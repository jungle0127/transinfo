using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IVuserrightsDao
    {
		int GetCount();

		IList<Vuserrights> FindAll();

		IList<Vuserrights> PaginationFindAll(VuserrightsPagination obj);

		IList<Vuserrights> QuickFindAll();

		IList<Vuserrights> FindByUserid(Int64 userid);

		IList<Vuserrights> PaginationFindByUserid(VuserrightsPagination obj);

		IList<Vuserrights> FindByRightid(Int64 rightid);

		IList<Vuserrights> PaginationFindByRightid(VuserrightsPagination obj);

		IList<Vuserrights> FindByRighturl(String righturl);

		IList<Vuserrights> PaginationFindByRighturl(VuserrightsPagination obj);

		IList<Vuserrights> FindByGroupname(String groupname);

		IList<Vuserrights> PaginationFindByGroupname(VuserrightsPagination obj);

		IList<Vuserrights> FindByRightname(String rightname);

		IList<Vuserrights> PaginationFindByRightname(VuserrightsPagination obj);

		void Reload(Vuserrights obj);
	}
}
