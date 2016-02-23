using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trans.Biz.ListshowPojo
{
    public class DepotParamPojo
    {
        public DepotParamPojo() { }
        private string cityId;

        public string CityId
        {
            get { return cityId; }
            set { cityId = value; }
        }
        private string typeId;

        public string TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }
        private string scopeId;

        public string ScopeId
        {
            get { return scopeId; }
            set { scopeId = value; }
        }
        private string area;

        public string Area
        {
            get { return area; }
            set { area = value; }
        }
    }
}