using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class RightgrouphasrightsDao : IRightgrouphasrightsDao
    {
        private ISqlMapper sqlMapper = null;
        public RightgrouphasrightsDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Rightgrouphasrights.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Rightgrouphasrights Find(Int64 id) 
        {
			String stmtId = "Rightgrouphasrights.Find";
			Rightgrouphasrights result = this.sqlMapper.QueryForObject<Rightgrouphasrights>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Rightgrouphasrights.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Rightgrouphasrights> FindAll() {
			String stmtId = "Rightgrouphasrights.FindAll";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, null);
			return result;
        }
		public IList<Rightgrouphasrights> DescendOrderFindAll() {
			String stmtId = "Rightgrouphasrights.DescendOrderFindAll";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, null);
			return result;
        }
		public IList<Rightgrouphasrights> PaginationFindAll(RightgrouphasrightsPagination obj) {
			String stmtId = "Rightgrouphasrights.FindAllPagination";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, obj);
			return result;
        }
		public IList<Rightgrouphasrights> DescendOrderPaginationFindAll(RightgrouphasrightsPagination obj) {
			String stmtId = "Rightgrouphasrights.DescendOrderFindAllPagination";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, obj);
			return result;
        }
		public IList<Rightgrouphasrights> QuickFindAll() {
			String stmtId = "Rightgrouphasrights.QuickFindAll";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, null);
			return result;
        }
		public IList<Rightgrouphasrights> FindByActive(Byte active) {
			String stmtId = "Rightgrouphasrights.FindByActive";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, active);
			return result;
        }
		public IList<Rightgrouphasrights> DescendOrderFindByActive(Byte active) {
			String stmtId = "Rightgrouphasrights.DescendOrderFindByActive";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, active);
			return result;
        }
		public IList<Rightgrouphasrights> PaginationFindByActive(RightgrouphasrightsPagination obj) {
			String stmtId = "RightgrouphasrightsPagination.FindByActive";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, obj);
			return result;
        }
		public IList<Rightgrouphasrights> DescendOrderPaginationFindByActive(RightgrouphasrightsPagination obj) {
			String stmtId = "RightgrouphasrightsPagination.DescendOrderFindByActive";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, obj);
			return result;
        }
		public int FindCountByActive(Rightgrouphasrights obj){
			String stmtId = "Rightgrouphasrights.GetFindByActiveCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Rightgrouphasrights> FindByRightid(Int64 rightid) {
			String stmtId = "Rightgrouphasrights.FindByRightid";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, rightid);
			return result;
        }
		public IList<Rightgrouphasrights> DescendOrderFindByRightid(Int64 rightid) {
			String stmtId = "Rightgrouphasrights.DescendOrderFindByRightid";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, rightid);
			return result;
        }
		public IList<Rightgrouphasrights> PaginationFindByRightid(RightgrouphasrightsPagination obj) {
			String stmtId = "RightgrouphasrightsPagination.FindByRightid";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, obj);
			return result;
        }
		public IList<Rightgrouphasrights> DescendOrderPaginationFindByRightid(RightgrouphasrightsPagination obj) {
			String stmtId = "RightgrouphasrightsPagination.DescendOrderFindByRightid";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, obj);
			return result;
        }
		public int FindCountByRightid(Rightgrouphasrights obj){
			String stmtId = "Rightgrouphasrights.GetFindByRightidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Rightgrouphasrights> FindByGroupid(Int64 groupid) {
			String stmtId = "Rightgrouphasrights.FindByGroupid";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, groupid);
			return result;
        }
		public IList<Rightgrouphasrights> DescendOrderFindByGroupid(Int64 groupid) {
			String stmtId = "Rightgrouphasrights.DescendOrderFindByGroupid";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, groupid);
			return result;
        }
		public IList<Rightgrouphasrights> PaginationFindByGroupid(RightgrouphasrightsPagination obj) {
			String stmtId = "RightgrouphasrightsPagination.FindByGroupid";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, obj);
			return result;
        }
		public IList<Rightgrouphasrights> DescendOrderPaginationFindByGroupid(RightgrouphasrightsPagination obj) {
			String stmtId = "RightgrouphasrightsPagination.DescendOrderFindByGroupid";
			IList<Rightgrouphasrights> result = this.sqlMapper.QueryForList<Rightgrouphasrights>(stmtId, obj);
			return result;
        }
		public int FindCountByGroupid(Rightgrouphasrights obj){
			String stmtId = "Rightgrouphasrights.GetFindByGroupidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Rightgrouphasrights obj) {
			String stmtId = "Rightgrouphasrights.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Rightgrouphasrights obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Rightgrouphasrights.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Rightgrouphasrights obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Rightgrouphasrights.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByActive(Byte active) {
			String stmtId = "Rightgrouphasrights.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public int DeleteByRightid(Int64 rightid) {
			String stmtId = "Rightgrouphasrights.DeleteByRightid";
			int result = this.sqlMapper.Delete(stmtId, rightid);
			return result;
        }
		public int DeleteByGroupid(Int64 groupid) {
			String stmtId = "Rightgrouphasrights.DeleteByGroupid";
			int result = this.sqlMapper.Delete(stmtId, groupid);
			return result;
        }
		public void Reload(Rightgrouphasrights obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Rightgrouphasrights.Find";
			this.sqlMapper.QueryForObject<Rightgrouphasrights>(stmtId, obj, obj);
		}
    }
}
