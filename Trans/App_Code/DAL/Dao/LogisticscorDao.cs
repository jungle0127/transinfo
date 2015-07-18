using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class LogisticscorDao : ILogisticscorDao
    {
        private ISqlMapper sqlMapper = null;
        public LogisticscorDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Logisticscor.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Logisticscor Find(Int64 id) 
        {
			String stmtId = "Logisticscor.Find";
			Logisticscor result = this.sqlMapper.QueryForObject<Logisticscor>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Logisticscor.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Logisticscor> FindAll() {
			String stmtId = "Logisticscor.FindAll";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, null);
			return result;
        }
		public IList<Logisticscor> DescendOrderFindAll() {
			String stmtId = "Logisticscor.DescendOrderFindAll";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, null);
			return result;
        }
		public IList<Logisticscor> PaginationFindAll(LogisticscorPagination obj) {
			String stmtId = "Logisticscor.FindAllPagination";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public IList<Logisticscor> DescendOrderPaginationFindAll(LogisticscorPagination obj) {
			String stmtId = "Logisticscor.DescendOrderFindAllPagination";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public IList<Logisticscor> QuickFindAll() {
			String stmtId = "Logisticscor.QuickFindAll";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, null);
			return result;
        }
		public IList<Logisticscor> FindByAddress(String address) {
			String stmtId = "Logisticscor.FindByAddress";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, address);
			return result;
        }
		public IList<Logisticscor> DescendOrderFindByAddress(String address) {
			String stmtId = "Logisticscor.DescendOrderFindByAddress";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, address);
			return result;
        }
		public IList<Logisticscor> PaginationFindByAddress(LogisticscorPagination obj) {
			String stmtId = "LogisticscorPagination.FindByAddress";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public IList<Logisticscor> DescendOrderPaginationFindByAddress(LogisticscorPagination obj) {
			String stmtId = "LogisticscorPagination.DescendOrderFindByAddress";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public int FindCountByAddress(Logisticscor obj){
			String stmtId = "Logisticscor.GetFindByAddressCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Logisticscor> FindByActive(Byte active) {
			String stmtId = "Logisticscor.FindByActive";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, active);
			return result;
        }
		public IList<Logisticscor> DescendOrderFindByActive(Byte active) {
			String stmtId = "Logisticscor.DescendOrderFindByActive";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, active);
			return result;
        }
		public IList<Logisticscor> PaginationFindByActive(LogisticscorPagination obj) {
			String stmtId = "LogisticscorPagination.FindByActive";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public IList<Logisticscor> DescendOrderPaginationFindByActive(LogisticscorPagination obj) {
			String stmtId = "LogisticscorPagination.DescendOrderFindByActive";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public int FindCountByActive(Logisticscor obj){
			String stmtId = "Logisticscor.GetFindByActiveCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Logisticscor> FindByLicenseurl(String licenseurl) {
			String stmtId = "Logisticscor.FindByLicenseurl";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, licenseurl);
			return result;
        }
		public IList<Logisticscor> DescendOrderFindByLicenseurl(String licenseurl) {
			String stmtId = "Logisticscor.DescendOrderFindByLicenseurl";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, licenseurl);
			return result;
        }
		public IList<Logisticscor> PaginationFindByLicenseurl(LogisticscorPagination obj) {
			String stmtId = "LogisticscorPagination.FindByLicenseurl";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public IList<Logisticscor> DescendOrderPaginationFindByLicenseurl(LogisticscorPagination obj) {
			String stmtId = "LogisticscorPagination.DescendOrderFindByLicenseurl";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public int FindCountByLicenseurl(Logisticscor obj){
			String stmtId = "Logisticscor.GetFindByLicenseurlCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Logisticscor> FindByCorporationname(String corporationname) {
			String stmtId = "Logisticscor.FindByCorporationname";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, corporationname);
			return result;
        }
		public IList<Logisticscor> DescendOrderFindByCorporationname(String corporationname) {
			String stmtId = "Logisticscor.DescendOrderFindByCorporationname";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, corporationname);
			return result;
        }
		public IList<Logisticscor> PaginationFindByCorporationname(LogisticscorPagination obj) {
			String stmtId = "LogisticscorPagination.FindByCorporationname";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public IList<Logisticscor> DescendOrderPaginationFindByCorporationname(LogisticscorPagination obj) {
			String stmtId = "LogisticscorPagination.DescendOrderFindByCorporationname";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public int FindCountByCorporationname(Logisticscor obj){
			String stmtId = "Logisticscor.GetFindByCorporationnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Logisticscor> FindByContactperson(String contactperson) {
			String stmtId = "Logisticscor.FindByContactperson";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, contactperson);
			return result;
        }
		public IList<Logisticscor> DescendOrderFindByContactperson(String contactperson) {
			String stmtId = "Logisticscor.DescendOrderFindByContactperson";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, contactperson);
			return result;
        }
		public IList<Logisticscor> PaginationFindByContactperson(LogisticscorPagination obj) {
			String stmtId = "LogisticscorPagination.FindByContactperson";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public IList<Logisticscor> DescendOrderPaginationFindByContactperson(LogisticscorPagination obj) {
			String stmtId = "LogisticscorPagination.DescendOrderFindByContactperson";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public int FindCountByContactperson(Logisticscor obj){
			String stmtId = "Logisticscor.GetFindByContactpersonCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Logisticscor> FindByUserid(Int64 userid) {
			String stmtId = "Logisticscor.FindByUserid";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, userid);
			return result;
        }
		public IList<Logisticscor> DescendOrderFindByUserid(Int64 userid) {
			String stmtId = "Logisticscor.DescendOrderFindByUserid";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, userid);
			return result;
        }
		public IList<Logisticscor> PaginationFindByUserid(LogisticscorPagination obj) {
			String stmtId = "LogisticscorPagination.FindByUserid";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public IList<Logisticscor> DescendOrderPaginationFindByUserid(LogisticscorPagination obj) {
			String stmtId = "LogisticscorPagination.DescendOrderFindByUserid";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public int FindCountByUserid(Logisticscor obj){
			String stmtId = "Logisticscor.GetFindByUseridCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Logisticscor> FindByTelephone(String telephone) {
			String stmtId = "Logisticscor.FindByTelephone";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, telephone);
			return result;
        }
		public IList<Logisticscor> DescendOrderFindByTelephone(String telephone) {
			String stmtId = "Logisticscor.DescendOrderFindByTelephone";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, telephone);
			return result;
        }
		public IList<Logisticscor> PaginationFindByTelephone(LogisticscorPagination obj) {
			String stmtId = "LogisticscorPagination.FindByTelephone";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public IList<Logisticscor> DescendOrderPaginationFindByTelephone(LogisticscorPagination obj) {
			String stmtId = "LogisticscorPagination.DescendOrderFindByTelephone";
			IList<Logisticscor> result = this.sqlMapper.QueryForList<Logisticscor>(stmtId, obj);
			return result;
        }
		public int FindCountByTelephone(Logisticscor obj){
			String stmtId = "Logisticscor.GetFindByTelephoneCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Logisticscor obj) {
			String stmtId = "Logisticscor.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Logisticscor obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Logisticscor.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Logisticscor obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Logisticscor.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByAddress(String address) {
			String stmtId = "Logisticscor.DeleteByAddress";
			int result = this.sqlMapper.Delete(stmtId, address);
			return result;
        }
		public int DeleteByActive(Byte active) {
			String stmtId = "Logisticscor.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public int DeleteByLicenseurl(String licenseurl) {
			String stmtId = "Logisticscor.DeleteByLicenseurl";
			int result = this.sqlMapper.Delete(stmtId, licenseurl);
			return result;
        }
		public int DeleteByCorporationname(String corporationname) {
			String stmtId = "Logisticscor.DeleteByCorporationname";
			int result = this.sqlMapper.Delete(stmtId, corporationname);
			return result;
        }
		public int DeleteByContactperson(String contactperson) {
			String stmtId = "Logisticscor.DeleteByContactperson";
			int result = this.sqlMapper.Delete(stmtId, contactperson);
			return result;
        }
		public int DeleteByUserid(Int64 userid) {
			String stmtId = "Logisticscor.DeleteByUserid";
			int result = this.sqlMapper.Delete(stmtId, userid);
			return result;
        }
		public int DeleteByTelephone(String telephone) {
			String stmtId = "Logisticscor.DeleteByTelephone";
			int result = this.sqlMapper.Delete(stmtId, telephone);
			return result;
        }
		public void Reload(Logisticscor obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Logisticscor.Find";
			this.sqlMapper.QueryForObject<Logisticscor>(stmtId, obj, obj);
		}
    }
}
