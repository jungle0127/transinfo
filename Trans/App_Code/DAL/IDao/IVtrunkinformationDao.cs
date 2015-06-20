using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IVtrunkinformationDao
    {
		int GetCount();

		IList<Vtrunkinformation> FindAll();

		IList<Vtrunkinformation> PaginationFindAll(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> QuickFindAll();

		IList<Vtrunkinformation> FindByVantypename(String vantypename);

		IList<Vtrunkinformation> PaginationFindByVantypename(VtrunkinformationPagination obj);

		int FindCountByVantypename(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByTrunktypename(String trunktypename);

		IList<Vtrunkinformation> PaginationFindByTrunktypename(VtrunkinformationPagination obj);

		int FindCountByTrunktypename(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByDstregionname(String dstregionname);

		IList<Vtrunkinformation> PaginationFindByDstregionname(VtrunkinformationPagination obj);

		int FindCountByDstregionname(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByVolume(String volume);

		IList<Vtrunkinformation> PaginationFindByVolume(VtrunkinformationPagination obj);

		int FindCountByVolume(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByNumber(String number);

		IList<Vtrunkinformation> PaginationFindByNumber(VtrunkinformationPagination obj);

		int FindCountByNumber(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByBrand(String brand);

		IList<Vtrunkinformation> PaginationFindByBrand(VtrunkinformationPagination obj);

		int FindCountByBrand(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByLength(String length);

		IList<Vtrunkinformation> PaginationFindByLength(VtrunkinformationPagination obj);

		int FindCountByLength(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByConatactphone(String conatactphone);

		IList<Vtrunkinformation> PaginationFindByConatactphone(VtrunkinformationPagination obj);

		int FindCountByConatactphone(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByContactpersonname(String contactpersonname);

		IList<Vtrunkinformation> PaginationFindByContactpersonname(VtrunkinformationPagination obj);

		int FindCountByContactpersonname(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByLocation(String location);

		IList<Vtrunkinformation> PaginationFindByLocation(VtrunkinformationPagination obj);

		int FindCountByLocation(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindBySrccityname(String srccityname);

		IList<Vtrunkinformation> PaginationFindBySrccityname(VtrunkinformationPagination obj);

		int FindCountBySrccityname(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindBySrccitycode(String srccitycode);

		IList<Vtrunkinformation> PaginationFindBySrccitycode(VtrunkinformationPagination obj);

		int FindCountBySrccitycode(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindBySrcregionname(String srcregionname);

		IList<Vtrunkinformation> PaginationFindBySrcregionname(VtrunkinformationPagination obj);

		int FindCountBySrcregionname(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByWeightcapacity(String weightcapacity);

		IList<Vtrunkinformation> PaginationFindByWeightcapacity(VtrunkinformationPagination obj);

		int FindCountByWeightcapacity(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByTrunkcountyname(String trunkcountyname);

		IList<Vtrunkinformation> PaginationFindByTrunkcountyname(VtrunkinformationPagination obj);

		int FindCountByTrunkcountyname(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindById(Int64 id);

		IList<Vtrunkinformation> PaginationFindById(VtrunkinformationPagination obj);

		int FindCountById(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByPrefixname(String prefixname);

		IList<Vtrunkinformation> PaginationFindByPrefixname(VtrunkinformationPagination obj);

		int FindCountByPrefixname(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByVanimageuri(String vanimageuri);

		IList<Vtrunkinformation> PaginationFindByVanimageuri(VtrunkinformationPagination obj);

		int FindCountByVanimageuri(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByLicenseuri(String licenseuri);

		IList<Vtrunkinformation> PaginationFindByLicenseuri(VtrunkinformationPagination obj);

		int FindCountByLicenseuri(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByTrunkidentifynumber(String trunkidentifynumber);

		IList<Vtrunkinformation> PaginationFindByTrunkidentifynumber(VtrunkinformationPagination obj);

		int FindCountByTrunkidentifynumber(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByDstcityname(String dstcityname);

		IList<Vtrunkinformation> PaginationFindByDstcityname(VtrunkinformationPagination obj);

		int FindCountByDstcityname(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByDstcitycode(String dstcitycode);

		IList<Vtrunkinformation> PaginationFindByDstcitycode(VtrunkinformationPagination obj);

		int FindCountByDstcitycode(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByRoutetype(String routetype);

		IList<Vtrunkinformation> PaginationFindByRoutetype(VtrunkinformationPagination obj);

		int FindCountByRoutetype(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByUsername(String username);

		IList<Vtrunkinformation> PaginationFindByUsername(VtrunkinformationPagination obj);

		int FindCountByUsername(Vtrunkinformation obj);

		void Reload(Vtrunkinformation obj);
	}
}
