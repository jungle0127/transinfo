using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class VgoodssourceinformationDao : IVgoodssourceinformationDao
    {
        private ISqlMapper sqlMapper = null;
        public VgoodssourceinformationDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
        public IList<Vgoodssourceinformation> DynamicQuery(VgoodssourceinformationPagination obj)
        {
            String stmtId = "Vgoodssourceinformation.DynamicQuery";
            IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
            return result;
        }

        public int DynamicCount(VgoodssourceinformationPagination obj)
        {
            String stmtId = "Vgoodssourceinformation.DynamicCount";
            int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
            return result;
        }
		public int GetCount() {
			String stmtId = "Vgoodssourceinformation.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Vgoodssourceinformation Find(Int64 id) 
        {
			String stmtId = "Vgoodssourceinformation.Find";
			Vgoodssourceinformation result = this.sqlMapper.QueryForObject<Vgoodssourceinformation>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Vgoodssourceinformation.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Vgoodssourceinformation> FindAll() {
			String stmtId = "Vgoodssourceinformation.FindAll";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, null);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindAll() {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindAll";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, null);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindAll(VgoodssourceinformationPagination obj) {
			String stmtId = "Vgoodssourceinformation.FindAllPagination";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindAll(VgoodssourceinformationPagination obj) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindAllPagination";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> QuickFindAll() {
			String stmtId = "Vgoodssourceinformation.QuickFindAll";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, null);
			return result;
        }
		public IList<Vgoodssourceinformation> FindByGoodstypename(String goodstypename) {
			String stmtId = "Vgoodssourceinformation.FindByGoodstypename";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, goodstypename);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByGoodstypename(String goodstypename) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByGoodstypename";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, goodstypename);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByGoodstypename(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByGoodstypename";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByGoodstypename(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByGoodstypename";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByGoodstypename(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByGoodstypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByGoodstypeid(Int64 goodstypeid) {
			String stmtId = "Vgoodssourceinformation.FindByGoodstypeid";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, goodstypeid);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByGoodstypeid(Int64 goodstypeid) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByGoodstypeid";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, goodstypeid);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByGoodstypeid(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByGoodstypeid";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByGoodstypeid(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByGoodstypeid";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByGoodstypeid(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByGoodstypeidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByDeadline(DateTime deadline) {
			String stmtId = "Vgoodssourceinformation.FindByDeadline";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, deadline);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByDeadline(DateTime deadline) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByDeadline";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, deadline);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByDeadline(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByDeadline";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByDeadline(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByDeadline";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDeadline(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByDeadlineCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByNeedtrunkweight(Int64 needtrunkweight) {
			String stmtId = "Vgoodssourceinformation.FindByNeedtrunkweight";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, needtrunkweight);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByNeedtrunkweight(Int64 needtrunkweight) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByNeedtrunkweight";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, needtrunkweight);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByNeedtrunkweight(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByNeedtrunkweight";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByNeedtrunkweight(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByNeedtrunkweight";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByNeedtrunkweight(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByNeedtrunkweightCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByTransporttypename(String transporttypename) {
			String stmtId = "Vgoodssourceinformation.FindByTransporttypename";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, transporttypename);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByTransporttypename(String transporttypename) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByTransporttypename";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, transporttypename);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByTransporttypename(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByTransporttypename";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByTransporttypename(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByTransporttypename";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTransporttypename(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByTransporttypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByCautiontypename(String cautiontypename) {
			String stmtId = "Vgoodssourceinformation.FindByCautiontypename";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, cautiontypename);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByCautiontypename(String cautiontypename) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByCautiontypename";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, cautiontypename);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByCautiontypename(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByCautiontypename";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByCautiontypename(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByCautiontypename";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByCautiontypename(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByCautiontypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByNeedtrunklength(Int64 needtrunklength) {
			String stmtId = "Vgoodssourceinformation.FindByNeedtrunklength";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, needtrunklength);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByNeedtrunklength(Int64 needtrunklength) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByNeedtrunklength";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, needtrunklength);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByNeedtrunklength(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByNeedtrunklength";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByNeedtrunklength(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByNeedtrunklength";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByNeedtrunklength(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByNeedtrunklengthCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByPrice(String price) {
			String stmtId = "Vgoodssourceinformation.FindByPrice";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, price);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByPrice(String price) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByPrice";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, price);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByPrice(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByPrice";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByPrice(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByPrice";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByPrice(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByPriceCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByGoodsname(String goodsname) {
			String stmtId = "Vgoodssourceinformation.FindByGoodsname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, goodsname);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByGoodsname(String goodsname) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByGoodsname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, goodsname);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByGoodsname(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByGoodsname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByGoodsname(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByGoodsname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByGoodsname(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByGoodsnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindBySrccityname(String srccityname) {
			String stmtId = "Vgoodssourceinformation.FindBySrccityname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, srccityname);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindBySrccityname(String srccityname) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindBySrccityname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, srccityname);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindBySrccityname(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindBySrccityname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindBySrccityname(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindBySrccityname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountBySrccityname(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindBySrccitynameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindBySrccitycode(String srccitycode) {
			String stmtId = "Vgoodssourceinformation.FindBySrccitycode";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, srccitycode);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindBySrccitycode(String srccitycode) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindBySrccitycode";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, srccitycode);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindBySrccitycode(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindBySrccitycode";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindBySrccitycode(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindBySrccitycode";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountBySrccitycode(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindBySrccitycodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindBySrcregionname(String srcregionname) {
			String stmtId = "Vgoodssourceinformation.FindBySrcregionname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, srcregionname);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindBySrcregionname(String srcregionname) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindBySrcregionname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, srcregionname);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindBySrcregionname(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindBySrcregionname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindBySrcregionname(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindBySrcregionname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountBySrcregionname(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindBySrcregionnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByContent(String content) {
			String stmtId = "Vgoodssourceinformation.FindByContent";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, content);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByContent(String content) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByContent";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, content);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByContent(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByContent";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByContent(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByContent";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByContent(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByContentCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindById(Int64 id) {
			String stmtId = "Vgoodssourceinformation.FindById";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, id);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindById(Int64 id) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindById";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, id);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindById(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindById";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindById(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindById";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountById(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByIdCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByDstregionname(String dstregionname) {
			String stmtId = "Vgoodssourceinformation.FindByDstregionname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, dstregionname);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByDstregionname(String dstregionname) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByDstregionname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, dstregionname);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByDstregionname(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByDstregionname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByDstregionname(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByDstregionname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDstregionname(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByDstregionnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByNeedtrunkvolume(Int64 needtrunkvolume) {
			String stmtId = "Vgoodssourceinformation.FindByNeedtrunkvolume";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, needtrunkvolume);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByNeedtrunkvolume(Int64 needtrunkvolume) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByNeedtrunkvolume";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, needtrunkvolume);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByNeedtrunkvolume(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByNeedtrunkvolume";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByNeedtrunkvolume(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByNeedtrunkvolume";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByNeedtrunkvolume(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByNeedtrunkvolumeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByReleasedate(DateTime releasedate) {
			String stmtId = "Vgoodssourceinformation.FindByReleasedate";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, releasedate);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByReleasedate(DateTime releasedate) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByReleasedate";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, releasedate);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByReleasedate(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByReleasedate";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByReleasedate(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByReleasedate";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByReleasedate(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByReleasedateCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByDstcityname(String dstcityname) {
			String stmtId = "Vgoodssourceinformation.FindByDstcityname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, dstcityname);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByDstcityname(String dstcityname) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByDstcityname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, dstcityname);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByDstcityname(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByDstcityname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByDstcityname(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByDstcityname";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDstcityname(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByDstcitynameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByDstcitycode(String dstcitycode) {
			String stmtId = "Vgoodssourceinformation.FindByDstcitycode";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, dstcitycode);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByDstcitycode(String dstcitycode) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByDstcitycode";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, dstcitycode);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByDstcitycode(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByDstcitycode";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByDstcitycode(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByDstcitycode";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDstcitycode(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByDstcitycodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByTitle(String title) {
			String stmtId = "Vgoodssourceinformation.FindByTitle";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, title);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByTitle(String title) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByTitle";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, title);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByTitle(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByTitle";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByTitle(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByTitle";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTitle(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByTitleCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByTitlecolor(String titlecolor) {
			String stmtId = "Vgoodssourceinformation.FindByTitlecolor";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, titlecolor);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByTitlecolor(String titlecolor) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByTitlecolor";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, titlecolor);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByTitlecolor(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByTitlecolor";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByTitlecolor(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByTitlecolor";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTitlecolor(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByTitlecolorCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vgoodssourceinformation> FindByUsername(String username) {
			String stmtId = "Vgoodssourceinformation.FindByUsername";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, username);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderFindByUsername(String username) {
			String stmtId = "Vgoodssourceinformation.DescendOrderFindByUsername";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, username);
			return result;
        }
		public IList<Vgoodssourceinformation> PaginationFindByUsername(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.FindByUsername";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public IList<Vgoodssourceinformation> DescendOrderPaginationFindByUsername(VgoodssourceinformationPagination obj) {
			String stmtId = "VgoodssourceinformationPagination.DescendOrderFindByUsername";
			IList<Vgoodssourceinformation> result = this.sqlMapper.QueryForList<Vgoodssourceinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByUsername(Vgoodssourceinformation obj){
			String stmtId = "Vgoodssourceinformation.GetFindByUsernameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Reload(Vgoodssourceinformation obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Vgoodssourceinformation.Find";
			this.sqlMapper.QueryForObject<Vgoodssourceinformation>(stmtId, obj, obj);
		}
    }
}
