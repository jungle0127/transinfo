using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IVgoodssourceinformationDao
    {
		int GetCount();

		IList<Vgoodssourceinformation> FindAll();

		IList<Vgoodssourceinformation> PaginationFindAll(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> QuickFindAll();

		IList<Vgoodssourceinformation> FindByGoodstypename(String goodstypename);

		IList<Vgoodssourceinformation> PaginationFindByGoodstypename(VgoodssourceinformationPagination obj);

		int FindCountByGoodstypename(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByNeedtrunkvolume(Int64 needtrunkvolume);

		IList<Vgoodssourceinformation> PaginationFindByNeedtrunkvolume(VgoodssourceinformationPagination obj);

		int FindCountByNeedtrunkvolume(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByDeadline(DateTime deadline);

		IList<Vgoodssourceinformation> PaginationFindByDeadline(VgoodssourceinformationPagination obj);

		int FindCountByDeadline(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByNeedtrunkweight(Int64 needtrunkweight);

		IList<Vgoodssourceinformation> PaginationFindByNeedtrunkweight(VgoodssourceinformationPagination obj);

		int FindCountByNeedtrunkweight(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByTransporttypename(String transporttypename);

		IList<Vgoodssourceinformation> PaginationFindByTransporttypename(VgoodssourceinformationPagination obj);

		int FindCountByTransporttypename(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByCautiontypename(String cautiontypename);

		IList<Vgoodssourceinformation> PaginationFindByCautiontypename(VgoodssourceinformationPagination obj);

		int FindCountByCautiontypename(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByNeedtrunklength(Int64 needtrunklength);

		IList<Vgoodssourceinformation> PaginationFindByNeedtrunklength(VgoodssourceinformationPagination obj);

		int FindCountByNeedtrunklength(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByPrice(String price);

		IList<Vgoodssourceinformation> PaginationFindByPrice(VgoodssourceinformationPagination obj);

		int FindCountByPrice(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByGoodsname(String goodsname);

		IList<Vgoodssourceinformation> PaginationFindByGoodsname(VgoodssourceinformationPagination obj);

		int FindCountByGoodsname(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindBySrccityname(String srccityname);

		IList<Vgoodssourceinformation> PaginationFindBySrccityname(VgoodssourceinformationPagination obj);

		int FindCountBySrccityname(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindBySrccitycode(String srccitycode);

		IList<Vgoodssourceinformation> PaginationFindBySrccitycode(VgoodssourceinformationPagination obj);

		int FindCountBySrccitycode(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindBySrcregionname(String srcregionname);

		IList<Vgoodssourceinformation> PaginationFindBySrcregionname(VgoodssourceinformationPagination obj);

		int FindCountBySrcregionname(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByContent(String content);

		IList<Vgoodssourceinformation> PaginationFindByContent(VgoodssourceinformationPagination obj);

		int FindCountByContent(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindById(Int64 id);

		IList<Vgoodssourceinformation> PaginationFindById(VgoodssourceinformationPagination obj);

		int FindCountById(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByDstregionname(String dstregionname);

		IList<Vgoodssourceinformation> PaginationFindByDstregionname(VgoodssourceinformationPagination obj);

		int FindCountByDstregionname(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByReleasedate(DateTime releasedate);

		IList<Vgoodssourceinformation> PaginationFindByReleasedate(VgoodssourceinformationPagination obj);

		int FindCountByReleasedate(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByDstcityname(String dstcityname);

		IList<Vgoodssourceinformation> PaginationFindByDstcityname(VgoodssourceinformationPagination obj);

		int FindCountByDstcityname(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByDstcitycode(String dstcitycode);

		IList<Vgoodssourceinformation> PaginationFindByDstcitycode(VgoodssourceinformationPagination obj);

		int FindCountByDstcitycode(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByTitle(String title);

		IList<Vgoodssourceinformation> PaginationFindByTitle(VgoodssourceinformationPagination obj);

		int FindCountByTitle(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByTitlecolor(String titlecolor);

		IList<Vgoodssourceinformation> PaginationFindByTitlecolor(VgoodssourceinformationPagination obj);

		int FindCountByTitlecolor(Vgoodssourceinformation obj);

		IList<Vgoodssourceinformation> FindByUsername(String username);

		IList<Vgoodssourceinformation> PaginationFindByUsername(VgoodssourceinformationPagination obj);

		int FindCountByUsername(Vgoodssourceinformation obj);

		void Reload(Vgoodssourceinformation obj);
	}
}
