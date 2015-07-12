using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using log4net;
using System.Text;

namespace Trans.Biz.Common
{
    public class FrontTableGenerator : IFrontTableGenerator
    {
        private static ILog logger = LogManager.GetLogger(typeof(FrontTableGenerator));
        public FrontTableGenerator()
        { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="columnHeader"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public string getTableHTML(Hashtable columnHeader, IList<IList<string>> values)
        {
            logger.Info("Begin generate table HTML:");
            logger.Info("column header item count:" + columnHeader.Count.ToString());
            logger.Info("Rows item count:" + values.Count.ToString());
            StringBuilder htmlBuilder = new StringBuilder();
            htmlBuilder.Append("<table class=\"table table-hover newsList\">");
            htmlBuilder.Append("<thead>");
            foreach (DictionaryEntry headerItem in columnHeader)
            {
                htmlBuilder.Append("<th  width=\"" + headerItem.Value.ToString() + "%\">");
                htmlBuilder.Append(headerItem.Key.ToString());
                htmlBuilder.Append("</th>");
            }
            htmlBuilder.Append("</thead>");
            logger.Info("Got HTML header html code:" + htmlBuilder.ToString());
            
            htmlBuilder.Append("</table>");
            return htmlBuilder.ToString();
        }
        private string getRowsHtml(IList<IList<string>> values)
        {
            StringBuilder htmlBuilder = new StringBuilder();
            htmlBuilder.Append("<tbody>");
            foreach (IList<string> row in values)
            {
                htmlBuilder.Append("<tr>");
                foreach (string cell in row)
                {
 
                }
                htmlBuilder.Append("</tr>");
            }
            htmlBuilder.Append("</tbody>");
            return htmlBuilder.ToString();
        }

    }
}