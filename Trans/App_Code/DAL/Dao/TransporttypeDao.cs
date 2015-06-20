using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class TransporttypeDao : ITransporttypeDao
    {
        private ISqlMapper sqlMapper = null;
        public TransporttypeDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Transporttype.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Transporttype Find(Int64 id) 
        {
			String stmtId = "Transporttype.Find";
			Transporttype result = this.sqlMapper.QueryForObject<Transporttype>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Transporttype.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Transporttype> FindAll() {
			String stmtId = "Transporttype.FindAll";
			IList<Transporttype> result = this.sqlMapper.QueryForList<Transporttype>(stmtId, null);
			return result;
        }
		public IList<Transporttype> PaginationFindAll(TransporttypePagination obj) {
			String stmtId = "Transporttype.FindAllPagination";
			IList<Transporttype> result = this.sqlMapper.QueryForList<Transporttype>(stmtId, obj);
			return result;
        }
		public IList<Transporttype> QuickFindAll() {
			String stmtId = "Transporttype.QuickFindAll";
			IList<Transporttype> result = this.sqlMapper.QueryForList<Transporttype>(stmtId, null);
			return result;
        }
		public IList<Transporttype> FindByTypename(String typename) {
			String stmtId = "Transporttype.FindByTypename";
			IList<Transporttype> result = this.sqlMapper.QueryForList<Transporttype>(stmtId, typename);
			return result;
        }
		public IList<Transporttype> PaginationFindByTypename(TransporttypePagination obj) {
			String stmtId = "TransporttypePagination.FindByTypename";
			IList<Transporttype> result = this.sqlMapper.QueryForList<Transporttype>(stmtId, obj);
			return result;
        }
		public int FindCountByTypename(Transporttype obj){
			String stmtId = "Transporttype.GetFindByTypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Transporttype obj) {
			String stmtId = "Transporttype.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Transporttype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Transporttype.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Transporttype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Transporttype.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByTypename(String typename) {
			String stmtId = "Transporttype.DeleteByTypename";
			int result = this.sqlMapper.Delete(stmtId, typename);
			return result;
        }
		public void Reload(Transporttype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Transporttype.Find";
			this.sqlMapper.QueryForObject<Transporttype>(stmtId, obj, obj);
		}
    }
}
