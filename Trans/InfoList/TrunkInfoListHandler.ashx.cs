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
    /// Summary description for TrunkInfoListHandler
    /// </summary>
    public class TrunkInfoListHandler : IHttpHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(ArticleListHandler));
        private IVtrunkinformationDao vTrunkInfoDao;
        public TrunkInfoListHandler()
        {
            this.vTrunkInfoDao = new VtrunkinformationDao();
        }

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.RequestType == "POST")
            {// POST
                StreamReader streamReader = new StreamReader(context.Request.InputStream);
                string typeId = streamReader.ReadToEnd();
                logger.Info("Got news type parameter:" + typeId);
                Vtrunkinformation poco = new Vtrunkinformation();

                int count = this.vTrunkInfoDao.FindAll().Count;
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
                string tableHtml = this.generateTrunksInfoHtml(pageNumber, pageSize);
                context.Response.ContentType = "text/plain";
                context.Response.Write(tableHtml);
            }
        }

        public string generateTrunksInfoHtml(string pageNumber, string pageSize)
        {
            VtrunkinformationPagination pageNationPoco = new VtrunkinformationPagination();
            pageNationPoco.Limit = int.Parse(pageSize);

            pageNationPoco.Offset = (int.Parse(pageNumber) - 1) * pageNationPoco.Limit;
            logger.Info("Got offset:" + pageNationPoco.Offset.ToString());
            //pageNationPoco = long.Parse(typeId);
            IList<Vtrunkinformation> trunksInfoList = this.vTrunkInfoDao.DescendOrderPaginationFindAll(pageNationPoco);
            logger.Info("Got items:" + trunksInfoList.Count.ToString());
            string tableHtml = this.getTableHtml(this.getTableBodyHtml(trunksInfoList));
            logger.Info("table html:" + tableHtml);
            return tableHtml;
        }


        private string getTableHtml(string bodyHtml)
        {
            StringBuilder htmlBuilder = new StringBuilder();
            htmlBuilder.Append("<table class=\"table table-hover lorryList\"><caption><div id=\"tableCaption\" style=\"padding-top:3px;\"><img src=\"../../imgs/lorry.png\">车源信息</div><span class=\"tableMiddle\"><div class=\"tableMiddle\">相信您在这可以很快找到心仪的货源，祝您生活愉快！</div></span></caption><thead><tr class=\"headTr\"><th>信息内容</th><th>发布时间</th><th>所在地</th><th>立即查看</th></tr></thead>");
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

        private string getTableBodyHtml(IList<Vtrunkinformation> trunksInfoList)
        {
            StringBuilder bodyBuilder = new StringBuilder();
            foreach (Vtrunkinformation trunksInfoPoco in trunksInfoList)
            {
                bodyBuilder.Append("<tr>");
                bodyBuilder.Append("<td  width=\"50%\">");
                bodyBuilder.Append("<a target=\"_blank\" href=\"../InfoShow/DetailInfoFrame.aspx?type=trunk&id=" + trunksInfoPoco.Id.ToString() + "\" class=\"infoTitle h4LorryInfoTitle\" >");
                bodyBuilder.Append(trunksInfoPoco.Title);
                bodyBuilder.Append("</a><p><span class=\"light-info\">车辆长度：</span><span class=\"infos spanLorryLength\" id=\"carLength\">");
                bodyBuilder.Append(trunksInfoPoco.Length);
                bodyBuilder.Append("</span>|<span class=\"light-info\">载重：</span><span class=\"infos spanLorryWeight\" id=\"carWeight\">");
                bodyBuilder.Append(trunksInfoPoco.Weightcapacity);
                bodyBuilder.Append("</span></p><p><span class=\"light-info\">信息来源：</span><a  href=\"#\" class=\"lorryCompanyLink\">");
                bodyBuilder.Append(trunksInfoPoco.Username);
                bodyBuilder.Append("</a></p></td><td><span class=\"infos lorryPublishTime\" id=\"publishTime\">");
                bodyBuilder.Append(trunksInfoPoco.Releasedate);
                bodyBuilder.Append("</span></td><td><span  class=\"spanLorryPlace\">");
                bodyBuilder.Append(trunksInfoPoco.Srccityname);
                bodyBuilder.Append("</span></td><td><a class=\"moreBottn\" href=\"../InfoShow/DetailInfoFrame.aspx?type=trunk&id=" + trunksInfoPoco.Id.ToString() + "\" target=\"_blank\"><img src=\"../../imgs/plus_alt.png\" id=\"moreBtn\"></a></td></tr>");

            }
            return bodyBuilder.ToString();
        }






        //private static ILog logger = LogManager.GetLogger(typeof(TrunkInfoListHandler));
        //private ITrunkinformationDao trunksInfoDao;
        //private ITableGenerator tableGenerator;
        //public TrunkInfoListHandler()
        //{
        //    this.trunksInfoDao = new TrunkinformationDao();
        //    this.tableGenerator = new TableGenerator();
        //    logger.Info("Constructor method done.");
        //}



        //public void ProcessRequest(HttpContext context)
        //{
        //    if (context.Request.RequestType == "POST")
        //    {
        //        logger.Info("Request type is POST.");
        //        context.Response.ContentType = "text/plain";
        //        StreamReader streamReader = new StreamReader(context.Request.InputStream);
        //        string userId = streamReader.ReadToEnd();
        //        logger.Info("Got the request parameter UserID:" + userId);
        //        Trunkinformation trunksInfoPoco = new Trunkinformation();
        //        long userIdLong = -1;
        //        bool result = long.TryParse(userId, out userIdLong);
        //        if (!result)
        //        {
        //            logger.Error("Trunks ID is invalid.");
        //            context.Response.Write("-1");
        //        }
        //        trunksInfoPoco.Userid = userIdLong;
        //        int itemCount = this.trunksInfoDao.FindCountByUserid(trunksInfoPoco);
        //        logger.Info("Got items data count:" + itemCount.ToString());
        //        context.Response.Write(itemCount.ToString());
        //    }
        //    else
        //    {
        //        logger.Info("Request type is GET.");
        //        foreach (string paramName in context.Request.QueryString.AllKeys)
        //        {
        //            logger.Info("Parameter name" + paramName + ", with value:" + context.Request.QueryString[paramName].ToString());
        //        }
        //        if (context.Request.QueryString.Count == 4)
        //        {
        //            logger.Info("Pagination query.");
        //            string pageNumber = context.Request.QueryString["pageNumber"].ToString();
        //            string pageSize = context.Request.QueryString["pageSize"].ToString();
        //            string userId = context.Request.QueryString["userid"].ToString();
        //            string htmlData = this.buildTableHTML(pageNumber, pageSize, userId);
        //            context.Response.ContentType = "text/plain";
        //            context.Response.Write(htmlData);
        //        }
        //        else
        //        {// Delete item 
        //            logger.Info("delete item");
        //            string id = context.Request.QueryString["id"].ToString();
        //            string result = this.deleteItem(id);
        //            context.Response.ContentType = "text/plain";
        //            context.Response.Write(result);
        //        }
        //    }

        //}



        //#region table builder
        //private string buildTableHTML(string pageNumber, string pageSize, string userId)
        //{
        //    logger.Info("Build table html with pageNumber:" + pageNumber);
        //    logger.Info("Build table html with pageSize:" + pageSize);
        //    logger.Info("Build table html with userID:" + userId);
        //    TrunkinformationPagination trunksInfoPoco = new TrunkinformationPagination();
        //    trunksInfoPoco.Limit = int.Parse(pageSize);
        //    trunksInfoPoco.Offset = (int.Parse(pageNumber) - 1) * trunksInfoPoco.Limit;
        //    trunksInfoPoco.Userid = long.Parse(userId);

        //    IList<Trunkinformation> trunksPocoList = this.trunksInfoDao.DescendOrderPaginationFindByUserid(trunksInfoPoco);
        //    logger.Info("Got items count:" + trunksPocoList.Count.ToString());
        //    string tableHTML = this.tableGenerator.getTableHTML(this.getTableHeader(), this.getTableData(trunksPocoList), this.getOperate());
        //    logger.Info("Build table HTML done:" + tableHTML);
        //    return tableHTML;
        //}

        //private IList<string> getTableHeader()
        //{
        //    IList<string> columnHeaderList = new List<string>();
        //    columnHeaderList.Add("信息内容");
        //    columnHeaderList.Add("发布时间");
        //    columnHeaderList.Add("所在地");
        //    columnHeaderList.Add("立即查看");
        //    return columnHeaderList;
        //}


        //private IList<IList<string>> getTableData(IList<Trunkinformation> GoodsInfoPocoList)
        //{
        //    IList<IList<string>> rowData = new List<IList<string>>();
        //    foreach (Trunkinformation trunksInfoPoco in GoodsInfoPocoList)
        //    {
        //        List<string> row = new List<string>();
        //        row.Add(trunksInfoPoco.Id.ToString());
        //        row.Add(trunksInfoPoco.Title);
        //        row.Add(trunksInfoPoco.Releasedate.ToString());
        //        rowData.Add(row);
        //    }
        //    return rowData;
        //}


        //private IList<TableOperationInfo> getOperate()
        //{
        //    IList<TableOperationInfo> operationInfoList = new List<TableOperationInfo>();

        //    TableOperationInfo viewOperation = new TableOperationInfo();
        //    viewOperation.OperationName = "查看";
        //    viewOperation.HyperLinkType = "_blank";
        //    viewOperation.HyperLink = "../../InfoShow/TrunkInfoDetail.aspx?type=goods&id=#id#";
        //    operationInfoList.Add(viewOperation);

        //    TableOperationInfo deleteOperation = new TableOperationInfo();
        //    deleteOperation.OperationName = "删除";
        //    deleteOperation.OnClick = "delete_item(#id#)";

        //    operationInfoList.Add(deleteOperation);

        //    return operationInfoList;
        //}














        //#endregion






































        //private string deleteItem(string id)
        //{
        //    logger.Info("Will delete the item with ID:" + id);
        //    Trunkinformation trunksInfoPoco = new Trunkinformation();
        //    try
        //    {
        //        trunksInfoPoco.Id = long.Parse(id);
        //        this.trunksInfoDao.Delete(trunksInfoPoco);
        //        logger.Info("Delete succeeded.");
        //        return "删除成功";
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error("Delete item failed with exception:" + ex.Message);
        //        return "删除失败:" + ex.Message;
        //    }
        //}


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }





    }
}