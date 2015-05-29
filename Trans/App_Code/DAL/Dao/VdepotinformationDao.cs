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
		public Vdepotinformation Find(Int64 id) 
        {
			String stmtId = "Vdepotinformation.Find";
			Vdepotinformation result = this.sqlMapper.QueryForObject<Vdepotinformation>(stmtId, id);
			return result;
        }
		public IList<Vdepotinformation> FindAll() {
			String stmtId = "Vdepotinformation.FindAll";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, null);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindAll(VdepotinformationPagination obj) {
			String stmtId = "Vdepotinformation.FindAllPagination";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> QuickFindAll() {
			String stmtId = "Vdepotinformation.QuickFindAll";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, null);
			return result;
        }
		public IList<Vdepotinformation> FindByCellphone(String cellphone) {
			String stmtId = "Vdepotinformation.FindByCellphone";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, cellphone);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByCellphone(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByCellphone";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> FindByDescription(String description) {
			String stmtId = "Vdepotinformation.FindByDescription";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, description);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByDescription(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByDescription";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> FindByValidtime(String validtime) {
			String stmtId = "Vdepotinformation.FindByValidtime";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, validtime);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByValidtime(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByValidtime";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> FindByContactperson(String contactperson) {
			String stmtId = "Vdepotinformation.FindByContactperson";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, contactperson);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByContactperson(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByContactperson";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> FindByUseablearea(Int32 useablearea) {
			String stmtId = "Vdepotinformation.FindByUseablearea";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, useablearea);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByUseablearea(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByUseablearea";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> FindByScopename(String scopename) {
			String stmtId = "Vdepotinformation.FindByScopename";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, scopename);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByScopename(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByScopename";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> FindByPrice(String price) {
			String stmtId = "Vdepotinformation.FindByPrice";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, price);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByPrice(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByPrice";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> FindByTitle(String title) {
			String stmtId = "Vdepotinformation.FindByTitle";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, title);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByTitle(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByTitle";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> FindByRegionname(String regionname) {
			String stmtId = "Vdepotinformation.FindByRegionname";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, regionname);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByRegionname(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByRegionname";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> FindById(Int64 id) {
			String stmtId = "Vdepotinformation.FindById";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, id);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindById(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindById";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> FindByDepottypename(String depottypename) {
			String stmtId = "Vdepotinformation.FindByDepottypename";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, depottypename);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByDepottypename(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByDepottypename";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> FindByAddress(String address) {
			String stmtId = "Vdepotinformation.FindByAddress";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, address);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByAddress(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByAddress";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> FindByArea(Int32 area) {
			String stmtId = "Vdepotinformation.FindByArea";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, area);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByArea(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByArea";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public IList<Vdepotinformation> FindByUsername(String username) {
			String stmtId = "Vdepotinformation.FindByUsername";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, username);
			return result;
        }
		public IList<Vdepotinformation> PaginationFindByUsername(VdepotinformationPagination obj) {
			String stmtId = "VdepotinformationPagination.FindByUsername";
			IList<Vdepotinformation> result = this.sqlMapper.QueryForList<Vdepotinformation>(stmtId, obj);
			return result;
        }
		public void Reload(Vdepotinformation obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Vdepotinformation.Find";
			this.sqlMapper.QueryForObject<Vdepotinformation>(stmtId, obj, obj);
		}
    }
}
