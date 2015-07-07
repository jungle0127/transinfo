using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;
using Trans.DAL.Dao;
using Trans.DAL.Entity;

namespace Trans.InfoShow
{
    public partial class NewsInfoDetail : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(NewsInfoDetail));
        private IArticleDao articleDao;
        private string articleId;
        private Article articlePoco;
        public NewsInfoDetail()
        {
            this.articleDao = new ArticleDao();
            if (Request.QueryString["id"] == null)
            {
                logger.Error("Article ID parameter is required.");
                //TODO:提醒
            }
            this.articleId = Request.QueryString["id"].ToString();
            this.articlePoco = this.getArticlePoco(this.articleId);
            logger.Debug("Constructor method done.");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //TODO: display article information.
            this.updateReadCount(this.articlePoco);
            logger.Info("page loaded.");
        }
        /// <summary>
        /// Get Article information by ID
        /// </summary>
        /// <param name="articleId">ID of article</param>
        /// <returns>Article information.</returns>
        private Article getArticlePoco(string articleId)
        {
            Article articlePoco = null;
            try
            {
                articlePoco = this.articleDao.Find(long.Parse(articleId));
                logger.Debug("Artile founded.");
            }
            catch (Exception ex)
            {
                logger.Error("Find article failed with articleID:" + articleId + ", and exception:" + ex.Message);
            }
            return articlePoco;
        }
        /// <summary>
        /// Add 1 to the read count to an article.
        /// </summary>
        /// <param name="poco">Article POCO</param>
        private void updateReadCount(Article poco)
        {
            poco.Hittimes = poco.Hittimes + 1;
            try
            {
                this.articleDao.Update(poco);
                logger.Debug("Hit times updated as:" + poco.Hittimes.ToString());
            }
            catch (Exception ex)
            {
                logger.Info("Update hittimes of article failed with exception:" + ex.Message);
            }
        }
    }
}