using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;

namespace Trans.InfoList
{
    public partial class NotificationList : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(NotificationList));
        private ArticleListHandler articleListHandler;
        private string newsFirstPageHtml;

        public string NewsFirstPageHtml
        {
            get { return newsFirstPageHtml; }
        }
        private string notificationFirstPageHtml;

        public string NotificationFirstPageHtml
        {
            get { return notificationFirstPageHtml; }
        }

        public NotificationList()
        {
            this.articleListHandler = new ArticleListHandler();
            this.newsFirstPageHtml = this.articleListHandler.generateNotificationHtml("1", "10", "1");
            this.notificationFirstPageHtml = this.articleListHandler.generateNotificationHtml("1", "10", "2");
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}