using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using Trans.DAL.Dao;
using System.IO;
using Trans.DAL.Entity;
using System.Text;
using System.Collections;
using Newtonsoft.Json;

namespace Trans.InfoList
{
    /// <summary>
    /// Summary description for GoodsInformationHandler
    /// </summary>
    public class GoodsInformationHandler : IHttpHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(GoodsInformationHandler));
        private IVgoodssourceinformationDao vGoodsInfoDao;
        public GoodsInformationHandler()
        {
            this.vGoodsInfoDao = new VgoodssourceinformationDao();
            logger.Info("Constructor done.");
        }
        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.RequestType == "POST")
            {// POST for getting total items count.
                logger.Info("Request type is POST.");
                StreamReader streamReader = new StreamReader(context.Request.InputStream);
                string parameters = streamReader.ReadToEnd();
                logger.Info("Got special line type parameter:" + parameters);
                VgoodssourceinformationPagination poco = new VgoodssourceinformationPagination();
                Hashtable data = (Hashtable)JsonConvert.DeserializeObject<Hashtable>(parameters);
                if (data == null || data.Count < 1)
                {
                    data = new Hashtable();
                    int count = this.vGoodsInfoDao.GetCount();
                    data.Add("item_count", count.ToString());
                    logger.Info("got item count:" + count.ToString());
                    data.Add("params", "0-0-0-0");
                }
                else
                {
                    string bitMap = this.hashtable2BitMap(data);
                    poco.Goodstypeid = data["typeId"] == null ? 0 : long.Parse(data["typeId"].ToString());
                    poco.Dstcitycode = data["dstCityId"] == null ? null : data["dstCityId"].ToString();
                    poco.Srccitycode = data["srcCityId"] == null ? null : data["srcCityId"].ToString();
                    poco.Needtrunkweight = data["weight"] == null ? 0 : long.Parse(data["weight"].ToString());
                    Hashtable weightMap = this.weightMap(poco.Needtrunkweight.ToString());
                    poco.Weighthigh = int.Parse(weightMap["weighthigh"].ToString());
                    poco.Weightlow = int.Parse(weightMap["weightlow"].ToString());
                    int count = this.vGoodsInfoDao.DynamicCount(poco);
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
            {
                string pageNumber = context.Request.QueryString["pageNumber"].ToString();
                logger.Info("Got page number:" + pageNumber);
                string pageSize = context.Request.QueryString["pageSize"].ToString();
                logger.Info("Got page size:" + pageSize);
                string bitParams = context.Request.QueryString["bitparams"].ToString();//null
                logger.Info("Got bitmap params:" + bitParams);
                context.Response.ContentType = "text/plain";
                context.Response.Write(this.generateTableHtml(pageNumber,pageSize,bitParams));

            }
        }
        private string hashtable2BitMap(Hashtable ht)
        {
            if (ht.Count < 1)
            {
                return "0-0-0-0";
            }

            StringBuilder bitMapBuilder = new StringBuilder();
            bitMapBuilder.Append(ht["srcCityId"] == null ? "0" : ht["srcCityId"].ToString());
            bitMapBuilder.Append("-");
            bitMapBuilder.Append(ht["dstCityId"] == null ? "0" : ht["dstCityId"].ToString());
            bitMapBuilder.Append("-");
            bitMapBuilder.Append(ht["weight"] == null ? "0" : ht["weight"].ToString());
            bitMapBuilder.Append("-");
            bitMapBuilder.Append(ht["typeId"] == null ? "0" : ht["typeId"].ToString());
            return bitMapBuilder.ToString();
        }
        private Hashtable weightMap(string weight)
        {
            Hashtable map = new Hashtable();
            if (weight == null || weight == "0")
            {
                map.Add("weighthigh", "0");
                map.Add("weightlow", "0");
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
            else
            {
                map.Add("weighthigh", "0");
                map.Add("weightlow", "0");
            }
            return map;
        }
        /// <summary>
        /// srcCityId-dstCityId-weight-typeId
        /// </summary>
        /// <param name="bitMap"></param>
        /// <returns></returns>
        private VgoodssourceinformationPagination bitMapParser(string bitMap)
        {
            VgoodssourceinformationPagination poco = new VgoodssourceinformationPagination();
            string[] paramArray = bitMap.Split('-');
            if (paramArray.Length != 4)
                return null;
            poco.Srccitycode = paramArray[0] == "0" ? null : paramArray[0];
            poco.Dstcitycode = paramArray[1] == "0" ? null : paramArray[1];
            poco.Needtrunkweight = long.Parse(paramArray[2]);
            Hashtable weightMap = this.weightMap(paramArray[2]);
            poco.Weighthigh = int.Parse(weightMap["weighthigh"].ToString());
            poco.Weightlow = int.Parse(weightMap["weightlow"].ToString());
            poco.Goodstypeid = int.Parse(paramArray[3]);
            return poco;
        }
        #region generator
        public string generateTableHtml(string pageNumber, string pageSize,string bitParams)
        {
            VgoodssourceinformationPagination goodsInfoPoco = this.bitMapParser(bitParams);
            goodsInfoPoco.Limit = int.Parse(pageSize);
            goodsInfoPoco.Offset = (int.Parse(pageNumber) - 1) * goodsInfoPoco.Limit;
            logger.Info("Got offset:" + goodsInfoPoco.Offset.ToString());
            IList<Vgoodssourceinformation> goodsInfoPocoList = this.vGoodsInfoDao.DynamicQuery(goodsInfoPoco);
            logger.Info("Good goods information items:" + goodsInfoPocoList.Count.ToString());
            StringBuilder htmlBuilder = new StringBuilder();
            htmlBuilder.Append("<table class=\"table table-hover goodsList\">");
            htmlBuilder.Append("<caption>");
            htmlBuilder.Append("<div id=\"tableCaption\" style=\"padding-top:3px;\"><img src=\"../imgs/pack-2.png\">货源信息</div>");
            htmlBuilder.Append("</caption>");
            htmlBuilder.Append("<thead>");
            htmlBuilder.Append("<tr class=\"headTr\">");
            htmlBuilder.Append("<th>信息内容</th>");
            htmlBuilder.Append("<th>发布时间</th>");
            htmlBuilder.Append("<th>所在地</th>");
            htmlBuilder.Append("<th>立即查看</th>");
            htmlBuilder.Append("</tr>");
            htmlBuilder.Append("</thead>");
            htmlBuilder.Append(this.getTableBodyHtml(goodsInfoPocoList));
            htmlBuilder.Append("</table>");
            string tableHtml = htmlBuilder.ToString();
            logger.Info("Html code :" + tableHtml);
            return tableHtml;
            
        }
        private string getTableBodyHtml(IList<Vgoodssourceinformation> goodsInfoPocoList)
        {
            StringBuilder htmlBuilder = new StringBuilder();
            htmlBuilder.Append("<tbody>");
            foreach (Vgoodssourceinformation poco in goodsInfoPocoList)
            {
                htmlBuilder.Append("<tr>");
                htmlBuilder.Append("<td>");
                htmlBuilder.Append("<a href=\"../InfoShow/DetailInfoFrame.aspx?type=goods&id=" + poco.Id.ToString() + "\" target=\"infoDetails\" class=\"infoTitle goodsInfoTitle\">");
                htmlBuilder.Append(poco.Title);
                htmlBuilder.Append("</a>");
                htmlBuilder.Append("<p>");
                htmlBuilder.Append("<span class=\"light-info\">所需车辆长度：</span><span class=\"infos spanNeedLength\" id=\"carLength\">");
                htmlBuilder.Append(poco.Needtrunklength.ToString());
                htmlBuilder.Append("米</span>");
                htmlBuilder.Append("<span class=\"light-info\">货重：</span><span class=\"infos spanGoodsWeight\" id=\"goodsWeight\">");
                htmlBuilder.Append(poco.Needtrunkweight.ToString());
                htmlBuilder.Append("吨</span>\"");
                htmlBuilder.Append("</p>");
                htmlBuilder.Append("<p><span class=\"light-info\">信息来源：</span><a  href=\"#\" class=\"goodsOrignLink\">");
                htmlBuilder.Append(poco.Username);
                htmlBuilder.Append("</a></p>");
                htmlBuilder.Append("</td>");
                htmlBuilder.Append("<td>");
                htmlBuilder.Append("<span class=\"infos goodsPublishTime\" id=\"publishTime\">");
                htmlBuilder.Append(poco.Releasedate.ToShortDateString());
                htmlBuilder.Append("</span>");
                htmlBuilder.Append("</td>");
                htmlBuilder.Append("<td><span  class=\"spanGoodsPlace\">");
                htmlBuilder.Append(poco.Srcregionname);
                htmlBuilder.Append("</span></td>");
                htmlBuilder.Append("<td>");
                htmlBuilder.Append("<a class=\"moreBottn\" href=\"../InfoShow/DetailInfoFrame.aspx?type=goods&id=" + poco.Id.ToString() + "\" target=\"_blank\"><img src=\"../imgs/plus_alt.png\" id=\"moreBtn\"></a>");
                htmlBuilder.Append("</td>");
                htmlBuilder.Append("</tr>");
            }
            htmlBuilder.Append("</tbody>");
            return htmlBuilder.ToString();
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