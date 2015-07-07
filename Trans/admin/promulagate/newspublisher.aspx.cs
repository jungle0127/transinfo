using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using Trans.DAL.Entity;
using log4net;

namespace Trans.admin.promulagate
{
    public partial class newspublisher : Trans.App_Code.Biz.Common.SessionCheckPageBase
    {
        private static ILog logger = LogManager.GetLogger(typeof(newspublisher));
        private string userId;
        private IArticleDao articleDao;
        public newspublisher() : base()
        {
            this.userId = base.UserId;
            this.articleDao = new ArticleDao();
            logger.Info("Construct method done.");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count > 0)
            {
                string requestType = Request.QueryString[0];
                if (requestType == "1")
                {
                    this.ddlArticleType.SelectedIndex = 0;
                    logger.Info("News publisher");
                }
                else
                {
                    this.ddlArticleType.SelectedIndex = 1;
                    logger.Info("Notification publisher.");
                }
            }
            
        }

        private void insertArticle()
        {
            Article articlePoco = new Article();
            articlePoco.Userid = long.Parse(this.userId);
            articlePoco.Typeid = long.Parse(this.ddlArticleType.SelectedValue);
            articlePoco.Title = this.txtTitle.Text;
            articlePoco.Releaseip = this.Request.UserHostAddress;
            articlePoco.Content = this.txtContent.Text;
            articlePoco.Hittimes = 0;
            articlePoco.Ispass = 1;
            if (this.cbIstop.Checked)
                articlePoco.Istop = 1;
            else
                articlePoco.Istop = 0;
            articlePoco.Releasedate = DateTime.Now;
            this.articleDao.Insert(articlePoco);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                this.insertArticle();
                logger.Info("Article inserted succeed.");
                if (this.ddlArticleType.SelectedValue == "1")
                    Response.Redirect("newslist.aspx");
                else
                    Response.Redirect("NotificationList.aspx");
            }
            catch (Exception ex)
            {
                logger.Error("Article inserted failed with exception:" + ex.Message );
                logger.Error("title:" + this.txtTitle.Text);
                logger.Error("Content:" + this.txtContent.Text);
            }
        }

    }
}