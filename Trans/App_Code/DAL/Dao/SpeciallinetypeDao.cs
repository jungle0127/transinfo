using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class SpeciallinetypeDao : ISpeciallinetypeDao
    {
        private ISqlMapper sqlMapper = null;
        public SpeciallinetypeDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Speciallinetype.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Speciallinetype Find(Int64 id) 
        {
			String stmtId = "Speciallinetype.Find";
			Speciallinetype result = this.sqlMapper.QueryForObject<Speciallinetype>(stmtId, id);
			return result;
        }
		public IList<Speciallinetype> FindAll() {
			String stmtId = "Speciallinetype.FindAll";
			IList<Speciallinetype> result = this.sqlMapper.QueryForList<Speciallinetype>(stmtId, null);
			return result;
        }
		public IList<Speciallinetype> PaginationFindAll(SpeciallinetypePagination obj) {
			String stmtId = "Speciallinetype.FindAllPagination";
			IList<Speciallinetype> result = this.sqlMapper.QueryForList<Speciallinetype>(stmtId, obj);
			return result;
        }
		public IList<Speciallinetype> QuickFindAll() {
			String stmtId = "Speciallinetype.QuickFindAll";
			IList<Speciallinetype> result = this.sqlMapper.QueryForList<Speciallinetype>(stmtId, null);
			return result;
        }
		public IList<Speciallinetype> FindByTypename(String typename) {
			String stmtId = "Speciallinetype.FindByTypename";
			IList<Speciallinetype> result = this.sqlMapper.QueryForList<Speciallinetype>(stmtId, typename);
			return result;
        }
		public IList<Speciallinetype> PaginationFindByTypename(SpeciallinetypePagination obj) {
			String stmtId = "SpeciallinetypePagination.FindByTypename";
			IList<Speciallinetype> result = this.sqlMapper.QueryForList<Speciallinetype>(stmtId, obj);
			return result;
        }
		public void Update(Speciallinetype obj) {
			String stmtId = "Speciallinetype.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Speciallinetype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Speciallinetype.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Speciallinetype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Speciallinetype.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByTypename(String typename) {
			String stmtId = "Speciallinetype.DeleteByTypename";
			int result = this.sqlMapper.Delete(stmtId, typename);
			return result;
        }
		public void Reload(Speciallinetype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Speciallinetype.Find";
			this.sqlMapper.QueryForObject<Speciallinetype>(stmtId, obj, obj);
		}
    }
}
