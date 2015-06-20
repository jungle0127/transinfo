using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ITrunkroutetypeDao
    {
		int GetCount();

		Trunkroutetype Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Trunkroutetype> FindAll();

		IList<Trunkroutetype> PaginationFindAll(TrunkroutetypePagination obj);

		IList<Trunkroutetype> QuickFindAll();

		IList<Trunkroutetype> FindByTypename(String typename);

		IList<Trunkroutetype> PaginationFindByTypename(TrunkroutetypePagination obj);

		int FindCountByTypename(Trunkroutetype obj);

		void Insert(Trunkroutetype obj);

		void Update(Trunkroutetype obj);

		void Delete(Trunkroutetype obj);

		int DeleteByTypename(String typename);

		void Reload(Trunkroutetype obj);
	}
}
