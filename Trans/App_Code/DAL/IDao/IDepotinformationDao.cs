using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IDepotinformationDao
    {
		int GetCount();

		Depotinformation Find(Int64 id);

		IList<Depotinformation> FindAll();

		IList<Depotinformation> PaginationFindAll(DepotinformationPagination obj);

		IList<Depotinformation> QuickFindAll();

		IList<Depotinformation> FindByCellphone(String cellphone);

		IList<Depotinformation> PaginationFindByCellphone(DepotinformationPagination obj);

		IList<Depotinformation> FindByDescription(String description);

		IList<Depotinformation> PaginationFindByDescription(DepotinformationPagination obj);

		IList<Depotinformation> FindByValidtime(String validtime);

		IList<Depotinformation> PaginationFindByValidtime(DepotinformationPagination obj);

		IList<Depotinformation> FindByContactperson(String contactperson);

		IList<Depotinformation> PaginationFindByContactperson(DepotinformationPagination obj);

		IList<Depotinformation> FindByUserid(Int64 userid);

		IList<Depotinformation> PaginationFindByUserid(DepotinformationPagination obj);

		IList<Depotinformation> FindByUseablearea(Int32 useablearea);

		IList<Depotinformation> PaginationFindByUseablearea(DepotinformationPagination obj);

		IList<Depotinformation> FindByPrice(String price);

		IList<Depotinformation> PaginationFindByPrice(DepotinformationPagination obj);

		IList<Depotinformation> FindByBizscopetype(Int64 bizscopetype);

		IList<Depotinformation> PaginationFindByBizscopetype(DepotinformationPagination obj);

		IList<Depotinformation> FindByDepottype(Int64 depottype);

		IList<Depotinformation> PaginationFindByDepottype(DepotinformationPagination obj);

		IList<Depotinformation> FindByTitle(String title);

		IList<Depotinformation> PaginationFindByTitle(DepotinformationPagination obj);

		IList<Depotinformation> FindByAddress(String address);

		IList<Depotinformation> PaginationFindByAddress(DepotinformationPagination obj);

		IList<Depotinformation> FindByArea(Int32 area);

		IList<Depotinformation> PaginationFindByArea(DepotinformationPagination obj);

		IList<Depotinformation> FindByCountycode(String countycode);

		IList<Depotinformation> PaginationFindByCountycode(DepotinformationPagination obj);

		void Insert(Depotinformation obj);

		void Update(Depotinformation obj);

		void Delete(Depotinformation obj);

		int DeleteByCellphone(String cellphone);

		int DeleteByDescription(String description);

		int DeleteByValidtime(String validtime);

		int DeleteByContactperson(String contactperson);

		int DeleteByUserid(Int64 userid);

		int DeleteByUseablearea(Int32 useablearea);

		int DeleteByPrice(String price);

		int DeleteByBizscopetype(Int64 bizscopetype);

		int DeleteByDepottype(Int64 depottype);

		int DeleteByTitle(String title);

		int DeleteByAddress(String address);

		int DeleteByArea(Int32 area);

		int DeleteByCountycode(String countycode);

		void Reload(Depotinformation obj);
	}
}
