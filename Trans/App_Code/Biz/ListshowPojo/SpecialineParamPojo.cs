using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trans.Biz.ListshowPojo
{
    public class SpecialineParamPojo
    {
        public SpecialineParamPojo() { }
        private string typeId;

        public string TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }
        private string cityId;

        public string CityId
        {
            get { return cityId; }
            set { cityId = value; }
        }
        private string deparutreId;

        public string DeparutreId
        {
            get { return deparutreId; }
            set { deparutreId = value; }
        }
        private string dstCityId;

        public string DstCityId
        {
            get { return dstCityId; }
            set { dstCityId = value; }
        }
    }
}