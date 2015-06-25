using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ITrunkinformationDao
    {
		int GetCount();

		Trunkinformation Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Trunkinformation> FindAll();

		IList<Trunkinformation> DescendOrderFindAll();

		IList<Trunkinformation> PaginationFindAll(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindAll(TrunkinformationPagination obj);

		IList<Trunkinformation> QuickFindAll();

		IList<Trunkinformation> FindBySrccountycode(String srccountycode);

		IList<Trunkinformation> DescendOrderFindBySrccountycode(String srccountycode);

		IList<Trunkinformation> PaginationFindBySrccountycode(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindBySrccountycode(TrunkinformationPagination obj);

		int FindCountBySrccountycode(Trunkinformation obj);

		IList<Trunkinformation> FindByMarketprice(String marketprice);

		IList<Trunkinformation> DescendOrderFindByMarketprice(String marketprice);

		IList<Trunkinformation> PaginationFindByMarketprice(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindByMarketprice(TrunkinformationPagination obj);

		int FindCountByMarketprice(Trunkinformation obj);

		IList<Trunkinformation> FindByTimetypeid(Int64 timetypeid);

		IList<Trunkinformation> DescendOrderFindByTimetypeid(Int64 timetypeid);

		IList<Trunkinformation> PaginationFindByTimetypeid(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindByTimetypeid(TrunkinformationPagination obj);

		int FindCountByTimetypeid(Trunkinformation obj);

		IList<Trunkinformation> FindByTakeofftime(DateTime takeofftime);

		IList<Trunkinformation> DescendOrderFindByTakeofftime(DateTime takeofftime);

		IList<Trunkinformation> PaginationFindByTakeofftime(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindByTakeofftime(TrunkinformationPagination obj);

		int FindCountByTakeofftime(Trunkinformation obj);

		IList<Trunkinformation> FindByRouter(String router);

		IList<Trunkinformation> DescendOrderFindByRouter(String router);

		IList<Trunkinformation> PaginationFindByRouter(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindByRouter(TrunkinformationPagination obj);

		int FindCountByRouter(Trunkinformation obj);

		IList<Trunkinformation> FindByUserid(Int64 userid);

		IList<Trunkinformation> DescendOrderFindByUserid(Int64 userid);

		IList<Trunkinformation> PaginationFindByUserid(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindByUserid(TrunkinformationPagination obj);

		int FindCountByUserid(Trunkinformation obj);

		IList<Trunkinformation> FindByNegotiateprice(String negotiateprice);

		IList<Trunkinformation> DescendOrderFindByNegotiateprice(String negotiateprice);

		IList<Trunkinformation> PaginationFindByNegotiateprice(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindByNegotiateprice(TrunkinformationPagination obj);

		int FindCountByNegotiateprice(Trunkinformation obj);

		IList<Trunkinformation> FindByReturntypeid(Int64 returntypeid);

		IList<Trunkinformation> DescendOrderFindByReturntypeid(Int64 returntypeid);

		IList<Trunkinformation> PaginationFindByReturntypeid(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindByReturntypeid(TrunkinformationPagination obj);

		int FindCountByReturntypeid(Trunkinformation obj);

		IList<Trunkinformation> FindByActive(Byte active);

		IList<Trunkinformation> DescendOrderFindByActive(Byte active);

		IList<Trunkinformation> PaginationFindByActive(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindByActive(TrunkinformationPagination obj);

		int FindCountByActive(Trunkinformation obj);

		IList<Trunkinformation> FindByTrunkid(Int64 trunkid);

		IList<Trunkinformation> DescendOrderFindByTrunkid(Int64 trunkid);

		IList<Trunkinformation> PaginationFindByTrunkid(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindByTrunkid(TrunkinformationPagination obj);

		int FindCountByTrunkid(Trunkinformation obj);

		IList<Trunkinformation> FindByTitle(String title);

		IList<Trunkinformation> DescendOrderFindByTitle(String title);

		IList<Trunkinformation> PaginationFindByTitle(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindByTitle(TrunkinformationPagination obj);

		int FindCountByTitle(Trunkinformation obj);

		IList<Trunkinformation> FindByDstcountycode(String dstcountycode);

		IList<Trunkinformation> DescendOrderFindByDstcountycode(String dstcountycode);

		IList<Trunkinformation> PaginationFindByDstcountycode(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindByDstcountycode(TrunkinformationPagination obj);

		int FindCountByDstcountycode(Trunkinformation obj);

		IList<Trunkinformation> FindByReleasedate(DateTime releasedate);

		IList<Trunkinformation> DescendOrderFindByReleasedate(DateTime releasedate);

		IList<Trunkinformation> PaginationFindByReleasedate(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindByReleasedate(TrunkinformationPagination obj);

		int FindCountByReleasedate(Trunkinformation obj);

		IList<Trunkinformation> FindByDescription(String description);

		IList<Trunkinformation> DescendOrderFindByDescription(String description);

		IList<Trunkinformation> PaginationFindByDescription(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindByDescription(TrunkinformationPagination obj);

		int FindCountByDescription(Trunkinformation obj);

		IList<Trunkinformation> FindByRoutetypeid(Int64 routetypeid);

		IList<Trunkinformation> DescendOrderFindByRoutetypeid(Int64 routetypeid);

		IList<Trunkinformation> PaginationFindByRoutetypeid(TrunkinformationPagination obj);

		IList<Trunkinformation> DescendOrderPaginationFindByRoutetypeid(TrunkinformationPagination obj);

		int FindCountByRoutetypeid(Trunkinformation obj);

		void Insert(Trunkinformation obj);

		void Update(Trunkinformation obj);

		void Delete(Trunkinformation obj);

		int DeleteBySrccountycode(String srccountycode);

		int DeleteByMarketprice(String marketprice);

		int DeleteByTimetypeid(Int64 timetypeid);

		int DeleteByTakeofftime(DateTime takeofftime);

		int DeleteByRouter(String router);

		int DeleteByUserid(Int64 userid);

		int DeleteByNegotiateprice(String negotiateprice);

		int DeleteByReturntypeid(Int64 returntypeid);

		int DeleteByActive(Byte active);

		int DeleteByTrunkid(Int64 trunkid);

		int DeleteByTitle(String title);

		int DeleteByDstcountycode(String dstcountycode);

		int DeleteByReleasedate(DateTime releasedate);

		int DeleteByDescription(String description);

		int DeleteByRoutetypeid(Int64 routetypeid);

		void Reload(Trunkinformation obj);
	}
}
