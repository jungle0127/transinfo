using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IVtrunkmetadataDao
    {
		int GetCount();

		IList<Vtrunkmetadata> FindAll();

		IList<Vtrunkmetadata> PaginationFindAll(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> QuickFindAll();

		IList<Vtrunkmetadata> FindByVantypename(String vantypename);

		IList<Vtrunkmetadata> PaginationFindByVantypename(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindByContactpersonname(String contactpersonname);

		IList<Vtrunkmetadata> PaginationFindByContactpersonname(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindByTrunktypename(String trunktypename);

		IList<Vtrunkmetadata> PaginationFindByTrunktypename(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindByConatactphone(String conatactphone);

		IList<Vtrunkmetadata> PaginationFindByConatactphone(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindByVolume(String volume);

		IList<Vtrunkmetadata> PaginationFindByVolume(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindByNumber(String number);

		IList<Vtrunkmetadata> PaginationFindByNumber(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindByBrand(String brand);

		IList<Vtrunkmetadata> PaginationFindByBrand(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindByLength(String length);

		IList<Vtrunkmetadata> PaginationFindByLength(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindByVanimageuri(String vanimageuri);

		IList<Vtrunkmetadata> PaginationFindByVanimageuri(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindByCountyname(String countyname);

		IList<Vtrunkmetadata> PaginationFindByCountyname(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindByWeightcapacity(String weightcapacity);

		IList<Vtrunkmetadata> PaginationFindByWeightcapacity(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindById(Int64 id);

		IList<Vtrunkmetadata> PaginationFindById(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindByPrefixname(String prefixname);

		IList<Vtrunkmetadata> PaginationFindByPrefixname(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindByLicenseuri(String licenseuri);

		IList<Vtrunkmetadata> PaginationFindByLicenseuri(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindByTrunkidentifynumber(String trunkidentifynumber);

		IList<Vtrunkmetadata> PaginationFindByTrunkidentifynumber(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindByCountycode(String countycode);

		IList<Vtrunkmetadata> PaginationFindByCountycode(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> FindByLocation(String location);

		IList<Vtrunkmetadata> PaginationFindByLocation(VtrunkmetadataPagination obj);

		void Reload(Vtrunkmetadata obj);
	}
}
