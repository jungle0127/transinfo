using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.Biz.Right;
using Trans.DAL.Entity;
using System.Text;
using System.Collections;

namespace Trans.admin
{
    public partial class leftmenu : Trans.App_Code.Biz.Common.SessionCheckPageBase
    {
        private IRightManager rightManager;
        private string rightMenuContent;

        public string RightMenuContent
        {
            get { return rightMenuContent; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.rightManager = new RightManager();
            this.rightMenuContent = this.getRightMenuContent(int.Parse(base.UserId));
        }
        private string getRightMenuContent(int userId)
        {
            StringBuilder rightMenuBuilder = new StringBuilder();
            LinkedList<RightsInfo> rightInfoList = rightManager.getRightsByUserId(userId);
            Hashtable rightGroupMap = this.rightManager.getRightGroupMap();
            foreach (RightsInfo rightInfo in rightInfoList)
            {
                Rightgroup rightGroupPoco = rightGroupMap[rightInfo.RightGroup.Id] as Rightgroup;
                rightMenuBuilder.Append(this.getRightgroupItem(rightGroupPoco.Groupname));
                rightMenuBuilder.Append("<ul class=\"menuson\">");
                foreach (Rights rightPojo in rightInfo.RightList)
                {
                    rightMenuBuilder.Append("<li><cite></cite><a href=\"");
                    rightMenuBuilder.Append(rightPojo.Righturl);
                    rightMenuBuilder.Append("\" target=\"rightFrame\">");
                    rightMenuBuilder.Append(rightPojo.Rightname);
                    rightMenuBuilder.Append("</a><i></i></li>");
                }
                rightMenuBuilder.Append("</ul>");
                rightMenuBuilder.Append("</dd>");
            }
            return rightMenuBuilder.ToString();
        }
        private string getRightgroupItem(string rightGroupName)
        {
            StringBuilder groupItemBuilder = new StringBuilder();
            groupItemBuilder.Append("<dd>");
            groupItemBuilder.Append("<div class=\"title\">");
            groupItemBuilder.Append("<span><img alt=\"\"  src=\"../images/leftico01.png\" /></span>");
            groupItemBuilder.Append(rightGroupName);
            groupItemBuilder.Append("</div>");
            return groupItemBuilder.ToString();
        }
    }
}