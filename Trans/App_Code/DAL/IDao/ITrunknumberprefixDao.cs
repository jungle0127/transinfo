using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ITrunknumberprefixDao
    {
		int GetCount();

		Trunknumberprefix Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Trunknumberprefix> FindAll();

		IList<Trunknumberprefix> PaginationFindAll(TrunknumberprefixPagination obj);

		IList<Trunknumberprefix> QuickFindAll();

		IList<Trunknumberprefix> FindByPrefixname(String prefixname);

		IList<Trunknumberprefix> PaginationFindByPrefixname(TrunknumberprefixPagination obj);

		int FindCountByPrefixname(Trunknumberprefix obj);

		void Insert(Trunknumberprefix obj);

		void Update(Trunknumberprefix obj);

		void Delete(Trunknumberprefix obj);

		int DeleteByPrefixname(String prefixname);

		void Reload(Trunknumberprefix obj);
	}
}
