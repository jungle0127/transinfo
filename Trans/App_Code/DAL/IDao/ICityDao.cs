using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ICityDao
    {
		int GetCount();

		City Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<City> FindAll();

		IList<City> DescendOrderFindAll();

		IList<City> PaginationFindAll(CityPagination obj);

		IList<City> DescendOrderPaginationFindAll(CityPagination obj);

		IList<City> QuickFindAll();

		IList<City> FindByProvincecode(String provincecode);

		IList<City> DescendOrderFindByProvincecode(String provincecode);

		IList<City> PaginationFindByProvincecode(CityPagination obj);

		IList<City> DescendOrderPaginationFindByProvincecode(CityPagination obj);

		int FindCountByProvincecode(City obj);

		IList<City> FindByCode(String code);

		IList<City> DescendOrderFindByCode(String code);

		IList<City> PaginationFindByCode(CityPagination obj);

		IList<City> DescendOrderPaginationFindByCode(CityPagination obj);

		int FindCountByCode(City obj);

		IList<City> FindByName(String name);

		IList<City> DescendOrderFindByName(String name);

		IList<City> PaginationFindByName(CityPagination obj);

		IList<City> DescendOrderPaginationFindByName(CityPagination obj);

		int FindCountByName(City obj);

		void Insert(City obj);

		void Update(City obj);

		void Delete(City obj);

		int DeleteByProvincecode(String provincecode);

		int DeleteByCode(String code);

		int DeleteByName(String name);

		void Reload(City obj);
	}
}
