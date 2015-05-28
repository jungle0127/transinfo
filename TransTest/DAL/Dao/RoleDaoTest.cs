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
    public class RoleDaoTest
    {
        private IRoleDao roleDao;
        [SetUp]
        public void setUp()
        {
            this.roleDao = new RoleDao();
        }
        [TearDown]
        public void tearDown()
        {
            this.roleDao = null;
        }
        [Test]
        public void testInsert()
        {
            Role roleEntity = new Role();
            roleEntity.Rolename = "test";
            this.roleDao.Insert(roleEntity);
        }
        [Test]
        public void testUpdate()
        {
            Role roleEntity = new Role();
            roleEntity.Rolename = "test";
            roleEntity.Id = 6;
            roleEntity.Active = 1;
            this.roleDao.Update(roleEntity);
        }
        [Test]
        public void testDeleteById()
        {
            Assert.AreEqual(1,this.roleDao.DeleteByRolename("test"));
        }
    }
}
