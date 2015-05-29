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

		IList<Vgoodssourceinformation> FindByNeedtrunkvolume(Int64 needtrunkvolume);

		IList<Vgoodssourceinformation> PaginationFindByNeedtrunkvolume(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> FindByDeadline(DateTime deadline);

		IList<Vgoodssourceinformation> PaginationFindByDeadline(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> FindByNeedtrunkweight(Int64 needtrunkweight);

		IList<Vgoodssourceinformation> PaginationFindByNeedtrunkweight(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> FindByReleasedate(DateTime releasedate);

		IList<Vgoodssourceinformation> PaginationFindByReleasedate(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> FindByCautiontypename(String cautiontypename);

		IList<Vgoodssourceinformation> PaginationFindByCautiontypename(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> FindByNeedtrunklength(Int64 needtrunklength);

		IList<Vgoodssourceinformation> PaginationFindByNeedtrunklength(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> FindByPrice(String price);

		IList<Vgoodssourceinformation> PaginationFindByPrice(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> FindByGoodsname(String goodsname);

		IList<Vgoodssourceinformation> PaginationFindByGoodsname(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> FindByTransporttypename(String transporttypename);

		IList<Vgoodssourceinformation> PaginationFindByTransporttypename(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> FindByTitle(String title);

		IList<Vgoodssourceinformation> PaginationFindByTitle(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> FindBySrcregionname(String srcregionname);

		IList<Vgoodssourceinformation> PaginationFindBySrcregionname(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> FindByContent(String content);

		IList<Vgoodssourceinformation> PaginationFindByContent(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> FindById(Int64 id);

		IList<Vgoodssourceinformation> PaginationFindById(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> FindByDstregionname(String dstregionname);

		IList<Vgoodssourceinformation> PaginationFindByDstregionname(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> FindByTitlecolor(String titlecolor);

		IList<Vgoodssourceinformation> PaginationFindByTitlecolor(VgoodssourceinformationPagination obj);

		IList<Vgoodssourceinformation> FindByUsername(String username);

		IList<Vgoodssourceinformation> PaginationFindByUsername(VgoodssourceinformationPagination obj);

		void Reload(Vgoodssourceinformation obj);
	}
}
