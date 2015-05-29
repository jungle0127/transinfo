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

		IList<Trunkmetadata> FindAll();

		IList<Trunkmetadata> PaginationFindAll(TrunkmetadataPagination obj);

		IList<Trunkmetadata> QuickFindAll();

		IList<Trunkmetadata> FindByConatactphone(String conatactphone);

		IList<Trunkmetadata> PaginationFindByConatactphone(TrunkmetadataPagination obj);

		IList<Trunkmetadata> FindByVolume(String volume);

		IList<Trunkmetadata> PaginationFindByVolume(TrunkmetadataPagination obj);

		IList<Trunkmetadata> FindByNumberid(Int64 numberid);

		IList<Trunkmetadata> PaginationFindByNumberid(TrunkmetadataPagination obj);

		IList<Trunkmetadata> FindByBrand(String brand);

		IList<Trunkmetadata> PaginationFindByBrand(TrunkmetadataPagination obj);

		IList<Trunkmetadata> FindByLength(String length);

		IList<Trunkmetadata> PaginationFindByLength(TrunkmetadataPagination obj);

		IList<Trunkmetadata> FindByTrunktypeid(Int64 trunktypeid);

		IList<Trunkmetadata> PaginationFindByTrunktypeid(TrunkmetadataPagination obj);

		IList<Trunkmetadata> FindByContactpersonname(String contactpersonname);

		IList<Trunkmetadata> PaginationFindByContactpersonname(TrunkmetadataPagination obj);

		IList<Trunkmetadata> FindByActive(Byte active);

		IList<Trunkmetadata> PaginationFindByActive(TrunkmetadataPagination obj);

		IList<Trunkmetadata> FindByVanimageuri(String vanimageuri);

		IList<Trunkmetadata> PaginationFindByVanimageuri(TrunkmetadataPagination obj);

		IList<Trunkmetadata> FindByWeightcapacity(String weightcapacity);

		IList<Trunkmetadata> PaginationFindByWeightcapacity(TrunkmetadataPagination obj);

		IList<Trunkmetadata> FindByVantypeid(Int64 vantypeid);

		IList<Trunkmetadata> PaginationFindByVantypeid(TrunkmetadataPagination obj);

		IList<Trunkmetadata> FindByLicenseuri(String licenseuri);

		IList<Trunkmetadata> PaginationFindByLicenseuri(TrunkmetadataPagination obj);

		IList<Trunkmetadata> FindByTrunkidentifynumber(String trunkidentifynumber);

		IList<Trunkmetadata> PaginationFindByTrunkidentifynumber(TrunkmetadataPagination obj);

		IList<Trunkmetadata> FindByCountycode(String countycode);

		IList<Trunkmetadata> PaginationFindByCountycode(TrunkmetadataPagination obj);

		IList<Trunkmetadata> FindByLocation(String location);

		IList<Trunkmetadata> PaginationFindByLocation(TrunkmetadataPagination obj);

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
