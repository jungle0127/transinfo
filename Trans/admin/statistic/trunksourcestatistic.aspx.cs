using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.Biz.Common;
using System.Collections;
using log4net;
using Trans.DAL.Dao;

namespace Trans.admin.statistic
{
    public partial class trunksourcestatistic : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(trunksourcestatistic));
        private CityManager cityManager = new CityManager();
        private ITrunkinformationDao tiDao = new TrunkinformationDao();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write(tiDao.GetCount());
                this.DropDownList1.Items.Clear();
                Hashtable provinceMap = this.cityManager.getAllProvince();
                foreach (string provinceCode in provinceMap.Keys)
                {
                    this.DropDownList1.Items.Add(new ListItem(provinceMap[provinceCode].ToString(), provinceCode));
                }
                logger.Info("Province initiated down.");
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info("Province dropdownlist changed.");
            this.DropDownList2.Items.Clear();
            Hashtable cityMap = this.cityManager.getCityByProvinceCode(this.DropDownList1.SelectedValue);
            foreach (string cityCode in cityMap.Keys)
            {
                this.DropDownList2.Items.Add(new ListItem(cityMap[cityCode].ToString(), cityCode));
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DropDownList3.Items.Clear();
            Hashtable countyMap = this.cityManager.getCountyByCityCode(this.DropDownList2.SelectedValue);
            foreach (string countyCode in countyMap.Keys)
            {
                this.DropDownList3.Items.Add(new ListItem(countyMap[countyCode].ToString(), countyCode));
            }
        }

    }
}