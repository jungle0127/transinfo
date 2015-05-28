using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;
using Trans.DAL.Dao;
using Trans.DAL.Entity;

namespace Trans.admin.rightmanager
{
    public partial class updaterolename : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(updaterolename));
        private IRoleDao roleDao;
        private Role roleEnity;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.roleDao = new RoleDao();
            logger.Info("RoleDao initiated done.");
            string roleId = Request.QueryString["id"];
            logger.Info("Got the roleId of the role that name will be updated.");
            this.roleEnity = this.roleDao.Find(Int32.Parse(roleId));
            logger.Info("Got the role entity by id");
            if (!IsPostBack)
            {
                this.txtRoleName.Text = this.roleEnity.Rolename;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            this.roleEnity.Rolename = this.txtRoleName.Text;
            this.roleDao.Update(this.roleEnity);
            logger.Info(this.roleEnity.Rolename);
            logger.Info("role name updated done as:" + this.txtRoleName.Text);
            Response.Redirect("rolemanagement.aspx");
        }

    }
}