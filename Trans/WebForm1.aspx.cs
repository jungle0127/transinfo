using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trans.DAL.Dao;
using Trans.DAL.Entity;

namespace Trans
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IVspeciallineinfoDao lineDao = new VspeciallineinfoDao();
            VspeciallineinfoPagination linePoco = new VspeciallineinfoPagination();
            linePoco.Speciallinetypeid = 2;
            IList<Vspeciallineinfo> pocoList = lineDao.DynamicQuery(linePoco);
            foreach (Vspeciallineinfo poco in pocoList)
            {
                Response.Write(poco.Id);
                Response.Write(":");
                Response.Write(poco.Speciallinetypeid);
                Response.Write(":");
                Response.Write(poco.Speciallinetypename);
                Response.Write("<br/>");
            }
        }
    }
}