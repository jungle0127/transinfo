using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Entity;
using Trans.DAL.Dao;
using System.Text;


namespace Trans.InfoShow
{
    public partial class SpeciallineInfoDetail : System.Web.UI.Page
    {
        private ISpeciallineinfoDao specialLineinfosList;
        private ISpeciallinetypeDao specialLineTypeList;
        private IVspeciallineinfoDao v_specialLine;
        

        public SpeciallineInfoDetail()
        {
            specialLineinfosList = new SpeciallineinfoDao();
            specialLineTypeList = new SpeciallinetypeDao();
            v_specialLine = new VspeciallineinfoDao();
            
        }
        public string getmessagebody()
        {
            StringBuilder MessageShow = new StringBuilder();
            Int32 idformes = Convert.ToInt32(Request.QueryString["id".ToString()]);
            IList<Vspeciallineinfo> specialLineDetailView = this.v_specialLine.FindById(idformes);
            //Speciallineinfo LineInfos = this.specialLineinfosList.Find(idformes);
            MessageShow.Append("<tbody><tr class=\"infoTitle\"><td><p id=\"infoTitle\" class=\"pInfoTitle\">");
            MessageShow.Append(specialLineDetailView[0].Title);
            MessageShow.Append("</p><hr class=\"hr1\" /></td></tr><tr><td class=\"infoDetail\"><table><tbody><tr><td class=\"infoPic\"><div id=\"infoPic\"><img src=\"../../imgs/companys/4.jpg\" class=\"imgInfoPic\" /></div></td><td class=\"infoContacts\"><table><tbody><tr><td class=\"firstTd\">发布时间：</td><td class=\"secTd\"><span class=\"spanInfotime\">");
            //MessageShow.Append();




            return MessageShow.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}