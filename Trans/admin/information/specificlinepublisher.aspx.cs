using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Trans.Biz.Common;
using Trans.DAL.Dao;
using Trans.DAL.Entity;
using Trans.DAL.IDao.USP;
using Trans.DAL.Dao.USP;
using System.Text;
using Trans.DAL.Entity.USP;
using log4net;

namespace Trans.admin.information
{
    public partial class specificlinepublisher : Trans.App_Code.Biz.Common.SessionCheckPageBase
    {
        private static ILog logger = LogManager.GetLogger(typeof(specificlinepublisher));
        private CityManager cityManager;
        private ISpeciallinetypeDao lineTypeDao;
        private IDeparturetypeDao departureTypeDao;
        private IUspInsertSpecialineDataDao uspInsertDao;
        public specificlinepublisher() : base()
        {
            this.cityManager = new CityManager();
            this.lineTypeDao = new SpeciallinetypeDao();
            this.departureTypeDao = new DeparturetypeDao();
            this.uspInsertDao = new UspInsertSpecialineDataDao();
            logger.Info("Constructor method done.");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.initProvince();
                this.initSpecialLineType();
                this.initDepartureType();
                logger.Info("Dropdownlist inited done.");
            }
            logger.Info("Page loaded done.");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                UspInsertSpecialineData uspParamData = new UspInsertSpecialineData();
                uspParamData.XmlData = this.loadInfoXML();
                logger.Info("Specialline information with XML style will be inserted:" + uspParamData.XmlData);
                this.uspInsertDao.RunProc(uspParamData);
                logger.Info("Specialline information inserted done.");
                Response.Redirect("../InformationManager/SpeciallineList.aspx");
            }
            catch (Exception Ex)
            {
                logger.Error("Specialline information inserted failed with excpetion:" + Ex.Message);
            }
        }

        private string loadInfoXML()
        {
            StringBuilder xmlBuilder = new StringBuilder();

            xmlBuilder.Append("<speciallinedata>");
            xmlBuilder.Append("<userid>" + base.UserId + "</userid>");
            xmlBuilder.Append("<title>" + this.txtTitle.Text + "</title>");
            xmlBuilder.Append("<srcaddress>" + this.txtSrcAddress.Text + "</srcaddress>");
            xmlBuilder.Append("<srccontactperson>" + this.txtSrcContactPerson.Text + "</srccontactperson>");
            xmlBuilder.Append("<srccontactcellphone>" + this.txtCellPhone.Text + "</srccontactcellphone>");
            xmlBuilder.Append("<srccontactphone>" + this.txtPhone.Text + "</srccontactphone>");
            xmlBuilder.Append("<srccountycode>" + this.txtSrcPlaceCode.Text + "</srccountycode>");
            xmlBuilder.Append("<dstaddress>" + this.txtDstAddress.Text + "</dstaddress>");
            xmlBuilder.Append("<dstcontactperson>" + this.txtDstContactPerson.Text + "</dstcontactperson>");
            xmlBuilder.Append("<dstcontactcellphone>" + this.txtDstCellPhone.Text + "</dstcontactcellphone>");
            xmlBuilder.Append("<dstcontactphone>" + this.txtDstPhone.Text + "</dstcontactphone>");
            xmlBuilder.Append("<dstcountycode>" + this.txtDstPlaceCode.Text + "</dstcountycode>");
            xmlBuilder.Append("<weightprice>" + this.txtWeightPrice.Text + "</weightprice>");
            xmlBuilder.Append("<volumeprice>" + this.txtVolumePrice.Text + "</volumeprice>");
            xmlBuilder.Append("<departuretypeid>" + this.ddlDepartureType.SelectedValue + "</departuretypeid>");
            xmlBuilder.Append("<speciallinetypeid>" + this.ddlLinetype.SelectedValue + "</speciallinetypeid>");
            xmlBuilder.Append("<description>" + this.txtDescription.Text + "</description>");
            xmlBuilder.Append("</speciallinedata>");
            logger.Info("Specialline built done.");
            return xmlBuilder.ToString();
        }


        #region 下拉框初始化
        /// <summary>
        /// 单往返类型
        /// </summary>
        private void initSpecialLineType()
        {
            IList<Speciallinetype> lineTypeList = this.lineTypeDao.FindAll();
            this.ddlLinetype.Items.Clear();
            this.ddlLinetype.Items.Add(new ListItem("请选择...", "-1"));
                
            foreach (Speciallinetype lineTypePoco in lineTypeList)
            {
                this.ddlLinetype.Items.Add(new ListItem(lineTypePoco.Typename, lineTypePoco.Id.ToString()));
            }
        }
        /// <summary>
        /// 发车时间类型
        /// </summary>
        private void initDepartureType()
        {
            this.ddlDepartureType.Items.Clear();
            this.ddlDepartureType.Items.Add(new ListItem("请选择...", "-1"));
            IList<Departuretype> departureTypeList = this.departureTypeDao.FindAll();
            foreach (Departuretype departureTypePoco in departureTypeList)
            {
                this.ddlDepartureType.Items.Add(new ListItem(departureTypePoco.Typename, departureTypePoco.Id.ToString()));
            }
        }
        #endregion

        #region 行政区初始化
        /// <summary>
        /// 省份
        /// </summary>
        private void initProvince()
        {
            this.ddlProvince.Items.Clear();
            this.ddlProvinceDst.Items.Clear();
            this.ddlCityDst.Items.Clear();
            this.ddlCity.Items.Clear();
            this.ddlCountyDst.Items.Clear();
            this.ddlCounty.Items.Clear();
            this.ddlProvinceDst.Items.Add(new ListItem("请选择...", "-1"));
            this.ddlProvince.Items.Add(new ListItem("请选择...", "-1"));
            this.ddlCity.Items.Add(new ListItem("请选择...", "-1"));
            this.ddlCityDst.Items.Add(new ListItem("请选择...", "-1"));
            this.ddlCounty.Items.Add(new ListItem("请选择...", "-1"));
            this.ddlCountyDst.Items.Add(new ListItem("请选择...", "-1"));
            Hashtable provinceMap = this.cityManager.getAllProvince();
            foreach (DictionaryEntry de in provinceMap)
            {
                this.ddlProvince.Items.Add(new ListItem(de.Value.ToString(), de.Key.ToString()));
                this.ddlProvinceDst.Items.Add(new ListItem(de.Value.ToString(), de.Key.ToString()));
            }
        }

        protected void ddlCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtSrcPlaceCode.Text = this.ddlCounty.SelectedValue;
        }

        protected void ddlProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ddlCity.Items.Clear();
            this.ddlCounty.Items.Clear();
            this.ddlCity.Items.Add(new ListItem("请选择...", "-1"));
            this.ddlCounty.Items.Add(new ListItem("请选择...", "-1"));
            this.txtSrcPlaceCode.Text = this.ddlProvince.SelectedValue;
            this.initCity(this.ddlCity, this.ddlProvince.SelectedValue);

        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ddlCounty.Items.Clear();
            this.ddlCounty.Items.Add(new ListItem("请选择...", "-1"));
            this.txtSrcPlaceCode.Text = this.ddlCity.SelectedValue;
            this.initCounty(this.ddlCounty, this.ddlCity.SelectedValue);

        }

        protected void ddlProvinceDst_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ddlCityDst.Items.Clear();
            this.ddlCountyDst.Items.Clear();
            this.ddlCityDst.Items.Add(new ListItem("请选择...", "-1"));
            this.ddlCountyDst.Items.Add(new ListItem("请选择...", "-1"));
            this.txtDstPlaceCode.Text = this.ddlProvinceDst.SelectedValue;
            this.initCity(this.ddlCityDst, this.ddlProvinceDst.SelectedValue);

        }

        protected void ddlCityDst_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ddlCountyDst.Items.Clear();
            this.ddlCountyDst.Items.Add(new ListItem("请选择...", "-1"));
            this.txtDstPlaceCode.Text = this.ddlCityDst.SelectedValue;
            this.initCounty(this.ddlCountyDst, this.ddlCityDst.SelectedValue);

        }

        protected void ddlCountyDst_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtDstPlaceCode.Text = this.ddlCountyDst.SelectedValue;
        }

        private void initCity(DropDownList ddl, string provinceCode)
        {
            Hashtable cityMap = this.cityManager.getCityByProvinceCode(provinceCode);
            foreach (DictionaryEntry de in cityMap)
            {
                ddl.Items.Add(new ListItem(de.Value.ToString(), de.Key.ToString()));
            }
        }
        private void initCounty(DropDownList ddl, string cityCode)
        {
            Hashtable countyMap = this.cityManager.getCountyByCityCode(cityCode);
            foreach (DictionaryEntry de in countyMap)
            {
                ddl.Items.Add(new ListItem(de.Value.ToString(), de.Key.ToString()));
            }
        }

        #endregion

    }
}