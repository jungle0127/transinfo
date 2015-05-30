using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Entity;
using Trans.DAL.Dao;
using System.Text;



namespace Trans.InfoList
{
    public partial class DepotInfoList : System.Web.UI.Page
    {
        private IDepotinformationDao depotInformationList;
        private IUsersDao userInfos;
        private IDepottypeDao depotType;
        private IUsersDao usersInfos;
        private ICountyDao countyDepot;
        private string MessageHtml;

        public string MessageHtmlDepot
        {
            get { return MessageHtml; }
        }


        public DepotInfoList()
        {
            depotInformationList = new DepotinformationDao();
            userInfos = new UsersDao();
            depotType = new DepottypeDao();
            usersInfos = new UsersDao();
            countyDepot = new CountyDao();
        }

        public string GetMessageBody()
        {
            StringBuilder MessageBody = new StringBuilder();
            DepotinformationPagination FindByPage = new DepotinformationPagination();
            FindByPage.Limit = 5;
            FindByPage.Offset = 0;
            IList<Depotinformation> depotinformations = this.depotInformationList.PaginationFindAll(FindByPage);
            foreach (Depotinformation enti in depotinformations)
            {
                MessageBody.Append("<tr><td class=\"infoDeatil\"><div class=\"storePic\"></div><div class=\"overFloat\"><a href=\"../InfoShow/DepotInfoDetail.aspx?id="+enti.Id+"\"><h4 class=\"infoTitle\">");
                Users depotUser = this.userInfos.Find(enti.Userid);
                MessageBody.Append(depotUser.Username);
                MessageBody.Append("</h4></a><span class=\"light-info\">面积：</span><span class=\"infos\" id=\"totalArea\">");
                MessageBody.Append(enti.Area);
                MessageBody.Append("</span>|<span class=\"light-info\">可用面积：</span><span class=\"infos\" id=\"useableArea\">");
                MessageBody.Append(enti.Useablearea);
                MessageBody.Append("</span><p><span class=\"light-info\">仓库类型：</span><span class=\"infos\" id=\"storeType\">");
                Depottype depotTps = this.depotType.Find(enti.Depottype);
                MessageBody.Append(depotTps.Typename);
                MessageBody.Append("</span>|<span class=\"light-info\">信息来源：</span><a  href=\"#\" class=\"infos_companyN\">");
                Users userIns = this.usersInfos.Find(enti.Userid);
                MessageBody.Append(userIns.Username);
                MessageBody.Append("</a></p></div></td><td><span class=\"infos\" id=\"publishTime\">");
                MessageBody.Append(enti.Validtime);
                MessageBody.Append("</span></td><td><span  id=\"prePrice\">");
                MessageBody.Append(enti.Price);
                MessageBody.Append("</span></td><td><a class=\"moreBottn\" href=\"#\" target=\"_blank\"><img src=\"../../imgs/plus_alt.png\" id=\"moreBtn\"></a></td></tr>");

            }
            return MessageBody.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            MessageHtml = GetMessageBody();

        }
    }
}