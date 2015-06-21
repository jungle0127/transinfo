using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trans.DAL.Dao;
using log4net;
using Trans.DAL.Entity;
using System.IO;

namespace Trans.admin.promulagate
{
    /// <summary>
    /// Summary description for ItemsCountHandler
    /// </summary>
    public class ItemsCountHandler : IHttpHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(ItemsCountHandler));
        private IArticleDao articleDao;

        public ItemsCountHandler()
        {
            this.articleDao = new ArticleDao();
            logger.Info("Constructor method done.");
        }
        public void ProcessRequest(HttpContext context)
        {
            StreamReader streamReader = new StreamReader(context.Request.InputStream);
            string typeId = streamReader.ReadToEnd();
            logger.Info("Got news type parameter:" + typeId);
            Article articlePoco = new Article();
            articlePoco.Typeid = long.Parse(typeId);
            int count = this.articleDao.FindCountByTypeid(articlePoco);
            logger.Info("got item count:" + count.ToString());
            context.Response.ContentType = "text/plain";

            context.Response.Write(count);
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