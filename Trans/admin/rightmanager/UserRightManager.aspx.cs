using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.App_Code.Biz.Common;
using log4net;
using Trans.Biz.Right;
using Trans.DAL.IDao.USP;
using Trans.DAL.Dao;
using Trans.DAL.Dao.USP;
using Trans.DAL.Entity;
using System.Text;
using System.Collections;
using Trans.DAL.Entity.USP;

namespace Trans.admin.rightmanager
{
    public partial class UserRightManager : SessionCheckPageBase
    {
        private static ILog logger = LogManager.GetLogger(typeof(UserRightManager));
        private IRightManager rightManager;
        private IUspUpdateUserHasRightsDao uspUserRightsDao;
        private IUsersDao usersDao;
        
        public UserRightManager() : base()
        {
            this.rightManager = new RightManager();
            this.uspUserRightsDao = new UspUpdateUserHasRightsDao();
            this.usersDao = new UsersDao();
            logger.Info("Constructor method.");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.initUserList();
            }
            this.createRightControls();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UspUpdateUserHasRights uspUpdateUserHasRights = new UspUpdateUserHasRights();
            uspUpdateUserHasRights.XmlData = this.prepareUSPParam();
            logger.Info("XML data for USP to update:" + uspUpdateUserHasRights.XmlData);
            try
            {
                this.uspUserRightsDao.RunProc(uspUpdateUserHasRights);
                logger.Info("Rights of user updated done.");
                this.labelNotification.Text = "权限更新成功";
            }
            catch (Exception ex)
            {
                logger.Error("Update the rights failed with exception:" + ex.Message);
                this.labelNotification.Text = "权限更新失败，错误信息：" + ex.Message;
            }
        }

        #region private method
        private void initUserList()
        {
            this.ddlUser.Items.Clear();
            this.ddlUser.Items.Add(new ListItem("请选择...", "-1"));
            IList<Users> usersPocoList = this.usersDao.FindAll();
            foreach (Users userPoco in usersPocoList)
            {
                this.ddlUser.Items.Add(new ListItem(userPoco.Loginname, userPoco.Id.ToString()));
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
            rightBuilder.Append("<userid>" + this.ddlUser.SelectedValue + "</userid>");
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

        #endregion

        protected void ddlUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labelNotification.Text = "";
            if (this.ddlUser.SelectedValue == "-1")
            {
                logger.Info("The first item is not a user, ignore it.");
                return;
            }
            logger.Info("Selected user with ID:" + this.ddlUser.SelectedValue);
            IList<Int64> allRightIdList = this.rightManager.getAllRightIdList();
            this.updateRights(allRightIdList, false, true);
            Users userPoco = this.usersDao.Find(long.Parse(this.ddlUser.SelectedValue));
            logger.Info("The role ID of the user:" + userPoco.Roleid.ToString());
            IList<long> roleRightIdList = this.rightManager.getRightIdListByRoleId(userPoco.Roleid);
            logger.Info("Rights item count of user's role:" + roleRightIdList.Count.ToString());
            this.updateRights(roleRightIdList, true, false);
            IList<long> userRightIdList = this.rightManager.getRightIdListByUserId(userPoco.Id);
            logger.Info("Rights item count of user:" + userRightIdList.Count.ToString());
            this.updateRights(userRightIdList, true, true);
        }
    }
}