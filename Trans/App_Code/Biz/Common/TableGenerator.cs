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
            string tableBodyHtml = this.getTableBodyHtml(values, operations);
            return this.getTable(columnHeader, tableBodyHtml);
        }
        private string getTable(IList<string> columnHeader,string bodyHtml)
        {
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
            headHtmlBuilder.Append("<tbody>");
            headHtmlBuilder.Append(bodyHtml);
            headHtmlBuilder.Append("</tbody>");
            headHtmlBuilder.Append("</table>");
            return headHtmlBuilder.ToString();
        }
        private string getTableBodyHtml(IList<IList<string>> values, IList<TableOperationInfo> operations)
        {
            StringBuilder htmlBuilder = new StringBuilder();
            foreach (IList<string> columnValues in values)
            {
                htmlBuilder.Append("<tr>");
                foreach (string columnValue in columnValues)
                {
                    htmlBuilder.Append("<td>");
                    htmlBuilder.Append(columnValue);
                    htmlBuilder.Append("</td>");
                }
                htmlBuilder.Append(this.getOperationColumn(operations, columnValues[0]));
                htmlBuilder.Append("</tr>");
            }
            return htmlBuilder.ToString();
        }
        private string getOperationColumn(IList<TableOperationInfo> operations,string id)
        {
            StringBuilder operationBuilder = new StringBuilder();
            operationBuilder.Append("<td>");
            foreach (TableOperationInfo operation in operations)
            {
                operationBuilder.Append("<a href=\"");
                operationBuilder.Append(operation.HyperLink.Replace("#id#",id));
                operationBuilder.Append("\" target=\"");
                operationBuilder.Append(operation.HyperLinkType);
                operationBuilder.Append("\"");
                if (null != operation.OnClick && "" != operation.OnClick.Replace("#id#",id))
                {
                    operationBuilder.Append(" onclick=\"");
                    operationBuilder.Append(operation.OnClick);
                    operationBuilder.Append("\"");
                }
                operationBuilder.Append("  class=\"tablelink\">");
                operationBuilder.Append(operation.OperationName);
                operationBuilder.Append("</a>");
            }
            operationBuilder.Append("</td>");
            return operationBuilder.ToString();
        }
    }
}