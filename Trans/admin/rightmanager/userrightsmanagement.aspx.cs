using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.App_Code.Biz.Common;
using log4net;
using Trans.Biz.Right;
using Trans.DAL.Dao.USP;
using Trans.DAL.IDao.USP;
using System.Text;
using System.Collections;
using Trans.DAL.Entity;
using Trans.DAL.Entity.USP;

namespace Trans.admin.rightmanager
{
    public partial class userrightsmanagement : SessionCheckPageBase
    {
        private static ILog logger = LogManager.GetLogger(typeof(userrightsmanagement));
        private IRightManager rightManager;
        private IUspUpdateUserHasRightsDao uspUserRightsDao;
        public userrightsmanagement()
        {
            this.rightManager = new RightManager();
            this.uspUserRightsDao = new UspUpdateUserHasRightsDao();
            logger.Info("Construct method done.");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.initRights();
            logger.Info("init controls done.");
        }

        private void initRights()
        {
            logger.Info("Begin init rights of User.");
            Hashtable rightGroupMap = this.rightManager.getRightGroupMap();
            logger.Info("Got right group information with count:" + rightGroupMap.Count.ToString());
            IList<long> userRightIdList = this.rightManager.getRightIdList(Int16.Parse(base.UserId));
            LinkedList<RightsInfo> rightInfoList = this.rightManager.getRightsByUserId(int.Parse(base.UserId));
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
                    
                    if (userRightIdList.Contains(rightEntity.Id))
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
            UspUpdateUserHasRights userRightsPoco = new UspUpdateUserHasRights();
            userRightsPoco.XmlData = this.prepareUSPParam();
            logger.Info("Parameter for run procedure:UspUpdateRoleHasRights listed below:");
            logger.Info(userRightsPoco.XmlData);
            this.uspUserRightsDao.RunProc(userRightsPoco);
        }
        private string prepareUSPParam()
        {
            StringBuilder rightBuilder = new StringBuilder();
            rightBuilder.Append("<rights>");
            rightBuilder.Append("<roleid>" + RoleId + "</roleid>");
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
    }
}