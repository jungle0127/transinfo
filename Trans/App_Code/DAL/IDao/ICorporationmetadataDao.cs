using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ICorporationmetadataDao
    {
		int GetCount();

		Corporationmetadata Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Corporationmetadata> FindAll();

		IList<Corporationmetadata> DescendOrderFindAll();

		IList<Corporationmetadata> PaginationFindAll(CorporationmetadataPagination obj);

		IList<Corporationmetadata> DescendOrderPaginationFindAll(CorporationmetadataPagination obj);

		IList<Corporationmetadata> QuickFindAll();

		IList<Corporationmetadata> FindByBizcontactperson(String bizcontactperson);

		IList<Corporationmetadata> DescendOrderFindByBizcontactperson(String bizcontactperson);

		IList<Corporationmetadata> PaginationFindByBizcontactperson(CorporationmetadataPagination obj);

		IList<Corporationmetadata> DescendOrderPaginationFindByBizcontactperson(CorporationmetadataPagination obj);

		int FindCountByBizcontactperson(Corporationmetadata obj);

		IList<Corporationmetadata> FindByPostcode(String postcode);

		IList<Corporationmetadata> DescendOrderFindByPostcode(String postcode);

		IList<Corporationmetadata> PaginationFindByPostcode(CorporationmetadataPagination obj);

		IList<Corporationmetadata> DescendOrderPaginationFindByPostcode(CorporationmetadataPagination obj);

		int FindCountByPostcode(Corporationmetadata obj);

		IList<Corporationmetadata> FindByCorporationname(String corporationname);

		IList<Corporationmetadata> DescendOrderFindByCorporationname(String corporationname);

		IList<Corporationmetadata> PaginationFindByCorporationname(CorporationmetadataPagination obj);

		IList<Corporationmetadata> DescendOrderPaginationFindByCorporationname(CorporationmetadataPagination obj);

		int FindCountByCorporationname(Corporationmetadata obj);

		IList<Corporationmetadata> FindByUserid(Int64 userid);

		IList<Corporationmetadata> DescendOrderFindByUserid(Int64 userid);

		IList<Corporationmetadata> PaginationFindByUserid(CorporationmetadataPagination obj);

		IList<Corporationmetadata> DescendOrderPaginationFindByUserid(CorporationmetadataPagination obj);

		int FindCountByUserid(Corporationmetadata obj);

		IList<Corporationmetadata> FindByLogourl(String logourl);

		IList<Corporationmetadata> DescendOrderFindByLogourl(String logourl);

		IList<Corporationmetadata> PaginationFindByLogourl(CorporationmetadataPagination obj);

		IList<Corporationmetadata> DescendOrderPaginationFindByLogourl(CorporationmetadataPagination obj);

		int FindCountByLogourl(Corporationmetadata obj);

		IList<Corporationmetadata> FindByActive(Byte active);

		IList<Corporationmetadata> DescendOrderFindByActive(Byte active);

		IList<Corporationmetadata> PaginationFindByActive(CorporationmetadataPagination obj);

		IList<Corporationmetadata> DescendOrderPaginationFindByActive(CorporationmetadataPagination obj);

		int FindCountByActive(Corporationmetadata obj);

		IList<Corporationmetadata> FindByCustomerQQ(String customerQQ);

		IList<Corporationmetadata> DescendOrderFindByCustomerQQ(String customerQQ);

		IList<Corporationmetadata> PaginationFindByCustomerQQ(CorporationmetadataPagination obj);

		IList<Corporationmetadata> DescendOrderPaginationFindByCustomerQQ(CorporationmetadataPagination obj);

		int FindCountByCustomerQQ(Corporationmetadata obj);

		IList<Corporationmetadata> FindByBiztelephone(String biztelephone);

		IList<Corporationmetadata> DescendOrderFindByBiztelephone(String biztelephone);

		IList<Corporationmetadata> PaginationFindByBiztelephone(CorporationmetadataPagination obj);

		IList<Corporationmetadata> DescendOrderPaginationFindByBiztelephone(CorporationmetadataPagination obj);

		int FindCountByBiztelephone(Corporationmetadata obj);

		IList<Corporationmetadata> FindByUrl(String url);

		IList<Corporationmetadata> DescendOrderFindByUrl(String url);

		IList<Corporationmetadata> PaginationFindByUrl(CorporationmetadataPagination obj);

		IList<Corporationmetadata> DescendOrderPaginationFindByUrl(CorporationmetadataPagination obj);

		int FindCountByUrl(Corporationmetadata obj);

		IList<Corporationmetadata> FindByAddress(String address);

		IList<Corporationmetadata> DescendOrderFindByAddress(String address);

		IList<Corporationmetadata> PaginationFindByAddress(CorporationmetadataPagination obj);

		IList<Corporationmetadata> DescendOrderPaginationFindByAddress(CorporationmetadataPagination obj);

		int FindCountByAddress(Corporationmetadata obj);

		IList<Corporationmetadata> FindByIntroduction(String introduction);

		IList<Corporationmetadata> DescendOrderFindByIntroduction(String introduction);

		IList<Corporationmetadata> PaginationFindByIntroduction(CorporationmetadataPagination obj);

		IList<Corporationmetadata> DescendOrderPaginationFindByIntroduction(CorporationmetadataPagination obj);

		int FindCountByIntroduction(Corporationmetadata obj);

		IList<Corporationmetadata> FindByCustomerEmail(String customerEmail);

		IList<Corporationmetadata> DescendOrderFindByCustomerEmail(String customerEmail);

		IList<Corporationmetadata> PaginationFindByCustomerEmail(CorporationmetadataPagination obj);

		IList<Corporationmetadata> DescendOrderPaginationFindByCustomerEmail(CorporationmetadataPagination obj);

		int FindCountByCustomerEmail(Corporationmetadata obj);

		void Insert(Corporationmetadata obj);

		void Update(Corporationmetadata obj);

		void Delete(Corporationmetadata obj);

		int DeleteByBizcontactperson(String bizcontactperson);

		int DeleteByPostcode(String postcode);

		int DeleteByCorporationname(String corporationname);

		int DeleteByUserid(Int64 userid);

		int DeleteByLogourl(String logourl);

		int DeleteByActive(Byte active);

		int DeleteByCustomerQQ(String customerQQ);

		int DeleteByBiztelephone(String biztelephone);

		int DeleteByUrl(String url);

		int DeleteByAddress(String address);

		int DeleteByIntroduction(String introduction);

		int DeleteByCustomerEmail(String customerEmail);

		void Reload(Corporationmetadata obj);
	}
}
