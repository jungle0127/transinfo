using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IVdepotinformationDao
    {
		int GetCount();

		IList<Vdepotinformation> FindAll();

		IList<Vdepotinformation> PaginationFindAll(VdepotinformationPagination obj);

		IList<Vdepotinformation> QuickFindAll();

		IList<Vdepotinformation> FindByCellphone(String cellphone);

		IList<Vdepotinformation> PaginationFindByCellphone(VdepotinformationPagination obj);

		int FindCountByCellphone(Vdepotinformation obj);

		IList<Vdepotinformation> FindByDescription(String description);

		IList<Vdepotinformation> PaginationFindByDescription(VdepotinformationPagination obj);

		int FindCountByDescription(Vdepotinformation obj);

		IList<Vdepotinformation> FindByValidtime(String validtime);

		IList<Vdepotinformation> PaginationFindByValidtime(VdepotinformationPagination obj);

		int FindCountByValidtime(Vdepotinformation obj);

		IList<Vdepotinformation> FindByCityname(String cityname);

		IList<Vdepotinformation> PaginationFindByCityname(VdepotinformationPagination obj);

		int FindCountByCityname(Vdepotinformation obj);

		IList<Vdepotinformation> FindByUseablearea(Int32 useablearea);

		IList<Vdepotinformation> PaginationFindByUseablearea(VdepotinformationPagination obj);

		int FindCountByUseablearea(Vdepotinformation obj);

		IList<Vdepotinformation> FindByScopename(String scopename);

		IList<Vdepotinformation> PaginationFindByScopename(VdepotinformationPagination obj);

		int FindCountByScopename(Vdepotinformation obj);

		IList<Vdepotinformation> FindByPrice(String price);

		IList<Vdepotinformation> PaginationFindByPrice(VdepotinformationPagination obj);

		int FindCountByPrice(Vdepotinformation obj);

		IList<Vdepotinformation> FindByContactperson(String contactperson);

		IList<Vdepotinformation> PaginationFindByContactperson(VdepotinformationPagination obj);

		int FindCountByContactperson(Vdepotinformation obj);

		IList<Vdepotinformation> FindByTitle(String title);

		IList<Vdepotinformation> PaginationFindByTitle(VdepotinformationPagination obj);

		int FindCountByTitle(Vdepotinformation obj);

		IList<Vdepotinformation> FindByRegionname(String regionname);

		IList<Vdepotinformation> PaginationFindByRegionname(VdepotinformationPagination obj);

		int FindCountByRegionname(Vdepotinformation obj);

		IList<Vdepotinformation> FindById(Int64 id);

		IList<Vdepotinformation> PaginationFindById(VdepotinformationPagination obj);

		int FindCountById(Vdepotinformation obj);

		IList<Vdepotinformation> FindByDepottypename(String depottypename);

		IList<Vdepotinformation> PaginationFindByDepottypename(VdepotinformationPagination obj);

		int FindCountByDepottypename(Vdepotinformation obj);

		IList<Vdepotinformation> FindByAddress(String address);

		IList<Vdepotinformation> PaginationFindByAddress(VdepotinformationPagination obj);

		int FindCountByAddress(Vdepotinformation obj);

		IList<Vdepotinformation> FindByCitycode(String citycode);

		IList<Vdepotinformation> PaginationFindByCitycode(VdepotinformationPagination obj);

		int FindCountByCitycode(Vdepotinformation obj);

		IList<Vdepotinformation> FindByArea(Int32 area);

		IList<Vdepotinformation> PaginationFindByArea(VdepotinformationPagination obj);

		int FindCountByArea(Vdepotinformation obj);

		IList<Vdepotinformation> FindByUsername(String username);

		IList<Vdepotinformation> PaginationFindByUsername(VdepotinformationPagination obj);

		int FindCountByUsername(Vdepotinformation obj);

		void Reload(Vdepotinformation obj);
	}
}
