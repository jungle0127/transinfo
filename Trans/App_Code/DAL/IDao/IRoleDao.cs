using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IRoleDao
    {
		int GetCount();

		Role Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Role> FindAll();

		IList<Role> DescendOrderFindAll();

		IList<Role> PaginationFindAll(RolePagination obj);

		IList<Role> DescendOrderPaginationFindAll(RolePagination obj);

		IList<Role> QuickFindAll();

		IList<Role> FindByActive(Byte active);

		IList<Role> DescendOrderFindByActive(Byte active);

		IList<Role> PaginationFindByActive(RolePagination obj);

		IList<Role> DescendOrderPaginationFindByActive(RolePagination obj);

		int FindCountByActive(Role obj);

		IList<Role> FindByRolename(String rolename);

		IList<Role> DescendOrderFindByRolename(String rolename);

		IList<Role> PaginationFindByRolename(RolePagination obj);

		IList<Role> DescendOrderPaginationFindByRolename(RolePagination obj);

		int FindCountByRolename(Role obj);

		void Insert(Role obj);

		void Update(Role obj);

		void Delete(Role obj);

		int DeleteByActive(Byte active);

		int DeleteByRolename(String rolename);

		void Reload(Role obj);
	}
}
