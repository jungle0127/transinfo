using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IVgoodssourceinformationDao
    {
        IList<Vgoodssourceinformation> DynamicQuery(VgoodssourceinformationPagination obj);

        int DynamicCount(VgoodssourceinformationPagination obj);

		int GetCount();

		IList<Vgoodssourceinformation> FindAll();

		IList<Vgoodssourceinformation> DescendOrderFindAll();

		IList<Vgoodssourceinformation> PaginationFindAll(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindAll(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> QuickFindAll();

		IList<Vgoodssourceinformation> FindByGoodstypename(String goodstypename);

		IList<Vgoodssourceinformation> DescendOrderFindByGoodstypename(String goodstypename);

		IList<Vgoodssourceinformation> PaginationFindByGoodstypename(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByGoodstypename(VgoodssourceinformationPagination obj);

		int FindCountByGoodstypename(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByGoodstypeid(Int64 goodstypeid);

		IList<Vgoodssourceinformation> DescendOrderFindByGoodstypeid(Int64 goodstypeid);

		IList<Vgoodssourceinformation> PaginationFindByGoodstypeid(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByGoodstypeid(VgoodssourceinformationPagination obj);

		int FindCountByGoodstypeid(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByDeadline(DateTime deadline);

		IList<Vgoodssourceinformation> DescendOrderFindByDeadline(DateTime deadline);

		IList<Vgoodssourceinformation> PaginationFindByDeadline(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByDeadline(VgoodssourceinformationPagination obj);

		int FindCountByDeadline(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByNeedtrunkweight(Int64 needtrunkweight);

		IList<Vgoodssourceinformation> DescendOrderFindByNeedtrunkweight(Int64 needtrunkweight);

		IList<Vgoodssourceinformation> PaginationFindByNeedtrunkweight(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByNeedtrunkweight(VgoodssourceinformationPagination obj);

		int FindCountByNeedtrunkweight(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByTransporttypename(String transporttypename);

		IList<Vgoodssourceinformation> DescendOrderFindByTransporttypename(String transporttypename);

		IList<Vgoodssourceinformation> PaginationFindByTransporttypename(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByTransporttypename(VgoodssourceinformationPagination obj);

		int FindCountByTransporttypename(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByCautiontypename(String cautiontypename);

		IList<Vgoodssourceinformation> DescendOrderFindByCautiontypename(String cautiontypename);

		IList<Vgoodssourceinformation> PaginationFindByCautiontypename(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByCautiontypename(VgoodssourceinformationPagination obj);

		int FindCountByCautiontypename(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByNeedtrunklength(Int64 needtrunklength);

		IList<Vgoodssourceinformation> DescendOrderFindByNeedtrunklength(Int64 needtrunklength);

		IList<Vgoodssourceinformation> PaginationFindByNeedtrunklength(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByNeedtrunklength(VgoodssourceinformationPagination obj);

		int FindCountByNeedtrunklength(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByPrice(String price);

		IList<Vgoodssourceinformation> DescendOrderFindByPrice(String price);

		IList<Vgoodssourceinformation> PaginationFindByPrice(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByPrice(VgoodssourceinformationPagination obj);

		int FindCountByPrice(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByGoodsname(String goodsname);

		IList<Vgoodssourceinformation> DescendOrderFindByGoodsname(String goodsname);

		IList<Vgoodssourceinformation> PaginationFindByGoodsname(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByGoodsname(VgoodssourceinformationPagination obj);

		int FindCountByGoodsname(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindBySrccityname(String srccityname);

		IList<Vgoodssourceinformation> DescendOrderFindBySrccityname(String srccityname);

		IList<Vgoodssourceinformation> PaginationFindBySrccityname(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindBySrccityname(VgoodssourceinformationPagination obj);

		int FindCountBySrccityname(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindBySrccitycode(String srccitycode);

		IList<Vgoodssourceinformation> DescendOrderFindBySrccitycode(String srccitycode);

		IList<Vgoodssourceinformation> PaginationFindBySrccitycode(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindBySrccitycode(VgoodssourceinformationPagination obj);

		int FindCountBySrccitycode(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindBySrcregionname(String srcregionname);

		IList<Vgoodssourceinformation> DescendOrderFindBySrcregionname(String srcregionname);

		IList<Vgoodssourceinformation> PaginationFindBySrcregionname(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindBySrcregionname(VgoodssourceinformationPagination obj);

		int FindCountBySrcregionname(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByContent(String content);

		IList<Vgoodssourceinformation> DescendOrderFindByContent(String content);

		IList<Vgoodssourceinformation> PaginationFindByContent(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByContent(VgoodssourceinformationPagination obj);

		int FindCountByContent(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindById(Int64 id);

		IList<Vgoodssourceinformation> DescendOrderFindById(Int64 id);

		IList<Vgoodssourceinformation> PaginationFindById(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindById(VgoodssourceinformationPagination obj);

		int FindCountById(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByDstregionname(String dstregionname);

		IList<Vgoodssourceinformation> DescendOrderFindByDstregionname(String dstregionname);

		IList<Vgoodssourceinformation> PaginationFindByDstregionname(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByDstregionname(VgoodssourceinformationPagination obj);

		int FindCountByDstregionname(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByNeedtrunkvolume(Int64 needtrunkvolume);

		IList<Vgoodssourceinformation> DescendOrderFindByNeedtrunkvolume(Int64 needtrunkvolume);

		IList<Vgoodssourceinformation> PaginationFindByNeedtrunkvolume(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByNeedtrunkvolume(VgoodssourceinformationPagination obj);

		int FindCountByNeedtrunkvolume(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByReleasedate(DateTime releasedate);

		IList<Vgoodssourceinformation> DescendOrderFindByReleasedate(DateTime releasedate);

		IList<Vgoodssourceinformation> PaginationFindByReleasedate(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByReleasedate(VgoodssourceinformationPagination obj);

		int FindCountByReleasedate(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByDstcityname(String dstcityname);

		IList<Vgoodssourceinformation> DescendOrderFindByDstcityname(String dstcityname);

		IList<Vgoodssourceinformation> PaginationFindByDstcityname(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByDstcityname(VgoodssourceinformationPagination obj);

		int FindCountByDstcityname(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByDstcitycode(String dstcitycode);

		IList<Vgoodssourceinformation> DescendOrderFindByDstcitycode(String dstcitycode);

		IList<Vgoodssourceinformation> PaginationFindByDstcitycode(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByDstcitycode(VgoodssourceinformationPagination obj);

		int FindCountByDstcitycode(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByTitle(String title);

		IList<Vgoodssourceinformation> DescendOrderFindByTitle(String title);

		IList<Vgoodssourceinformation> PaginationFindByTitle(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByTitle(VgoodssourceinformationPagination obj);

		int FindCountByTitle(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByTitlecolor(String titlecolor);

		IList<Vgoodssourceinformation> DescendOrderFindByTitlecolor(String titlecolor);

		IList<Vgoodssourceinformation> PaginationFindByTitlecolor(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByTitlecolor(VgoodssourceinformationPagination obj);

		int FindCountByTitlecolor(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByUsername(String username);

		IList<Vgoodssourceinformation> DescendOrderFindByUsername(String username);

		IList<Vgoodssourceinformation> PaginationFindByUsername(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> DescendOrderPaginationFindByUsername(VgoodssourceinformationPagination obj);

		int FindCountByUsername(Vgoodssourceinformation obj);

		void Reload(Vgoodssourceinformation obj);
	}
}
