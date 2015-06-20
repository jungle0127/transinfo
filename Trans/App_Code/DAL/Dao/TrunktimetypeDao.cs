using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class TrunktimetypeDao : ITrunktimetypeDao
    {
        private ISqlMapper sqlMapper = null;
        public TrunktimetypeDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Trunktimetype.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Trunktimetype Find(Int64 id) 
        {
			String stmtId = "Trunktimetype.Find";
			Trunktimetype result = this.sqlMapper.QueryForObject<Trunktimetype>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Trunktimetype.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Trunktimetype> FindAll() {
			String stmtId = "Trunktimetype.FindAll";
			IList<Trunktimetype> result = this.sqlMapper.QueryForList<Trunktimetype>(stmtId, null);
			return result;
        }
		public IList<Trunktimetype> PaginationFindAll(TrunktimetypePagination obj) {
			String stmtId = "Trunktimetype.FindAllPagination";
			IList<Trunktimetype> result = this.sqlMapper.QueryForList<Trunktimetype>(stmtId, obj);
			return result;
        }
		public IList<Trunktimetype> QuickFindAll() {
			String stmtId = "Trunktimetype.QuickFindAll";
			IList<Trunktimetype> result = this.sqlMapper.QueryForList<Trunktimetype>(stmtId, null);
			return result;
        }
		public IList<Trunktimetype> FindByTypename(String typename) {
			String stmtId = "Trunktimetype.FindByTypename";
			IList<Trunktimetype> result = this.sqlMapper.QueryForList<Trunktimetype>(stmtId, typename);
			return result;
        }
		public IList<Trunktimetype> PaginationFindByTypename(TrunktimetypePagination obj) {
			String stmtId = "TrunktimetypePagination.FindByTypename";
			IList<Trunktimetype> result = this.sqlMapper.QueryForList<Trunktimetype>(stmtId, obj);
			return result;
        }
		public int FindCountByTypename(Trunktimetype obj){
			String stmtId = "Trunktimetype.GetFindByTypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Trunktimetype obj) {
			String stmtId = "Trunktimetype.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Trunktimetype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunktimetype.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Trunktimetype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunktimetype.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByTypename(String typename) {
			String stmtId = "Trunktimetype.DeleteByTypename";
			int result = this.sqlMapper.Delete(stmtId, typename);
			return result;
        }
		public void Reload(Trunktimetype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunktimetype.Find";
			this.sqlMapper.QueryForObject<Trunktimetype>(stmtId, obj, obj);
		}
    }
}
