using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.App_Code.Biz.Common;
using log4net;
using Trans.Biz.Right;
using Trans.DAL.Dao;
using Trans.DAL.Entity;
using System.Collections;
using System.Text;
using Trans.DAL.IDao.USP;
using Trans.DAL.Dao.USP;
using Trans.DAL.Entity.USP;

namespace Trans.admin.rightmanager
{
    public partial class RoleRightManager : SessionCheckPageBase
    {
        private static ILog logger = LogManager.GetLogger(typeof(RoleRightManager));
        private IRightManager rightManager;
        private IRoleDao roleDao;
        private IUspUpdateRoleHasRightsDao uspUpdateRoleRightsDao;
        public RoleRightManager() : base()
        {
            this.rightManager = new RightManager();
            this.roleDao = new RoleDao();
            this.uspUpdateRoleRightsDao = new UspUpdateRoleHasRightsDao();
            logger.Info("Construct method done.");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.initRoleList();
                logger.Info("Role dropdownlist init done.");
            }
            this.createRightControls();
        }
        #region Private method

        /// <summary>
        /// Init right check box without right information
        /// </summary>
        private void createRightControls()
        {
            Hashtable rightGroupMap = this.rightManager.getRightGroupMap();
            logger.Info("Got right group information with count:" + rightGroupMap.Count.ToString());
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

        /// <summary>
        /// Init role drop down list.
        /// </summary>
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
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UspUpdateRoleHasRights uspPoco = new UspUpdateRoleHasRights();
            uspPoco.XmlData = this.prepareUSPParam();
            logger.Info("XML data for role:" + uspPoco.XmlData);
            try
            {
                this.uspUpdateRoleRightsDao.RunProc(uspPoco);
                this.labelNotification.Text = "权限更新成功";
                logger.Info("role rights updated done.");
            }
            catch (Exception ex)
            {
                this.labelNotification.Text = "权限更新失败，错误信息：" + ex.Message;
                logger.Error("Role rights updated failed with exception:" + ex.Message);
            }
        }
        /// <summary>
        /// Update rights with rightID list.
        /// </summary>
        /// <param name="rightIdList">right id list</param>
        /// <param name="isChecked">if it's true, the right of rightID list will be set to checked.</param>
        /// <param name="isEnable">if it's true, the right of the rightID list will set enabled.</param>
        private void updateRights(IList<long> rightIdList, bool isChecked, bool isEnable)
        {
            foreach (long rightId in rightIdList)
            {
                string checkBoxId = "cb_rt_" + rightId.ToString();
                Control control = this.rightPanel.FindControl(checkBoxId);
                if (null == control)
                {
                    logger.Error("Can not find the Checkbox with ID:" + checkBoxId);
                    continue;
                }
                CheckBox cb = control as CheckBox;
                cb.Checked = isChecked;
                cb.Enabled = isEnable;
            }
        }
        private string getRightIdByCBId(string cbId)
        {
            string[] strs = cbId.Split('_');
            return strs[2];
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
        #endregion

        protected void ddlRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labelNotification.Text = "";
            if (this.ddlRole.SelectedValue == "-1")
            {
                logger.Info("The first item is not a role, ignore it.");
                return;
            }
            IList<long> allRightIdList = this.rightManager.getAllRightIdList();
            this.updateRights(allRightIdList, false, true);
            logger.Info("Clear all the checkboxes.");
            IList<long> rightIdList = this.rightManager.getRightIdListByRoleId(long.Parse(this.ddlRole.SelectedValue));
            this.updateRights(rightIdList, true, true);
            logger.Info("Rights updated done.");
        }
    }
}