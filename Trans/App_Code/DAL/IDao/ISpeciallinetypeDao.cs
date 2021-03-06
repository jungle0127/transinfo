using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ISpeciallinetypeDao
    {
		int GetCount();

		Speciallinetype Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Speciallinetype> FindAll();

		IList<Speciallinetype> DescendOrderFindAll();

		IList<Speciallinetype> PaginationFindAll(SpeciallinetypePagination obj);

		IList<Speciallinetype> DescendOrderPaginationFindAll(SpeciallinetypePagination obj);

		IList<Speciallinetype> QuickFindAll();

		IList<Speciallinetype> FindByTypename(String typename);

		IList<Speciallinetype> DescendOrderFindByTypename(String typename);

		IList<Speciallinetype> PaginationFindByTypename(SpeciallinetypePagination obj);

		IList<Speciallinetype> DescendOrderPaginationFindByTypename(SpeciallinetypePagination obj);

		int FindCountByTypename(Speciallinetype obj);

		void Insert(Speciallinetype obj);

		void Update(Speciallinetype obj);

		void Delete(Speciallinetype obj);

		int DeleteByTypename(String typename);

		void Reload(Speciallinetype obj);
	}
}
