using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IVprovincecitycountyDao
    {
		int GetCount();

		IList<Vprovincecitycounty> FindAll();

		IList<Vprovincecitycounty> DescendOrderFindAll();

		IList<Vprovincecitycounty> PaginationFindAll(VprovincecitycountyPagination obj);

		IList<Vprovincecitycounty> DescendOrderPaginationFindAll(VprovincecitycountyPagination obj);

		IList<Vprovincecitycounty> QuickFindAll();

		IList<Vprovincecitycounty> FindByFullname(String fullname);

		IList<Vprovincecitycounty> DescendOrderFindByFullname(String fullname);

		IList<Vprovincecitycounty> PaginationFindByFullname(VprovincecitycountyPagination obj);

		IList<Vprovincecitycounty> DescendOrderPaginationFindByFullname(VprovincecitycountyPagination obj);

		int FindCountByFullname(Vprovincecitycounty obj);

		IList<Vprovincecitycounty> FindByCityname(String cityname);

		IList<Vprovincecitycounty> DescendOrderFindByCityname(String cityname);

		IList<Vprovincecitycounty> PaginationFindByCityname(VprovincecitycountyPagination obj);

		IList<Vprovincecitycounty> DescendOrderPaginationFindByCityname(VprovincecitycountyPagination obj);

		int FindCountByCityname(Vprovincecitycounty obj);

		IList<Vprovincecitycounty> FindByProvincecode(String provincecode);

		IList<Vprovincecitycounty> DescendOrderFindByProvincecode(String provincecode);

		IList<Vprovincecitycounty> PaginationFindByProvincecode(VprovincecitycountyPagination obj);

		IList<Vprovincecitycounty> DescendOrderPaginationFindByProvincecode(VprovincecitycountyPagination obj);

		int FindCountByProvincecode(Vprovincecitycounty obj);

		IList<Vprovincecitycounty> FindByCitycode(String citycode);

		IList<Vprovincecitycounty> DescendOrderFindByCitycode(String citycode);

		IList<Vprovincecitycounty> PaginationFindByCitycode(VprovincecitycountyPagination obj);

		IList<Vprovincecitycounty> DescendOrderPaginationFindByCitycode(VprovincecitycountyPagination obj);

		int FindCountByCitycode(Vprovincecitycounty obj);

		IList<Vprovincecitycounty> FindByCountyname(String countyname);

		IList<Vprovincecitycounty> DescendOrderFindByCountyname(String countyname);

		IList<Vprovincecitycounty> PaginationFindByCountyname(VprovincecitycountyPagination obj);

		IList<Vprovincecitycounty> DescendOrderPaginationFindByCountyname(VprovincecitycountyPagination obj);

		int FindCountByCountyname(Vprovincecitycounty obj);

		IList<Vprovincecitycounty> FindByProvincename(String provincename);

		IList<Vprovincecitycounty> DescendOrderFindByProvincename(String provincename);

		IList<Vprovincecitycounty> PaginationFindByProvincename(VprovincecitycountyPagination obj);

		IList<Vprovincecitycounty> DescendOrderPaginationFindByProvincename(VprovincecitycountyPagination obj);

		int FindCountByProvincename(Vprovincecitycounty obj);

		IList<Vprovincecitycounty> FindByCountycode(String countycode);

		IList<Vprovincecitycounty> DescendOrderFindByCountycode(String countycode);

		IList<Vprovincecitycounty> PaginationFindByCountycode(VprovincecitycountyPagination obj);

		IList<Vprovincecitycounty> DescendOrderPaginationFindByCountycode(VprovincecitycountyPagination obj);

		int FindCountByCountycode(Vprovincecitycounty obj);

		void Reload(Vprovincecitycounty obj);
	}
}
