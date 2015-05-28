using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ITrunknumberDao
    {
		int GetCount();

		Trunknumber Find(Int64 id);

		IList<Trunknumber> FindAll();

		IList<Trunknumber> PaginationFindAll(TrunknumberPagination obj);

		IList<Trunknumber> QuickFindAll();

		IList<Trunknumber> FindByNumber(String number);

		IList<Trunknumber> PaginationFindByNumber(TrunknumberPagination obj);

		IList<Trunknumber> FindByUserid(Int64 userid);

		IList<Trunknumber> PaginationFindByUserid(TrunknumberPagination obj);

		IList<Trunknumber> FindByPrefixid(Int64 prefixid);

		IList<Trunknumber> PaginationFindByPrefixid(TrunknumberPagination obj);

		IList<Trunknumber> FindByActive(Byte active);

		IList<Trunknumber> PaginationFindByActive(TrunknumberPagination obj);

		void Insert(Trunknumber obj);

		void Update(Trunknumber obj);

		void Delete(Trunknumber obj);

		int DeleteByNumber(String number);

		int DeleteByUserid(Int64 userid);

		int DeleteByPrefixid(Int64 prefixid);

		int DeleteByActive(Byte active);

		void Reload(Trunknumber obj);
	}
}
