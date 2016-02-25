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
using Newtonsoft.Json;
using System.Collections;





namespace Trans.InfoList
{
    /// <summary>
    /// Summary description for TrunkInfoListHandler
    /// </summary>
    public class TrunkInfoListHandler : IHttpHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(TrunkInfoListHandler));
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
                string parameters = streamReader.ReadToEnd();
                logger.Info("Got post parameters:" + parameters);
                VtrunkinformationPagination poco = new VtrunkinformationPagination();
                Hashtable data = (Hashtable)JsonConvert.DeserializeObject<Hashtable>(parameters);
                if (data == null || data.Count < 1)
                {
                    data = new Hashtable();
                    int count = this.vTrunkInfoDao.GetCount();
                    data.Add("item_count", count.ToString());
                    logger.Info("got item count:" + count.ToString());
                    data.Add("params", "0-0-0-0-0-0");
                }
                else
                {
                    string bitMap = this.hashtable2BitMap(data);
                    poco = this.transform2Poco(data);
                    int count =  this.vTrunkInfoDao.DynamicCount(poco);
                    logger.Info("Got items count:" + count.ToString());
                    data.Add("item_count", count.ToString());
                    data.Add("params", bitMap);
                    logger.Info("Post back parameters:" + bitMap);
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
                string bitparames = context.Request.QueryString["bitparams"].ToString();
                logger.Info("Got bitparams:" + bitparames);
                string tableHtml = this.generateTrunksInfoHtml(pageNumber, pageSize,bitparames);
                context.Response.ContentType = "text/plain";
                context.Response.Write(tableHtml);
            }
        }
        private VtrunkinformationPagination bitMap2Poco(string bitMap)
        {
            VtrunkinformationPagination poco = new VtrunkinformationPagination();
            string[] paramArray = bitMap.Split('-');
            if (paramArray.Length != 6)
                return null;
            poco.Srccitycode = paramArray[0] == "0" ? null : paramArray[0];
            poco.Dstcitycode = paramArray[1] == "0" ? null : paramArray[1];
            poco.Vantypeid = int.Parse(paramArray[2]);
            poco.Trunktypeid = int.Parse(paramArray[3]);
            poco.Length = int.Parse(paramArray[4]);
            Hashtable segMap = this.lengthMap(poco.Length.ToString());
            poco.Lengthhigh = int.Parse(segMap["lengthhigh"].ToString());
            poco.Lengthlow = int.Parse(segMap["lengthlow"].ToString());
            segMap = this.weightMap(poco.Weightcapacity.ToString());
            poco.Weighthigh = int.Parse(segMap["weighthigh"].ToString());
            poco.Weightlow = int.Parse(segMap["weightlow"].ToString());
            return poco;
        }
        private VtrunkinformationPagination transform2Poco(Hashtable data)
        {
            VtrunkinformationPagination poco = new VtrunkinformationPagination();
            poco.Srccitycode = data["srcCityId"] == null ? null : data["srcCityId"].ToString();
            poco.Dstcitycode = data["dstCityId"] == null ? null : data["dstCityId"].ToString();
            poco.Length = data["length"] == null ? 0 : int.Parse(data["length"].ToString());
            Hashtable segMap = this.lengthMap(poco.Length.ToString());
            poco.Lengthhigh = int.Parse(segMap["lengthhigh"].ToString());
            poco.Lengthlow = int.Parse(segMap["lengthlow"].ToString());
            poco.Weightcapacity = data["weight"] == null ? 0 : int.Parse(data["weight"].ToString());
            segMap = this.weightMap(poco.Weightcapacity.ToString());
            poco.Weighthigh = int.Parse(segMap["weighthigh"].ToString());
            poco.Weightlow = int.Parse(segMap["weightlow"].ToString());
            poco.Trunktypeid = data["trunkTypeId"] == null ? 0 : long.Parse(data["trunkTypeId"].ToString());
            poco.Vantypeid = data["vanTypeId"] == null ? 0 : long.Parse(data["vanTypeId"].ToString());
            return poco;
        }
        /// <summary>
        /// srcCityId-dstCityId-vanTypeId-trunkTypeId-length-weight
        /// </summary>
        /// <param name="ht"></param>
        /// <returns></returns>
        private string hashtable2BitMap(Hashtable ht)
        {
            if (ht.Count < 1)
            {
                return "0-0-0-0-0-0";
            }

            StringBuilder bitMapBuilder = new StringBuilder();
            bitMapBuilder.Append(ht["srcCityId"] == null ? "0" : ht["srcCityId"].ToString());
            bitMapBuilder.Append("-");
            bitMapBuilder.Append(ht["dstCityId"] == null ? "0" : ht["dstCityId"].ToString());
            bitMapBuilder.Append("-");
            bitMapBuilder.Append(ht["vanTypeId"] == null ? "0" : ht["vanTypeId"].ToString());
            bitMapBuilder.Append("-");
            bitMapBuilder.Append(ht["trunkTypeId"] == null ? "0" : ht["trunkTypeId"].ToString());
            bitMapBuilder.Append("-");
            bitMapBuilder.Append(ht["length"] == null ? "0" : ht["length"].ToString());
            bitMapBuilder.Append("-");
            bitMapBuilder.Append(ht["weight"] == null ? "0" : ht["weight"].ToString());
            return bitMapBuilder.ToString();
        }
        private Hashtable lengthMap(string length)
        {
            Hashtable map = new Hashtable();
            if (length == null || length == "0")
            {
                map.Add("lengthlow", "0");
                map.Add("lengthhigh", "0");
                return map;
            }
            if (length == "1")
            {
                map.Add("lengthlow", "0");
                map.Add("lengthhigh", "3");
            }
            else if (length == "2")
            {
                map.Add("lengthlow", "3");
                map.Add("lengthhigh", "6");
            }
            else if (length == "3")
            {
                map.Add("lengthlow", "6");
                map.Add("lengthhigh", "10");
            }
            else if (length == "4")
            {
                map.Add("lengthlow", "10");
                map.Add("lengthhigh", "13");
            }
            else if (length == "5")
            {
                map.Add("lengthlow", "13");
                map.Add("lengthhigh", "16");
            }
            else if (length == "6")
            {
                map.Add("lengthlow", "16");
                map.Add("lengthhigh", "2147483647");
            }
            else
            {
                map.Add("lengthlow", "0");
                map.Add("lengthhigh", "0");
            }
            return map;
        }
        private Hashtable weightMap(string weight)
        {
            Hashtable map = new Hashtable();
            if (weight == null || weight == "0")
            {
                map.Add("weightlow", "0");
                map.Add("weighthigh", "0");
            }
            else if (weight == "1")
            {
                map.Add("weightlow", "0");
                map.Add("weighthigh", "5");
            }
            else if (weight == "2")
            {
                map.Add("weightlow", "5");
                map.Add("weighthigh", "9");
            }
            else if (weight == "3")
            {
                map.Add("weightlow", "9");
                map.Add("weighthigh", "19");
            }
            else if (weight == "4")
            {
                map.Add("weightlow", "19");
                map.Add("weighthigh", "29");
            }
            else if (weight == "5")
            {
                map.Add("weightlow", "29");
                map.Add("weighthigh", "39");
            }
            else if (weight == "6")
            {
                map.Add("weightlow", "39");
                map.Add("weighthigh", "2147483647");
            }
            return map;
        }
        #region generator
        public string generateTrunksInfoHtml(string pageNumber, string pageSize,string bitparams)
        {
            VtrunkinformationPagination pageNationPoco = this.bitMap2Poco(bitparams);
            pageNationPoco.Limit = int.Parse(pageSize);
            pageNationPoco.Offset = (int.Parse(pageNumber) - 1) * pageNationPoco.Limit;
            logger.Info("Got offset:" + pageNationPoco.Offset.ToString());
            IList<Vtrunkinformation> trunksInfoList = this.vTrunkInfoDao.DynamicQuery(pageNationPoco);
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