using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;
using Trans.DAL.Dao;
using Trans.DAL.Entity;

namespace Trans.admin.personalinfo
{
    public partial class CoporationAuditInfoRequest : System.Web.UI.Page
    {
        private static ILog logger = LogManager.GetLogger(typeof(CoporationAuditInfoRequest));
        private ILogisticscorDao logisticsCorDao;
        private Logisticscor logisticsPoco;
        public CoporationAuditInfoRequest()
        {
            this.logisticsCorDao = new LogisticscorDao();
            this.logisticsPoco = new Logisticscor();
            logger.Info("Constructor method done.");
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            this.logisticsPoco.Address = this.txtAddress.Text;
            this.logisticsPoco.Contactperson = this.txtContact.Text;
            this.logisticsPoco.Corporationname = this.txtCorporationName.Text;
            this.logisticsPoco.Telephone = this.txtPhone.Text;
            if (this.fileUploadLicenseUrl.HasFile)
            {
                string srcFileName = this.fileUploadLicenseUrl.FileName;
                string dstCorporationLicenseFileName = "~/licenseimage/corporationlicense" + DateTime.Now.ToFileTime().ToString();
                this.fileUploadLicenseUrl.SaveAs(Server.MapPath(dstCorporationLicenseFileName));
                logger.Info("Corporation license image uploaded as:" + dstCorporationLicenseFileName);
                this.logisticsPoco.Licenseurl = dstCorporationLicenseFileName;
            }
            else
            {
                logger.Warn("Corporation license can not be missing.");
                return;
            }
            try
            {
                this.logisticsPoco.Userid = int.Parse(Session["userid"].ToString());
                this.logisticsPoco.Active = 0;
                this.logisticsCorDao.Insert(this.logisticsPoco);
                logger.Info("Data added.");
            }
            catch (Exception ex)
            {
                logger.Error("Corporation autdit information added failed with exception:" + ex.Message);
            }
        }
    }
}