using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IVspeciallineinfoDao
    {
		int GetCount();

		IList<Vspeciallineinfo> FindAll();

		IList<Vspeciallineinfo> PaginationFindAll(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> QuickFindAll();

		IList<Vspeciallineinfo> FindByReleasedate(DateTime releasedate);

		IList<Vspeciallineinfo> PaginationFindByReleasedate(VspeciallineinfoPagination obj);

		int FindCountByReleasedate(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySpeciallinetypename(String speciallinetypename);

		IList<Vspeciallineinfo> PaginationFindBySpeciallinetypename(VspeciallineinfoPagination obj);

		int FindCountBySpeciallinetypename(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySrccontactpersonname(String srccontactpersonname);

		IList<Vspeciallineinfo> PaginationFindBySrccontactpersonname(VspeciallineinfoPagination obj);

		int FindCountBySrccontactpersonname(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDescription(String description);

		IList<Vspeciallineinfo> PaginationFindByDescription(VspeciallineinfoPagination obj);

		int FindCountByDescription(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByUserid(Int64 userid);

		IList<Vspeciallineinfo> PaginationFindByUserid(VspeciallineinfoPagination obj);

		int FindCountByUserid(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySrccontactphone(String srccontactphone);

		IList<Vspeciallineinfo> PaginationFindBySrccontactphone(VspeciallineinfoPagination obj);

		int FindCountBySrccontactphone(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByVolumeprice(Int32 volumeprice);

		IList<Vspeciallineinfo> PaginationFindByVolumeprice(VspeciallineinfoPagination obj);

		int FindCountByVolumeprice(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDstcontactpersonname(String dstcontactpersonname);

		IList<Vspeciallineinfo> PaginationFindByDstcontactpersonname(VspeciallineinfoPagination obj);

		int FindCountByDstcontactpersonname(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySrcplaceaddress(String srcplaceaddress);

		IList<Vspeciallineinfo> PaginationFindBySrcplaceaddress(VspeciallineinfoPagination obj);

		int FindCountBySrcplaceaddress(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByWeightprice(Int32 weightprice);

		IList<Vspeciallineinfo> PaginationFindByWeightprice(VspeciallineinfoPagination obj);

		int FindCountByWeightprice(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySrccontactcellphone(String srccontactcellphone);

		IList<Vspeciallineinfo> PaginationFindBySrccontactcellphone(VspeciallineinfoPagination obj);

		int FindCountBySrccontactcellphone(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySrccityname(String srccityname);

		IList<Vspeciallineinfo> PaginationFindBySrccityname(VspeciallineinfoPagination obj);

		int FindCountBySrccityname(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySrccitycode(String srccitycode);

		IList<Vspeciallineinfo> PaginationFindBySrccitycode(VspeciallineinfoPagination obj);

		int FindCountBySrccitycode(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySrcregionname(String srcregionname);

		IList<Vspeciallineinfo> PaginationFindBySrcregionname(VspeciallineinfoPagination obj);

		int FindCountBySrcregionname(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDstcontactphone(String dstcontactphone);

		IList<Vspeciallineinfo> PaginationFindByDstcontactphone(VspeciallineinfoPagination obj);

		int FindCountByDstcontactphone(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindById(Int64 id);

		IList<Vspeciallineinfo> PaginationFindById(VspeciallineinfoPagination obj);

		int FindCountById(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDstregionname(String dstregionname);

		IList<Vspeciallineinfo> PaginationFindByDstregionname(VspeciallineinfoPagination obj);

		int FindCountByDstregionname(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDeparturetypename(String departuretypename);

		IList<Vspeciallineinfo> PaginationFindByDeparturetypename(VspeciallineinfoPagination obj);

		int FindCountByDeparturetypename(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDstplaceaddress(String dstplaceaddress);

		IList<Vspeciallineinfo> PaginationFindByDstplaceaddress(VspeciallineinfoPagination obj);

		int FindCountByDstplaceaddress(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDstcityname(String dstcityname);

		IList<Vspeciallineinfo> PaginationFindByDstcityname(VspeciallineinfoPagination obj);

		int FindCountByDstcityname(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDstcitycode(String dstcitycode);

		IList<Vspeciallineinfo> PaginationFindByDstcitycode(VspeciallineinfoPagination obj);

		int FindCountByDstcitycode(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByTitle(String title);

		IList<Vspeciallineinfo> PaginationFindByTitle(VspeciallineinfoPagination obj);

		int FindCountByTitle(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDstcontactcellphone(String dstcontactcellphone);

		IList<Vspeciallineinfo> PaginationFindByDstcontactcellphone(VspeciallineinfoPagination obj);

		int FindCountByDstcontactcellphone(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByUsername(String username);

		IList<Vspeciallineinfo> PaginationFindByUsername(VspeciallineinfoPagination obj);

		int FindCountByUsername(Vspeciallineinfo obj);

		void Reload(Vspeciallineinfo obj);
	}
}
