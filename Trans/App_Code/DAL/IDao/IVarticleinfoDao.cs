using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IVarticleinfoDao
    {
		int GetCount();

		IList<Varticleinfo> FindAll();

		IList<Varticleinfo> DescendOrderFindAll();

		IList<Varticleinfo> PaginationFindAll(VarticleinfoPagination obj);

		IList<Varticleinfo> DescendOrderPaginationFindAll(VarticleinfoPagination obj);

		IList<Varticleinfo> QuickFindAll();

		IList<Varticleinfo> FindByTitle(String title);

		IList<Varticleinfo> DescendOrderFindByTitle(String title);

		IList<Varticleinfo> PaginationFindByTitle(VarticleinfoPagination obj);

		IList<Varticleinfo> DescendOrderPaginationFindByTitle(VarticleinfoPagination obj);

		int FindCountByTitle(Varticleinfo obj);

		IList<Varticleinfo> FindByHittimes(Int64 hittimes);

		IList<Varticleinfo> DescendOrderFindByHittimes(Int64 hittimes);

		IList<Varticleinfo> PaginationFindByHittimes(VarticleinfoPagination obj);

		IList<Varticleinfo> DescendOrderPaginationFindByHittimes(VarticleinfoPagination obj);

		int FindCountByHittimes(Varticleinfo obj);

		IList<Varticleinfo> FindByUsername(String username);

		IList<Varticleinfo> DescendOrderFindByUsername(String username);

		IList<Varticleinfo> PaginationFindByUsername(VarticleinfoPagination obj);

		IList<Varticleinfo> DescendOrderPaginationFindByUsername(VarticleinfoPagination obj);

		int FindCountByUsername(Varticleinfo obj);

		IList<Varticleinfo> FindById(Int64 id);

		IList<Varticleinfo> DescendOrderFindById(Int64 id);

		IList<Varticleinfo> PaginationFindById(VarticleinfoPagination obj);

		IList<Varticleinfo> DescendOrderPaginationFindById(VarticleinfoPagination obj);

		int FindCountById(Varticleinfo obj);

		IList<Varticleinfo> FindByTitlecolor(String titlecolor);

		IList<Varticleinfo> DescendOrderFindByTitlecolor(String titlecolor);

		IList<Varticleinfo> PaginationFindByTitlecolor(VarticleinfoPagination obj);

		IList<Varticleinfo> DescendOrderPaginationFindByTitlecolor(VarticleinfoPagination obj);

		int FindCountByTitlecolor(Varticleinfo obj);

		IList<Varticleinfo> FindByTypeid(Int64 typeid);

		IList<Varticleinfo> DescendOrderFindByTypeid(Int64 typeid);

		IList<Varticleinfo> PaginationFindByTypeid(VarticleinfoPagination obj);

		IList<Varticleinfo> DescendOrderPaginationFindByTypeid(VarticleinfoPagination obj);

		int FindCountByTypeid(Varticleinfo obj);

		IList<Varticleinfo> FindByContent(String content);

		IList<Varticleinfo> DescendOrderFindByContent(String content);

		IList<Varticleinfo> PaginationFindByContent(VarticleinfoPagination obj);

		IList<Varticleinfo> DescendOrderPaginationFindByContent(VarticleinfoPagination obj);

		int FindCountByContent(Varticleinfo obj);

		IList<Varticleinfo> FindByReleaseip(String releaseip);

		IList<Varticleinfo> DescendOrderFindByReleaseip(String releaseip);

		IList<Varticleinfo> PaginationFindByReleaseip(VarticleinfoPagination obj);

		IList<Varticleinfo> DescendOrderPaginationFindByReleaseip(VarticleinfoPagination obj);

		int FindCountByReleaseip(Varticleinfo obj);

		IList<Varticleinfo> FindByReleasedate(DateTime releasedate);

		IList<Varticleinfo> DescendOrderFindByReleasedate(DateTime releasedate);

		IList<Varticleinfo> PaginationFindByReleasedate(VarticleinfoPagination obj);

		IList<Varticleinfo> DescendOrderPaginationFindByReleasedate(VarticleinfoPagination obj);

		int FindCountByReleasedate(Varticleinfo obj);

		void Reload(Varticleinfo obj);
	}
}
