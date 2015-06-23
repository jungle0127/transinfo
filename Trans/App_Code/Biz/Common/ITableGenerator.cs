using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trans.Biz.Common
{
    interface ITableGenerator
    {
        string getTableHTML(IList<string> columnHeader, IList<IList<string>> values,IList<TableOperationInfo> operations);
    }
}
