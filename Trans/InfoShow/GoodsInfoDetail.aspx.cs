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
            MessageShow.Append("<trclass=\"infoTitle\"><td><pid=\"infoTitle\"class=\"pInfoTitle\">");
            MessageShow.Append(detailForGoods.Title);
            MessageShow.Append("</p><hrclass=\"hr1\"/></td></tr><tr><tdclass=\"infoDetail\"><table><tbody><tr><tdclass=\"infoPic\"><divid=\"infoPic\"><imgsrc=\"../../imgs/companys/4.jpg\"class=\"imgInfoPic\"/></div></td><tdclass=\"infoContacts\"><table><tbody><tr><tdclass=\"firstTd\">发布时间：</td><tdclass=\"secTd\"><spanclass=\"spanInfotime\">");
            MessageShow.Append(detailForGoods.Releasedate);
            MessageShow.Append("</span></td></tr><tr><tdclass=\"firstTd\">联系人：</td><tdclass=\"secTd\"><spanclass=\"spanContactor\">");
            Users userGoods = this.userInfos.Find(detailForGoods.Userid);
            MessageShow.Append(userGoods.Username);
            MessageShow.Append("</span></td></tr><tr><tdclass=\"firstTd\">联系电话：</td><tdclass=\"secTd\"><spanclass=\"spanContacts\">");
            MessageShow.Append("***");
            MessageShow.Append("</span></td></tr><tr><td><hr/></td><td><hr/></td></tr><tr><tdclass=\"firstTd\">启运地：</td><tdclass=\"secTd\"><spanclass=\"spanBeginAdr\">");
            IList<County> goodsCounty = this.countyInfos.FindByCode(detailForGoods.Srccountycode);
            MessageShow.Append(goodsCounty[0].Name);
            MessageShow.Append("</span></td></tr><tr><tdclass=\"firstTd\">目的地：</td><tdclass=\"secTd\"><spanclass=\"spanEndAdr\">");
            goodsCounty = this.countyInfos.FindByCode(detailForGoods.Dstcountycode);
            MessageShow.Append(goodsCounty[0].Name);
            MessageShow.Append("</span></td></tr><tr><tdclass=\"firstTd\">类型：</td><tdclass=\"secTd\"><spanclass=\"spanType\">");
            Goodstype goodstypeInfos = this.goodsTypeInfo.Find(detailForGoods.Goodstypeid);
            MessageShow.Append(goodstypeInfos.Typename);
            MessageShow.Append("</span></td></tr><tr><tdclass=\"firstTd\">何时需要：</td><tdclass=\"secTd\"><spanclass=\"spanTimeToUse\">");
            MessageShow.Append("***");





            return MessageShow.ToString();


        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}