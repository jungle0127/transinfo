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

		IList<Article> FindAll();

		IList<Article> PaginationFindAll(ArticlePagination obj);

		IList<Article> QuickFindAll();

		IList<Article> FindByUserid(Int64 userid);

		IList<Article> PaginationFindByUserid(ArticlePagination obj);

		IList<Article> FindByTitle(String title);

		IList<Article> PaginationFindByTitle(ArticlePagination obj);

		IList<Article> FindByHittimes(Int64 hittimes);

		IList<Article> PaginationFindByHittimes(ArticlePagination obj);

		IList<Article> FindByTitlecolor(String titlecolor);

		IList<Article> PaginationFindByTitlecolor(ArticlePagination obj);

		IList<Article> FindByTypeid(Int64 typeid);

		IList<Article> PaginationFindByTypeid(ArticlePagination obj);

		IList<Article> FindByIstop(Byte istop);

		IList<Article> PaginationFindByIstop(ArticlePagination obj);

		IList<Article> FindByContent(String content);

		IList<Article> PaginationFindByContent(ArticlePagination obj);

		IList<Article> FindByReleaseip(String releaseip);

		IList<Article> PaginationFindByReleaseip(ArticlePagination obj);

		IList<Article> FindByReleasedate(DateTime releasedate);

		IList<Article> PaginationFindByReleasedate(ArticlePagination obj);

		IList<Article> FindByIspass(Byte ispass);

		IList<Article> PaginationFindByIspass(ArticlePagination obj);

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
