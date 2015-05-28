using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class DepottypeDao : IDepottypeDao
    {
        private ISqlMapper sqlMapper = null;
        public DepottypeDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Depottype.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Depottype Find(Int64 id) 
        {
			String stmtId = "Depottype.Find";
			Depottype result = this.sqlMapper.QueryForObject<Depottype>(stmtId, id);
			return result;
        }
		public IList<Depottype> FindAll() {
			String stmtId = "Depottype.FindAll";
			IList<Depottype> result = this.sqlMapper.QueryForList<Depottype>(stmtId, null);
			return result;
        }
		public IList<Depottype> PaginationFindAll(DepottypePagination obj) {
			String stmtId = "Depottype.FindAllPagination";
			IList<Depottype> result = this.sqlMapper.QueryForList<Depottype>(stmtId, obj);
			return result;
        }
		public IList<Depottype> QuickFindAll() {
			String stmtId = "Depottype.QuickFindAll";
			IList<Depottype> result = this.sqlMapper.QueryForList<Depottype>(stmtId, null);
			return result;
        }
		public IList<Depottype> FindByActive(Byte active) {
			String stmtId = "Depottype.FindByActive";
			IList<Depottype> result = this.sqlMapper.QueryForList<Depottype>(stmtId, active);
			return result;
        }
		public IList<Depottype> PaginationFindByActive(DepottypePagination obj) {
			String stmtId = "DepottypePagination.FindByActive";
			IList<Depottype> result = this.sqlMapper.QueryForList<Depottype>(stmtId, obj);
			return result;
        }
		public IList<Depottype> FindByTypename(String typename) {
			String stmtId = "Depottype.FindByTypename";
			IList<Depottype> result = this.sqlMapper.QueryForList<Depottype>(stmtId, typename);
			return result;
        }
		public IList<Depottype> PaginationFindByTypename(DepottypePagination obj) {
			String stmtId = "DepottypePagination.FindByTypename";
			IList<Depottype> result = this.sqlMapper.QueryForList<Depottype>(stmtId, obj);
			return result;
        }
		public void Update(Depottype obj) {
			String stmtId = "Depottype.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Depottype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Depottype.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Depottype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Depottype.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByActive(Byte active) {
			String stmtId = "Depottype.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public int DeleteByTypename(String typename) {
			String stmtId = "Depottype.DeleteByTypename";
			int result = this.sqlMapper.Delete(stmtId, typename);
			return result;
        }
		public void Reload(Depottype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Depottype.Find";
			this.sqlMapper.QueryForObject<Depottype>(stmtId, obj, obj);
		}
    }
}
