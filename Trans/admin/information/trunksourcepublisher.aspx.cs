using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using Trans.DAL.Entity;
using System.Collections;
using Trans.Biz.Common;
using log4net;

namespace Trans.admin.information
{
    public partial class trunksourcepublisher : Trans.App_Code.Biz.Common.SessionCheckPageBase
    {
        private static ILog logger = LogManager.GetLogger(typeof(trunksourcepublisher));

        private IVvehiclenumberDao vehicleNumberDao;
        private ITrunkreturntypeDao trunkReturnTypeDao;
        private ITrunkroutetypeDao trunkRouteTypeDao;
        private ITrunktimetypeDao trunkTimeTypeDao;
        private CityManager cityManager;
        private ITrunkinformationDao trunkInformationDao;
        public trunksourcepublisher() : base()
        {
            this.vehicleNumberDao = new VvehiclenumberDao();
            this.trunkReturnTypeDao = new TrunkreturntypeDao();
            this.trunkRouteTypeDao = new TrunkroutetypeDao();
            this.trunkTimeTypeDao = new TrunktimetypeDao();
            this.trunkInformationDao = new TrunkinformationDao();
            this.cityManager = new CityManager();
            logger.Info("Constructor method init done.");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.initReturnType();
                logger.Info("Inited return type dropdownlist.");
                this.initRouteType();
                logger.Info("Inited route type dropdownlist.");
                this.initTimeType();
                logger.Info("Inited time type dropdownlist.");
                this.initTrunkNumber();
                logger.Info("Inited trunk number dropdownlist.");
                this.initProvince();
                logger.Info("Inited province dropdownlist.");
            }
            logger.Info("Page load done.");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                this.trunkInformationDao.Insert(this.loadEntity());
                logger.Info("Trunk information inserted.");
            }
            catch (Exception ex)
            {
                logger.Error("Trunk information inserted failed with exception:" + ex.Message);
            }
        }

        private Trunkinformation loadEntity()
        {
            Trunkinformation trunkInformationEntity = new Trunkinformation();

            trunkInformationEntity.Active = 1;
            trunkInformationEntity.Description = this.txtDescription.Text;
            trunkInformationEntity.Dstcountycode = this.txtDstPlaceCode.Text;
            trunkInformationEntity.Marketprice = this.txtPrice.Text;
            trunkInformationEntity.Negotiateprice = this.txtNegotiatePrice.Text;
            trunkInformationEntity.Releasedate = DateTime.Now;
            trunkInformationEntity.Returntypeid = long.Parse(this.ddlReturnType.SelectedValue);
            trunkInformationEntity.Router = this.txtRouter.Text;
            trunkInformationEntity.Routetypeid = long.Parse(this.ddlRouteType.SelectedValue);
            trunkInformationEntity.Srccountycode = this.txtSrcPlaceCode.Text;
            trunkInformationEntity.Takeofftime = DateTime.Parse(this.txtTakeOffTime.Text);
            trunkInformationEntity.Timetypeid = long.Parse(this.ddlTimeType.SelectedValue);
            trunkInformationEntity.Title = this.txtTitle.Text;
            trunkInformationEntity.Trunkid = long.Parse(this.ddlTrunk.SelectedValue);
            trunkInformationEntity.Userid = long.Parse(base.UserId);
            logger.Info("Information wrapped done.");
            return trunkInformationEntity;
        }

        #region 初始化下拉框
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
       
        /// <summary>
        /// 初始化车牌
        /// </summary>
        private void initTrunkNumber()
        {
            this.ddlTrunk.Items.Clear();
            this.ddlTrunk.Items.Add(new ListItem("请选择...", "-1"));
            IList<Vvehiclenumber> vehicleNumberList = this.vehicleNumberDao.FindAll();
            foreach (Vvehiclenumber trunkNumberPoco in vehicleNumberList)
            {
                this.ddlTrunk.Items.Add(new ListItem(trunkNumberPoco.Prefixname + trunkNumberPoco.Number, trunkNumberPoco.Id.ToString()));
            }
        }
        /// <summary>
        /// 初始化返程类型
        /// 本地车；返程程；
        /// </summary>
        private void initRouteType()
        {
            this.ddlRouteType.Items.Clear();
            this.ddlRouteType.Items.Add(new ListItem("请选择...", "-1"));
            IList<Trunkroutetype> trunkRouteList = this.trunkRouteTypeDao.FindAll();
            foreach (Trunkroutetype trunkRoutePoco in trunkRouteList)
            {
                this.ddlRouteType.Items.Add(new ListItem(trunkRoutePoco.Typename, trunkRoutePoco.Id.ToString()));
            }
        }
        /// <summary>
        /// 初始化返程类型
        /// 单程，返程
        /// </summary>
        private void initReturnType()
        {
            this.ddlReturnType.Items.Clear();
            this.ddlReturnType.Items.Add(new ListItem("请选择...", "-1"));
            IList<Trunkreturntype> returnTypeList = this.trunkReturnTypeDao.FindAll();
            foreach (Trunkreturntype returnTypePoco in returnTypeList)
            {
                this.ddlReturnType.Items.Add(new ListItem(returnTypePoco.Typename, returnTypePoco.Id.ToString()));
            }
        }
        /// <summary>
        /// 初始化车源时间类型
        /// </summary>
        private void initTimeType()
        {
            this.ddlTimeType.Items.Clear();
            this.ddlTimeType.Items.Add(new ListItem("请选择...", "-1"));
            IList<Trunktimetype> timeTypeList = this.trunkTimeTypeDao.FindAll();
            foreach (Trunktimetype timeTypePoco in timeTypeList)
            {
                this.ddlTimeType.Items.Add(new ListItem(timeTypePoco.Typename, timeTypePoco.Id.ToString()));
            }
        }
        #endregion

        #region 行政区初始化
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

        protected void ImageButton_Click(object sender, ImageClickEventArgs e)
        {
            this.calendar.Visible = !this.calendar.Visible;
        }

        protected void txtTakeOffCalendar_SelectionChanged(object sender, EventArgs e)
        {
            this.txtTakeOffTime.Text = this.txtTakeOffCalendar.SelectedDate.ToShortDateString();
            this.calendar.Visible = false;
            this.txtTakeOffTime.Focus();
        }

    }
}