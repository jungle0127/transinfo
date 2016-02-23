using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trans.InfoList
{
    public partial class NewsContent : System.Web.UI.Page
    {
        private ArticleListHandler articleListHandler;
        private string newsFirstPageHtml;

        public string NewsFirstPageHtml
        {
            get { return newsFirstPageHtml; }
        }
        public NewsContent()
        {
            this.articleListHandler = new ArticleListHandler();
            this.newsFirstPageHtml = this.articleListHandler.generateNotificationHtml("1", "10", "1");
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}