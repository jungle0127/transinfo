using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ICorporationhonorDao
    {
		int GetCount();

		Corporationhonor Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Corporationhonor> FindAll();

		IList<Corporationhonor> DescendOrderFindAll();

		IList<Corporationhonor> PaginationFindAll(CorporationhonorPagination obj);

		IList<Corporationhonor> DescendOrderPaginationFindAll(CorporationhonorPagination obj);

		IList<Corporationhonor> QuickFindAll();

		IList<Corporationhonor> FindByCorporationid(Int64 corporationid);

		IList<Corporationhonor> DescendOrderFindByCorporationid(Int64 corporationid);

		IList<Corporationhonor> PaginationFindByCorporationid(CorporationhonorPagination obj);

		IList<Corporationhonor> DescendOrderPaginationFindByCorporationid(CorporationhonorPagination obj);

		int FindCountByCorporationid(Corporationhonor obj);

		IList<Corporationhonor> FindByActive(Byte active);

		IList<Corporationhonor> DescendOrderFindByActive(Byte active);

		IList<Corporationhonor> PaginationFindByActive(CorporationhonorPagination obj);

		IList<Corporationhonor> DescendOrderPaginationFindByActive(CorporationhonorPagination obj);

		int FindCountByActive(Corporationhonor obj);

		IList<Corporationhonor> FindByHonortitle(String honortitle);

		IList<Corporationhonor> DescendOrderFindByHonortitle(String honortitle);

		IList<Corporationhonor> PaginationFindByHonortitle(CorporationhonorPagination obj);

		IList<Corporationhonor> DescendOrderPaginationFindByHonortitle(CorporationhonorPagination obj);

		int FindCountByHonortitle(Corporationhonor obj);

		IList<Corporationhonor> FindByHonorimageurl(String honorimageurl);

		IList<Corporationhonor> DescendOrderFindByHonorimageurl(String honorimageurl);

		IList<Corporationhonor> PaginationFindByHonorimageurl(CorporationhonorPagination obj);

		IList<Corporationhonor> DescendOrderPaginationFindByHonorimageurl(CorporationhonorPagination obj);

		int FindCountByHonorimageurl(Corporationhonor obj);

		void Insert(Corporationhonor obj);

		void Update(Corporationhonor obj);

		void Delete(Corporationhonor obj);

		int DeleteByCorporationid(Int64 corporationid);

		int DeleteByActive(Byte active);

		int DeleteByHonortitle(String honortitle);

		int DeleteByHonorimageurl(String honorimageurl);

		void Reload(Corporationhonor obj);
	}
}
