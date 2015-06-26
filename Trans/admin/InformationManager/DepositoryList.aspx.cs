using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;
using Trans.DAL.Dao;
using Trans.DAL.IDao;

namespace Trans.admin.InformationManager
{
    public partial class DepositoryList : Trans.App_Code.Biz.Common.SessionCheckPageBase
    {
        public DepositoryList() : base()
        {
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}