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

		IList<Vdepotinformation> FindByDescription(String description);

		IList<Vdepotinformation> PaginationFindByDescription(VdepotinformationPagination obj);

		IList<Vdepotinformation> FindByValidtime(String validtime);

		IList<Vdepotinformation> PaginationFindByValidtime(VdepotinformationPagination obj);

		IList<Vdepotinformation> FindByCityname(String cityname);

		IList<Vdepotinformation> PaginationFindByCityname(VdepotinformationPagination obj);

		IList<Vdepotinformation> FindByUseablearea(Int32 useablearea);

		IList<Vdepotinformation> PaginationFindByUseablearea(VdepotinformationPagination obj);

		IList<Vdepotinformation> FindByScopename(String scopename);

		IList<Vdepotinformation> PaginationFindByScopename(VdepotinformationPagination obj);

		IList<Vdepotinformation> FindByPrice(String price);

		IList<Vdepotinformation> PaginationFindByPrice(VdepotinformationPagination obj);

		IList<Vdepotinformation> FindByContactperson(String contactperson);

		IList<Vdepotinformation> PaginationFindByContactperson(VdepotinformationPagination obj);

		IList<Vdepotinformation> FindByTitle(String title);

		IList<Vdepotinformation> PaginationFindByTitle(VdepotinformationPagination obj);

		IList<Vdepotinformation> FindByRegionname(String regionname);

		IList<Vdepotinformation> PaginationFindByRegionname(VdepotinformationPagination obj);

		IList<Vdepotinformation> FindById(Int64 id);

		IList<Vdepotinformation> PaginationFindById(VdepotinformationPagination obj);

		IList<Vdepotinformation> FindByDepottypename(String depottypename);

		IList<Vdepotinformation> PaginationFindByDepottypename(VdepotinformationPagination obj);

		IList<Vdepotinformation> FindByAddress(String address);

		IList<Vdepotinformation> PaginationFindByAddress(VdepotinformationPagination obj);

		IList<Vdepotinformation> FindByCitycode(String citycode);

		IList<Vdepotinformation> PaginationFindByCitycode(VdepotinformationPagination obj);

		IList<Vdepotinformation> FindByArea(Int32 area);

		IList<Vdepotinformation> PaginationFindByArea(VdepotinformationPagination obj);

		IList<Vdepotinformation> FindByUsername(String username);

		IList<Vdepotinformation> PaginationFindByUsername(VdepotinformationPagination obj);

		void Reload(Vdepotinformation obj);
	}
}
