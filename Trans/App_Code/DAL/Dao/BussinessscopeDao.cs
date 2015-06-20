using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class BussinessscopeDao : IBussinessscopeDao
    {
        private ISqlMapper sqlMapper = null;
        public BussinessscopeDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Bussinessscope.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Bussinessscope Find(Int64 id) 
        {
			String stmtId = "Bussinessscope.Find";
			Bussinessscope result = this.sqlMapper.QueryForObject<Bussinessscope>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Bussinessscope.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Bussinessscope> FindAll() {
			String stmtId = "Bussinessscope.FindAll";
			IList<Bussinessscope> result = this.sqlMapper.QueryForList<Bussinessscope>(stmtId, null);
			return result;
        }
		public IList<Bussinessscope> PaginationFindAll(BussinessscopePagination obj) {
			String stmtId = "Bussinessscope.FindAllPagination";
			IList<Bussinessscope> result = this.sqlMapper.QueryForList<Bussinessscope>(stmtId, obj);
			return result;
        }
		public IList<Bussinessscope> QuickFindAll() {
			String stmtId = "Bussinessscope.QuickFindAll";
			IList<Bussinessscope> result = this.sqlMapper.QueryForList<Bussinessscope>(stmtId, null);
			return result;
        }
		public IList<Bussinessscope> FindByScopename(String scopename) {
			String stmtId = "Bussinessscope.FindByScopename";
			IList<Bussinessscope> result = this.sqlMapper.QueryForList<Bussinessscope>(stmtId, scopename);
			return result;
        }
		public IList<Bussinessscope> PaginationFindByScopename(BussinessscopePagination obj) {
			String stmtId = "BussinessscopePagination.FindByScopename";
			IList<Bussinessscope> result = this.sqlMapper.QueryForList<Bussinessscope>(stmtId, obj);
			return result;
        }
		public int FindCountByScopename(Bussinessscope obj){
			String stmtId = "Bussinessscope.GetFindByScopenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Bussinessscope> FindByActive(Byte active) {
			String stmtId = "Bussinessscope.FindByActive";
			IList<Bussinessscope> result = this.sqlMapper.QueryForList<Bussinessscope>(stmtId, active);
			return result;
        }
		public IList<Bussinessscope> PaginationFindByActive(BussinessscopePagination obj) {
			String stmtId = "BussinessscopePagination.FindByActive";
			IList<Bussinessscope> result = this.sqlMapper.QueryForList<Bussinessscope>(stmtId, obj);
			return result;
        }
		public int FindCountByActive(Bussinessscope obj){
			String stmtId = "Bussinessscope.GetFindByActiveCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Bussinessscope obj) {
			String stmtId = "Bussinessscope.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Bussinessscope obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Bussinessscope.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Bussinessscope obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Bussinessscope.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByScopename(String scopename) {
			String stmtId = "Bussinessscope.DeleteByScopename";
			int result = this.sqlMapper.Delete(stmtId, scopename);
			return result;
        }
		public int DeleteByActive(Byte active) {
			String stmtId = "Bussinessscope.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public void Reload(Bussinessscope obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Bussinessscope.Find";
			this.sqlMapper.QueryForObject<Bussinessscope>(stmtId, obj, obj);
		}
    }
}
