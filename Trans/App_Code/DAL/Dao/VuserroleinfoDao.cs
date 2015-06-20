using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class VuserroleinfoDao : IVuserroleinfoDao
    {
        private ISqlMapper sqlMapper = null;
        public VuserroleinfoDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Vuserroleinfo.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Vuserroleinfo Find(Int64 id) 
        {
			String stmtId = "Vuserroleinfo.Find";
			Vuserroleinfo result = this.sqlMapper.QueryForObject<Vuserroleinfo>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Vuserroleinfo.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Vuserroleinfo> FindAll() {
			String stmtId = "Vuserroleinfo.FindAll";
			IList<Vuserroleinfo> result = this.sqlMapper.QueryForList<Vuserroleinfo>(stmtId, null);
			return result;
        }
		public IList<Vuserroleinfo> PaginationFindAll(VuserroleinfoPagination obj) {
			String stmtId = "Vuserroleinfo.FindAllPagination";
			IList<Vuserroleinfo> result = this.sqlMapper.QueryForList<Vuserroleinfo>(stmtId, obj);
			return result;
        }
		public IList<Vuserroleinfo> QuickFindAll() {
			String stmtId = "Vuserroleinfo.QuickFindAll";
			IList<Vuserroleinfo> result = this.sqlMapper.QueryForList<Vuserroleinfo>(stmtId, null);
			return result;
        }
		public IList<Vuserroleinfo> FindByUserid(Int64 userid) {
			String stmtId = "Vuserroleinfo.FindByUserid";
			IList<Vuserroleinfo> result = this.sqlMapper.QueryForList<Vuserroleinfo>(stmtId, userid);
			return result;
        }
		public IList<Vuserroleinfo> PaginationFindByUserid(VuserroleinfoPagination obj) {
			String stmtId = "VuserroleinfoPagination.FindByUserid";
			IList<Vuserroleinfo> result = this.sqlMapper.QueryForList<Vuserroleinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByUserid(Vuserroleinfo obj){
			String stmtId = "Vuserroleinfo.GetFindByUseridCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vuserroleinfo> FindByLoginname(String loginname) {
			String stmtId = "Vuserroleinfo.FindByLoginname";
			IList<Vuserroleinfo> result = this.sqlMapper.QueryForList<Vuserroleinfo>(stmtId, loginname);
			return result;
        }
		public IList<Vuserroleinfo> PaginationFindByLoginname(VuserroleinfoPagination obj) {
			String stmtId = "VuserroleinfoPagination.FindByLoginname";
			IList<Vuserroleinfo> result = this.sqlMapper.QueryForList<Vuserroleinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByLoginname(Vuserroleinfo obj){
			String stmtId = "Vuserroleinfo.GetFindByLoginnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vuserroleinfo> FindByUsername(String username) {
			String stmtId = "Vuserroleinfo.FindByUsername";
			IList<Vuserroleinfo> result = this.sqlMapper.QueryForList<Vuserroleinfo>(stmtId, username);
			return result;
        }
		public IList<Vuserroleinfo> PaginationFindByUsername(VuserroleinfoPagination obj) {
			String stmtId = "VuserroleinfoPagination.FindByUsername";
			IList<Vuserroleinfo> result = this.sqlMapper.QueryForList<Vuserroleinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByUsername(Vuserroleinfo obj){
			String stmtId = "Vuserroleinfo.GetFindByUsernameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vuserroleinfo> FindByRoleid(Int64 roleid) {
			String stmtId = "Vuserroleinfo.FindByRoleid";
			IList<Vuserroleinfo> result = this.sqlMapper.QueryForList<Vuserroleinfo>(stmtId, roleid);
			return result;
        }
		public IList<Vuserroleinfo> PaginationFindByRoleid(VuserroleinfoPagination obj) {
			String stmtId = "VuserroleinfoPagination.FindByRoleid";
			IList<Vuserroleinfo> result = this.sqlMapper.QueryForList<Vuserroleinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByRoleid(Vuserroleinfo obj){
			String stmtId = "Vuserroleinfo.GetFindByRoleidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vuserroleinfo> FindByRolename(String rolename) {
			String stmtId = "Vuserroleinfo.FindByRolename";
			IList<Vuserroleinfo> result = this.sqlMapper.QueryForList<Vuserroleinfo>(stmtId, rolename);
			return result;
        }
		public IList<Vuserroleinfo> PaginationFindByRolename(VuserroleinfoPagination obj) {
			String stmtId = "VuserroleinfoPagination.FindByRolename";
			IList<Vuserroleinfo> result = this.sqlMapper.QueryForList<Vuserroleinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByRolename(Vuserroleinfo obj){
			String stmtId = "Vuserroleinfo.GetFindByRolenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Reload(Vuserroleinfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Vuserroleinfo.Find";
			this.sqlMapper.QueryForObject<Vuserroleinfo>(stmtId, obj, obj);
		}
    }
}
