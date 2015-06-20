using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class VuserrightsDao : IVuserrightsDao
    {
        private ISqlMapper sqlMapper = null;
        public VuserrightsDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Vuserrights.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Vuserrights Find(Int64 id) 
        {
			String stmtId = "Vuserrights.Find";
			Vuserrights result = this.sqlMapper.QueryForObject<Vuserrights>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Vuserrights.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Vuserrights> FindAll() {
			String stmtId = "Vuserrights.FindAll";
			IList<Vuserrights> result = this.sqlMapper.QueryForList<Vuserrights>(stmtId, null);
			return result;
        }
		public IList<Vuserrights> PaginationFindAll(VuserrightsPagination obj) {
			String stmtId = "Vuserrights.FindAllPagination";
			IList<Vuserrights> result = this.sqlMapper.QueryForList<Vuserrights>(stmtId, obj);
			return result;
        }
		public IList<Vuserrights> QuickFindAll() {
			String stmtId = "Vuserrights.QuickFindAll";
			IList<Vuserrights> result = this.sqlMapper.QueryForList<Vuserrights>(stmtId, null);
			return result;
        }
		public IList<Vuserrights> FindByUserid(Int64 userid) {
			String stmtId = "Vuserrights.FindByUserid";
			IList<Vuserrights> result = this.sqlMapper.QueryForList<Vuserrights>(stmtId, userid);
			return result;
        }
		public IList<Vuserrights> PaginationFindByUserid(VuserrightsPagination obj) {
			String stmtId = "VuserrightsPagination.FindByUserid";
			IList<Vuserrights> result = this.sqlMapper.QueryForList<Vuserrights>(stmtId, obj);
			return result;
        }
		public int FindCountByUserid(Vuserrights obj){
			String stmtId = "Vuserrights.GetFindByUseridCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vuserrights> FindByRightid(Int64 rightid) {
			String stmtId = "Vuserrights.FindByRightid";
			IList<Vuserrights> result = this.sqlMapper.QueryForList<Vuserrights>(stmtId, rightid);
			return result;
        }
		public IList<Vuserrights> PaginationFindByRightid(VuserrightsPagination obj) {
			String stmtId = "VuserrightsPagination.FindByRightid";
			IList<Vuserrights> result = this.sqlMapper.QueryForList<Vuserrights>(stmtId, obj);
			return result;
        }
		public int FindCountByRightid(Vuserrights obj){
			String stmtId = "Vuserrights.GetFindByRightidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vuserrights> FindByRighturl(String righturl) {
			String stmtId = "Vuserrights.FindByRighturl";
			IList<Vuserrights> result = this.sqlMapper.QueryForList<Vuserrights>(stmtId, righturl);
			return result;
        }
		public IList<Vuserrights> PaginationFindByRighturl(VuserrightsPagination obj) {
			String stmtId = "VuserrightsPagination.FindByRighturl";
			IList<Vuserrights> result = this.sqlMapper.QueryForList<Vuserrights>(stmtId, obj);
			return result;
        }
		public int FindCountByRighturl(Vuserrights obj){
			String stmtId = "Vuserrights.GetFindByRighturlCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vuserrights> FindByGroupname(String groupname) {
			String stmtId = "Vuserrights.FindByGroupname";
			IList<Vuserrights> result = this.sqlMapper.QueryForList<Vuserrights>(stmtId, groupname);
			return result;
        }
		public IList<Vuserrights> PaginationFindByGroupname(VuserrightsPagination obj) {
			String stmtId = "VuserrightsPagination.FindByGroupname";
			IList<Vuserrights> result = this.sqlMapper.QueryForList<Vuserrights>(stmtId, obj);
			return result;
        }
		public int FindCountByGroupname(Vuserrights obj){
			String stmtId = "Vuserrights.GetFindByGroupnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vuserrights> FindByRightname(String rightname) {
			String stmtId = "Vuserrights.FindByRightname";
			IList<Vuserrights> result = this.sqlMapper.QueryForList<Vuserrights>(stmtId, rightname);
			return result;
        }
		public IList<Vuserrights> PaginationFindByRightname(VuserrightsPagination obj) {
			String stmtId = "VuserrightsPagination.FindByRightname";
			IList<Vuserrights> result = this.sqlMapper.QueryForList<Vuserrights>(stmtId, obj);
			return result;
        }
		public int FindCountByRightname(Vuserrights obj){
			String stmtId = "Vuserrights.GetFindByRightnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Reload(Vuserrights obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Vuserrights.Find";
			this.sqlMapper.QueryForObject<Vuserrights>(stmtId, obj, obj);
		}
    }
}
