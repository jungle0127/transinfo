﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Entity;
using System.Text;
using Trans.DAL.Dao;
using log4net;
using Trans.InfoList;
using System.Collections;
using Trans.Biz.Common;
using Trans.Biz.ResourceStatistic;


namespace Trans.InfoList
{
    public partial class SpeciallineInfoList : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(SpeciallineInfoList));
        private CityManager cityManager;
        private Statistic statistic;
        private string totalLorry;

        public string TotalLorry
        {
            get { return totalLorry; }
        }
        private string totalGoods;

        public string TotalGoods
        {
            get { return totalGoods; }
        }

        public SpeciallineInfoList()
        {
            this.cityManager = new CityManager();
            this.statistic = new Statistic();
            this.totalLorry = this.statistic.TotalLorry;
            this.totalGoods = this.statistic.TotalGoods;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.initProvince();
            }
        }

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
            ScriptManager.RegisterStartupScript(this.updatePanelLocatedPlace, this.GetType(),"", "<script type=text/javascript>alert('1');test();alert('2');</script>", true);
            
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