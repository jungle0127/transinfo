using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class SpeciallineinfoDao : ISpeciallineinfoDao
    {
        private ISqlMapper sqlMapper = null;
        public SpeciallineinfoDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Speciallineinfo.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Speciallineinfo Find(Int64 id) 
        {
			String stmtId = "Speciallineinfo.Find";
			Speciallineinfo result = this.sqlMapper.QueryForObject<Speciallineinfo>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Speciallineinfo.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Speciallineinfo> FindAll() {
			String stmtId = "Speciallineinfo.FindAll";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, null);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderFindAll() {
			String stmtId = "Speciallineinfo.DescendOrderFindAll";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, null);
			return result;
        }
		public IList<Speciallineinfo> PaginationFindAll(SpeciallineinfoPagination obj) {
			String stmtId = "Speciallineinfo.FindAllPagination";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderPaginationFindAll(SpeciallineinfoPagination obj) {
			String stmtId = "Speciallineinfo.DescendOrderFindAllPagination";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Speciallineinfo> QuickFindAll() {
			String stmtId = "Speciallineinfo.QuickFindAll";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, null);
			return result;
        }
		public IList<Speciallineinfo> FindByUserid(Int64 userid) {
			String stmtId = "Speciallineinfo.FindByUserid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, userid);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderFindByUserid(Int64 userid) {
			String stmtId = "Speciallineinfo.DescendOrderFindByUserid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, userid);
			return result;
        }
		public IList<Speciallineinfo> PaginationFindByUserid(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.FindByUserid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderPaginationFindByUserid(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.DescendOrderFindByUserid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByUserid(Speciallineinfo obj){
			String stmtId = "Speciallineinfo.GetFindByUseridCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Speciallineinfo> FindByDestinationplaceinfoid(Int64 destinationplaceinfoid) {
			String stmtId = "Speciallineinfo.FindByDestinationplaceinfoid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, destinationplaceinfoid);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderFindByDestinationplaceinfoid(Int64 destinationplaceinfoid) {
			String stmtId = "Speciallineinfo.DescendOrderFindByDestinationplaceinfoid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, destinationplaceinfoid);
			return result;
        }
		public IList<Speciallineinfo> PaginationFindByDestinationplaceinfoid(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.FindByDestinationplaceinfoid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderPaginationFindByDestinationplaceinfoid(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.DescendOrderFindByDestinationplaceinfoid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByDestinationplaceinfoid(Speciallineinfo obj){
			String stmtId = "Speciallineinfo.GetFindByDestinationplaceinfoidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Speciallineinfo> FindByDeparturetypeid(Int64 departuretypeid) {
			String stmtId = "Speciallineinfo.FindByDeparturetypeid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, departuretypeid);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderFindByDeparturetypeid(Int64 departuretypeid) {
			String stmtId = "Speciallineinfo.DescendOrderFindByDeparturetypeid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, departuretypeid);
			return result;
        }
		public IList<Speciallineinfo> PaginationFindByDeparturetypeid(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.FindByDeparturetypeid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderPaginationFindByDeparturetypeid(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.DescendOrderFindByDeparturetypeid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByDeparturetypeid(Speciallineinfo obj){
			String stmtId = "Speciallineinfo.GetFindByDeparturetypeidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Speciallineinfo> FindByTitle(String title) {
			String stmtId = "Speciallineinfo.FindByTitle";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, title);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderFindByTitle(String title) {
			String stmtId = "Speciallineinfo.DescendOrderFindByTitle";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, title);
			return result;
        }
		public IList<Speciallineinfo> PaginationFindByTitle(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.FindByTitle";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderPaginationFindByTitle(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.DescendOrderFindByTitle";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByTitle(Speciallineinfo obj){
			String stmtId = "Speciallineinfo.GetFindByTitleCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Speciallineinfo> FindByVolumeprice(Int32 volumeprice) {
			String stmtId = "Speciallineinfo.FindByVolumeprice";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, volumeprice);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderFindByVolumeprice(Int32 volumeprice) {
			String stmtId = "Speciallineinfo.DescendOrderFindByVolumeprice";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, volumeprice);
			return result;
        }
		public IList<Speciallineinfo> PaginationFindByVolumeprice(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.FindByVolumeprice";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderPaginationFindByVolumeprice(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.DescendOrderFindByVolumeprice";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByVolumeprice(Speciallineinfo obj){
			String stmtId = "Speciallineinfo.GetFindByVolumepriceCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Speciallineinfo> FindByWeightprice(Int32 weightprice) {
			String stmtId = "Speciallineinfo.FindByWeightprice";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, weightprice);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderFindByWeightprice(Int32 weightprice) {
			String stmtId = "Speciallineinfo.DescendOrderFindByWeightprice";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, weightprice);
			return result;
        }
		public IList<Speciallineinfo> PaginationFindByWeightprice(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.FindByWeightprice";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderPaginationFindByWeightprice(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.DescendOrderFindByWeightprice";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByWeightprice(Speciallineinfo obj){
			String stmtId = "Speciallineinfo.GetFindByWeightpriceCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Speciallineinfo> FindByDescription(String description) {
			String stmtId = "Speciallineinfo.FindByDescription";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, description);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderFindByDescription(String description) {
			String stmtId = "Speciallineinfo.DescendOrderFindByDescription";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, description);
			return result;
        }
		public IList<Speciallineinfo> PaginationFindByDescription(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.FindByDescription";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderPaginationFindByDescription(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.DescendOrderFindByDescription";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByDescription(Speciallineinfo obj){
			String stmtId = "Speciallineinfo.GetFindByDescriptionCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Speciallineinfo> FindBySourceplaceinfoid(Int64 sourceplaceinfoid) {
			String stmtId = "Speciallineinfo.FindBySourceplaceinfoid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, sourceplaceinfoid);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderFindBySourceplaceinfoid(Int64 sourceplaceinfoid) {
			String stmtId = "Speciallineinfo.DescendOrderFindBySourceplaceinfoid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, sourceplaceinfoid);
			return result;
        }
		public IList<Speciallineinfo> PaginationFindBySourceplaceinfoid(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.FindBySourceplaceinfoid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderPaginationFindBySourceplaceinfoid(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.DescendOrderFindBySourceplaceinfoid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountBySourceplaceinfoid(Speciallineinfo obj){
			String stmtId = "Speciallineinfo.GetFindBySourceplaceinfoidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Speciallineinfo> FindBySpeciallinetypeid(Int64 speciallinetypeid) {
			String stmtId = "Speciallineinfo.FindBySpeciallinetypeid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, speciallinetypeid);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderFindBySpeciallinetypeid(Int64 speciallinetypeid) {
			String stmtId = "Speciallineinfo.DescendOrderFindBySpeciallinetypeid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, speciallinetypeid);
			return result;
        }
		public IList<Speciallineinfo> PaginationFindBySpeciallinetypeid(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.FindBySpeciallinetypeid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderPaginationFindBySpeciallinetypeid(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.DescendOrderFindBySpeciallinetypeid";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountBySpeciallinetypeid(Speciallineinfo obj){
			String stmtId = "Speciallineinfo.GetFindBySpeciallinetypeidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Speciallineinfo> FindByReleasedate(DateTime releasedate) {
			String stmtId = "Speciallineinfo.FindByReleasedate";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, releasedate);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderFindByReleasedate(DateTime releasedate) {
			String stmtId = "Speciallineinfo.DescendOrderFindByReleasedate";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, releasedate);
			return result;
        }
		public IList<Speciallineinfo> PaginationFindByReleasedate(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.FindByReleasedate";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public IList<Speciallineinfo> DescendOrderPaginationFindByReleasedate(SpeciallineinfoPagination obj) {
			String stmtId = "SpeciallineinfoPagination.DescendOrderFindByReleasedate";
			IList<Speciallineinfo> result = this.sqlMapper.QueryForList<Speciallineinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByReleasedate(Speciallineinfo obj){
			String stmtId = "Speciallineinfo.GetFindByReleasedateCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Speciallineinfo obj) {
			String stmtId = "Speciallineinfo.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Speciallineinfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Speciallineinfo.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Speciallineinfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Speciallineinfo.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByUserid(Int64 userid) {
			String stmtId = "Speciallineinfo.DeleteByUserid";
			int result = this.sqlMapper.Delete(stmtId, userid);
			return result;
        }
		public int DeleteByDestinationplaceinfoid(Int64 destinationplaceinfoid) {
			String stmtId = "Speciallineinfo.DeleteByDestinationplaceinfoid";
			int result = this.sqlMapper.Delete(stmtId, destinationplaceinfoid);
			return result;
        }
		public int DeleteByDeparturetypeid(Int64 departuretypeid) {
			String stmtId = "Speciallineinfo.DeleteByDeparturetypeid";
			int result = this.sqlMapper.Delete(stmtId, departuretypeid);
			return result;
        }
		public int DeleteByTitle(String title) {
			String stmtId = "Speciallineinfo.DeleteByTitle";
			int result = this.sqlMapper.Delete(stmtId, title);
			return result;
        }
		public int DeleteByVolumeprice(Int32 volumeprice) {
			String stmtId = "Speciallineinfo.DeleteByVolumeprice";
			int result = this.sqlMapper.Delete(stmtId, volumeprice);
			return result;
        }
		public int DeleteByWeightprice(Int32 weightprice) {
			String stmtId = "Speciallineinfo.DeleteByWeightprice";
			int result = this.sqlMapper.Delete(stmtId, weightprice);
			return result;
        }
		public int DeleteByDescription(String description) {
			String stmtId = "Speciallineinfo.DeleteByDescription";
			int result = this.sqlMapper.Delete(stmtId, description);
			return result;
        }
		public int DeleteBySourceplaceinfoid(Int64 sourceplaceinfoid) {
			String stmtId = "Speciallineinfo.DeleteBySourceplaceinfoid";
			int result = this.sqlMapper.Delete(stmtId, sourceplaceinfoid);
			return result;
        }
		public int DeleteBySpeciallinetypeid(Int64 speciallinetypeid) {
			String stmtId = "Speciallineinfo.DeleteBySpeciallinetypeid";
			int result = this.sqlMapper.Delete(stmtId, speciallinetypeid);
			return result;
        }
		public int DeleteByReleasedate(DateTime releasedate) {
			String stmtId = "Speciallineinfo.DeleteByReleasedate";
			int result = this.sqlMapper.Delete(stmtId, releasedate);
			return result;
        }
		public void Reload(Speciallineinfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Speciallineinfo.Find";
			this.sqlMapper.QueryForObject<Speciallineinfo>(stmtId, obj, obj);
		}
    }
}
