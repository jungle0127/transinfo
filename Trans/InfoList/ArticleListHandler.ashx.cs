using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trans.DAL.Entity;
using Trans.DAL.Dao;
using System.Text;
using log4net;
using System.Collections;
namespace Trans.InfoList
{
    /// <summary>
    /// Summary description for ArticleListHandler
    /// </summary>
    public class ArticleListHandler : IHttpHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(ArticleListHandler));
        private IVarticleinfoDao vArticleInfoDao;
        public ArticleListHandler()
        {
            this.vArticleInfoDao = new VarticleinfoDao();
        }
        public void ProcessRequest(HttpContext context)
        {
            string pageNumber = context.Request.QueryString["pageNumber"].ToString();
            logger.Info("Got page number:" + pageNumber);
            string pageSize = context.Request.QueryString["pageSize"].ToString();
            logger.Info("Got page size:" + pageSize);
            string typeId = context.Request.QueryString["type"].ToString();
            logger.Info("Got type ID:" + typeId);
            string tableHtml = this.generateNotificationHtml(pageNumber, pageSize, typeId);
            context.Response.ContentType = "text/plain";
            context.Response.Write(tableHtml);
        }
        public string generateNotificationHtml(string pageNumber, string pageSize, string typeId)
        {
            VarticleinfoPagination pageNationPoco = new VarticleinfoPagination();
            pageNationPoco.Limit = int.Parse(pageSize);

            pageNationPoco.Offset = (int.Parse(pageNumber) - 1) * pageNationPoco.Limit;
            logger.Info("Got offset:" + pageNationPoco.Offset.ToString());
            pageNationPoco.Typeid = long.Parse(typeId);
            IList<Varticleinfo> articleInfoList = this.vArticleInfoDao.DescendOrderPaginationFindByTypeid(pageNationPoco);
            logger.Info("Got items:" + articleInfoList.Count.ToString());
            string tableHtml = this.getTableHtml(this.getTableBodyHtml(articleInfoList),typeId);
            logger.Info("table html:" + tableHtml);
            return tableHtml;
        }
        private string getTableHtml(string bodyHtml,string typeId)
        {
            StringBuilder htmlBuilder = new StringBuilder();
            if (typeId == "1")
            {
                htmlBuilder.Append("<table class=\"table table-hover newsList\">");
            }
            else
            {
                htmlBuilder.Append("<table class=\"table table-hover noticeList\">");
            }
            htmlBuilder.Append("<tbody>");
            //htmlBuilder.Append("<thead>");
            //htmlBuilder.Append("<th  width=\"90%\">标题");
            //htmlBuilder.Append("</th>");
            //htmlBuilder.Append("<th  width=\"10%\">发布时间");
            //htmlBuilder.Append("</th>");
            //htmlBuilder.Append("</thead>");
            htmlBuilder.Append(bodyHtml);
            htmlBuilder.Append("</tbody>");
            htmlBuilder.Append("</table>");
            return htmlBuilder.ToString();
        }
        private string getTableBodyHtml(IList<Varticleinfo> articleInfoList)
        {
            StringBuilder bodyBuilder = new StringBuilder();
            foreach (Varticleinfo articleInfoPoco in articleInfoList)
            {
                bodyBuilder.Append("<tr>");
                bodyBuilder.Append("<td  width=\"90%\">");
                bodyBuilder.Append("<a target=\"_blank\" href=\"../InfoShow/NewsInfoDetail.aspx?id=" + articleInfoPoco.Id.ToString() + "\">");
                bodyBuilder.Append(articleInfoPoco.Title);
                bodyBuilder.Append("</a>");
                bodyBuilder.Append("</td>");
                bodyBuilder.Append("<td  width=\"10%\">");
                bodyBuilder.Append(articleInfoPoco.Releasedate.ToShortDateString());
                bodyBuilder.Append("</td>");
                bodyBuilder.Append("</tr>");
            }
            return bodyBuilder.ToString();
        }
        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
    }
}