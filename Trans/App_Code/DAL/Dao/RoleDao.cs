using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class RoleDao : IRoleDao
    {
        private ISqlMapper sqlMapper = null;
        public RoleDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Role.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Role Find(Int64 id) 
        {
			String stmtId = "Role.Find";
			Role result = this.sqlMapper.QueryForObject<Role>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Role.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Role> FindAll() {
			String stmtId = "Role.FindAll";
			IList<Role> result = this.sqlMapper.QueryForList<Role>(stmtId, null);
			return result;
        }
		public IList<Role> PaginationFindAll(RolePagination obj) {
			String stmtId = "Role.FindAllPagination";
			IList<Role> result = this.sqlMapper.QueryForList<Role>(stmtId, obj);
			return result;
        }
		public IList<Role> QuickFindAll() {
			String stmtId = "Role.QuickFindAll";
			IList<Role> result = this.sqlMapper.QueryForList<Role>(stmtId, null);
			return result;
        }
		public IList<Role> FindByActive(Byte active) {
			String stmtId = "Role.FindByActive";
			IList<Role> result = this.sqlMapper.QueryForList<Role>(stmtId, active);
			return result;
        }
		public IList<Role> PaginationFindByActive(RolePagination obj) {
			String stmtId = "RolePagination.FindByActive";
			IList<Role> result = this.sqlMapper.QueryForList<Role>(stmtId, obj);
			return result;
        }
		public int FindCountByActive(Role obj){
			String stmtId = "Role.GetFindByActiveCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Role> FindByRolename(String rolename) {
			String stmtId = "Role.FindByRolename";
			IList<Role> result = this.sqlMapper.QueryForList<Role>(stmtId, rolename);
			return result;
        }
		public IList<Role> PaginationFindByRolename(RolePagination obj) {
			String stmtId = "RolePagination.FindByRolename";
			IList<Role> result = this.sqlMapper.QueryForList<Role>(stmtId, obj);
			return result;
        }
		public int FindCountByRolename(Role obj){
			String stmtId = "Role.GetFindByRolenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Role obj) {
			String stmtId = "Role.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Role obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Role.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Role obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Role.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByActive(Byte active) {
			String stmtId = "Role.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public int DeleteByRolename(String rolename) {
			String stmtId = "Role.DeleteByRolename";
			int result = this.sqlMapper.Delete(stmtId, rolename);
			return result;
        }
		public void Reload(Role obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Role.Find";
			this.sqlMapper.QueryForObject<Role>(stmtId, obj, obj);
		}
    }
}
