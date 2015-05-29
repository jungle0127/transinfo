using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using Trans.DAL.Entity;
using System.Text;

namespace Trans.InfoList
{
    public partial class TrunkInfoList : System.Web.UI.Page
    {
        private ITrunkinformationDao trunkinformation;
        private ITrunkmetadataDao trunkmetadata;
        private IUsersDao Usersinfo;
        private ICountyDao Countyinfos;
        public TrunkInfoList()
        {
            trunkinformation = new TrunkinformationDao();
            trunkmetadata = new TrunkmetadataDao();
            Usersinfo = new UsersDao();
            Countyinfos = new CountyDao();
        }

        private string Message;

        public string Message1
        {
            get { return Message; }
        }
        public string GetMessageBody()
        {
            TrunkinformationPagination trunkinfoUse = new TrunkinformationPagination();
            trunkinfoUse.Limit = 5;
            trunkinfoUse.Offset = 0;
            IList<Trunkinformation> showData = this.trunkinformation.PaginationFindAll(trunkinfoUse);
            StringBuilder showBody = new StringBuilder();
            foreach (Trunkinformation enti in showData)
            {
                showBody.Append("<tr><td><a href=\"../InfoShow/TrunkInfoDetail.aspx?id="+enti.Id.ToString()+" \" class=\"infoTitle h4LorryInfoTitle\">");
                showBody.Append(enti.Title);
                showBody.Append("</a><p><span class=\"light-info\">车辆长度：</span><span class=\"infos spanLorryLength\" id=\"carLength\">");
                Trunkmetadata trunkDetails = this.trunkmetadata.Find(enti.Trunkid);
                showBody.Append(trunkDetails.Length);
                showBody.Append("</span>|<span class=\"light-info\">载重：</span><span class=\"infos spanLorryWeight\" id=\"carWeight\">");
                showBody.Append(trunkDetails.Weightcapacity);
                showBody.Append("</span></p><p><span class=\"light-info\">信息来源：</span><a  href=\"#\" class=\"lorryCompanyLink\">");
                Users userInfo = this.Usersinfo.Find(enti.Userid);
                showBody.Append(userInfo.Username);
                showBody.Append("</a></p></td><td><span class=\"infos lorryPublishTime\" id=\"publishTime\">");
                showBody.Append(enti.Takeofftime);
                showBody.Append("</span></td><td><span  class=\"spanLorryPlace\">");
                IList<County> trunkCounty = this.Countyinfos.FindByCode(enti.Srccountycode);
                showBody.Append(trunkCounty[0].Name);
                showBody.Append("</span></td><td><a class=\"moreBottn\" href=\"#\" target=\"_blank\"><img src=\"../../imgs/plus_alt.png\" id=\"moreBtn\"></a></td></tr>");

            }
            return showBody.ToString();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Message = GetMessageBody();
        }

    }
}