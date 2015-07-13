using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Entity;
using Trans.DAL.Dao;
using System.Text;
using Trans.DAL.Dao;
using Trans.DAL.Entity;
using System.Text;
using log4net;
using Trans.InfoList;


namespace Trans.InfoList
{
    public partial class DepotInfoList : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(TrunkInfoList));
        private DepotListHandler DepotListHandler;
        private string depotFirstPageHtml;

        public string DepotFirstPageHtml
        {
            get { return depotFirstPageHtml; }
            set { depotFirstPageHtml = value; }
        }

        public DepotInfoList()
        {
            this.DepotListHandler = new DepotListHandler();
            this.depotFirstPageHtml = this.DepotListHandler.generateDepotInfoHtml("1", "10");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
    }
}