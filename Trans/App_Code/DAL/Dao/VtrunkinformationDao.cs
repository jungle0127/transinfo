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
		public int GetFindCount(Int64 id) {
			String stmtId = "Vtrunkinformation.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Vtrunkinformation> FindAll() {
			String stmtId = "Vtrunkinformation.FindAll";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, null);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindAll() {
			String stmtId = "Vtrunkinformation.DescendOrderFindAll";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, null);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindAll(VtrunkinformationPagination obj) {
			String stmtId = "Vtrunkinformation.FindAllPagination";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindAll(VtrunkinformationPagination obj) {
			String stmtId = "Vtrunkinformation.DescendOrderFindAllPagination";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> QuickFindAll() {
			String stmtId = "Vtrunkinformation.QuickFindAll";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, null);
			return result;
        }
		public IList<Vtrunkinformation> FindByTakeofftime(DateTime takeofftime) {
			String stmtId = "Vtrunkinformation.FindByTakeofftime";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, takeofftime);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByTakeofftime(DateTime takeofftime) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByTakeofftime";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, takeofftime);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByTakeofftime(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByTakeofftime";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByTakeofftime(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByTakeofftime";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTakeofftime(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByTakeofftimeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByLicenseuri(String licenseuri) {
			String stmtId = "Vtrunkinformation.FindByLicenseuri";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, licenseuri);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByLicenseuri(String licenseuri) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByLicenseuri";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, licenseuri);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByLicenseuri(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByLicenseuri";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByLicenseuri(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByLicenseuri";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByLicenseuri(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByLicenseuriCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindBySrcregionname(String srcregionname) {
			String stmtId = "Vtrunkinformation.FindBySrcregionname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, srcregionname);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindBySrcregionname(String srcregionname) {
			String stmtId = "Vtrunkinformation.DescendOrderFindBySrcregionname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, srcregionname);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindBySrcregionname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindBySrcregionname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindBySrcregionname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindBySrcregionname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountBySrcregionname(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindBySrcregionnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByTitle(String title) {
			String stmtId = "Vtrunkinformation.FindByTitle";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, title);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByTitle(String title) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByTitle";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, title);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByTitle(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByTitle";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByTitle(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByTitle";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTitle(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByTitleCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByTrunktypename(String trunktypename) {
			String stmtId = "Vtrunkinformation.FindByTrunktypename";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, trunktypename);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByTrunktypename(String trunktypename) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByTrunktypename";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, trunktypename);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByTrunktypename(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByTrunktypename";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByTrunktypename(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByTrunktypename";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTrunktypename(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByTrunktypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByReleasedate(DateTime releasedate) {
			String stmtId = "Vtrunkinformation.FindByReleasedate";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, releasedate);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByReleasedate(DateTime releasedate) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByReleasedate";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, releasedate);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByReleasedate(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByReleasedate";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByReleasedate(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByReleasedate";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByReleasedate(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByReleasedateCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByDstcityname(String dstcityname) {
			String stmtId = "Vtrunkinformation.FindByDstcityname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, dstcityname);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByDstcityname(String dstcityname) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByDstcityname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, dstcityname);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByDstcityname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByDstcityname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByDstcityname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByDstcityname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDstcityname(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByDstcitynameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindById(Int64 id) {
			String stmtId = "Vtrunkinformation.FindById";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, id);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindById(Int64 id) {
			String stmtId = "Vtrunkinformation.DescendOrderFindById";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, id);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindById(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindById";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindById(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindById";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountById(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByIdCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByDstregionname(String dstregionname) {
			String stmtId = "Vtrunkinformation.FindByDstregionname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, dstregionname);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByDstregionname(String dstregionname) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByDstregionname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, dstregionname);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByDstregionname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByDstregionname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByDstregionname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByDstregionname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDstregionname(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByDstregionnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByTrunkcountyname(String trunkcountyname) {
			String stmtId = "Vtrunkinformation.FindByTrunkcountyname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, trunkcountyname);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByTrunkcountyname(String trunkcountyname) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByTrunkcountyname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, trunkcountyname);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByTrunkcountyname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByTrunkcountyname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByTrunkcountyname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByTrunkcountyname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTrunkcountyname(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByTrunkcountynameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByConatactphone(String conatactphone) {
			String stmtId = "Vtrunkinformation.FindByConatactphone";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, conatactphone);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByConatactphone(String conatactphone) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByConatactphone";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, conatactphone);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByConatactphone(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByConatactphone";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByConatactphone(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByConatactphone";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByConatactphone(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByConatactphoneCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByVanimageuri(String vanimageuri) {
			String stmtId = "Vtrunkinformation.FindByVanimageuri";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, vanimageuri);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByVanimageuri(String vanimageuri) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByVanimageuri";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, vanimageuri);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByVanimageuri(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByVanimageuri";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByVanimageuri(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByVanimageuri";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByVanimageuri(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByVanimageuriCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByPrefixname(String prefixname) {
			String stmtId = "Vtrunkinformation.FindByPrefixname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, prefixname);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByPrefixname(String prefixname) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByPrefixname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, prefixname);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByPrefixname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByPrefixname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByPrefixname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByPrefixname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByPrefixname(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByPrefixnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByLength(String length) {
			String stmtId = "Vtrunkinformation.FindByLength";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, length);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByLength(String length) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByLength";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, length);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByLength(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByLength";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByLength(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByLength";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByLength(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByLengthCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindBySrccityname(String srccityname) {
			String stmtId = "Vtrunkinformation.FindBySrccityname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, srccityname);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindBySrccityname(String srccityname) {
			String stmtId = "Vtrunkinformation.DescendOrderFindBySrccityname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, srccityname);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindBySrccityname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindBySrccityname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindBySrccityname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindBySrccityname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountBySrccityname(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindBySrccitynameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindBySrccitycode(String srccitycode) {
			String stmtId = "Vtrunkinformation.FindBySrccitycode";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, srccitycode);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindBySrccitycode(String srccitycode) {
			String stmtId = "Vtrunkinformation.DescendOrderFindBySrccitycode";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, srccitycode);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindBySrccitycode(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindBySrccitycode";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindBySrccitycode(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindBySrccitycode";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountBySrccitycode(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindBySrccitycodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByTrunkidentifynumber(String trunkidentifynumber) {
			String stmtId = "Vtrunkinformation.FindByTrunkidentifynumber";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, trunkidentifynumber);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByTrunkidentifynumber(String trunkidentifynumber) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByTrunkidentifynumber";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, trunkidentifynumber);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByTrunkidentifynumber(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByTrunkidentifynumber";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByTrunkidentifynumber(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByTrunkidentifynumber";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTrunkidentifynumber(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByTrunkidentifynumberCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByVantypename(String vantypename) {
			String stmtId = "Vtrunkinformation.FindByVantypename";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, vantypename);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByVantypename(String vantypename) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByVantypename";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, vantypename);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByVantypename(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByVantypename";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByVantypename(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByVantypename";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByVantypename(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByVantypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByWeightcapacity(String weightcapacity) {
			String stmtId = "Vtrunkinformation.FindByWeightcapacity";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, weightcapacity);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByWeightcapacity(String weightcapacity) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByWeightcapacity";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, weightcapacity);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByWeightcapacity(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByWeightcapacity";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByWeightcapacity(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByWeightcapacity";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByWeightcapacity(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByWeightcapacityCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByNumber(String number) {
			String stmtId = "Vtrunkinformation.FindByNumber";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, number);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByNumber(String number) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByNumber";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, number);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByNumber(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByNumber";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByNumber(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByNumber";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByNumber(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByNumberCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByDstcitycode(String dstcitycode) {
			String stmtId = "Vtrunkinformation.FindByDstcitycode";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, dstcitycode);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByDstcitycode(String dstcitycode) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByDstcitycode";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, dstcitycode);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByDstcitycode(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByDstcitycode";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByDstcitycode(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByDstcitycode";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDstcitycode(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByDstcitycodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByVolume(String volume) {
			String stmtId = "Vtrunkinformation.FindByVolume";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, volume);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByVolume(String volume) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByVolume";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, volume);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByVolume(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByVolume";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByVolume(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByVolume";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByVolume(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByVolumeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByContactpersonname(String contactpersonname) {
			String stmtId = "Vtrunkinformation.FindByContactpersonname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, contactpersonname);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByContactpersonname(String contactpersonname) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByContactpersonname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, contactpersonname);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByContactpersonname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByContactpersonname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByContactpersonname(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByContactpersonname";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByContactpersonname(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByContactpersonnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByBrand(String brand) {
			String stmtId = "Vtrunkinformation.FindByBrand";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, brand);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByBrand(String brand) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByBrand";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, brand);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByBrand(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByBrand";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByBrand(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByBrand";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByBrand(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByBrandCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByRoutetype(String routetype) {
			String stmtId = "Vtrunkinformation.FindByRoutetype";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, routetype);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByRoutetype(String routetype) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByRoutetype";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, routetype);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByRoutetype(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByRoutetype";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByRoutetype(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByRoutetype";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByRoutetype(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByRoutetypeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByUsername(String username) {
			String stmtId = "Vtrunkinformation.FindByUsername";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, username);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByUsername(String username) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByUsername";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, username);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByUsername(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByUsername";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByUsername(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByUsername";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByUsername(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByUsernameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vtrunkinformation> FindByLocation(String location) {
			String stmtId = "Vtrunkinformation.FindByLocation";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, location);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderFindByLocation(String location) {
			String stmtId = "Vtrunkinformation.DescendOrderFindByLocation";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, location);
			return result;
        }
		public IList<Vtrunkinformation> PaginationFindByLocation(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.FindByLocation";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Vtrunkinformation> DescendOrderPaginationFindByLocation(VtrunkinformationPagination obj) {
			String stmtId = "VtrunkinformationPagination.DescendOrderFindByLocation";
			IList<Vtrunkinformation> result = this.sqlMapper.QueryForList<Vtrunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByLocation(Vtrunkinformation obj){
			String stmtId = "Vtrunkinformation.GetFindByLocationCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Reload(Vtrunkinformation obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Vtrunkinformation.Find";
			this.sqlMapper.QueryForObject<Vtrunkinformation>(stmtId, obj, obj);
		}
    }
}
