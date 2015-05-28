using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NDbUnit.Core;
using System.Data;
using System.Collections.Specialized;
using Proteus.Utility.UnitTest;
using System.Data.SqlClient;
using NDbUnit.Core.SqlClient;
using Trans.DAL.Dao;
using Trans.DAL.Entity;

namespace TransTest.DAL.Dao
{
    [TestFixture]
    public class UsersDaoTest
    {
        private UsersDao usersDao;

        [SetUp]
        public void setUp()
        {
            //INDbUnitTest dataBase = new SqlDbUnitTest("Data Source=(local);Initial Catalog=artsurvey;Persist Security Info=True;User ID=sa;Password=lotus");
            //dataBase.ReadXmlSchema("../../etc/artsurvey.xsd");

            //DataTableCollection dtc = dataBase.GetDataSetFromDb().Tables;
            //foreach (DataTable dt in dtc)
            //{
            //    StringCollection sc = new StringCollection();
            //    sc.Add(dt.TableName);
            //    dataBase.GetDataSetFromDb(sc).WriteXmlSchema("etc//" + dt.TableName + ".schema.xml");
            //    dataBase.GetDataSetFromDb(sc).WriteXml("etc//" + dt.TableName + ".data.xml");
            //}
            this.usersDao = new UsersDao();
        }
        [Test]
        public void testFind()
        {
            Users users = this.usersDao.Find(2);
            Assert.AreNotEqual(null, users);
            Assert.AreEqual("ps", users.Loginname);
        }
        [Test]
        public void testFindAll()
        {
            IList<Users> usersList = this.usersDao.FindAll();
            Assert.AreEqual(2, usersList.Count);
        }
        [Test]
        public void testFindByRoleId()
        {
            IList<Users> userList = this.usersDao.FindByRoleid(2);
            Assert.AreEqual(1, userList.Count);
        }
        [Test]
        public void testFindByLoginname()
        {
            String value = "ps";
            IList<Users> userList = this.usersDao.FindByLoginname(value);
            Assert.AreEqual(1, userList.Count);
        }
        [TearDown]
        public void tearDown()
        {
            this.usersDao = null;
        }
    }
}
