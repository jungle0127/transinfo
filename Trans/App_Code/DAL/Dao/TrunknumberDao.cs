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
		public int GetFindCount(Int64 id) {
			String stmtId = "Trunknumber.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Trunknumber> FindAll() {
			String stmtId = "Trunknumber.FindAll";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, null);
			return result;
        }
		public IList<Trunknumber> DescendOrderFindAll() {
			String stmtId = "Trunknumber.DescendOrderFindAll";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, null);
			return result;
        }
		public IList<Trunknumber> PaginationFindAll(TrunknumberPagination obj) {
			String stmtId = "Trunknumber.FindAllPagination";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, obj);
			return result;
        }
		public IList<Trunknumber> DescendOrderPaginationFindAll(TrunknumberPagination obj) {
			String stmtId = "Trunknumber.DescendOrderFindAllPagination";
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
		public IList<Trunknumber> DescendOrderFindByNumber(String number) {
			String stmtId = "Trunknumber.DescendOrderFindByNumber";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, number);
			return result;
        }
		public IList<Trunknumber> PaginationFindByNumber(TrunknumberPagination obj) {
			String stmtId = "TrunknumberPagination.FindByNumber";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, obj);
			return result;
        }
		public IList<Trunknumber> DescendOrderPaginationFindByNumber(TrunknumberPagination obj) {
			String stmtId = "TrunknumberPagination.DescendOrderFindByNumber";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, obj);
			return result;
        }
		public int FindCountByNumber(Trunknumber obj){
			String stmtId = "Trunknumber.GetFindByNumberCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunknumber> FindByUserid(Int64 userid) {
			String stmtId = "Trunknumber.FindByUserid";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, userid);
			return result;
        }
		public IList<Trunknumber> DescendOrderFindByUserid(Int64 userid) {
			String stmtId = "Trunknumber.DescendOrderFindByUserid";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, userid);
			return result;
        }
		public IList<Trunknumber> PaginationFindByUserid(TrunknumberPagination obj) {
			String stmtId = "TrunknumberPagination.FindByUserid";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, obj);
			return result;
        }
		public IList<Trunknumber> DescendOrderPaginationFindByUserid(TrunknumberPagination obj) {
			String stmtId = "TrunknumberPagination.DescendOrderFindByUserid";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, obj);
			return result;
        }
		public int FindCountByUserid(Trunknumber obj){
			String stmtId = "Trunknumber.GetFindByUseridCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunknumber> FindByPrefixid(Int64 prefixid) {
			String stmtId = "Trunknumber.FindByPrefixid";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, prefixid);
			return result;
        }
		public IList<Trunknumber> DescendOrderFindByPrefixid(Int64 prefixid) {
			String stmtId = "Trunknumber.DescendOrderFindByPrefixid";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, prefixid);
			return result;
        }
		public IList<Trunknumber> PaginationFindByPrefixid(TrunknumberPagination obj) {
			String stmtId = "TrunknumberPagination.FindByPrefixid";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, obj);
			return result;
        }
		public IList<Trunknumber> DescendOrderPaginationFindByPrefixid(TrunknumberPagination obj) {
			String stmtId = "TrunknumberPagination.DescendOrderFindByPrefixid";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, obj);
			return result;
        }
		public int FindCountByPrefixid(Trunknumber obj){
			String stmtId = "Trunknumber.GetFindByPrefixidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunknumber> FindByActive(Byte active) {
			String stmtId = "Trunknumber.FindByActive";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, active);
			return result;
        }
		public IList<Trunknumber> DescendOrderFindByActive(Byte active) {
			String stmtId = "Trunknumber.DescendOrderFindByActive";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, active);
			return result;
        }
		public IList<Trunknumber> PaginationFindByActive(TrunknumberPagination obj) {
			String stmtId = "TrunknumberPagination.FindByActive";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, obj);
			return result;
        }
		public IList<Trunknumber> DescendOrderPaginationFindByActive(TrunknumberPagination obj) {
			String stmtId = "TrunknumberPagination.DescendOrderFindByActive";
			IList<Trunknumber> result = this.sqlMapper.QueryForList<Trunknumber>(stmtId, obj);
			return result;
        }
		public int FindCountByActive(Trunknumber obj){
			String stmtId = "Trunknumber.GetFindByActiveCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
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
