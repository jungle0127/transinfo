using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IRightgroupDao
    {
		int GetCount();

		Rightgroup Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Rightgroup> FindAll();

		IList<Rightgroup> PaginationFindAll(RightgroupPagination obj);

		IList<Rightgroup> QuickFindAll();

		IList<Rightgroup> FindByActive(Byte active);

		IList<Rightgroup> PaginationFindByActive(RightgroupPagination obj);

		int FindCountByActive(Rightgroup obj);

		IList<Rightgroup> FindByGroupname(String groupname);

		IList<Rightgroup> PaginationFindByGroupname(RightgroupPagination obj);

		int FindCountByGroupname(Rightgroup obj);

		void Insert(Rightgroup obj);

		void Update(Rightgroup obj);

		void Delete(Rightgroup obj);

		int DeleteByActive(Byte active);

		int DeleteByGroupname(String groupname);

		void Reload(Rightgroup obj);
	}
}
