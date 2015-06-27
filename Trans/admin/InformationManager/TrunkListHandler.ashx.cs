using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using Trans.DAL.Dao;
using Trans.DAL.Entity;
using Trans.Biz.Common;
using System.IO;


namespace Trans.admin.InformationManager
{
    /// <summary>
    /// Summary description for TrunkListHandler
    /// </summary>
    public class TrunkListHandler : IHttpHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(TrunkListHandler));
        private ITrunkinformationDao trunkInfoDao;
        private ITableGenerator tableGenerator;

        public TrunkListHandler()
        {
            this.trunkInfoDao = new TrunkinformationDao();
            this.tableGenerator = new TableGenerator();
            logger.Info("constructor method done.");
        }
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Request.RequestType == "POST")
            {
                logger.Info("Request type is POST.");
                StreamReader streamReader = new StreamReader(context.Request.InputStream);
                string userId = streamReader.ReadToEnd();
                Trunkinformation trunkInfoPoco = new Trunkinformation();
                long userIdLong = 0;
                bool parseResult = long.TryParse(userId, out userIdLong);
                if (parseResult)
                {
                    trunkInfoPoco.Userid = userIdLong;
                    int itemsCount = this.trunkInfoDao.FindCountByUserid(trunkInfoPoco);
                    logger.Info("Items count:" + itemsCount.ToString());
                    context.Response.Write(itemsCount.ToString());
                }
                else
                {
                    logger.Info("User ID parse failed:" + userId);
                    context.Response.Write("0");
                }
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
                    logger.Info("Table HTML builded done:" + htmlData);
                    context.Response.Write(htmlData);
                }
                else
                { // Delete item 
                    logger.Info("delete item");
                    string id = context.Request.QueryString["id"].ToString();
                    string result = this.deleteItem(id);
                    context.Response.Write(result);
                }
            }
        }

        private string deleteItem(string id)
        {
            logger.Info("Will remove trunk information item with id:" + id);
            Trunkinformation trunkInfoPoco = new Trunkinformation();
            try
            {
                trunkInfoPoco.Id = long.Parse(id);
                this.trunkInfoDao.Delete(trunkInfoPoco);
                logger.Info("Deleted done, item id:" + id);
                return "删除成功";
            }
            catch (Exception ex)
            {
                logger.Error("Delete failed with exception:" + ex.Message);
                return "删除失败:" + ex.Message;
            }
        }

        #region table builder
        private string buildTableHTML(string pageNumber, string pageSize, string userId)
        {
            logger.Info("Build table html with pageNumber:" + pageNumber);
            logger.Info("Build table html with pageSize:" + pageSize);
            logger.Info("Build table html with userID:" + userId);
            TrunkinformationPagination trunkInfoPoco = new TrunkinformationPagination();
            try
            {
                trunkInfoPoco.Limit = int.Parse(pageSize);
                trunkInfoPoco.Offset = (int.Parse(pageNumber) - 1) * trunkInfoPoco.Limit;
                trunkInfoPoco.Userid = long.Parse(userId);
            }
            catch (Exception ex)
            {
                logger.Error("Parameter invalid:" + ex.Message);
                return "参数错误：" + ex.Message;
            }
            IList<Trunkinformation> trunkInfoPocoList = this.trunkInfoDao.DescendOrderPaginationFindByUserid(trunkInfoPoco);
            logger.Info("Got items of Trunkinformation:" + trunkInfoPocoList.Count.ToString());
            string htmlData = this.tableGenerator.getTableHTML(this.getTableHeader(), this.getTableData(trunkInfoPocoList), this.getOperate());
            logger.Info("Table HTML data build done:" + htmlData);
            return htmlData;
        }
        private IList<string> getTableHeader()
        {
            IList<string> columnHeaderList = new List<string>();
            columnHeaderList.Add("标题");
            columnHeaderList.Add("发布时间");
            columnHeaderList.Add("操作");
            return columnHeaderList;
        }
        private IList<IList<string>> getTableData(IList<Trunkinformation> trunkInfoPocoList)
        {
            IList<IList<string>> rowData = new List<IList<string>>();
            foreach (Trunkinformation trunkInfoPoco in trunkInfoPocoList)
            {
                List<string> row = new List<string>();
                row.Add(trunkInfoPoco.Id.ToString());
                row.Add(trunkInfoPoco.Title);
                row.Add(trunkInfoPoco.Releasedate.ToString());
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
            viewOperation.HyperLink = "../../InfoShow/DetailInfoFrame.aspx?type=trunk&id=#id#";
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
                return false;
            }
        }
    }
}