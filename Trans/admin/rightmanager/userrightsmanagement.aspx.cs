using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.App_Code.Biz.Common;
using log4net;

namespace Trans.admin.rightmanager
{
    public partial class userrightsmanagement : SessionCheckPageBase
    {
        private static ILog logger = LogManager.GetLogger(typeof(userrightsmanagement));

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}