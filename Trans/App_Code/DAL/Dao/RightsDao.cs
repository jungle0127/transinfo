using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class RightsDao : IRightsDao
    {
        private ISqlMapper sqlMapper = null;
        public RightsDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Rights.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Rights Find(Int64 id) 
        {
			String stmtId = "Rights.Find";
			Rights result = this.sqlMapper.QueryForObject<Rights>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Rights.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Rights> FindAll() {
			String stmtId = "Rights.FindAll";
			IList<Rights> result = this.sqlMapper.QueryForList<Rights>(stmtId, null);
			return result;
        }
		public IList<Rights> PaginationFindAll(RightsPagination obj) {
			String stmtId = "Rights.FindAllPagination";
			IList<Rights> result = this.sqlMapper.QueryForList<Rights>(stmtId, obj);
			return result;
        }
		public IList<Rights> QuickFindAll() {
			String stmtId = "Rights.QuickFindAll";
			IList<Rights> result = this.sqlMapper.QueryForList<Rights>(stmtId, null);
			return result;
        }
		public IList<Rights> FindByActive(Byte active) {
			String stmtId = "Rights.FindByActive";
			IList<Rights> result = this.sqlMapper.QueryForList<Rights>(stmtId, active);
			return result;
        }
		public IList<Rights> PaginationFindByActive(RightsPagination obj) {
			String stmtId = "RightsPagination.FindByActive";
			IList<Rights> result = this.sqlMapper.QueryForList<Rights>(stmtId, obj);
			return result;
        }
		public int FindCountByActive(Rights obj){
			String stmtId = "Rights.GetFindByActiveCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Rights> FindByRighturl(String righturl) {
			String stmtId = "Rights.FindByRighturl";
			IList<Rights> result = this.sqlMapper.QueryForList<Rights>(stmtId, righturl);
			return result;
        }
		public IList<Rights> PaginationFindByRighturl(RightsPagination obj) {
			String stmtId = "RightsPagination.FindByRighturl";
			IList<Rights> result = this.sqlMapper.QueryForList<Rights>(stmtId, obj);
			return result;
        }
		public int FindCountByRighturl(Rights obj){
			String stmtId = "Rights.GetFindByRighturlCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Rights> FindByRightname(String rightname) {
			String stmtId = "Rights.FindByRightname";
			IList<Rights> result = this.sqlMapper.QueryForList<Rights>(stmtId, rightname);
			return result;
        }
		public IList<Rights> PaginationFindByRightname(RightsPagination obj) {
			String stmtId = "RightsPagination.FindByRightname";
			IList<Rights> result = this.sqlMapper.QueryForList<Rights>(stmtId, obj);
			return result;
        }
		public int FindCountByRightname(Rights obj){
			String stmtId = "Rights.GetFindByRightnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Rights obj) {
			String stmtId = "Rights.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Rights obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Rights.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Rights obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Rights.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByActive(Byte active) {
			String stmtId = "Rights.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public int DeleteByRighturl(String righturl) {
			String stmtId = "Rights.DeleteByRighturl";
			int result = this.sqlMapper.Delete(stmtId, righturl);
			return result;
        }
		public int DeleteByRightname(String rightname) {
			String stmtId = "Rights.DeleteByRightname";
			int result = this.sqlMapper.Delete(stmtId, rightname);
			return result;
        }
		public void Reload(Rights obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Rights.Find";
			this.sqlMapper.QueryForObject<Rights>(stmtId, obj, obj);
		}
    }
}
