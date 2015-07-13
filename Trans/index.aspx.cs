using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;
using Trans.DAL.Entity;
using IBatisNet.DataMapper.Configuration;
using IBatisNet.DataMapper;
using Trans.DAL.Dao;
using Trans.Biz.Right;
using Trans.DAL.IDao.USP;
using Trans.DAL.Dao.USP;
using Trans.DAL.Entity.USP;
using System.Text;
namespace Trans
{
    public partial class index : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(index));
        private IArticleDao articleDao;
        public index()
        {
            this.articleDao = new ArticleDao();
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Property
        private string buildTopNews()
        {
            ArticlePagination articlePoco = new ArticlePagination();
            articlePoco.Limit = 5;
            articlePoco.Offset = 0;
            StringBuilder articleBuilder = new StringBuilder();
            IList<Article> pocoList = this.articleDao.DescendOrderPaginationFindAll(articlePoco);
            return articleBuilder.ToString();
        }
        #endregion
    }
}