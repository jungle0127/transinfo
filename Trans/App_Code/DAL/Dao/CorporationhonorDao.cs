using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class CorporationhonorDao : ICorporationhonorDao
    {
        private ISqlMapper sqlMapper = null;
        public CorporationhonorDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Corporationhonor.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Corporationhonor Find(Int64 id) 
        {
			String stmtId = "Corporationhonor.Find";
			Corporationhonor result = this.sqlMapper.QueryForObject<Corporationhonor>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Corporationhonor.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Corporationhonor> FindAll() {
			String stmtId = "Corporationhonor.FindAll";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, null);
			return result;
        }
		public IList<Corporationhonor> DescendOrderFindAll() {
			String stmtId = "Corporationhonor.DescendOrderFindAll";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, null);
			return result;
        }
		public IList<Corporationhonor> PaginationFindAll(CorporationhonorPagination obj) {
			String stmtId = "Corporationhonor.FindAllPagination";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, obj);
			return result;
        }
		public IList<Corporationhonor> DescendOrderPaginationFindAll(CorporationhonorPagination obj) {
			String stmtId = "Corporationhonor.DescendOrderFindAllPagination";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, obj);
			return result;
        }
		public IList<Corporationhonor> QuickFindAll() {
			String stmtId = "Corporationhonor.QuickFindAll";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, null);
			return result;
        }
		public IList<Corporationhonor> FindByCorporationid(Int64 corporationid) {
			String stmtId = "Corporationhonor.FindByCorporationid";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, corporationid);
			return result;
        }
		public IList<Corporationhonor> DescendOrderFindByCorporationid(Int64 corporationid) {
			String stmtId = "Corporationhonor.DescendOrderFindByCorporationid";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, corporationid);
			return result;
        }
		public IList<Corporationhonor> PaginationFindByCorporationid(CorporationhonorPagination obj) {
			String stmtId = "CorporationhonorPagination.FindByCorporationid";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, obj);
			return result;
        }
		public IList<Corporationhonor> DescendOrderPaginationFindByCorporationid(CorporationhonorPagination obj) {
			String stmtId = "CorporationhonorPagination.DescendOrderFindByCorporationid";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, obj);
			return result;
        }
		public int FindCountByCorporationid(Corporationhonor obj){
			String stmtId = "Corporationhonor.GetFindByCorporationidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Corporationhonor> FindByActive(Byte active) {
			String stmtId = "Corporationhonor.FindByActive";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, active);
			return result;
        }
		public IList<Corporationhonor> DescendOrderFindByActive(Byte active) {
			String stmtId = "Corporationhonor.DescendOrderFindByActive";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, active);
			return result;
        }
		public IList<Corporationhonor> PaginationFindByActive(CorporationhonorPagination obj) {
			String stmtId = "CorporationhonorPagination.FindByActive";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, obj);
			return result;
        }
		public IList<Corporationhonor> DescendOrderPaginationFindByActive(CorporationhonorPagination obj) {
			String stmtId = "CorporationhonorPagination.DescendOrderFindByActive";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, obj);
			return result;
        }
		public int FindCountByActive(Corporationhonor obj){
			String stmtId = "Corporationhonor.GetFindByActiveCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Corporationhonor> FindByHonortitle(String honortitle) {
			String stmtId = "Corporationhonor.FindByHonortitle";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, honortitle);
			return result;
        }
		public IList<Corporationhonor> DescendOrderFindByHonortitle(String honortitle) {
			String stmtId = "Corporationhonor.DescendOrderFindByHonortitle";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, honortitle);
			return result;
        }
		public IList<Corporationhonor> PaginationFindByHonortitle(CorporationhonorPagination obj) {
			String stmtId = "CorporationhonorPagination.FindByHonortitle";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, obj);
			return result;
        }
		public IList<Corporationhonor> DescendOrderPaginationFindByHonortitle(CorporationhonorPagination obj) {
			String stmtId = "CorporationhonorPagination.DescendOrderFindByHonortitle";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, obj);
			return result;
        }
		public int FindCountByHonortitle(Corporationhonor obj){
			String stmtId = "Corporationhonor.GetFindByHonortitleCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Corporationhonor> FindByHonorimageurl(String honorimageurl) {
			String stmtId = "Corporationhonor.FindByHonorimageurl";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, honorimageurl);
			return result;
        }
		public IList<Corporationhonor> DescendOrderFindByHonorimageurl(String honorimageurl) {
			String stmtId = "Corporationhonor.DescendOrderFindByHonorimageurl";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, honorimageurl);
			return result;
        }
		public IList<Corporationhonor> PaginationFindByHonorimageurl(CorporationhonorPagination obj) {
			String stmtId = "CorporationhonorPagination.FindByHonorimageurl";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, obj);
			return result;
        }
		public IList<Corporationhonor> DescendOrderPaginationFindByHonorimageurl(CorporationhonorPagination obj) {
			String stmtId = "CorporationhonorPagination.DescendOrderFindByHonorimageurl";
			IList<Corporationhonor> result = this.sqlMapper.QueryForList<Corporationhonor>(stmtId, obj);
			return result;
        }
		public int FindCountByHonorimageurl(Corporationhonor obj){
			String stmtId = "Corporationhonor.GetFindByHonorimageurlCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Update(Corporationhonor obj) {
			String stmtId = "Corporationhonor.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Corporationhonor obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Corporationhonor.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Corporationhonor obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Corporationhonor.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByCorporationid(Int64 corporationid) {
			String stmtId = "Corporationhonor.DeleteByCorporationid";
			int result = this.sqlMapper.Delete(stmtId, corporationid);
			return result;
        }
		public int DeleteByActive(Byte active) {
			String stmtId = "Corporationhonor.DeleteByActive";
			int result = this.sqlMapper.Delete(stmtId, active);
			return result;
        }
		public int DeleteByHonortitle(String honortitle) {
			String stmtId = "Corporationhonor.DeleteByHonortitle";
			int result = this.sqlMapper.Delete(stmtId, honortitle);
			return result;
        }
		public int DeleteByHonorimageurl(String honorimageurl) {
			String stmtId = "Corporationhonor.DeleteByHonorimageurl";
			int result = this.sqlMapper.Delete(stmtId, honorimageurl);
			return result;
        }
		public void Reload(Corporationhonor obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Corporationhonor.Find";
			this.sqlMapper.QueryForObject<Corporationhonor>(stmtId, obj, obj);
		}
    }
}
