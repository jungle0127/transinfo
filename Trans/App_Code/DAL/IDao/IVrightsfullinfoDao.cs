using System; 
using System.Collections.Generic; 
using System.Text; 
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{
    public partial interface IVrightsfullinfoDao
    {
		int GetCount();

		IList<Vrightsfullinfo> FindAll();

		IList<Vrightsfullinfo> PaginationFindAll(VrightsfullinfoPagination obj);

		IList<Vrightsfullinfo> QuickFindAll();

		IList<Vrightsfullinfo> FindByGroupname(String groupname);

		IList<Vrightsfullinfo> PaginationFindByGroupname(VrightsfullinfoPagination obj);

		int FindCountByGroupname(Vrightsfullinfo obj);

		IList<Vrightsfullinfo> FindByRightId(Int64 rightId);

		IList<Vrightsfullinfo> PaginationFindByRightId(VrightsfullinfoPagination obj);

		int FindCountByRightId(Vrightsfullinfo obj);

		IList<Vrightsfullinfo> FindByRighturl(String righturl);

		IList<Vrightsfullinfo> PaginationFindByRighturl(VrightsfullinfoPagination obj);

		int FindCountByRighturl(Vrightsfullinfo obj);

		IList<Vrightsfullinfo> FindByGroupId(Int64 groupId);

		IList<Vrightsfullinfo> PaginationFindByGroupId(VrightsfullinfoPagination obj);

		int FindCountByGroupId(Vrightsfullinfo obj);

		IList<Vrightsfullinfo> FindByRightname(String rightname);

		IList<Vrightsfullinfo> PaginationFindByRightname(VrightsfullinfoPagination obj);

		int FindCountByRightname(Vrightsfullinfo obj);

		void Reload(Vrightsfullinfo obj);
	}
}
