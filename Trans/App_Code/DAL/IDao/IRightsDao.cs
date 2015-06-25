using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IRightsDao
    {
		int GetCount();

		Rights Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Rights> FindAll();

		IList<Rights> DescendOrderFindAll();

		IList<Rights> PaginationFindAll(RightsPagination obj);

		IList<Rights> DescendOrderPaginationFindAll(RightsPagination obj);

		IList<Rights> QuickFindAll();

		IList<Rights> FindByActive(Byte active);

		IList<Rights> DescendOrderFindByActive(Byte active);

		IList<Rights> PaginationFindByActive(RightsPagination obj);

		IList<Rights> DescendOrderPaginationFindByActive(RightsPagination obj);

		int FindCountByActive(Rights obj);

		IList<Rights> FindByRighturl(String righturl);

		IList<Rights> DescendOrderFindByRighturl(String righturl);

		IList<Rights> PaginationFindByRighturl(RightsPagination obj);

		IList<Rights> DescendOrderPaginationFindByRighturl(RightsPagination obj);

		int FindCountByRighturl(Rights obj);

		IList<Rights> FindByRightname(String rightname);

		IList<Rights> DescendOrderFindByRightname(String rightname);

		IList<Rights> PaginationFindByRightname(RightsPagination obj);

		IList<Rights> DescendOrderPaginationFindByRightname(RightsPagination obj);

		int FindCountByRightname(Rights obj);

		void Insert(Rights obj);

		void Update(Rights obj);

		void Delete(Rights obj);

		int DeleteByActive(Byte active);

		int DeleteByRighturl(String righturl);

		int DeleteByRightname(String rightname);

		void Reload(Rights obj);
	}
}
