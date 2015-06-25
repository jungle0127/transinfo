using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class VspeciallineinfoDao : IVspeciallineinfoDao
    {
        private ISqlMapper sqlMapper = null;
        public VspeciallineinfoDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Vspeciallineinfo.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Vspeciallineinfo Find(Int64 id) 
        {
			String stmtId = "Vspeciallineinfo.Find";
			Vspeciallineinfo result = this.sqlMapper.QueryForObject<Vspeciallineinfo>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Vspeciallineinfo.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Vspeciallineinfo> FindAll() {
			String stmtId = "Vspeciallineinfo.FindAll";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, null);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindAll() {
			String stmtId = "Vspeciallineinfo.DescendOrderFindAll";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, null);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindAll(VspeciallineinfoPagination obj) {
			String stmtId = "Vspeciallineinfo.FindAllPagination";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindAll(VspeciallineinfoPagination obj) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindAllPagination";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> QuickFindAll() {
			String stmtId = "Vspeciallineinfo.QuickFindAll";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, null);
			return result;
        }
		public IList<Vspeciallineinfo> FindByReleasedate(DateTime releasedate) {
			String stmtId = "Vspeciallineinfo.FindByReleasedate";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, releasedate);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindByReleasedate(DateTime releasedate) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindByReleasedate";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, releasedate);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByReleasedate(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByReleasedate";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindByReleasedate(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindByReleasedate";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByReleasedate(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByReleasedateCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindBySpeciallinetypename(String speciallinetypename) {
			String stmtId = "Vspeciallineinfo.FindBySpeciallinetypename";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, speciallinetypename);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindBySpeciallinetypename(String speciallinetypename) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindBySpeciallinetypename";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, speciallinetypename);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySpeciallinetypename(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySpeciallinetypename";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindBySpeciallinetypename(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindBySpeciallinetypename";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountBySpeciallinetypename(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindBySpeciallinetypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindBySrccontactpersonname(String srccontactpersonname) {
			String stmtId = "Vspeciallineinfo.FindBySrccontactpersonname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srccontactpersonname);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindBySrccontactpersonname(String srccontactpersonname) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindBySrccontactpersonname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srccontactpersonname);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySrccontactpersonname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySrccontactpersonname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindBySrccontactpersonname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindBySrccontactpersonname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountBySrccontactpersonname(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindBySrccontactpersonnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindByDescription(String description) {
			String stmtId = "Vspeciallineinfo.FindByDescription";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, description);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindByDescription(String description) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindByDescription";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, description);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDescription(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDescription";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindByDescription(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindByDescription";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByDescription(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByDescriptionCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindByUserid(Int64 userid) {
			String stmtId = "Vspeciallineinfo.FindByUserid";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, userid);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindByUserid(Int64 userid) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindByUserid";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, userid);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByUserid(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByUserid";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindByUserid(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindByUserid";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByUserid(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByUseridCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindBySrccontactphone(String srccontactphone) {
			String stmtId = "Vspeciallineinfo.FindBySrccontactphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srccontactphone);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindBySrccontactphone(String srccontactphone) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindBySrccontactphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srccontactphone);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySrccontactphone(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySrccontactphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindBySrccontactphone(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindBySrccontactphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountBySrccontactphone(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindBySrccontactphoneCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindByVolumeprice(Int32 volumeprice) {
			String stmtId = "Vspeciallineinfo.FindByVolumeprice";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, volumeprice);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindByVolumeprice(Int32 volumeprice) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindByVolumeprice";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, volumeprice);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByVolumeprice(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByVolumeprice";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindByVolumeprice(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindByVolumeprice";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByVolumeprice(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByVolumepriceCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindByDstcontactpersonname(String dstcontactpersonname) {
			String stmtId = "Vspeciallineinfo.FindByDstcontactpersonname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstcontactpersonname);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindByDstcontactpersonname(String dstcontactpersonname) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindByDstcontactpersonname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstcontactpersonname);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDstcontactpersonname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDstcontactpersonname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindByDstcontactpersonname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindByDstcontactpersonname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByDstcontactpersonname(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByDstcontactpersonnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindBySrcplaceaddress(String srcplaceaddress) {
			String stmtId = "Vspeciallineinfo.FindBySrcplaceaddress";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srcplaceaddress);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindBySrcplaceaddress(String srcplaceaddress) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindBySrcplaceaddress";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srcplaceaddress);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySrcplaceaddress(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySrcplaceaddress";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindBySrcplaceaddress(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindBySrcplaceaddress";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountBySrcplaceaddress(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindBySrcplaceaddressCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindByWeightprice(Int32 weightprice) {
			String stmtId = "Vspeciallineinfo.FindByWeightprice";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, weightprice);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindByWeightprice(Int32 weightprice) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindByWeightprice";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, weightprice);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByWeightprice(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByWeightprice";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindByWeightprice(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindByWeightprice";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByWeightprice(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByWeightpriceCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindBySrccontactcellphone(String srccontactcellphone) {
			String stmtId = "Vspeciallineinfo.FindBySrccontactcellphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srccontactcellphone);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindBySrccontactcellphone(String srccontactcellphone) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindBySrccontactcellphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srccontactcellphone);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySrccontactcellphone(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySrccontactcellphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindBySrccontactcellphone(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindBySrccontactcellphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountBySrccontactcellphone(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindBySrccontactcellphoneCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindBySrccityname(String srccityname) {
			String stmtId = "Vspeciallineinfo.FindBySrccityname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srccityname);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindBySrccityname(String srccityname) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindBySrccityname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srccityname);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySrccityname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySrccityname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindBySrccityname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindBySrccityname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountBySrccityname(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindBySrccitynameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindBySrccitycode(String srccitycode) {
			String stmtId = "Vspeciallineinfo.FindBySrccitycode";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srccitycode);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindBySrccitycode(String srccitycode) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindBySrccitycode";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srccitycode);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySrccitycode(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySrccitycode";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindBySrccitycode(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindBySrccitycode";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountBySrccitycode(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindBySrccitycodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindBySrcregionname(String srcregionname) {
			String stmtId = "Vspeciallineinfo.FindBySrcregionname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srcregionname);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindBySrcregionname(String srcregionname) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindBySrcregionname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srcregionname);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySrcregionname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySrcregionname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindBySrcregionname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindBySrcregionname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountBySrcregionname(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindBySrcregionnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindByDstcontactphone(String dstcontactphone) {
			String stmtId = "Vspeciallineinfo.FindByDstcontactphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstcontactphone);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindByDstcontactphone(String dstcontactphone) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindByDstcontactphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstcontactphone);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDstcontactphone(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDstcontactphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindByDstcontactphone(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindByDstcontactphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByDstcontactphone(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByDstcontactphoneCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindById(Int64 id) {
			String stmtId = "Vspeciallineinfo.FindById";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, id);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindById(Int64 id) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindById";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, id);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindById(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindById";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindById(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindById";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountById(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByIdCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindByDstregionname(String dstregionname) {
			String stmtId = "Vspeciallineinfo.FindByDstregionname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstregionname);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindByDstregionname(String dstregionname) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindByDstregionname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstregionname);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDstregionname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDstregionname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindByDstregionname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindByDstregionname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByDstregionname(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByDstregionnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindByDeparturetypename(String departuretypename) {
			String stmtId = "Vspeciallineinfo.FindByDeparturetypename";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, departuretypename);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindByDeparturetypename(String departuretypename) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindByDeparturetypename";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, departuretypename);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDeparturetypename(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDeparturetypename";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindByDeparturetypename(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindByDeparturetypename";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByDeparturetypename(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByDeparturetypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindByDstplaceaddress(String dstplaceaddress) {
			String stmtId = "Vspeciallineinfo.FindByDstplaceaddress";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstplaceaddress);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindByDstplaceaddress(String dstplaceaddress) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindByDstplaceaddress";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstplaceaddress);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDstplaceaddress(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDstplaceaddress";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindByDstplaceaddress(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindByDstplaceaddress";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByDstplaceaddress(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByDstplaceaddressCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindByDstcityname(String dstcityname) {
			String stmtId = "Vspeciallineinfo.FindByDstcityname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstcityname);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindByDstcityname(String dstcityname) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindByDstcityname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstcityname);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDstcityname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDstcityname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindByDstcityname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindByDstcityname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByDstcityname(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByDstcitynameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindByDstcitycode(String dstcitycode) {
			String stmtId = "Vspeciallineinfo.FindByDstcitycode";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstcitycode);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindByDstcitycode(String dstcitycode) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindByDstcitycode";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstcitycode);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDstcitycode(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDstcitycode";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindByDstcitycode(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindByDstcitycode";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByDstcitycode(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByDstcitycodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindByTitle(String title) {
			String stmtId = "Vspeciallineinfo.FindByTitle";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, title);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindByTitle(String title) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindByTitle";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, title);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByTitle(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByTitle";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindByTitle(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindByTitle";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByTitle(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByTitleCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindByDstcontactcellphone(String dstcontactcellphone) {
			String stmtId = "Vspeciallineinfo.FindByDstcontactcellphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstcontactcellphone);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindByDstcontactcellphone(String dstcontactcellphone) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindByDstcontactcellphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstcontactcellphone);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDstcontactcellphone(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDstcontactcellphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindByDstcontactcellphone(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindByDstcontactcellphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByDstcontactcellphone(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByDstcontactcellphoneCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vspeciallineinfo> FindByUsername(String username) {
			String stmtId = "Vspeciallineinfo.FindByUsername";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, username);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderFindByUsername(String username) {
			String stmtId = "Vspeciallineinfo.DescendOrderFindByUsername";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, username);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByUsername(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByUsername";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> DescendOrderPaginationFindByUsername(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.DescendOrderFindByUsername";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByUsername(Vspeciallineinfo obj){
			String stmtId = "Vspeciallineinfo.GetFindByUsernameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Reload(Vspeciallineinfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Vspeciallineinfo.Find";
			this.sqlMapper.QueryForObject<Vspeciallineinfo>(stmtId, obj, obj);
		}
    }
}
