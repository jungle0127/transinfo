using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface ITrunkreturntypeDao
    {
		int GetCount();

		Trunkreturntype Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Trunkreturntype> FindAll();

		IList<Trunkreturntype> PaginationFindAll(TrunkreturntypePagination obj);

		IList<Trunkreturntype> QuickFindAll();

		IList<Trunkreturntype> FindByTypename(String typename);

		IList<Trunkreturntype> PaginationFindByTypename(TrunkreturntypePagination obj);

		int FindCountByTypename(Trunkreturntype obj);

		void Insert(Trunkreturntype obj);

		void Update(Trunkreturntype obj);

		void Delete(Trunkreturntype obj);

		int DeleteByTypename(String typename);

		void Reload(Trunkreturntype obj);
	}
}
