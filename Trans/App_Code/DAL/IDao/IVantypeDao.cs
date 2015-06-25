using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IVantypeDao
    {
		int GetCount();

		Vantype Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Vantype> FindAll();

		IList<Vantype> DescendOrderFindAll();

		IList<Vantype> PaginationFindAll(VantypePagination obj);

		IList<Vantype> DescendOrderPaginationFindAll(VantypePagination obj);

		IList<Vantype> QuickFindAll();

		IList<Vantype> FindByTypename(String typename);

		IList<Vantype> DescendOrderFindByTypename(String typename);

		IList<Vantype> PaginationFindByTypename(VantypePagination obj);

		IList<Vantype> DescendOrderPaginationFindByTypename(VantypePagination obj);

		int FindCountByTypename(Vantype obj);

		void Reload(Vantype obj);
	}
}
