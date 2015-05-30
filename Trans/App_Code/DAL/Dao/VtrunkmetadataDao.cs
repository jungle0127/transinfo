using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class VtrunkmetadataDao : IVtrunkmetadataDao
    {
        private ISqlMapper sqlMapper = null;
        public VtrunkmetadataDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Vtrunkmetadata.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Vtrunkmetadata Find(Int64 id) 
        {
			String stmtId = "Vtrunkmetadata.Find";
			Vtrunkmetadata result = this.sqlMapper.QueryForObject<Vtrunkmetadata>(stmtId, id);
			return result;
        }
		public IList<Vtrunkmetadata> FindAll() {
			String stmtId = "Vtrunkmetadata.FindAll";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, null);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindAll(VtrunkmetadataPagination obj) {
			String stmtId = "Vtrunkmetadata.FindAllPagination";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> QuickFindAll() {
			String stmtId = "Vtrunkmetadata.QuickFindAll";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, null);
			return result;
        }
		public IList<Vtrunkmetadata> FindByVantypename(String vantypename) {
			String stmtId = "Vtrunkmetadata.FindByVantypename";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, vantypename);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByVantypename(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByVantypename";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindByContactpersonname(String contactpersonname) {
			String stmtId = "Vtrunkmetadata.FindByContactpersonname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, contactpersonname);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByContactpersonname(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByContactpersonname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindByTrunktypename(String trunktypename) {
			String stmtId = "Vtrunkmetadata.FindByTrunktypename";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, trunktypename);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByTrunktypename(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByTrunktypename";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindByConatactphone(String conatactphone) {
			String stmtId = "Vtrunkmetadata.FindByConatactphone";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, conatactphone);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByConatactphone(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByConatactphone";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindByVolume(String volume) {
			String stmtId = "Vtrunkmetadata.FindByVolume";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, volume);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByVolume(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByVolume";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindByNumber(String number) {
			String stmtId = "Vtrunkmetadata.FindByNumber";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, number);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByNumber(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByNumber";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindByBrand(String brand) {
			String stmtId = "Vtrunkmetadata.FindByBrand";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, brand);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByBrand(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByBrand";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindByLength(String length) {
			String stmtId = "Vtrunkmetadata.FindByLength";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, length);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByLength(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByLength";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindByVanimageuri(String vanimageuri) {
			String stmtId = "Vtrunkmetadata.FindByVanimageuri";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, vanimageuri);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByVanimageuri(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByVanimageuri";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindByCountyname(String countyname) {
			String stmtId = "Vtrunkmetadata.FindByCountyname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, countyname);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByCountyname(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByCountyname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindByWeightcapacity(String weightcapacity) {
			String stmtId = "Vtrunkmetadata.FindByWeightcapacity";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, weightcapacity);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByWeightcapacity(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByWeightcapacity";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindById(Int64 id) {
			String stmtId = "Vtrunkmetadata.FindById";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, id);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindById(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindById";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindByPrefixname(String prefixname) {
			String stmtId = "Vtrunkmetadata.FindByPrefixname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, prefixname);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByPrefixname(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByPrefixname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindByLicenseuri(String licenseuri) {
			String stmtId = "Vtrunkmetadata.FindByLicenseuri";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, licenseuri);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByLicenseuri(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByLicenseuri";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindByTrunkidentifynumber(String trunkidentifynumber) {
			String stmtId = "Vtrunkmetadata.FindByTrunkidentifynumber";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, trunkidentifynumber);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByTrunkidentifynumber(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByTrunkidentifynumber";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindByCountycode(String countycode) {
			String stmtId = "Vtrunkmetadata.FindByCountycode";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, countycode);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByCountycode(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByCountycode";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> FindByLocation(String location) {
			String stmtId = "Vtrunkmetadata.FindByLocation";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, location);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByLocation(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByLocation";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public void Reload(Vtrunkmetadata obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Vtrunkmetadata.Find";
			this.sqlMapper.QueryForObject<Vtrunkmetadata>(stmtId, obj, obj);
		}
    }
}