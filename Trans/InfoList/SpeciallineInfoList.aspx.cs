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
    public partial class SpeciallineInfoList : System.Web.UI.Page
    {
        private ISpeciallineinfoDao specialLineInfo;
        private IPlaceinfoDao placeInfoList;

        public SpeciallineInfoList()
        {
            specialLineInfo = new SpeciallineinfoDao();
            placeInfoList = new PlaceinfoDao();
        }


        public string GetALLMessageBody()
        {
            StringBuilder MessageBody = new StringBuilder();
            SpeciallineinfoPagination FindByPageAll = new SpeciallineinfoPagination();
            FindByPageAll.Limit=6;
            FindByPageAll.Offset=0;
            IList<Speciallineinfo> specialLineAll = this.specialLineInfo.PaginationFindAll(FindByPageAll);
            foreach (Speciallineinfo enti in specialLineAll)
            {
                MessageBody.Append("<div id=\"line_infos\" class=\"line_infos\"><p class=\"NEWSline_text\">");
                MessageBody.Append(enti.Sourceplaceinfoid);
            }


            return MessageBody.ToString();

        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}