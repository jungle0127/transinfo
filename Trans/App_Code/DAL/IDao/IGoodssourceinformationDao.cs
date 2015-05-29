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

		IList<Goodssourceinformation> FindAll();

		IList<Goodssourceinformation> PaginationFindAll(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> QuickFindAll();

		IList<Goodssourceinformation> FindByCautiontypeid(Int64 cautiontypeid);

		IList<Goodssourceinformation> PaginationFindByCautiontypeid(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindByNeedtrunkvolume(Int64 needtrunkvolume);

		IList<Goodssourceinformation> PaginationFindByNeedtrunkvolume(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindByDeadline(DateTime deadline);

		IList<Goodssourceinformation> PaginationFindByDeadline(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindByNeedtrunkweight(Int64 needtrunkweight);

		IList<Goodssourceinformation> PaginationFindByNeedtrunkweight(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindByReleasedate(DateTime releasedate);

		IList<Goodssourceinformation> PaginationFindByReleasedate(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindByUserid(Int64 userid);

		IList<Goodssourceinformation> PaginationFindByUserid(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindByNeedtrunklength(Int64 needtrunklength);

		IList<Goodssourceinformation> PaginationFindByNeedtrunklength(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindByPrice(String price);

		IList<Goodssourceinformation> PaginationFindByPrice(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindByGoodsname(String goodsname);

		IList<Goodssourceinformation> PaginationFindByGoodsname(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindByTitle(String title);

		IList<Goodssourceinformation> PaginationFindByTitle(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindByTransporttypeid(Int64 transporttypeid);

		IList<Goodssourceinformation> PaginationFindByTransporttypeid(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindByContent(String content);

		IList<Goodssourceinformation> PaginationFindByContent(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindBySrccountycode(String srccountycode);

		IList<Goodssourceinformation> PaginationFindBySrccountycode(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindByDstcountycode(String dstcountycode);

		IList<Goodssourceinformation> PaginationFindByDstcountycode(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindByActive(Byte active);

		IList<Goodssourceinformation> PaginationFindByActive(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindByGoodstypeid(Int64 goodstypeid);

		IList<Goodssourceinformation> PaginationFindByGoodstypeid(GoodssourceinformationPagination obj);

		IList<Goodssourceinformation> FindByTitlecolor(String titlecolor);

		IList<Goodssourceinformation> PaginationFindByTitlecolor(GoodssourceinformationPagination obj);

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
