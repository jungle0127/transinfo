using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Entity;
using Trans.DAL.Dao;
using System.Text;



namespace Trans.InfoList
{
    public partial class DepotInfoList : System.Web.UI.Page
    {
        private IDepotinformationDao depotInformationList;

        public DepotInfoList()
        {
            depotInformationList = new DepotinformationDao();
        }

        public string GetMessageBody()
        {
            StringBuilder MessageBody = new StringBuilder();
            MessageBody.Append("<tr><td class=\"infoDeatil\"><div class=\"storePic\"></div><div class=\"overFloat\"><a href=\"../InfoShow/DepotInfoDetail.aspx\"><h4 class=\"infoTitle\">");
           // IList<Depotinformation>




            return MessageBody.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}