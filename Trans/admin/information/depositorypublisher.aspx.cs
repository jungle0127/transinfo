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
using log4net;

namespace Trans.admin.information
{
    public partial class depositorypublisher : Trans.App_Code.Biz.Common.SessionCheckPageBase
    {
        private static ILog logger = LogManager.GetLogger(typeof(depositorypublisher));
        private CityManager cityManager;
        private IBussinessscopeDao bizScopeDao;
        private IDepottypeDao depotTypeDao;
        private IDepotinformationDao depotInfoDao;
        public depositorypublisher() : base()
        {
            this.bizScopeDao = new BussinessscopeDao();
            this.depotTypeDao = new DepottypeDao();
            this.depotInfoDao = new DepotinformationDao();
            this.cityManager = new CityManager();
            logger.Info("Constructor method done.");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.initBizScopeList();
                logger.Info("Biz scope dropdownlist inited doen.");
                this.initDepotType();
                logger.Info("Depository dropdownlist inited done.");
                this.initProvince();
                logger.Info("Province dropdownlist inited done.");
            }
            logger.Info("Page loaded done.");
        }
        #region 初始化下拉框
        /// <summary>
        /// 经营范围
        /// </summary>
        private void initBizScopeList()
        {
            this.ddlBizScope.Items.Clear();
            this.ddlBizScope.Items.Add(new ListItem("请选择...", "-1"));
            IList<Bussinessscope> bizScopeList = this.bizScopeDao.FindAll();
            foreach (Bussinessscope bizScopePoco in bizScopeList)
            {
                this.ddlBizScope.Items.Add(new ListItem(bizScopePoco.Scopename, bizScopePoco.Id.ToString()));
            }
        }

        private void initDepotType()
        {
            this.ddlDepotType.Items.ToString();
            this.ddlDepotType.Items.Add(new ListItem("请选择...", "-1"));
            IList<Depottype> depotTypeList = this.depotTypeDao.FindAll();
            foreach (Depottype depotTypePoco in depotTypeList)
            {
                this.ddlDepotType.Items.Add(new ListItem(depotTypePoco.Typename, depotTypePoco.Id.ToString()));
            }
        }

        #endregion

        #region 行政区初始化
        private void initProvince()
        {
            this.ddlProvince.Items.Clear();
            this.ddlCity.Items.Clear();
            this.ddlCounty.Items.Clear();
            this.ddlProvince.Items.Add(new ListItem("请选择...", "-1"));
            this.ddlCity.Items.Add(new ListItem("请选择...", "-1"));
            this.ddlCounty.Items.Add(new ListItem("请选择...", "-1"));
            Hashtable provinceMap = this.cityManager.getAllProvince();
            foreach (DictionaryEntry de in provinceMap)
            {
                this.ddlProvince.Items.Add(new ListItem(de.Value.ToString(), de.Key.ToString()));
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                this.depotInfoDao.Insert(this.loadEntity());
                logger.Info("Depository information inserted doen.");
            }
            catch (Exception ex)
            {
                logger.Error("Depository information inserted with exception:" + ex.Message);
            }
            
        }

        private Depotinformation loadEntity()
        {
            Depotinformation depotInfoEntity = new Depotinformation();
            depotInfoEntity.Address = this.txtAddress.Text;
            
            depotInfoEntity.Area = int.Parse(this.txtArea.Text);
            depotInfoEntity.Bizscopetype = long.Parse(this.ddlBizScope.SelectedValue);
            depotInfoEntity.Cellphone = this.txtPhone.Text;
            depotInfoEntity.Contactperson = this.txtContactPerson.Text;
            depotInfoEntity.Depottype = long.Parse(this.ddlDepotType.SelectedValue);
            depotInfoEntity.Description = this.txtNote.Text;
            depotInfoEntity.Price = this.txtPrice.Text;
            depotInfoEntity.Title = this.txtTitle.Text;
            depotInfoEntity.Useablearea = int.Parse(this.txtUseableArea.Text);
            depotInfoEntity.Validtime = this.txtValidTime.Text;
            depotInfoEntity.Userid = long.Parse(base.UserId);
            depotInfoEntity.Countycode = this.txtSrcPlaceCode.Text;
            logger.Info("Information loaded done.");
            return depotInfoEntity;
        }

        protected void txtValidCalendar_SelectionChanged(object sender, EventArgs e)
        {
            this.txtValidTime.Text = this.txtValidCalendar.SelectedDate.ToShortDateString();
            this.calendar.Visible = false;
            this.txtValidTime.Focus();
        }

        protected void ImageButton_Click(object sender, ImageClickEventArgs e)
        {
            this.calendar.Visible = !this.calendar.Visible;
        }

    }
}