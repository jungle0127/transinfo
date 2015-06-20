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

		int FindCountByVantypename(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByContactpersonname(String contactpersonname);

		IList<Vtrunkmetadata> PaginationFindByContactpersonname(VtrunkmetadataPagination obj);

		int FindCountByContactpersonname(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByTrunktypename(String trunktypename);

		IList<Vtrunkmetadata> PaginationFindByTrunktypename(VtrunkmetadataPagination obj);

		int FindCountByTrunktypename(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByConatactphone(String conatactphone);

		IList<Vtrunkmetadata> PaginationFindByConatactphone(VtrunkmetadataPagination obj);

		int FindCountByConatactphone(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByVolume(String volume);

		IList<Vtrunkmetadata> PaginationFindByVolume(VtrunkmetadataPagination obj);

		int FindCountByVolume(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByNumber(String number);

		IList<Vtrunkmetadata> PaginationFindByNumber(VtrunkmetadataPagination obj);

		int FindCountByNumber(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByBrand(String brand);

		IList<Vtrunkmetadata> PaginationFindByBrand(VtrunkmetadataPagination obj);

		int FindCountByBrand(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByLength(String length);

		IList<Vtrunkmetadata> PaginationFindByLength(VtrunkmetadataPagination obj);

		int FindCountByLength(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByVanimageuri(String vanimageuri);

		IList<Vtrunkmetadata> PaginationFindByVanimageuri(VtrunkmetadataPagination obj);

		int FindCountByVanimageuri(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByCountyname(String countyname);

		IList<Vtrunkmetadata> PaginationFindByCountyname(VtrunkmetadataPagination obj);

		int FindCountByCountyname(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByWeightcapacity(String weightcapacity);

		IList<Vtrunkmetadata> PaginationFindByWeightcapacity(VtrunkmetadataPagination obj);

		int FindCountByWeightcapacity(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindById(Int64 id);

		IList<Vtrunkmetadata> PaginationFindById(VtrunkmetadataPagination obj);

		int FindCountById(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByPrefixname(String prefixname);

		IList<Vtrunkmetadata> PaginationFindByPrefixname(VtrunkmetadataPagination obj);

		int FindCountByPrefixname(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByLicenseuri(String licenseuri);

		IList<Vtrunkmetadata> PaginationFindByLicenseuri(VtrunkmetadataPagination obj);

		int FindCountByLicenseuri(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByTrunkidentifynumber(String trunkidentifynumber);

		IList<Vtrunkmetadata> PaginationFindByTrunkidentifynumber(VtrunkmetadataPagination obj);

		int FindCountByTrunkidentifynumber(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByCountycode(String countycode);

		IList<Vtrunkmetadata> PaginationFindByCountycode(VtrunkmetadataPagination obj);

		int FindCountByCountycode(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByLocation(String location);

		IList<Vtrunkmetadata> PaginationFindByLocation(VtrunkmetadataPagination obj);

		int FindCountByLocation(Vtrunkmetadata obj);

		void Reload(Vtrunkmetadata obj);
	}
}
