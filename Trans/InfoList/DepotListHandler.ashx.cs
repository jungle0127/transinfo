using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using Trans.DAL.Dao;
using System.IO;
using Trans.DAL.Entity;
using Trans.Biz.Common;
using System.Text;




namespace Trans.InfoList
{
    /// <summary>
    /// Summary description for DepotListHandler
    /// </summary>
    public class DepotListHandler : IHttpHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(ArticleListHandler));
        private IVdepotinformationDao vDepotInfoDao;

        public DepotListHandler()
        {
            this.vDepotInfoDao = new VdepotinformationDao();
        }




        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.RequestType == "POST")
            {// POST
                StreamReader streamReader = new StreamReader(context.Request.InputStream);
                string typeId = streamReader.ReadToEnd();
                logger.Info("Got news type parameter:" + typeId);
                Vtrunkinformation poco = new Vtrunkinformation();

                int count = this.vDepotInfoDao.FindAll().Count;
                logger.Info("got item count:" + count.ToString());
                context.Response.ContentType = "text/plain";
                context.Response.Write(count);
            }
            else
            {// GET
                string pageNumber = context.Request.QueryString["pageNumber"].ToString();
                logger.Info("Got page number:" + pageNumber);
                string pageSize = context.Request.QueryString["pageSize"].ToString();
                logger.Info("Got page size:" + pageSize);
                string tableHtml = this.generateDepotInfoHtml(pageNumber, pageSize);
                context.Response.ContentType = "text/plain";
                context.Response.Write(tableHtml);
            }
        }

        public string generateDepotInfoHtml(string pageNumber, string pageSize)
        {
            VdepotinformationPagination pageNationPoco = new VdepotinformationPagination();
            pageNationPoco.Limit = int.Parse(pageSize);

            pageNationPoco.Offset = (int.Parse(pageNumber) - 1) * pageNationPoco.Limit;
            logger.Info("Got offset:" + pageNationPoco.Offset.ToString());
            //pageNationPoco = long.Parse(typeId);
            IList<Vdepotinformation> trunksInfoList = this.vDepotInfoDao.DescendOrderPaginationFindAll(pageNationPoco);
            logger.Info("Got items:" + trunksInfoList.Count.ToString());
            string tableHtml = this.getTableHtml(this.getTableBodyHtml(trunksInfoList));
            logger.Info("table html:" + tableHtml);
            return tableHtml;
        }


        private string getTableHtml(string bodyHtml)
        {
            StringBuilder htmlBuilder = new StringBuilder();
            htmlBuilder.Append("<table class=\"table table-hover showStoreInfo\"><caption><div id=\"tableCaption\" style=\"padding-top:3px;\"><img src=\"../../imgs/pack-2.png\">仓储信息</div><span class=\"tableMiddle\"><div class=\"tableMiddle\">相信您在这可以很快找到心仪的货源，祝您生活愉快！</div></span></caption><thead><tr class=\"headTr\"><th>信息内容</th><th>发布时间</th><th>参考报价</th><th>立即查看</th></tr></thead>");
            htmlBuilder.Append("<tbody>");
            //htmlBuilder.Append("<thead>");
            //htmlBuilder.Append("<th  width=\"90%\">标题");
            //htmlBuilder.Append("</th>");
            //htmlBuilder.Append("<th  width=\"10%\">发布时间");
            //htmlBuilder.Append("</th>");
            //htmlBuilder.Append("</thead>");
            htmlBuilder.Append(bodyHtml);
            htmlBuilder.Append("</tbody>");
            htmlBuilder.Append("</table>");
            return htmlBuilder.ToString();
        }



        private string getTableBodyHtml(IList<Vdepotinformation> depotInfoList)
        {
            StringBuilder bodyBuilder = new StringBuilder();
            foreach (Vdepotinformation depotInfoPoco in depotInfoList)
            {
                bodyBuilder.Append("<tr>");
                bodyBuilder.Append("<td class=\"infoDeatil\">");
                bodyBuilder.Append("<div class=\"storePic\"></div><div class=\"overFloat\"><a href=\"../InfoShow/DetailInfoFrame.aspx?type=depot&id=" + depotInfoPoco.Id.ToString() + "\"><h4 class=\"infoTitle\" >");
                bodyBuilder.Append(depotInfoPoco.Title);
                bodyBuilder.Append("</h4></a><span class=\"light-info\">面积：</span><span class=\"infos\" id=\"totalArea\">");
                bodyBuilder.Append(depotInfoPoco.Area);
                bodyBuilder.Append("</span>|<span class=\"light-info\">可用面积：</span><span class=\"infos\" id=\"useableArea\">");
                bodyBuilder.Append(depotInfoPoco.Useablearea);
                bodyBuilder.Append("</span><p><span class=\"light-info\">仓库类型：</span><span class=\"infos\" id=\"storeType\">");
                bodyBuilder.Append(depotInfoPoco.Depottypename);
                bodyBuilder.Append("</span>|<span class=\"light-info\">信息来源：</span><a  href=\"#\" class=\"infos_companyN\">");
                bodyBuilder.Append(depotInfoPoco.Username);
                bodyBuilder.Append("</a></p></div></td><td><span class=\"infos\" id=\"publishTime\">");
                bodyBuilder.Append(depotInfoPoco.Validtime);
                bodyBuilder.Append("</span></td><td><span  id=\"prePrice\">");
                bodyBuilder.Append(depotInfoPoco.Price);
                bodyBuilder.Append("</span></td><td><a class=\"moreBottn\" href=\"../InfoShow/DetailInfoFrame.aspx?type=depot&id=" + depotInfoPoco.Id.ToString() + "\" target=\"_blank\"><img src=\"../../imgs/plus_alt.png\" id=\"moreBtn\"></a></td></tr>");

            }
            return bodyBuilder.ToString();
        }








        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}