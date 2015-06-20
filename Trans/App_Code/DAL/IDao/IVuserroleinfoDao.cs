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

		IList<Vuserroleinfo> PaginationFindAll(VuserroleinfoPagination obj);

		IList<Vuserroleinfo> QuickFindAll();

		IList<Vuserroleinfo> FindByUserid(Int64 userid);

		IList<Vuserroleinfo> PaginationFindByUserid(VuserroleinfoPagination obj);

		int FindCountByUserid(Vuserroleinfo obj);

		IList<Vuserroleinfo> FindByLoginname(String loginname);

		IList<Vuserroleinfo> PaginationFindByLoginname(VuserroleinfoPagination obj);

		int FindCountByLoginname(Vuserroleinfo obj);

		IList<Vuserroleinfo> FindByUsername(String username);

		IList<Vuserroleinfo> PaginationFindByUsername(VuserroleinfoPagination obj);

		int FindCountByUsername(Vuserroleinfo obj);

		IList<Vuserroleinfo> FindByRoleid(Int64 roleid);

		IList<Vuserroleinfo> PaginationFindByRoleid(VuserroleinfoPagination obj);

		int FindCountByRoleid(Vuserroleinfo obj);

		IList<Vuserroleinfo> FindByRolename(String rolename);

		IList<Vuserroleinfo> PaginationFindByRolename(VuserroleinfoPagination obj);

		int FindCountByRolename(Vuserroleinfo obj);

		void Reload(Vuserroleinfo obj);
	}
}
