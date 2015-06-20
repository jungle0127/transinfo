using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IVarticleinfoDao
    {
		int GetCount();

		IList<Varticleinfo> FindAll();

		IList<Varticleinfo> PaginationFindAll(VarticleinfoPagination obj);

		IList<Varticleinfo> QuickFindAll();

		IList<Varticleinfo> FindByTitle(String title);

		IList<Varticleinfo> PaginationFindByTitle(VarticleinfoPagination obj);

		int FindCountByTitle(Varticleinfo obj);

		IList<Varticleinfo> FindByHittimes(Int64 hittimes);

		IList<Varticleinfo> PaginationFindByHittimes(VarticleinfoPagination obj);

		int FindCountByHittimes(Varticleinfo obj);

		IList<Varticleinfo> FindByUsername(String username);

		IList<Varticleinfo> PaginationFindByUsername(VarticleinfoPagination obj);

		int FindCountByUsername(Varticleinfo obj);

		IList<Varticleinfo> FindById(Int64 id);

		IList<Varticleinfo> PaginationFindById(VarticleinfoPagination obj);

		int FindCountById(Varticleinfo obj);

		IList<Varticleinfo> FindByTitlecolor(String titlecolor);

		IList<Varticleinfo> PaginationFindByTitlecolor(VarticleinfoPagination obj);

		int FindCountByTitlecolor(Varticleinfo obj);

		IList<Varticleinfo> FindByTypeid(Int64 typeid);

		IList<Varticleinfo> PaginationFindByTypeid(VarticleinfoPagination obj);

		int FindCountByTypeid(Varticleinfo obj);

		IList<Varticleinfo> FindByContent(String content);

		IList<Varticleinfo> PaginationFindByContent(VarticleinfoPagination obj);

		int FindCountByContent(Varticleinfo obj);

		IList<Varticleinfo> FindByReleaseip(String releaseip);

		IList<Varticleinfo> PaginationFindByReleaseip(VarticleinfoPagination obj);

		int FindCountByReleaseip(Varticleinfo obj);

		IList<Varticleinfo> FindByReleasedate(DateTime releasedate);

		IList<Varticleinfo> PaginationFindByReleasedate(VarticleinfoPagination obj);

		int FindCountByReleasedate(Varticleinfo obj);

		void Reload(Varticleinfo obj);
	}
}
