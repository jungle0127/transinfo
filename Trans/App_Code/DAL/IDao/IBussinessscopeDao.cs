using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IBussinessscopeDao
    {
		int GetCount();

		Bussinessscope Find(Int64 id);

		IList<Bussinessscope> FindAll();

		IList<Bussinessscope> PaginationFindAll(BussinessscopePagination obj);

		IList<Bussinessscope> QuickFindAll();

		IList<Bussinessscope> FindByScopename(String scopename);

		IList<Bussinessscope> PaginationFindByScopename(BussinessscopePagination obj);

		IList<Bussinessscope> FindByActive(Byte active);

		IList<Bussinessscope> PaginationFindByActive(BussinessscopePagination obj);

		void Insert(Bussinessscope obj);

		void Update(Bussinessscope obj);

		void Delete(Bussinessscope obj);

		int DeleteByScopename(String scopename);

		int DeleteByActive(Byte active);

		void Reload(Bussinessscope obj);
	}
}
