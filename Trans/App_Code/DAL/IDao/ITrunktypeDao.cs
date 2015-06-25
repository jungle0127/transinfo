using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ITrunktypeDao
    {
		int GetCount();

		Trunktype Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Trunktype> FindAll();

		IList<Trunktype> DescendOrderFindAll();

		IList<Trunktype> PaginationFindAll(TrunktypePagination obj);

		IList<Trunktype> DescendOrderPaginationFindAll(TrunktypePagination obj);

		IList<Trunktype> QuickFindAll();

		IList<Trunktype> FindByTypename(String typename);

		IList<Trunktype> DescendOrderFindByTypename(String typename);

		IList<Trunktype> PaginationFindByTypename(TrunktypePagination obj);

		IList<Trunktype> DescendOrderPaginationFindByTypename(TrunktypePagination obj);

		int FindCountByTypename(Trunktype obj);

		void Insert(Trunktype obj);

		void Update(Trunktype obj);

		void Delete(Trunktype obj);

		int DeleteByTypename(String typename);

		void Reload(Trunktype obj);
	}
}
