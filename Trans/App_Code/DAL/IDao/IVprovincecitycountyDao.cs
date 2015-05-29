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

		IList<Vprovincecitycounty> FindByCityname(String cityname);

		IList<Vprovincecitycounty> PaginationFindByCityname(VprovincecitycountyPagination obj);

		IList<Vprovincecitycounty> FindByProvincecode(String provincecode);

		IList<Vprovincecitycounty> PaginationFindByProvincecode(VprovincecitycountyPagination obj);

		IList<Vprovincecitycounty> FindByCitycode(String citycode);

		IList<Vprovincecitycounty> PaginationFindByCitycode(VprovincecitycountyPagination obj);

		IList<Vprovincecitycounty> FindByCountyname(String countyname);

		IList<Vprovincecitycounty> PaginationFindByCountyname(VprovincecitycountyPagination obj);

		IList<Vprovincecitycounty> FindByProvincename(String provincename);

		IList<Vprovincecitycounty> PaginationFindByProvincename(VprovincecitycountyPagination obj);

		IList<Vprovincecitycounty> FindByCountycode(String countycode);

		IList<Vprovincecitycounty> PaginationFindByCountycode(VprovincecitycountyPagination obj);

		void Reload(Vprovincecitycounty obj);
	}
}
