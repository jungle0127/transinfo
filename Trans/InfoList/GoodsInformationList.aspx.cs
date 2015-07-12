using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;

namespace Trans.InfoList
{
    public partial class GoodsInformationList : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(GoodsInformationList));
        private GoodsInformationHandler goodsInformationHandler;
        public GoodsInformationList()
        {
            this.goodsInformationHandler = new GoodsInformationHandler();
        }
        private string firstPageInformation;

        public string FirstPageInformation
        {
            get { return firstPageInformation; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.firstPageInformation = this.goodsInformationHandler.generateTableHtml("1", "10");
        }
    }
}