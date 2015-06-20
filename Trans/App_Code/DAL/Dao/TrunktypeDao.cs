using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class TrunktypeDao : ITrunktypeDao
    {
        private ISqlMapper sqlMapper = null;
        public TrunktypeDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Trunktype.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Trunktype Find(Int64 id) 
        {
			String stmtId = "Trunktype.Find";
			Trunktype result = this.sqlMapper.QueryForObject<Trunktype>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Trunktype.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Trunktype> FindAll() {
			String stmtId = "Trunktype.FindAll";
			IList<Trunktype> result = this.sqlMapper.QueryForList<Trunktype>(stmtId, null);
			return result;
        }
		public IList<Trunktype> PaginationFindAll(TrunktypePagination obj) {
			String stmtId = "Trunktype.FindAllPagination";
			IList<Trunktype> result = this.sqlMapper.QueryForList<Trunktype>(stmtId, obj);
			return result;
        }
		public IList<Trunktype> QuickFindAll() {
			String stmtId = "Trunktype.QuickFindAll";
			IList<Trunktype> result = this.sqlMapper.QueryForList<Trunktype>(stmtId, null);
			return result;
        }
		public IList<Trunktype> FindByTypename(String typename) {
			String stmtId = "Trunktype.FindByTypename";
			IList<Trunktype> result = this.sqlMapper.QueryForList<Trunktype>(stmtId, typename);
			return result;
        }
		public IList<Trunktype> PaginationFindByTypename(TrunktypePagination obj) {
			String stmtId = "TrunktypePagination.FindByTypename";
			IList<Trunktype> result = this.sqlMapper.QueryForList<Trunktype>(stmtId, obj);
			return result;
        }
		public int FindCountByTypename(Trunktype obj){
			String stmtId = "Trunktype.GetFindByTypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Trunktype obj) {
			String stmtId = "Trunktype.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Trunktype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunktype.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Trunktype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunktype.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByTypename(String typename) {
			String stmtId = "Trunktype.DeleteByTypename";
			int result = this.sqlMapper.Delete(stmtId, typename);
			return result;
        }
		public void Reload(Trunktype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunktype.Find";
			this.sqlMapper.QueryForObject<Trunktype>(stmtId, obj, obj);
		}
    }
}
