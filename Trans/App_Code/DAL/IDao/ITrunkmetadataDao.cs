using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ITrunkmetadataDao
    {
		int GetCount();

		Trunkmetadata Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Trunkmetadata> FindAll();

		IList<Trunkmetadata> DescendOrderFindAll();

		IList<Trunkmetadata> PaginationFindAll(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindAll(TrunkmetadataPagination obj);

		IList<Trunkmetadata> QuickFindAll();

		IList<Trunkmetadata> FindByConatactphone(String conatactphone);

		IList<Trunkmetadata> DescendOrderFindByConatactphone(String conatactphone);

		IList<Trunkmetadata> PaginationFindByConatactphone(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindByConatactphone(TrunkmetadataPagination obj);

		int FindCountByConatactphone(Trunkmetadata obj);

		IList<Trunkmetadata> FindByVolume(String volume);

		IList<Trunkmetadata> DescendOrderFindByVolume(String volume);

		IList<Trunkmetadata> PaginationFindByVolume(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindByVolume(TrunkmetadataPagination obj);

		int FindCountByVolume(Trunkmetadata obj);

		IList<Trunkmetadata> FindByNumberid(Int64 numberid);

		IList<Trunkmetadata> DescendOrderFindByNumberid(Int64 numberid);

		IList<Trunkmetadata> PaginationFindByNumberid(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindByNumberid(TrunkmetadataPagination obj);

		int FindCountByNumberid(Trunkmetadata obj);

		IList<Trunkmetadata> FindByBrand(String brand);

		IList<Trunkmetadata> DescendOrderFindByBrand(String brand);

		IList<Trunkmetadata> PaginationFindByBrand(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindByBrand(TrunkmetadataPagination obj);

		int FindCountByBrand(Trunkmetadata obj);

		IList<Trunkmetadata> FindByLength(String length);

		IList<Trunkmetadata> DescendOrderFindByLength(String length);

		IList<Trunkmetadata> PaginationFindByLength(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindByLength(TrunkmetadataPagination obj);

		int FindCountByLength(Trunkmetadata obj);

		IList<Trunkmetadata> FindByTrunktypeid(Int64 trunktypeid);

		IList<Trunkmetadata> DescendOrderFindByTrunktypeid(Int64 trunktypeid);

		IList<Trunkmetadata> PaginationFindByTrunktypeid(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindByTrunktypeid(TrunkmetadataPagination obj);

		int FindCountByTrunktypeid(Trunkmetadata obj);

		IList<Trunkmetadata> FindByContactpersonname(String contactpersonname);

		IList<Trunkmetadata> DescendOrderFindByContactpersonname(String contactpersonname);

		IList<Trunkmetadata> PaginationFindByContactpersonname(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindByContactpersonname(TrunkmetadataPagination obj);

		int FindCountByContactpersonname(Trunkmetadata obj);

		IList<Trunkmetadata> FindByActive(Byte active);

		IList<Trunkmetadata> DescendOrderFindByActive(Byte active);

		IList<Trunkmetadata> PaginationFindByActive(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindByActive(TrunkmetadataPagination obj);

		int FindCountByActive(Trunkmetadata obj);

		IList<Trunkmetadata> FindByVanimageuri(String vanimageuri);

		IList<Trunkmetadata> DescendOrderFindByVanimageuri(String vanimageuri);

		IList<Trunkmetadata> PaginationFindByVanimageuri(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindByVanimageuri(TrunkmetadataPagination obj);

		int FindCountByVanimageuri(Trunkmetadata obj);

		IList<Trunkmetadata> FindByWeightcapacity(String weightcapacity);

		IList<Trunkmetadata> DescendOrderFindByWeightcapacity(String weightcapacity);

		IList<Trunkmetadata> PaginationFindByWeightcapacity(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindByWeightcapacity(TrunkmetadataPagination obj);

		int FindCountByWeightcapacity(Trunkmetadata obj);

		IList<Trunkmetadata> FindByVantypeid(Int64 vantypeid);

		IList<Trunkmetadata> DescendOrderFindByVantypeid(Int64 vantypeid);

		IList<Trunkmetadata> PaginationFindByVantypeid(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindByVantypeid(TrunkmetadataPagination obj);

		int FindCountByVantypeid(Trunkmetadata obj);

		IList<Trunkmetadata> FindByLicenseuri(String licenseuri);

		IList<Trunkmetadata> DescendOrderFindByLicenseuri(String licenseuri);

		IList<Trunkmetadata> PaginationFindByLicenseuri(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindByLicenseuri(TrunkmetadataPagination obj);

		int FindCountByLicenseuri(Trunkmetadata obj);

		IList<Trunkmetadata> FindByTrunkidentifynumber(String trunkidentifynumber);

		IList<Trunkmetadata> DescendOrderFindByTrunkidentifynumber(String trunkidentifynumber);

		IList<Trunkmetadata> PaginationFindByTrunkidentifynumber(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindByTrunkidentifynumber(TrunkmetadataPagination obj);

		int FindCountByTrunkidentifynumber(Trunkmetadata obj);

		IList<Trunkmetadata> FindByCountycode(String countycode);

		IList<Trunkmetadata> DescendOrderFindByCountycode(String countycode);

		IList<Trunkmetadata> PaginationFindByCountycode(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindByCountycode(TrunkmetadataPagination obj);

		int FindCountByCountycode(Trunkmetadata obj);

		IList<Trunkmetadata> FindByLocation(String location);

		IList<Trunkmetadata> DescendOrderFindByLocation(String location);

		IList<Trunkmetadata> PaginationFindByLocation(TrunkmetadataPagination obj);

		IList<Trunkmetadata> DescendOrderPaginationFindByLocation(TrunkmetadataPagination obj);

		int FindCountByLocation(Trunkmetadata obj);

		void Insert(Trunkmetadata obj);

		void Update(Trunkmetadata obj);

		void Delete(Trunkmetadata obj);

		int DeleteByConatactphone(String conatactphone);

		int DeleteByVolume(String volume);

		int DeleteByNumberid(Int64 numberid);

		int DeleteByBrand(String brand);

		int DeleteByLength(String length);

		int DeleteByTrunktypeid(Int64 trunktypeid);

		int DeleteByContactpersonname(String contactpersonname);

		int DeleteByActive(Byte active);

		int DeleteByVanimageuri(String vanimageuri);

		int DeleteByWeightcapacity(String weightcapacity);

		int DeleteByVantypeid(Int64 vantypeid);

		int DeleteByLicenseuri(String licenseuri);

		int DeleteByTrunkidentifynumber(String trunkidentifynumber);

		int DeleteByCountycode(String countycode);

		int DeleteByLocation(String location);

		void Reload(Trunkmetadata obj);
	}
}
