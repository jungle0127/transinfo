using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trans.DAL.Entity;

namespace Trans.Biz.Right
{
    public class RightsInfo
    {
        private IList<Rights> rightList;

        public IList<Rights> RightList
        {
            get { return rightList; }
            set { rightList = value; }
        }
        private Rightgroup rightGroup;

        public Rightgroup RightGroup
        {
            get { return rightGroup; }
            set { rightGroup = value; }
        }

    }
}