using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IVuserroleinfoDao
    {
		int GetCount();

		IList<Vuserroleinfo> FindAll();

		IList<Vuserroleinfo> DescendOrderFindAll();

		IList<Vuserroleinfo> PaginationFindAll(VuserroleinfoPagination obj);

		IList<Vuserroleinfo> DescendOrderPaginationFindAll(VuserroleinfoPagination obj);

		IList<Vuserroleinfo> QuickFindAll();

		IList<Vuserroleinfo> FindByUserid(Int64 userid);

		IList<Vuserroleinfo> DescendOrderFindByUserid(Int64 userid);

		IList<Vuserroleinfo> PaginationFindByUserid(VuserroleinfoPagination obj);

		IList<Vuserroleinfo> DescendOrderPaginationFindByUserid(VuserroleinfoPagination obj);

		int FindCountByUserid(Vuserroleinfo obj);

		IList<Vuserroleinfo> FindByLoginname(String loginname);

		IList<Vuserroleinfo> DescendOrderFindByLoginname(String loginname);

		IList<Vuserroleinfo> PaginationFindByLoginname(VuserroleinfoPagination obj);

		IList<Vuserroleinfo> DescendOrderPaginationFindByLoginname(VuserroleinfoPagination obj);

		int FindCountByLoginname(Vuserroleinfo obj);

		IList<Vuserroleinfo> FindByUsername(String username);

		IList<Vuserroleinfo> DescendOrderFindByUsername(String username);

		IList<Vuserroleinfo> PaginationFindByUsername(VuserroleinfoPagination obj);

		IList<Vuserroleinfo> DescendOrderPaginationFindByUsername(VuserroleinfoPagination obj);

		int FindCountByUsername(Vuserroleinfo obj);

		IList<Vuserroleinfo> FindByRoleid(Int64 roleid);

		IList<Vuserroleinfo> DescendOrderFindByRoleid(Int64 roleid);

		IList<Vuserroleinfo> PaginationFindByRoleid(VuserroleinfoPagination obj);

		IList<Vuserroleinfo> DescendOrderPaginationFindByRoleid(VuserroleinfoPagination obj);

		int FindCountByRoleid(Vuserroleinfo obj);

		IList<Vuserroleinfo> FindByRolename(String rolename);

		IList<Vuserroleinfo> DescendOrderFindByRolename(String rolename);

		IList<Vuserroleinfo> PaginationFindByRolename(VuserroleinfoPagination obj);

		IList<Vuserroleinfo> DescendOrderPaginationFindByRolename(VuserroleinfoPagination obj);

		int FindCountByRolename(Vuserroleinfo obj);

		void Reload(Vuserroleinfo obj);
	}
}
