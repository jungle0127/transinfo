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
        private ICountyDao countyinfos;
        private IUsersDao usersInfos;
        private ISpeciallinetypeDao speciallineType;
        private IDeparturetypeDao deparInfos;

        private string MessageString, MessageStringSingle, MessageStringGB;

        public string MessageStringGBHtml
        {
            get { return MessageStringGB; }
        }

        public string MessageStringSinglehtml
        {
            get { return MessageStringSingle; }
        }

        public string MessageStringhtml
        {
            get { return MessageString; }

        }


 

        public SpeciallineInfoList()
        {
            specialLineInfo = new SpeciallineinfoDao();
            placeInfoList = new PlaceinfoDao();
            countyinfos = new CountyDao();
            usersInfos = new UsersDao();
            speciallineType = new SpeciallinetypeDao();
            deparInfos = new DeparturetypeDao();
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
                //MessageBody.Append(enti.Sourceplaceinfoid);
                Placeinfo placeInformation = this.placeInfoList.Find(enti.Sourceplaceinfoid);
                MessageBody.Append(placeInformation.Address);
                MessageBody.Append("<span id=\"line_kuai\"><img class=\"imgSingleLine\" src=\"../../imgs/signle.jpg\" /></span>");
                placeInformation = this.placeInfoList.Find(enti.Destinationplaceinfoid);
                MessageBody.Append(placeInformation.Address);
                MessageBody.Append("</p><p class=\"title\"><a href=\"http://search.jt56.org/hnftwl.jt56.org\" target=\"_blank\">");
                Users usersEinfo = this.usersInfos.Find(enti.Userid);
                MessageBody.Append(usersEinfo.Username);
                MessageBody.Append("</a></p><div class=\"align_left\"><p class=\"title\">发车班次：<span id=\"Dark\">");
                Departuretype deparInfo = this.deparInfos.Find(enti.Departuretypeid);
                MessageBody.Append(deparInfo.Typename);
                MessageBody.Append("</span></p><p class=\"title\">运输时长：<span id=\"Dark\">");
                MessageBody.Append("***");


                MessageBody.Append("</span></p><p class=\"title\">重货：<span id=\"huo_color\">");
                MessageBody.Append(enti.Weightprice);
                MessageBody.Append("</span>元/公斤</p></div><div class=\"align_left\"><p class=\"title\">是否直达：<span id=\"Dark\">");
                Speciallinetype LineType = this.speciallineType.Find(enti.Speciallinetypeid);
                MessageBody.Append(LineType.Typename);//单程-往返
                MessageBody.Append("</span></p><p class=\"title\">运输方式：<span id=\"Dark\">");
                MessageBody.Append("***");

                MessageBody.Append("</span></p><p class=\"title\">泡货：<span id=\"huo_color\">");
                MessageBody.Append(enti.Volumeprice);
                MessageBody.Append("</span>元/方</p></div><div class=\"clear\"></div><div class=\"NEWS_button\"><a href=\"../InfoShow/SpeciallineInfoDetail.aspx?id=" + enti.Id.ToString() + "\" target=\"_blank\">查看详情</a></div></div>");


            }
            return MessageBody.ToString();

        }


        public string GetSingleMessageBody()
        {
            StringBuilder MessageBody = new StringBuilder();
            SpeciallineinfoPagination FindByPageSingle = new SpeciallineinfoPagination();
            FindByPageSingle.Limit = 6;
            FindByPageSingle.Offset = 0;
            FindByPageSingle.Speciallinetypeid = 2;
            IList<Speciallineinfo> specialLineAll = this.specialLineInfo.PaginationFindBySpeciallinetypeid(FindByPageSingle);
            foreach (Speciallineinfo enti in specialLineAll)
            {
                MessageBody.Append("<div id=\"line_infos\" class=\"line_infos\"><p class=\"NEWSline_text\">");
                //MessageBody.Append(enti.Sourceplaceinfoid);
                Placeinfo placeInformation = this.placeInfoList.Find(enti.Sourceplaceinfoid);
                MessageBody.Append(placeInformation.Address);
                MessageBody.Append("<span id=\"line_kuai\"><img class=\"imgSingleLine\" src=\"../../imgs/signle.jpg\" /></span>");
                placeInformation = this.placeInfoList.Find(enti.Destinationplaceinfoid);
                MessageBody.Append(placeInformation.Address);
                MessageBody.Append("</p><p class=\"title\"><a href=\"http://search.jt56.org/hnftwl.jt56.org\" target=\"_blank\">");
                Users usersEinfo = this.usersInfos.Find(enti.Userid);
                MessageBody.Append(usersEinfo.Username);
                MessageBody.Append("</a></p><div class=\"align_left\"><p class=\"title\">发车班次：<span id=\"Dark\">");
                Departuretype deparInfo = this.deparInfos.Find(enti.Departuretypeid);
                MessageBody.Append(deparInfo.Typename);
                MessageBody.Append("</span></p><p class=\"title\">运输时长：<span id=\"Dark\">");
                MessageBody.Append("***");


                MessageBody.Append("</span></p><p class=\"title\">重货：<span id=\"huo_color\">");
                MessageBody.Append(enti.Weightprice);
                MessageBody.Append("</span>元/公斤</p></div><div class=\"align_left\"><p class=\"title\">是否直达：<span id=\"Dark\">");
                Speciallinetype LineType = this.speciallineType.Find(enti.Speciallinetypeid);
                MessageBody.Append(LineType.Typename);//单程-往返
                MessageBody.Append("</span></p><p class=\"title\">运输方式：<span id=\"Dark\">");
                MessageBody.Append("***");

                MessageBody.Append("</span></p><p class=\"title\">泡货：<span id=\"huo_color\">");
                MessageBody.Append(enti.Volumeprice);
                MessageBody.Append("</span>元/方</p></div><div class=\"clear\"></div><div class=\"NEWS_button\"><a href=\"../InfoShow/SpeciallineInfoDetail.aspx" + enti.Id.ToString() + "\" target=\"_blank\">查看详情</a></div></div>");
            }
            return MessageBody.ToString();

        }

        public string GetGBMessageBody()
        {
            StringBuilder MessageBody = new StringBuilder();
            SpeciallineinfoPagination FindByPageGB = new SpeciallineinfoPagination();
            FindByPageGB.Limit = 6;
            FindByPageGB.Offset = 0;
            FindByPageGB.Speciallinetypeid = 1;
            IList<Speciallineinfo> specialLineAll = this.specialLineInfo.PaginationFindBySpeciallinetypeid(FindByPageGB);
            foreach (Speciallineinfo enti in specialLineAll)
            {
                MessageBody.Append("<div id=\"line_infos\" class=\"line_infos\"><p class=\"NEWSline_text\">");
                //MessageBody.Append(enti.Sourceplaceinfoid);
                Placeinfo placeInformation = this.placeInfoList.Find(enti.Sourceplaceinfoid);
                MessageBody.Append(placeInformation.Address);
                MessageBody.Append("<span id=\"line_kuai\"><img class=\"imgSingleLine\" src=\"../../imgs/signle.jpg\" /></span>");
                placeInformation = this.placeInfoList.Find(enti.Destinationplaceinfoid);
                MessageBody.Append(placeInformation.Address);
                MessageBody.Append("</p><p class=\"title\"><a href=\"http://search.jt56.org/hnftwl.jt56.org\" target=\"_blank\">");
                Users usersEinfo = this.usersInfos.Find(enti.Userid);
                MessageBody.Append(usersEinfo.Username);
                MessageBody.Append("</a></p><div class=\"align_left\"><p class=\"title\">发车班次：<span id=\"Dark\">");
                Departuretype deparInfo = this.deparInfos.Find(enti.Departuretypeid);
                MessageBody.Append(deparInfo.Typename);
                MessageBody.Append("</span></p><p class=\"title\">运输时长：<span id=\"Dark\">");
                MessageBody.Append("***");


                MessageBody.Append("</span></p><p class=\"title\">重货：<span id=\"huo_color\">");
                MessageBody.Append(enti.Weightprice);
                MessageBody.Append("</span>元/公斤</p></div><div class=\"align_left\"><p class=\"title\">是否直达：<span id=\"Dark\">");
                Speciallinetype LineType = this.speciallineType.Find(enti.Speciallinetypeid);
                MessageBody.Append(LineType.Typename);//单程-往返
                MessageBody.Append("</span></p><p class=\"title\">运输方式：<span id=\"Dark\">");
                MessageBody.Append("***");

                MessageBody.Append("</span></p><p class=\"title\">泡货：<span id=\"huo_color\">");
                MessageBody.Append(enti.Volumeprice);
                MessageBody.Append("</span>元/方</p></div><div class=\"clear\"></div><div class=\"NEWS_button\"><a href=\"../InfoShow/SpeciallineInfoDetail.aspx" + enti.Id.ToString() + "\" target=\"_blank\">查看详情</a></div></div>");
            }
            return MessageBody.ToString();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            MessageString = GetALLMessageBody();
            MessageStringSingle = GetGBMessageBody();
            MessageStringGB = GetSingleMessageBody();

        }
    }
}