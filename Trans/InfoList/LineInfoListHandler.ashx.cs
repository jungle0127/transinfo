using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using Trans.DAL.Dao;
using System.IO;
using Trans.DAL.Entity;
using Trans.Biz.Common;
using System.Text;




namespace Trans.InfoList
{
    /// <summary>
    /// Summary description for LineInfoListHandler
    /// </summary>
    public class LineInfoListHandler : IHttpHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(ArticleListHandler));
        private IVspeciallineinfoDao vLineInfoDao;
        

        public LineInfoListHandler()
        {
            this.vLineInfoDao = new VspeciallineinfoDao();
        }




        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.RequestType == "POST")
            {// POST
                StreamReader streamReader = new StreamReader(context.Request.InputStream);
                string typeId = streamReader.ReadToEnd();
                logger.Info("Got news type parameter:" + typeId);
                Vspeciallineinfo poco = new Vspeciallineinfo();

                int count = this.vLineInfoDao.FindAll().Count;
                logger.Info("got item count:" + count.ToString());
                context.Response.ContentType = "text/plain";
                context.Response.Write(count);
            }
            else
            {// GET
                string pageNumber = context.Request.QueryString["pageNumber"].ToString();
                logger.Info("Got page number:" + pageNumber);
                string pageSize = context.Request.QueryString["pageSize"].ToString();
                logger.Info("Got page size:" + pageSize);
                string typeName = context.Request.QueryString["typeName"].ToString();
                logger.Info("Got type Name:" + pageSize);
                string tableHtml = this.generateLineInfoHtml(pageNumber, pageSize, typeName);
                context.Response.ContentType = "text/plain";
                context.Response.Write(tableHtml);
            }
        }


        public string generateLineInfoHtml(string pageNumber, string pageSize, string typeName)
        {
            VspeciallineinfoPagination pageNationPoco = new VspeciallineinfoPagination();
            pageNationPoco.Limit = int.Parse(pageSize);

            pageNationPoco.Offset = (int.Parse(pageNumber) - 1) * pageNationPoco.Limit;
            logger.Info("Got offset:" + pageNationPoco.Offset.ToString());
            pageNationPoco.Speciallinetypename = typeName;
            IList<Vspeciallineinfo> lineInfoList = this.vLineInfoDao.DescendOrderPaginationFindAll(pageNationPoco);
            logger.Info("Got items:" + lineInfoList.Count.ToString());
            string tableHtml = this.getTableHtml(this.getTableBodyHtml(lineInfoList), typeName);
            logger.Info("table html:" + tableHtml);
            return tableHtml;
        }
        


        private string getTableHtml(string bodyHtml,string typeName)
        {
            StringBuilder htmlBuilder = new StringBuilder();
            htmlBuilder.Append("<div class=\"container-fluid\" id=\"showLineInfo\"><div class=\"tabL\">");
            htmlBuilder.Append("<ul class=\"nav nav-tabs\" id=\"myTab\"><li class=\"active\"><a href=\"#all\" data-toggle='tab' class=\"allLineLink\" id=\"allLineLink\">全部</a></li><li><a href=\"#one-way\" data-toggle='tab' class=\"singleLineLink\" id=\"singleLineLink\">单程</a></li><li><a href=\"#round-way\" data-toggle='tab' class=\"roundWayLineLink\" id=\"roundWayLineLink\">往返</a></li></ul>");
            htmlBuilder.Append("<div class=\"tab-content\"><div class=\"tab-pane active\" id=\"all\" ");
            if (typeName == "单程")
            {
                htmlBuilder.Append("class=\"singleLineDiv\">");
            }
            else if (typeName == "往返")
            {
                htmlBuilder.Append("class=\"roundWayLineDiv\">");
            }
            else
            {
                htmlBuilder.Append("class=\"allLineDiv\">");
            }
            //htmlBuilder.Append("<table class=\"table table-hover showStoreInfo\"><caption><div id=\"tableCaption\" style=\"padding-top:3px;\"><img src=\"../../imgs/pack-2.png\">仓储信息</div><span class=\"tableMiddle\"><div class=\"tableMiddle\">相信您在这可以很快找到心仪的货源，祝您生活愉快！</div></span></caption><thead><tr class=\"headTr\"><th>信息内容</th><th>发布时间</th><th>参考报价</th><th>立即查看</th></tr></thead>");
            //htmlBuilder.Append("<tbody>");

            htmlBuilder.Append(bodyHtml);
            //htmlBuilder.Append("</tbody>");
            //htmlBuilder.Append("</table>");
            htmlBuilder.Append("</div></div></div></div>");


            return htmlBuilder.ToString();
        }


        private string getTableBodyHtml(IList<Vspeciallineinfo> lineInfoList)
        {
            StringBuilder bodyBuilder = new StringBuilder();
            foreach (Vspeciallineinfo lineInfoPoco in lineInfoList)
            {
                
                
                
                bodyBuilder.Append("<div id=\"line_infos\" class=\"line_infos\"><p class=\"NEWSline_text\">");
                bodyBuilder.Append(lineInfoPoco.Srccityname);
                bodyBuilder.Append("<span id=\"line_kuai\"><img class=\"imgSingleLine\" src=\"../../imgs/signle.jpg\" /></span>");
                bodyBuilder.Append(lineInfoPoco.Dstcityname);
                bodyBuilder.Append("</p><p class=\"title\"><a href=\"#\" target=\"_blank\">");
                bodyBuilder.Append(lineInfoPoco.Username);
                bodyBuilder.Append("</a></p><div class=\"align_left\"><p class=\"title\">发车班次：<span id=\"Dark\">");
                bodyBuilder.Append(lineInfoPoco.Departuretypename);
                bodyBuilder.Append("</span></p><p class=\"title\">运输时长：<span id=\"Dark\">");
                bodyBuilder.Append("***");


                bodyBuilder.Append("</span></p><p class=\"title\">重货：<span id=\"huo_color\">");
                bodyBuilder.Append(lineInfoPoco.Weightprice);
                bodyBuilder.Append("</span>元/公斤</p></div><div class=\"align_left\"><p class=\"title\">是否直达：<span id=\"Dark\">");
                bodyBuilder.Append(lineInfoPoco.Speciallinetypename);//单程-往返
                bodyBuilder.Append("</span></p><p class=\"title\">运输方式：<span id=\"Dark\">");
                bodyBuilder.Append(lineInfoPoco.Speciallinetypename);
                bodyBuilder.Append("</span></p><p class=\"title\">泡货：<span id=\"huo_color\">");
                bodyBuilder.Append(lineInfoPoco.Volumeprice);
                bodyBuilder.Append("</span>元/方</p></div><div class=\"clear\"></div><div class=\"NEWS_button\"><a target=\"_parent\" href=\"../InfoShow/detailinfoframe.aspx?id=" + lineInfoPoco.Id.ToString() + "&type=line\">查看详情</a></div></div>");



                


            }
            return bodyBuilder.ToString();
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