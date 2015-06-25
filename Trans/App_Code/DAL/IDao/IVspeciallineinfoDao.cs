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

		IList<Vspeciallineinfo> DescendOrderFindAll();

		IList<Vspeciallineinfo> PaginationFindAll(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindAll(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> QuickFindAll();

		IList<Vspeciallineinfo> FindByReleasedate(DateTime releasedate);

		IList<Vspeciallineinfo> DescendOrderFindByReleasedate(DateTime releasedate);

		IList<Vspeciallineinfo> PaginationFindByReleasedate(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindByReleasedate(VspeciallineinfoPagination obj);

		int FindCountByReleasedate(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySpeciallinetypename(String speciallinetypename);

		IList<Vspeciallineinfo> DescendOrderFindBySpeciallinetypename(String speciallinetypename);

		IList<Vspeciallineinfo> PaginationFindBySpeciallinetypename(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindBySpeciallinetypename(VspeciallineinfoPagination obj);

		int FindCountBySpeciallinetypename(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySrccontactpersonname(String srccontactpersonname);

		IList<Vspeciallineinfo> DescendOrderFindBySrccontactpersonname(String srccontactpersonname);

		IList<Vspeciallineinfo> PaginationFindBySrccontactpersonname(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindBySrccontactpersonname(VspeciallineinfoPagination obj);

		int FindCountBySrccontactpersonname(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDescription(String description);

		IList<Vspeciallineinfo> DescendOrderFindByDescription(String description);

		IList<Vspeciallineinfo> PaginationFindByDescription(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindByDescription(VspeciallineinfoPagination obj);

		int FindCountByDescription(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByUserid(Int64 userid);

		IList<Vspeciallineinfo> DescendOrderFindByUserid(Int64 userid);

		IList<Vspeciallineinfo> PaginationFindByUserid(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindByUserid(VspeciallineinfoPagination obj);

		int FindCountByUserid(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySrccontactphone(String srccontactphone);

		IList<Vspeciallineinfo> DescendOrderFindBySrccontactphone(String srccontactphone);

		IList<Vspeciallineinfo> PaginationFindBySrccontactphone(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindBySrccontactphone(VspeciallineinfoPagination obj);

		int FindCountBySrccontactphone(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByVolumeprice(Int32 volumeprice);

		IList<Vspeciallineinfo> DescendOrderFindByVolumeprice(Int32 volumeprice);

		IList<Vspeciallineinfo> PaginationFindByVolumeprice(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindByVolumeprice(VspeciallineinfoPagination obj);

		int FindCountByVolumeprice(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDstcontactpersonname(String dstcontactpersonname);

		IList<Vspeciallineinfo> DescendOrderFindByDstcontactpersonname(String dstcontactpersonname);

		IList<Vspeciallineinfo> PaginationFindByDstcontactpersonname(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindByDstcontactpersonname(VspeciallineinfoPagination obj);

		int FindCountByDstcontactpersonname(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySrcplaceaddress(String srcplaceaddress);

		IList<Vspeciallineinfo> DescendOrderFindBySrcplaceaddress(String srcplaceaddress);

		IList<Vspeciallineinfo> PaginationFindBySrcplaceaddress(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindBySrcplaceaddress(VspeciallineinfoPagination obj);

		int FindCountBySrcplaceaddress(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByWeightprice(Int32 weightprice);

		IList<Vspeciallineinfo> DescendOrderFindByWeightprice(Int32 weightprice);

		IList<Vspeciallineinfo> PaginationFindByWeightprice(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindByWeightprice(VspeciallineinfoPagination obj);

		int FindCountByWeightprice(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySrccontactcellphone(String srccontactcellphone);

		IList<Vspeciallineinfo> DescendOrderFindBySrccontactcellphone(String srccontactcellphone);

		IList<Vspeciallineinfo> PaginationFindBySrccontactcellphone(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindBySrccontactcellphone(VspeciallineinfoPagination obj);

		int FindCountBySrccontactcellphone(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySrccityname(String srccityname);

		IList<Vspeciallineinfo> DescendOrderFindBySrccityname(String srccityname);

		IList<Vspeciallineinfo> PaginationFindBySrccityname(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindBySrccityname(VspeciallineinfoPagination obj);

		int FindCountBySrccityname(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySrccitycode(String srccitycode);

		IList<Vspeciallineinfo> DescendOrderFindBySrccitycode(String srccitycode);

		IList<Vspeciallineinfo> PaginationFindBySrccitycode(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindBySrccitycode(VspeciallineinfoPagination obj);

		int FindCountBySrccitycode(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindBySrcregionname(String srcregionname);

		IList<Vspeciallineinfo> DescendOrderFindBySrcregionname(String srcregionname);

		IList<Vspeciallineinfo> PaginationFindBySrcregionname(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindBySrcregionname(VspeciallineinfoPagination obj);

		int FindCountBySrcregionname(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDstcontactphone(String dstcontactphone);

		IList<Vspeciallineinfo> DescendOrderFindByDstcontactphone(String dstcontactphone);

		IList<Vspeciallineinfo> PaginationFindByDstcontactphone(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindByDstcontactphone(VspeciallineinfoPagination obj);

		int FindCountByDstcontactphone(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindById(Int64 id);

		IList<Vspeciallineinfo> DescendOrderFindById(Int64 id);

		IList<Vspeciallineinfo> PaginationFindById(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindById(VspeciallineinfoPagination obj);

		int FindCountById(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDstregionname(String dstregionname);

		IList<Vspeciallineinfo> DescendOrderFindByDstregionname(String dstregionname);

		IList<Vspeciallineinfo> PaginationFindByDstregionname(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindByDstregionname(VspeciallineinfoPagination obj);

		int FindCountByDstregionname(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDeparturetypename(String departuretypename);

		IList<Vspeciallineinfo> DescendOrderFindByDeparturetypename(String departuretypename);

		IList<Vspeciallineinfo> PaginationFindByDeparturetypename(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindByDeparturetypename(VspeciallineinfoPagination obj);

		int FindCountByDeparturetypename(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDstplaceaddress(String dstplaceaddress);

		IList<Vspeciallineinfo> DescendOrderFindByDstplaceaddress(String dstplaceaddress);

		IList<Vspeciallineinfo> PaginationFindByDstplaceaddress(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindByDstplaceaddress(VspeciallineinfoPagination obj);

		int FindCountByDstplaceaddress(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDstcityname(String dstcityname);

		IList<Vspeciallineinfo> DescendOrderFindByDstcityname(String dstcityname);

		IList<Vspeciallineinfo> PaginationFindByDstcityname(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindByDstcityname(VspeciallineinfoPagination obj);

		int FindCountByDstcityname(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDstcitycode(String dstcitycode);

		IList<Vspeciallineinfo> DescendOrderFindByDstcitycode(String dstcitycode);

		IList<Vspeciallineinfo> PaginationFindByDstcitycode(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindByDstcitycode(VspeciallineinfoPagination obj);

		int FindCountByDstcitycode(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByTitle(String title);

		IList<Vspeciallineinfo> DescendOrderFindByTitle(String title);

		IList<Vspeciallineinfo> PaginationFindByTitle(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindByTitle(VspeciallineinfoPagination obj);

		int FindCountByTitle(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByDstcontactcellphone(String dstcontactcellphone);

		IList<Vspeciallineinfo> DescendOrderFindByDstcontactcellphone(String dstcontactcellphone);

		IList<Vspeciallineinfo> PaginationFindByDstcontactcellphone(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindByDstcontactcellphone(VspeciallineinfoPagination obj);

		int FindCountByDstcontactcellphone(Vspeciallineinfo obj);

		IList<Vspeciallineinfo> FindByUsername(String username);

		IList<Vspeciallineinfo> DescendOrderFindByUsername(String username);

		IList<Vspeciallineinfo> PaginationFindByUsername(VspeciallineinfoPagination obj);

		IList<Vspeciallineinfo> DescendOrderPaginationFindByUsername(VspeciallineinfoPagination obj);

		int FindCountByUsername(Vspeciallineinfo obj);

		void Reload(Vspeciallineinfo obj);
	}
}
