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
		public IList<Varticleinfo> FindAll() {
			String stmtId = "Varticleinfo.FindAll";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, null);
			return result;
        }
		public IList<Varticleinfo> PaginationFindAll(VarticleinfoPagination obj) {
			String stmtId = "Varticleinfo.FindAllPagination";
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
		public IList<Varticleinfo> PaginationFindByTitle(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindByTitle";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> FindByHittimes(Int64 hittimes) {
			String stmtId = "Varticleinfo.FindByHittimes";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, hittimes);
			return result;
        }
		public IList<Varticleinfo> PaginationFindByHittimes(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindByHittimes";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> FindByUsername(String username) {
			String stmtId = "Varticleinfo.FindByUsername";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, username);
			return result;
        }
		public IList<Varticleinfo> PaginationFindByUsername(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindByUsername";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> FindById(Int64 id) {
			String stmtId = "Varticleinfo.FindById";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, id);
			return result;
        }
		public IList<Varticleinfo> PaginationFindById(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindById";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> FindByTitlecolor(String titlecolor) {
			String stmtId = "Varticleinfo.FindByTitlecolor";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, titlecolor);
			return result;
        }
		public IList<Varticleinfo> PaginationFindByTitlecolor(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindByTitlecolor";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> FindByContent(String content) {
			String stmtId = "Varticleinfo.FindByContent";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, content);
			return result;
        }
		public IList<Varticleinfo> PaginationFindByContent(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindByContent";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> FindByReleaseip(String releaseip) {
			String stmtId = "Varticleinfo.FindByReleaseip";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, releaseip);
			return result;
        }
		public IList<Varticleinfo> PaginationFindByReleaseip(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindByReleaseip";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public IList<Varticleinfo> FindByReleasedate(DateTime releasedate) {
			String stmtId = "Varticleinfo.FindByReleasedate";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, releasedate);
			return result;
        }
		public IList<Varticleinfo> PaginationFindByReleasedate(VarticleinfoPagination obj) {
			String stmtId = "VarticleinfoPagination.FindByReleasedate";
			IList<Varticleinfo> result = this.sqlMapper.QueryForList<Varticleinfo>(stmtId, obj);
			return result;
        }
		public void Reload(Varticleinfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Varticleinfo.Find";
			this.sqlMapper.QueryForObject<Varticleinfo>(stmtId, obj, obj);
		}
    }
}
