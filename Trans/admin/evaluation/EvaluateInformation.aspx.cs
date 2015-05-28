using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using Trans.DAL.Entity;

namespace Trans.admin.evaluation
{
    public partial class EvaluateInformation : System.Web.UI.Page
    {
        private IEvaluatetypeDao evaluateTypeDao;
        public EvaluateInformation()
        {
            this.evaluateTypeDao = new EvaluatetypeDao();
 
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            IList<Evaluatetype> evaluateTypeInfoList = this.evaluateTypeDao.FindAll();
            foreach (Evaluatetype typePoco in evaluateTypeInfoList)
            {
                Response.Write(typePoco.Name + "</br>");
            }
        }
    }
}