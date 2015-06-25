using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using log4net;

namespace Trans.Biz.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class TableGenerator : ITableGenerator
    {
        private static ILog logger = LogManager.GetLogger(typeof(TableGenerator));
        public TableGenerator()
        {
 
        }
        public string getTableHTML(IList<string> columnHeader, IList<IList<string>> values, IList<TableOperationInfo> operations)
        {
            logger.Info("Begin constructor method.");
            string tableBodyHtml = this.getTableBodyHtml(values, operations);
            return this.getTable(columnHeader, tableBodyHtml);
        }
        private string getTable(IList<string> columnHeader,string bodyHtml)
        {
            logger.Info("Begin build table with body html:" + bodyHtml);
            StringBuilder headHtmlBuilder = new StringBuilder();
            headHtmlBuilder.Append("<table class=\"tablelist\">");
            headHtmlBuilder.Append("<thead>");
            foreach (string headerName in columnHeader)
            {
                headHtmlBuilder.Append("<th>");
                headHtmlBuilder.Append(headerName);
                headHtmlBuilder.Append("</th>");
            }
            headHtmlBuilder.Append("</thead>");
            logger.Info("Got HTML header html code:" + headHtmlBuilder.ToString());
            headHtmlBuilder.Append("<tbody>");
            headHtmlBuilder.Append(bodyHtml);
            headHtmlBuilder.Append("</tbody>");
            headHtmlBuilder.Append("</table>");
            logger.Info("Got table HTML:" + headHtmlBuilder.ToString());
            return headHtmlBuilder.ToString();
        }
        private string getTableBodyHtml(IList<IList<string>> values, IList<TableOperationInfo> operations)
        {
            if (null == values)
            {
                logger.Warn("Rows of data is NULL.");
            }
            if (null == values || values.Count < 1)
            {
                logger.Warn("No rows of data.");
            }
            if (null == operations || operations.Count < 1)
            {
                logger.Warn("There is no perations data.");
            }
            StringBuilder htmlBuilder = new StringBuilder();
            try
            {
                foreach (IList<string> columnValues in values)
                {
                    htmlBuilder.Append("<tr>");
                    for (int index = 1; index < columnValues.Count; index++)
                    {
                        htmlBuilder.Append("<td>");
                        htmlBuilder.Append(columnValues[index]);
                        htmlBuilder.Append("</td>");
                    }
                    htmlBuilder.Append(this.getOperationColumn(operations, columnValues[0]));
                    htmlBuilder.Append("</tr>");
                }
            }
            catch (Exception ex)
            {
                logger.Error("Build body failed with exception:" + ex.Message);
            }
            logger.Info("got table body html:" + htmlBuilder.ToString());
            return htmlBuilder.ToString();
        }
        private string getOperationColumn(IList<TableOperationInfo> operations,string id)
        {
            StringBuilder operationBuilder = new StringBuilder();
            operationBuilder.Append("<td>");
            foreach (TableOperationInfo operation in operations)
            {
                operationBuilder.Append(" <a href=\"");
                operationBuilder.Append(operation.HyperLink.Replace("#id#",id));
                operationBuilder.Append("\" target=\"");
                operationBuilder.Append(operation.HyperLinkType);
                operationBuilder.Append("\"");
                if (null != operation.OnClick && "" != operation.OnClick)
                {
                    operationBuilder.Append(" onclick=\"");
                    operationBuilder.Append(operation.OnClick.Replace("#id#", id));
                    operationBuilder.Append("\"");
                }
                operationBuilder.Append("  class=\"tablelink\">");
                operationBuilder.Append(operation.OperationName);
                operationBuilder.Append("</a>&nbsp;&nbsp;");
            }
            operationBuilder.Append("</td>");
            logger.Info("Got operation html:" + operationBuilder.ToString());
            return operationBuilder.ToString();
        }
    }
}