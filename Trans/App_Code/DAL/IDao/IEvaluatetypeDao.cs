using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IEvaluatetypeDao
    {
		int GetCount();

		Evaluatetype Find(Int64 id);

		int GetFindCount(Int64 id);

		IList<Evaluatetype> FindAll();

		IList<Evaluatetype> PaginationFindAll(EvaluatetypePagination obj);

		IList<Evaluatetype> QuickFindAll();

		IList<Evaluatetype> FindByActive(Byte active);

		IList<Evaluatetype> PaginationFindByActive(EvaluatetypePagination obj);

		int FindCountByActive(Evaluatetype obj);

		IList<Evaluatetype> FindByName(String name);

		IList<Evaluatetype> PaginationFindByName(EvaluatetypePagination obj);

		int FindCountByName(Evaluatetype obj);

		void Insert(Evaluatetype obj);

		void Update(Evaluatetype obj);

		void Delete(Evaluatetype obj);

		int DeleteByActive(Byte active);

		int DeleteByName(String name);

		void Reload(Evaluatetype obj);
	}
}
