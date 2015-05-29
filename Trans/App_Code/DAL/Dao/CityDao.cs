using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class CityDao : ICityDao
    {
        private ISqlMapper sqlMapper = null;
        public CityDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "City.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public City Find(Int64 id) 
        {
			String stmtId = "City.Find";
			City result = this.sqlMapper.QueryForObject<City>(stmtId, id);
			return result;
        }
		public IList<City> FindAll() {
			String stmtId = "City.FindAll";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, null);
			return result;
        }
		public IList<City> PaginationFindAll(CityPagination obj) {
			String stmtId = "City.FindAllPagination";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, obj);
			return result;
        }
		public IList<City> QuickFindAll() {
			String stmtId = "City.QuickFindAll";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, null);
			return result;
        }
		public IList<City> FindByProvincecode(String provincecode) {
			String stmtId = "City.FindByProvincecode";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, provincecode);
			return result;
        }
		public IList<City> PaginationFindByProvincecode(CityPagination obj) {
			String stmtId = "CityPagination.FindByProvincecode";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, obj);
			return result;
        }
		public IList<City> FindByCode(String code) {
			String stmtId = "City.FindByCode";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, code);
			return result;
        }
		public IList<City> PaginationFindByCode(CityPagination obj) {
			String stmtId = "CityPagination.FindByCode";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, obj);
			return result;
        }
		public IList<City> FindByName(String name) {
			String stmtId = "City.FindByName";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, name);
			return result;
        }
		public IList<City> PaginationFindByName(CityPagination obj) {
			String stmtId = "CityPagination.FindByName";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, obj);
			return result;
        }
		public void Update(City obj) {
			String stmtId = "City.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(City obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "City.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(City obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "City.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByProvincecode(String provincecode) {
			String stmtId = "City.DeleteByProvincecode";
			int result = this.sqlMapper.Delete(stmtId, provincecode);
			return result;
        }
		public int DeleteByCode(String code) {
			String stmtId = "City.DeleteByCode";
			int result = this.sqlMapper.Delete(stmtId, code);
			return result;
        }
		public int DeleteByName(String name) {
			String stmtId = "City.DeleteByName";
			int result = this.sqlMapper.Delete(stmtId, name);
			return result;
        }
		public void Reload(City obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "City.Find";
			this.sqlMapper.QueryForObject<City>(stmtId, obj, obj);
		}
    }
}
