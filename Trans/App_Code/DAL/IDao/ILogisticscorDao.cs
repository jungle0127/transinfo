using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ILogisticscorDao
    {
		int GetCount();

		Logisticscor Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Logisticscor> FindAll();

		IList<Logisticscor> DescendOrderFindAll();

		IList<Logisticscor> PaginationFindAll(LogisticscorPagination obj);

		IList<Logisticscor> DescendOrderPaginationFindAll(LogisticscorPagination obj);

		IList<Logisticscor> QuickFindAll();

		IList<Logisticscor> FindByAddress(String address);

		IList<Logisticscor> DescendOrderFindByAddress(String address);

		IList<Logisticscor> PaginationFindByAddress(LogisticscorPagination obj);

		IList<Logisticscor> DescendOrderPaginationFindByAddress(LogisticscorPagination obj);

		int FindCountByAddress(Logisticscor obj);

		IList<Logisticscor> FindByActive(Byte active);

		IList<Logisticscor> DescendOrderFindByActive(Byte active);

		IList<Logisticscor> PaginationFindByActive(LogisticscorPagination obj);

		IList<Logisticscor> DescendOrderPaginationFindByActive(LogisticscorPagination obj);

		int FindCountByActive(Logisticscor obj);

		IList<Logisticscor> FindByLicenseurl(String licenseurl);

		IList<Logisticscor> DescendOrderFindByLicenseurl(String licenseurl);

		IList<Logisticscor> PaginationFindByLicenseurl(LogisticscorPagination obj);

		IList<Logisticscor> DescendOrderPaginationFindByLicenseurl(LogisticscorPagination obj);

		int FindCountByLicenseurl(Logisticscor obj);

		IList<Logisticscor> FindByCorporationname(String corporationname);

		IList<Logisticscor> DescendOrderFindByCorporationname(String corporationname);

		IList<Logisticscor> PaginationFindByCorporationname(LogisticscorPagination obj);

		IList<Logisticscor> DescendOrderPaginationFindByCorporationname(LogisticscorPagination obj);

		int FindCountByCorporationname(Logisticscor obj);

		IList<Logisticscor> FindByContactperson(String contactperson);

		IList<Logisticscor> DescendOrderFindByContactperson(String contactperson);

		IList<Logisticscor> PaginationFindByContactperson(LogisticscorPagination obj);

		IList<Logisticscor> DescendOrderPaginationFindByContactperson(LogisticscorPagination obj);

		int FindCountByContactperson(Logisticscor obj);

		IList<Logisticscor> FindByUserid(Int64 userid);

		IList<Logisticscor> DescendOrderFindByUserid(Int64 userid);

		IList<Logisticscor> PaginationFindByUserid(LogisticscorPagination obj);

		IList<Logisticscor> DescendOrderPaginationFindByUserid(LogisticscorPagination obj);

		int FindCountByUserid(Logisticscor obj);

		IList<Logisticscor> FindByTelephone(String telephone);

		IList<Logisticscor> DescendOrderFindByTelephone(String telephone);

		IList<Logisticscor> PaginationFindByTelephone(LogisticscorPagination obj);

		IList<Logisticscor> DescendOrderPaginationFindByTelephone(LogisticscorPagination obj);

		int FindCountByTelephone(Logisticscor obj);

		void Insert(Logisticscor obj);

		void Update(Logisticscor obj);

		void Delete(Logisticscor obj);

		int DeleteByAddress(String address);

		int DeleteByActive(Byte active);

		int DeleteByLicenseurl(String licenseurl);

		int DeleteByCorporationname(String corporationname);

		int DeleteByContactperson(String contactperson);

		int DeleteByUserid(Int64 userid);

		int DeleteByTelephone(String telephone);

		void Reload(Logisticscor obj);
	}
}
