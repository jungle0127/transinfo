using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using Trans.DAL.Entity;

namespace Trans.admin.personalinfo
{
    public partial class updatepwd : System.Web.UI.Page
    {
        private IUsersDao usersDao;
        public updatepwd()
        {
            this.usersDao = new UsersDao();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
               Users userPoco = this.usersDao.Find(1);
               
               Response.Write(userPoco.Id);
               Response.Write("<br/>");
               Response.Write(userPoco.Username);

        }
    }
}