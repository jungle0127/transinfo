using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ITransporttypeDao
    {
		int GetCount();

		Transporttype Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Transporttype> FindAll();

		IList<Transporttype> DescendOrderFindAll();

		IList<Transporttype> PaginationFindAll(TransporttypePagination obj);

		IList<Transporttype> DescendOrderPaginationFindAll(TransporttypePagination obj);

		IList<Transporttype> QuickFindAll();

		IList<Transporttype> FindByTypename(String typename);

		IList<Transporttype> DescendOrderFindByTypename(String typename);

		IList<Transporttype> PaginationFindByTypename(TransporttypePagination obj);

		IList<Transporttype> DescendOrderPaginationFindByTypename(TransporttypePagination obj);

		int FindCountByTypename(Transporttype obj);

		void Insert(Transporttype obj);

		void Update(Transporttype obj);

		void Delete(Transporttype obj);

		int DeleteByTypename(String typename);

		void Reload(Transporttype obj);
	}
}
