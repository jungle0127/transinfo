using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class TrunknumberDao : ITrunknumberDao
    {
        private ISqlMapper sqlMapper = null;
        public TrunknumberDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Trunknumber.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Trunknumber Find(Int64 id) 
        {
			String stmtId = "Trunknumber.Find";
			Trunknumber result = this.sqlMapper.QueryForObject<Trunknumber>(stmtId, id);
			return result;
        }
		public IList<Trunknumber> FindAll() {
			String stmtId = "Trunknumber.FindAll";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, null);
			return result;
        }
		public IList<Trunknumber> PaginationFindAll(TrunknumberPagination obj) {
			String stmtId = "Trunknumber.FindAllPagination";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, obj);
			return result;
        }
		public IList<Trunknumber> QuickFindAll() {
			String stmtId = "Trunknumber.QuickFindAll";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, null);
			return result;
        }
		public IList<Trunknumber> FindByNumber(String number) {
			String stmtId = "Trunknumber.FindByNumber";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, number);
			return result;
        }
		public IList<Trunknumber> PaginationFindByNumber(TrunknumberPagination obj) {
			String stmtId = "TrunknumberPagination.FindByNumber";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, obj);
			return result;
        }
		public IList<Trunknumber> FindByUserid(Int64 userid) {
			String stmtId = "Trunknumber.FindByUserid";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, userid);
			return result;
        }
		public IList<Trunknumber> PaginationFindByUserid(TrunknumberPagination obj) {
			String stmtId = "TrunknumberPagination.FindByUserid";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, obj);
			return result;
        }
		public IList<Trunknumber> FindByPrefixid(Int64 prefixid) {
			String stmtId = "Trunknumber.FindByPrefixid";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, prefixid);
			return result;
        }
		public IList<Trunknumber> PaginationFindByPrefixid(TrunknumberPagination obj) {
			String stmtId = "TrunknumberPagination.FindByPrefixid";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, obj);
			return result;
        }
		public IList<Trunknumber> FindByActive(Byte active) {
			String stmtId = "Trunknumber.FindByActive";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, active);
			return result;
        }
		public IList<Trunknumber> PaginationFindByActive(TrunknumberPagination obj) {
			String stmtId = "TrunknumberPagination.FindByActive";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, obj);
			return result;
        }
		public void Update(Trunknumber obj) {
			String stmtId = "Trunknumber.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Trunknumber obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunknumber.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Trunknumber obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunknumber.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByNumber(String number) {
			String stmtId = "Trunknumber.DeleteByNumber";
			int result = this.sqlMapper.Delete(stmtId, number);
			return result;
        }
		public int DeleteByUserid(Int64 userid) {
			String stmtId = "Trunknumber.DeleteByUserid";
			int result = this.sqlMapper.Delete(stmtId, userid);
			return result;
        }
		public int DeleteByPrefixid(Int64 prefixid) {
			String stmtId = "Trunknumber.DeleteByPrefixid";
			int result = this.sqlMapper.Delete(stmtId, prefixid);
			return result;
        }
		public int DeleteByActive(Byte active) {
			String stmtId = "Trunknumber.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public void Reload(Trunknumber obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunknumber.Find";
			this.sqlMapper.QueryForObject<Trunknumber>(stmtId, obj, obj);
		}
    }
}
