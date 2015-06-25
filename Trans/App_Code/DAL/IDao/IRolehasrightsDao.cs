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

		int GetFindCount(Int64 id);

		IList<Rolehasrights> FindAll();

		IList<Rolehasrights> DescendOrderFindAll();

		IList<Rolehasrights> PaginationFindAll(RolehasrightsPagination obj);

		IList<Rolehasrights> DescendOrderPaginationFindAll(RolehasrightsPagination obj);

		IList<Rolehasrights> QuickFindAll();

		IList<Rolehasrights> FindByActive(Byte active);

		IList<Rolehasrights> DescendOrderFindByActive(Byte active);

		IList<Rolehasrights> PaginationFindByActive(RolehasrightsPagination obj);

		IList<Rolehasrights> DescendOrderPaginationFindByActive(RolehasrightsPagination obj);

		int FindCountByActive(Rolehasrights obj);

		IList<Rolehasrights> FindByRightid(Int64 rightid);

		IList<Rolehasrights> DescendOrderFindByRightid(Int64 rightid);

		IList<Rolehasrights> PaginationFindByRightid(RolehasrightsPagination obj);

		IList<Rolehasrights> DescendOrderPaginationFindByRightid(RolehasrightsPagination obj);

		int FindCountByRightid(Rolehasrights obj);

		IList<Rolehasrights> FindByRoleid(Int64 roleid);

		IList<Rolehasrights> DescendOrderFindByRoleid(Int64 roleid);

		IList<Rolehasrights> PaginationFindByRoleid(RolehasrightsPagination obj);

		IList<Rolehasrights> DescendOrderPaginationFindByRoleid(RolehasrightsPagination obj);

		int FindCountByRoleid(Rolehasrights obj);

		void Insert(Rolehasrights obj);

		void Update(Rolehasrights obj);

		void Delete(Rolehasrights obj);

		int DeleteByActive(Byte active);

		int DeleteByRightid(Int64 rightid);

		int DeleteByRoleid(Int64 roleid);

		void Reload(Rolehasrights obj);
	}
}
