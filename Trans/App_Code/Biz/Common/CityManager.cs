using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trans.DAL.Dao;
using System.Collections;
using Trans.DAL.Entity;
using log4net;

namespace Trans.Biz.Common
{
    public class CityManager
    {
        private static ILog logger = LogManager.GetLogger(typeof(CityManager));
        private IProvinceDao provinceDao;
        private ICityDao cityDao;
        private ICountyDao countyDao;
        public CityManager()
        {
            logger.Info("Begin initiate CityManager.");
            this.provinceDao = new ProvinceDao();
            this.cityDao = new CityDao();
            this.countyDao = new CountyDao();
            logger.Info("Initiate CityManager done.");
        }

        public Hashtable getAllProvince()
        {
            logger.Info("Begin query all provinces.");
            Hashtable provinceMap = new Hashtable();
            IList<Province> provincePocoList = this.provinceDao.FindAll();
            logger.Info("Got province items count:" + provincePocoList.Count.ToString());
            foreach (Province poco in provincePocoList)
            {
                provinceMap.Add(poco.Code, poco.Name);
            }
            logger.Info("Query province done.");
            return provinceMap;
        }

        public Hashtable getCityByProvinceCode(string provinceCode)
        {
            Hashtable cityMap = new Hashtable();
            IList<City> cityPocoList = this.cityDao.FindByProvincecode(provinceCode);
            foreach (City poco in cityPocoList)
            {
                cityMap.Add(poco.Code, poco.Name);
            }
            return cityMap;
        }

        public Hashtable getCountyByCityCode(string cityCode)
        {
            Hashtable countyMap = new Hashtable();
            IList<County> countyPocoLis = this.countyDao.FindByCitycode(cityCode);
            foreach (County poco in countyPocoLis)
            {
                countyMap.Add(poco.Code, poco.Name);
            }
            return countyMap;
        }

        public Province getProvinceByCode(string provinceCode)
        {
            IList<Province> provinceList = this.provinceDao.FindByCode(provinceCode);
            if (provinceList != null && provinceList.Count > 0)
            {
                return provinceList[0];
            }
            return null;
        }

        public City getCityByCode(string cityCode)
        {
            IList<City> cityList = this.cityDao.FindByCode(cityCode);
            if (null != cityList && cityList.Count > 0)
            {
                return cityList[0];
            }
            return null;
        }

        public County getCountyByCode(string countyCode)
        {
            IList<County> countyList = this.countyDao.FindByCode(countyCode);
            if (null != countyList && countyList.Count > 0)
            {
                return countyList[0];
            }
            return null;
        }
    }
}