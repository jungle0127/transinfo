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

		IList<Vprovincecitycounty> PaginationFindAll(VprovincecitycountyPagination obj);

		IList<Vprovincecitycounty> QuickFindAll();

		IList<Vprovincecitycounty> FindByFullname(String fullname);

		IList<Vprovincecitycounty> PaginationFindByFullname(VprovincecitycountyPagination obj);

		int FindCountByFullname(Vprovincecitycounty obj);

		IList<Vprovincecitycounty> FindByCityname(String cityname);

		IList<Vprovincecitycounty> PaginationFindByCityname(VprovincecitycountyPagination obj);

		int FindCountByCityname(Vprovincecitycounty obj);

		IList<Vprovincecitycounty> FindByProvincecode(String provincecode);

		IList<Vprovincecitycounty> PaginationFindByProvincecode(VprovincecitycountyPagination obj);

		int FindCountByProvincecode(Vprovincecitycounty obj);

		IList<Vprovincecitycounty> FindByCitycode(String citycode);

		IList<Vprovincecitycounty> PaginationFindByCitycode(VprovincecitycountyPagination obj);

		int FindCountByCitycode(Vprovincecitycounty obj);

		IList<Vprovincecitycounty> FindByCountyname(String countyname);

		IList<Vprovincecitycounty> PaginationFindByCountyname(VprovincecitycountyPagination obj);

		int FindCountByCountyname(Vprovincecitycounty obj);

		IList<Vprovincecitycounty> FindByProvincename(String provincename);

		IList<Vprovincecitycounty> PaginationFindByProvincename(VprovincecitycountyPagination obj);

		int FindCountByProvincename(Vprovincecitycounty obj);

		IList<Vprovincecitycounty> FindByCountycode(String countycode);

		IList<Vprovincecitycounty> PaginationFindByCountycode(VprovincecitycountyPagination obj);

		int FindCountByCountycode(Vprovincecitycounty obj);

		void Reload(Vprovincecitycounty obj);
	}
}
