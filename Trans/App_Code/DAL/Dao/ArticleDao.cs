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
		public int GetFindCount(Int64 id) {
			String stmtId = "Article.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Article> FindAll() {
			String stmtId = "Article.FindAll";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, null);
			return result;
        }
		public IList<Article> DescendOrderFindAll() {
			String stmtId = "Article.DescendOrderFindAll";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, null);
			return result;
        }
		public IList<Article> PaginationFindAll(ArticlePagination obj) {
			String stmtId = "Article.FindAllPagination";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> DescendOrderPaginationFindAll(ArticlePagination obj) {
			String stmtId = "Article.DescendOrderFindAllPagination";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> QuickFindAll() {
			String stmtId = "Article.QuickFindAll";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, null);
			return result;
        }
		public IList<Article> FindByUserid(Int64 userid) {
			String stmtId = "Article.FindByUserid";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, userid);
			return result;
        }
		public IList<Article> DescendOrderFindByUserid(Int64 userid) {
			String stmtId = "Article.DescendOrderFindByUserid";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, userid);
			return result;
        }
		public IList<Article> PaginationFindByUserid(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByUserid";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> DescendOrderPaginationFindByUserid(ArticlePagination obj) {
			String stmtId = "ArticlePagination.DescendOrderFindByUserid";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public int FindCountByUserid(Article obj){
			String stmtId = "Article.GetFindByUseridCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Article> FindByTitle(String title) {
			String stmtId = "Article.FindByTitle";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, title);
			return result;
        }
		public IList<Article> DescendOrderFindByTitle(String title) {
			String stmtId = "Article.DescendOrderFindByTitle";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, title);
			return result;
        }
		public IList<Article> PaginationFindByTitle(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByTitle";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> DescendOrderPaginationFindByTitle(ArticlePagination obj) {
			String stmtId = "ArticlePagination.DescendOrderFindByTitle";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public int FindCountByTitle(Article obj){
			String stmtId = "Article.GetFindByTitleCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Article> FindByHittimes(Int64 hittimes) {
			String stmtId = "Article.FindByHittimes";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, hittimes);
			return result;
        }
		public IList<Article> DescendOrderFindByHittimes(Int64 hittimes) {
			String stmtId = "Article.DescendOrderFindByHittimes";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, hittimes);
			return result;
        }
		public IList<Article> PaginationFindByHittimes(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByHittimes";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> DescendOrderPaginationFindByHittimes(ArticlePagination obj) {
			String stmtId = "ArticlePagination.DescendOrderFindByHittimes";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public int FindCountByHittimes(Article obj){
			String stmtId = "Article.GetFindByHittimesCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Article> FindByTitlecolor(String titlecolor) {
			String stmtId = "Article.FindByTitlecolor";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, titlecolor);
			return result;
        }
		public IList<Article> DescendOrderFindByTitlecolor(String titlecolor) {
			String stmtId = "Article.DescendOrderFindByTitlecolor";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, titlecolor);
			return result;
        }
		public IList<Article> PaginationFindByTitlecolor(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByTitlecolor";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> DescendOrderPaginationFindByTitlecolor(ArticlePagination obj) {
			String stmtId = "ArticlePagination.DescendOrderFindByTitlecolor";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public int FindCountByTitlecolor(Article obj){
			String stmtId = "Article.GetFindByTitlecolorCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Article> FindByTypeid(Int64 typeid) {
			String stmtId = "Article.FindByTypeid";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, typeid);
			return result;
        }
		public IList<Article> DescendOrderFindByTypeid(Int64 typeid) {
			String stmtId = "Article.DescendOrderFindByTypeid";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, typeid);
			return result;
        }
		public IList<Article> PaginationFindByTypeid(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByTypeid";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> DescendOrderPaginationFindByTypeid(ArticlePagination obj) {
			String stmtId = "ArticlePagination.DescendOrderFindByTypeid";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public int FindCountByTypeid(Article obj){
			String stmtId = "Article.GetFindByTypeidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Article> FindByIstop(Byte istop) {
			String stmtId = "Article.FindByIstop";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, istop);
			return result;
        }
		public IList<Article> DescendOrderFindByIstop(Byte istop) {
			String stmtId = "Article.DescendOrderFindByIstop";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, istop);
			return result;
        }
		public IList<Article> PaginationFindByIstop(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByIstop";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> DescendOrderPaginationFindByIstop(ArticlePagination obj) {
			String stmtId = "ArticlePagination.DescendOrderFindByIstop";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public int FindCountByIstop(Article obj){
			String stmtId = "Article.GetFindByIstopCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Article> FindByContent(String content) {
			String stmtId = "Article.FindByContent";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, content);
			return result;
        }
		public IList<Article> DescendOrderFindByContent(String content) {
			String stmtId = "Article.DescendOrderFindByContent";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, content);
			return result;
        }
		public IList<Article> PaginationFindByContent(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByContent";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> DescendOrderPaginationFindByContent(ArticlePagination obj) {
			String stmtId = "ArticlePagination.DescendOrderFindByContent";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public int FindCountByContent(Article obj){
			String stmtId = "Article.GetFindByContentCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Article> FindByReleaseip(String releaseip) {
			String stmtId = "Article.FindByReleaseip";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, releaseip);
			return result;
        }
		public IList<Article> DescendOrderFindByReleaseip(String releaseip) {
			String stmtId = "Article.DescendOrderFindByReleaseip";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, releaseip);
			return result;
        }
		public IList<Article> PaginationFindByReleaseip(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByReleaseip";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> DescendOrderPaginationFindByReleaseip(ArticlePagination obj) {
			String stmtId = "ArticlePagination.DescendOrderFindByReleaseip";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public int FindCountByReleaseip(Article obj){
			String stmtId = "Article.GetFindByReleaseipCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Article> FindByReleasedate(DateTime releasedate) {
			String stmtId = "Article.FindByReleasedate";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, releasedate);
			return result;
        }
		public IList<Article> DescendOrderFindByReleasedate(DateTime releasedate) {
			String stmtId = "Article.DescendOrderFindByReleasedate";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, releasedate);
			return result;
        }
		public IList<Article> PaginationFindByReleasedate(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByReleasedate";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> DescendOrderPaginationFindByReleasedate(ArticlePagination obj) {
			String stmtId = "ArticlePagination.DescendOrderFindByReleasedate";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public int FindCountByReleasedate(Article obj){
			String stmtId = "Article.GetFindByReleasedateCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Article> FindByIspass(Byte ispass) {
			String stmtId = "Article.FindByIspass";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, ispass);
			return result;
        }
		public IList<Article> DescendOrderFindByIspass(Byte ispass) {
			String stmtId = "Article.DescendOrderFindByIspass";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, ispass);
			return result;
        }
		public IList<Article> PaginationFindByIspass(ArticlePagination obj) {
			String stmtId = "ArticlePagination.FindByIspass";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public IList<Article> DescendOrderPaginationFindByIspass(ArticlePagination obj) {
			String stmtId = "ArticlePagination.DescendOrderFindByIspass";
			IList<Article> result = this.sqlMapper.QueryForList<Article>(stmtId, obj);
			return result;
        }
		public int FindCountByIspass(Article obj){
			String stmtId = "Article.GetFindByIspassCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
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
		public int DeleteByIstop(Byte istop) {
			String stmtId = "Article.DeleteByIstop";
			int result = this.sqlMapper.Delete(stmtId, istop);
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
		public int DeleteByReleasedate(DateTime releasedate) {
			String stmtId = "Article.DeleteByReleasedate";
			int result = this.sqlMapper.Delete(stmtId, releasedate);
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
