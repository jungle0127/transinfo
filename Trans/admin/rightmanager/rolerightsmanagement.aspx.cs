using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using Common.Logging;
using Trans.DAL.Entity;
using Trans.Biz.Right;
using System.Collections;
using Trans.App_Code.Biz.Common;
using System.Text;
using Trans.DAL.IDao.USP;
using Trans.DAL.Dao.USP;
using Trans.DAL.Entity.USP;

namespace Trans.admin.rightmanager
{
    public partial class rolerightsmanagement : SessionCheckPageBase
    {
        private static ILog logger = LogManager.GetLogger(typeof(rolerightsmanagement));
        private IRightManager rightManager;
        private IVuserrightsDao userRightsDao;
        private IRoleDao roleDao;
        public rolerightsmanagement() : base()
        {
            logger.Info("Begin constructor method.");
            this.rightManager = new RightManager();
            logger.Info("rightmanager init done.");
            this.userRightsDao = new VuserrightsDao();
            logger.Info("vuserrightsdao view dao init done.");
            this.roleDao = new RoleDao();
            logger.Info("Role dao init done.");
            logger.Info("Constructor method end.");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.initRoleList();
            }
            logger.Info("Page loaded done.");
        }

        private void initRights(string roleId)
        {
            logger.Info("Begin init rights of role.");
            Hashtable rightGroupMap = this.rightManager.getRightGroupMap();
            logger.Info("Got right group information with count:" + rightGroupMap.Count.ToString());
            IList<long> roleRightIdList = this.rightManager.getRightIdListByRoleId(Int16.Parse(roleId));
            IList<RightsInfo> rightInfoList = this.rightManager.getRightsFullInfo();
            foreach (RightsInfo rightsInfo in rightInfoList)
            {
                Label rightGroupLabel = new Label();
                Rightgroup rightGroup = rightGroupMap[rightsInfo.RightGroup.Id] as Rightgroup;
                rightGroupLabel.Text = rightGroup.Groupname;
                rightGroupLabel.ID = "lb_gp_" + rightsInfo.RightGroup.Id.ToString();
                this.rightPanel.Controls.Add(rightGroupLabel);
                Literal lineBreak = new Literal();
                lineBreak.Text = "<br/>";
                this.rightPanel.Controls.Add(lineBreak);
                foreach (Rights rightEntity in rightsInfo.RightList)
                {
                    CheckBox cb = new CheckBox();
                    cb.Text = rightEntity.Rightname;
                    cb.ID = "cb_rt_" + rightEntity.Id.ToString();
                    if (roleRightIdList.Contains(rightEntity.Id))
                        cb.Checked = true;
                    this.rightPanel.Controls.Add(cb);
                }
                //this.rightPanel.Controls.Add(lineBreak);
                Literal lineDoubleBreak = new Literal();
                lineDoubleBreak.Text = "<br/><br/>";
                this.rightPanel.Controls.Add(lineDoubleBreak);
            }
            Button btnSubmit = new Button();
            btnSubmit.Text = "提交";
            btnSubmit.ID = "btnSubmit";
            btnSubmit.CssClass = "btn";
            btnSubmit.Click += new EventHandler(btnSubmit_Click);
            logger.Info("Rights of role init done.");
            this.rightPanel.Controls.Add(btnSubmit);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            IUspUpdateRoleHasRightsDao updateRoleRightsDao = new UspUpdateRoleHasRightsDao();
            UspUpdateRoleHasRights roleRightsPoco = new UspUpdateRoleHasRights();
            roleRightsPoco.XmlData = this.prepareUSPParam();
            logger.Info("Parameter for run procedure:UspUpdateRoleHasRights listed below:");
            logger.Info(roleRightsPoco.XmlData);
            updateRoleRightsDao.RunProc(roleRightsPoco);
        }

        private string prepareUSPParam()
        {
            StringBuilder rightBuilder = new StringBuilder();
            rightBuilder.Append("<rights>");
            rightBuilder.Append("<roleid>" + this.ddlRole.SelectedValue + "</roleid>");
            foreach (Control control in this.rightPanel.Controls)
            {
                if (control.ID != null && control.ID.Contains("cb_rt"))
                {
                    CheckBox rightCheckBox = control as CheckBox;
                    if (rightCheckBox.Checked)
                    {
                        rightBuilder.Append("<rightid>" + this.getRightIdByCBId(rightCheckBox.ID) + "</rightid>");
                    }
                }
            }
            rightBuilder.Append("</rights>");
            return rightBuilder.ToString();
        }

        private string getRightIdByCBId(string cbId)
        {
            string[] strs = cbId.Split('_');
            return strs[2];
        }

        private void initRoleList()
        {
            this.ddlRole.Items.Clear();
            this.ddlRole.Items.Add(new ListItem("请选择...", "-1"));
            IList<Role> roleList = this.roleDao.FindAll();
            foreach (Role rolePoco in roleList)
            {
                this.ddlRole.Items.Add(new ListItem(rolePoco.Rolename, rolePoco.Id.ToString()));
            }
        }

        protected void ddlRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rightPanel.Controls.Clear();
            this.initRights(this.ddlRole.SelectedValue);
        }
    }
}