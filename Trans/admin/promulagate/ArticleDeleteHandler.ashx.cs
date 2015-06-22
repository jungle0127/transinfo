using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using Trans.DAL.Dao;
using System.IO;
using Trans.DAL.Entity;

namespace Trans.admin.promulagate
{
    /// <summary>
    /// Summary description for ArticleDeleteHandler
    /// </summary>
    public class ArticleDeleteHandler : IHttpHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(ArticleDeleteHandler));
        private IArticleDao articleDao;
        public ArticleDeleteHandler()
        {
            this.articleDao = new ArticleDao();
            logger.Info("Constructor method done.");
        }
        public void ProcessRequest(HttpContext context)
        {
            StreamReader streamReader = new StreamReader(context.Request.InputStream);
            string articleId = streamReader.ReadToEnd();
            logger.Info("Got request parameter:" + articleId);
            Article articlePoco = new Article();
            articlePoco.Id = long.Parse(articleId);
            context.Response.ContentType = "text/plain";

            try
            {
                this.articleDao.Delete(articlePoco);
                context.Response.Write("删除成功");
            }
            catch (Exception ex)
            {
                logger.Info("Delete article failed with exception:" + ex.Message);
                context.Response.Write("删除失败：" + ex.Message);
            }
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