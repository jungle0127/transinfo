using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class VvehiclenumberDao : IVvehiclenumberDao
    {
        private ISqlMapper sqlMapper = null;
        public VvehiclenumberDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Vvehiclenumber.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Vvehiclenumber Find(Int64 id) 
        {
			String stmtId = "Vvehiclenumber.Find";
			Vvehiclenumber result = this.sqlMapper.QueryForObject<Vvehiclenumber>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Vvehiclenumber.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Vvehiclenumber> FindAll() {
			String stmtId = "Vvehiclenumber.FindAll";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, null);
			return result;
        }
		public IList<Vvehiclenumber> DescendOrderFindAll() {
			String stmtId = "Vvehiclenumber.DescendOrderFindAll";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, null);
			return result;
        }
		public IList<Vvehiclenumber> PaginationFindAll(VvehiclenumberPagination obj) {
			String stmtId = "Vvehiclenumber.FindAllPagination";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, obj);
			return result;
        }
		public IList<Vvehiclenumber> DescendOrderPaginationFindAll(VvehiclenumberPagination obj) {
			String stmtId = "Vvehiclenumber.DescendOrderFindAllPagination";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, obj);
			return result;
        }
		public IList<Vvehiclenumber> QuickFindAll() {
			String stmtId = "Vvehiclenumber.QuickFindAll";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, null);
			return result;
        }
		public IList<Vvehiclenumber> FindByUserid(Int64 userid) {
			String stmtId = "Vvehiclenumber.FindByUserid";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, userid);
			return result;
        }
		public IList<Vvehiclenumber> DescendOrderFindByUserid(Int64 userid) {
			String stmtId = "Vvehiclenumber.DescendOrderFindByUserid";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, userid);
			return result;
        }
		public IList<Vvehiclenumber> PaginationFindByUserid(VvehiclenumberPagination obj) {
			String stmtId = "VvehiclenumberPagination.FindByUserid";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, obj);
			return result;
        }
		public IList<Vvehiclenumber> DescendOrderPaginationFindByUserid(VvehiclenumberPagination obj) {
			String stmtId = "VvehiclenumberPagination.DescendOrderFindByUserid";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, obj);
			return result;
        }
		public int FindCountByUserid(Vvehiclenumber obj){
			String stmtId = "Vvehiclenumber.GetFindByUseridCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vvehiclenumber> FindById(Int64 id) {
			String stmtId = "Vvehiclenumber.FindById";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, id);
			return result;
        }
		public IList<Vvehiclenumber> DescendOrderFindById(Int64 id) {
			String stmtId = "Vvehiclenumber.DescendOrderFindById";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, id);
			return result;
        }
		public IList<Vvehiclenumber> PaginationFindById(VvehiclenumberPagination obj) {
			String stmtId = "VvehiclenumberPagination.FindById";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, obj);
			return result;
        }
		public IList<Vvehiclenumber> DescendOrderPaginationFindById(VvehiclenumberPagination obj) {
			String stmtId = "VvehiclenumberPagination.DescendOrderFindById";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, obj);
			return result;
        }
		public int FindCountById(Vvehiclenumber obj){
			String stmtId = "Vvehiclenumber.GetFindByIdCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vvehiclenumber> FindByPrefixname(String prefixname) {
			String stmtId = "Vvehiclenumber.FindByPrefixname";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, prefixname);
			return result;
        }
		public IList<Vvehiclenumber> DescendOrderFindByPrefixname(String prefixname) {
			String stmtId = "Vvehiclenumber.DescendOrderFindByPrefixname";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, prefixname);
			return result;
        }
		public IList<Vvehiclenumber> PaginationFindByPrefixname(VvehiclenumberPagination obj) {
			String stmtId = "VvehiclenumberPagination.FindByPrefixname";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, obj);
			return result;
        }
		public IList<Vvehiclenumber> DescendOrderPaginationFindByPrefixname(VvehiclenumberPagination obj) {
			String stmtId = "VvehiclenumberPagination.DescendOrderFindByPrefixname";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, obj);
			return result;
        }
		public int FindCountByPrefixname(Vvehiclenumber obj){
			String stmtId = "Vvehiclenumber.GetFindByPrefixnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vvehiclenumber> FindByNumber(String number) {
			String stmtId = "Vvehiclenumber.FindByNumber";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, number);
			return result;
        }
		public IList<Vvehiclenumber> DescendOrderFindByNumber(String number) {
			String stmtId = "Vvehiclenumber.DescendOrderFindByNumber";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, number);
			return result;
        }
		public IList<Vvehiclenumber> PaginationFindByNumber(VvehiclenumberPagination obj) {
			String stmtId = "VvehiclenumberPagination.FindByNumber";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, obj);
			return result;
        }
		public IList<Vvehiclenumber> DescendOrderPaginationFindByNumber(VvehiclenumberPagination obj) {
			String stmtId = "VvehiclenumberPagination.DescendOrderFindByNumber";
			IList<Vvehiclenumber> result = this.sqlMapper.QueryForList<Vvehiclenumber>(stmtId, obj);
			return result;
        }
		public int FindCountByNumber(Vvehiclenumber obj){
			String stmtId = "Vvehiclenumber.GetFindByNumberCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Reload(Vvehiclenumber obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Vvehiclenumber.Find";
			this.sqlMapper.QueryForObject<Vvehiclenumber>(stmtId, obj, obj);
		}
    }
}
