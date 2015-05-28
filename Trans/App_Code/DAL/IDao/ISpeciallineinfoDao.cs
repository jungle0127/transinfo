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

		IList<Speciallineinfo> FindAll();

		IList<Speciallineinfo> PaginationFindAll(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> QuickFindAll();

		IList<Speciallineinfo> FindByUserid(Int64 userid);

		IList<Speciallineinfo> PaginationFindByUserid(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> FindByDestinationplaceinfoid(Int64 destinationplaceinfoid);

		IList<Speciallineinfo> PaginationFindByDestinationplaceinfoid(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> FindByDeparturetypeid(Int64 departuretypeid);

		IList<Speciallineinfo> PaginationFindByDeparturetypeid(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> FindByTitle(String title);

		IList<Speciallineinfo> PaginationFindByTitle(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> FindByVolumeprice(Int32 volumeprice);

		IList<Speciallineinfo> PaginationFindByVolumeprice(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> FindBySpeciallinetypeid(Int64 speciallinetypeid);

		IList<Speciallineinfo> PaginationFindBySpeciallinetypeid(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> FindByWeightprice(Int32 weightprice);

		IList<Speciallineinfo> PaginationFindByWeightprice(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> FindByDescription(String description);

		IList<Speciallineinfo> PaginationFindByDescription(SpeciallineinfoPagination obj);

		IList<Speciallineinfo> FindBySourceplaceinfoid(Int64 sourceplaceinfoid);

		IList<Speciallineinfo> PaginationFindBySourceplaceinfoid(SpeciallineinfoPagination obj);

		void Insert(Speciallineinfo obj);

		void Update(Speciallineinfo obj);

		void Delete(Speciallineinfo obj);

		int DeleteByUserid(Int64 userid);

		int DeleteByDestinationplaceinfoid(Int64 destinationplaceinfoid);

		int DeleteByDeparturetypeid(Int64 departuretypeid);

		int DeleteByTitle(String title);

		int DeleteByVolumeprice(Int32 volumeprice);

		int DeleteBySpeciallinetypeid(Int64 speciallinetypeid);

		int DeleteByWeightprice(Int32 weightprice);

		int DeleteByDescription(String description);

		int DeleteBySourceplaceinfoid(Int64 sourceplaceinfoid);

		void Reload(Speciallineinfo obj);
	}
}
