using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trans.Biz.Common
{
    public class TableOperationInfo
    {
        private string operationName;

        public string OperationName
        {
            get { return operationName; }
            set { operationName = value; }
        }
        private string hyperLink = "#";

        public string HyperLink
        {
            get { return hyperLink; }
            set { hyperLink = value; }
        }
        private string hyperLinkType = "_self";

        public string HyperLinkType
        {
            get { return hyperLinkType; }
            set { hyperLinkType = value; }
        }
        private string onClick;

        public string OnClick
        {
            get { return onClick; }
            set { onClick = value; }
        }
    }
}