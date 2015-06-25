using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IGoodssourceinformationDao
    {
		int GetCount();

		Goodssourceinformation Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Goodssourceinformation> FindAll();

		IList<Goodssourceinformation> DescendOrderFindAll();

		IList<Goodssourceinformation> PaginationFindAll(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindAll(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> QuickFindAll();

		IList<Goodssourceinformation> FindByCautiontypeid(Int64 cautiontypeid);

		IList<Goodssourceinformation> DescendOrderFindByCautiontypeid(Int64 cautiontypeid);

		IList<Goodssourceinformation> PaginationFindByCautiontypeid(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByCautiontypeid(GoodssourceinformationPagination obj);

		int FindCountByCautiontypeid(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindByNeedtrunkvolume(Int64 needtrunkvolume);

		IList<Goodssourceinformation> DescendOrderFindByNeedtrunkvolume(Int64 needtrunkvolume);

		IList<Goodssourceinformation> PaginationFindByNeedtrunkvolume(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByNeedtrunkvolume(GoodssourceinformationPagination obj);

		int FindCountByNeedtrunkvolume(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindByDeadline(DateTime deadline);

		IList<Goodssourceinformation> DescendOrderFindByDeadline(DateTime deadline);

		IList<Goodssourceinformation> PaginationFindByDeadline(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByDeadline(GoodssourceinformationPagination obj);

		int FindCountByDeadline(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindByNeedtrunkweight(Int64 needtrunkweight);

		IList<Goodssourceinformation> DescendOrderFindByNeedtrunkweight(Int64 needtrunkweight);

		IList<Goodssourceinformation> PaginationFindByNeedtrunkweight(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByNeedtrunkweight(GoodssourceinformationPagination obj);

		int FindCountByNeedtrunkweight(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindByReleasedate(DateTime releasedate);

		IList<Goodssourceinformation> DescendOrderFindByReleasedate(DateTime releasedate);

		IList<Goodssourceinformation> PaginationFindByReleasedate(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByReleasedate(GoodssourceinformationPagination obj);

		int FindCountByReleasedate(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindByUserid(Int64 userid);

		IList<Goodssourceinformation> DescendOrderFindByUserid(Int64 userid);

		IList<Goodssourceinformation> PaginationFindByUserid(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByUserid(GoodssourceinformationPagination obj);

		int FindCountByUserid(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindByNeedtrunklength(Int64 needtrunklength);

		IList<Goodssourceinformation> DescendOrderFindByNeedtrunklength(Int64 needtrunklength);

		IList<Goodssourceinformation> PaginationFindByNeedtrunklength(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByNeedtrunklength(GoodssourceinformationPagination obj);

		int FindCountByNeedtrunklength(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindByPrice(String price);

		IList<Goodssourceinformation> DescendOrderFindByPrice(String price);

		IList<Goodssourceinformation> PaginationFindByPrice(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByPrice(GoodssourceinformationPagination obj);

		int FindCountByPrice(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindByGoodsname(String goodsname);

		IList<Goodssourceinformation> DescendOrderFindByGoodsname(String goodsname);

		IList<Goodssourceinformation> PaginationFindByGoodsname(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByGoodsname(GoodssourceinformationPagination obj);

		int FindCountByGoodsname(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindByTitle(String title);

		IList<Goodssourceinformation> DescendOrderFindByTitle(String title);

		IList<Goodssourceinformation> PaginationFindByTitle(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByTitle(GoodssourceinformationPagination obj);

		int FindCountByTitle(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindByTransporttypeid(Int64 transporttypeid);

		IList<Goodssourceinformation> DescendOrderFindByTransporttypeid(Int64 transporttypeid);

		IList<Goodssourceinformation> PaginationFindByTransporttypeid(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByTransporttypeid(GoodssourceinformationPagination obj);

		int FindCountByTransporttypeid(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindByContent(String content);

		IList<Goodssourceinformation> DescendOrderFindByContent(String content);

		IList<Goodssourceinformation> PaginationFindByContent(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByContent(GoodssourceinformationPagination obj);

		int FindCountByContent(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindBySrccountycode(String srccountycode);

		IList<Goodssourceinformation> DescendOrderFindBySrccountycode(String srccountycode);

		IList<Goodssourceinformation> PaginationFindBySrccountycode(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindBySrccountycode(GoodssourceinformationPagination obj);

		int FindCountBySrccountycode(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindByDstcountycode(String dstcountycode);

		IList<Goodssourceinformation> DescendOrderFindByDstcountycode(String dstcountycode);

		IList<Goodssourceinformation> PaginationFindByDstcountycode(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByDstcountycode(GoodssourceinformationPagination obj);

		int FindCountByDstcountycode(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindByActive(Byte active);

		IList<Goodssourceinformation> DescendOrderFindByActive(Byte active);

		IList<Goodssourceinformation> PaginationFindByActive(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByActive(GoodssourceinformationPagination obj);

		int FindCountByActive(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindByGoodstypeid(Int64 goodstypeid);

		IList<Goodssourceinformation> DescendOrderFindByGoodstypeid(Int64 goodstypeid);

		IList<Goodssourceinformation> PaginationFindByGoodstypeid(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByGoodstypeid(GoodssourceinformationPagination obj);

		int FindCountByGoodstypeid(Goodssourceinformation obj);

		IList<Goodssourceinformation> FindByTitlecolor(String titlecolor);

		IList<Goodssourceinformation> DescendOrderFindByTitlecolor(String titlecolor);

		IList<Goodssourceinformation> PaginationFindByTitlecolor(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> DescendOrderPaginationFindByTitlecolor(GoodssourceinformationPagination obj);

		int FindCountByTitlecolor(Goodssourceinformation obj);

		void Insert(Goodssourceinformation obj);

		void Update(Goodssourceinformation obj);

		void Delete(Goodssourceinformation obj);

		int DeleteByCautiontypeid(Int64 cautiontypeid);

		int DeleteByNeedtrunkvolume(Int64 needtrunkvolume);

		int DeleteByDeadline(DateTime deadline);

		int DeleteByNeedtrunkweight(Int64 needtrunkweight);

		int DeleteByReleasedate(DateTime releasedate);

		int DeleteByUserid(Int64 userid);

		int DeleteByNeedtrunklength(Int64 needtrunklength);

		int DeleteByPrice(String price);

		int DeleteByGoodsname(String goodsname);

		int DeleteByTitle(String title);

		int DeleteByTransporttypeid(Int64 transporttypeid);

		int DeleteByContent(String content);

		int DeleteBySrccountycode(String srccountycode);

		int DeleteByDstcountycode(String dstcountycode);

		int DeleteByActive(Byte active);

		int DeleteByGoodstypeid(Int64 goodstypeid);

		int DeleteByTitlecolor(String titlecolor);

		void Reload(Goodssourceinformation obj);
	}
}
