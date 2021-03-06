using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IGoodstypeDao
    {
		int GetCount();

		Goodstype Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Goodstype> FindAll();

		IList<Goodstype> DescendOrderFindAll();

		IList<Goodstype> PaginationFindAll(GoodstypePagination obj);

		IList<Goodstype> DescendOrderPaginationFindAll(GoodstypePagination obj);

		IList<Goodstype> QuickFindAll();

		IList<Goodstype> FindByTypename(String typename);

		IList<Goodstype> DescendOrderFindByTypename(String typename);

		IList<Goodstype> PaginationFindByTypename(GoodstypePagination obj);

		IList<Goodstype> DescendOrderPaginationFindByTypename(GoodstypePagination obj);

		int FindCountByTypename(Goodstype obj);

		void Insert(Goodstype obj);

		void Update(Goodstype obj);

		void Delete(Goodstype obj);

		int DeleteByTypename(String typename);

		void Reload(Goodstype obj);
	}
}
