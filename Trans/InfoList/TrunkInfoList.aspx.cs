using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using Trans.DAL.Entity;
using System.Text;
using log4net;
using Trans.InfoList;

namespace Trans.InfoList
{
    public partial class TrunkInfoList : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(TrunkInfoList));
        private TrunkInfoListHandler trunkListHandler;
        private string trunksFirstPageHtml;

        public string TrunksFirstPageHtml
        {
            get { return trunksFirstPageHtml; }
            set { trunksFirstPageHtml = value; }
        }
        public TrunkInfoList()
        {
            this.trunkListHandler = new TrunkInfoListHandler();
            this.trunksFirstPageHtml = this.trunkListHandler.generateTrunksInfoHtml("1", "10");
        }



        protected void Page_Load(object sender, EventArgs e)
        {

        }

    }
}