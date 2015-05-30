using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using System.Text;
using Trans.DAL.Entity;





namespace Trans.InfoShow
{
    public partial class GoodsInfoDetail : System.Web.UI.Page
    {
        private IGoodssourceinformationDao goodsinformationtable;
        private IUsersDao userInfos;
        private ICountyDao countyInfos;
        private IGoodstypeDao goodsTypeInfo;
        private string MessageHtml;

        public string MessageHtmlGoods
        {
            get { return MessageHtml; }
        }


        public GoodsInfoDetail()
        {
            goodsinformationtable = new GoodssourceinformationDao();
            userInfos = new UsersDao();
            countyInfos = new CountyDao();
            goodsTypeInfo = new GoodstypeDao();

        }


        public string getmessagebody()
        {
            StringBuilder MessageShow = new StringBuilder();
            Int32 idformes = Convert.ToInt32(Request.QueryString["id".ToString()]);
            Goodssourceinformation detailForGoods = this.goodsinformationtable.Find(idformes);
            //开始组装html
            MessageShow.Append("<tr class=\"infoTitle\"><td><p id=\"infoTitle\" class=\"pInfoTitle\">");
            MessageShow.Append(detailForGoods.Title);
            MessageShow.Append("</p><hr class=\"hr1\" /></td></tr><tr><td class=\"infoDetail\"><table><tbody><tr><td class=\"infoPic\"><div id=\"infoPic\"><img src=\"../../imgs/companys/4.jpg\" class=\"imgInfoPic\" /></div></td><td class=\"infoContacts\"><table><tbody><tr><td class=\"firstTd\">发布时间：</td><td class=\"secTd\"><span class=\"spanInfotime\">");
            MessageShow.Append(detailForGoods.Releasedate);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\">联系人：</td><td class=\"secTd\"><span class=\"spanContactor\">");
            Users userGoods = this.userInfos.Find(detailForGoods.Userid);
            MessageShow.Append(userGoods.Username);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\">联系电话：</td><td class=\"secTd\"><span class=\"spanContacts\">");
            MessageShow.Append("***");
            MessageShow.Append("</span></td></tr><tr><td><hr /></td><td><hr /></td></tr><tr><td class=\"firstTd\">启运地：</td><td class=\"secTd\"><span class=\"spanBeginAdr\">");
            IList<County> goodsCounty = this.countyInfos.FindByCode(detailForGoods.Srccountycode);
            MessageShow.Append(goodsCounty[0].Name);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\">目的地：</td><td class=\"secTd\"><span class=\"spanEndAdr\">");
            goodsCounty = this.countyInfos.FindByCode(detailForGoods.Dstcountycode);
            MessageShow.Append(goodsCounty[0].Name);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\">类型：</td><td class=\"secTd\"><span class=\"spanType\">");
            Goodstype goodstypeInfos = this.goodsTypeInfo.Find(detailForGoods.Goodstypeid);
            MessageShow.Append(goodstypeInfos.Typename);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\">何时需要：</td><td class=\"secTd\"><span class=\"spanTimeToUse\">");
            MessageShow.Append("***");
            MessageShow.Append("</span></td></tr><tr><td><hr /></td><td><hr /></td></tr><tr><td class=\"firstTd\">特殊说明 ：</td><td class=\"secTd\"><span class=\"spanPrice\">");
            MessageShow.Append(detailForGoods.Content);
            MessageShow.Append("</span></td></tr></tbody></table></td></tr></tbody></table></td></tr><tr><td></td></tr>");
            return MessageShow.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            MessageHtml = getmessagebody();
        }
    }
}