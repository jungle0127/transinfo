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

		IList<Vtrunkmetadata> DescendOrderFindAll();

		IList<Vtrunkmetadata> PaginationFindAll(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindAll(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> QuickFindAll();

		IList<Vtrunkmetadata> FindByVantypename(String vantypename);

		IList<Vtrunkmetadata> DescendOrderFindByVantypename(String vantypename);

		IList<Vtrunkmetadata> PaginationFindByVantypename(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByVantypename(VtrunkmetadataPagination obj);

		int FindCountByVantypename(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByContactpersonname(String contactpersonname);

		IList<Vtrunkmetadata> DescendOrderFindByContactpersonname(String contactpersonname);

		IList<Vtrunkmetadata> PaginationFindByContactpersonname(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByContactpersonname(VtrunkmetadataPagination obj);

		int FindCountByContactpersonname(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByTrunktypename(String trunktypename);

		IList<Vtrunkmetadata> DescendOrderFindByTrunktypename(String trunktypename);

		IList<Vtrunkmetadata> PaginationFindByTrunktypename(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByTrunktypename(VtrunkmetadataPagination obj);

		int FindCountByTrunktypename(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByConatactphone(String conatactphone);

		IList<Vtrunkmetadata> DescendOrderFindByConatactphone(String conatactphone);

		IList<Vtrunkmetadata> PaginationFindByConatactphone(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByConatactphone(VtrunkmetadataPagination obj);

		int FindCountByConatactphone(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByVolume(String volume);

		IList<Vtrunkmetadata> DescendOrderFindByVolume(String volume);

		IList<Vtrunkmetadata> PaginationFindByVolume(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByVolume(VtrunkmetadataPagination obj);

		int FindCountByVolume(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByNumber(String number);

		IList<Vtrunkmetadata> DescendOrderFindByNumber(String number);

		IList<Vtrunkmetadata> PaginationFindByNumber(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByNumber(VtrunkmetadataPagination obj);

		int FindCountByNumber(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByBrand(String brand);

		IList<Vtrunkmetadata> DescendOrderFindByBrand(String brand);

		IList<Vtrunkmetadata> PaginationFindByBrand(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByBrand(VtrunkmetadataPagination obj);

		int FindCountByBrand(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByLength(String length);

		IList<Vtrunkmetadata> DescendOrderFindByLength(String length);

		IList<Vtrunkmetadata> PaginationFindByLength(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByLength(VtrunkmetadataPagination obj);

		int FindCountByLength(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByVanimageuri(String vanimageuri);

		IList<Vtrunkmetadata> DescendOrderFindByVanimageuri(String vanimageuri);

		IList<Vtrunkmetadata> PaginationFindByVanimageuri(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByVanimageuri(VtrunkmetadataPagination obj);

		int FindCountByVanimageuri(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByCountyname(String countyname);

		IList<Vtrunkmetadata> DescendOrderFindByCountyname(String countyname);

		IList<Vtrunkmetadata> PaginationFindByCountyname(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByCountyname(VtrunkmetadataPagination obj);

		int FindCountByCountyname(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByWeightcapacity(String weightcapacity);

		IList<Vtrunkmetadata> DescendOrderFindByWeightcapacity(String weightcapacity);

		IList<Vtrunkmetadata> PaginationFindByWeightcapacity(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByWeightcapacity(VtrunkmetadataPagination obj);

		int FindCountByWeightcapacity(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindById(Int64 id);

		IList<Vtrunkmetadata> DescendOrderFindById(Int64 id);

		IList<Vtrunkmetadata> PaginationFindById(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindById(VtrunkmetadataPagination obj);

		int FindCountById(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByPrefixname(String prefixname);

		IList<Vtrunkmetadata> DescendOrderFindByPrefixname(String prefixname);

		IList<Vtrunkmetadata> PaginationFindByPrefixname(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByPrefixname(VtrunkmetadataPagination obj);

		int FindCountByPrefixname(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByLicenseuri(String licenseuri);

		IList<Vtrunkmetadata> DescendOrderFindByLicenseuri(String licenseuri);

		IList<Vtrunkmetadata> PaginationFindByLicenseuri(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByLicenseuri(VtrunkmetadataPagination obj);

		int FindCountByLicenseuri(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByTrunkidentifynumber(String trunkidentifynumber);

		IList<Vtrunkmetadata> DescendOrderFindByTrunkidentifynumber(String trunkidentifynumber);

		IList<Vtrunkmetadata> PaginationFindByTrunkidentifynumber(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByTrunkidentifynumber(VtrunkmetadataPagination obj);

		int FindCountByTrunkidentifynumber(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByCountycode(String countycode);

		IList<Vtrunkmetadata> DescendOrderFindByCountycode(String countycode);

		IList<Vtrunkmetadata> PaginationFindByCountycode(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByCountycode(VtrunkmetadataPagination obj);

		int FindCountByCountycode(Vtrunkmetadata obj);

		IList<Vtrunkmetadata> FindByLocation(String location);

		IList<Vtrunkmetadata> DescendOrderFindByLocation(String location);

		IList<Vtrunkmetadata> PaginationFindByLocation(VtrunkmetadataPagination obj);

		IList<Vtrunkmetadata> DescendOrderPaginationFindByLocation(VtrunkmetadataPagination obj);

		int FindCountByLocation(Vtrunkmetadata obj);

		void Reload(Vtrunkmetadata obj);
	}
}
