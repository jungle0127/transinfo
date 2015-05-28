using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trans.DAL.Entity;
using System.Collections;

namespace Trans.Biz.Right
{
    public interface IRightManager
    {
        LinkedList<RightsInfo> getRightsByUserId(int userId);
        IList<RightsInfo> getRightsFullInfo();
        Hashtable getRightGroupMap();
        IList<long> getRightIdList(int userId);
    }
}
