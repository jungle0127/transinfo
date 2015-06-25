using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ICountyDao
    {
		int GetCount();

		County Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<County> FindAll();

		IList<County> DescendOrderFindAll();

		IList<County> PaginationFindAll(CountyPagination obj);

		IList<County> DescendOrderPaginationFindAll(CountyPagination obj);

		IList<County> QuickFindAll();

		IList<County> FindByCitycode(String citycode);

		IList<County> DescendOrderFindByCitycode(String citycode);

		IList<County> PaginationFindByCitycode(CountyPagination obj);

		IList<County> DescendOrderPaginationFindByCitycode(CountyPagination obj);

		int FindCountByCitycode(County obj);

		IList<County> FindByCode(String code);

		IList<County> DescendOrderFindByCode(String code);

		IList<County> PaginationFindByCode(CountyPagination obj);

		IList<County> DescendOrderPaginationFindByCode(CountyPagination obj);

		int FindCountByCode(County obj);

		IList<County> FindByName(String name);

		IList<County> DescendOrderFindByName(String name);

		IList<County> PaginationFindByName(CountyPagination obj);

		IList<County> DescendOrderPaginationFindByName(CountyPagination obj);

		int FindCountByName(County obj);

		void Insert(County obj);

		void Update(County obj);

		void Delete(County obj);

		int DeleteByCitycode(String citycode);

		int DeleteByCode(String code);

		int DeleteByName(String name);

		void Reload(County obj);
	}
}
