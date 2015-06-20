using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class DeparturetypeDao : IDeparturetypeDao
    {
        private ISqlMapper sqlMapper = null;
        public DeparturetypeDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Departuretype.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Departuretype Find(Int64 id) 
        {
			String stmtId = "Departuretype.Find";
			Departuretype result = this.sqlMapper.QueryForObject<Departuretype>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Departuretype.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Departuretype> FindAll() {
			String stmtId = "Departuretype.FindAll";
			IList<Departuretype> result = this.sqlMapper.QueryForList<Departuretype>(stmtId, null);
			return result;
        }
		public IList<Departuretype> PaginationFindAll(DeparturetypePagination obj) {
			String stmtId = "Departuretype.FindAllPagination";
			IList<Departuretype> result = this.sqlMapper.QueryForList<Departuretype>(stmtId, obj);
			return result;
        }
		public IList<Departuretype> QuickFindAll() {
			String stmtId = "Departuretype.QuickFindAll";
			IList<Departuretype> result = this.sqlMapper.QueryForList<Departuretype>(stmtId, null);
			return result;
        }
		public IList<Departuretype> FindByTypename(String typename) {
			String stmtId = "Departuretype.FindByTypename";
			IList<Departuretype> result = this.sqlMapper.QueryForList<Departuretype>(stmtId, typename);
			return result;
        }
		public IList<Departuretype> PaginationFindByTypename(DeparturetypePagination obj) {
			String stmtId = "DeparturetypePagination.FindByTypename";
			IList<Departuretype> result = this.sqlMapper.QueryForList<Departuretype>(stmtId, obj);
			return result;
        }
		public int FindCountByTypename(Departuretype obj){
			String stmtId = "Departuretype.GetFindByTypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Departuretype obj) {
			String stmtId = "Departuretype.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Departuretype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Departuretype.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Departuretype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Departuretype.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByTypename(String typename) {
			String stmtId = "Departuretype.DeleteByTypename";
			int result = this.sqlMapper.Delete(stmtId, typename);
			return result;
        }
		public void Reload(Departuretype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Departuretype.Find";
			this.sqlMapper.QueryForObject<Departuretype>(stmtId, obj, obj);
		}
    }
}
