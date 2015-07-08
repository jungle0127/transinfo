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
    public partial class NewsInfoDetail : System.Web.UI.Page
    {
        private IVarticleinfoDao articleInfos;
        private string MessageBody;

        public string MessageBodyFront
        {
            get { return MessageBody; }
        }

        public NewsInfoDetail()
        {
            articleInfos = new VarticleinfoDao();
        }

        public string GetMessageBody()
        {
            StringBuilder MessageShow = new StringBuilder();
            Int32 idformes = Convert.ToInt32(Request.QueryString["id".ToString()]);
            IList<Varticleinfo> articleDetail = this.articleInfos.FindById(idformes);
            int preNum=0, nextNum = 0;

            MessageShow.Append("<div class=\"searchSelectionFrame infoDetail\"><p class=\"newsTitle\" id=\"title\">");
            MessageShow.Append(articleDetail[0].Title);
            MessageShow.Append("</p><center><p>发布日期：<span id=\"deliverDate\" class=\"gray\">");
            MessageShow.Append(articleDetail[0].Releasedate);
            MessageShow.Append("</span>&nbsp;&nbsp;访问次数：<span id=\"visitTimes\" class=\"gray\">");
            MessageShow.Append(articleDetail[0].Hittimes+1);

            try
            {
                IList<Varticleinfo> Prearticle = this.articleInfos.FindById(articleDetail[0].Id - 1);
                preNum = 1;
                string title = Prearticle[0].Title;
            }
            catch
            {
                preNum = 0;
            }
            try
            {
                IList<Varticleinfo> Nextarticle = this.articleInfos.FindById(articleDetail[0].Id + 1);
                nextNum = 1;
                string tittle = Nextarticle[0].Title;
            }
            catch
            {
                nextNum = 0;
            }


            if (preNum==1)
            {
                IList<Varticleinfo> Prearticle = this.articleInfos.FindById(articleDetail[0].Id - 1);
                MessageShow.Append("</span></p></center><table width=\"100%\"><tr><td class=\"preSwitch\"><a class=\"green\" href=\"");
                MessageShow.Append("../InfoShow/NewsInfoDetail.aspx?id=");
                MessageShow.Append(articleDetail[0].Id - 1);
                MessageShow.Append("\">上一篇:<span id=\"preArticle\">");
                MessageShow.Append(Prearticle[0].Title);
            }
            else
            {
                MessageShow.Append("</span></p></center><table width=\"100%\"><tr><td class=\"preSwitch\"><a class=\"green\" href=\"");
                MessageShow.Append("#");
                MessageShow.Append("\">上一篇:<span id=\"preArticle\">");
                MessageShow.Append("空");

            }

            if(nextNum==1)
            {
                IList<Varticleinfo> Nextarticle = this.articleInfos.FindById(articleDetail[0].Id + 1);
                MessageShow.Append("</span></a></td><td class=\"nextSwitch\"><a class=\"green\" href=\"");
                MessageShow.Append("../InfoShow/NewsInfoDetail.aspx?id=");
                MessageShow.Append(articleDetail[0].Id + 1);


                MessageShow.Append("\">下一篇:<span id=\"nextArticle\">");
                MessageShow.Append(Nextarticle[0].Title);
            }
            else
            {
                MessageShow.Append("</span></a></td><td class=\"nextSwitch\"><a class=\"green\" href=\"");
                MessageShow.Append("#");


                MessageShow.Append("\">下一篇:<span id=\"nextArticle\">");
                MessageShow.Append("空");

            }

            MessageShow.Append("</span></a></td></tr></table><hr style=\"margin-top:5px;\"><div class=\"newsContent newsDetail\"><div id=\"content\">");
            MessageShow.Append(articleDetail[0].Content);
            MessageShow.Append("</div></div><hr style=\"margin-bottom:0;\"><table width=\"100%\"><tr><td class=\"preSwitch\"><a class=\"green\" href=\"");

            if(preNum==1)
            {
                IList<Varticleinfo> Prearticle = this.articleInfos.FindById(articleDetail[0].Id - 1);
                MessageShow.Append("../InfoShow/NewsInfoDetail.aspx?id=");
                MessageShow.Append(articleDetail[0].Id - 1);
                MessageShow.Append("\">上一篇:<span id=\"preArticle\">");
                MessageShow.Append(Prearticle[0].Title);
            }
            else
            {
                MessageShow.Append("#");
                MessageShow.Append("\">上一篇:<span id=\"preArticle\">");
                MessageShow.Append("空");
            }
            MessageShow.Append("</span></a></td><td class=\"nextSwitch\"><a class=\"green\" href=\"");

            if(nextNum==1)
            {
                IList<Varticleinfo> Nextarticle = this.articleInfos.FindById(articleDetail[0].Id + 1);
                MessageShow.Append("../InfoShow/NewsInfoDetail.aspx?id=");
                MessageShow.Append(articleDetail[0].Id + 1);
                MessageShow.Append("\">下一篇:<span id=\"nextArticle\">");
                MessageShow.Append(Nextarticle[0].Title);
            }
            else
            {
                MessageShow.Append("#");
                MessageShow.Append("\">下一篇:<span id=\"nextArticle\">");
                MessageShow.Append("空");
            }



            MessageShow.Append("</span></a></td></tr></table></div>");
            return MessageShow.ToString();
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            MessageBody = GetMessageBody();
        }
    }
}