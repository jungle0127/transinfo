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

		int GetFindCount(Int64 id);

		IList<Depotinformation> FindAll();

		IList<Depotinformation> DescendOrderFindAll();

		IList<Depotinformation> PaginationFindAll(DepotinformationPagination obj);

		IList<Depotinformation> DescendOrderPaginationFindAll(DepotinformationPagination obj);

		IList<Depotinformation> QuickFindAll();

		IList<Depotinformation> FindByCellphone(String cellphone);

		IList<Depotinformation> DescendOrderFindByCellphone(String cellphone);

		IList<Depotinformation> PaginationFindByCellphone(DepotinformationPagination obj);

		IList<Depotinformation> DescendOrderPaginationFindByCellphone(DepotinformationPagination obj);

		int FindCountByCellphone(Depotinformation obj);

		IList<Depotinformation> FindByDescription(String description);

		IList<Depotinformation> DescendOrderFindByDescription(String description);

		IList<Depotinformation> PaginationFindByDescription(DepotinformationPagination obj);

		IList<Depotinformation> DescendOrderPaginationFindByDescription(DepotinformationPagination obj);

		int FindCountByDescription(Depotinformation obj);

		IList<Depotinformation> FindByValidtime(String validtime);

		IList<Depotinformation> DescendOrderFindByValidtime(String validtime);

		IList<Depotinformation> PaginationFindByValidtime(DepotinformationPagination obj);

		IList<Depotinformation> DescendOrderPaginationFindByValidtime(DepotinformationPagination obj);

		int FindCountByValidtime(Depotinformation obj);

		IList<Depotinformation> FindByContactperson(String contactperson);

		IList<Depotinformation> DescendOrderFindByContactperson(String contactperson);

		IList<Depotinformation> PaginationFindByContactperson(DepotinformationPagination obj);

		IList<Depotinformation> DescendOrderPaginationFindByContactperson(DepotinformationPagination obj);

		int FindCountByContactperson(Depotinformation obj);

		IList<Depotinformation> FindByUserid(Int64 userid);

		IList<Depotinformation> DescendOrderFindByUserid(Int64 userid);

		IList<Depotinformation> PaginationFindByUserid(DepotinformationPagination obj);

		IList<Depotinformation> DescendOrderPaginationFindByUserid(DepotinformationPagination obj);

		int FindCountByUserid(Depotinformation obj);

		IList<Depotinformation> FindByUseablearea(Int32 useablearea);

		IList<Depotinformation> DescendOrderFindByUseablearea(Int32 useablearea);

		IList<Depotinformation> PaginationFindByUseablearea(DepotinformationPagination obj);

		IList<Depotinformation> DescendOrderPaginationFindByUseablearea(DepotinformationPagination obj);

		int FindCountByUseablearea(Depotinformation obj);

		IList<Depotinformation> FindByPrice(String price);

		IList<Depotinformation> DescendOrderFindByPrice(String price);

		IList<Depotinformation> PaginationFindByPrice(DepotinformationPagination obj);

		IList<Depotinformation> DescendOrderPaginationFindByPrice(DepotinformationPagination obj);

		int FindCountByPrice(Depotinformation obj);

		IList<Depotinformation> FindByBizscopetype(Int64 bizscopetype);

		IList<Depotinformation> DescendOrderFindByBizscopetype(Int64 bizscopetype);

		IList<Depotinformation> PaginationFindByBizscopetype(DepotinformationPagination obj);

		IList<Depotinformation> DescendOrderPaginationFindByBizscopetype(DepotinformationPagination obj);

		int FindCountByBizscopetype(Depotinformation obj);

		IList<Depotinformation> FindByDepottype(Int64 depottype);

		IList<Depotinformation> DescendOrderFindByDepottype(Int64 depottype);

		IList<Depotinformation> PaginationFindByDepottype(DepotinformationPagination obj);

		IList<Depotinformation> DescendOrderPaginationFindByDepottype(DepotinformationPagination obj);

		int FindCountByDepottype(Depotinformation obj);

		IList<Depotinformation> FindByTitle(String title);

		IList<Depotinformation> DescendOrderFindByTitle(String title);

		IList<Depotinformation> PaginationFindByTitle(DepotinformationPagination obj);

		IList<Depotinformation> DescendOrderPaginationFindByTitle(DepotinformationPagination obj);

		int FindCountByTitle(Depotinformation obj);

		IList<Depotinformation> FindByAddress(String address);

		IList<Depotinformation> DescendOrderFindByAddress(String address);

		IList<Depotinformation> PaginationFindByAddress(DepotinformationPagination obj);

		IList<Depotinformation> DescendOrderPaginationFindByAddress(DepotinformationPagination obj);

		int FindCountByAddress(Depotinformation obj);

		IList<Depotinformation> FindByArea(Int32 area);

		IList<Depotinformation> DescendOrderFindByArea(Int32 area);

		IList<Depotinformation> PaginationFindByArea(DepotinformationPagination obj);

		IList<Depotinformation> DescendOrderPaginationFindByArea(DepotinformationPagination obj);

		int FindCountByArea(Depotinformation obj);

		IList<Depotinformation> FindByCountycode(String countycode);

		IList<Depotinformation> DescendOrderFindByCountycode(String countycode);

		IList<Depotinformation> PaginationFindByCountycode(DepotinformationPagination obj);

		IList<Depotinformation> DescendOrderPaginationFindByCountycode(DepotinformationPagination obj);

		int FindCountByCountycode(Depotinformation obj);

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
