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
    public partial class GoodsInfoList : System.Web.UI.Page
    {
        private IGoodssourceinformationDao goodsinformationtable;
        private IUsersDao userInfos;
        private ICountyDao countyInfos;
        private string MessageHtml;

        public string MessageHtmlGoods
        {
            get { return MessageHtml; }
        }



        public GoodsInfoList()
        {
            goodsinformationtable = new GoodssourceinformationDao();
            userInfos = new UsersDao();
            countyInfos = new CountyDao();
        }

        public string getmessagebody()
        {
            StringBuilder messagebody = new StringBuilder();
            GoodssourceinformationPagination goodspage = new GoodssourceinformationPagination();
            goodspage.Limit = 5;
            goodspage.Offset = 0;
            IList<Goodssourceinformation> goodssourcelist = this.goodsinformationtable.PaginationFindAll(goodspage);
            foreach (Goodssourceinformation enti in goodssourcelist)
            {
                messagebody.Append("<tr><td><a target=\"_parent\" href=\"../InfoShow/detailinfoframe.aspx?id="+enti.Id.ToString()+"&type=goods\" class=\"infoTitle goodsInfoTitle\">");
                messagebody.Append(enti.Title);
                messagebody.Append("</a><p><span class=\"light-info\">所需车辆长度：</span><span class=\"infos spanNeedLength\" id=\"carLength\">");
                messagebody.Append(enti.Needtrunklength);
                messagebody.Append("</span>|<span class=\"light-info\">货重：</span><span class=\"infos spanGoodsWeight\" id=\"goodsWeight\">");
                messagebody.Append(enti.Needtrunkweight);
                messagebody.Append("</span></p><p><span class=\"light-info\">信息来源：</span><a  href=\"#\" class=\"goodsOrignLink\">");
                Users userEinfos = this.userInfos.Find(enti.Userid);
                messagebody.Append(userEinfos.Username);
                messagebody.Append("</a></p></td><td><span class=\"infos goodsPublishTime\" id=\"publishTime\">");
                messagebody.Append(enti.Releasedate);
                messagebody.Append("</span></td><td><span  class=\"spanGoodsPlace\">");
                IList<County> countyEinfos = this.countyInfos.FindByCode(enti.Srccountycode);
                messagebody.Append(countyEinfos[0].Name);
                messagebody.Append("</span></td><td><a class=\"moreBottn\" href=\"#\" target=\"_blank\"><img src=\"../../imgs/plus_alt.png\" id=\"moreBtn\"></a></td></tr>");
            }
            return messagebody.ToString();
        }


        protected void Page_Load(object sender, EventArgs e)
        {

            MessageHtml = getmessagebody();

        }

       
    }
}