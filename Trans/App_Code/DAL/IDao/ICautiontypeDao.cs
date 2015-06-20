using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ICautiontypeDao
    {
		int GetCount();

		Cautiontype Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Cautiontype> FindAll();

		IList<Cautiontype> PaginationFindAll(CautiontypePagination obj);

		IList<Cautiontype> QuickFindAll();

		IList<Cautiontype> FindByTypename(String typename);

		IList<Cautiontype> PaginationFindByTypename(CautiontypePagination obj);

		int FindCountByTypename(Cautiontype obj);

		void Insert(Cautiontype obj);

		void Update(Cautiontype obj);

		void Delete(Cautiontype obj);

		int DeleteByTypename(String typename);

		void Reload(Cautiontype obj);
	}
}
