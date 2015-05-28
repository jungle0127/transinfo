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
    public partial class updateuser : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(updateuser));
        private IRoleDao roleDao;
        private IUsersDao userDao;
        private Users userEntity;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.roleDao = new RoleDao();
            this.userDao = new UsersDao();
            IList<Role> roleList = this.roleDao.FindAll();
            string userId = Request.QueryString["id"];
            this.userEntity = this.userDao.Find(Int64.Parse(userId));
            this.txtLoginName.Text = this.userEntity.Loginname;
            this.txtUserName.Text = this.userEntity.Username;

            if (!IsPostBack)
            {
                this.ddlRole.Items.Clear();
                this.ddlRole.Items.Add(new ListItem("请选择...","-1"));
                foreach (Role roleEntity in roleList)
                {
                    ListItem roleItem = new ListItem();
                    roleItem.Text = roleEntity.Rolename;
                    roleItem.Value = roleEntity.Id.ToString();
                    this.ddlRole.Items.Add(roleItem);
                    if (roleItem.Value == this.userEntity.Roleid.ToString())
                    {
                        roleItem.Selected = true;
                    }
                    
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            this.userEntity.Roleid = Int64.Parse(this.ddlRole.SelectedValue);
            this.userDao.Update(this.userEntity);
        }

        protected void btnUpdatePwd_Click(object sender, EventArgs e)
        {

        }
    }
}