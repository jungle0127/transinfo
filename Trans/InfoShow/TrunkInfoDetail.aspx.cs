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
    public partial class TrunkInfoDetail : System.Web.UI.Page
    {
        private ITrunkinformationDao trunkinfos;
        private ITrunkmetadataDao trunkMeta;
        private ICountyDao countyTable;
        private ITrunktypeDao trunkTypeinfo;
        public TrunkInfoDetail()
        {
            trunkinfos = new TrunkinformationDao();
            trunkMeta = new TrunkmetadataDao();
            countyTable = new CountyDao();
            trunkTypeinfo = new TrunktypeDao();
        }
        private string messageforhtml;

        public string Messageforhtml
        {
            get { return messageforhtml; }
        }


        public string GetMessageBody()
        {
            StringBuilder MessageShow=new StringBuilder();
            Int32 idformes = Convert.ToInt32(Request.QueryString["id".ToString()]);
            Trunkinformation detailForTrunk = this.trunkinfos.Find(idformes);
            //开始组装html
            
            MessageShow.Append("<tr><td class=\"right-leftSide\"><table><tbody><tr class=\"infoTitle\"><td><p id=\"infoTitle\" class=\"pInfoTitle\">");
            MessageShow.Append(detailForTrunk.Title);
            MessageShow.Append("</p><hr class=\"hr1\" /></td></tr><tr><td class=\"infoDetail\"><table><tbody><tr><td class=\"infoPic\"><div id=\"infoPic\"><img src=\"../../imgs/companys/4.jpg\" class=\"imgInfoPic\" /></div></td><td class=\"infoContacts\"><table><tbody><tr><td class=\"firstTd\">发布时间：</td><td class=\"secTd\"><span class=\"spanInfotime\">");
            MessageShow.Append(detailForTrunk.Releasedate);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\">联系人：</td><td class=\"secTd\"><span class=\"spanContactor\">");
            Trunkmetadata trunkownerDetails = this.trunkMeta.Find(detailForTrunk.Trunkid);
            MessageShow.Append(trunkownerDetails.Contactpersonname);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\">联系电话：</td><td class=\"secTd\"><span class=\"spanContacts\">");
            MessageShow.Append(trunkownerDetails.Conatactphone);
            MessageShow.Append("</span></td></tr><tr><td><hr /></td><td><hr /></td></tr><tr><td class=\"firstTd\">启运地：</td><td class=\"secTd\"><span class=\"spanBeginAdr\">");
            IList<County> countyinfos = this.countyTable.FindByCode(detailForTrunk.Srccountycode);
            MessageShow.Append(countyinfos[0].Name);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\">目的地：</td><td class=\"secTd\"><span class=\"spanEndAdr\">");
            countyinfos = this.countyTable.FindByCode(detailForTrunk.Dstcountycode);
            MessageShow.Append(countyinfos[0].Name);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\">类型：</td><td class=\"secTd\"><span class=\"spanType\">");

            Trunktype trunktypes = this.trunkTypeinfo.Find(trunkownerDetails.Trunktypeid);
            MessageShow.Append(trunktypes.Typename);
            MessageShow.Append("</span></td></tr><tr><td class=\"firstTd\">何时需要：</td><td class=\"secTd\"><span class=\"spanTimeToUse\">");
            if (detailForTrunk.Timetypeid == 0)
            {
                MessageShow.Append("即时车源");
            }
            else
            {
                MessageShow.Append("长期车源");
            }
            MessageShow.Append("</span></td></tr><tr><td><hr /></td><td><hr /></td></tr><tr><td class=\"firstTd\">特殊说明 ：</td><td class=\"secTd\"><span class=\"spanPrice\">");
            MessageShow.Append(detailForTrunk.Description);
            MessageShow.Append("</span></td></tr></tbody></table></td></tr></tbody></table></td></tr><tr><td></td></tr></tbody></table></td><td class=\"right-rightSide\"><div class=\"deliverInfoNum\">已发布信息：<span class=\"spanLorryInfoNum\">");
            MessageShow.Append("待获取数据");
            MessageShow.Append("</span>条</div><div></div></td></tr>");

            return MessageShow.ToString();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Request.QueryString["id"].ToString());
            messageforhtml = GetMessageBody();
        }
    }
}