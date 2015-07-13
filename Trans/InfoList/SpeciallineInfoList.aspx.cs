using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Entity;
using System.Text;
using Trans.DAL.Dao;
using log4net;
using Trans.InfoList;


namespace Trans.InfoList
{
    public partial class SpeciallineInfoList : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(SpeciallineInfoList));
        private LineInfoListHandler lineListHandler;
 

        private string totalPageHtml;

        public string TotalPageHtml
        {
            get { return totalPageHtml; }
            set { totalPageHtml = value; }
        }


        public SpeciallineInfoList()
        {
            this.lineListHandler = new LineInfoListHandler();
            this.totalPageHtml = this.lineListHandler.generateLineInfoHtml("1", "10","");
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
    }
}