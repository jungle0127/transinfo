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
		public IList<Vspeciallineinfo> FindAll() {
			String stmtId = "Vspeciallineinfo.FindAll";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, null);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindAll(VspeciallineinfoPagination obj) {
			String stmtId = "Vspeciallineinfo.FindAllPagination";
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
		public IList<Vspeciallineinfo> PaginationFindByReleasedate(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByReleasedate";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindBySpeciallinetypename(String speciallinetypename) {
			String stmtId = "Vspeciallineinfo.FindBySpeciallinetypename";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, speciallinetypename);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySpeciallinetypename(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySpeciallinetypename";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindBySrccontactpersonname(String srccontactpersonname) {
			String stmtId = "Vspeciallineinfo.FindBySrccontactpersonname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srccontactpersonname);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySrccontactpersonname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySrccontactpersonname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindByDescription(String description) {
			String stmtId = "Vspeciallineinfo.FindByDescription";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, description);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDescription(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDescription";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindByUserid(Int64 userid) {
			String stmtId = "Vspeciallineinfo.FindByUserid";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, userid);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByUserid(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByUserid";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindBySrccontactphone(String srccontactphone) {
			String stmtId = "Vspeciallineinfo.FindBySrccontactphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srccontactphone);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySrccontactphone(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySrccontactphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindByVolumeprice(Int32 volumeprice) {
			String stmtId = "Vspeciallineinfo.FindByVolumeprice";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, volumeprice);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByVolumeprice(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByVolumeprice";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindByDstcontactpersonname(String dstcontactpersonname) {
			String stmtId = "Vspeciallineinfo.FindByDstcontactpersonname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstcontactpersonname);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDstcontactpersonname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDstcontactpersonname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindBySrcplaceaddress(String srcplaceaddress) {
			String stmtId = "Vspeciallineinfo.FindBySrcplaceaddress";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srcplaceaddress);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySrcplaceaddress(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySrcplaceaddress";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindByWeightprice(Int32 weightprice) {
			String stmtId = "Vspeciallineinfo.FindByWeightprice";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, weightprice);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByWeightprice(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByWeightprice";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindBySrccontactcellphone(String srccontactcellphone) {
			String stmtId = "Vspeciallineinfo.FindBySrccontactcellphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srccontactcellphone);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySrccontactcellphone(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySrccontactcellphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindBySrccityname(String srccityname) {
			String stmtId = "Vspeciallineinfo.FindBySrccityname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srccityname);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySrccityname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySrccityname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindBySrccitycode(String srccitycode) {
			String stmtId = "Vspeciallineinfo.FindBySrccitycode";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srccitycode);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySrccitycode(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySrccitycode";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindBySrcregionname(String srcregionname) {
			String stmtId = "Vspeciallineinfo.FindBySrcregionname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, srcregionname);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindBySrcregionname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindBySrcregionname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindByDstcontactphone(String dstcontactphone) {
			String stmtId = "Vspeciallineinfo.FindByDstcontactphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstcontactphone);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDstcontactphone(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDstcontactphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindById(Int64 id) {
			String stmtId = "Vspeciallineinfo.FindById";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, id);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindById(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindById";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindByDstregionname(String dstregionname) {
			String stmtId = "Vspeciallineinfo.FindByDstregionname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstregionname);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDstregionname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDstregionname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindByDeparturetypename(String departuretypename) {
			String stmtId = "Vspeciallineinfo.FindByDeparturetypename";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, departuretypename);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDeparturetypename(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDeparturetypename";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindByDstplaceaddress(String dstplaceaddress) {
			String stmtId = "Vspeciallineinfo.FindByDstplaceaddress";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstplaceaddress);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDstplaceaddress(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDstplaceaddress";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindByDstcityname(String dstcityname) {
			String stmtId = "Vspeciallineinfo.FindByDstcityname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstcityname);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDstcityname(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDstcityname";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindByDstcitycode(String dstcitycode) {
			String stmtId = "Vspeciallineinfo.FindByDstcitycode";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstcitycode);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDstcitycode(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDstcitycode";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindByTitle(String title) {
			String stmtId = "Vspeciallineinfo.FindByTitle";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, title);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByTitle(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByTitle";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindByDstcontactcellphone(String dstcontactcellphone) {
			String stmtId = "Vspeciallineinfo.FindByDstcontactcellphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, dstcontactcellphone);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByDstcontactcellphone(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByDstcontactcellphone";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Vspeciallineinfo> FindByUsername(String username) {
			String stmtId = "Vspeciallineinfo.FindByUsername";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, username);
			return result;
        }
		public IList<Vspeciallineinfo> PaginationFindByUsername(VspeciallineinfoPagination obj) {
			String stmtId = "VspeciallineinfoPagination.FindByUsername";
			IList<Vspeciallineinfo> result = this.sqlMapper.QueryForList<Vspeciallineinfo>(stmtId, obj);
			return result;
        }
		public void Reload(Vspeciallineinfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Vspeciallineinfo.Find";
			this.sqlMapper.QueryForObject<Vspeciallineinfo>(stmtId, obj, obj);
		}
    }
}
