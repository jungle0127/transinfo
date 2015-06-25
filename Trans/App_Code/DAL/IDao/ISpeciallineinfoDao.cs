using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ISpeciallineinfoDao
    {
		int GetCount();

		Speciallineinfo Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Speciallineinfo> FindAll();

		IList<Speciallineinfo> DescendOrderFindAll();

		IList<Speciallineinfo> PaginationFindAll(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> DescendOrderPaginationFindAll(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> QuickFindAll();

		IList<Speciallineinfo> FindByUserid(Int64 userid);

		IList<Speciallineinfo> DescendOrderFindByUserid(Int64 userid);

		IList<Speciallineinfo> PaginationFindByUserid(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> DescendOrderPaginationFindByUserid(SpeciallineinfoPagination obj);

		int FindCountByUserid(Speciallineinfo obj);

		IList<Speciallineinfo> FindByDestinationplaceinfoid(Int64 destinationplaceinfoid);

		IList<Speciallineinfo> DescendOrderFindByDestinationplaceinfoid(Int64 destinationplaceinfoid);

		IList<Speciallineinfo> PaginationFindByDestinationplaceinfoid(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> DescendOrderPaginationFindByDestinationplaceinfoid(SpeciallineinfoPagination obj);

		int FindCountByDestinationplaceinfoid(Speciallineinfo obj);

		IList<Speciallineinfo> FindByDeparturetypeid(Int64 departuretypeid);

		IList<Speciallineinfo> DescendOrderFindByDeparturetypeid(Int64 departuretypeid);

		IList<Speciallineinfo> PaginationFindByDeparturetypeid(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> DescendOrderPaginationFindByDeparturetypeid(SpeciallineinfoPagination obj);

		int FindCountByDeparturetypeid(Speciallineinfo obj);

		IList<Speciallineinfo> FindByTitle(String title);

		IList<Speciallineinfo> DescendOrderFindByTitle(String title);

		IList<Speciallineinfo> PaginationFindByTitle(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> DescendOrderPaginationFindByTitle(SpeciallineinfoPagination obj);

		int FindCountByTitle(Speciallineinfo obj);

		IList<Speciallineinfo> FindByVolumeprice(Int32 volumeprice);

		IList<Speciallineinfo> DescendOrderFindByVolumeprice(Int32 volumeprice);

		IList<Speciallineinfo> PaginationFindByVolumeprice(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> DescendOrderPaginationFindByVolumeprice(SpeciallineinfoPagination obj);

		int FindCountByVolumeprice(Speciallineinfo obj);

		IList<Speciallineinfo> FindByWeightprice(Int32 weightprice);

		IList<Speciallineinfo> DescendOrderFindByWeightprice(Int32 weightprice);

		IList<Speciallineinfo> PaginationFindByWeightprice(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> DescendOrderPaginationFindByWeightprice(SpeciallineinfoPagination obj);

		int FindCountByWeightprice(Speciallineinfo obj);

		IList<Speciallineinfo> FindByDescription(String description);

		IList<Speciallineinfo> DescendOrderFindByDescription(String description);

		IList<Speciallineinfo> PaginationFindByDescription(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> DescendOrderPaginationFindByDescription(SpeciallineinfoPagination obj);

		int FindCountByDescription(Speciallineinfo obj);

		IList<Speciallineinfo> FindBySourceplaceinfoid(Int64 sourceplaceinfoid);

		IList<Speciallineinfo> DescendOrderFindBySourceplaceinfoid(Int64 sourceplaceinfoid);

		IList<Speciallineinfo> PaginationFindBySourceplaceinfoid(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> DescendOrderPaginationFindBySourceplaceinfoid(SpeciallineinfoPagination obj);

		int FindCountBySourceplaceinfoid(Speciallineinfo obj);

		IList<Speciallineinfo> FindBySpeciallinetypeid(Int64 speciallinetypeid);

		IList<Speciallineinfo> DescendOrderFindBySpeciallinetypeid(Int64 speciallinetypeid);

		IList<Speciallineinfo> PaginationFindBySpeciallinetypeid(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> DescendOrderPaginationFindBySpeciallinetypeid(SpeciallineinfoPagination obj);

		int FindCountBySpeciallinetypeid(Speciallineinfo obj);

		IList<Speciallineinfo> FindByReleasedate(DateTime releasedate);

		IList<Speciallineinfo> DescendOrderFindByReleasedate(DateTime releasedate);

		IList<Speciallineinfo> PaginationFindByReleasedate(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> DescendOrderPaginationFindByReleasedate(SpeciallineinfoPagination obj);

		int FindCountByReleasedate(Speciallineinfo obj);

		void Insert(Speciallineinfo obj);

		void Update(Speciallineinfo obj);

		void Delete(Speciallineinfo obj);

		int DeleteByUserid(Int64 userid);

		int DeleteByDestinationplaceinfoid(Int64 destinationplaceinfoid);

		int DeleteByDeparturetypeid(Int64 departuretypeid);

		int DeleteByTitle(String title);

		int DeleteByVolumeprice(Int32 volumeprice);

		int DeleteByWeightprice(Int32 weightprice);

		int DeleteByDescription(String description);

		int DeleteBySourceplaceinfoid(Int64 sourceplaceinfoid);

		int DeleteBySpeciallinetypeid(Int64 speciallinetypeid);

		int DeleteByReleasedate(DateTime releasedate);

		void Reload(Speciallineinfo obj);
	}
}
