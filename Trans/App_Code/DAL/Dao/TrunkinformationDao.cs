using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class TrunkinformationDao : ITrunkinformationDao
    {
        private ISqlMapper sqlMapper = null;
        public TrunkinformationDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Trunkinformation.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Trunkinformation Find(Int64 id) 
        {
			String stmtId = "Trunkinformation.Find";
			Trunkinformation result = this.sqlMapper.QueryForObject<Trunkinformation>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Trunkinformation.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Trunkinformation> FindAll() {
			String stmtId = "Trunkinformation.FindAll";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, null);
			return result;
        }
		public IList<Trunkinformation> PaginationFindAll(TrunkinformationPagination obj) {
			String stmtId = "Trunkinformation.FindAllPagination";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public IList<Trunkinformation> QuickFindAll() {
			String stmtId = "Trunkinformation.QuickFindAll";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, null);
			return result;
        }
		public IList<Trunkinformation> FindBySrccountycode(String srccountycode) {
			String stmtId = "Trunkinformation.FindBySrccountycode";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, srccountycode);
			return result;
        }
		public IList<Trunkinformation> PaginationFindBySrccountycode(TrunkinformationPagination obj) {
			String stmtId = "TrunkinformationPagination.FindBySrccountycode";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountBySrccountycode(Trunkinformation obj){
			String stmtId = "Trunkinformation.GetFindBySrccountycodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunkinformation> FindByMarketprice(String marketprice) {
			String stmtId = "Trunkinformation.FindByMarketprice";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, marketprice);
			return result;
        }
		public IList<Trunkinformation> PaginationFindByMarketprice(TrunkinformationPagination obj) {
			String stmtId = "TrunkinformationPagination.FindByMarketprice";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByMarketprice(Trunkinformation obj){
			String stmtId = "Trunkinformation.GetFindByMarketpriceCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunkinformation> FindByTimetypeid(Int64 timetypeid) {
			String stmtId = "Trunkinformation.FindByTimetypeid";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, timetypeid);
			return result;
        }
		public IList<Trunkinformation> PaginationFindByTimetypeid(TrunkinformationPagination obj) {
			String stmtId = "TrunkinformationPagination.FindByTimetypeid";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTimetypeid(Trunkinformation obj){
			String stmtId = "Trunkinformation.GetFindByTimetypeidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunkinformation> FindByTakeofftime(DateTime takeofftime) {
			String stmtId = "Trunkinformation.FindByTakeofftime";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, takeofftime);
			return result;
        }
		public IList<Trunkinformation> PaginationFindByTakeofftime(TrunkinformationPagination obj) {
			String stmtId = "TrunkinformationPagination.FindByTakeofftime";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTakeofftime(Trunkinformation obj){
			String stmtId = "Trunkinformation.GetFindByTakeofftimeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunkinformation> FindByRouter(String router) {
			String stmtId = "Trunkinformation.FindByRouter";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, router);
			return result;
        }
		public IList<Trunkinformation> PaginationFindByRouter(TrunkinformationPagination obj) {
			String stmtId = "TrunkinformationPagination.FindByRouter";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByRouter(Trunkinformation obj){
			String stmtId = "Trunkinformation.GetFindByRouterCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunkinformation> FindByUserid(Int64 userid) {
			String stmtId = "Trunkinformation.FindByUserid";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, userid);
			return result;
        }
		public IList<Trunkinformation> PaginationFindByUserid(TrunkinformationPagination obj) {
			String stmtId = "TrunkinformationPagination.FindByUserid";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByUserid(Trunkinformation obj){
			String stmtId = "Trunkinformation.GetFindByUseridCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunkinformation> FindByNegotiateprice(String negotiateprice) {
			String stmtId = "Trunkinformation.FindByNegotiateprice";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, negotiateprice);
			return result;
        }
		public IList<Trunkinformation> PaginationFindByNegotiateprice(TrunkinformationPagination obj) {
			String stmtId = "TrunkinformationPagination.FindByNegotiateprice";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByNegotiateprice(Trunkinformation obj){
			String stmtId = "Trunkinformation.GetFindByNegotiatepriceCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunkinformation> FindByReturntypeid(Int64 returntypeid) {
			String stmtId = "Trunkinformation.FindByReturntypeid";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, returntypeid);
			return result;
        }
		public IList<Trunkinformation> PaginationFindByReturntypeid(TrunkinformationPagination obj) {
			String stmtId = "TrunkinformationPagination.FindByReturntypeid";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByReturntypeid(Trunkinformation obj){
			String stmtId = "Trunkinformation.GetFindByReturntypeidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunkinformation> FindByActive(Byte active) {
			String stmtId = "Trunkinformation.FindByActive";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, active);
			return result;
        }
		public IList<Trunkinformation> PaginationFindByActive(TrunkinformationPagination obj) {
			String stmtId = "TrunkinformationPagination.FindByActive";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByActive(Trunkinformation obj){
			String stmtId = "Trunkinformation.GetFindByActiveCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunkinformation> FindByTrunkid(Int64 trunkid) {
			String stmtId = "Trunkinformation.FindByTrunkid";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, trunkid);
			return result;
        }
		public IList<Trunkinformation> PaginationFindByTrunkid(TrunkinformationPagination obj) {
			String stmtId = "TrunkinformationPagination.FindByTrunkid";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTrunkid(Trunkinformation obj){
			String stmtId = "Trunkinformation.GetFindByTrunkidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunkinformation> FindByTitle(String title) {
			String stmtId = "Trunkinformation.FindByTitle";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, title);
			return result;
        }
		public IList<Trunkinformation> PaginationFindByTitle(TrunkinformationPagination obj) {
			String stmtId = "TrunkinformationPagination.FindByTitle";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTitle(Trunkinformation obj){
			String stmtId = "Trunkinformation.GetFindByTitleCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunkinformation> FindByDstcountycode(String dstcountycode) {
			String stmtId = "Trunkinformation.FindByDstcountycode";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, dstcountycode);
			return result;
        }
		public IList<Trunkinformation> PaginationFindByDstcountycode(TrunkinformationPagination obj) {
			String stmtId = "TrunkinformationPagination.FindByDstcountycode";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDstcountycode(Trunkinformation obj){
			String stmtId = "Trunkinformation.GetFindByDstcountycodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunkinformation> FindByReleasedate(DateTime releasedate) {
			String stmtId = "Trunkinformation.FindByReleasedate";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, releasedate);
			return result;
        }
		public IList<Trunkinformation> PaginationFindByReleasedate(TrunkinformationPagination obj) {
			String stmtId = "TrunkinformationPagination.FindByReleasedate";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByReleasedate(Trunkinformation obj){
			String stmtId = "Trunkinformation.GetFindByReleasedateCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunkinformation> FindByDescription(String description) {
			String stmtId = "Trunkinformation.FindByDescription";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, description);
			return result;
        }
		public IList<Trunkinformation> PaginationFindByDescription(TrunkinformationPagination obj) {
			String stmtId = "TrunkinformationPagination.FindByDescription";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDescription(Trunkinformation obj){
			String stmtId = "Trunkinformation.GetFindByDescriptionCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Trunkinformation> FindByRoutetypeid(Int64 routetypeid) {
			String stmtId = "Trunkinformation.FindByRoutetypeid";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, routetypeid);
			return result;
        }
		public IList<Trunkinformation> PaginationFindByRoutetypeid(TrunkinformationPagination obj) {
			String stmtId = "TrunkinformationPagination.FindByRoutetypeid";
			IList<Trunkinformation> result = this.sqlMapper.QueryForList<Trunkinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByRoutetypeid(Trunkinformation obj){
			String stmtId = "Trunkinformation.GetFindByRoutetypeidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Trunkinformation obj) {
			String stmtId = "Trunkinformation.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Trunkinformation obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunkinformation.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Trunkinformation obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunkinformation.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteBySrccountycode(String srccountycode) {
			String stmtId = "Trunkinformation.DeleteBySrccountycode";
			int result = this.sqlMapper.Delete(stmtId, srccountycode);
			return result;
        }
		public int DeleteByMarketprice(String marketprice) {
			String stmtId = "Trunkinformation.DeleteByMarketprice";
			int result = this.sqlMapper.Delete(stmtId, marketprice);
			return result;
        }
		public int DeleteByTimetypeid(Int64 timetypeid) {
			String stmtId = "Trunkinformation.DeleteByTimetypeid";
			int result = this.sqlMapper.Delete(stmtId, timetypeid);
			return result;
        }
		public int DeleteByTakeofftime(DateTime takeofftime) {
			String stmtId = "Trunkinformation.DeleteByTakeofftime";
			int result = this.sqlMapper.Delete(stmtId, takeofftime);
			return result;
        }
		public int DeleteByRouter(String router) {
			String stmtId = "Trunkinformation.DeleteByRouter";
			int result = this.sqlMapper.Delete(stmtId, router);
			return result;
        }
		public int DeleteByUserid(Int64 userid) {
			String stmtId = "Trunkinformation.DeleteByUserid";
			int result = this.sqlMapper.Delete(stmtId, userid);
			return result;
        }
		public int DeleteByNegotiateprice(String negotiateprice) {
			String stmtId = "Trunkinformation.DeleteByNegotiateprice";
			int result = this.sqlMapper.Delete(stmtId, negotiateprice);
			return result;
        }
		public int DeleteByReturntypeid(Int64 returntypeid) {
			String stmtId = "Trunkinformation.DeleteByReturntypeid";
			int result = this.sqlMapper.Delete(stmtId, returntypeid);
			return result;
        }
		public int DeleteByActive(Byte active) {
			String stmtId = "Trunkinformation.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public int DeleteByTrunkid(Int64 trunkid) {
			String stmtId = "Trunkinformation.DeleteByTrunkid";
			int result = this.sqlMapper.Delete(stmtId, trunkid);
			return result;
        }
		public int DeleteByTitle(String title) {
			String stmtId = "Trunkinformation.DeleteByTitle";
			int result = this.sqlMapper.Delete(stmtId, title);
			return result;
        }
		public int DeleteByDstcountycode(String dstcountycode) {
			String stmtId = "Trunkinformation.DeleteByDstcountycode";
			int result = this.sqlMapper.Delete(stmtId, dstcountycode);
			return result;
        }
		public int DeleteByReleasedate(DateTime releasedate) {
			String stmtId = "Trunkinformation.DeleteByReleasedate";
			int result = this.sqlMapper.Delete(stmtId, releasedate);
			return result;
        }
		public int DeleteByDescription(String description) {
			String stmtId = "Trunkinformation.DeleteByDescription";
			int result = this.sqlMapper.Delete(stmtId, description);
			return result;
        }
		public int DeleteByRoutetypeid(Int64 routetypeid) {
			String stmtId = "Trunkinformation.DeleteByRoutetypeid";
			int result = this.sqlMapper.Delete(stmtId, routetypeid);
			return result;
        }
		public void Reload(Trunkinformation obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunkinformation.Find";
			this.sqlMapper.QueryForObject<Trunkinformation>(stmtId, obj, obj);
		}
    }
}
