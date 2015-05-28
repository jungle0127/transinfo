using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IRolehasrightsDao
    {
		int GetCount();

		Rolehasrights Find(Int64 id);

		IList<Rolehasrights> FindAll();

		IList<Rolehasrights> PaginationFindAll(RolehasrightsPagination obj);

		IList<Rolehasrights> QuickFindAll();

		IList<Rolehasrights> FindByActive(Byte active);

		IList<Rolehasrights> PaginationFindByActive(RolehasrightsPagination obj);

		IList<Rolehasrights> FindByRightid(Int64 rightid);

		IList<Rolehasrights> PaginationFindByRightid(RolehasrightsPagination obj);

		IList<Rolehasrights> FindByRoleid(Int64 roleid);

		IList<Rolehasrights> PaginationFindByRoleid(RolehasrightsPagination obj);

		void Insert(Rolehasrights obj);

		void Update(Rolehasrights obj);

		void Delete(Rolehasrights obj);

		int DeleteByActive(Byte active);

		int DeleteByRightid(Int64 rightid);

		int DeleteByRoleid(Int64 roleid);

		void Reload(Rolehasrights obj);
	}
}
