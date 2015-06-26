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
    /// Summary description for SpeciallineListHandler
    /// </summary>
    public class SpeciallineListHandler : IHttpHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(SpeciallineListHandler));
        private ISpeciallineinfoDao speciallineDao;
        private ITableGenerator tableGenerator;
        public SpeciallineListHandler()
        {
            this.speciallineDao = new SpeciallineinfoDao();
            this.tableGenerator = new TableGenerator();
            logger.Info("Constructor method done.");
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Request.RequestType == "POST")
            {
                logger.Info("Request type is POST.");
                StreamReader streamReader = new StreamReader(context.Request.InputStream);
                string userId = streamReader.ReadToEnd();
                Speciallineinfo lineInfoPoco = new Speciallineinfo();
                long userIdLong = 0;
                bool parseResult = long.TryParse(userId, out userIdLong);
                if (parseResult)
                {
                    lineInfoPoco.Userid = userIdLong;
                    int itemsCount = this.speciallineDao.FindCountByUserid(lineInfoPoco);
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
            Speciallineinfo lineInfoPoco = new Speciallineinfo();
            try
            {
                lineInfoPoco.Id = long.Parse(id);
                this.speciallineDao.Delete(lineInfoPoco);
                logger.Info("Item removed done.");
                return "删除成功";
            }
            catch (Exception ex)
            {
                logger.Error("Remove item failed with exception:" + ex.Message);
                return "删除失败：" + ex.Message;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        private string buildTableHTML(string pageNumber, string pageSize, string userId)
        {
            logger.Info("Build table html with pageNumber:" + pageNumber);
            logger.Info("Build table html with pageSize:" + pageSize);
            logger.Info("Build table html with userID:" + userId);
            SpeciallineinfoPagination lineInfoPoco = new SpeciallineinfoPagination();
            try
            {
                lineInfoPoco.Limit = int.Parse(pageSize);
                lineInfoPoco.Offset = (int.Parse(pageNumber) - 1) * lineInfoPoco.Limit;
                lineInfoPoco.Userid = long.Parse(userId);
            }
            catch (Exception ex)
            {
                logger.Error("Parameter invalid:" + ex.Message);
                return "参数错误：" + ex.Message;
            }
            IList<Speciallineinfo> lineInfoPocoList = this.speciallineDao.DescendOrderPaginationFindByUserid(lineInfoPoco);
            logger.Info("Got items:" + lineInfoPocoList.Count.ToString());
            string tableHTML = this.tableGenerator.getTableHTML(this.getTableHeader(), this.getTableData(lineInfoPocoList), this.getOperate());
            logger.Info("Build table HTML done:" + tableHTML);
            return tableHTML;
        }

        #region table builder
        private IList<string> getTableHeader()
        {
            IList<string> columnHeaderList = new List<string>();
            columnHeaderList.Add("标题");
            columnHeaderList.Add("发布时间");
            columnHeaderList.Add("操作");
            return columnHeaderList;
        }
        private IList<IList<string>> getTableData(IList<Speciallineinfo> lineInfoPocoList)
        {
            IList<IList<string>> rowData = new List<IList<string>>();
            foreach (Speciallineinfo lineInfoPoco in lineInfoPocoList)
            {
                List<string> row = new List<string>();
                row.Add(lineInfoPoco.Id.ToString());
                row.Add(lineInfoPoco.Title);
                row.Add(lineInfoPoco.Releasedate.ToString());
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