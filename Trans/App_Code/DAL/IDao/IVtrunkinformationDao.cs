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

		IList<Vtrunkinformation> FindByTrunktypename(String trunktypename);

		IList<Vtrunkinformation> PaginationFindByTrunktypename(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByDstregionname(String dstregionname);

		IList<Vtrunkinformation> PaginationFindByDstregionname(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByVolume(String volume);

		IList<Vtrunkinformation> PaginationFindByVolume(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByNumber(String number);

		IList<Vtrunkinformation> PaginationFindByNumber(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByBrand(String brand);

		IList<Vtrunkinformation> PaginationFindByBrand(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByLength(String length);

		IList<Vtrunkinformation> PaginationFindByLength(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByConatactphone(String conatactphone);

		IList<Vtrunkinformation> PaginationFindByConatactphone(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByContactpersonname(String contactpersonname);

		IList<Vtrunkinformation> PaginationFindByContactpersonname(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByLocation(String location);

		IList<Vtrunkinformation> PaginationFindByLocation(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindBySrccityname(String srccityname);

		IList<Vtrunkinformation> PaginationFindBySrccityname(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindBySrccitycode(String srccitycode);

		IList<Vtrunkinformation> PaginationFindBySrccitycode(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindBySrcregionname(String srcregionname);

		IList<Vtrunkinformation> PaginationFindBySrcregionname(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByWeightcapacity(String weightcapacity);

		IList<Vtrunkinformation> PaginationFindByWeightcapacity(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByTrunkcountyname(String trunkcountyname);

		IList<Vtrunkinformation> PaginationFindByTrunkcountyname(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindById(Int64 id);

		IList<Vtrunkinformation> PaginationFindById(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByPrefixname(String prefixname);

		IList<Vtrunkinformation> PaginationFindByPrefixname(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByVanimageuri(String vanimageuri);

		IList<Vtrunkinformation> PaginationFindByVanimageuri(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByLicenseuri(String licenseuri);

		IList<Vtrunkinformation> PaginationFindByLicenseuri(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByTrunkidentifynumber(String trunkidentifynumber);

		IList<Vtrunkinformation> PaginationFindByTrunkidentifynumber(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByDstcityname(String dstcityname);

		IList<Vtrunkinformation> PaginationFindByDstcityname(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByDstcitycode(String dstcitycode);

		IList<Vtrunkinformation> PaginationFindByDstcitycode(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByRoutetype(String routetype);

		IList<Vtrunkinformation> PaginationFindByRoutetype(VtrunkinformationPagination obj);

		IList<Vtrunkinformation> FindByUsername(String username);

		IList<Vtrunkinformation> PaginationFindByUsername(VtrunkinformationPagination obj);

		void Reload(Vtrunkinformation obj);
	}
}
