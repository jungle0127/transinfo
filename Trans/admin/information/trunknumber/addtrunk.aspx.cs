using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using Trans.Biz.Common;
using System.Collections;
using Trans.DAL.Entity;
using Trans.DAL.Entity.USP;
using Trans.DAL.Dao.USP;
using Trans.DAL.IDao.USP;
using System.Text;

namespace Trans.admin.information.trunknumber
{
    public partial class addtrunk : Trans.App_Code.Biz.Common.SessionCheckPageBase
    {
        private ITrunktypeDao trunkTypeDao;
        private IVantypeDao vanTypeDao;
        private CityManager cityManager;
        private IUspInsertTrunkMetadataDao metaDataDao;
        private ITrunknumberprefixDao prefixDao;
        private ITrunknumberDao numberDao;
        public addtrunk() : base()
        {
            this.trunkTypeDao = new TrunktypeDao();
            this.vanTypeDao = new VantypeDao();
            this.cityManager = new CityManager();
            this.metaDataDao = new UspInsertTrunkMetadataDao();
            this.prefixDao = new TrunknumberprefixDao();
            this.numberDao = new TrunknumberDao();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.initProvince();
                this.initTrunktype();
                this.initVantype();
                this.initNumberPrefix();
                this.initNumberCityPrefix();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private UspInsertTrunkMetadata initTrunkMetaEntity()
        {
            string trunkImageFileName =  "~/licenseimage/trunk_" + DateTime.Now.ToFileTime();
            string licenseImageFileName = "~/licenseimage/license_" + DateTime.Now.ToFileTime();
            if (this.fileUploadTrunkImage.HasFile && this.fileUploadTrunkLicenceImage.HasFile)
            {
                this.fileUploadTrunkImage.SaveAs(Server.MapPath(trunkImageFileName));
                this.fileUploadTrunkLicenceImage.SaveAs(Server.MapPath(licenseImageFileName));
            }
            else
            {
                return null;
            }

            StringBuilder metadataXmlBuilder = new StringBuilder();
            metadataXmlBuilder.Append("<trunkmetadata>");

            metadataXmlBuilder.Append("<userid>"+base.UserId+"</userid>");
            metadataXmlBuilder.Append("<numberprefixid>"+this.ddlNumberPrefix.SelectedValue+"</numberprefixid>");
            metadataXmlBuilder.Append("<trunknumber>"+this.ddlNumberCityPrefix.SelectedItem.Text + " " + this.txtNumber.Text+"</trunknumber>");
            metadataXmlBuilder.Append("<length>"+this.txtTrunkLength.Text+"</length>");
            metadataXmlBuilder.Append("<weightcapacity>"+this.txtTrunkCapacity.Text+"</weightcapacity>");
            metadataXmlBuilder.Append("<volume>"+this.txtTrunkVolume.Text+"</volume>");
            metadataXmlBuilder.Append("<countycode>"+this.txtPlaceCode.Text+"</countycode>");
            metadataXmlBuilder.Append("<location>"+this.txtAddress.Text+"</location>");
            metadataXmlBuilder.Append("<vantypeid>"+this.ddlVanType.SelectedValue+"</vantypeid>");
            metadataXmlBuilder.Append("<brand>"+this.txtBrand.Text+"</brand>");
            metadataXmlBuilder.Append("<trunktypeid>"+this.ddlTrunkType.SelectedValue+"</trunktypeid>");
            metadataXmlBuilder.Append("<contactpersonname>"+this.txtContactPerson.Text+"</contactpersonname>");
            metadataXmlBuilder.Append("<contactphone>"+this.txtContactPerson.Text+"</contactphone>");
            metadataXmlBuilder.Append("<trunkidentifynumber>"+this.txtIdentificationCode.Text+"</trunkidentifynumber>");
            metadataXmlBuilder.Append("<vanimageuri>"+trunkImageFileName+"</vanimageuri>");
            metadataXmlBuilder.Append("<licenseuri>"+licenseImageFileName+"</licenseuri>");

            metadataXmlBuilder.Append("</trunkmetadata>");

            UspInsertTrunkMetadata metaData = new UspInsertTrunkMetadata();
            metaData.XmlData = metadataXmlBuilder.ToString();
            return metaData;
        }

        #region 下拉框

        private void initNumberPrefix()
        {
            this.ddlNumberPrefix.Items.Clear();
            this.ddlNumberPrefix.Items.Add(new ListItem("请选择...", "-1"));
            IList<Trunknumberprefix> prefixList = this.prefixDao.FindAll();
            foreach (Trunknumberprefix prefixPoco in prefixList)
            {
                this.ddlNumberPrefix.Items.Add(new ListItem(prefixPoco.Prefixname, prefixPoco.Id.ToString()));
            }
        }
        private void initNumberCityPrefix()
        {
            this.ddlNumberCityPrefix.Items.Clear();
            for (int i = 0; i < 26; i++)
            {
                this.ddlNumberCityPrefix.Items.Add(new ListItem(Convert.ToChar(65 + i).ToString(), "0"));
            }
        }

        private void initVantype()
        {
            IList<Vantype> vanTypeList = this.vanTypeDao.FindAll();
            this.ddlVanType.Items.Clear();
            this.ddlVanType.Items.Add(new ListItem("请选择...", "-1"));
            foreach (Vantype vanTypePoco in vanTypeList)
            {
                this.ddlVanType.Items.Add(new ListItem(vanTypePoco.Typename, vanTypePoco.Id.ToString()));
            }
        }
        private void initTrunktype()
        {
            IList<Trunktype> trunkTypeList = this.trunkTypeDao.FindAll();
            this.ddlTrunkType.Items.Clear();
            this.ddlTrunkType.Items.Add(new ListItem("请选择...", "-1"));
            foreach (Trunktype trunkTypePoco in trunkTypeList)
            {
                this.ddlTrunkType.Items.Add(new ListItem(trunkTypePoco.Typename, trunkTypePoco.Id.ToString()));
            }
        }
        //private void initTrunkNumber()
        //{
        //    IList<Vvehiclenumber> vehicleNumberList = this.vehicleNumberDao.FindByUserid(long.Parse(base.UserId));
        //    this.ddlTrunkNumber.Items.Clear();
        //    this.ddlTrunkNumber.Items.Add(new ListItem("请选择...", "-1"));
        //    foreach (Vvehiclenumber vehicleNumberPoco in vehicleNumberList)
        //    {
        //        this.ddlTrunkNumber.Items.Add(new ListItem(vehicleNumberPoco.Prefixname + vehicleNumberPoco.Number, vehicleNumberPoco.Id.ToString()));
        //    }

        //}
        #endregion

        #region 行政区划
        /// <summary>
        /// 省份
        /// </summary>
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
            this.txtPlaceCode.Text = this.ddlCounty.SelectedValue;
        }

        protected void ddlProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ddlCity.Items.Clear();
            this.ddlCounty.Items.Clear();
            this.ddlCity.Items.Add(new ListItem("请选择...", "-1"));
            this.ddlCounty.Items.Add(new ListItem("请选择...", "-1"));
            this.txtPlaceCode.Text = this.ddlProvince.SelectedValue;
            this.initCity(this.ddlCity, this.ddlProvince.SelectedValue);

        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ddlCounty.Items.Clear();
            this.ddlCounty.Items.Add(new ListItem("请选择...", "-1"));
            this.txtPlaceCode.Text = this.ddlCity.SelectedValue;
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
            this.metaDataDao.RunProc(this.initTrunkMetaEntity());
        }
    }
}