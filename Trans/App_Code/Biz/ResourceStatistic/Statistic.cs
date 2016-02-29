using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using Trans.DAL.Dao;

namespace Trans.Biz.ResourceStatistic
{
    public class Statistic
    {
        private ITrunkinformationDao trunkInfoDao;
        private IGoodssourceinformationDao goodsInfoDao;
        private string totalLorry;

        public string TotalLorry
        {
            get { return totalLorry; }
        }
        private string totalGoods;

        public string TotalGoods
        {
            get { return totalGoods; }
        }
        public Statistic()
        {
            this.trunkInfoDao = new TrunkinformationDao();
            this.goodsInfoDao = new GoodssourceinformationDao();
            this.totalLorry = this.trunkInfoDao.GetCount().ToString();
            this.totalGoods = this.goodsInfoDao.GetCount().ToString();
        }
    }
}