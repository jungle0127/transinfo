using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class RolehasrightsDao : IRolehasrightsDao
    {
        private ISqlMapper sqlMapper = null;
        public RolehasrightsDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Rolehasrights.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Rolehasrights Find(Int64 id) 
        {
			String stmtId = "Rolehasrights.Find";
			Rolehasrights result = this.sqlMapper.QueryForObject<Rolehasrights>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Rolehasrights.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Rolehasrights> FindAll() {
			String stmtId = "Rolehasrights.FindAll";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, null);
			return result;
        }
		public IList<Rolehasrights> DescendOrderFindAll() {
			String stmtId = "Rolehasrights.DescendOrderFindAll";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, null);
			return result;
        }
		public IList<Rolehasrights> PaginationFindAll(RolehasrightsPagination obj) {
			String stmtId = "Rolehasrights.FindAllPagination";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, obj);
			return result;
        }
		public IList<Rolehasrights> DescendOrderPaginationFindAll(RolehasrightsPagination obj) {
			String stmtId = "Rolehasrights.DescendOrderFindAllPagination";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, obj);
			return result;
        }
		public IList<Rolehasrights> QuickFindAll() {
			String stmtId = "Rolehasrights.QuickFindAll";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, null);
			return result;
        }
		public IList<Rolehasrights> FindByActive(Byte active) {
			String stmtId = "Rolehasrights.FindByActive";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, active);
			return result;
        }
		public IList<Rolehasrights> DescendOrderFindByActive(Byte active) {
			String stmtId = "Rolehasrights.DescendOrderFindByActive";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, active);
			return result;
        }
		public IList<Rolehasrights> PaginationFindByActive(RolehasrightsPagination obj) {
			String stmtId = "RolehasrightsPagination.FindByActive";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, obj);
			return result;
        }
		public IList<Rolehasrights> DescendOrderPaginationFindByActive(RolehasrightsPagination obj) {
			String stmtId = "RolehasrightsPagination.DescendOrderFindByActive";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, obj);
			return result;
        }
		public int FindCountByActive(Rolehasrights obj){
			String stmtId = "Rolehasrights.GetFindByActiveCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Rolehasrights> FindByRightid(Int64 rightid) {
			String stmtId = "Rolehasrights.FindByRightid";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, rightid);
			return result;
        }
		public IList<Rolehasrights> DescendOrderFindByRightid(Int64 rightid) {
			String stmtId = "Rolehasrights.DescendOrderFindByRightid";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, rightid);
			return result;
        }
		public IList<Rolehasrights> PaginationFindByRightid(RolehasrightsPagination obj) {
			String stmtId = "RolehasrightsPagination.FindByRightid";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, obj);
			return result;
        }
		public IList<Rolehasrights> DescendOrderPaginationFindByRightid(RolehasrightsPagination obj) {
			String stmtId = "RolehasrightsPagination.DescendOrderFindByRightid";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, obj);
			return result;
        }
		public int FindCountByRightid(Rolehasrights obj){
			String stmtId = "Rolehasrights.GetFindByRightidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Rolehasrights> FindByRoleid(Int64 roleid) {
			String stmtId = "Rolehasrights.FindByRoleid";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, roleid);
			return result;
        }
		public IList<Rolehasrights> DescendOrderFindByRoleid(Int64 roleid) {
			String stmtId = "Rolehasrights.DescendOrderFindByRoleid";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, roleid);
			return result;
        }
		public IList<Rolehasrights> PaginationFindByRoleid(RolehasrightsPagination obj) {
			String stmtId = "RolehasrightsPagination.FindByRoleid";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, obj);
			return result;
        }
		public IList<Rolehasrights> DescendOrderPaginationFindByRoleid(RolehasrightsPagination obj) {
			String stmtId = "RolehasrightsPagination.DescendOrderFindByRoleid";
			IList<Rolehasrights> result = this.sqlMapper.QueryForList<Rolehasrights>(stmtId, obj);
			return result;
        }
		public int FindCountByRoleid(Rolehasrights obj){
			String stmtId = "Rolehasrights.GetFindByRoleidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Rolehasrights obj) {
			String stmtId = "Rolehasrights.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Rolehasrights obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Rolehasrights.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Rolehasrights obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Rolehasrights.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByActive(Byte active) {
			String stmtId = "Rolehasrights.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public int DeleteByRightid(Int64 rightid) {
			String stmtId = "Rolehasrights.DeleteByRightid";
			int result = this.sqlMapper.Delete(stmtId, rightid);
			return result;
        }
		public int DeleteByRoleid(Int64 roleid) {
			String stmtId = "Rolehasrights.DeleteByRoleid";
			int result = this.sqlMapper.Delete(stmtId, roleid);
			return result;
        }
		public void Reload(Rolehasrights obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Rolehasrights.Find";
			this.sqlMapper.QueryForObject<Rolehasrights>(stmtId, obj, obj);
		}
    }
}
