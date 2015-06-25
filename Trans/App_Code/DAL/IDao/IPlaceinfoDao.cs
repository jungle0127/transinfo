using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IPlaceinfoDao
    {
		int GetCount();

		Placeinfo Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Placeinfo> FindAll();

		IList<Placeinfo> DescendOrderFindAll();

		IList<Placeinfo> PaginationFindAll(PlaceinfoPagination obj);

		IList<Placeinfo> DescendOrderPaginationFindAll(PlaceinfoPagination obj);

		IList<Placeinfo> QuickFindAll();

		IList<Placeinfo> FindByAddress(String address);

		IList<Placeinfo> DescendOrderFindByAddress(String address);

		IList<Placeinfo> PaginationFindByAddress(PlaceinfoPagination obj);

		IList<Placeinfo> DescendOrderPaginationFindByAddress(PlaceinfoPagination obj);

		int FindCountByAddress(Placeinfo obj);

		IList<Placeinfo> FindByContactpersonname(String contactpersonname);

		IList<Placeinfo> DescendOrderFindByContactpersonname(String contactpersonname);

		IList<Placeinfo> PaginationFindByContactpersonname(PlaceinfoPagination obj);

		IList<Placeinfo> DescendOrderPaginationFindByContactpersonname(PlaceinfoPagination obj);

		int FindCountByContactpersonname(Placeinfo obj);

		IList<Placeinfo> FindByContactphone(String contactphone);

		IList<Placeinfo> DescendOrderFindByContactphone(String contactphone);

		IList<Placeinfo> PaginationFindByContactphone(PlaceinfoPagination obj);

		IList<Placeinfo> DescendOrderPaginationFindByContactphone(PlaceinfoPagination obj);

		int FindCountByContactphone(Placeinfo obj);

		IList<Placeinfo> FindByContactcellphone(String contactcellphone);

		IList<Placeinfo> DescendOrderFindByContactcellphone(String contactcellphone);

		IList<Placeinfo> PaginationFindByContactcellphone(PlaceinfoPagination obj);

		IList<Placeinfo> DescendOrderPaginationFindByContactcellphone(PlaceinfoPagination obj);

		int FindCountByContactcellphone(Placeinfo obj);

		IList<Placeinfo> FindByCountycode(String countycode);

		IList<Placeinfo> DescendOrderFindByCountycode(String countycode);

		IList<Placeinfo> PaginationFindByCountycode(PlaceinfoPagination obj);

		IList<Placeinfo> DescendOrderPaginationFindByCountycode(PlaceinfoPagination obj);

		int FindCountByCountycode(Placeinfo obj);

		void Insert(Placeinfo obj);

		void Update(Placeinfo obj);

		void Delete(Placeinfo obj);

		int DeleteByAddress(String address);

		int DeleteByContactpersonname(String contactpersonname);

		int DeleteByContactphone(String contactphone);

		int DeleteByContactcellphone(String contactcellphone);

		int DeleteByCountycode(String countycode);

		void Reload(Placeinfo obj);
	}
}
