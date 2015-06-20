using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class DepotinformationDao : IDepotinformationDao
    {
        private ISqlMapper sqlMapper = null;
        public DepotinformationDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Depotinformation.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Depotinformation Find(Int64 id) 
        {
			String stmtId = "Depotinformation.Find";
			Depotinformation result = this.sqlMapper.QueryForObject<Depotinformation>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Depotinformation.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Depotinformation> FindAll() {
			String stmtId = "Depotinformation.FindAll";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, null);
			return result;
        }
		public IList<Depotinformation> PaginationFindAll(DepotinformationPagination obj) {
			String stmtId = "Depotinformation.FindAllPagination";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, obj);
			return result;
        }
		public IList<Depotinformation> QuickFindAll() {
			String stmtId = "Depotinformation.QuickFindAll";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, null);
			return result;
        }
		public IList<Depotinformation> FindByCellphone(String cellphone) {
			String stmtId = "Depotinformation.FindByCellphone";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, cellphone);
			return result;
        }
		public IList<Depotinformation> PaginationFindByCellphone(DepotinformationPagination obj) {
			String stmtId = "DepotinformationPagination.FindByCellphone";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByCellphone(Depotinformation obj){
			String stmtId = "Depotinformation.GetFindByCellphoneCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Depotinformation> FindByDescription(String description) {
			String stmtId = "Depotinformation.FindByDescription";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, description);
			return result;
        }
		public IList<Depotinformation> PaginationFindByDescription(DepotinformationPagination obj) {
			String stmtId = "DepotinformationPagination.FindByDescription";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDescription(Depotinformation obj){
			String stmtId = "Depotinformation.GetFindByDescriptionCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Depotinformation> FindByValidtime(String validtime) {
			String stmtId = "Depotinformation.FindByValidtime";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, validtime);
			return result;
        }
		public IList<Depotinformation> PaginationFindByValidtime(DepotinformationPagination obj) {
			String stmtId = "DepotinformationPagination.FindByValidtime";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByValidtime(Depotinformation obj){
			String stmtId = "Depotinformation.GetFindByValidtimeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Depotinformation> FindByContactperson(String contactperson) {
			String stmtId = "Depotinformation.FindByContactperson";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, contactperson);
			return result;
        }
		public IList<Depotinformation> PaginationFindByContactperson(DepotinformationPagination obj) {
			String stmtId = "DepotinformationPagination.FindByContactperson";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByContactperson(Depotinformation obj){
			String stmtId = "Depotinformation.GetFindByContactpersonCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Depotinformation> FindByUserid(Int64 userid) {
			String stmtId = "Depotinformation.FindByUserid";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, userid);
			return result;
        }
		public IList<Depotinformation> PaginationFindByUserid(DepotinformationPagination obj) {
			String stmtId = "DepotinformationPagination.FindByUserid";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByUserid(Depotinformation obj){
			String stmtId = "Depotinformation.GetFindByUseridCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Depotinformation> FindByUseablearea(Int32 useablearea) {
			String stmtId = "Depotinformation.FindByUseablearea";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, useablearea);
			return result;
        }
		public IList<Depotinformation> PaginationFindByUseablearea(DepotinformationPagination obj) {
			String stmtId = "DepotinformationPagination.FindByUseablearea";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByUseablearea(Depotinformation obj){
			String stmtId = "Depotinformation.GetFindByUseableareaCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Depotinformation> FindByPrice(String price) {
			String stmtId = "Depotinformation.FindByPrice";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, price);
			return result;
        }
		public IList<Depotinformation> PaginationFindByPrice(DepotinformationPagination obj) {
			String stmtId = "DepotinformationPagination.FindByPrice";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByPrice(Depotinformation obj){
			String stmtId = "Depotinformation.GetFindByPriceCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Depotinformation> FindByBizscopetype(Int64 bizscopetype) {
			String stmtId = "Depotinformation.FindByBizscopetype";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, bizscopetype);
			return result;
        }
		public IList<Depotinformation> PaginationFindByBizscopetype(DepotinformationPagination obj) {
			String stmtId = "DepotinformationPagination.FindByBizscopetype";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByBizscopetype(Depotinformation obj){
			String stmtId = "Depotinformation.GetFindByBizscopetypeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Depotinformation> FindByDepottype(Int64 depottype) {
			String stmtId = "Depotinformation.FindByDepottype";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, depottype);
			return result;
        }
		public IList<Depotinformation> PaginationFindByDepottype(DepotinformationPagination obj) {
			String stmtId = "DepotinformationPagination.FindByDepottype";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByDepottype(Depotinformation obj){
			String stmtId = "Depotinformation.GetFindByDepottypeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Depotinformation> FindByTitle(String title) {
			String stmtId = "Depotinformation.FindByTitle";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, title);
			return result;
        }
		public IList<Depotinformation> PaginationFindByTitle(DepotinformationPagination obj) {
			String stmtId = "DepotinformationPagination.FindByTitle";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByTitle(Depotinformation obj){
			String stmtId = "Depotinformation.GetFindByTitleCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Depotinformation> FindByAddress(String address) {
			String stmtId = "Depotinformation.FindByAddress";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, address);
			return result;
        }
		public IList<Depotinformation> PaginationFindByAddress(DepotinformationPagination obj) {
			String stmtId = "DepotinformationPagination.FindByAddress";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByAddress(Depotinformation obj){
			String stmtId = "Depotinformation.GetFindByAddressCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Depotinformation> FindByArea(Int32 area) {
			String stmtId = "Depotinformation.FindByArea";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, area);
			return result;
        }
		public IList<Depotinformation> PaginationFindByArea(DepotinformationPagination obj) {
			String stmtId = "DepotinformationPagination.FindByArea";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByArea(Depotinformation obj){
			String stmtId = "Depotinformation.GetFindByAreaCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Depotinformation> FindByCountycode(String countycode) {
			String stmtId = "Depotinformation.FindByCountycode";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, countycode);
			return result;
        }
		public IList<Depotinformation> PaginationFindByCountycode(DepotinformationPagination obj) {
			String stmtId = "DepotinformationPagination.FindByCountycode";
			IList<Depotinformation> result = this.sqlMapper.QueryForList<Depotinformation>(stmtId, obj);
			return result;
        }
		public int FindCountByCountycode(Depotinformation obj){
			String stmtId = "Depotinformation.GetFindByCountycodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Depotinformation obj) {
			String stmtId = "Depotinformation.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Depotinformation obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Depotinformation.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Depotinformation obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Depotinformation.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByCellphone(String cellphone) {
			String stmtId = "Depotinformation.DeleteByCellphone";
			int result = this.sqlMapper.Delete(stmtId, cellphone);
			return result;
        }
		public int DeleteByDescription(String description) {
			String stmtId = "Depotinformation.DeleteByDescription";
			int result = this.sqlMapper.Delete(stmtId, description);
			return result;
        }
		public int DeleteByValidtime(String validtime) {
			String stmtId = "Depotinformation.DeleteByValidtime";
			int result = this.sqlMapper.Delete(stmtId, validtime);
			return result;
        }
		public int DeleteByContactperson(String contactperson) {
			String stmtId = "Depotinformation.DeleteByContactperson";
			int result = this.sqlMapper.Delete(stmtId, contactperson);
			return result;
        }
		public int DeleteByUserid(Int64 userid) {
			String stmtId = "Depotinformation.DeleteByUserid";
			int result = this.sqlMapper.Delete(stmtId, userid);
			return result;
        }
		public int DeleteByUseablearea(Int32 useablearea) {
			String stmtId = "Depotinformation.DeleteByUseablearea";
			int result = this.sqlMapper.Delete(stmtId, useablearea);
			return result;
        }
		public int DeleteByPrice(String price) {
			String stmtId = "Depotinformation.DeleteByPrice";
			int result = this.sqlMapper.Delete(stmtId, price);
			return result;
        }
		public int DeleteByBizscopetype(Int64 bizscopetype) {
			String stmtId = "Depotinformation.DeleteByBizscopetype";
			int result = this.sqlMapper.Delete(stmtId, bizscopetype);
			return result;
        }
		public int DeleteByDepottype(Int64 depottype) {
			String stmtId = "Depotinformation.DeleteByDepottype";
			int result = this.sqlMapper.Delete(stmtId, depottype);
			return result;
        }
		public int DeleteByTitle(String title) {
			String stmtId = "Depotinformation.DeleteByTitle";
			int result = this.sqlMapper.Delete(stmtId, title);
			return result;
        }
		public int DeleteByAddress(String address) {
			String stmtId = "Depotinformation.DeleteByAddress";
			int result = this.sqlMapper.Delete(stmtId, address);
			return result;
        }
		public int DeleteByArea(Int32 area) {
			String stmtId = "Depotinformation.DeleteByArea";
			int result = this.sqlMapper.Delete(stmtId, area);
			return result;
        }
		public int DeleteByCountycode(String countycode) {
			String stmtId = "Depotinformation.DeleteByCountycode";
			int result = this.sqlMapper.Delete(stmtId, countycode);
			return result;
        }
		public void Reload(Depotinformation obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Depotinformation.Find";
			this.sqlMapper.QueryForObject<Depotinformation>(stmtId, obj, obj);
		}
    }
}
