using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ITrunktimetypeDao
    {
		int GetCount();

		Trunktimetype Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Trunktimetype> FindAll();

		IList<Trunktimetype> PaginationFindAll(TrunktimetypePagination obj);

		IList<Trunktimetype> QuickFindAll();

		IList<Trunktimetype> FindByTypename(String typename);

		IList<Trunktimetype> PaginationFindByTypename(TrunktimetypePagination obj);

		int FindCountByTypename(Trunktimetype obj);

		void Insert(Trunktimetype obj);

		void Update(Trunktimetype obj);

		void Delete(Trunktimetype obj);

		int DeleteByTypename(String typename);

		void Reload(Trunktimetype obj);
	}
}
