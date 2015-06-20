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

		IList<Speciallineinfo> PaginationFindAll(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> QuickFindAll();

		IList<Speciallineinfo> FindByUserid(Int64 userid);

		IList<Speciallineinfo> PaginationFindByUserid(SpeciallineinfoPagination obj);

		int FindCountByUserid(Speciallineinfo obj);

		IList<Speciallineinfo> FindByDestinationplaceinfoid(Int64 destinationplaceinfoid);

		IList<Speciallineinfo> PaginationFindByDestinationplaceinfoid(SpeciallineinfoPagination obj);

		int FindCountByDestinationplaceinfoid(Speciallineinfo obj);

		IList<Speciallineinfo> FindByDeparturetypeid(Int64 departuretypeid);

		IList<Speciallineinfo> PaginationFindByDeparturetypeid(SpeciallineinfoPagination obj);

		int FindCountByDeparturetypeid(Speciallineinfo obj);

		IList<Speciallineinfo> FindByTitle(String title);

		IList<Speciallineinfo> PaginationFindByTitle(SpeciallineinfoPagination obj);

		int FindCountByTitle(Speciallineinfo obj);

		IList<Speciallineinfo> FindByVolumeprice(Int32 volumeprice);

		IList<Speciallineinfo> PaginationFindByVolumeprice(SpeciallineinfoPagination obj);

		int FindCountByVolumeprice(Speciallineinfo obj);

		IList<Speciallineinfo> FindByWeightprice(Int32 weightprice);

		IList<Speciallineinfo> PaginationFindByWeightprice(SpeciallineinfoPagination obj);

		int FindCountByWeightprice(Speciallineinfo obj);

		IList<Speciallineinfo> FindByDescription(String description);

		IList<Speciallineinfo> PaginationFindByDescription(SpeciallineinfoPagination obj);

		int FindCountByDescription(Speciallineinfo obj);

		IList<Speciallineinfo> FindBySourceplaceinfoid(Int64 sourceplaceinfoid);

		IList<Speciallineinfo> PaginationFindBySourceplaceinfoid(SpeciallineinfoPagination obj);

		int FindCountBySourceplaceinfoid(Speciallineinfo obj);

		IList<Speciallineinfo> FindBySpeciallinetypeid(Int64 speciallinetypeid);

		IList<Speciallineinfo> PaginationFindBySpeciallinetypeid(SpeciallineinfoPagination obj);

		int FindCountBySpeciallinetypeid(Speciallineinfo obj);

		IList<Speciallineinfo> FindByReleasedate(DateTime releasedate);

		IList<Speciallineinfo> PaginationFindByReleasedate(SpeciallineinfoPagination obj);

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
