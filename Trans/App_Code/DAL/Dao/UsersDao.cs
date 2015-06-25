using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class UsersDao : IUsersDao
    {
        private ISqlMapper sqlMapper = null;
        public UsersDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Users.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Users Find(Int64 id) 
        {
			String stmtId = "Users.Find";
			Users result = this.sqlMapper.QueryForObject<Users>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Users.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Users> FindAll() {
			String stmtId = "Users.FindAll";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, null);
			return result;
        }
		public IList<Users> DescendOrderFindAll() {
			String stmtId = "Users.DescendOrderFindAll";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, null);
			return result;
        }
		public IList<Users> PaginationFindAll(UsersPagination obj) {
			String stmtId = "Users.FindAllPagination";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, obj);
			return result;
        }
		public IList<Users> DescendOrderPaginationFindAll(UsersPagination obj) {
			String stmtId = "Users.DescendOrderFindAllPagination";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, obj);
			return result;
        }
		public IList<Users> QuickFindAll() {
			String stmtId = "Users.QuickFindAll";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, null);
			return result;
        }
		public IList<Users> FindByActive(Byte active) {
			String stmtId = "Users.FindByActive";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, active);
			return result;
        }
		public IList<Users> DescendOrderFindByActive(Byte active) {
			String stmtId = "Users.DescendOrderFindByActive";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, active);
			return result;
        }
		public IList<Users> PaginationFindByActive(UsersPagination obj) {
			String stmtId = "UsersPagination.FindByActive";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, obj);
			return result;
        }
		public IList<Users> DescendOrderPaginationFindByActive(UsersPagination obj) {
			String stmtId = "UsersPagination.DescendOrderFindByActive";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, obj);
			return result;
        }
		public int FindCountByActive(Users obj){
			String stmtId = "Users.GetFindByActiveCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Users> FindByUsername(String username) {
			String stmtId = "Users.FindByUsername";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, username);
			return result;
        }
		public IList<Users> DescendOrderFindByUsername(String username) {
			String stmtId = "Users.DescendOrderFindByUsername";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, username);
			return result;
        }
		public IList<Users> PaginationFindByUsername(UsersPagination obj) {
			String stmtId = "UsersPagination.FindByUsername";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, obj);
			return result;
        }
		public IList<Users> DescendOrderPaginationFindByUsername(UsersPagination obj) {
			String stmtId = "UsersPagination.DescendOrderFindByUsername";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, obj);
			return result;
        }
		public int FindCountByUsername(Users obj){
			String stmtId = "Users.GetFindByUsernameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Users> FindByRoleid(Int64 roleid) {
			String stmtId = "Users.FindByRoleid";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, roleid);
			return result;
        }
		public IList<Users> DescendOrderFindByRoleid(Int64 roleid) {
			String stmtId = "Users.DescendOrderFindByRoleid";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, roleid);
			return result;
        }
		public IList<Users> PaginationFindByRoleid(UsersPagination obj) {
			String stmtId = "UsersPagination.FindByRoleid";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, obj);
			return result;
        }
		public IList<Users> DescendOrderPaginationFindByRoleid(UsersPagination obj) {
			String stmtId = "UsersPagination.DescendOrderFindByRoleid";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, obj);
			return result;
        }
		public int FindCountByRoleid(Users obj){
			String stmtId = "Users.GetFindByRoleidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Users> FindByLoginname(String loginname) {
			String stmtId = "Users.FindByLoginname";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, loginname);
			return result;
        }
		public IList<Users> DescendOrderFindByLoginname(String loginname) {
			String stmtId = "Users.DescendOrderFindByLoginname";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, loginname);
			return result;
        }
		public IList<Users> PaginationFindByLoginname(UsersPagination obj) {
			String stmtId = "UsersPagination.FindByLoginname";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, obj);
			return result;
        }
		public IList<Users> DescendOrderPaginationFindByLoginname(UsersPagination obj) {
			String stmtId = "UsersPagination.DescendOrderFindByLoginname";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, obj);
			return result;
        }
		public int FindCountByLoginname(Users obj){
			String stmtId = "Users.GetFindByLoginnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Users> FindByNote(String note) {
			String stmtId = "Users.FindByNote";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, note);
			return result;
        }
		public IList<Users> DescendOrderFindByNote(String note) {
			String stmtId = "Users.DescendOrderFindByNote";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, note);
			return result;
        }
		public IList<Users> PaginationFindByNote(UsersPagination obj) {
			String stmtId = "UsersPagination.FindByNote";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, obj);
			return result;
        }
		public IList<Users> DescendOrderPaginationFindByNote(UsersPagination obj) {
			String stmtId = "UsersPagination.DescendOrderFindByNote";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, obj);
			return result;
        }
		public int FindCountByNote(Users obj){
			String stmtId = "Users.GetFindByNoteCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Users> FindByPassword(String password) {
			String stmtId = "Users.FindByPassword";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, password);
			return result;
        }
		public IList<Users> DescendOrderFindByPassword(String password) {
			String stmtId = "Users.DescendOrderFindByPassword";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, password);
			return result;
        }
		public IList<Users> PaginationFindByPassword(UsersPagination obj) {
			String stmtId = "UsersPagination.FindByPassword";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, obj);
			return result;
        }
		public IList<Users> DescendOrderPaginationFindByPassword(UsersPagination obj) {
			String stmtId = "UsersPagination.DescendOrderFindByPassword";
			IList<Users> result = this.sqlMapper.QueryForList<Users>(stmtId, obj);
			return result;
        }
		public int FindCountByPassword(Users obj){
			String stmtId = "Users.GetFindByPasswordCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Users obj) {
			String stmtId = "Users.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Users obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Users.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Users obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Users.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByActive(Byte active) {
			String stmtId = "Users.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public int DeleteByUsername(String username) {
			String stmtId = "Users.DeleteByUsername";
			int result = this.sqlMapper.Delete(stmtId, username);
			return result;
        }
		public int DeleteByRoleid(Int64 roleid) {
			String stmtId = "Users.DeleteByRoleid";
			int result = this.sqlMapper.Delete(stmtId, roleid);
			return result;
        }
		public int DeleteByLoginname(String loginname) {
			String stmtId = "Users.DeleteByLoginname";
			int result = this.sqlMapper.Delete(stmtId, loginname);
			return result;
        }
		public int DeleteByNote(String note) {
			String stmtId = "Users.DeleteByNote";
			int result = this.sqlMapper.Delete(stmtId, note);
			return result;
        }
		public int DeleteByPassword(String password) {
			String stmtId = "Users.DeleteByPassword";
			int result = this.sqlMapper.Delete(stmtId, password);
			return result;
        }
		public void Reload(Users obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Users.Find";
			this.sqlMapper.QueryForObject<Users>(stmtId, obj, obj);
		}
    }
}
