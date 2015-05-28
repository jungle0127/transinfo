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

		IList<Trunktype> FindAll();

		IList<Trunktype> PaginationFindAll(TrunktypePagination obj);

		IList<Trunktype> QuickFindAll();

		IList<Trunktype> FindByTypename(String typename);

		IList<Trunktype> PaginationFindByTypename(TrunktypePagination obj);

		void Insert(Trunktype obj);

		void Update(Trunktype obj);

		void Delete(Trunktype obj);

		int DeleteByTypename(String typename);

		void Reload(Trunktype obj);
	}
}
