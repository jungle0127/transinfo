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

		IList<Vvehiclenumber> PaginationFindAll(VvehiclenumberPagination obj);

		IList<Vvehiclenumber> QuickFindAll();

		IList<Vvehiclenumber> FindByUserid(Int64 userid);

		IList<Vvehiclenumber> PaginationFindByUserid(VvehiclenumberPagination obj);

		int FindCountByUserid(Vvehiclenumber obj);

		IList<Vvehiclenumber> FindById(Int64 id);

		IList<Vvehiclenumber> PaginationFindById(VvehiclenumberPagination obj);

		int FindCountById(Vvehiclenumber obj);

		IList<Vvehiclenumber> FindByPrefixname(String prefixname);

		IList<Vvehiclenumber> PaginationFindByPrefixname(VvehiclenumberPagination obj);

		int FindCountByPrefixname(Vvehiclenumber obj);

		IList<Vvehiclenumber> FindByNumber(String number);

		IList<Vvehiclenumber> PaginationFindByNumber(VvehiclenumberPagination obj);

		int FindCountByNumber(Vvehiclenumber obj);

		void Reload(Vvehiclenumber obj);
	}
}
