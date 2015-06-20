using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class ProvinceDao : IProvinceDao
    {
        private ISqlMapper sqlMapper = null;
        public ProvinceDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Province.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Province Find(Int64 id) 
        {
			String stmtId = "Province.Find";
			Province result = this.sqlMapper.QueryForObject<Province>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Province.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Province> FindAll() {
			String stmtId = "Province.FindAll";
			IList<Province> result = this.sqlMapper.QueryForList<Province>(stmtId, null);
			return result;
        }
		public IList<Province> PaginationFindAll(ProvincePagination obj) {
			String stmtId = "Province.FindAllPagination";
			IList<Province> result = this.sqlMapper.QueryForList<Province>(stmtId, obj);
			return result;
        }
		public IList<Province> QuickFindAll() {
			String stmtId = "Province.QuickFindAll";
			IList<Province> result = this.sqlMapper.QueryForList<Province>(stmtId, null);
			return result;
        }
		public IList<Province> FindByCode(String code) {
			String stmtId = "Province.FindByCode";
			IList<Province> result = this.sqlMapper.QueryForList<Province>(stmtId, code);
			return result;
        }
		public IList<Province> PaginationFindByCode(ProvincePagination obj) {
			String stmtId = "ProvincePagination.FindByCode";
			IList<Province> result = this.sqlMapper.QueryForList<Province>(stmtId, obj);
			return result;
        }
		public int FindCountByCode(Province obj){
			String stmtId = "Province.GetFindByCodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Province> FindByName(String name) {
			String stmtId = "Province.FindByName";
			IList<Province> result = this.sqlMapper.QueryForList<Province>(stmtId, name);
			return result;
        }
		public IList<Province> PaginationFindByName(ProvincePagination obj) {
			String stmtId = "ProvincePagination.FindByName";
			IList<Province> result = this.sqlMapper.QueryForList<Province>(stmtId, obj);
			return result;
        }
		public int FindCountByName(Province obj){
			String stmtId = "Province.GetFindByNameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Province obj) {
			String stmtId = "Province.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Province obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Province.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Province obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Province.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByCode(String code) {
			String stmtId = "Province.DeleteByCode";
			int result = this.sqlMapper.Delete(stmtId, code);
			return result;
        }
		public int DeleteByName(String name) {
			String stmtId = "Province.DeleteByName";
			int result = this.sqlMapper.Delete(stmtId, name);
			return result;
        }
		public void Reload(Province obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Province.Find";
			this.sqlMapper.QueryForObject<Province>(stmtId, obj, obj);
		}
    }
}
