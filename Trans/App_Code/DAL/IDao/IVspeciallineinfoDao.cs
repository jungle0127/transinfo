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

		IList<Vspeciallineinfo> FindBySpeciallinetypename(String speciallinetypename);

		IList<Vspeciallineinfo> PaginationFindBySpeciallinetypename(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindBySrccontactpersonname(String srccontactpersonname);

		IList<Vspeciallineinfo> PaginationFindBySrccontactpersonname(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindByDescription(String description);

		IList<Vspeciallineinfo> PaginationFindByDescription(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindByUserid(Int64 userid);

		IList<Vspeciallineinfo> PaginationFindByUserid(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindBySrccontactphone(String srccontactphone);

		IList<Vspeciallineinfo> PaginationFindBySrccontactphone(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindByVolumeprice(Int32 volumeprice);

		IList<Vspeciallineinfo> PaginationFindByVolumeprice(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindByDstcontactpersonname(String dstcontactpersonname);

		IList<Vspeciallineinfo> PaginationFindByDstcontactpersonname(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindBySrcplaceaddress(String srcplaceaddress);

		IList<Vspeciallineinfo> PaginationFindBySrcplaceaddress(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindByWeightprice(Int32 weightprice);

		IList<Vspeciallineinfo> PaginationFindByWeightprice(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindBySrccontactcellphone(String srccontactcellphone);

		IList<Vspeciallineinfo> PaginationFindBySrccontactcellphone(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindBySrccityname(String srccityname);

		IList<Vspeciallineinfo> PaginationFindBySrccityname(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindBySrccitycode(String srccitycode);

		IList<Vspeciallineinfo> PaginationFindBySrccitycode(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindBySrcregionname(String srcregionname);

		IList<Vspeciallineinfo> PaginationFindBySrcregionname(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindByDstcontactphone(String dstcontactphone);

		IList<Vspeciallineinfo> PaginationFindByDstcontactphone(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindById(Int64 id);

		IList<Vspeciallineinfo> PaginationFindById(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindByDstregionname(String dstregionname);

		IList<Vspeciallineinfo> PaginationFindByDstregionname(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindByDeparturetypename(String departuretypename);

		IList<Vspeciallineinfo> PaginationFindByDeparturetypename(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindByDstplaceaddress(String dstplaceaddress);

		IList<Vspeciallineinfo> PaginationFindByDstplaceaddress(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindByDstcityname(String dstcityname);

		IList<Vspeciallineinfo> PaginationFindByDstcityname(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindByDstcitycode(String dstcitycode);

		IList<Vspeciallineinfo> PaginationFindByDstcitycode(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindByTitle(String title);

		IList<Vspeciallineinfo> PaginationFindByTitle(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindByDstcontactcellphone(String dstcontactcellphone);

		IList<Vspeciallineinfo> PaginationFindByDstcontactcellphone(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> FindByUsername(String username);

		IList<Vspeciallineinfo> PaginationFindByUsername(VspeciallineinfoPagination obj);

		void Reload(Vspeciallineinfo obj);
	}
}
