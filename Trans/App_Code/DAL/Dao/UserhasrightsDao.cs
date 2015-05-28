using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class UserhasrightsDao : IUserhasrightsDao
    {
        private ISqlMapper sqlMapper = null;
        public UserhasrightsDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Userhasrights.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Userhasrights Find(Int64 id) 
        {
			String stmtId = "Userhasrights.Find";
			Userhasrights result = this.sqlMapper.QueryForObject<Userhasrights>(stmtId, id);
			return result;
        }
		public IList<Userhasrights> FindAll() {
			String stmtId = "Userhasrights.FindAll";
			IList<Userhasrights> result = this.sqlMapper.QueryForList<Userhasrights>(stmtId, null);
			return result;
        }
		public IList<Userhasrights> PaginationFindAll(UserhasrightsPagination obj) {
			String stmtId = "Userhasrights.FindAllPagination";
			IList<Userhasrights> result = this.sqlMapper.QueryForList<Userhasrights>(stmtId, obj);
			return result;
        }
		public IList<Userhasrights> QuickFindAll() {
			String stmtId = "Userhasrights.QuickFindAll";
			IList<Userhasrights> result = this.sqlMapper.QueryForList<Userhasrights>(stmtId, null);
			return result;
        }
		public IList<Userhasrights> FindByUserid(Int64 userid) {
			String stmtId = "Userhasrights.FindByUserid";
			IList<Userhasrights> result = this.sqlMapper.QueryForList<Userhasrights>(stmtId, userid);
			return result;
        }
		public IList<Userhasrights> PaginationFindByUserid(UserhasrightsPagination obj) {
			String stmtId = "UserhasrightsPagination.FindByUserid";
			IList<Userhasrights> result = this.sqlMapper.QueryForList<Userhasrights>(stmtId, obj);
			return result;
        }
		public IList<Userhasrights> FindByRightid(Int64 rightid) {
			String stmtId = "Userhasrights.FindByRightid";
			IList<Userhasrights> result = this.sqlMapper.QueryForList<Userhasrights>(stmtId, rightid);
			return result;
        }
		public IList<Userhasrights> PaginationFindByRightid(UserhasrightsPagination obj) {
			String stmtId = "UserhasrightsPagination.FindByRightid";
			IList<Userhasrights> result = this.sqlMapper.QueryForList<Userhasrights>(stmtId, obj);
			return result;
        }
		public IList<Userhasrights> FindByAcitve(Byte acitve) {
			String stmtId = "Userhasrights.FindByAcitve";
			IList<Userhasrights> result = this.sqlMapper.QueryForList<Userhasrights>(stmtId, acitve);
			return result;
        }
		public IList<Userhasrights> PaginationFindByAcitve(UserhasrightsPagination obj) {
			String stmtId = "UserhasrightsPagination.FindByAcitve";
			IList<Userhasrights> result = this.sqlMapper.QueryForList<Userhasrights>(stmtId, obj);
			return result;
        }
		public void Update(Userhasrights obj) {
			String stmtId = "Userhasrights.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Userhasrights obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Userhasrights.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Userhasrights obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Userhasrights.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByUserid(Int64 userid) {
			String stmtId = "Userhasrights.DeleteByUserid";
			int result = this.sqlMapper.Delete(stmtId, userid);
			return result;
        }
		public int DeleteByRightid(Int64 rightid) {
			String stmtId = "Userhasrights.DeleteByRightid";
			int result = this.sqlMapper.Delete(stmtId, rightid);
			return result;
        }
		public int DeleteByAcitve(Byte acitve) {
			String stmtId = "Userhasrights.DeleteByAcitve";
			int result = this.sqlMapper.Delete(stmtId, acitve);
			return result;
        }
		public void Reload(Userhasrights obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Userhasrights.Find";
			this.sqlMapper.QueryForObject<Userhasrights>(stmtId, obj, obj);
		}
    }
}
