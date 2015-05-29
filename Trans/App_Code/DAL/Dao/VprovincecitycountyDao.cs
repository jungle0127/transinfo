using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class VprovincecitycountyDao : IVprovincecitycountyDao
    {
        private ISqlMapper sqlMapper = null;
        public VprovincecitycountyDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Vprovincecitycounty.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Vprovincecitycounty Find(Int64 id) 
        {
			String stmtId = "Vprovincecitycounty.Find";
			Vprovincecitycounty result = this.sqlMapper.QueryForObject<Vprovincecitycounty>(stmtId, id);
			return result;
        }
		public IList<Vprovincecitycounty> FindAll() {
			String stmtId = "Vprovincecitycounty.FindAll";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, null);
			return result;
        }
		public IList<Vprovincecitycounty> PaginationFindAll(VprovincecitycountyPagination obj) {
			String stmtId = "Vprovincecitycounty.FindAllPagination";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, obj);
			return result;
        }
		public IList<Vprovincecitycounty> QuickFindAll() {
			String stmtId = "Vprovincecitycounty.QuickFindAll";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, null);
			return result;
        }
		public IList<Vprovincecitycounty> FindByFullname(String fullname) {
			String stmtId = "Vprovincecitycounty.FindByFullname";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, fullname);
			return result;
        }
		public IList<Vprovincecitycounty> PaginationFindByFullname(VprovincecitycountyPagination obj) {
			String stmtId = "VprovincecitycountyPagination.FindByFullname";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, obj);
			return result;
        }
		public IList<Vprovincecitycounty> FindByCityname(String cityname) {
			String stmtId = "Vprovincecitycounty.FindByCityname";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, cityname);
			return result;
        }
		public IList<Vprovincecitycounty> PaginationFindByCityname(VprovincecitycountyPagination obj) {
			String stmtId = "VprovincecitycountyPagination.FindByCityname";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, obj);
			return result;
        }
		public IList<Vprovincecitycounty> FindByProvincecode(String provincecode) {
			String stmtId = "Vprovincecitycounty.FindByProvincecode";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, provincecode);
			return result;
        }
		public IList<Vprovincecitycounty> PaginationFindByProvincecode(VprovincecitycountyPagination obj) {
			String stmtId = "VprovincecitycountyPagination.FindByProvincecode";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, obj);
			return result;
        }
		public IList<Vprovincecitycounty> FindByCitycode(String citycode) {
			String stmtId = "Vprovincecitycounty.FindByCitycode";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, citycode);
			return result;
        }
		public IList<Vprovincecitycounty> PaginationFindByCitycode(VprovincecitycountyPagination obj) {
			String stmtId = "VprovincecitycountyPagination.FindByCitycode";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, obj);
			return result;
        }
		public IList<Vprovincecitycounty> FindByCountyname(String countyname) {
			String stmtId = "Vprovincecitycounty.FindByCountyname";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, countyname);
			return result;
        }
		public IList<Vprovincecitycounty> PaginationFindByCountyname(VprovincecitycountyPagination obj) {
			String stmtId = "VprovincecitycountyPagination.FindByCountyname";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, obj);
			return result;
        }
		public IList<Vprovincecitycounty> FindByProvincename(String provincename) {
			String stmtId = "Vprovincecitycounty.FindByProvincename";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, provincename);
			return result;
        }
		public IList<Vprovincecitycounty> PaginationFindByProvincename(VprovincecitycountyPagination obj) {
			String stmtId = "VprovincecitycountyPagination.FindByProvincename";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, obj);
			return result;
        }
		public IList<Vprovincecitycounty> FindByCountycode(String countycode) {
			String stmtId = "Vprovincecitycounty.FindByCountycode";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, countycode);
			return result;
        }
		public IList<Vprovincecitycounty> PaginationFindByCountycode(VprovincecitycountyPagination obj) {
			String stmtId = "VprovincecitycountyPagination.FindByCountycode";
			IList<Vprovincecitycounty> result = this.sqlMapper.QueryForList<Vprovincecitycounty>(stmtId, obj);
			return result;
        }
		public void Reload(Vprovincecitycounty obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Vprovincecitycounty.Find";
			this.sqlMapper.QueryForObject<Vprovincecitycounty>(stmtId, obj, obj);
		}
    }
}
