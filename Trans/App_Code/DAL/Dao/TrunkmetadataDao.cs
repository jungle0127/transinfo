using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class TrunkmetadataDao : ITrunkmetadataDao
    {
        private ISqlMapper sqlMapper = null;
        public TrunkmetadataDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Trunkmetadata.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Trunkmetadata Find(Int64 id) 
        {
			String stmtId = "Trunkmetadata.Find";
			Trunkmetadata result = this.sqlMapper.QueryForObject<Trunkmetadata>(stmtId, id);
			return result;
        }
		public IList<Trunkmetadata> FindAll() {
			String stmtId = "Trunkmetadata.FindAll";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, null);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindAll(TrunkmetadataPagination obj) {
			String stmtId = "Trunkmetadata.FindAllPagination";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Trunkmetadata> QuickFindAll() {
			String stmtId = "Trunkmetadata.QuickFindAll";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, null);
			return result;
        }
		public IList<Trunkmetadata> FindByConatactphone(String conatactphone) {
			String stmtId = "Trunkmetadata.FindByConatactphone";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, conatactphone);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindByConatactphone(TrunkmetadataPagination obj) {
			String stmtId = "TrunkmetadataPagination.FindByConatactphone";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Trunkmetadata> FindByVolume(String volume) {
			String stmtId = "Trunkmetadata.FindByVolume";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, volume);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindByVolume(TrunkmetadataPagination obj) {
			String stmtId = "TrunkmetadataPagination.FindByVolume";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Trunkmetadata> FindByNumberid(Int64 numberid) {
			String stmtId = "Trunkmetadata.FindByNumberid";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, numberid);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindByNumberid(TrunkmetadataPagination obj) {
			String stmtId = "TrunkmetadataPagination.FindByNumberid";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Trunkmetadata> FindByBrand(String brand) {
			String stmtId = "Trunkmetadata.FindByBrand";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, brand);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindByBrand(TrunkmetadataPagination obj) {
			String stmtId = "TrunkmetadataPagination.FindByBrand";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Trunkmetadata> FindByLength(String length) {
			String stmtId = "Trunkmetadata.FindByLength";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, length);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindByLength(TrunkmetadataPagination obj) {
			String stmtId = "TrunkmetadataPagination.FindByLength";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Trunkmetadata> FindByTrunktypeid(Int64 trunktypeid) {
			String stmtId = "Trunkmetadata.FindByTrunktypeid";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, trunktypeid);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindByTrunktypeid(TrunkmetadataPagination obj) {
			String stmtId = "TrunkmetadataPagination.FindByTrunktypeid";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Trunkmetadata> FindByContactpersonname(String contactpersonname) {
			String stmtId = "Trunkmetadata.FindByContactpersonname";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, contactpersonname);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindByContactpersonname(TrunkmetadataPagination obj) {
			String stmtId = "TrunkmetadataPagination.FindByContactpersonname";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Trunkmetadata> FindByActive(Byte active) {
			String stmtId = "Trunkmetadata.FindByActive";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, active);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindByActive(TrunkmetadataPagination obj) {
			String stmtId = "TrunkmetadataPagination.FindByActive";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Trunkmetadata> FindByVanimageuri(String vanimageuri) {
			String stmtId = "Trunkmetadata.FindByVanimageuri";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, vanimageuri);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindByVanimageuri(TrunkmetadataPagination obj) {
			String stmtId = "TrunkmetadataPagination.FindByVanimageuri";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Trunkmetadata> FindByWeightcapacity(String weightcapacity) {
			String stmtId = "Trunkmetadata.FindByWeightcapacity";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, weightcapacity);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindByWeightcapacity(TrunkmetadataPagination obj) {
			String stmtId = "TrunkmetadataPagination.FindByWeightcapacity";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Trunkmetadata> FindByVantypeid(Int64 vantypeid) {
			String stmtId = "Trunkmetadata.FindByVantypeid";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, vantypeid);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindByVantypeid(TrunkmetadataPagination obj) {
			String stmtId = "TrunkmetadataPagination.FindByVantypeid";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Trunkmetadata> FindByLicenseuri(String licenseuri) {
			String stmtId = "Trunkmetadata.FindByLicenseuri";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, licenseuri);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindByLicenseuri(TrunkmetadataPagination obj) {
			String stmtId = "TrunkmetadataPagination.FindByLicenseuri";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Trunkmetadata> FindByTrunkidentifynumber(String trunkidentifynumber) {
			String stmtId = "Trunkmetadata.FindByTrunkidentifynumber";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, trunkidentifynumber);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindByTrunkidentifynumber(TrunkmetadataPagination obj) {
			String stmtId = "TrunkmetadataPagination.FindByTrunkidentifynumber";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Trunkmetadata> FindByCountycode(String countycode) {
			String stmtId = "Trunkmetadata.FindByCountycode";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, countycode);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindByCountycode(TrunkmetadataPagination obj) {
			String stmtId = "TrunkmetadataPagination.FindByCountycode";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Trunkmetadata> FindByLocation(String location) {
			String stmtId = "Trunkmetadata.FindByLocation";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, location);
			return result;
        }
		public IList<Trunkmetadata> PaginationFindByLocation(TrunkmetadataPagination obj) {
			String stmtId = "TrunkmetadataPagination.FindByLocation";
			IList<Trunkmetadata> result = this.sqlMapper.QueryForList<Trunkmetadata>(stmtId, obj);
			return result;
        }
		public void Update(Trunkmetadata obj) {
			String stmtId = "Trunkmetadata.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Trunkmetadata obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunkmetadata.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Trunkmetadata obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunkmetadata.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByConatactphone(String conatactphone) {
			String stmtId = "Trunkmetadata.DeleteByConatactphone";
			int result = this.sqlMapper.Delete(stmtId, conatactphone);
			return result;
        }
		public int DeleteByVolume(String volume) {
			String stmtId = "Trunkmetadata.DeleteByVolume";
			int result = this.sqlMapper.Delete(stmtId, volume);
			return result;
        }
		public int DeleteByNumberid(Int64 numberid) {
			String stmtId = "Trunkmetadata.DeleteByNumberid";
			int result = this.sqlMapper.Delete(stmtId, numberid);
			return result;
        }
		public int DeleteByBrand(String brand) {
			String stmtId = "Trunkmetadata.DeleteByBrand";
			int result = this.sqlMapper.Delete(stmtId, brand);
			return result;
        }
		public int DeleteByLength(String length) {
			String stmtId = "Trunkmetadata.DeleteByLength";
			int result = this.sqlMapper.Delete(stmtId, length);
			return result;
        }
		public int DeleteByTrunktypeid(Int64 trunktypeid) {
			String stmtId = "Trunkmetadata.DeleteByTrunktypeid";
			int result = this.sqlMapper.Delete(stmtId, trunktypeid);
			return result;
        }
		public int DeleteByContactpersonname(String contactpersonname) {
			String stmtId = "Trunkmetadata.DeleteByContactpersonname";
			int result = this.sqlMapper.Delete(stmtId, contactpersonname);
			return result;
        }
		public int DeleteByActive(Byte active) {
			String stmtId = "Trunkmetadata.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public int DeleteByVanimageuri(String vanimageuri) {
			String stmtId = "Trunkmetadata.DeleteByVanimageuri";
			int result = this.sqlMapper.Delete(stmtId, vanimageuri);
			return result;
        }
		public int DeleteByWeightcapacity(String weightcapacity) {
			String stmtId = "Trunkmetadata.DeleteByWeightcapacity";
			int result = this.sqlMapper.Delete(stmtId, weightcapacity);
			return result;
        }
		public int DeleteByVantypeid(Int64 vantypeid) {
			String stmtId = "Trunkmetadata.DeleteByVantypeid";
			int result = this.sqlMapper.Delete(stmtId, vantypeid);
			return result;
        }
		public int DeleteByLicenseuri(String licenseuri) {
			String stmtId = "Trunkmetadata.DeleteByLicenseuri";
			int result = this.sqlMapper.Delete(stmtId, licenseuri);
			return result;
        }
		public int DeleteByTrunkidentifynumber(String trunkidentifynumber) {
			String stmtId = "Trunkmetadata.DeleteByTrunkidentifynumber";
			int result = this.sqlMapper.Delete(stmtId, trunkidentifynumber);
			return result;
        }
		public int DeleteByCountycode(String countycode) {
			String stmtId = "Trunkmetadata.DeleteByCountycode";
			int result = this.sqlMapper.Delete(stmtId, countycode);
			return result;
        }
		public int DeleteByLocation(String location) {
			String stmtId = "Trunkmetadata.DeleteByLocation";
			int result = this.sqlMapper.Delete(stmtId, location);
			return result;
        }
		public void Reload(Trunkmetadata obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunkmetadata.Find";
			this.sqlMapper.QueryForObject<Trunkmetadata>(stmtId, obj, obj);
		}
    }
}
