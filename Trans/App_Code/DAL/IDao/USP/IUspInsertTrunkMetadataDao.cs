using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity.USP;

namespace Trans.DAL.IDao.USP
{
    public interface IUspInsertTrunkMetadataDao
    {
        void RunProc(UspInsertTrunkMetadata obj);
    }
}