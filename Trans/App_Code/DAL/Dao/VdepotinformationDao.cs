using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class VdepotinformationDao : IVdepotinformationDao
    {
        private ISqlMapper sqlMapper = null;
        public VdepotinformationDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Vdepotinformation.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
        public IList<Vdepotinformation> DynamicQuery(VdepotinformationPagination obj)
        {
            String stmtId = "Vdepotinformation.DynamicQuery";
            IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
            return result;
        }
        public int DynamicCount(VdepotinformationPagination obj)
        {
            String stmtId = "Vdepotinformation.DynamicCount";
            int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
            return result;
        }
		public Vdepotinformation Find(Int64 id) 
        {
			String stmtId = "Vdepotinformation.Find";
			Vdepotinformation result = this.sqlMapper.QueryForObject<Vdepotinformation>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Vdepotinformation.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Vdepotinformation> FindAll() {
			String stmtId = "Vdepotinformation.FindAll";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, null);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindAll() {
			String stmtId = "Vdepotinformation.DescendOrderFindAll";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, null);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindAll(VdepotinformationPagination obj) {
			String stmtId = "Vdepotinformation.FindAllPagination";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindAll(VdepotinformationPagination obj) {
			String stmtId = "Vdepotinformation.DescendOrderFindAllPagination";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> QuickFindAll() {
			String stmtId = "Vdepotinformation.QuickFindAll";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, null);
			return result;
        }
		public IList<Vdepotinformation> FindByScopeid(Int64 scopeid) {
			String stmtId = "Vdepotinformation.FindByScopeid";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, scopeid);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByScopeid(Int64 scopeid) {
			String stmtId = "Vdepotinformation.DescendOrderFindByScopeid";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, scopeid);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByScopeid(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByScopeid";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByScopeid(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByScopeid";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByScopeid(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByScopeidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByDescription(String description) {
			String stmtId = "Vdepotinformation.FindByDescription";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, description);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByDescription(String description) {
			String stmtId = "Vdepotinformation.DescendOrderFindByDescription";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, description);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByDescription(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByDescription";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByDescription(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByDescription";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDescription(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByDescriptionCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByValidtime(String validtime) {
			String stmtId = "Vdepotinformation.FindByValidtime";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, validtime);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByValidtime(String validtime) {
			String stmtId = "Vdepotinformation.DescendOrderFindByValidtime";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, validtime);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByValidtime(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByValidtime";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByValidtime(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByValidtime";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByValidtime(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByValidtimeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByCityname(String cityname) {
			String stmtId = "Vdepotinformation.FindByCityname";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, cityname);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByCityname(String cityname) {
			String stmtId = "Vdepotinformation.DescendOrderFindByCityname";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, cityname);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByCityname(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByCityname";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByCityname(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByCityname";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByCityname(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByCitynameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByUseablearea(Int32 useablearea) {
			String stmtId = "Vdepotinformation.FindByUseablearea";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, useablearea);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByUseablearea(Int32 useablearea) {
			String stmtId = "Vdepotinformation.DescendOrderFindByUseablearea";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, useablearea);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByUseablearea(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByUseablearea";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByUseablearea(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByUseablearea";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByUseablearea(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByUseableareaCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByDepottypeid(Int64 depottypeid) {
			String stmtId = "Vdepotinformation.FindByDepottypeid";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, depottypeid);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByDepottypeid(Int64 depottypeid) {
			String stmtId = "Vdepotinformation.DescendOrderFindByDepottypeid";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, depottypeid);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByDepottypeid(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByDepottypeid";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByDepottypeid(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByDepottypeid";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDepottypeid(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByDepottypeidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByScopename(String scopename) {
			String stmtId = "Vdepotinformation.FindByScopename";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, scopename);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByScopename(String scopename) {
			String stmtId = "Vdepotinformation.DescendOrderFindByScopename";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, scopename);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByScopename(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByScopename";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByScopename(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByScopename";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByScopename(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByScopenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByPrice(String price) {
			String stmtId = "Vdepotinformation.FindByPrice";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, price);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByPrice(String price) {
			String stmtId = "Vdepotinformation.DescendOrderFindByPrice";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, price);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByPrice(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByPrice";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByPrice(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByPrice";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByPrice(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByPriceCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByContactperson(String contactperson) {
			String stmtId = "Vdepotinformation.FindByContactperson";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, contactperson);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByContactperson(String contactperson) {
			String stmtId = "Vdepotinformation.DescendOrderFindByContactperson";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, contactperson);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByContactperson(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByContactperson";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByContactperson(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByContactperson";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByContactperson(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByContactpersonCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByTitle(String title) {
			String stmtId = "Vdepotinformation.FindByTitle";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, title);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByTitle(String title) {
			String stmtId = "Vdepotinformation.DescendOrderFindByTitle";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, title);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByTitle(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByTitle";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByTitle(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByTitle";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTitle(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByTitleCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByRegionname(String regionname) {
			String stmtId = "Vdepotinformation.FindByRegionname";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, regionname);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByRegionname(String regionname) {
			String stmtId = "Vdepotinformation.DescendOrderFindByRegionname";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, regionname);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByRegionname(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByRegionname";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByRegionname(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByRegionname";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByRegionname(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByRegionnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindById(Int64 id) {
			String stmtId = "Vdepotinformation.FindById";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, id);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindById(Int64 id) {
			String stmtId = "Vdepotinformation.DescendOrderFindById";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, id);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindById(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindById";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindById(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindById";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountById(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByIdCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByDepottypename(String depottypename) {
			String stmtId = "Vdepotinformation.FindByDepottypename";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, depottypename);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByDepottypename(String depottypename) {
			String stmtId = "Vdepotinformation.DescendOrderFindByDepottypename";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, depottypename);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByDepottypename(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByDepottypename";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByDepottypename(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByDepottypename";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDepottypename(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByDepottypenameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByCellphone(String cellphone) {
			String stmtId = "Vdepotinformation.FindByCellphone";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, cellphone);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByCellphone(String cellphone) {
			String stmtId = "Vdepotinformation.DescendOrderFindByCellphone";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, cellphone);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByCellphone(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByCellphone";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByCellphone(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByCellphone";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByCellphone(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByCellphoneCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByAddress(String address) {
			String stmtId = "Vdepotinformation.FindByAddress";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, address);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByAddress(String address) {
			String stmtId = "Vdepotinformation.DescendOrderFindByAddress";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, address);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByAddress(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByAddress";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByAddress(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByAddress";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByAddress(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByAddressCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByCitycode(String citycode) {
			String stmtId = "Vdepotinformation.FindByCitycode";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, citycode);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByCitycode(String citycode) {
			String stmtId = "Vdepotinformation.DescendOrderFindByCitycode";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, citycode);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByCitycode(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByCitycode";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByCitycode(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByCitycode";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByCitycode(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByCitycodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByArea(Int32 area) {
			String stmtId = "Vdepotinformation.FindByArea";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, area);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByArea(Int32 area) {
			String stmtId = "Vdepotinformation.DescendOrderFindByArea";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, area);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByArea(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByArea";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByArea(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByArea";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByArea(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByAreaCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Vdepotinformation> FindByUsername(String username) {
			String stmtId = "Vdepotinformation.FindByUsername";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, username);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderFindByUsername(String username) {
			String stmtId = "Vdepotinformation.DescendOrderFindByUsername";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, username);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByUsername(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByUsername";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> DescendOrderPaginationFindByUsername(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.DescendOrderFindByUsername";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByUsername(Vdepotinformation obj){
			String stmtId = "Vdepotinformation.GetFindByUsernameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Reload(Vdepotinformation obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Vdepotinformation.Find";
			this.sqlMapper.QueryForObject<Vdepotinformation>(stmtId, obj, obj);
		}
    }
}
