using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Trans.DAL.Dao;
using Trans.DAL.Entity;

namespace Trans.admin.promulagate
{
    /// <summary>
    /// Summary description for NewsListHandler
    /// </summary>
    public class NewsListHandler : IHttpHandler
    {
        private IVarticleinfoDao articleInfoDao;
        public NewsListHandler()
        {
            this.articleInfoDao = new VarticleinfoDao();
        }
        public void ProcessRequest(HttpContext context)
        {
            string pageNumber = context.Request.QueryString["page"].ToString();
            VarticleinfoPagination pageNationPoco = new VarticleinfoPagination();
            pageNationPoco.Limit = 30;
            pageNationPoco.Offset = 0;
            IList<Varticleinfo> articleInfoList = this.articleInfoDao.PaginationFindAll(pageNationPoco);

            context.Response.Write(this.getTableHtml(this.getTableBodyHtml(articleInfoList)));
        }

        private string getTableHtml(string bodyHtml)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<table class=\"tablelist\">");
            sb.Append("<thead>");
            sb.Append(@"<th>标题</th>
                        <th>用户</th>
                        <th>操作</th>
        </tr>
        </thead>");
            sb.Append("<tbody>");
            sb.Append(bodyHtml);
            sb.Append("</tbody>");
            sb.Append("</table>");
            return sb.ToString();
        }
        private string getTableBodyHtml(IList<Varticleinfo> articleInfoList)
        {
            StringBuilder bodyBuilder = new StringBuilder();
            foreach (Varticleinfo articleInfoPoco in articleInfoList)
            {
                bodyBuilder.Append("<tr>");
                bodyBuilder.Append("<td>");
                bodyBuilder.Append(articleInfoPoco.Title);
                bodyBuilder.Append("</td>");
                bodyBuilder.Append("<td>");
                bodyBuilder.Append(articleInfoPoco.Username);
                bodyBuilder.Append("</td>");
                bodyBuilder.Append("<td>");
                bodyBuilder.Append("<a href=\"#\" class=\"tablelink\">查看</a>     <a href=\"#\" class=\"tablelink\"> 删除</a>");
                bodyBuilder.Append("</td>");
            }
            return bodyBuilder.ToString();
        }
        private string getTestData()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<table class=\"tablelist\">");
            sb.Append("<thead>");
            sb.Append("<th>编号<i class=\"sort\"><img src=\"../../images/px.gif\" /></i></th>");
            sb.Append(@"<th>标题</th>
        <th>用户</th>
        <th>籍贯</th>
        <th>操作</th>
        </tr>
        </thead>");

            sb.Append("<tbody>");

            sb.Append(@"<tr>
        <td>20130908</td>
        <td>王金平幕僚：马英九声明字字见血 人活着没意思</td>
        <td>admin</td>
        <td>江苏南京</td>");

            sb.Append("<td><a href=\"#\" class=\"tablelink\">查看</a>     <a href=\"#\" class=\"tablelink\"> 删除</a></td>");
            sb.Append(@"</tr> 
        
        <tr>
        <td>20130907</td>
        <td>温州19名小学生中毒流鼻血续：周边部分企业关停</td>
        <td>uimaker</td>
        <td>山东济南</td>");
            sb.Append(" <td><a href=\"#\" class=\"tablelink\">查看</a>     <a href=\"#\" class=\"tablelink\">删除</a></td>");
            sb.Append("</tr>");
            sb.Append("</tbody>");
            sb.Append("</table>");

            return sb.ToString();
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