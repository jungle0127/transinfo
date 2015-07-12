using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using Trans.DAL.Dao;
using System.IO;
using Trans.DAL.Entity;
using System.Text;

namespace Trans.InfoList
{
    /// <summary>
    /// Summary description for GoodsInformationHandler
    /// </summary>
    public class GoodsInformationHandler : IHttpHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(GoodsInformationHandler));
        private IVgoodssourceinformationDao vGoodsInfoDao;
        private IGoodssourceinformationDao goodsInfoDao;
        public GoodsInformationHandler()
        {
            this.vGoodsInfoDao = new VgoodssourceinformationDao();
            this.goodsInfoDao = new GoodssourceinformationDao();
            logger.Info("Constructor done.");
        }
        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.RequestType == "POST")
            {// POST for getting total items count.
                logger.Info("Request type is POST.");
                int itemsCount = this.goodsInfoDao.GetCount();
                logger.Info("Got items count:" + itemsCount.ToString());
                context.Response.ContentType = "text/plain";
                context.Response.Write(itemsCount.ToString());
            }
            else
            {
                string pageNumber = context.Request.QueryString["pageNumber"].ToString();
                string pageSize = context.Request.QueryString["pageSize"].ToString();
                context.Response.ContentType = "text/plain";
                context.Response.Write(this.generateTableHtml(pageNumber,pageSize));

            }
        }
        public string generateTableHtml(string pageNumber, string pageSize)
        {
            VgoodssourceinformationPagination goodsInfoPoco = new VgoodssourceinformationPagination();
            goodsInfoPoco.Limit = int.Parse(pageSize);

            goodsInfoPoco.Offset = (int.Parse(pageNumber) - 1) * goodsInfoPoco.Limit;
            logger.Info("Got offset:" + goodsInfoPoco.Offset.ToString());
            IList<Vgoodssourceinformation> goodsInfoPocoList = this.vGoodsInfoDao.DescendOrderPaginationFindAll(goodsInfoPoco);
            logger.Info("Good goods information items:" + goodsInfoPocoList.Count.ToString());
            StringBuilder htmlBuilder = new StringBuilder();
            htmlBuilder.Append("<table class=\"table table-hover goodsList\">");
            htmlBuilder.Append("<caption>");
            htmlBuilder.Append("<div id=\"tableCaption\" style=\"padding-top:3px;\"><img src=\"../imgs/pack-2.png\">货源信息</div>");
            htmlBuilder.Append("</caption>");
            htmlBuilder.Append("<thead>");
            htmlBuilder.Append("<tr class=\"headTr\">");
            htmlBuilder.Append("<th>信息内容</th>");
            htmlBuilder.Append("<th>发布时间</th>");
            htmlBuilder.Append("<th>所在地</th>");
            htmlBuilder.Append("<th>立即查看</th>");
            htmlBuilder.Append("</tr>");
            htmlBuilder.Append("</thead>");
            htmlBuilder.Append(this.getTableBodyHtml(goodsInfoPocoList));
            htmlBuilder.Append("</table>");
            string tableHtml = htmlBuilder.ToString();
            logger.Info("Html code :" + tableHtml);
            return tableHtml;
            
        }
        private string getTableBodyHtml(IList<Vgoodssourceinformation> goodsInfoPocoList)
        {
            StringBuilder htmlBuilder = new StringBuilder();
            htmlBuilder.Append("<tbody>");
            foreach (Vgoodssourceinformation poco in goodsInfoPocoList)
            {
                htmlBuilder.Append("<tr>");
                htmlBuilder.Append("<td>");
                htmlBuilder.Append("<a href=\"../thirdLevel/goodsDetail.html\" target=\"infoDetails\" class=\"infoTitle goodsInfoTitle\">");
                htmlBuilder.Append(poco.Title);
                htmlBuilder.Append("</a>");
                htmlBuilder.Append("<p>");
                htmlBuilder.Append("<span class=\"light-info\">所需车辆长度：</span><span class=\"infos spanNeedLength\" id=\"carLength\">");
                htmlBuilder.Append(poco.Needtrunklength.ToString());
                htmlBuilder.Append("米</span>");
                htmlBuilder.Append("<span class=\"light-info\">货重：</span><span class=\"infos spanGoodsWeight\" id=\"goodsWeight\">");
                htmlBuilder.Append(poco.Needtrunkweight.ToString());
                htmlBuilder.Append("吨</span>\"");
                htmlBuilder.Append("</p>");
                htmlBuilder.Append("<p><span class=\"light-info\">信息来源：</span><a  href=\"#\" class=\"goodsOrignLink\">");
                htmlBuilder.Append(poco.Username);
                htmlBuilder.Append("</a></p>");
                htmlBuilder.Append("</td>");
                htmlBuilder.Append("<td>");
                htmlBuilder.Append("<span class=\"infos goodsPublishTime\" id=\"publishTime\">");
                htmlBuilder.Append(poco.Releasedate.ToShortDateString());
                htmlBuilder.Append("</span>");
                htmlBuilder.Append("</td>");
                htmlBuilder.Append("<td><span  class=\"spanGoodsPlace\">");
                htmlBuilder.Append(poco.Srcregionname);
                htmlBuilder.Append("</span></td>");
                htmlBuilder.Append("<td>");
                htmlBuilder.Append("<a class=\"moreBottn\" href=\"#\" target=\"_blank\"><img src=\"../imgs/plus_alt.png\" id=\"moreBtn\"></a>");
                htmlBuilder.Append("</td>");
                htmlBuilder.Append("</tr>");
            }
            htmlBuilder.Append("</tbody>");
            return htmlBuilder.ToString();
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}