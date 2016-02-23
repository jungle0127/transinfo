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
using System.Collections;
using Newtonsoft.Json;
using Trans.Biz.ListshowPojo;




namespace Trans.InfoList
{
    /// <summary>
    /// Summary description for DepotListHandler
    /// </summary>
    public class DepotListHandler : IHttpHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(DepotListHandler));
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
                string parameters = streamReader.ReadToEnd();
                logger.Info("Got post parameters:" + parameters);
                VdepotinformationPagination poco = new VdepotinformationPagination();
                Hashtable data = (Hashtable)JsonConvert.DeserializeObject<Hashtable>(parameters);
                if (data == null || data.Count < 1)
                {
                    data = new Hashtable();
                    int count = this.vDepotInfoDao.GetCount();
                    data.Add("item_count", count.ToString());
                    logger.Info("got item count:" + count.ToString());
                    data.Add("params", "0-0-0-0");
                }
                else 
                {
                    string bitMap = this.hashtable2BitMap(data);
                    poco.Citycode = data["cityId"] == null ? null : data["cityId"].ToString();
                    poco.Depottypeid = data["typeId"] == null ? 0 : long.Parse(data["typeId"].ToString());
                    poco.Scopeid = data["scopeId"] == null ? 0 : long.Parse(data["scopeId"].ToString());
                    string area = data["area"] == null ? "0" : data["area"].ToString();
                    Hashtable areaMap = this.areaMap(area);
                    poco.AreaLow = int.Parse(areaMap["low"].ToString());
                    poco.AreaHigh = int.Parse(areaMap["high"].ToString());
                    poco.Area = int.Parse(area);
                    int count = this.vDepotInfoDao.DynamicCount(poco);
                    logger.Info("Got items count:" + count.ToString());
                    data = new Hashtable();
                    data.Add("item_count", count.ToString());
                    data.Add("params", bitMap);
                    logger.Info("Post back bitMap:" + bitMap);
                }
                context.Response.ContentType = "text/plain";
                context.Response.Write(JsonConvert.SerializeObject(data));
            }
            else
            {// GET
                string pageNumber = context.Request.QueryString["pageNumber"].ToString();
                logger.Info("Got page number:" + pageNumber);
                string pageSize = context.Request.QueryString["pageSize"].ToString();
                logger.Info("Got page size:" + pageSize);
                string bitParams = context.Request.QueryString["bitparams"].ToString();//null
                logger.Info("Got bitmap params:" + bitParams);
                string tableHtml = this.generateDepotInfoHtml(pageNumber, pageSize,bitParams);
                context.Response.ContentType = "text/plain";
                context.Response.Write(tableHtml);
            }
        }

        public string generateDepotInfoHtml(string pageNumber, string pageSize,string bitParams)
        {
            pageNumber = int.Parse(pageNumber) < 0 ? "0" : pageNumber;
            VdepotinformationPagination pageNationPoco = new VdepotinformationPagination();
            pageNationPoco.Limit = int.Parse(pageSize);

            pageNationPoco.Offset = (int.Parse(pageNumber) - 1) * pageNationPoco.Limit;
            logger.Info("Got offset:" + pageNationPoco.Offset.ToString());
            DepotParamPojo pojo = this.paramBitMapParser(bitParams);
            pageNationPoco.Area = int.Parse(pojo.Area);
            Hashtable areaMap = this.areaMap(pojo.Area);
            pageNationPoco.AreaLow = int.Parse(areaMap["low"].ToString());
            pageNationPoco.AreaHigh = int.Parse(areaMap["high"].ToString());
            pageNationPoco.Citycode = pojo.CityId;
            pageNationPoco.Depottypeid = long.Parse(pojo.TypeId);
            pageNationPoco.Scopeid = long.Parse(pojo.ScopeId);
            IList<Vdepotinformation> trunksInfoList = this.vDepotInfoDao.DynamicQuery(pageNationPoco);
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
        private Hashtable areaMap(string src)
        {
            Hashtable map = new Hashtable();
            if (src == null || src == "0" || src == "")
            {
                map.Add("low", "0");
                map.Add("high", "0");
                return map;
            }
            if (src == "1")
            {
                map.Add("low", "0");
                map.Add("high", "10");
            }
            if (src == "2")
            {
                map.Add("low", "10");
                map.Add("high", "50");
            }
            if (src == "3")
            {
                map.Add("low", "50");
                map.Add("high", "90");
            }
            if (src == "4")
            {
                map.Add("low", "90");
                map.Add("high", "150");
            }
            if (src == "5")
            {
                map.Add("low", "150");
                map.Add("high", "250");
            }
            if (src == "6")
            {
                map.Add("low", "250");
                map.Add("high", "350");
            }
            if (src == "7")
            {
                map.Add("low", "350");
                map.Add("high", "550");
            }
            if (src == "8")
            {
                map.Add("low", "550");
                map.Add("high", "2147483647");
            }
            return map;
        }
        private string hashtable2BitMap(Hashtable ht)
        {
            if (ht.Count < 1)
            {
                return "0-0-0-0";
            }

            StringBuilder bitMapBuilder = new StringBuilder();
            bitMapBuilder.Append(ht["cityId"] == null ? "0" : ht["cityId"].ToString());
            bitMapBuilder.Append("-");
            bitMapBuilder.Append(ht["scopeId"] == null ? "0" : ht["scopeId"].ToString());
            bitMapBuilder.Append("-");
            bitMapBuilder.Append(ht["typeId"] == null ? "0" : ht["typeId"].ToString());
            bitMapBuilder.Append("-");
            bitMapBuilder.Append(ht["area"] == null ? "0" : ht["area"].ToString());
            return bitMapBuilder.ToString();
        }
        /// <summary>
        /// parameters format: cityId-scopeId-typeId-area
        /// </summary>
        /// <param name="bitMap"></param>
        /// <returns></returns>
        private DepotParamPojo paramBitMapParser(string bitMap)
        {
            DepotParamPojo paramPojo = new DepotParamPojo();
            string[] paramArray = bitMap.Split('-');
            if (paramArray.Length != 4)
                return null;
            paramPojo.CityId = paramArray[0] == "0" ? null : paramArray[0];
            paramPojo.ScopeId = paramArray[1];
            paramPojo.TypeId = paramArray[2];
            paramPojo.Area = paramArray[3];
            return paramPojo;
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