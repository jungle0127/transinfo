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
    public partial class NewsList : System.Web.UI.Page
    {
        private IVarticleinfoDao articleInfo;
        private string MessageBody;
        private string AnnounceMess;
        private string NoticeMess;

        public string NoticeMessFront
        {
            get { return NoticeMess; }
        }

        public string AnnounceMessFront
        {
            get { return AnnounceMess; }
        }

        public string MessageBodyFront
        {
            get { return MessageBody; }
        }

        public NewsList()
        {
            articleInfo = new VarticleinfoDao();
        }

        public string GetMessageBody()
        {
            StringBuilder messageShow = new StringBuilder();
            IList<Varticleinfo> articleInfoDetail = this.articleInfo.FindAll();
            messageShow.Append("<a  href=\"../InfoShow/NewsInfoDetail.aspx?id="+ articleInfoDetail[0].Id.ToString() + "\" class=\"newsTitle\" id=\"newsTitle\">");
            messageShow.Append(articleInfoDetail[0].Title);
            messageShow.Append("</a><h5 class=\"gray\">发布日期：<span id=\"deliverDate\">");
            messageShow.Append(articleInfoDetail[0].Releasedate);
            messageShow.Append("</span></h5><p class=\"newsContent\">");
            messageShow.Append(articleInfoDetail[0].Content);
            messageShow.Append("</p>");

            return messageShow.ToString();
        }

        public string GetNoticeMessage()
        {
            StringBuilder MessageShow = new StringBuilder();
            IList<Varticleinfo> articleInfoDetail = this.articleInfo.FindByTypeid(1);
            for (int i = 0; i < 5; i++)
            {
                MessageShow.Append("<tr><td width=\"90%\"><a href=\"../InfoShow/NewsInfoDetail.aspx?id=" + articleInfoDetail[i].Id.ToString() + "\" >");
                MessageShow.Append(articleInfoDetail[i].Title);
                MessageShow.Append("</a></td><td width=\"10%\">");
                MessageShow.Append(articleInfoDetail[i].Releasedate);
                MessageShow.Append("</td></tr>");
            }
                return MessageShow.ToString();
        }

        public string GetAnnounceMessage()
        {
            StringBuilder MessageShow = new StringBuilder();
            IList<Varticleinfo> articleInfoDetail = this.articleInfo.FindByTypeid(2);
            for (int i = 0; i < 5; i++)
            {
                MessageShow.Append("<tr><td width=\"90%\"><a href=\"../InfoShow/NewsInfoDetail.aspx?id=" + articleInfoDetail[i].Id.ToString() + "\" >");
                MessageShow.Append(articleInfoDetail[i].Title);
                MessageShow.Append("</a></td><td width=\"10%\">");
                MessageShow.Append(articleInfoDetail[i].Releasedate);
                MessageShow.Append("</td></tr>");
            }
            return MessageShow.ToString();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            MessageBody = GetMessageBody();
            AnnounceMess = GetNoticeMessage();
            NoticeMess = GetAnnounceMessage();
        }
    }
}