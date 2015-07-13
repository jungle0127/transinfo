using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using log4net;

namespace Trans.App_Code.Biz.Common
{
    public class SessionCheckPageBase : Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(SessionCheckPageBase));
        #region Property
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
        #endregion
        public SessionCheckPageBase()
        {
            this.Load += new EventHandler(this.BaseLoad);
        }
        private void BaseLoad(object sender,EventArgs e)
        {
            if (null == Session["userid"] || null == Session["roleid"] || null == Session["username"])
            {
                Response.Redirect("~/admin/login.aspx");
                logger.Info("Can not get user information.");
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