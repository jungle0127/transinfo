using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IProvinceDao
    {
		int GetCount();

		Province Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Province> FindAll();

		IList<Province> DescendOrderFindAll();

		IList<Province> PaginationFindAll(ProvincePagination obj);

		IList<Province> DescendOrderPaginationFindAll(ProvincePagination obj);

		IList<Province> QuickFindAll();

		IList<Province> FindByCode(String code);

		IList<Province> DescendOrderFindByCode(String code);

		IList<Province> PaginationFindByCode(ProvincePagination obj);

		IList<Province> DescendOrderPaginationFindByCode(ProvincePagination obj);

		int FindCountByCode(Province obj);

		IList<Province> FindByName(String name);

		IList<Province> DescendOrderFindByName(String name);

		IList<Province> PaginationFindByName(ProvincePagination obj);

		IList<Province> DescendOrderPaginationFindByName(ProvincePagination obj);

		int FindCountByName(Province obj);

		void Insert(Province obj);

		void Update(Province obj);

		void Delete(Province obj);

		int DeleteByCode(String code);

		int DeleteByName(String name);

		void Reload(Province obj);
	}
}
