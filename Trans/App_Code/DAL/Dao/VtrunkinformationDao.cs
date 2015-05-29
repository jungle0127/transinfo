using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class VtrunkinformationDao : IVtrunkinformationDao
    {
        private ISqlMapper sqlMapper = null;
        public VtrunkinformationDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Vtrunkinformation.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Vtrunkinformation Find(Int64 id) 
        {
			String stmtId = "Vtrunkinformation.Find";
			Vtrunkinformation result = this.sqlMapper.QueryForObject<Vtrunkinformation>(stmtId, id);
			return result;
        }
		public IList<Vtrunkinformation> FindAll() {
			String stmtId = "Vtrunkinformation.FindAll";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, null);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindAll(VtrunkinformationPagination obj) {
			String stmtId = "Vtrunkinformation.FindAllPagination";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> QuickFindAll() {
			String stmtId = "Vtrunkinformation.QuickFindAll";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, null);
			return result;
        }
		public IList<Vtrunkinformation> FindByVantypename(String vantypename) {
			String stmtId = "Vtrunkinformation.FindByVantypename";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, vantypename);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByVantypename(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByVantypename";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByTrunktypename(String trunktypename) {
			String stmtId = "Vtrunkinformation.FindByTrunktypename";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, trunktypename);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByTrunktypename(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByTrunktypename";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByDstregionname(String dstregionname) {
			String stmtId = "Vtrunkinformation.FindByDstregionname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, dstregionname);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByDstregionname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByDstregionname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByVolume(String volume) {
			String stmtId = "Vtrunkinformation.FindByVolume";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, volume);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByVolume(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByVolume";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByNumber(String number) {
			String stmtId = "Vtrunkinformation.FindByNumber";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, number);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByNumber(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByNumber";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByBrand(String brand) {
			String stmtId = "Vtrunkinformation.FindByBrand";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, brand);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByBrand(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByBrand";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByLength(String length) {
			String stmtId = "Vtrunkinformation.FindByLength";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, length);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByLength(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByLength";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByConatactphone(String conatactphone) {
			String stmtId = "Vtrunkinformation.FindByConatactphone";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, conatactphone);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByConatactphone(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByConatactphone";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByVanimageuri(String vanimageuri) {
			String stmtId = "Vtrunkinformation.FindByVanimageuri";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, vanimageuri);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByVanimageuri(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByVanimageuri";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindBySrcregionname(String srcregionname) {
			String stmtId = "Vtrunkinformation.FindBySrcregionname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, srcregionname);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindBySrcregionname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindBySrcregionname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByWeightcapacity(String weightcapacity) {
			String stmtId = "Vtrunkinformation.FindByWeightcapacity";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, weightcapacity);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByWeightcapacity(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByWeightcapacity";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByTrunkcountyname(String trunkcountyname) {
			String stmtId = "Vtrunkinformation.FindByTrunkcountyname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, trunkcountyname);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByTrunkcountyname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByTrunkcountyname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindById(Int64 id) {
			String stmtId = "Vtrunkinformation.FindById";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, id);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindById(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindById";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByPrefixname(String prefixname) {
			String stmtId = "Vtrunkinformation.FindByPrefixname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, prefixname);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByPrefixname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByPrefixname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByLicenseuri(String licenseuri) {
			String stmtId = "Vtrunkinformation.FindByLicenseuri";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, licenseuri);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByLicenseuri(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByLicenseuri";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByTrunkidentifynumber(String trunkidentifynumber) {
			String stmtId = "Vtrunkinformation.FindByTrunkidentifynumber";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, trunkidentifynumber);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByTrunkidentifynumber(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByTrunkidentifynumber";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByContactpersonname(String contactpersonname) {
			String stmtId = "Vtrunkinformation.FindByContactpersonname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, contactpersonname);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByContactpersonname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByContactpersonname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByLocation(String location) {
			String stmtId = "Vtrunkinformation.FindByLocation";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, location);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByLocation(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByLocation";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByRoutetype(String routetype) {
			String stmtId = "Vtrunkinformation.FindByRoutetype";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, routetype);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByRoutetype(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByRoutetype";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> FindByUsername(String username) {
			String stmtId = "Vtrunkinformation.FindByUsername";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, username);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByUsername(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByUsername";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public void Reload(Vtrunkinformation obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Vtrunkinformation.Find";
			this.sqlMapper.QueryForObject<Vtrunkinformation>(stmtId, obj, obj);
		}
    }
}
