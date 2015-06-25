using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class TrunknumberprefixDao : ITrunknumberprefixDao
    {
        private ISqlMapper sqlMapper = null;
        public TrunknumberprefixDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Trunknumberprefix.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Trunknumberprefix Find(Int64 id) 
        {
			String stmtId = "Trunknumberprefix.Find";
			Trunknumberprefix result = this.sqlMapper.QueryForObject<Trunknumberprefix>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Trunknumberprefix.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Trunknumberprefix> FindAll() {
			String stmtId = "Trunknumberprefix.FindAll";
			IList<Trunknumberprefix> result = this.sqlMapper.QueryForList<Trunknumberprefix>(stmtId, null);
			return result;
        }
		public IList<Trunknumberprefix> DescendOrderFindAll() {
			String stmtId = "Trunknumberprefix.DescendOrderFindAll";
			IList<Trunknumberprefix> result = this.sqlMapper.QueryForList<Trunknumberprefix>(stmtId, null);
			return result;
        }
		public IList<Trunknumberprefix> PaginationFindAll(TrunknumberprefixPagination obj) {
			String stmtId = "Trunknumberprefix.FindAllPagination";
			IList<Trunknumberprefix> result = this.sqlMapper.QueryForList<Trunknumberprefix>(stmtId, obj);
			return result;
        }
		public IList<Trunknumberprefix> DescendOrderPaginationFindAll(TrunknumberprefixPagination obj) {
			String stmtId = "Trunknumberprefix.DescendOrderFindAllPagination";
			IList<Trunknumberprefix> result = this.sqlMapper.QueryForList<Trunknumberprefix>(stmtId, obj);
			return result;
        }
		public IList<Trunknumberprefix> QuickFindAll() {
			String stmtId = "Trunknumberprefix.QuickFindAll";
			IList<Trunknumberprefix> result = this.sqlMapper.QueryForList<Trunknumberprefix>(stmtId, null);
			return result;
        }
		public IList<Trunknumberprefix> FindByPrefixname(String prefixname) {
			String stmtId = "Trunknumberprefix.FindByPrefixname";
			IList<Trunknumberprefix> result = this.sqlMapper.QueryForList<Trunknumberprefix>(stmtId, prefixname);
			return result;
        }
		public IList<Trunknumberprefix> DescendOrderFindByPrefixname(String prefixname) {
			String stmtId = "Trunknumberprefix.DescendOrderFindByPrefixname";
			IList<Trunknumberprefix> result = this.sqlMapper.QueryForList<Trunknumberprefix>(stmtId, prefixname);
			return result;
        }
		public IList<Trunknumberprefix> PaginationFindByPrefixname(TrunknumberprefixPagination obj) {
			String stmtId = "TrunknumberprefixPagination.FindByPrefixname";
			IList<Trunknumberprefix> result = this.sqlMapper.QueryForList<Trunknumberprefix>(stmtId, obj);
			return result;
        }
		public IList<Trunknumberprefix> DescendOrderPaginationFindByPrefixname(TrunknumberprefixPagination obj) {
			String stmtId = "TrunknumberprefixPagination.DescendOrderFindByPrefixname";
			IList<Trunknumberprefix> result = this.sqlMapper.QueryForList<Trunknumberprefix>(stmtId, obj);
			return result;
        }
		public int FindCountByPrefixname(Trunknumberprefix obj){
			String stmtId = "Trunknumberprefix.GetFindByPrefixnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Trunknumberprefix obj) {
			String stmtId = "Trunknumberprefix.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Trunknumberprefix obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunknumberprefix.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Trunknumberprefix obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunknumberprefix.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByPrefixname(String prefixname) {
			String stmtId = "Trunknumberprefix.DeleteByPrefixname";
			int result = this.sqlMapper.Delete(stmtId, prefixname);
			return result;
        }
		public void Reload(Trunknumberprefix obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunknumberprefix.Find";
			this.sqlMapper.QueryForObject<Trunknumberprefix>(stmtId, obj, obj);
		}
    }
}
