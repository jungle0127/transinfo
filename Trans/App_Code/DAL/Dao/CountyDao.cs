using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class CountyDao : ICountyDao
    {
        private ISqlMapper sqlMapper = null;
        public CountyDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "County.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public County Find(Int64 id) 
        {
			String stmtId = "County.Find";
			County result = this.sqlMapper.QueryForObject<County>(stmtId, id);
			return result;
        }
		public IList<County> FindAll() {
			String stmtId = "County.FindAll";
			IList<County> result = this.sqlMapper.QueryForList<County>(stmtId, null);
			return result;
        }
		public IList<County> PaginationFindAll(CountyPagination obj) {
			String stmtId = "County.FindAllPagination";
			IList<County> result = this.sqlMapper.QueryForList<County>(stmtId, obj);
			return result;
        }
		public IList<County> QuickFindAll() {
			String stmtId = "County.QuickFindAll";
			IList<County> result = this.sqlMapper.QueryForList<County>(stmtId, null);
			return result;
        }
		public IList<County> FindByCitycode(String citycode) {
			String stmtId = "County.FindByCitycode";
			IList<County> result = this.sqlMapper.QueryForList<County>(stmtId, citycode);
			return result;
        }
		public IList<County> PaginationFindByCitycode(CountyPagination obj) {
			String stmtId = "CountyPagination.FindByCitycode";
			IList<County> result = this.sqlMapper.QueryForList<County>(stmtId, obj);
			return result;
        }
		public IList<County> FindByCode(String code) {
			String stmtId = "County.FindByCode";
			IList<County> result = this.sqlMapper.QueryForList<County>(stmtId, code);
			return result;
        }
		public IList<County> PaginationFindByCode(CountyPagination obj) {
			String stmtId = "CountyPagination.FindByCode";
			IList<County> result = this.sqlMapper.QueryForList<County>(stmtId, obj);
			return result;
        }
		public IList<County> FindByName(String name) {
			String stmtId = "County.FindByName";
			IList<County> result = this.sqlMapper.QueryForList<County>(stmtId, name);
			return result;
        }
		public IList<County> PaginationFindByName(CountyPagination obj) {
			String stmtId = "CountyPagination.FindByName";
			IList<County> result = this.sqlMapper.QueryForList<County>(stmtId, obj);
			return result;
        }
		public void Update(County obj) {
			String stmtId = "County.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(County obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "County.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(County obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "County.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByCitycode(String citycode) {
			String stmtId = "County.DeleteByCitycode";
			int result = this.sqlMapper.Delete(stmtId, citycode);
			return result;
        }
		public int DeleteByCode(String code) {
			String stmtId = "County.DeleteByCode";
			int result = this.sqlMapper.Delete(stmtId, code);
			return result;
        }
		public int DeleteByName(String name) {
			String stmtId = "County.DeleteByName";
			int result = this.sqlMapper.Delete(stmtId, name);
			return result;
        }
		public void Reload(County obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "County.Find";
			this.sqlMapper.QueryForObject<County>(stmtId, obj, obj);
		}
    }
}
