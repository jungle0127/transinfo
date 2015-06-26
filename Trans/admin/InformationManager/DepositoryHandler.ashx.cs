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
    /// Summary description for DepositoryHandler
    /// </summary>
    public class DepositoryHandler : IHttpHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(DepositoryHandler));
        private IDepotinformationDao depotoryDao;
        public DepositoryHandler()
        {
            this.depotoryDao = new DepotinformationDao();
            logger.Info("Constructor method done.");
        }
        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.HttpMethod == "POST")
            {// Items count
                logger.Info("Request type is POST.");
                StreamReader streamReader = new StreamReader(context.Request.InputStream);
                string parameter = streamReader.ReadToEnd();
                logger.Info("Got the parameter:" + parameter);
                context.Response.ContentType = "text/plain";
                Depotinformation depotInfoPoco = new Depotinformation();
                depotInfoPoco.Userid = long.Parse(parameter);
                int itemsCount = this.depotoryDao.FindCountByUserid(depotInfoPoco);
                logger.Info("Got items count:" + itemsCount.ToString() + " from User:" + parameter);
                context.Response.Write(itemsCount.ToString());
            }
            else
            {
                logger.Info("Request type is GET.");
                foreach(string parameterName in context.Request.QueryString.AllKeys)
                {
                    logger.Info("Request parameter:" + parameterName + ", with value:" + context.Request.QueryString[parameterName].ToString());
                }
                if (context.Request.QueryString.Count == 4)
                {// Pagination data retrieve
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
        /// Delete item of depotory information.
        /// </summary>
        /// <param name="id">id of depotory information</param>
        /// <returns>result of delete.</returns>
        private string deleteItem(string id)
        {
            logger.Info("Will remove depot information item with id:" + id);
            Depotinformation depotInfoPoco = new Depotinformation();
            depotInfoPoco.Id = long.Parse(id);
            try
            {
                this.depotoryDao.Delete(depotInfoPoco);
                logger.Info("Deleted done, item id:" + id);
                return "删除成功";
            }
            catch (Exception ex)
            {
                logger.Error("Delete failed with exception:" + ex.Message);
                return "删除失败:" + ex.Message;
            }
        }

        private string buildTableHTML(string pageNumber, string pageSize, string userId)
        {
            DepotinformationPagination depotInfoPoco = new DepotinformationPagination();
            depotInfoPoco.Limit = int.Parse(pageSize);
            logger.Info("Will retrieve data with page size:" + pageSize);
            depotInfoPoco.Offset = (int.Parse(pageNumber) - 1) * depotInfoPoco.Limit;
            logger.Info("Will retrieve data with limit:" + depotInfoPoco.Limit.ToString());
            depotInfoPoco.Userid = long.Parse(userId);
            logger.Info("Will retrieve data for user id:" + userId);
            IList<Depotinformation> depotInfoList = this.depotoryDao.DescendOrderPaginationFindByUserid(depotInfoPoco);
            logger.Info("Got items of Depotinformation:" + depotInfoList.Count.ToString());
            ITableGenerator tableGenerator = new TableGenerator();
            string htmlData = tableGenerator.getTableHTML(this.getTableHeader(), this.getTableData(depotInfoList), this.getOperate());
            logger.Info("Table HTML data build done:" + htmlData);
            return htmlData;
        }
        #region table builder
        private IList<string> getTableHeader()
        {
            IList<string> columnHeaderList = new List<string>();
            columnHeaderList.Add("标题");
            columnHeaderList.Add("有效时间");
            columnHeaderList.Add("操作");
            return columnHeaderList;
        }
        private IList<IList<string>> getTableData(IList<Depotinformation> depotInfoPocoList)
        {
            IList<IList<string>> rowData = new List<IList<string>>();
            foreach (Depotinformation depotInfoPoco in depotInfoPocoList)
            {
                List<string> row = new List<string>();
                row.Add(depotInfoPoco.Id.ToString());
                row.Add(depotInfoPoco.Title);
                row.Add(depotInfoPoco.Validtime);
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
            viewOperation.HyperLink = "viewtest.aspx?id=#id#";
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