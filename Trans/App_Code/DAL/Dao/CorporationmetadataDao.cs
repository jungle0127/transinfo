using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class CorporationmetadataDao : ICorporationmetadataDao
    {
        private ISqlMapper sqlMapper = null;
        public CorporationmetadataDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Corporationmetadata.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Corporationmetadata Find(Int64 id) 
        {
			String stmtId = "Corporationmetadata.Find";
			Corporationmetadata result = this.sqlMapper.QueryForObject<Corporationmetadata>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Corporationmetadata.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Corporationmetadata> FindAll() {
			String stmtId = "Corporationmetadata.FindAll";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, null);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderFindAll() {
			String stmtId = "Corporationmetadata.DescendOrderFindAll";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, null);
			return result;
        }
		public IList<Corporationmetadata> PaginationFindAll(CorporationmetadataPagination obj) {
			String stmtId = "Corporationmetadata.FindAllPagination";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderPaginationFindAll(CorporationmetadataPagination obj) {
			String stmtId = "Corporationmetadata.DescendOrderFindAllPagination";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public IList<Corporationmetadata> QuickFindAll() {
			String stmtId = "Corporationmetadata.QuickFindAll";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, null);
			return result;
        }
		public IList<Corporationmetadata> FindByBizcontactperson(String bizcontactperson) {
			String stmtId = "Corporationmetadata.FindByBizcontactperson";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, bizcontactperson);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderFindByBizcontactperson(String bizcontactperson) {
			String stmtId = "Corporationmetadata.DescendOrderFindByBizcontactperson";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, bizcontactperson);
			return result;
        }
		public IList<Corporationmetadata> PaginationFindByBizcontactperson(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.FindByBizcontactperson";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderPaginationFindByBizcontactperson(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.DescendOrderFindByBizcontactperson";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByBizcontactperson(Corporationmetadata obj){
			String stmtId = "Corporationmetadata.GetFindByBizcontactpersonCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Corporationmetadata> FindByPostcode(String postcode) {
			String stmtId = "Corporationmetadata.FindByPostcode";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, postcode);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderFindByPostcode(String postcode) {
			String stmtId = "Corporationmetadata.DescendOrderFindByPostcode";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, postcode);
			return result;
        }
		public IList<Corporationmetadata> PaginationFindByPostcode(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.FindByPostcode";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderPaginationFindByPostcode(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.DescendOrderFindByPostcode";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByPostcode(Corporationmetadata obj){
			String stmtId = "Corporationmetadata.GetFindByPostcodeCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Corporationmetadata> FindByCorporationname(String corporationname) {
			String stmtId = "Corporationmetadata.FindByCorporationname";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, corporationname);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderFindByCorporationname(String corporationname) {
			String stmtId = "Corporationmetadata.DescendOrderFindByCorporationname";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, corporationname);
			return result;
        }
		public IList<Corporationmetadata> PaginationFindByCorporationname(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.FindByCorporationname";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderPaginationFindByCorporationname(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.DescendOrderFindByCorporationname";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByCorporationname(Corporationmetadata obj){
			String stmtId = "Corporationmetadata.GetFindByCorporationnameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Corporationmetadata> FindByUserid(Int64 userid) {
			String stmtId = "Corporationmetadata.FindByUserid";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, userid);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderFindByUserid(Int64 userid) {
			String stmtId = "Corporationmetadata.DescendOrderFindByUserid";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, userid);
			return result;
        }
		public IList<Corporationmetadata> PaginationFindByUserid(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.FindByUserid";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderPaginationFindByUserid(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.DescendOrderFindByUserid";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByUserid(Corporationmetadata obj){
			String stmtId = "Corporationmetadata.GetFindByUseridCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Corporationmetadata> FindByLogourl(String logourl) {
			String stmtId = "Corporationmetadata.FindByLogourl";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, logourl);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderFindByLogourl(String logourl) {
			String stmtId = "Corporationmetadata.DescendOrderFindByLogourl";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, logourl);
			return result;
        }
		public IList<Corporationmetadata> PaginationFindByLogourl(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.FindByLogourl";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderPaginationFindByLogourl(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.DescendOrderFindByLogourl";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByLogourl(Corporationmetadata obj){
			String stmtId = "Corporationmetadata.GetFindByLogourlCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Corporationmetadata> FindByActive(Byte active) {
			String stmtId = "Corporationmetadata.FindByActive";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, active);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderFindByActive(Byte active) {
			String stmtId = "Corporationmetadata.DescendOrderFindByActive";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, active);
			return result;
        }
		public IList<Corporationmetadata> PaginationFindByActive(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.FindByActive";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderPaginationFindByActive(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.DescendOrderFindByActive";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByActive(Corporationmetadata obj){
			String stmtId = "Corporationmetadata.GetFindByActiveCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Corporationmetadata> FindByCustomerQQ(String customerQQ) {
			String stmtId = "Corporationmetadata.FindByCustomerQQ";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, customerQQ);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderFindByCustomerQQ(String customerQQ) {
			String stmtId = "Corporationmetadata.DescendOrderFindByCustomerQQ";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, customerQQ);
			return result;
        }
		public IList<Corporationmetadata> PaginationFindByCustomerQQ(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.FindByCustomerQQ";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderPaginationFindByCustomerQQ(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.DescendOrderFindByCustomerQQ";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByCustomerQQ(Corporationmetadata obj){
			String stmtId = "Corporationmetadata.GetFindByCustomerQQCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Corporationmetadata> FindByBiztelephone(String biztelephone) {
			String stmtId = "Corporationmetadata.FindByBiztelephone";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, biztelephone);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderFindByBiztelephone(String biztelephone) {
			String stmtId = "Corporationmetadata.DescendOrderFindByBiztelephone";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, biztelephone);
			return result;
        }
		public IList<Corporationmetadata> PaginationFindByBiztelephone(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.FindByBiztelephone";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderPaginationFindByBiztelephone(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.DescendOrderFindByBiztelephone";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByBiztelephone(Corporationmetadata obj){
			String stmtId = "Corporationmetadata.GetFindByBiztelephoneCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Corporationmetadata> FindByUrl(String url) {
			String stmtId = "Corporationmetadata.FindByUrl";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, url);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderFindByUrl(String url) {
			String stmtId = "Corporationmetadata.DescendOrderFindByUrl";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, url);
			return result;
        }
		public IList<Corporationmetadata> PaginationFindByUrl(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.FindByUrl";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderPaginationFindByUrl(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.DescendOrderFindByUrl";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByUrl(Corporationmetadata obj){
			String stmtId = "Corporationmetadata.GetFindByUrlCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Corporationmetadata> FindByAddress(String address) {
			String stmtId = "Corporationmetadata.FindByAddress";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, address);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderFindByAddress(String address) {
			String stmtId = "Corporationmetadata.DescendOrderFindByAddress";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, address);
			return result;
        }
		public IList<Corporationmetadata> PaginationFindByAddress(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.FindByAddress";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderPaginationFindByAddress(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.DescendOrderFindByAddress";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByAddress(Corporationmetadata obj){
			String stmtId = "Corporationmetadata.GetFindByAddressCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Corporationmetadata> FindByIntroduction(String introduction) {
			String stmtId = "Corporationmetadata.FindByIntroduction";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, introduction);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderFindByIntroduction(String introduction) {
			String stmtId = "Corporationmetadata.DescendOrderFindByIntroduction";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, introduction);
			return result;
        }
		public IList<Corporationmetadata> PaginationFindByIntroduction(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.FindByIntroduction";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderPaginationFindByIntroduction(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.DescendOrderFindByIntroduction";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByIntroduction(Corporationmetadata obj){
			String stmtId = "Corporationmetadata.GetFindByIntroductionCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Corporationmetadata> FindByCustomerEmail(String customerEmail) {
			String stmtId = "Corporationmetadata.FindByCustomerEmail";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, customerEmail);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderFindByCustomerEmail(String customerEmail) {
			String stmtId = "Corporationmetadata.DescendOrderFindByCustomerEmail";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, customerEmail);
			return result;
        }
		public IList<Corporationmetadata> PaginationFindByCustomerEmail(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.FindByCustomerEmail";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public IList<Corporationmetadata> DescendOrderPaginationFindByCustomerEmail(CorporationmetadataPagination obj) {
			String stmtId = "CorporationmetadataPagination.DescendOrderFindByCustomerEmail";
			IList<Corporationmetadata> result = this.sqlMapper.QueryForList<Corporationmetadata>(stmtId, obj);
			return result;
        }
		public int FindCountByCustomerEmail(Corporationmetadata obj){
			String stmtId = "Corporationmetadata.GetFindByCustomerEmailCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Corporationmetadata obj) {
			String stmtId = "Corporationmetadata.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Corporationmetadata obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Corporationmetadata.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Corporationmetadata obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Corporationmetadata.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByBizcontactperson(String bizcontactperson) {
			String stmtId = "Corporationmetadata.DeleteByBizcontactperson";
			int result = this.sqlMapper.Delete(stmtId, bizcontactperson);
			return result;
        }
		public int DeleteByPostcode(String postcode) {
			String stmtId = "Corporationmetadata.DeleteByPostcode";
			int result = this.sqlMapper.Delete(stmtId, postcode);
			return result;
        }
		public int DeleteByCorporationname(String corporationname) {
			String stmtId = "Corporationmetadata.DeleteByCorporationname";
			int result = this.sqlMapper.Delete(stmtId, corporationname);
			return result;
        }
		public int DeleteByUserid(Int64 userid) {
			String stmtId = "Corporationmetadata.DeleteByUserid";
			int result = this.sqlMapper.Delete(stmtId, userid);
			return result;
        }
		public int DeleteByLogourl(String logourl) {
			String stmtId = "Corporationmetadata.DeleteByLogourl";
			int result = this.sqlMapper.Delete(stmtId, logourl);
			return result;
        }
		public int DeleteByActive(Byte active) {
			String stmtId = "Corporationmetadata.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public int DeleteByCustomerQQ(String customerQQ) {
			String stmtId = "Corporationmetadata.DeleteByCustomerQQ";
			int result = this.sqlMapper.Delete(stmtId, customerQQ);
			return result;
        }
		public int DeleteByBiztelephone(String biztelephone) {
			String stmtId = "Corporationmetadata.DeleteByBiztelephone";
			int result = this.sqlMapper.Delete(stmtId, biztelephone);
			return result;
        }
		public int DeleteByUrl(String url) {
			String stmtId = "Corporationmetadata.DeleteByUrl";
			int result = this.sqlMapper.Delete(stmtId, url);
			return result;
        }
		public int DeleteByAddress(String address) {
			String stmtId = "Corporationmetadata.DeleteByAddress";
			int result = this.sqlMapper.Delete(stmtId, address);
			return result;
        }
		public int DeleteByIntroduction(String introduction) {
			String stmtId = "Corporationmetadata.DeleteByIntroduction";
			int result = this.sqlMapper.Delete(stmtId, introduction);
			return result;
        }
		public int DeleteByCustomerEmail(String customerEmail) {
			String stmtId = "Corporationmetadata.DeleteByCustomerEmail";
			int result = this.sqlMapper.Delete(stmtId, customerEmail);
			return result;
        }
		public void Reload(Corporationmetadata obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Corporationmetadata.Find";
			this.sqlMapper.QueryForObject<Corporationmetadata>(stmtId, obj, obj);
		}
    }
}
