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
    public partial class addrole : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(addrole));
        private IRoleDao roleDao;
        private Role roleEntity;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.roleDao = new RoleDao();
            this.roleEntity = new Role();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            this.roleEntity.Active = 1;
            this.roleEntity.Rolename = this.txtRoleName.Text;
            this.roleDao.Insert(this.roleEntity);
            logger.Info("New role added with name:" + this.txtRoleName.Text);
            Response.Redirect("rolemanagement.aspx");
        }
    }
}