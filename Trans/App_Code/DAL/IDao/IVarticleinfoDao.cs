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

		IList<Varticleinfo> FindByHittimes(Int64 hittimes);

		IList<Varticleinfo> PaginationFindByHittimes(VarticleinfoPagination obj);

		IList<Varticleinfo> FindByUsername(String username);

		IList<Varticleinfo> PaginationFindByUsername(VarticleinfoPagination obj);

		IList<Varticleinfo> FindById(Int64 id);

		IList<Varticleinfo> PaginationFindById(VarticleinfoPagination obj);

		IList<Varticleinfo> FindByTitlecolor(String titlecolor);

		IList<Varticleinfo> PaginationFindByTitlecolor(VarticleinfoPagination obj);

		IList<Varticleinfo> FindByTypeid(Int64 typeid);

		IList<Varticleinfo> PaginationFindByTypeid(VarticleinfoPagination obj);

		IList<Varticleinfo> FindByContent(String content);

		IList<Varticleinfo> PaginationFindByContent(VarticleinfoPagination obj);

		IList<Varticleinfo> FindByReleaseip(String releaseip);

		IList<Varticleinfo> PaginationFindByReleaseip(VarticleinfoPagination obj);

		IList<Varticleinfo> FindByReleasedate(DateTime releasedate);

		IList<Varticleinfo> PaginationFindByReleasedate(VarticleinfoPagination obj);

		void Reload(Varticleinfo obj);
	}
}
