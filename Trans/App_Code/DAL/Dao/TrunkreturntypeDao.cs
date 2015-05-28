using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using Trans.DAL.Entity;

namespace Trans.DAL.Dao 
{

    public partial class TrunkreturntypeDao : ITrunkreturntypeDao
    {
        private ISqlMapper sqlMapper = null;
        public TrunkreturntypeDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
		public int GetCount() {
			String stmtId = "Trunkreturntype.GetCount";
			int result = this.sqlMapper.QueryForObject<int>(stmtId, null);
			return result;
		}
		public Trunkreturntype Find(Int64 id) 
        {
			String stmtId = "Trunkreturntype.Find";
			Trunkreturntype result = this.sqlMapper.QueryForObject<Trunkreturntype>(stmtId, id);
			return result;
        }
		public IList<Trunkreturntype> FindAll() {
			String stmtId = "Trunkreturntype.FindAll";
			IList<Trunkreturntype> result = this.sqlMapper.QueryForList<Trunkreturntype>(stmtId, null);
			return result;
        }
		public IList<Trunkreturntype> PaginationFindAll(TrunkreturntypePagination obj) {
			String stmtId = "Trunkreturntype.FindAllPagination";
			IList<Trunkreturntype> result = this.sqlMapper.QueryForList<Trunkreturntype>(stmtId, obj);
			return result;
        }
		public IList<Trunkreturntype> QuickFindAll() {
			String stmtId = "Trunkreturntype.QuickFindAll";
			IList<Trunkreturntype> result = this.sqlMapper.QueryForList<Trunkreturntype>(stmtId, null);
			return result;
        }
		public IList<Trunkreturntype> FindByTypename(String typename) {
			String stmtId = "Trunkreturntype.FindByTypename";
			IList<Trunkreturntype> result = this.sqlMapper.QueryForList<Trunkreturntype>(stmtId, typename);
			return result;
        }
		public IList<Trunkreturntype> PaginationFindByTypename(TrunkreturntypePagination obj) {
			String stmtId = "TrunkreturntypePagination.FindByTypename";
			IList<Trunkreturntype> result = this.sqlMapper.QueryForList<Trunkreturntype>(stmtId, obj);
			return result;
        }
		public void Update(Trunkreturntype obj) {
			String stmtId = "Trunkreturntype.Update";
			this.sqlMapper.Update(stmtId, obj);
		}
		public void Insert(Trunkreturntype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunkreturntype.Insert";
			this.sqlMapper.Insert(stmtId, obj);
		}
		public void Delete(Trunkreturntype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunkreturntype.Delete";
			this.sqlMapper.Delete(stmtId, obj);
		}
		public int DeleteByTypename(String typename) {
			String stmtId = "Trunkreturntype.DeleteByTypename";
			int result = this.sqlMapper.Delete(stmtId, typename);
			return result;
        }
		public void Reload(Trunkreturntype obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "Trunkreturntype.Find";
			this.sqlMapper.QueryForObject<Trunkreturntype>(stmtId, obj, obj);
		}
    }
}
