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

		IList<Vvehiclenumber> FindById(Int64 id);

		IList<Vvehiclenumber> PaginationFindById(VvehiclenumberPagination obj);

		IList<Vvehiclenumber> FindByPrefixname(String prefixname);

		IList<Vvehiclenumber> PaginationFindByPrefixname(VvehiclenumberPagination obj);

		IList<Vvehiclenumber> FindByNumber(String number);

		IList<Vvehiclenumber> PaginationFindByNumber(VvehiclenumberPagination obj);

		void Reload(Vvehiclenumber obj);
	}
}
