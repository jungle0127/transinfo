using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity.USP;

namespace Trans.DAL.IDao.USP
{
    public interface IUspUpdateRoleHasRightsDao
    {
        void RunProc(UspUpdateRoleHasRights obj);
    }
}