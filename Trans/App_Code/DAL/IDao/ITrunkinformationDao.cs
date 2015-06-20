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

		IList<Trunkinformation> PaginationFindAll(TrunkinformationPagination obj);

		IList<Trunkinformation> QuickFindAll();

		IList<Trunkinformation> FindBySrccountycode(String srccountycode);

		IList<Trunkinformation> PaginationFindBySrccountycode(TrunkinformationPagination obj);

		int FindCountBySrccountycode(Trunkinformation obj);

		IList<Trunkinformation> FindByMarketprice(String marketprice);

		IList<Trunkinformation> PaginationFindByMarketprice(TrunkinformationPagination obj);

		int FindCountByMarketprice(Trunkinformation obj);

		IList<Trunkinformation> FindByTimetypeid(Int64 timetypeid);

		IList<Trunkinformation> PaginationFindByTimetypeid(TrunkinformationPagination obj);

		int FindCountByTimetypeid(Trunkinformation obj);

		IList<Trunkinformation> FindByTakeofftime(DateTime takeofftime);

		IList<Trunkinformation> PaginationFindByTakeofftime(TrunkinformationPagination obj);

		int FindCountByTakeofftime(Trunkinformation obj);

		IList<Trunkinformation> FindByRouter(String router);

		IList<Trunkinformation> PaginationFindByRouter(TrunkinformationPagination obj);

		int FindCountByRouter(Trunkinformation obj);

		IList<Trunkinformation> FindByUserid(Int64 userid);

		IList<Trunkinformation> PaginationFindByUserid(TrunkinformationPagination obj);

		int FindCountByUserid(Trunkinformation obj);

		IList<Trunkinformation> FindByNegotiateprice(String negotiateprice);

		IList<Trunkinformation> PaginationFindByNegotiateprice(TrunkinformationPagination obj);

		int FindCountByNegotiateprice(Trunkinformation obj);

		IList<Trunkinformation> FindByReturntypeid(Int64 returntypeid);

		IList<Trunkinformation> PaginationFindByReturntypeid(TrunkinformationPagination obj);

		int FindCountByReturntypeid(Trunkinformation obj);

		IList<Trunkinformation> FindByActive(Byte active);

		IList<Trunkinformation> PaginationFindByActive(TrunkinformationPagination obj);

		int FindCountByActive(Trunkinformation obj);

		IList<Trunkinformation> FindByTrunkid(Int64 trunkid);

		IList<Trunkinformation> PaginationFindByTrunkid(TrunkinformationPagination obj);

		int FindCountByTrunkid(Trunkinformation obj);

		IList<Trunkinformation> FindByTitle(String title);

		IList<Trunkinformation> PaginationFindByTitle(TrunkinformationPagination obj);

		int FindCountByTitle(Trunkinformation obj);

		IList<Trunkinformation> FindByDstcountycode(String dstcountycode);

		IList<Trunkinformation> PaginationFindByDstcountycode(TrunkinformationPagination obj);

		int FindCountByDstcountycode(Trunkinformation obj);

		IList<Trunkinformation> FindByReleasedate(DateTime releasedate);

		IList<Trunkinformation> PaginationFindByReleasedate(TrunkinformationPagination obj);

		int FindCountByReleasedate(Trunkinformation obj);

		IList<Trunkinformation> FindByDescription(String description);

		IList<Trunkinformation> PaginationFindByDescription(TrunkinformationPagination obj);

		int FindCountByDescription(Trunkinformation obj);

		IList<Trunkinformation> FindByRoutetypeid(Int64 routetypeid);

		IList<Trunkinformation> PaginationFindByRoutetypeid(TrunkinformationPagination obj);

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
