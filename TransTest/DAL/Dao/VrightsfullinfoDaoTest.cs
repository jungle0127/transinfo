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
    public class VrightsfullinfoDaoTest
    {
        private VrightsfullinfoDao rightsDao;
        [SetUp]
        public void setUp()
        {
            this.rightsDao = new VrightsfullinfoDao();
        }

        [Test]
        public void testFindById()
        {
            Vrightsfullinfo rightList = this.rightsDao.Find(1);
        }
    }
}
