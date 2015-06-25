using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IVvehiclenumberDao
    {
		int GetCount();

		IList<Vvehiclenumber> FindAll();

		IList<Vvehiclenumber> DescendOrderFindAll();

		IList<Vvehiclenumber> PaginationFindAll(VvehiclenumberPagination obj);

		IList<Vvehiclenumber> DescendOrderPaginationFindAll(VvehiclenumberPagination obj);

		IList<Vvehiclenumber> QuickFindAll();

		IList<Vvehiclenumber> FindByUserid(Int64 userid);

		IList<Vvehiclenumber> DescendOrderFindByUserid(Int64 userid);

		IList<Vvehiclenumber> PaginationFindByUserid(VvehiclenumberPagination obj);

		IList<Vvehiclenumber> DescendOrderPaginationFindByUserid(VvehiclenumberPagination obj);

		int FindCountByUserid(Vvehiclenumber obj);

		IList<Vvehiclenumber> FindById(Int64 id);

		IList<Vvehiclenumber> DescendOrderFindById(Int64 id);

		IList<Vvehiclenumber> PaginationFindById(VvehiclenumberPagination obj);

		IList<Vvehiclenumber> DescendOrderPaginationFindById(VvehiclenumberPagination obj);

		int FindCountById(Vvehiclenumber obj);

		IList<Vvehiclenumber> FindByPrefixname(String prefixname);

		IList<Vvehiclenumber> DescendOrderFindByPrefixname(String prefixname);

		IList<Vvehiclenumber> PaginationFindByPrefixname(VvehiclenumberPagination obj);

		IList<Vvehiclenumber> DescendOrderPaginationFindByPrefixname(VvehiclenumberPagination obj);

		int FindCountByPrefixname(Vvehiclenumber obj);

		IList<Vvehiclenumber> FindByNumber(String number);

		IList<Vvehiclenumber> DescendOrderFindByNumber(String number);

		IList<Vvehiclenumber> PaginationFindByNumber(VvehiclenumberPagination obj);

		IList<Vvehiclenumber> DescendOrderPaginationFindByNumber(VvehiclenumberPagination obj);

		int FindCountByNumber(Vvehiclenumber obj);

		void Reload(Vvehiclenumber obj);
	}
}
