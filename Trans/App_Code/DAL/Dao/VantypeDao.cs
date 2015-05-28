using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class VantypeDao : IVantypeDao
    {
        private ISqlMapper sqlMapper = null;
        public VantypeDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Vantype.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Vantype Find(Int64 id) 
        {
			String stmtId = "Vantype.Find";
			Vantype result = this.sqlMapper.QueryForObject<Vantype>(stmtId, id);
			return result;
        }
		public IList<Vantype> FindAll() {
			String stmtId = "Vantype.FindAll";
			IList<Vantype> result = this.sqlMapper.QueryForList<Vantype>(stmtId, null);
			return result;
        }
		public IList<Vantype> PaginationFindAll(VantypePagination obj) {
			String stmtId = "Vantype.FindAllPagination";
			IList<Vantype> result = this.sqlMapper.QueryForList<Vantype>(stmtId, obj);
			return result;
        }
		public IList<Vantype> QuickFindAll() {
			String stmtId = "Vantype.QuickFindAll";
			IList<Vantype> result = this.sqlMapper.QueryForList<Vantype>(stmtId, null);
			return result;
        }
		public IList<Vantype> FindByTypename(String typename) {
			String stmtId = "Vantype.FindByTypename";
			IList<Vantype> result = this.sqlMapper.QueryForList<Vantype>(stmtId, typename);
			return result;
        }
		public IList<Vantype> PaginationFindByTypename(VantypePagination obj) {
			String stmtId = "VantypePagination.FindByTypename";
			IList<Vantype> result = this.sqlMapper.QueryForList<Vantype>(stmtId, obj);
			return result;
        }
		public void Reload(Vantype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Vantype.Find";
			this.sqlMapper.QueryForObject<Vantype>(stmtId, obj, obj);
		}
    }
}
