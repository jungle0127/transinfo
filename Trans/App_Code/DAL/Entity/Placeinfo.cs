using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Placeinfo
	{
		private String m_address;
		public String Address
		{
			get { return m_address; }
			set { m_address = value;}
		}
		private String m_contactpersonname;
		public String Contactpersonname
		{
			get { return m_contactpersonname; }
			set { m_contactpersonname = value;}
		}
		private String m_contactphone;
		public String Contactphone
		{
			get { return m_contactphone; }
			set { m_contactphone = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private String m_contactcellphone;
		public String Contactcellphone
		{
			get { return m_contactcellphone; }
			set { m_contactcellphone = value;}
		}
		private String m_countycode;
		public String Countycode
		{
			get { return m_countycode; }
			set { m_countycode = value;}
		}
	}
}
