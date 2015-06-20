using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class CautiontypeDao : ICautiontypeDao
    {
        private ISqlMapper sqlMapper = null;
        public CautiontypeDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Cautiontype.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Cautiontype Find(Int64 id) 
        {
			String stmtId = "Cautiontype.Find";
			Cautiontype result = this.sqlMapper.QueryForObject<Cautiontype>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Cautiontype.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Cautiontype> FindAll() {
			String stmtId = "Cautiontype.FindAll";
			IList<Cautiontype> result = this.sqlMapper.QueryForList<Cautiontype>(stmtId, null);
			return result;
        }
		public IList<Cautiontype> PaginationFindAll(CautiontypePagination obj) {
			String stmtId = "Cautiontype.FindAllPagination";
			IList<Cautiontype> result = this.sqlMapper.QueryForList<Cautiontype>(stmtId, obj);
			return result;
        }
		public IList<Cautiontype> QuickFindAll() {
			String stmtId = "Cautiontype.QuickFindAll";
			IList<Cautiontype> result = this.sqlMapper.QueryForList<Cautiontype>(stmtId, null);
			return result;
        }
		public IList<Cautiontype> FindByTypename(String typename) {
			String stmtId = "Cautiontype.FindByTypename";
			IList<Cautiontype> result = this.sqlMapper.QueryForList<Cautiontype>(stmtId, typename);
			return result;
        }
		public IList<Cautiontype> PaginationFindByTypename(CautiontypePagination obj) {
			String stmtId = "CautiontypePagination.FindByTypename";
			IList<Cautiontype> result = this.sqlMapper.QueryForList<Cautiontype>(stmtId, obj);
			return result;
        }
		public int FindCountByTypename(Cautiontype obj){
			String stmtId = "Cautiontype.GetFindByTypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Cautiontype obj) {
			String stmtId = "Cautiontype.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Cautiontype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Cautiontype.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Cautiontype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Cautiontype.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByTypename(String typename) {
			String stmtId = "Cautiontype.DeleteByTypename";
			int result = this.sqlMapper.Delete(stmtId, typename);
			return result;
        }
		public void Reload(Cautiontype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Cautiontype.Find";
			this.sqlMapper.QueryForObject<Cautiontype>(stmtId, obj, obj);
		}
    }
}
