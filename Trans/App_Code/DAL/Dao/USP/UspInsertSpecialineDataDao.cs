
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trans.DAL.IDao.USP;
using Trans.DAL.Entity.USP;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
namespace Trans.DAL.Dao.USP
{
public class UspInsertSpecialineDataDao : IUspInsertSpecialineDataDao
    {
        private ISqlMapper sqlMapper = null;
        public UspInsertSpecialineDataDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
        public void RunProc(UspInsertSpecialineData obj)
        {
            String stmtId = "uspInsertSpecialineDataid";
            this.sqlMapper.QueryForObject(stmtId, obj);
        }
    }
}
