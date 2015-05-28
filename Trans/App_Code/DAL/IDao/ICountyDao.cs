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

		IList<County> FindAll();

		IList<County> PaginationFindAll(CountyPagination obj);

		IList<County> QuickFindAll();

		IList<County> FindByCitycode(String citycode);

		IList<County> PaginationFindByCitycode(CountyPagination obj);

		IList<County> FindByCode(String code);

		IList<County> PaginationFindByCode(CountyPagination obj);

		IList<County> FindByName(String name);

		IList<County> PaginationFindByName(CountyPagination obj);

		void Insert(County obj);

		void Update(County obj);

		void Delete(County obj);

		int DeleteByCitycode(String citycode);

		int DeleteByCode(String code);

		int DeleteByName(String name);

		void Reload(County obj);
	}
}
