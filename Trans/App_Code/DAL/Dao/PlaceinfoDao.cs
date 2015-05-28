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
		public IList<Placeinfo> FindAll() {
			String stmtId = "Placeinfo.FindAll";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, null);
			return result;
        }
		public IList<Placeinfo> PaginationFindAll(PlaceinfoPagination obj) {
			String stmtId = "Placeinfo.FindAllPagination";
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
		public IList<Placeinfo> PaginationFindByAddress(PlaceinfoPagination obj) {
			String stmtId = "PlaceinfoPagination.FindByAddress";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public IList<Placeinfo> FindByContactpersonname(String contactpersonname) {
			String stmtId = "Placeinfo.FindByContactpersonname";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, contactpersonname);
			return result;
        }
		public IList<Placeinfo> PaginationFindByContactpersonname(PlaceinfoPagination obj) {
			String stmtId = "PlaceinfoPagination.FindByContactpersonname";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public IList<Placeinfo> FindByContactphone(String contactphone) {
			String stmtId = "Placeinfo.FindByContactphone";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, contactphone);
			return result;
        }
		public IList<Placeinfo> PaginationFindByContactphone(PlaceinfoPagination obj) {
			String stmtId = "PlaceinfoPagination.FindByContactphone";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public IList<Placeinfo> FindByContactcellphone(String contactcellphone) {
			String stmtId = "Placeinfo.FindByContactcellphone";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, contactcellphone);
			return result;
        }
		public IList<Placeinfo> PaginationFindByContactcellphone(PlaceinfoPagination obj) {
			String stmtId = "PlaceinfoPagination.FindByContactcellphone";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
			return result;
        }
		public IList<Placeinfo> FindByCountycode(String countycode) {
			String stmtId = "Placeinfo.FindByCountycode";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, countycode);
			return result;
        }
		public IList<Placeinfo> PaginationFindByCountycode(PlaceinfoPagination obj) {
			String stmtId = "PlaceinfoPagination.FindByCountycode";
			IList<Placeinfo> result = this.sqlMapper.QueryForList<Placeinfo>(stmtId, obj);
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
