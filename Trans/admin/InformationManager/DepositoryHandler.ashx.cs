using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using Trans.DAL.Dao;
using System.IO;
using Trans.DAL.Entity;

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
            {
                logger.Info("Request type is POST.");
                StreamReader streamReader = new StreamReader(context.Request.InputStream);
                string parameter = streamReader.ReadToEnd();
                logger.Info("Got the parameter:" + parameter);
                context.Response.ContentType = "text/plain";
                context.Response.Write(parameter);
            }
            else
            {
                logger.Info("Request type is GET.");
                string pageNumber = context.Request.QueryString["pageNumber"].ToString();
                string pageSize = context.Request.QueryString["pageSize"].ToString();
                string userId = context.Request.QueryString["userid"].ToString();
                DepotinformationPagination depotInfoPoco = new DepotinformationPagination();
                depotInfoPoco.Limit = int.Parse(pageSize);
                depotInfoPoco.Offset = (int.Parse(pageNumber) - 1) * depotInfoPoco.Limit;
                depotInfoPoco.Userid = long.Parse(userId);
                IList<Depotinformation> depotInfoList = this.depotoryDao.PaginationFindByUserid(depotInfoPoco);
            }
        }

        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
    }
}