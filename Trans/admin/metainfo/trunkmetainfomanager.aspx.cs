using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using Trans.DAL.Entity;

namespace Trans.admin.metainfo
{
    public partial class trunkmetainfomanager : Trans.App_Code.Biz.Common.SessionCheckPageBase
    {
        private ITrunknumberprefixDao trunkNumberPrefixDao;
        private ITrunknumberDao trunkNumberDao;
        private IVantypeDao vanTypeDao;
        private ITrunktypeDao trunkTypeDao;
        private ITrunkmetadataDao trunkMetadataDao;
        public trunkmetainfomanager()
        {
            this.trunkNumberPrefixDao = new TrunknumberprefixDao();
            this.trunkNumberDao = new TrunknumberDao();
            this.vanTypeDao = new VantypeDao();
            this.trunkTypeDao = new TrunktypeDao();
            this.trunkMetadataDao = new TrunkmetadataDao();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region 下拉框初始化
        /// <summary>
        /// 车牌前辍
        /// </summary>
        private void initNumberPrefix()
        {
            this.ddlTrunkNumberPrefix.Items.Clear();
            IList<Trunknumberprefix> trunkNumberPrefixList = this.trunkNumberPrefixDao.FindAll();
            foreach (Trunknumberprefix numberPrefixPoco in trunkNumberPrefixList)
            {
                this.ddlTrunkNumberPrefix.Items.Add(new ListItem(numberPrefixPoco.Prefixname,numberPrefixPoco.Id.ToString()));
            }
        }
        private void initVanType()
        {
            this.ddlVanType.Items.Clear();

        }
        #endregion
    }
}