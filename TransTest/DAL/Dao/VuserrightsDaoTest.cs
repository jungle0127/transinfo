using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Trans.DAL.Dao;
using Trans.DAL.Entity;

namespace TransTest.DAL.Dao
{
    [TestFixture]
    public class VuserrightsDaoTest
    {
        private IVuserrightsDao userRightsDao;
        [SetUp]
        public void setUp()
        {
            this.userRightsDao = new VuserrightsDao();
        }
        [TearDown]
        public void tearDown()
        {
            this.userRightsDao = null;
        }
        [Test]
        public void testFindById()
        {
            IList<Vuserrights> userRights = this.userRightsDao.FindByUserid(1);
            Assert.AreEqual(20, userRights.Count);
        }
        [Test]
        public void testFindByRightName()
        {
            IList<Vuserrights> userRights = this.userRightsDao.FindByRightname("角色管理");
            Assert.AreEqual(1, userRights.Count);
        }
    }
}
