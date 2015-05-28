using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class ArticleDao : IArticleDao
    {
        private ISqlMapper sqlMapper = null;
        public ArticleDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Article.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Article Find(Int64 id) 
        {
			String stmtId = "Article.Find";
			Article result = this.sqlMapper.QueryForObject<Article>(stmtId, id);
			return result;
        }
		public IList<Article> FindAll() {
			String stmtId = "Article.FindAll";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, null);
			return result;
        }
		public IList<Article> PaginationFindAll(ArticlePagination obj) {
			String stmtId = "Article.FindAllPagination";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> QuickFindAll() {
			String stmtId = "Article.QuickFindAll";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, null);
			return result;
        }
		public IList<Article> FindByReleasedate(DateTime releasedate) {
			String stmtId = "Article.FindByReleasedate";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, releasedate);
			return result;
        }
		public IList<Article> PaginationFindByReleasedate(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByReleasedate";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> FindByUserid(Int64 userid) {
			String stmtId = "Article.FindByUserid";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, userid);
			return result;
        }
		public IList<Article> PaginationFindByUserid(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByUserid";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> FindByTitle(String title) {
			String stmtId = "Article.FindByTitle";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, title);
			return result;
        }
		public IList<Article> PaginationFindByTitle(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByTitle";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> FindByHittimes(Int64 hittimes) {
			String stmtId = "Article.FindByHittimes";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, hittimes);
			return result;
        }
		public IList<Article> PaginationFindByHittimes(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByHittimes";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> FindByTitlecolor(String titlecolor) {
			String stmtId = "Article.FindByTitlecolor";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, titlecolor);
			return result;
        }
		public IList<Article> PaginationFindByTitlecolor(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByTitlecolor";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> FindByTypeid(Int64 typeid) {
			String stmtId = "Article.FindByTypeid";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, typeid);
			return result;
        }
		public IList<Article> PaginationFindByTypeid(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByTypeid";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> FindByContent(String content) {
			String stmtId = "Article.FindByContent";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, content);
			return result;
        }
		public IList<Article> PaginationFindByContent(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByContent";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> FindByReleaseip(String releaseip) {
			String stmtId = "Article.FindByReleaseip";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, releaseip);
			return result;
        }
		public IList<Article> PaginationFindByReleaseip(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByReleaseip";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> FindByIstop(Byte istop) {
			String stmtId = "Article.FindByIstop";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, istop);
			return result;
        }
		public IList<Article> PaginationFindByIstop(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByIstop";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> FindByIspass(Byte ispass) {
			String stmtId = "Article.FindByIspass";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, ispass);
			return result;
        }
		public IList<Article> PaginationFindByIspass(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByIspass";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public void Update(Article obj) {
			String stmtId = "Article.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Article obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Article.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Article obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Article.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByReleasedate(DateTime releasedate) {
			String stmtId = "Article.DeleteByReleasedate";
			int result = this.sqlMapper.Delete(stmtId, releasedate);
			return result;
        }
		public int DeleteByUserid(Int64 userid) {
			String stmtId = "Article.DeleteByUserid";
			int result = this.sqlMapper.Delete(stmtId, userid);
			return result;
        }
		public int DeleteByTitle(String title) {
			String stmtId = "Article.DeleteByTitle";
			int result = this.sqlMapper.Delete(stmtId, title);
			return result;
        }
		public int DeleteByHittimes(Int64 hittimes) {
			String stmtId = "Article.DeleteByHittimes";
			int result = this.sqlMapper.Delete(stmtId, hittimes);
			return result;
        }
		public int DeleteByTitlecolor(String titlecolor) {
			String stmtId = "Article.DeleteByTitlecolor";
			int result = this.sqlMapper.Delete(stmtId, titlecolor);
			return result;
        }
		public int DeleteByTypeid(Int64 typeid) {
			String stmtId = "Article.DeleteByTypeid";
			int result = this.sqlMapper.Delete(stmtId, typeid);
			return result;
        }
		public int DeleteByContent(String content) {
			String stmtId = "Article.DeleteByContent";
			int result = this.sqlMapper.Delete(stmtId, content);
			return result;
        }
		public int DeleteByReleaseip(String releaseip) {
			String stmtId = "Article.DeleteByReleaseip";
			int result = this.sqlMapper.Delete(stmtId, releaseip);
			return result;
        }
		public int DeleteByIstop(Byte istop) {
			String stmtId = "Article.DeleteByIstop";
			int result = this.sqlMapper.Delete(stmtId, istop);
			return result;
        }
		public int DeleteByIspass(Byte ispass) {
			String stmtId = "Article.DeleteByIspass";
			int result = this.sqlMapper.Delete(stmtId, ispass);
			return result;
        }
		public void Reload(Article obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Article.Find";
			this.sqlMapper.QueryForObject<Article>(stmtId, obj, obj);
		}
    }
}
