using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Trans.App_Code.Biz.Common
{
    public class SessionCheckPageBase : Page
    {
        private string userId;

        public string UserId
        {
            get { return userId; }
        }
        private string roleId;

        public string RoleId
        {
            get { return roleId; }
        }
        private string userName;

        public string UserName
        {
            get { return userName; }
        }

        public SessionCheckPageBase()
        {
            //this.Load += new EventHandler(this.BaseLoad);
            this.roleId = "1";
            this.userId = "1";
            this.userName = "ps";
        }
        private void BaseLoad(object sender,EventArgs e)
        {
            if (null == Session["userid"] || null == Session["roleid"] || null == Session["username"])
            {
                Response.Redirect("~/admin/login.aspx");
            }
            else
            {
                this.userId = Session["userid"].ToString();
                this.roleId = Session["roleid"].ToString();
                this.userName = Session["userName"].ToString();
            }
        }
    }
}