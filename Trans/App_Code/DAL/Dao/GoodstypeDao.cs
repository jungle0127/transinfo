using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class GoodstypeDao : IGoodstypeDao
    {
        private ISqlMapper sqlMapper = null;
        public GoodstypeDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Goodstype.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Goodstype Find(Int64 id) 
        {
			String stmtId = "Goodstype.Find";
			Goodstype result = this.sqlMapper.QueryForObject<Goodstype>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Goodstype.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Goodstype> FindAll() {
			String stmtId = "Goodstype.FindAll";
			IList<Goodstype> result = this.sqlMapper.QueryForList<Goodstype>(stmtId, null);
			return result;
        }
		public IList<Goodstype> PaginationFindAll(GoodstypePagination obj) {
			String stmtId = "Goodstype.FindAllPagination";
			IList<Goodstype> result = this.sqlMapper.QueryForList<Goodstype>(stmtId, obj);
			return result;
        }
		public IList<Goodstype> QuickFindAll() {
			String stmtId = "Goodstype.QuickFindAll";
			IList<Goodstype> result = this.sqlMapper.QueryForList<Goodstype>(stmtId, null);
			return result;
        }
		public IList<Goodstype> FindByTypename(String typename) {
			String stmtId = "Goodstype.FindByTypename";
			IList<Goodstype> result = this.sqlMapper.QueryForList<Goodstype>(stmtId, typename);
			return result;
        }
		public IList<Goodstype> PaginationFindByTypename(GoodstypePagination obj) {
			String stmtId = "GoodstypePagination.FindByTypename";
			IList<Goodstype> result = this.sqlMapper.QueryForList<Goodstype>(stmtId, obj);
			return result;
        }
		public int FindCountByTypename(Goodstype obj){
			String stmtId = "Goodstype.GetFindByTypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Goodstype obj) {
			String stmtId = "Goodstype.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Goodstype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Goodstype.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Goodstype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Goodstype.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByTypename(String typename) {
			String stmtId = "Goodstype.DeleteByTypename";
			int result = this.sqlMapper.Delete(stmtId, typename);
			return result;
        }
		public void Reload(Goodstype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Goodstype.Find";
			this.sqlMapper.QueryForObject<Goodstype>(stmtId, obj, obj);
		}
    }
}
