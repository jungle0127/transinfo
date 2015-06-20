using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class ArticletypeDao : IArticletypeDao
    {
        private ISqlMapper sqlMapper = null;
        public ArticletypeDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Articletype.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Articletype Find(Int64 id) 
        {
			String stmtId = "Articletype.Find";
			Articletype result = this.sqlMapper.QueryForObject<Articletype>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Articletype.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Articletype> FindAll() {
			String stmtId = "Articletype.FindAll";
			IList<Articletype> result = this.sqlMapper.QueryForList<Articletype>(stmtId, null);
			return result;
        }
		public IList<Articletype> PaginationFindAll(ArticletypePagination obj) {
			String stmtId = "Articletype.FindAllPagination";
			IList<Articletype> result = this.sqlMapper.QueryForList<Articletype>(stmtId, obj);
			return result;
        }
		public IList<Articletype> QuickFindAll() {
			String stmtId = "Articletype.QuickFindAll";
			IList<Articletype> result = this.sqlMapper.QueryForList<Articletype>(stmtId, null);
			return result;
        }
		public IList<Articletype> FindByActive(Byte active) {
			String stmtId = "Articletype.FindByActive";
			IList<Articletype> result = this.sqlMapper.QueryForList<Articletype>(stmtId, active);
			return result;
        }
		public IList<Articletype> PaginationFindByActive(ArticletypePagination obj) {
			String stmtId = "ArticletypePagination.FindByActive";
			IList<Articletype> result = this.sqlMapper.QueryForList<Articletype>(stmtId, obj);
			return result;
        }
		public int FindCountByActive(Articletype obj){
			String stmtId = "Articletype.GetFindByActiveCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Articletype> FindByTypename(String typename) {
			String stmtId = "Articletype.FindByTypename";
			IList<Articletype> result = this.sqlMapper.QueryForList<Articletype>(stmtId, typename);
			return result;
        }
		public IList<Articletype> PaginationFindByTypename(ArticletypePagination obj) {
			String stmtId = "ArticletypePagination.FindByTypename";
			IList<Articletype> result = this.sqlMapper.QueryForList<Articletype>(stmtId, obj);
			return result;
        }
		public int FindCountByTypename(Articletype obj){
			String stmtId = "Articletype.GetFindByTypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Articletype obj) {
			String stmtId = "Articletype.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Articletype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Articletype.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Articletype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Articletype.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByActive(Byte active) {
			String stmtId = "Articletype.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public int DeleteByTypename(String typename) {
			String stmtId = "Articletype.DeleteByTypename";
			int result = this.sqlMapper.Delete(stmtId, typename);
			return result;
        }
		public void Reload(Articletype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Articletype.Find";
			this.sqlMapper.QueryForObject<Articletype>(stmtId, obj, obj);
		}
    }
}
