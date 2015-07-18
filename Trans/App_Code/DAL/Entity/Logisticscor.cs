using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Logisticscor
	{
		private String m_address;
		public String Address
		{
			get { return m_address; }
			set { m_address = value;}
		}
		private Byte m_active;
		public Byte Active
		{
			get { return m_active; }
			set { m_active = value;}
		}
		private String m_licenseurl;
		public String Licenseurl
		{
			get { return m_licenseurl; }
			set { m_licenseurl = value;}
		}
		private String m_corporationname;
		public String Corporationname
		{
			get { return m_corporationname; }
			set { m_corporationname = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private String m_contactperson;
		public String Contactperson
		{
			get { return m_contactperson; }
			set { m_contactperson = value;}
		}
		private Int64 m_userid;
		public Int64 Userid
		{
			get { return m_userid; }
			set { m_userid = value;}
		}
		private String m_telephone;
		public String Telephone
		{
			get { return m_telephone; }
			set { m_telephone = value;}
		}
	}
}
