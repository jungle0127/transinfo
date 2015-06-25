using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class GoodssourceinformationDao : IGoodssourceinformationDao
    {
        private ISqlMapper sqlMapper = null;
        public GoodssourceinformationDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Goodssourceinformation.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Goodssourceinformation Find(Int64 id) 
        {
			String stmtId = "Goodssourceinformation.Find";
			Goodssourceinformation result = this.sqlMapper.QueryForObject<Goodssourceinformation>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Goodssourceinformation.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Goodssourceinformation> FindAll() {
			String stmtId = "Goodssourceinformation.FindAll";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, null);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindAll() {
			String stmtId = "Goodssourceinformation.DescendOrderFindAll";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, null);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindAll(GoodssourceinformationPagination obj) {
			String stmtId = "Goodssourceinformation.FindAllPagination";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindAll(GoodssourceinformationPagination obj) {
			String stmtId = "Goodssourceinformation.DescendOrderFindAllPagination";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> QuickFindAll() {
			String stmtId = "Goodssourceinformation.QuickFindAll";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, null);
			return result;
        }
		public IList<Goodssourceinformation> FindByCautiontypeid(Int64 cautiontypeid) {
			String stmtId = "Goodssourceinformation.FindByCautiontypeid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, cautiontypeid);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByCautiontypeid(Int64 cautiontypeid) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByCautiontypeid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, cautiontypeid);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByCautiontypeid(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByCautiontypeid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByCautiontypeid(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByCautiontypeid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByCautiontypeid(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByCautiontypeidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindByNeedtrunkvolume(Int64 needtrunkvolume) {
			String stmtId = "Goodssourceinformation.FindByNeedtrunkvolume";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, needtrunkvolume);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByNeedtrunkvolume(Int64 needtrunkvolume) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByNeedtrunkvolume";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, needtrunkvolume);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByNeedtrunkvolume(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByNeedtrunkvolume";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByNeedtrunkvolume(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByNeedtrunkvolume";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByNeedtrunkvolume(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByNeedtrunkvolumeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindByDeadline(DateTime deadline) {
			String stmtId = "Goodssourceinformation.FindByDeadline";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, deadline);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByDeadline(DateTime deadline) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByDeadline";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, deadline);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByDeadline(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByDeadline";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByDeadline(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByDeadline";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDeadline(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByDeadlineCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindByNeedtrunkweight(Int64 needtrunkweight) {
			String stmtId = "Goodssourceinformation.FindByNeedtrunkweight";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, needtrunkweight);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByNeedtrunkweight(Int64 needtrunkweight) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByNeedtrunkweight";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, needtrunkweight);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByNeedtrunkweight(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByNeedtrunkweight";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByNeedtrunkweight(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByNeedtrunkweight";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByNeedtrunkweight(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByNeedtrunkweightCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindByReleasedate(DateTime releasedate) {
			String stmtId = "Goodssourceinformation.FindByReleasedate";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, releasedate);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByReleasedate(DateTime releasedate) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByReleasedate";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, releasedate);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByReleasedate(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByReleasedate";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByReleasedate(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByReleasedate";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByReleasedate(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByReleasedateCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindByUserid(Int64 userid) {
			String stmtId = "Goodssourceinformation.FindByUserid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, userid);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByUserid(Int64 userid) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByUserid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, userid);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByUserid(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByUserid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByUserid(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByUserid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByUserid(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByUseridCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindByNeedtrunklength(Int64 needtrunklength) {
			String stmtId = "Goodssourceinformation.FindByNeedtrunklength";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, needtrunklength);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByNeedtrunklength(Int64 needtrunklength) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByNeedtrunklength";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, needtrunklength);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByNeedtrunklength(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByNeedtrunklength";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByNeedtrunklength(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByNeedtrunklength";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByNeedtrunklength(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByNeedtrunklengthCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindByPrice(String price) {
			String stmtId = "Goodssourceinformation.FindByPrice";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, price);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByPrice(String price) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByPrice";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, price);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByPrice(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByPrice";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByPrice(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByPrice";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByPrice(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByPriceCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindByGoodsname(String goodsname) {
			String stmtId = "Goodssourceinformation.FindByGoodsname";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, goodsname);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByGoodsname(String goodsname) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByGoodsname";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, goodsname);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByGoodsname(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByGoodsname";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByGoodsname(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByGoodsname";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByGoodsname(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByGoodsnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindByTitle(String title) {
			String stmtId = "Goodssourceinformation.FindByTitle";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, title);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByTitle(String title) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByTitle";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, title);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByTitle(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByTitle";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByTitle(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByTitle";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTitle(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByTitleCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindByTransporttypeid(Int64 transporttypeid) {
			String stmtId = "Goodssourceinformation.FindByTransporttypeid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, transporttypeid);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByTransporttypeid(Int64 transporttypeid) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByTransporttypeid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, transporttypeid);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByTransporttypeid(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByTransporttypeid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByTransporttypeid(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByTransporttypeid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTransporttypeid(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByTransporttypeidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindByContent(String content) {
			String stmtId = "Goodssourceinformation.FindByContent";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, content);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByContent(String content) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByContent";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, content);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByContent(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByContent";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByContent(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByContent";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByContent(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByContentCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindBySrccountycode(String srccountycode) {
			String stmtId = "Goodssourceinformation.FindBySrccountycode";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, srccountycode);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindBySrccountycode(String srccountycode) {
			String stmtId = "Goodssourceinformation.DescendOrderFindBySrccountycode";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, srccountycode);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindBySrccountycode(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindBySrccountycode";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindBySrccountycode(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindBySrccountycode";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountBySrccountycode(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindBySrccountycodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindByDstcountycode(String dstcountycode) {
			String stmtId = "Goodssourceinformation.FindByDstcountycode";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, dstcountycode);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByDstcountycode(String dstcountycode) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByDstcountycode";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, dstcountycode);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByDstcountycode(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByDstcountycode";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByDstcountycode(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByDstcountycode";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDstcountycode(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByDstcountycodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindByActive(Byte active) {
			String stmtId = "Goodssourceinformation.FindByActive";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, active);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByActive(Byte active) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByActive";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, active);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByActive(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByActive";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByActive(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByActive";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByActive(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByActiveCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindByGoodstypeid(Int64 goodstypeid) {
			String stmtId = "Goodssourceinformation.FindByGoodstypeid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, goodstypeid);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByGoodstypeid(Int64 goodstypeid) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByGoodstypeid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, goodstypeid);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByGoodstypeid(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByGoodstypeid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByGoodstypeid(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByGoodstypeid";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByGoodstypeid(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByGoodstypeidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Goodssourceinformation> FindByTitlecolor(String titlecolor) {
			String stmtId = "Goodssourceinformation.FindByTitlecolor";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, titlecolor);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderFindByTitlecolor(String titlecolor) {
			String stmtId = "Goodssourceinformation.DescendOrderFindByTitlecolor";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, titlecolor);
			return result;
        }
		public IList<Goodssourceinformation> PaginationFindByTitlecolor(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.FindByTitlecolor";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Goodssourceinformation> DescendOrderPaginationFindByTitlecolor(GoodssourceinformationPagination obj) {
			String stmtId = "GoodssourceinformationPagination.DescendOrderFindByTitlecolor";
			IList<Goodssourceinformation> result = this.sqlMapper.QueryForList<Goodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTitlecolor(Goodssourceinformation obj){
			String stmtId = "Goodssourceinformation.GetFindByTitlecolorCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Goodssourceinformation obj) {
			String stmtId = "Goodssourceinformation.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Goodssourceinformation obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Goodssourceinformation.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Goodssourceinformation obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Goodssourceinformation.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByCautiontypeid(Int64 cautiontypeid) {
			String stmtId = "Goodssourceinformation.DeleteByCautiontypeid";
			int result = this.sqlMapper.Delete(stmtId, cautiontypeid);
			return result;
        }
		public int DeleteByNeedtrunkvolume(Int64 needtrunkvolume) {
			String stmtId = "Goodssourceinformation.DeleteByNeedtrunkvolume";
			int result = this.sqlMapper.Delete(stmtId, needtrunkvolume);
			return result;
        }
		public int DeleteByDeadline(DateTime deadline) {
			String stmtId = "Goodssourceinformation.DeleteByDeadline";
			int result = this.sqlMapper.Delete(stmtId, deadline);
			return result;
        }
		public int DeleteByNeedtrunkweight(Int64 needtrunkweight) {
			String stmtId = "Goodssourceinformation.DeleteByNeedtrunkweight";
			int result = this.sqlMapper.Delete(stmtId, needtrunkweight);
			return result;
        }
		public int DeleteByReleasedate(DateTime releasedate) {
			String stmtId = "Goodssourceinformation.DeleteByReleasedate";
			int result = this.sqlMapper.Delete(stmtId, releasedate);
			return result;
        }
		public int DeleteByUserid(Int64 userid) {
			String stmtId = "Goodssourceinformation.DeleteByUserid";
			int result = this.sqlMapper.Delete(stmtId, userid);
			return result;
        }
		public int DeleteByNeedtrunklength(Int64 needtrunklength) {
			String stmtId = "Goodssourceinformation.DeleteByNeedtrunklength";
			int result = this.sqlMapper.Delete(stmtId, needtrunklength);
			return result;
        }
		public int DeleteByPrice(String price) {
			String stmtId = "Goodssourceinformation.DeleteByPrice";
			int result = this.sqlMapper.Delete(stmtId, price);
			return result;
        }
		public int DeleteByGoodsname(String goodsname) {
			String stmtId = "Goodssourceinformation.DeleteByGoodsname";
			int result = this.sqlMapper.Delete(stmtId, goodsname);
			return result;
        }
		public int DeleteByTitle(String title) {
			String stmtId = "Goodssourceinformation.DeleteByTitle";
			int result = this.sqlMapper.Delete(stmtId, title);
			return result;
        }
		public int DeleteByTransporttypeid(Int64 transporttypeid) {
			String stmtId = "Goodssourceinformation.DeleteByTransporttypeid";
			int result = this.sqlMapper.Delete(stmtId, transporttypeid);
			return result;
        }
		public int DeleteByContent(String content) {
			String stmtId = "Goodssourceinformation.DeleteByContent";
			int result = this.sqlMapper.Delete(stmtId, content);
			return result;
        }
		public int DeleteBySrccountycode(String srccountycode) {
			String stmtId = "Goodssourceinformation.DeleteBySrccountycode";
			int result = this.sqlMapper.Delete(stmtId, srccountycode);
			return result;
        }
		public int DeleteByDstcountycode(String dstcountycode) {
			String stmtId = "Goodssourceinformation.DeleteByDstcountycode";
			int result = this.sqlMapper.Delete(stmtId, dstcountycode);
			return result;
        }
		public int DeleteByActive(Byte active) {
			String stmtId = "Goodssourceinformation.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public int DeleteByGoodstypeid(Int64 goodstypeid) {
			String stmtId = "Goodssourceinformation.DeleteByGoodstypeid";
			int result = this.sqlMapper.Delete(stmtId, goodstypeid);
			return result;
        }
		public int DeleteByTitlecolor(String titlecolor) {
			String stmtId = "Goodssourceinformation.DeleteByTitlecolor";
			int result = this.sqlMapper.Delete(stmtId, titlecolor);
			return result;
        }
		public void Reload(Goodssourceinformation obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Goodssourceinformation.Find";
			this.sqlMapper.QueryForObject<Goodssourceinformation>(stmtId, obj, obj);
		}
    }
}
