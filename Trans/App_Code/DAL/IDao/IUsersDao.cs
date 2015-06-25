using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IUsersDao
    {
		int GetCount();

		Users Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Users> FindAll();

		IList<Users> DescendOrderFindAll();

		IList<Users> PaginationFindAll(UsersPagination obj);

		IList<Users> DescendOrderPaginationFindAll(UsersPagination obj);

		IList<Users> QuickFindAll();

		IList<Users> FindByActive(Byte active);

		IList<Users> DescendOrderFindByActive(Byte active);

		IList<Users> PaginationFindByActive(UsersPagination obj);

		IList<Users> DescendOrderPaginationFindByActive(UsersPagination obj);

		int FindCountByActive(Users obj);

		IList<Users> FindByUsername(String username);

		IList<Users> DescendOrderFindByUsername(String username);

		IList<Users> PaginationFindByUsername(UsersPagination obj);

		IList<Users> DescendOrderPaginationFindByUsername(UsersPagination obj);

		int FindCountByUsername(Users obj);

		IList<Users> FindByRoleid(Int64 roleid);

		IList<Users> DescendOrderFindByRoleid(Int64 roleid);

		IList<Users> PaginationFindByRoleid(UsersPagination obj);

		IList<Users> DescendOrderPaginationFindByRoleid(UsersPagination obj);

		int FindCountByRoleid(Users obj);

		IList<Users> FindByLoginname(String loginname);

		IList<Users> DescendOrderFindByLoginname(String loginname);

		IList<Users> PaginationFindByLoginname(UsersPagination obj);

		IList<Users> DescendOrderPaginationFindByLoginname(UsersPagination obj);

		int FindCountByLoginname(Users obj);

		IList<Users> FindByNote(String note);

		IList<Users> DescendOrderFindByNote(String note);

		IList<Users> PaginationFindByNote(UsersPagination obj);

		IList<Users> DescendOrderPaginationFindByNote(UsersPagination obj);

		int FindCountByNote(Users obj);

		IList<Users> FindByPassword(String password);

		IList<Users> DescendOrderFindByPassword(String password);

		IList<Users> PaginationFindByPassword(UsersPagination obj);

		IList<Users> DescendOrderPaginationFindByPassword(UsersPagination obj);

		int FindCountByPassword(Users obj);

		void Insert(Users obj);

		void Update(Users obj);

		void Delete(Users obj);

		int DeleteByActive(Byte active);

		int DeleteByUsername(String username);

		int DeleteByRoleid(Int64 roleid);

		int DeleteByLoginname(String loginname);

		int DeleteByNote(String note);

		int DeleteByPassword(String password);

		void Reload(Users obj);
	}
}
