using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Trans.Biz.Common
{
    interface IFrontTableGenerator
    {
        string getTableHTML(Hashtable columnHeader, IList<IList<string>> values);
    }
}
