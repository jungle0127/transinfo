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
		public int GetFindCount(Int64 id) {
			String stmtId = "Vtrunkmetadata.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Vtrunkmetadata> FindAll() {
			String stmtId = "Vtrunkmetadata.FindAll";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, null);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindAll() {
			String stmtId = "Vtrunkmetadata.DescendOrderFindAll";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, null);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindAll(VtrunkmetadataPagination obj) {
			String stmtId = "Vtrunkmetadata.FindAllPagination";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindAll(VtrunkmetadataPagination obj) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindAllPagination";
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
		public IList<Vtrunkmetadata> DescendOrderFindByVantypename(String vantypename) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByVantypename";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, vantypename);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByVantypename(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByVantypename";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByVantypename(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByVantypename";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByVantypename(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByVantypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindByContactpersonname(String contactpersonname) {
			String stmtId = "Vtrunkmetadata.FindByContactpersonname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, contactpersonname);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindByContactpersonname(String contactpersonname) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByContactpersonname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, contactpersonname);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByContactpersonname(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByContactpersonname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByContactpersonname(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByContactpersonname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByContactpersonname(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByContactpersonnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindByTrunktypename(String trunktypename) {
			String stmtId = "Vtrunkmetadata.FindByTrunktypename";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, trunktypename);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindByTrunktypename(String trunktypename) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByTrunktypename";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, trunktypename);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByTrunktypename(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByTrunktypename";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByTrunktypename(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByTrunktypename";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByTrunktypename(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByTrunktypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindByConatactphone(String conatactphone) {
			String stmtId = "Vtrunkmetadata.FindByConatactphone";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, conatactphone);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindByConatactphone(String conatactphone) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByConatactphone";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, conatactphone);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByConatactphone(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByConatactphone";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByConatactphone(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByConatactphone";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByConatactphone(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByConatactphoneCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindByVolume(String volume) {
			String stmtId = "Vtrunkmetadata.FindByVolume";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, volume);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindByVolume(String volume) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByVolume";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, volume);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByVolume(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByVolume";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByVolume(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByVolume";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByVolume(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByVolumeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindByNumber(String number) {
			String stmtId = "Vtrunkmetadata.FindByNumber";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, number);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindByNumber(String number) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByNumber";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, number);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByNumber(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByNumber";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByNumber(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByNumber";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByNumber(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByNumberCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindByBrand(String brand) {
			String stmtId = "Vtrunkmetadata.FindByBrand";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, brand);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindByBrand(String brand) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByBrand";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, brand);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByBrand(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByBrand";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByBrand(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByBrand";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByBrand(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByBrandCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindByLength(String length) {
			String stmtId = "Vtrunkmetadata.FindByLength";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, length);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindByLength(String length) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByLength";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, length);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByLength(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByLength";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByLength(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByLength";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByLength(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByLengthCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindByVanimageuri(String vanimageuri) {
			String stmtId = "Vtrunkmetadata.FindByVanimageuri";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, vanimageuri);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindByVanimageuri(String vanimageuri) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByVanimageuri";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, vanimageuri);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByVanimageuri(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByVanimageuri";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByVanimageuri(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByVanimageuri";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByVanimageuri(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByVanimageuriCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindByCountyname(String countyname) {
			String stmtId = "Vtrunkmetadata.FindByCountyname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, countyname);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindByCountyname(String countyname) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByCountyname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, countyname);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByCountyname(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByCountyname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByCountyname(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByCountyname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByCountyname(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByCountynameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindByWeightcapacity(String weightcapacity) {
			String stmtId = "Vtrunkmetadata.FindByWeightcapacity";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, weightcapacity);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindByWeightcapacity(String weightcapacity) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByWeightcapacity";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, weightcapacity);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByWeightcapacity(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByWeightcapacity";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByWeightcapacity(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByWeightcapacity";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByWeightcapacity(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByWeightcapacityCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindById(Int64 id) {
			String stmtId = "Vtrunkmetadata.FindById";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, id);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindById(Int64 id) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindById";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, id);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindById(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindById";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindById(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindById";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountById(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByIdCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindByPrefixname(String prefixname) {
			String stmtId = "Vtrunkmetadata.FindByPrefixname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, prefixname);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindByPrefixname(String prefixname) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByPrefixname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, prefixname);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByPrefixname(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByPrefixname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByPrefixname(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByPrefixname";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByPrefixname(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByPrefixnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindByLicenseuri(String licenseuri) {
			String stmtId = "Vtrunkmetadata.FindByLicenseuri";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, licenseuri);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindByLicenseuri(String licenseuri) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByLicenseuri";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, licenseuri);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByLicenseuri(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByLicenseuri";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByLicenseuri(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByLicenseuri";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByLicenseuri(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByLicenseuriCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindByTrunkidentifynumber(String trunkidentifynumber) {
			String stmtId = "Vtrunkmetadata.FindByTrunkidentifynumber";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, trunkidentifynumber);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindByTrunkidentifynumber(String trunkidentifynumber) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByTrunkidentifynumber";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, trunkidentifynumber);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByTrunkidentifynumber(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByTrunkidentifynumber";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByTrunkidentifynumber(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByTrunkidentifynumber";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByTrunkidentifynumber(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByTrunkidentifynumberCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindByCountycode(String countycode) {
			String stmtId = "Vtrunkmetadata.FindByCountycode";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, countycode);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindByCountycode(String countycode) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByCountycode";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, countycode);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByCountycode(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByCountycode";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByCountycode(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByCountycode";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByCountycode(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByCountycodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkmetadata> FindByLocation(String location) {
			String stmtId = "Vtrunkmetadata.FindByLocation";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, location);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderFindByLocation(String location) {
			String stmtId = "Vtrunkmetadata.DescendOrderFindByLocation";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, location);
			return result;
        }
		public IList<Vtrunkmetadata> PaginationFindByLocation(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.FindByLocation";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkmetadata> DescendOrderPaginationFindByLocation(VtrunkmetadataPagination obj) {
			String stmtId = "VtrunkmetadataPagination.DescendOrderFindByLocation";
			IList<Vtrunkmetadata> result = this.sqlMapper.QueryForList<Vtrunkmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByLocation(Vtrunkmetadata obj){
			String stmtId = "Vtrunkmetadata.GetFindByLocationCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Reload(Vtrunkmetadata obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Vtrunkmetadata.Find";
			this.sqlMapper.QueryForObject<Vtrunkmetadata>(stmtId, obj, obj);
		}
    }
}
