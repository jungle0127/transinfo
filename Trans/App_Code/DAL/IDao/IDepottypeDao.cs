using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IDepottypeDao
    {
		int GetCount();

		Depottype Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Depottype> FindAll();

		IList<Depottype> DescendOrderFindAll();

		IList<Depottype> PaginationFindAll(DepottypePagination obj);

		IList<Depottype> DescendOrderPaginationFindAll(DepottypePagination obj);

		IList<Depottype> QuickFindAll();

		IList<Depottype> FindByActive(Byte active);

		IList<Depottype> DescendOrderFindByActive(Byte active);

		IList<Depottype> PaginationFindByActive(DepottypePagination obj);

		IList<Depottype> DescendOrderPaginationFindByActive(DepottypePagination obj);

		int FindCountByActive(Depottype obj);

		IList<Depottype> FindByTypename(String typename);

		IList<Depottype> DescendOrderFindByTypename(String typename);

		IList<Depottype> PaginationFindByTypename(DepottypePagination obj);

		IList<Depottype> DescendOrderPaginationFindByTypename(DepottypePagination obj);

		int FindCountByTypename(Depottype obj);

		void Insert(Depottype obj);

		void Update(Depottype obj);

		void Delete(Depottype obj);

		int DeleteByActive(Byte active);

		int DeleteByTypename(String typename);

		void Reload(Depottype obj);
	}
}
