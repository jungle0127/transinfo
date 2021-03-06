using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IRightgrouphasrightsDao
    {
		int GetCount();

		Rightgrouphasrights Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Rightgrouphasrights> FindAll();

		IList<Rightgrouphasrights> DescendOrderFindAll();

		IList<Rightgrouphasrights> PaginationFindAll(RightgrouphasrightsPagination obj);

		IList<Rightgrouphasrights> DescendOrderPaginationFindAll(RightgrouphasrightsPagination obj);

		IList<Rightgrouphasrights> QuickFindAll();

		IList<Rightgrouphasrights> FindByActive(Byte active);

		IList<Rightgrouphasrights> DescendOrderFindByActive(Byte active);

		IList<Rightgrouphasrights> PaginationFindByActive(RightgrouphasrightsPagination obj);

		IList<Rightgrouphasrights> DescendOrderPaginationFindByActive(RightgrouphasrightsPagination obj);

		int FindCountByActive(Rightgrouphasrights obj);

		IList<Rightgrouphasrights> FindByRightid(Int64 rightid);

		IList<Rightgrouphasrights> DescendOrderFindByRightid(Int64 rightid);

		IList<Rightgrouphasrights> PaginationFindByRightid(RightgrouphasrightsPagination obj);

		IList<Rightgrouphasrights> DescendOrderPaginationFindByRightid(RightgrouphasrightsPagination obj);

		int FindCountByRightid(Rightgrouphasrights obj);

		IList<Rightgrouphasrights> FindByGroupid(Int64 groupid);

		IList<Rightgrouphasrights> DescendOrderFindByGroupid(Int64 groupid);

		IList<Rightgrouphasrights> PaginationFindByGroupid(RightgrouphasrightsPagination obj);

		IList<Rightgrouphasrights> DescendOrderPaginationFindByGroupid(RightgrouphasrightsPagination obj);

		int FindCountByGroupid(Rightgrouphasrights obj);

		void Insert(Rightgrouphasrights obj);

		void Update(Rightgrouphasrights obj);

		void Delete(Rightgrouphasrights obj);

		int DeleteByActive(Byte active);

		int DeleteByRightid(Int64 rightid);

		int DeleteByGroupid(Int64 groupid);

		void Reload(Rightgrouphasrights obj);
	}
}
