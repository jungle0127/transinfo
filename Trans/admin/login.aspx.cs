using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using Trans.DAL.Entity;

namespace Trans.admin
{
    public partial class login : System.Web.UI.Page
    {
        private IUsersDao usersDao;
        public login()
        {
            this.usersDao = new UsersDao();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //IList<Users> userList = this.usersDao.FindByLoginname(this.txtLoginName.Text);
            //Users userPoco = userList[0];
            //Response.Write(userPoco.Loginname);
            //Response.Write(userPoco.Password);

            Session["username"] = "admin";
            Session["userid"] = "1";
            Session["roleid"] = "1";
            Response.Redirect("MainFrame.aspx");
        }
    }
}