using System;
using System.Collections.Generic; 
using System.Text;


namespace Trans.DAL.Entity.USP
{
    [Serializable]
    public class UspUpdateUserHasRights
    {
        private String _xmlData;

        public String XmlData
        {
            get { return _xmlData; }
            set { _xmlData = value; }
        }
    }
}