using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IArticletypeDao
    {
		int GetCount();

		Articletype Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Articletype> FindAll();

		IList<Articletype> DescendOrderFindAll();

		IList<Articletype> PaginationFindAll(ArticletypePagination obj);

		IList<Articletype> DescendOrderPaginationFindAll(ArticletypePagination obj);

		IList<Articletype> QuickFindAll();

		IList<Articletype> FindByActive(Byte active);

		IList<Articletype> DescendOrderFindByActive(Byte active);

		IList<Articletype> PaginationFindByActive(ArticletypePagination obj);

		IList<Articletype> DescendOrderPaginationFindByActive(ArticletypePagination obj);

		int FindCountByActive(Articletype obj);

		IList<Articletype> FindByTypename(String typename);

		IList<Articletype> DescendOrderFindByTypename(String typename);

		IList<Articletype> PaginationFindByTypename(ArticletypePagination obj);

		IList<Articletype> DescendOrderPaginationFindByTypename(ArticletypePagination obj);

		int FindCountByTypename(Articletype obj);

		void Insert(Articletype obj);

		void Update(Articletype obj);

		void Delete(Articletype obj);

		int DeleteByActive(Byte active);

		int DeleteByTypename(String typename);

		void Reload(Articletype obj);
	}
}
