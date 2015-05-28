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
    public partial class usermanagement : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(usermanagement));
        private IUsersDao usersDao;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.usersDao = new UsersDao();
            IList<Users> userList = this.usersDao.FindAll();
            this.gvUser.DataSource = userList;
            this.gvUser.DataBind();
        }

        protected void gvUser_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editUpdate")
            {
                logger.Info("Redirect to user update page.");
                Response.Redirect("updateuser.aspx?id=" + e.CommandArgument.ToString());
            }
            else if (e.CommandName == "delUser")
            {
                if (Request.Form["rtVal"].ToString().Substring(0, 4) == "true")
                {
                    Response.Write("DEL:" + e.CommandArgument.ToString());
                    logger.Info("Role with Id:" + e.CommandArgument.ToString() + " deleted.");
                }
            }
        }
    }
}