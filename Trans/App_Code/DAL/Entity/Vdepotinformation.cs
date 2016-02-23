using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Vdepotinformation
	{
		private Int64 m_scopeid;
		public Int64 Scopeid
		{
			get { return m_scopeid; }
			set { m_scopeid = value;}
		}
		private String m_description;
		public String Description
		{
			get { return m_description; }
			set { m_description = value;}
		}
		private String m_validtime;
		public String Validtime
		{
			get { return m_validtime; }
			set { m_validtime = value;}
		}
		private String m_cityname;
		public String Cityname
		{
			get { return m_cityname; }
			set { m_cityname = value;}
		}
		private Int32 m_useablearea;
		public Int32 Useablearea
		{
			get { return m_useablearea; }
			set { m_useablearea = value;}
		}
		private Int64 m_depottypeid;
		public Int64 Depottypeid
		{
			get { return m_depottypeid; }
			set { m_depottypeid = value;}
		}
		private String m_scopename;
		public String Scopename
		{
			get { return m_scopename; }
			set { m_scopename = value;}
		}
		private String m_price;
		public String Price
		{
			get { return m_price; }
			set { m_price = value;}
		}
		private String m_contactperson;
		public String Contactperson
		{
			get { return m_contactperson; }
			set { m_contactperson = value;}
		}
		private String m_title;
		public String Title
		{
			get { return m_title; }
			set { m_title = value;}
		}
		private String m_regionname;
		public String Regionname
		{
			get { return m_regionname; }
			set { m_regionname = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private String m_depottypename;
		public String Depottypename
		{
			get { return m_depottypename; }
			set { m_depottypename = value;}
		}
		private String m_cellphone;
		public String Cellphone
		{
			get { return m_cellphone; }
			set { m_cellphone = value;}
		}
		private String m_address;
		public String Address
		{
			get { return m_address; }
			set { m_address = value;}
		}
		private String m_citycode;
		public String Citycode
		{
			get { return m_citycode; }
			set { m_citycode = value;}
		}
		private Int32 m_area;
		public Int32 Area
		{
			get { return m_area; }
			set { m_area = value;}
		}
		private String m_username;
		public String Username
		{
			get { return m_username; }
			set { m_username = value;}
		}
	}
}
