
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
public class UspUpdateRoleHasRightsDao : IUspUpdateRoleHasRightsDao
    {
        private ISqlMapper sqlMapper = null;
        public UspUpdateRoleHasRightsDao()
        {
            DomSqlMapBuilder sqlMapBuilder = new DomSqlMapBuilder();
            this.sqlMapper = sqlMapBuilder.Configure("etc/mybatis.sqlmap.cfg.xml");
        }
        public void RunProc(UspUpdateRoleHasRights obj)
        {
            String stmtId = "uspUpdateRoleHasRightsid";
            this.sqlMapper.QueryForObject(stmtId, obj);
        }
    }
}
