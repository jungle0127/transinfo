using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class VrightsfullinfoDao : IVrightsfullinfoDao
    {
        private ISqlMapper sqlMapper = null;
        public VrightsfullinfoDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Vrightsfullinfo.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Vrightsfullinfo Find(Int64 id) 
        {
			String stmtId = "Vrightsfullinfo.Find";
			Vrightsfullinfo result = this.sqlMapper.QueryForObject<Vrightsfullinfo>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Vrightsfullinfo.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Vrightsfullinfo> FindAll() {
			String stmtId = "Vrightsfullinfo.FindAll";
			IList<Vrightsfullinfo> result = this.sqlMapper.QueryForList<Vrightsfullinfo>(stmtId, null);
			return result;
        }
		public IList<Vrightsfullinfo> PaginationFindAll(VrightsfullinfoPagination obj) {
			String stmtId = "Vrightsfullinfo.FindAllPagination";
			IList<Vrightsfullinfo> result = this.sqlMapper.QueryForList<Vrightsfullinfo>(stmtId, obj);
			return result;
        }
		public IList<Vrightsfullinfo> QuickFindAll() {
			String stmtId = "Vrightsfullinfo.QuickFindAll";
			IList<Vrightsfullinfo> result = this.sqlMapper.QueryForList<Vrightsfullinfo>(stmtId, null);
			return result;
        }
		public IList<Vrightsfullinfo> FindByGroupname(String groupname) {
			String stmtId = "Vrightsfullinfo.FindByGroupname";
			IList<Vrightsfullinfo> result = this.sqlMapper.QueryForList<Vrightsfullinfo>(stmtId, groupname);
			return result;
        }
		public IList<Vrightsfullinfo> PaginationFindByGroupname(VrightsfullinfoPagination obj) {
			String stmtId = "VrightsfullinfoPagination.FindByGroupname";
			IList<Vrightsfullinfo> result = this.sqlMapper.QueryForList<Vrightsfullinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByGroupname(Vrightsfullinfo obj){
			String stmtId = "Vrightsfullinfo.GetFindByGroupnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vrightsfullinfo> FindByRightId(Int64 rightId) {
			String stmtId = "Vrightsfullinfo.FindByRightId";
			IList<Vrightsfullinfo> result = this.sqlMapper.QueryForList<Vrightsfullinfo>(stmtId, rightId);
			return result;
        }
		public IList<Vrightsfullinfo> PaginationFindByRightId(VrightsfullinfoPagination obj) {
			String stmtId = "VrightsfullinfoPagination.FindByRightId";
			IList<Vrightsfullinfo> result = this.sqlMapper.QueryForList<Vrightsfullinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByRightId(Vrightsfullinfo obj){
			String stmtId = "Vrightsfullinfo.GetFindByRightIdCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vrightsfullinfo> FindByRighturl(String righturl) {
			String stmtId = "Vrightsfullinfo.FindByRighturl";
			IList<Vrightsfullinfo> result = this.sqlMapper.QueryForList<Vrightsfullinfo>(stmtId, righturl);
			return result;
        }
		public IList<Vrightsfullinfo> PaginationFindByRighturl(VrightsfullinfoPagination obj) {
			String stmtId = "VrightsfullinfoPagination.FindByRighturl";
			IList<Vrightsfullinfo> result = this.sqlMapper.QueryForList<Vrightsfullinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByRighturl(Vrightsfullinfo obj){
			String stmtId = "Vrightsfullinfo.GetFindByRighturlCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vrightsfullinfo> FindByGroupId(Int64 groupId) {
			String stmtId = "Vrightsfullinfo.FindByGroupId";
			IList<Vrightsfullinfo> result = this.sqlMapper.QueryForList<Vrightsfullinfo>(stmtId, groupId);
			return result;
        }
		public IList<Vrightsfullinfo> PaginationFindByGroupId(VrightsfullinfoPagination obj) {
			String stmtId = "VrightsfullinfoPagination.FindByGroupId";
			IList<Vrightsfullinfo> result = this.sqlMapper.QueryForList<Vrightsfullinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByGroupId(Vrightsfullinfo obj){
			String stmtId = "Vrightsfullinfo.GetFindByGroupIdCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vrightsfullinfo> FindByRightname(String rightname) {
			String stmtId = "Vrightsfullinfo.FindByRightname";
			IList<Vrightsfullinfo> result = this.sqlMapper.QueryForList<Vrightsfullinfo>(stmtId, rightname);
			return result;
        }
		public IList<Vrightsfullinfo> PaginationFindByRightname(VrightsfullinfoPagination obj) {
			String stmtId = "VrightsfullinfoPagination.FindByRightname";
			IList<Vrightsfullinfo> result = this.sqlMapper.QueryForList<Vrightsfullinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByRightname(Vrightsfullinfo obj){
			String stmtId = "Vrightsfullinfo.GetFindByRightnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Reload(Vrightsfullinfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Vrightsfullinfo.Find";
			this.sqlMapper.QueryForObject<Vrightsfullinfo>(stmtId, obj, obj);
		}
    }
}
