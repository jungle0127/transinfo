using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Trans.Biz.Common;
using Trans.DAL.Dao;
using Trans.DAL.Entity;

namespace Trans.admin.information
{
    public partial class depositorypublisher : Trans.App_Code.Biz.Common.SessionCheckPageBase
    {
        private IBussinessscopeDao bizScopeDao;
        private IDepottypeDao depotTypeDao;
        private IDepotinformationDao depotInfoDao;
        public depositorypublisher() : base()
        {
            this.bizScopeDao = new BussinessscopeDao();
            this.depotTypeDao = new DepottypeDao();
            this.depotInfoDao = new DepotinformationDao();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.initBizScopeList();
                this.initDepotType();
            }
        }
        #region 初始化下拉框
        /// <summary>
        /// 经营范围
        /// </summary>
        private void initBizScopeList()
        {
            this.ddlBizScope.Items.Clear();
            this.ddlBizScope.Items.Add(new ListItem("请选择...", "-1"));
            IList<Bussinessscope> bizScopeList = this.bizScopeDao.FindAll();
            foreach (Bussinessscope bizScopePoco in bizScopeList)
            {
                this.ddlBizScope.Items.Add(new ListItem(bizScopePoco.Scopename, bizScopePoco.Id.ToString()));
            }
        }

        private void initDepotType()
        {
            this.ddlDepotType.Items.ToString();
            this.ddlDepotType.Items.Add(new ListItem("请选择...", "-1"));
            IList<Depottype> depotTypeList = this.depotTypeDao.FindAll();
            foreach (Depottype depotTypePoco in depotTypeList)
            {
                this.ddlDepotType.Items.Add(new ListItem(depotTypePoco.Typename, depotTypePoco.Id.ToString()));
            }
        }

        #endregion


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            this.depotInfoDao.Insert(this.loadEntity());
        }

        private Depotinformation loadEntity()
        {
            Depotinformation depotInfoEntity = new Depotinformation();
            depotInfoEntity.Address = this.txtAddress.Text;
            
            depotInfoEntity.Area = int.Parse(this.txtArea.Text);
            depotInfoEntity.Bizscopetype = long.Parse(this.ddlBizScope.SelectedValue);
            depotInfoEntity.Cellphone = this.txtPhone.Text;
            depotInfoEntity.Contactperson = this.txtContactPerson.Text;
            depotInfoEntity.Depottype = long.Parse(this.ddlDepotType.SelectedValue);
            depotInfoEntity.Description = this.txtNote.Text;
            depotInfoEntity.Price = this.txtPrice.Text;
            depotInfoEntity.Title = this.txtTitle.Text;
            depotInfoEntity.Useablearea = int.Parse(this.txtUseableArea.Text);
            depotInfoEntity.Validtime = this.txtValidTime.Text;
            depotInfoEntity.Userid = long.Parse(base.UserId);
            return depotInfoEntity;
        }

        protected void txtValidCalendar_SelectionChanged(object sender, EventArgs e)
        {
            this.txtValidTime.Text = this.txtValidCalendar.SelectedDate.ToShortDateString();
            this.calendar.Visible = false;
            this.txtValidTime.Focus();
        }

        protected void ImageButton_Click(object sender, ImageClickEventArgs e)
        {
            this.calendar.Visible = !this.calendar.Visible;
        }

    }
}