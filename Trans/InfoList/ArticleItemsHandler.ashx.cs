using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trans.DAL.Dao;
using System.IO;
using log4net;
using Trans.DAL.Entity;

namespace Trans.InfoList
{
    /// <summary>
    /// Summary description for ArticleItemsHandler
    /// </summary>
    public class ArticleItemsHandler : IHttpHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(ArticleItemsHandler));
        private IVarticleinfoDao vArticleInfoDao;
        public ArticleItemsHandler()
        {
            this.vArticleInfoDao = new VarticleinfoDao();
        }
        public void ProcessRequest(HttpContext context)
        {
            StreamReader streamReader = new StreamReader(context.Request.InputStream);
            string typeId = streamReader.ReadToEnd();
            logger.Info("Got news type parameter:" + typeId);
            Varticleinfo poco = new Varticleinfo();
            poco.Typeid = long.Parse(typeId);
            int count = this.vArticleInfoDao.FindCountByTypeid(poco);
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