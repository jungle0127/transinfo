using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IUserhasrightsDao
    {
		int GetCount();

		Userhasrights Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Userhasrights> FindAll();

		IList<Userhasrights> DescendOrderFindAll();

		IList<Userhasrights> PaginationFindAll(UserhasrightsPagination obj);

		IList<Userhasrights> DescendOrderPaginationFindAll(UserhasrightsPagination obj);

		IList<Userhasrights> QuickFindAll();

		IList<Userhasrights> FindByUserid(Int64 userid);

		IList<Userhasrights> DescendOrderFindByUserid(Int64 userid);

		IList<Userhasrights> PaginationFindByUserid(UserhasrightsPagination obj);

		IList<Userhasrights> DescendOrderPaginationFindByUserid(UserhasrightsPagination obj);

		int FindCountByUserid(Userhasrights obj);

		IList<Userhasrights> FindByRightid(Int64 rightid);

		IList<Userhasrights> DescendOrderFindByRightid(Int64 rightid);

		IList<Userhasrights> PaginationFindByRightid(UserhasrightsPagination obj);

		IList<Userhasrights> DescendOrderPaginationFindByRightid(UserhasrightsPagination obj);

		int FindCountByRightid(Userhasrights obj);

		IList<Userhasrights> FindByAcitve(Byte acitve);

		IList<Userhasrights> DescendOrderFindByAcitve(Byte acitve);

		IList<Userhasrights> PaginationFindByAcitve(UserhasrightsPagination obj);

		IList<Userhasrights> DescendOrderPaginationFindByAcitve(UserhasrightsPagination obj);

		int FindCountByAcitve(Userhasrights obj);

		void Insert(Userhasrights obj);

		void Update(Userhasrights obj);

		void Delete(Userhasrights obj);

		int DeleteByUserid(Int64 userid);

		int DeleteByRightid(Int64 rightid);

		int DeleteByAcitve(Byte acitve);

		void Reload(Userhasrights obj);
	}
}
