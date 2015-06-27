using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using Trans.DAL.Dao;
using System.IO;
using Trans.DAL.Entity;
using Trans.Biz.Common;

namespace Trans.admin.InformationManager
{
    /// <summary>
    /// Summary description for GoodsListHandler
    /// </summary>
    public class GoodsListHandler : IHttpHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(GoodsListHandler));
        private IGoodssourceinformationDao goodsInfoDao;
        private ITableGenerator tableGenerator;
        public GoodsListHandler()
        {
            this.goodsInfoDao = new GoodssourceinformationDao();
            this.tableGenerator = new TableGenerator();
            logger.Info("Constructor method done.");
        }
        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.RequestType == "POST")
            {
                logger.Info("Request type is POST.");
                context.Response.ContentType = "text/plain";
                StreamReader streamReader = new StreamReader(context.Request.InputStream);
                string userId = streamReader.ReadToEnd();
                logger.Info("Got the request parameter UserID:" + userId);
                Goodssourceinformation goodsInfoPoco = new Goodssourceinformation();
                long userIdLong = -1;
                bool result = long.TryParse(userId, out userIdLong);
                if (!result)
                {
                    logger.Error("User ID is invalid.");
                    context.Response.Write("-1");
                }
                goodsInfoPoco.Userid = userIdLong;
                int itemCount = this.goodsInfoDao.FindCountByUserid(goodsInfoPoco);
                logger.Info("Got items data count:" + itemCount.ToString());
                context.Response.Write(itemCount.ToString());
            }
            else
            {
                logger.Info("Request type is GET.");
                foreach (string paramName in context.Request.QueryString.AllKeys)
                {
                    logger.Info("Parameter name" + paramName + ", with value:" + context.Request.QueryString[paramName].ToString());
                }
                if (context.Request.QueryString.Count == 4)
                {
                    logger.Info("Pagination query.");
                    string pageNumber = context.Request.QueryString["pageNumber"].ToString();
                    string pageSize = context.Request.QueryString["pageSize"].ToString();
                    string userId = context.Request.QueryString["userid"].ToString();
                    string htmlData = this.buildTableHTML(pageNumber, pageSize, userId);
                    context.Response.ContentType = "text/plain";
                    context.Response.Write(htmlData);
                }
                else
                {// Delete item 
                    logger.Info("delete item");
                    string id = context.Request.QueryString["id"].ToString();
                    string result = this.deleteItem(id);
                    context.Response.ContentType = "text/plain";
                    context.Response.Write(result);
                }
            }
            
        }
        /// <summary>
        /// Delete GoodsSourceInformation item with ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private string deleteItem(string id)
        {
            logger.Info("Will delete the item with ID:" + id);
            Goodssourceinformation goodsInfoPoco = new Goodssourceinformation();
            try
            {
                goodsInfoPoco.Id = long.Parse(id);
                this.goodsInfoDao.Delete(goodsInfoPoco);
                logger.Info("Delete succeeded.");
                return "删除成功";
            }
            catch (Exception ex)
            {
                logger.Error("Delete item failed with exception:" + ex.Message);
                return "删除失败:" + ex.Message;
            }
        }
        #region table builder
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        private string buildTableHTML(string pageNumber,string pageSize,string userId)
        {
            logger.Info("Build table html with pageNumber:" + pageNumber);
            logger.Info("Build table html with pageSize:" + pageSize);
            logger.Info("Build table html with userID:" + userId);
            GoodssourceinformationPagination goodsInfoPoco = new GoodssourceinformationPagination();
            goodsInfoPoco.Limit = int.Parse(pageSize);
            goodsInfoPoco.Offset = (int.Parse(pageNumber) - 1) * goodsInfoPoco.Limit;
            goodsInfoPoco.Userid = long.Parse(userId);

            IList<Goodssourceinformation> goodsPocoList = this.goodsInfoDao.DescendOrderPaginationFindByUserid(goodsInfoPoco);
            logger.Info("Got items count:" + goodsPocoList.Count.ToString());
            string tableHTML = this.tableGenerator.getTableHTML(this.getTableHeader(), this.getTableData(goodsPocoList), this.getOperate());
            logger.Info("Build table HTML done:" + tableHTML);
            return tableHTML;
        }
        private IList<string> getTableHeader()
        {
            IList<string> columnHeaderList = new List<string>();
            columnHeaderList.Add("标题");
            columnHeaderList.Add("发布时间");
            columnHeaderList.Add("操作");
            return columnHeaderList;
        }
        private IList<IList<string>> getTableData(IList<Goodssourceinformation> GoodsInfoPocoList)
        {
            IList<IList<string>> rowData = new List<IList<string>>();
            foreach (Goodssourceinformation goodsInfoPoco in GoodsInfoPocoList)
            {
                List<string> row = new List<string>();
                row.Add(goodsInfoPoco.Id.ToString());
                row.Add(goodsInfoPoco.Title);
                row.Add(goodsInfoPoco.Releasedate.ToString());
                rowData.Add(row);
            }
            return rowData;
        }
        private IList<TableOperationInfo> getOperate()
        {
            IList<TableOperationInfo> operationInfoList = new List<TableOperationInfo>();

            TableOperationInfo viewOperation = new TableOperationInfo();
            viewOperation.OperationName = "查看";
            viewOperation.HyperLinkType = "_blank";
            viewOperation.HyperLink = "../../InfoShow/DetailInfoFrame.aspx?type=goods&id=#id#";
            operationInfoList.Add(viewOperation);

            TableOperationInfo deleteOperation = new TableOperationInfo();
            deleteOperation.OperationName = "删除";
            deleteOperation.OnClick = "delete_item(#id#)";

            operationInfoList.Add(deleteOperation);

            return operationInfoList;
        }
        #endregion
        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
    }
}