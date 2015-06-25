using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class VarticleinfoDao : IVarticleinfoDao
    {
        private ISqlMapper sqlMapper = null;
        public VarticleinfoDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Varticleinfo.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Varticleinfo Find(Int64 id) 
        {
			String stmtId = "Varticleinfo.Find";
			Varticleinfo result = this.sqlMapper.QueryForObject<Varticleinfo>(stmtId, id);
			return result;
        }
		public int GetFindCount(Int64 id) {
			String stmtId = "Varticleinfo.GetFindCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, id);
			return result;
		}
		public IList<Varticleinfo> FindAll() {
			String stmtId = "Varticleinfo.FindAll";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, null);
			return result;
        }
		public IList<Varticleinfo> DescendOrderFindAll() {
			String stmtId = "Varticleinfo.DescendOrderFindAll";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, null);
			return result;
        }
		public IList<Varticleinfo> PaginationFindAll(VarticleinfoPagination obj) {
			String stmtId = "Varticleinfo.FindAllPagination";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> DescendOrderPaginationFindAll(VarticleinfoPagination obj) {
			String stmtId = "Varticleinfo.DescendOrderFindAllPagination";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> QuickFindAll() {
			String stmtId = "Varticleinfo.QuickFindAll";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, null);
			return result;
        }
		public IList<Varticleinfo> FindByTitle(String title) {
			String stmtId = "Varticleinfo.FindByTitle";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, title);
			return result;
        }
		public IList<Varticleinfo> DescendOrderFindByTitle(String title) {
			String stmtId = "Varticleinfo.DescendOrderFindByTitle";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, title);
			return result;
        }
		public IList<Varticleinfo> PaginationFindByTitle(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindByTitle";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> DescendOrderPaginationFindByTitle(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.DescendOrderFindByTitle";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByTitle(Varticleinfo obj){
			String stmtId = "Varticleinfo.GetFindByTitleCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Varticleinfo> FindByHittimes(Int64 hittimes) {
			String stmtId = "Varticleinfo.FindByHittimes";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, hittimes);
			return result;
        }
		public IList<Varticleinfo> DescendOrderFindByHittimes(Int64 hittimes) {
			String stmtId = "Varticleinfo.DescendOrderFindByHittimes";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, hittimes);
			return result;
        }
		public IList<Varticleinfo> PaginationFindByHittimes(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindByHittimes";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> DescendOrderPaginationFindByHittimes(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.DescendOrderFindByHittimes";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByHittimes(Varticleinfo obj){
			String stmtId = "Varticleinfo.GetFindByHittimesCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Varticleinfo> FindByUsername(String username) {
			String stmtId = "Varticleinfo.FindByUsername";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, username);
			return result;
        }
		public IList<Varticleinfo> DescendOrderFindByUsername(String username) {
			String stmtId = "Varticleinfo.DescendOrderFindByUsername";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, username);
			return result;
        }
		public IList<Varticleinfo> PaginationFindByUsername(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindByUsername";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> DescendOrderPaginationFindByUsername(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.DescendOrderFindByUsername";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByUsername(Varticleinfo obj){
			String stmtId = "Varticleinfo.GetFindByUsernameCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Varticleinfo> FindById(Int64 id) {
			String stmtId = "Varticleinfo.FindById";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, id);
			return result;
        }
		public IList<Varticleinfo> DescendOrderFindById(Int64 id) {
			String stmtId = "Varticleinfo.DescendOrderFindById";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, id);
			return result;
        }
		public IList<Varticleinfo> PaginationFindById(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindById";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> DescendOrderPaginationFindById(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.DescendOrderFindById";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public int FindCountById(Varticleinfo obj){
			String stmtId = "Varticleinfo.GetFindByIdCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Varticleinfo> FindByTitlecolor(String titlecolor) {
			String stmtId = "Varticleinfo.FindByTitlecolor";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, titlecolor);
			return result;
        }
		public IList<Varticleinfo> DescendOrderFindByTitlecolor(String titlecolor) {
			String stmtId = "Varticleinfo.DescendOrderFindByTitlecolor";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, titlecolor);
			return result;
        }
		public IList<Varticleinfo> PaginationFindByTitlecolor(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindByTitlecolor";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> DescendOrderPaginationFindByTitlecolor(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.DescendOrderFindByTitlecolor";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByTitlecolor(Varticleinfo obj){
			String stmtId = "Varticleinfo.GetFindByTitlecolorCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Varticleinfo> FindByTypeid(Int64 typeid) {
			String stmtId = "Varticleinfo.FindByTypeid";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, typeid);
			return result;
        }
		public IList<Varticleinfo> DescendOrderFindByTypeid(Int64 typeid) {
			String stmtId = "Varticleinfo.DescendOrderFindByTypeid";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, typeid);
			return result;
        }
		public IList<Varticleinfo> PaginationFindByTypeid(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindByTypeid";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> DescendOrderPaginationFindByTypeid(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.DescendOrderFindByTypeid";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByTypeid(Varticleinfo obj){
			String stmtId = "Varticleinfo.GetFindByTypeidCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Varticleinfo> FindByContent(String content) {
			String stmtId = "Varticleinfo.FindByContent";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, content);
			return result;
        }
		public IList<Varticleinfo> DescendOrderFindByContent(String content) {
			String stmtId = "Varticleinfo.DescendOrderFindByContent";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, content);
			return result;
        }
		public IList<Varticleinfo> PaginationFindByContent(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindByContent";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> DescendOrderPaginationFindByContent(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.DescendOrderFindByContent";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByContent(Varticleinfo obj){
			String stmtId = "Varticleinfo.GetFindByContentCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Varticleinfo> FindByReleaseip(String releaseip) {
			String stmtId = "Varticleinfo.FindByReleaseip";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, releaseip);
			return result;
        }
		public IList<Varticleinfo> DescendOrderFindByReleaseip(String releaseip) {
			String stmtId = "Varticleinfo.DescendOrderFindByReleaseip";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, releaseip);
			return result;
        }
		public IList<Varticleinfo> PaginationFindByReleaseip(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindByReleaseip";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> DescendOrderPaginationFindByReleaseip(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.DescendOrderFindByReleaseip";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByReleaseip(Varticleinfo obj){
			String stmtId = "Varticleinfo.GetFindByReleaseipCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public IList<Varticleinfo> FindByReleasedate(DateTime releasedate) {
			String stmtId = "Varticleinfo.FindByReleasedate";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, releasedate);
			return result;
        }
		public IList<Varticleinfo> DescendOrderFindByReleasedate(DateTime releasedate) {
			String stmtId = "Varticleinfo.DescendOrderFindByReleasedate";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, releasedate);
			return result;
        }
		public IList<Varticleinfo> PaginationFindByReleasedate(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindByReleasedate";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> DescendOrderPaginationFindByReleasedate(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.DescendOrderFindByReleasedate";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public int FindCountByReleasedate(Varticleinfo obj){
			String stmtId = "Varticleinfo.GetFindByReleasedateCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, obj);
			return result;
		}
		public void Reload(Varticleinfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Varticleinfo.Find";
			this.sqlMapper.QueryForObject<Varticleinfo>(stmtId, obj, obj);
		}
    }
}
