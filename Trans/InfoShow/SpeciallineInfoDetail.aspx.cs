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
        //private ISpeciallineinfoDao specialLineinfosList;
        //private ISpeciallinetypeDao specialLineTypeList;
        private IVspeciallineinfoDao v_specialLine;
        private string HtmlMessageBody;

        public string HtmlMessageBodyPage
        {
            get { return HtmlMessageBody; }
        }
        

        public SpeciallineInfoDetail()
        {
            //specialLineinfosList = new SpeciallineinfoDao();
            //specialLineTypeList = new SpeciallinetypeDao();
            v_specialLine = new VspeciallineinfoDao();
            
        }
        public string getMessageBody()
        {
            StringBuilder MessageShow = new StringBuilder();
            Int32 idformes = Convert.ToInt32(Request.QueryString["id".ToString()]);
            IList<Vspeciallineinfo> specialLineDetailView = this.v_specialLine.FindById(idformes);
            //Speciallineinfo LineInfos = this.specialLineinfosList.Find(idformes);
            MessageShow.Append("<tbody><tr class=\"infoTitle\"><td><p id=\"infoTitle\" class=\"pInfoTitle\">");
            MessageShow.Append(specialLineDetailView[0].Title);
            MessageShow.Append("</p><hr class=\"hr1\" /></td></tr><tr><td class=\"infoDetail\"><table><tbody><tr><td class=\"infoPic\"><div id=\"infoPic\"><img src=\"../../imgs/companys/4.jpg\" class=\"imgInfoPic\" /></div></td><td class=\"infoContacts\"><table><tbody><tr><td class=\"firstTd\">发布时间：</td><td class=\"secTd\"><span class=\"spanInfotime\">");
            MessageShow.Append(specialLineDetailView[0].Releasedate);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\">发布人：</td><td class=\"secTd\"><span class=\"spanContactor\">");
            MessageShow.Append(specialLineDetailView[0].Username);
            MessageShow.Append("</span></td></tr><tr><td><hr /></td><td><hr /></td></tr><tr><td class=\"firstTd\">启运地：</td><td class=\"secTd\"><span class=\"spanBeginAdr\">");
            MessageShow.Append(specialLineDetailView[0].Srccityname);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\">目的地：</td><td class=\"secTd\"><span class=\"spanEndAdr\">");
            MessageShow.Append(specialLineDetailView[0].Dstcityname);
            MessageShow.Append("</span></td></tr></tbody></table></td></tr></tbody></table></td></tr><tr><td><table><caption></caption><tbody><tr><td class=\"firstTd\">重货价格：</td><td class=\"secTd\"><span class=\"spanHeavyPrice\">");
            MessageShow.Append(specialLineDetailView[0].Weightprice);
            MessageShow.Append("</span></td><td class=\"firstTd\">泡货价格：</td><td class=\"secTd\"><span class=\"spanPaoPrice\">");
            MessageShow.Append(specialLineDetailView[0].Volumeprice);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\">专线类型：</td><td class=\"secTd\"><span class=\"spanTransWay\">");
            MessageShow.Append(specialLineDetailView[0].Speciallinetypename);
            MessageShow.Append("</span></td><td class=\"firstTd\">发车班次：</td><td class=\"secTd\"><span class=\"spanTransTimes\">");
            MessageShow.Append(specialLineDetailView[0].Departuretypename);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\"></td><td class=\"secTd\"><span class=\"spanTransHover\">");
            //MessageShow.Append(specialLineDetailView[0].Departuretypename);
            MessageShow.Append("</span></td><td class=\"firstTd\"></td><td class=\"secTd\"><span class=\"spanEndAdr\">");
            //MessageShow.Append(specialLineDetailView[0].);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\">始发地址：</td><td class=\"secTd\"><span class=\"spanBeginPlace\">");
            MessageShow.Append(specialLineDetailView[0].Srcregionname);
            MessageShow.Append("</span></td><td class=\"firstTd\">联系人：</td><td class=\"secTd\"><span class=\"spanBeginPlaceCont\">");
            MessageShow.Append(specialLineDetailView[0].Srccontactcellphone+" "+specialLineDetailView[0].Srccontactpersonname);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\">目的地址：</td><td class=\"secTd\"><span class=\"spanEndPlace\">");
            MessageShow.Append(specialLineDetailView[0].Dstregionname);
            MessageShow.Append("</span></td><td class=\"firstTd\">联系人：</td><td class=\"secTd\"><span class=\"spanEndPlaceCont\">");
            MessageShow.Append(specialLineDetailView[0].Dstcontactcellphone + " " + specialLineDetailView[0].Dstcontactpersonname);
            MessageShow.Append("</span></td></tr></tbody></table></td></tr></tbody>");
            return MessageShow.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlMessageBody = getMessageBody();
        }
    }
}