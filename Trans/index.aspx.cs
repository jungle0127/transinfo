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

        private string topNews;

        public string TopNews
        {
            get { return topNews; }
        }

        public index()
        {
            this.topNews = this.initTopNews();
        }

        private string initTopNews()
        {
            StringBuilder newsBuilder = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                newsBuilder.Append("<li><a href=\"newsshow.aspx?id=1\">测试新闻数据</a></li>");
            }


            return newsBuilder.ToString();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
         
        }
    }
}