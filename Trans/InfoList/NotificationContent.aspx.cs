using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;

namespace Trans.InfoList
{
    public partial class NotificationContent : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(NotificationList));
        private ArticleListHandler articleListHandler;
        private string notificationFirstPageHtml;

        public string NotificationFirstPageHtml
        {
            get { return notificationFirstPageHtml; }
        }
        public NotificationContent()
        {
            this.articleListHandler = new ArticleListHandler();
            this.notificationFirstPageHtml = this.articleListHandler.generateNotificationHtml("1", "10", "2");
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}