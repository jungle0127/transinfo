using System;
using System.Collections.Generic; 
using System.Text;


namespace Trans.DAL.Entity.USP
{
    [Serializable]
    public class UspInsertTrunkMetadata
    {
        private String _xmlData;

        public String XmlData
        {
            get { return _xmlData; }
            set { _xmlData = value; }
        }
    }
}