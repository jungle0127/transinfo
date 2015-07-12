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

		IList<Vtrunkinformation> DescendOrderFindAll();

		IList<Vtrunkinformation> PaginationFindAll(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindAll(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> QuickFindAll();

		IList<Vtrunkinformation> FindByVantypename(String vantypename);

		IList<Vtrunkinformation> DescendOrderFindByVantypename(String vantypename);

		IList<Vtrunkinformation> PaginationFindByVantypename(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByVantypename(VtrunkinformationPagination obj);

		int FindCountByVantypename(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByTrunktypename(String trunktypename);

		IList<Vtrunkinformation> DescendOrderFindByTrunktypename(String trunktypename);

		IList<Vtrunkinformation> PaginationFindByTrunktypename(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByTrunktypename(VtrunkinformationPagination obj);

		int FindCountByTrunktypename(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByDstregionname(String dstregionname);

		IList<Vtrunkinformation> DescendOrderFindByDstregionname(String dstregionname);

		IList<Vtrunkinformation> PaginationFindByDstregionname(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByDstregionname(VtrunkinformationPagination obj);

		int FindCountByDstregionname(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByVolume(String volume);

		IList<Vtrunkinformation> DescendOrderFindByVolume(String volume);

		IList<Vtrunkinformation> PaginationFindByVolume(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByVolume(VtrunkinformationPagination obj);

		int FindCountByVolume(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByNumber(String number);

		IList<Vtrunkinformation> DescendOrderFindByNumber(String number);

		IList<Vtrunkinformation> PaginationFindByNumber(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByNumber(VtrunkinformationPagination obj);

		int FindCountByNumber(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByBrand(String brand);

		IList<Vtrunkinformation> DescendOrderFindByBrand(String brand);

		IList<Vtrunkinformation> PaginationFindByBrand(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByBrand(VtrunkinformationPagination obj);

		int FindCountByBrand(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByLength(String length);

		IList<Vtrunkinformation> DescendOrderFindByLength(String length);

		IList<Vtrunkinformation> PaginationFindByLength(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByLength(VtrunkinformationPagination obj);

		int FindCountByLength(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByConatactphone(String conatactphone);

		IList<Vtrunkinformation> DescendOrderFindByConatactphone(String conatactphone);

		IList<Vtrunkinformation> PaginationFindByConatactphone(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByConatactphone(VtrunkinformationPagination obj);

		int FindCountByConatactphone(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByContactpersonname(String contactpersonname);

		IList<Vtrunkinformation> DescendOrderFindByContactpersonname(String contactpersonname);

		IList<Vtrunkinformation> PaginationFindByContactpersonname(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByContactpersonname(VtrunkinformationPagination obj);

		int FindCountByContactpersonname(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByLocation(String location);

		IList<Vtrunkinformation> DescendOrderFindByLocation(String location);

		IList<Vtrunkinformation> PaginationFindByLocation(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByLocation(VtrunkinformationPagination obj);

		int FindCountByLocation(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindBySrccityname(String srccityname);

		IList<Vtrunkinformation> DescendOrderFindBySrccityname(String srccityname);

		IList<Vtrunkinformation> PaginationFindBySrccityname(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindBySrccityname(VtrunkinformationPagination obj);

		int FindCountBySrccityname(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindBySrccitycode(String srccitycode);

		IList<Vtrunkinformation> DescendOrderFindBySrccitycode(String srccitycode);

		IList<Vtrunkinformation> PaginationFindBySrccitycode(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindBySrccitycode(VtrunkinformationPagination obj);

		int FindCountBySrccitycode(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindBySrcregionname(String srcregionname);

		IList<Vtrunkinformation> DescendOrderFindBySrcregionname(String srcregionname);

		IList<Vtrunkinformation> PaginationFindBySrcregionname(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindBySrcregionname(VtrunkinformationPagination obj);

		int FindCountBySrcregionname(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByWeightcapacity(String weightcapacity);

		IList<Vtrunkinformation> DescendOrderFindByWeightcapacity(String weightcapacity);

		IList<Vtrunkinformation> PaginationFindByWeightcapacity(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByWeightcapacity(VtrunkinformationPagination obj);

		int FindCountByWeightcapacity(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByTrunkcountyname(String trunkcountyname);

		IList<Vtrunkinformation> DescendOrderFindByTrunkcountyname(String trunkcountyname);

		IList<Vtrunkinformation> PaginationFindByTrunkcountyname(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByTrunkcountyname(VtrunkinformationPagination obj);

		int FindCountByTrunkcountyname(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindById(Int64 id);

		IList<Vtrunkinformation> DescendOrderFindById(Int64 id);

		IList<Vtrunkinformation> PaginationFindById(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindById(VtrunkinformationPagination obj);

		int FindCountById(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByPrefixname(String prefixname);

		IList<Vtrunkinformation> DescendOrderFindByPrefixname(String prefixname);

		IList<Vtrunkinformation> PaginationFindByPrefixname(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByPrefixname(VtrunkinformationPagination obj);

		int FindCountByPrefixname(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByVanimageuri(String vanimageuri);

		IList<Vtrunkinformation> DescendOrderFindByVanimageuri(String vanimageuri);

		IList<Vtrunkinformation> PaginationFindByVanimageuri(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByVanimageuri(VtrunkinformationPagination obj);

		int FindCountByVanimageuri(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByLicenseuri(String licenseuri);

		IList<Vtrunkinformation> DescendOrderFindByLicenseuri(String licenseuri);

		IList<Vtrunkinformation> PaginationFindByLicenseuri(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByLicenseuri(VtrunkinformationPagination obj);

		int FindCountByLicenseuri(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByTrunkidentifynumber(String trunkidentifynumber);

		IList<Vtrunkinformation> DescendOrderFindByTrunkidentifynumber(String trunkidentifynumber);

		IList<Vtrunkinformation> PaginationFindByTrunkidentifynumber(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByTrunkidentifynumber(VtrunkinformationPagination obj);

		int FindCountByTrunkidentifynumber(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByDstcityname(String dstcityname);

		IList<Vtrunkinformation> DescendOrderFindByDstcityname(String dstcityname);

		IList<Vtrunkinformation> PaginationFindByDstcityname(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByDstcityname(VtrunkinformationPagination obj);

		int FindCountByDstcityname(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByDstcitycode(String dstcitycode);

		IList<Vtrunkinformation> DescendOrderFindByDstcitycode(String dstcitycode);

		IList<Vtrunkinformation> PaginationFindByDstcitycode(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByDstcitycode(VtrunkinformationPagination obj);

		int FindCountByDstcitycode(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByTitle(String title);

		IList<Vtrunkinformation> DescendOrderFindByTitle(String title);

		IList<Vtrunkinformation> PaginationFindByTitle(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByTitle(VtrunkinformationPagination obj);

		int FindCountByTitle(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByRoutetype(String routetype);

		IList<Vtrunkinformation> DescendOrderFindByRoutetype(String routetype);

		IList<Vtrunkinformation> PaginationFindByRoutetype(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByRoutetype(VtrunkinformationPagination obj);

		int FindCountByRoutetype(Vtrunkinformation obj);

		IList<Vtrunkinformation> FindByUsername(String username);

		IList<Vtrunkinformation> DescendOrderFindByUsername(String username);

		IList<Vtrunkinformation> PaginationFindByUsername(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> DescendOrderPaginationFindByUsername(VtrunkinformationPagination obj);

		int FindCountByUsername(Vtrunkinformation obj);

		void Reload(Vtrunkinformation obj);
	}
}
