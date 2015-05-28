using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using Trans.DAL.Entity;
using log4net;

namespace Trans.admin.rightmanager
{
    public partial class rolemanagement : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(rolemanagement));
        private IRoleDao roleDao;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.roleDao = new RoleDao();
            logger.Info("role dao initiated done.");
            IList<Role> roleList = this.roleDao.FindAll();
            logger.Info("Got all the role entity");
            this.gvRole.DataSource = roleList;
            this.gvRole.DataBind();
            logger.Info("GridView data bind done.");
        }

        protected void gvRole_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editUpdate")
            {
                logger.Info("Redirect to role update page.");
                Response.Redirect("updaterolename.aspx?id=" + e.CommandArgument.ToString());
            }
            else if (e.CommandName == "delRole")
            {
                if (Request.Form["rtVal"].ToString().Substring(0, 4) == "true")
                {
                    this.roleDao.Delete(this.roleDao.Find(Int32.Parse(e.CommandArgument.ToString())));
                    logger.Info("Role with Id:" + e.CommandArgument.ToString() + " deleted.");
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("addrole.aspx");
        }

    }
}