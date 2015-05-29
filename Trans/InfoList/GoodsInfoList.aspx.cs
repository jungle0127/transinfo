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


        public GoodsInfoList()
        {
            goodsinformationtable = new GoodssourceinformationDao();
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
                messagebody.Append("<tr><td><a href=\"../InfoShow/GoodsInfoDetail.aspx\" class=\"infoTitle goodsInfoTitle\">");
                messagebody.Append(enti.Title);
                messagebody.Append("</a><p><span class=\"light-info\">所需车辆长度：</span><span class=\"infos spanNeedLength\" id=\"carLength\">");
                messagebody.Append("*待获取车辆长度信息*");
                messagebody.Append("</span>|<span class=\"light-info\">货重：</span><span class=\"infos spanGoodsWeight\" id=\"goodsWeight\">");
                messagebody.Append("");
            }


            return messagebody.ToString();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

       
    }
}