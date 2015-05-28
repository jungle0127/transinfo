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

		IList<Users> FindAll();

		IList<Users> PaginationFindAll(UsersPagination obj);

		IList<Users> QuickFindAll();

		IList<Users> FindByActive(Byte active);

		IList<Users> PaginationFindByActive(UsersPagination obj);

		IList<Users> FindByUsername(String username);

		IList<Users> PaginationFindByUsername(UsersPagination obj);

		IList<Users> FindByRoleid(Int64 roleid);

		IList<Users> PaginationFindByRoleid(UsersPagination obj);

		IList<Users> FindByLoginname(String loginname);

		IList<Users> PaginationFindByLoginname(UsersPagination obj);

		IList<Users> FindByNote(String note);

		IList<Users> PaginationFindByNote(UsersPagination obj);

		IList<Users> FindByPassword(String password);

		IList<Users> PaginationFindByPassword(UsersPagination obj);

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
