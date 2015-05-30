using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using System.Text;
using Trans.DAL.Entity;




namespace Trans.InfoShow
{
    public partial class DepotInfoDetail : System.Web.UI.Page
    {
        private IVdepotinformationDao v_depotInformation;
        private string MessageForPage;

        public string MessageForPageHtml
        {
            get { return MessageForPage; }
        }

        public DepotInfoDetail()
        {
            v_depotInformation = new VdepotinformationDao();
        }

        public string GetMessageBody()
        {
            StringBuilder MessageBody = new StringBuilder();
            Int32 idformes = Convert.ToInt32(Request.QueryString["id".ToString()]);
            IList<Vdepotinformation> detailForDepots = this.v_depotInformation.FindById(idformes);
            MessageBody.Append("<tbody><tr class=\"infoTitle\"><td><p id=\"infoTitle\" class=\"pInfoTitle\">");
            MessageBody.Append(detailForDepots[0].Title);
            MessageBody.Append("</p><hr class=\"hr1\" /></td></tr><tr><td class=\"infoDetail\"><table><tbody><tr><td class=\"infoPic\"><div id=\"infoPic\"><!--<img src=\"#\" class=\"imgInfoPic\" />--></div></td><td class=\"infoContacts\"><table><tbody><tr><td class=\"firstTd\">发布时间：</td><td class=\"secTd\"><span class=\"spanInfotime\">");
            MessageBody.Append(detailForDepots[0].Validtime);
            MessageBody.Append("</span></td></tr><tr><td class=\"firstTd\">联系人：</td><td class=\"secTd\"><span class=\"spanContactor\">");
            MessageBody.Append(detailForDepots[0].Username);
            MessageBody.Append("</span></td></tr><tr><td class=\"firstTd\">联系电话：</td><td class=\"secTd\"><span class=\"spanContacts\">");
            MessageBody.Append(detailForDepots[0].Cellphone);
            MessageBody.Append("</span></td></tr><tr><td><hr /></td><td><hr /></td></tr><tr><td class=\"firstTd\">仓库类型：</td><td class=\"secTd\"><span class=\"spanStorageType\">");
            MessageBody.Append(detailForDepots[0].Depottypename);
            MessageBody.Append("</span></td></tr><tr><td class=\"firstTd\">经营范围：</td><td class=\"secTd\"><span class=\"spanScorp\">");
            MessageBody.Append(detailForDepots[0].Depottypename);
            MessageBody.Append("</span></td></tr><tr><td class=\"firstTd\">总面积：</td><td class=\"secTd\"><span class=\"spanTotalArea\">");
            MessageBody.Append(detailForDepots[0].Area);
            MessageBody.Append("</span></td></tr><tr><td class=\"firstTd\">可用面积：</td><td class=\"secTd\"><span class=\"spanUseableArea\">");
            MessageBody.Append(detailForDepots[0].Useablearea);
            MessageBody.Append("</span></td></tr><tr><td class=\"firstTd\">参考价：</td><td class=\"secTd\"><span class=\"spanPrice\">");
            MessageBody.Append(detailForDepots[0].Price);
            MessageBody.Append("</span></td></<tr><td class=\"firstTd\">仓库地址：</td><td class=\"secTd\"><span class=\"spanStorageAdr\">");
            MessageBody.Append(detailForDepots[0].Address);
            MessageBody.Append("</span></td></tr><tr><td><hr /></td><td><hr /></td></tr><tr><td class=\"firstTd\">特殊说明 ：</td><td class=\"secTd\"><span class=\"spanPrice\">");
            MessageBody.Append(detailForDepots[0].Description);
            MessageBody.Append("</span></td></tr></tbody></table></td></tr></tbody></table></td></tr><tr><td></td></tr></tbody>");
            return MessageBody.ToString();
        }



        protected void Page_Load(object sender, EventArgs e)
        {

            MessageForPage = GetMessageBody();


        }
    }
}