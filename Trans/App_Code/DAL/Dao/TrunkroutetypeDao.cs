using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class TrunkroutetypeDao : ITrunkroutetypeDao
    {
        private ISqlMapper sqlMapper = null;
        public TrunkroutetypeDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Trunkroutetype.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Trunkroutetype Find(Int64 id) 
        {
			String stmtId = "Trunkroutetype.Find";
			Trunkroutetype result = this.sqlMapper.QueryForObject<Trunkroutetype>(stmtId, id);
			return result;
        }
		public IList<Trunkroutetype> FindAll() {
			String stmtId = "Trunkroutetype.FindAll";
			IList<Trunkroutetype> result = this.sqlMapper.QueryForList<Trunkroutetype>(stmtId, null);
			return result;
        }
		public IList<Trunkroutetype> PaginationFindAll(TrunkroutetypePagination obj) {
			String stmtId = "Trunkroutetype.FindAllPagination";
			IList<Trunkroutetype> result = this.sqlMapper.QueryForList<Trunkroutetype>(stmtId, obj);
			return result;
        }
		public IList<Trunkroutetype> QuickFindAll() {
			String stmtId = "Trunkroutetype.QuickFindAll";
			IList<Trunkroutetype> result = this.sqlMapper.QueryForList<Trunkroutetype>(stmtId, null);
			return result;
        }
		public IList<Trunkroutetype> FindByTypename(String typename) {
			String stmtId = "Trunkroutetype.FindByTypename";
			IList<Trunkroutetype> result = this.sqlMapper.QueryForList<Trunkroutetype>(stmtId, typename);
			return result;
        }
		public IList<Trunkroutetype> PaginationFindByTypename(TrunkroutetypePagination obj) {
			String stmtId = "TrunkroutetypePagination.FindByTypename";
			IList<Trunkroutetype> result = this.sqlMapper.QueryForList<Trunkroutetype>(stmtId, obj);
			return result;
        }
		public void Update(Trunkroutetype obj) {
			String stmtId = "Trunkroutetype.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Trunkroutetype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunkroutetype.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Trunkroutetype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunkroutetype.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByTypename(String typename) {
			String stmtId = "Trunkroutetype.DeleteByTypename";
			int result = this.sqlMapper.Delete(stmtId, typename);
			return result;
        }
		public void Reload(Trunkroutetype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunkroutetype.Find";
			this.sqlMapper.QueryForObject<Trunkroutetype>(stmtId, obj, obj);
		}
    }
}
