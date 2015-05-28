using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using Trans.DAL.Entity;
using log4net;
using Trans.Biz.Common;
using System.Collections;

namespace Trans.admin.information
{
    public partial class goodssourcepublisher : Trans.App_Code.Biz.Common.SessionCheckPageBase
    {
        private static ILog logger = LogManager.GetLogger(typeof(goodssourcepublisher));
        private IGoodssourceinformationDao goodsSourceInfoDao;
        private IGoodstypeDao goodsTypeDao;
        private ITransporttypeDao transportTypeDao;
        private ICautiontypeDao cautionTypeDao;
        private CityManager cityManager = new CityManager();
        public goodssourcepublisher() : base()
        {
            this.goodsSourceInfoDao = new GoodssourceinformationDao();
            this.goodsTypeDao = new GoodstypeDao();
            this.transportTypeDao = new TransporttypeDao();
            this.cautionTypeDao = new CautiontypeDao();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.initCautionType();
                this.initGoodstype();
                this.initTransportType();
                this.initProvince();
            }
        }
        #region 下拉框初始化
        /// <summary>
        /// 货物类型
        /// </summary>
        private void initGoodstype()
        {
            IList<Goodstype> goodsTypeList = this.goodsTypeDao.FindAll();
            this.ddlGoodsType.Items.Clear();
            this.ddlGoodsType.Items.Add(new ListItem("请选择...", "-1"));
            foreach (Goodstype goodsTypePoco in goodsTypeList)
            {
                this.ddlGoodsType.Items.Add(new ListItem(goodsTypePoco.Typename, goodsTypePoco.Id.ToString()));
            }
 
        }
        /// <summary>
        /// 运输类型
        /// </summary>
        private void initTransportType()
        {
            this.ddlTransportType.Items.Clear();
            this.ddlTransportType.Items.Add(new ListItem("请选择...", "-1"));
            IList<Transporttype> transportTypeList = this.transportTypeDao.FindAll();
            foreach (Transporttype transportTypePoco in transportTypeList)
            {
                this.ddlTransportType.Items.Add(new ListItem(transportTypePoco.Typename,transportTypePoco.Id.ToString()));
            }
        }
        /// <summary>
        /// 注意事项
        /// </summary>
        private void initCautionType()
        {
            this.ddlCautionType.Items.Clear();
            this.ddlCautionType.Items.Add(new ListItem("请选择...", "-1"));
            IList<Cautiontype> cautionTypeList = this.cautionTypeDao.FindAll();
            foreach (Cautiontype cautionTypePoco in cautionTypeList)
            {
                this.ddlCautionType.Items.Add(new ListItem(cautionTypePoco.Typename, cautionTypePoco.Id.ToString()));
            }
        }
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

        #region 日期控件 
        protected void ImageButton_Click(object sender, ImageClickEventArgs e)
        {
            this.calendar.Visible = !this.calendar.Visible;
        }

        protected void txtValidCalendar_SelectionChanged(object sender, EventArgs e)
        {
            this.txtValidTime.Text = this.txtValidCalendar.SelectedDate.ToShortDateString();
            this.calendar.Visible = false;
            this.txtValidTime.Focus();
        }
        #endregion


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            this.goodsSourceInfoDao.Insert(this.loadGoodsSourceInfoPoco());
        }

        private Goodssourceinformation loadGoodsSourceInfoPoco()
        {
            Goodssourceinformation goodsSourceInfoPoco = new Goodssourceinformation();

            goodsSourceInfoPoco.Active = 1;
            goodsSourceInfoPoco.Cautiontypeid = long.Parse(this.ddlCautionType.SelectedValue);
            goodsSourceInfoPoco.Content = this.txtGoodsInfo.Text;
            goodsSourceInfoPoco.Deadline = DateTime.Parse(this.txtValidTime.Text);
            goodsSourceInfoPoco.Dstcountycode = this.txtDstPlaceCode.Text;
            goodsSourceInfoPoco.Srccountycode = this.txtSrcPlaceCode.Text;
            goodsSourceInfoPoco.Title = this.txtTitle.Text;
            goodsSourceInfoPoco.Transporttypeid = long.Parse(this.ddlTransportType.SelectedValue);
            goodsSourceInfoPoco.Price = this.txtPrice.Text;
            goodsSourceInfoPoco.Goodsname = this.txtGoodsName.Text;
            goodsSourceInfoPoco.Goodstypeid = long.Parse(this.ddlGoodsType.SelectedValue);
            goodsSourceInfoPoco.Userid = long.Parse(base.UserId);
            goodsSourceInfoPoco.Releasedate = DateTime.Now;

            return goodsSourceInfoPoco;
        }
    }
}