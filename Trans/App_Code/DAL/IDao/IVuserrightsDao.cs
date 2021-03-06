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

		IList<Vuserrights> DescendOrderFindAll();

		IList<Vuserrights> PaginationFindAll(VuserrightsPagination obj);

		IList<Vuserrights> DescendOrderPaginationFindAll(VuserrightsPagination obj);

		IList<Vuserrights> QuickFindAll();

		IList<Vuserrights> FindById(Int64 id);

		IList<Vuserrights> DescendOrderFindById(Int64 id);

		IList<Vuserrights> PaginationFindById(VuserrightsPagination obj);

		IList<Vuserrights> DescendOrderPaginationFindById(VuserrightsPagination obj);

		int FindCountById(Vuserrights obj);

		IList<Vuserrights> FindByRightname(String rightname);

		IList<Vuserrights> DescendOrderFindByRightname(String rightname);

		IList<Vuserrights> PaginationFindByRightname(VuserrightsPagination obj);

		IList<Vuserrights> DescendOrderPaginationFindByRightname(VuserrightsPagination obj);

		int FindCountByRightname(Vuserrights obj);

		IList<Vuserrights> FindByRighturl(String righturl);

		IList<Vuserrights> DescendOrderFindByRighturl(String righturl);

		IList<Vuserrights> PaginationFindByRighturl(VuserrightsPagination obj);

		IList<Vuserrights> DescendOrderPaginationFindByRighturl(VuserrightsPagination obj);

		int FindCountByRighturl(Vuserrights obj);

		IList<Vuserrights> FindByGroupid(Int64 groupid);

		IList<Vuserrights> DescendOrderFindByGroupid(Int64 groupid);

		IList<Vuserrights> PaginationFindByGroupid(VuserrightsPagination obj);

		IList<Vuserrights> DescendOrderPaginationFindByGroupid(VuserrightsPagination obj);

		int FindCountByGroupid(Vuserrights obj);

		IList<Vuserrights> FindByRightid(Int64 rightid);

		IList<Vuserrights> DescendOrderFindByRightid(Int64 rightid);

		IList<Vuserrights> PaginationFindByRightid(VuserrightsPagination obj);

		IList<Vuserrights> DescendOrderPaginationFindByRightid(VuserrightsPagination obj);

		int FindCountByRightid(Vuserrights obj);

		IList<Vuserrights> FindByRighttype(Int64 righttype);

		IList<Vuserrights> DescendOrderFindByRighttype(Int64 righttype);

		IList<Vuserrights> PaginationFindByRighttype(VuserrightsPagination obj);

		IList<Vuserrights> DescendOrderPaginationFindByRighttype(VuserrightsPagination obj);

		int FindCountByRighttype(Vuserrights obj);

		IList<Vuserrights> FindByGroupname(String groupname);

		IList<Vuserrights> DescendOrderFindByGroupname(String groupname);

		IList<Vuserrights> PaginationFindByGroupname(VuserrightsPagination obj);

		IList<Vuserrights> DescendOrderPaginationFindByGroupname(VuserrightsPagination obj);

		int FindCountByGroupname(Vuserrights obj);

		void Reload(Vuserrights obj);
	}
}
