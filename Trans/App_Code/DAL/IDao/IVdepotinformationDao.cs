using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IVdepotinformationDao
    {
		int GetCount();

        IList<Vdepotinformation> DynamicQuery(VdepotinformationPagination obj);

        int DynamicCount(VdepotinformationPagination obj);

		IList<Vdepotinformation> FindAll();

		IList<Vdepotinformation> DescendOrderFindAll();

		IList<Vdepotinformation> PaginationFindAll(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindAll(VdepotinformationPagination obj);

		IList<Vdepotinformation> QuickFindAll();

		IList<Vdepotinformation> FindByScopeid(Int64 scopeid);

		IList<Vdepotinformation> DescendOrderFindByScopeid(Int64 scopeid);

		IList<Vdepotinformation> PaginationFindByScopeid(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByScopeid(VdepotinformationPagination obj);

		int FindCountByScopeid(Vdepotinformation obj);

		IList<Vdepotinformation> FindByDescription(String description);

		IList<Vdepotinformation> DescendOrderFindByDescription(String description);

		IList<Vdepotinformation> PaginationFindByDescription(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByDescription(VdepotinformationPagination obj);

		int FindCountByDescription(Vdepotinformation obj);

		IList<Vdepotinformation> FindByValidtime(String validtime);

		IList<Vdepotinformation> DescendOrderFindByValidtime(String validtime);

		IList<Vdepotinformation> PaginationFindByValidtime(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByValidtime(VdepotinformationPagination obj);

		int FindCountByValidtime(Vdepotinformation obj);

		IList<Vdepotinformation> FindByCityname(String cityname);

		IList<Vdepotinformation> DescendOrderFindByCityname(String cityname);

		IList<Vdepotinformation> PaginationFindByCityname(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByCityname(VdepotinformationPagination obj);

		int FindCountByCityname(Vdepotinformation obj);

		IList<Vdepotinformation> FindByUseablearea(Int32 useablearea);

		IList<Vdepotinformation> DescendOrderFindByUseablearea(Int32 useablearea);

		IList<Vdepotinformation> PaginationFindByUseablearea(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByUseablearea(VdepotinformationPagination obj);

		int FindCountByUseablearea(Vdepotinformation obj);

		IList<Vdepotinformation> FindByDepottypeid(Int64 depottypeid);

		IList<Vdepotinformation> DescendOrderFindByDepottypeid(Int64 depottypeid);

		IList<Vdepotinformation> PaginationFindByDepottypeid(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByDepottypeid(VdepotinformationPagination obj);

		int FindCountByDepottypeid(Vdepotinformation obj);

		IList<Vdepotinformation> FindByScopename(String scopename);

		IList<Vdepotinformation> DescendOrderFindByScopename(String scopename);

		IList<Vdepotinformation> PaginationFindByScopename(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByScopename(VdepotinformationPagination obj);

		int FindCountByScopename(Vdepotinformation obj);

		IList<Vdepotinformation> FindByPrice(String price);

		IList<Vdepotinformation> DescendOrderFindByPrice(String price);

		IList<Vdepotinformation> PaginationFindByPrice(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByPrice(VdepotinformationPagination obj);

		int FindCountByPrice(Vdepotinformation obj);

		IList<Vdepotinformation> FindByContactperson(String contactperson);

		IList<Vdepotinformation> DescendOrderFindByContactperson(String contactperson);

		IList<Vdepotinformation> PaginationFindByContactperson(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByContactperson(VdepotinformationPagination obj);

		int FindCountByContactperson(Vdepotinformation obj);

		IList<Vdepotinformation> FindByTitle(String title);

		IList<Vdepotinformation> DescendOrderFindByTitle(String title);

		IList<Vdepotinformation> PaginationFindByTitle(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByTitle(VdepotinformationPagination obj);

		int FindCountByTitle(Vdepotinformation obj);

		IList<Vdepotinformation> FindByRegionname(String regionname);

		IList<Vdepotinformation> DescendOrderFindByRegionname(String regionname);

		IList<Vdepotinformation> PaginationFindByRegionname(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByRegionname(VdepotinformationPagination obj);

		int FindCountByRegionname(Vdepotinformation obj);

		IList<Vdepotinformation> FindById(Int64 id);

		IList<Vdepotinformation> DescendOrderFindById(Int64 id);

		IList<Vdepotinformation> PaginationFindById(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindById(VdepotinformationPagination obj);

		int FindCountById(Vdepotinformation obj);

		IList<Vdepotinformation> FindByDepottypename(String depottypename);

		IList<Vdepotinformation> DescendOrderFindByDepottypename(String depottypename);

		IList<Vdepotinformation> PaginationFindByDepottypename(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByDepottypename(VdepotinformationPagination obj);

		int FindCountByDepottypename(Vdepotinformation obj);

		IList<Vdepotinformation> FindByCellphone(String cellphone);

		IList<Vdepotinformation> DescendOrderFindByCellphone(String cellphone);

		IList<Vdepotinformation> PaginationFindByCellphone(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByCellphone(VdepotinformationPagination obj);

		int FindCountByCellphone(Vdepotinformation obj);

		IList<Vdepotinformation> FindByAddress(String address);

		IList<Vdepotinformation> DescendOrderFindByAddress(String address);

		IList<Vdepotinformation> PaginationFindByAddress(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByAddress(VdepotinformationPagination obj);

		int FindCountByAddress(Vdepotinformation obj);

		IList<Vdepotinformation> FindByCitycode(String citycode);

		IList<Vdepotinformation> DescendOrderFindByCitycode(String citycode);

		IList<Vdepotinformation> PaginationFindByCitycode(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByCitycode(VdepotinformationPagination obj);

		int FindCountByCitycode(Vdepotinformation obj);

		IList<Vdepotinformation> FindByArea(Int32 area);

		IList<Vdepotinformation> DescendOrderFindByArea(Int32 area);

		IList<Vdepotinformation> PaginationFindByArea(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByArea(VdepotinformationPagination obj);

		int FindCountByArea(Vdepotinformation obj);

		IList<Vdepotinformation> FindByUsername(String username);

		IList<Vdepotinformation> DescendOrderFindByUsername(String username);

		IList<Vdepotinformation> PaginationFindByUsername(VdepotinformationPagination obj);

		IList<Vdepotinformation> DescendOrderPaginationFindByUsername(VdepotinformationPagination obj);

		int FindCountByUsername(Vdepotinformation obj);

		void Reload(Vdepotinformation obj);
	}
}
