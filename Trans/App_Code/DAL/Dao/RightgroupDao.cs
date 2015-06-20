using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class RightgroupDao : IRightgroupDao
    {
        private ISqlMapper sqlMapper = null;
        public RightgroupDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Rightgroup.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Rightgroup Find(Int64 id) 
        {
			String stmtId = "Rightgroup.Find";
			Rightgroup result = this.sqlMapper.QueryForObject<Rightgroup>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Rightgroup.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Rightgroup> FindAll() {
			String stmtId = "Rightgroup.FindAll";
			IList<Rightgroup> result = this.sqlMapper.QueryForList<Rightgroup>(stmtId, null);
			return result;
        }
		public IList<Rightgroup> PaginationFindAll(RightgroupPagination obj) {
			String stmtId = "Rightgroup.FindAllPagination";
			IList<Rightgroup> result = this.sqlMapper.QueryForList<Rightgroup>(stmtId, obj);
			return result;
        }
		public IList<Rightgroup> QuickFindAll() {
			String stmtId = "Rightgroup.QuickFindAll";
			IList<Rightgroup> result = this.sqlMapper.QueryForList<Rightgroup>(stmtId, null);
			return result;
        }
		public IList<Rightgroup> FindByActive(Byte active) {
			String stmtId = "Rightgroup.FindByActive";
			IList<Rightgroup> result = this.sqlMapper.QueryForList<Rightgroup>(stmtId, active);
			return result;
        }
		public IList<Rightgroup> PaginationFindByActive(RightgroupPagination obj) {
			String stmtId = "RightgroupPagination.FindByActive";
			IList<Rightgroup> result = this.sqlMapper.QueryForList<Rightgroup>(stmtId, obj);
			return result;
        }
		public int FindCountByActive(Rightgroup obj){
			String stmtId = "Rightgroup.GetFindByActiveCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Rightgroup> FindByGroupname(String groupname) {
			String stmtId = "Rightgroup.FindByGroupname";
			IList<Rightgroup> result = this.sqlMapper.QueryForList<Rightgroup>(stmtId, groupname);
			return result;
        }
		public IList<Rightgroup> PaginationFindByGroupname(RightgroupPagination obj) {
			String stmtId = "RightgroupPagination.FindByGroupname";
			IList<Rightgroup> result = this.sqlMapper.QueryForList<Rightgroup>(stmtId, obj);
			return result;
        }
		public int FindCountByGroupname(Rightgroup obj){
			String stmtId = "Rightgroup.GetFindByGroupnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Rightgroup obj) {
			String stmtId = "Rightgroup.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Rightgroup obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Rightgroup.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Rightgroup obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Rightgroup.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByActive(Byte active) {
			String stmtId = "Rightgroup.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public int DeleteByGroupname(String groupname) {
			String stmtId = "Rightgroup.DeleteByGroupname";
			int result = this.sqlMapper.Delete(stmtId, groupname);
			return result;
        }
		public void Reload(Rightgroup obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Rightgroup.Find";
			this.sqlMapper.QueryForObject<Rightgroup>(stmtId, obj, obj);
		}
    }
}
