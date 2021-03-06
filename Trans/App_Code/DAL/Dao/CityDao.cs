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
		public int GetFindCount(Int64 id) {
			String stmtId = "City.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<City> FindAll() {
			String stmtId = "City.FindAll";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, null);
			return result;
        }
		public IList<City> DescendOrderFindAll() {
			String stmtId = "City.DescendOrderFindAll";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, null);
			return result;
        }
		public IList<City> PaginationFindAll(CityPagination obj) {
			String stmtId = "City.FindAllPagination";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, obj);
			return result;
        }
		public IList<City> DescendOrderPaginationFindAll(CityPagination obj) {
			String stmtId = "City.DescendOrderFindAllPagination";
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
		public IList<City> DescendOrderFindByProvincecode(String provincecode) {
			String stmtId = "City.DescendOrderFindByProvincecode";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, provincecode);
			return result;
        }
		public IList<City> PaginationFindByProvincecode(CityPagination obj) {
			String stmtId = "CityPagination.FindByProvincecode";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, obj);
			return result;
        }
		public IList<City> DescendOrderPaginationFindByProvincecode(CityPagination obj) {
			String stmtId = "CityPagination.DescendOrderFindByProvincecode";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, obj);
			return result;
        }
		public int FindCountByProvincecode(City obj){
			String stmtId = "City.GetFindByProvincecodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<City> FindByCode(String code) {
			String stmtId = "City.FindByCode";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, code);
			return result;
        }
		public IList<City> DescendOrderFindByCode(String code) {
			String stmtId = "City.DescendOrderFindByCode";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, code);
			return result;
        }
		public IList<City> PaginationFindByCode(CityPagination obj) {
			String stmtId = "CityPagination.FindByCode";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, obj);
			return result;
        }
		public IList<City> DescendOrderPaginationFindByCode(CityPagination obj) {
			String stmtId = "CityPagination.DescendOrderFindByCode";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, obj);
			return result;
        }
		public int FindCountByCode(City obj){
			String stmtId = "City.GetFindByCodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<City> FindByName(String name) {
			String stmtId = "City.FindByName";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, name);
			return result;
        }
		public IList<City> DescendOrderFindByName(String name) {
			String stmtId = "City.DescendOrderFindByName";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, name);
			return result;
        }
		public IList<City> PaginationFindByName(CityPagination obj) {
			String stmtId = "CityPagination.FindByName";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, obj);
			return result;
        }
		public IList<City> DescendOrderPaginationFindByName(CityPagination obj) {
			String stmtId = "CityPagination.DescendOrderFindByName";
			IList<City> result = this.sqlMapper.QueryForList<City>(stmtId, obj);
			return result;
        }
		public int FindCountByName(City obj){
			String stmtId = "City.GetFindByNameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
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
