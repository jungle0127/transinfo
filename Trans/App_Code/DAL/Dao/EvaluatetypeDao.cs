using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class EvaluatetypeDao : IEvaluatetypeDao
    {
        private ISqlMapper sqlMapper = null;
        public EvaluatetypeDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Evaluatetype.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Evaluatetype Find(Int64 id) 
        {
			String stmtId = "Evaluatetype.Find";
			Evaluatetype result = this.sqlMapper.QueryForObject<Evaluatetype>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Evaluatetype.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Evaluatetype> FindAll() {
			String stmtId = "Evaluatetype.FindAll";
			IList<Evaluatetype> result = this.sqlMapper.QueryForList<Evaluatetype>(stmtId, null);
			return result;
        }
		public IList<Evaluatetype> DescendOrderFindAll() {
			String stmtId = "Evaluatetype.DescendOrderFindAll";
			IList<Evaluatetype> result = this.sqlMapper.QueryForList<Evaluatetype>(stmtId, null);
			return result;
        }
		public IList<Evaluatetype> PaginationFindAll(EvaluatetypePagination obj) {
			String stmtId = "Evaluatetype.FindAllPagination";
			IList<Evaluatetype> result = this.sqlMapper.QueryForList<Evaluatetype>(stmtId, obj);
			return result;
        }
		public IList<Evaluatetype> DescendOrderPaginationFindAll(EvaluatetypePagination obj) {
			String stmtId = "Evaluatetype.DescendOrderFindAllPagination";
			IList<Evaluatetype> result = this.sqlMapper.QueryForList<Evaluatetype>(stmtId, obj);
			return result;
        }
		public IList<Evaluatetype> QuickFindAll() {
			String stmtId = "Evaluatetype.QuickFindAll";
			IList<Evaluatetype> result = this.sqlMapper.QueryForList<Evaluatetype>(stmtId, null);
			return result;
        }
		public IList<Evaluatetype> FindByActive(Byte active) {
			String stmtId = "Evaluatetype.FindByActive";
			IList<Evaluatetype> result = this.sqlMapper.QueryForList<Evaluatetype>(stmtId, active);
			return result;
        }
		public IList<Evaluatetype> DescendOrderFindByActive(Byte active) {
			String stmtId = "Evaluatetype.DescendOrderFindByActive";
			IList<Evaluatetype> result = this.sqlMapper.QueryForList<Evaluatetype>(stmtId, active);
			return result;
        }
		public IList<Evaluatetype> PaginationFindByActive(EvaluatetypePagination obj) {
			String stmtId = "EvaluatetypePagination.FindByActive";
			IList<Evaluatetype> result = this.sqlMapper.QueryForList<Evaluatetype>(stmtId, obj);
			return result;
        }
		public IList<Evaluatetype> DescendOrderPaginationFindByActive(EvaluatetypePagination obj) {
			String stmtId = "EvaluatetypePagination.DescendOrderFindByActive";
			IList<Evaluatetype> result = this.sqlMapper.QueryForList<Evaluatetype>(stmtId, obj);
			return result;
        }
		public int FindCountByActive(Evaluatetype obj){
			String stmtId = "Evaluatetype.GetFindByActiveCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Evaluatetype> FindByName(String name) {
			String stmtId = "Evaluatetype.FindByName";
			IList<Evaluatetype> result = this.sqlMapper.QueryForList<Evaluatetype>(stmtId, name);
			return result;
        }
		public IList<Evaluatetype> DescendOrderFindByName(String name) {
			String stmtId = "Evaluatetype.DescendOrderFindByName";
			IList<Evaluatetype> result = this.sqlMapper.QueryForList<Evaluatetype>(stmtId, name);
			return result;
        }
		public IList<Evaluatetype> PaginationFindByName(EvaluatetypePagination obj) {
			String stmtId = "EvaluatetypePagination.FindByName";
			IList<Evaluatetype> result = this.sqlMapper.QueryForList<Evaluatetype>(stmtId, obj);
			return result;
        }
		public IList<Evaluatetype> DescendOrderPaginationFindByName(EvaluatetypePagination obj) {
			String stmtId = "EvaluatetypePagination.DescendOrderFindByName";
			IList<Evaluatetype> result = this.sqlMapper.QueryForList<Evaluatetype>(stmtId, obj);
			return result;
        }
		public int FindCountByName(Evaluatetype obj){
			String stmtId = "Evaluatetype.GetFindByNameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Evaluatetype obj) {
			String stmtId = "Evaluatetype.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Evaluatetype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Evaluatetype.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Evaluatetype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Evaluatetype.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByActive(Byte active) {
			String stmtId = "Evaluatetype.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public int DeleteByName(String name) {
			String stmtId = "Evaluatetype.DeleteByName";
			int result = this.sqlMapper.Delete(stmtId, name);
			return result;
        }
		public void Reload(Evaluatetype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Evaluatetype.Find";
			this.sqlMapper.QueryForObject<Evaluatetype>(stmtId, obj, obj);
		}
    }
}
