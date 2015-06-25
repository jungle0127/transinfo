using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IArticleDao
    {
		int GetCount();

		Article Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Article> FindAll();

		IList<Article> DescendOrderFindAll();

		IList<Article> PaginationFindAll(ArticlePagination obj);

		IList<Article> DescendOrderPaginationFindAll(ArticlePagination obj);

		IList<Article> QuickFindAll();

		IList<Article> FindByUserid(Int64 userid);

		IList<Article> DescendOrderFindByUserid(Int64 userid);

		IList<Article> PaginationFindByUserid(ArticlePagination obj);

		IList<Article> DescendOrderPaginationFindByUserid(ArticlePagination obj);

		int FindCountByUserid(Article obj);

		IList<Article> FindByTitle(String title);

		IList<Article> DescendOrderFindByTitle(String title);

		IList<Article> PaginationFindByTitle(ArticlePagination obj);

		IList<Article> DescendOrderPaginationFindByTitle(ArticlePagination obj);

		int FindCountByTitle(Article obj);

		IList<Article> FindByHittimes(Int64 hittimes);

		IList<Article> DescendOrderFindByHittimes(Int64 hittimes);

		IList<Article> PaginationFindByHittimes(ArticlePagination obj);

		IList<Article> DescendOrderPaginationFindByHittimes(ArticlePagination obj);

		int FindCountByHittimes(Article obj);

		IList<Article> FindByTitlecolor(String titlecolor);

		IList<Article> DescendOrderFindByTitlecolor(String titlecolor);

		IList<Article> PaginationFindByTitlecolor(ArticlePagination obj);

		IList<Article> DescendOrderPaginationFindByTitlecolor(ArticlePagination obj);

		int FindCountByTitlecolor(Article obj);

		IList<Article> FindByTypeid(Int64 typeid);

		IList<Article> DescendOrderFindByTypeid(Int64 typeid);

		IList<Article> PaginationFindByTypeid(ArticlePagination obj);

		IList<Article> DescendOrderPaginationFindByTypeid(ArticlePagination obj);

		int FindCountByTypeid(Article obj);

		IList<Article> FindByIstop(Byte istop);

		IList<Article> DescendOrderFindByIstop(Byte istop);

		IList<Article> PaginationFindByIstop(ArticlePagination obj);

		IList<Article> DescendOrderPaginationFindByIstop(ArticlePagination obj);

		int FindCountByIstop(Article obj);

		IList<Article> FindByContent(String content);

		IList<Article> DescendOrderFindByContent(String content);

		IList<Article> PaginationFindByContent(ArticlePagination obj);

		IList<Article> DescendOrderPaginationFindByContent(ArticlePagination obj);

		int FindCountByContent(Article obj);

		IList<Article> FindByReleaseip(String releaseip);

		IList<Article> DescendOrderFindByReleaseip(String releaseip);

		IList<Article> PaginationFindByReleaseip(ArticlePagination obj);

		IList<Article> DescendOrderPaginationFindByReleaseip(ArticlePagination obj);

		int FindCountByReleaseip(Article obj);

		IList<Article> FindByReleasedate(DateTime releasedate);

		IList<Article> DescendOrderFindByReleasedate(DateTime releasedate);

		IList<Article> PaginationFindByReleasedate(ArticlePagination obj);

		IList<Article> DescendOrderPaginationFindByReleasedate(ArticlePagination obj);

		int FindCountByReleasedate(Article obj);

		IList<Article> FindByIspass(Byte ispass);

		IList<Article> DescendOrderFindByIspass(Byte ispass);

		IList<Article> PaginationFindByIspass(ArticlePagination obj);

		IList<Article> DescendOrderPaginationFindByIspass(ArticlePagination obj);

		int FindCountByIspass(Article obj);

		void Insert(Article obj);

		void Update(Article obj);

		void Delete(Article obj);

		int DeleteByUserid(Int64 userid);

		int DeleteByTitle(String title);

		int DeleteByHittimes(Int64 hittimes);

		int DeleteByTitlecolor(String titlecolor);

		int DeleteByTypeid(Int64 typeid);

		int DeleteByIstop(Byte istop);

		int DeleteByContent(String content);

		int DeleteByReleaseip(String releaseip);

		int DeleteByReleasedate(DateTime releasedate);

		int DeleteByIspass(Byte ispass);

		void Reload(Article obj);
	}
}
