using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class PlaceinfoDao : IPlaceinfoDao
    {
        private ISqlMapper sqlMapper = null;
        public PlaceinfoDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Placeinfo.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Placeinfo Find(Int64 id) 
        {
			String stmtId = "Placeinfo.Find";
			Placeinfo result = this.sqlMapper.QueryForObject<Placeinfo>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Placeinfo.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Placeinfo> FindAll() {
			String stmtId = "Placeinfo.FindAll";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, null);
			return result;
        }
		public IList<Placeinfo> DescendOrderFindAll() {
			String stmtId = "Placeinfo.DescendOrderFindAll";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, null);
			return result;
        }
		public IList<Placeinfo> PaginationFindAll(PlaceinfoPagination obj) {
			String stmtId = "Placeinfo.FindAllPagination";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public IList<Placeinfo> DescendOrderPaginationFindAll(PlaceinfoPagination obj) {
			String stmtId = "Placeinfo.DescendOrderFindAllPagination";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public IList<Placeinfo> QuickFindAll() {
			String stmtId = "Placeinfo.QuickFindAll";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, null);
			return result;
        }
		public IList<Placeinfo> FindByAddress(String address) {
			String stmtId = "Placeinfo.FindByAddress";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, address);
			return result;
        }
		public IList<Placeinfo> DescendOrderFindByAddress(String address) {
			String stmtId = "Placeinfo.DescendOrderFindByAddress";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, address);
			return result;
        }
		public IList<Placeinfo> PaginationFindByAddress(PlaceinfoPagination obj) {
			String stmtId = "PlaceinfoPagination.FindByAddress";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public IList<Placeinfo> DescendOrderPaginationFindByAddress(PlaceinfoPagination obj) {
			String stmtId = "PlaceinfoPagination.DescendOrderFindByAddress";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByAddress(Placeinfo obj){
			String stmtId = "Placeinfo.GetFindByAddressCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Placeinfo> FindByContactpersonname(String contactpersonname) {
			String stmtId = "Placeinfo.FindByContactpersonname";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, contactpersonname);
			return result;
        }
		public IList<Placeinfo> DescendOrderFindByContactpersonname(String contactpersonname) {
			String stmtId = "Placeinfo.DescendOrderFindByContactpersonname";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, contactpersonname);
			return result;
        }
		public IList<Placeinfo> PaginationFindByContactpersonname(PlaceinfoPagination obj) {
			String stmtId = "PlaceinfoPagination.FindByContactpersonname";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public IList<Placeinfo> DescendOrderPaginationFindByContactpersonname(PlaceinfoPagination obj) {
			String stmtId = "PlaceinfoPagination.DescendOrderFindByContactpersonname";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByContactpersonname(Placeinfo obj){
			String stmtId = "Placeinfo.GetFindByContactpersonnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Placeinfo> FindByContactphone(String contactphone) {
			String stmtId = "Placeinfo.FindByContactphone";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, contactphone);
			return result;
        }
		public IList<Placeinfo> DescendOrderFindByContactphone(String contactphone) {
			String stmtId = "Placeinfo.DescendOrderFindByContactphone";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, contactphone);
			return result;
        }
		public IList<Placeinfo> PaginationFindByContactphone(PlaceinfoPagination obj) {
			String stmtId = "PlaceinfoPagination.FindByContactphone";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public IList<Placeinfo> DescendOrderPaginationFindByContactphone(PlaceinfoPagination obj) {
			String stmtId = "PlaceinfoPagination.DescendOrderFindByContactphone";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByContactphone(Placeinfo obj){
			String stmtId = "Placeinfo.GetFindByContactphoneCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Placeinfo> FindByContactcellphone(String contactcellphone) {
			String stmtId = "Placeinfo.FindByContactcellphone";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, contactcellphone);
			return result;
        }
		public IList<Placeinfo> DescendOrderFindByContactcellphone(String contactcellphone) {
			String stmtId = "Placeinfo.DescendOrderFindByContactcellphone";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, contactcellphone);
			return result;
        }
		public IList<Placeinfo> PaginationFindByContactcellphone(PlaceinfoPagination obj) {
			String stmtId = "PlaceinfoPagination.FindByContactcellphone";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public IList<Placeinfo> DescendOrderPaginationFindByContactcellphone(PlaceinfoPagination obj) {
			String stmtId = "PlaceinfoPagination.DescendOrderFindByContactcellphone";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByContactcellphone(Placeinfo obj){
			String stmtId = "Placeinfo.GetFindByContactcellphoneCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Placeinfo> FindByCountycode(String countycode) {
			String stmtId = "Placeinfo.FindByCountycode";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, countycode);
			return result;
        }
		public IList<Placeinfo> DescendOrderFindByCountycode(String countycode) {
			String stmtId = "Placeinfo.DescendOrderFindByCountycode";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, countycode);
			return result;
        }
		public IList<Placeinfo> PaginationFindByCountycode(PlaceinfoPagination obj) {
			String stmtId = "PlaceinfoPagination.FindByCountycode";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public IList<Placeinfo> DescendOrderPaginationFindByCountycode(PlaceinfoPagination obj) {
			String stmtId = "PlaceinfoPagination.DescendOrderFindByCountycode";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByCountycode(Placeinfo obj){
			String stmtId = "Placeinfo.GetFindByCountycodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Placeinfo obj) {
			String stmtId = "Placeinfo.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Placeinfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Placeinfo.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Placeinfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Placeinfo.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByAddress(String address) {
			String stmtId = "Placeinfo.DeleteByAddress";
			int result = this.sqlMapper.Delete(stmtId, address);
			return result;
        }
		public int DeleteByContactpersonname(String contactpersonname) {
			String stmtId = "Placeinfo.DeleteByContactpersonname";
			int result = this.sqlMapper.Delete(stmtId, contactpersonname);
			return result;
        }
		public int DeleteByContactphone(String contactphone) {
			String stmtId = "Placeinfo.DeleteByContactphone";
			int result = this.sqlMapper.Delete(stmtId, contactphone);
			return result;
        }
		public int DeleteByContactcellphone(String contactcellphone) {
			String stmtId = "Placeinfo.DeleteByContactcellphone";
			int result = this.sqlMapper.Delete(stmtId, contactcellphone);
			return result;
        }
		public int DeleteByCountycode(String countycode) {
			String stmtId = "Placeinfo.DeleteByCountycode";
			int result = this.sqlMapper.Delete(stmtId, countycode);
			return result;
        }
		public void Reload(Placeinfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Placeinfo.Find";
			this.sqlMapper.QueryForObject<Placeinfo>(stmtId, obj, obj);
		}
    }
}
