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
        IList<Int64?> getRightIdList(int userId);
        IList<Int64?> getRightIdListByUserId(long? userId);
        IList<Int64?> getRightIdListByRoleId(long? roleId);
        IList<Int64?> getAllRightIdList();
    }
}
