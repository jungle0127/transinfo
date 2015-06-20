using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IDeparturetypeDao
    {
		int GetCount();

		Departuretype Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Departuretype> FindAll();

		IList<Departuretype> PaginationFindAll(DeparturetypePagination obj);

		IList<Departuretype> QuickFindAll();

		IList<Departuretype> FindByTypename(String typename);

		IList<Departuretype> PaginationFindByTypename(DeparturetypePagination obj);

		int FindCountByTypename(Departuretype obj);

		void Insert(Departuretype obj);

		void Update(Departuretype obj);

		void Delete(Departuretype obj);

		int DeleteByTypename(String typename);

		void Reload(Departuretype obj);
	}
}
