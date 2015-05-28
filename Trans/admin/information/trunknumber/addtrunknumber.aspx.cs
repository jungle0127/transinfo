using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using Trans.DAL.Entity;

namespace Trans.admin.information.trunknumber
{
    public partial class addtrunknumber : Trans.App_Code.Biz.Common.SessionCheckPageBase
    {
        private ITrunknumberprefixDao prefixDao;
        private ITrunknumberDao numberDao;
        public addtrunknumber() : base()
        {
            this.prefixDao = new TrunknumberprefixDao();
            this.numberDao = new TrunknumberDao();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.initNumberPrefix();
                this.initNumberCityPrefix();
            }
        }

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
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Trunknumber numberPoco = new Trunknumber();
            numberPoco.Number = this.ddlNumberCityPrefix.SelectedItem.Text + " " + this.txtNumber.Text;
            numberPoco.Prefixid = long.Parse(this.ddlNumberPrefix.SelectedValue);
            numberPoco.Userid = long.Parse(base.UserId);
            numberPoco.Active = 1;
            this.numberDao.Insert(numberPoco);
            Response.Redirect("addtrunk.aspx");
        }
    }
}