using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Trunkmetadata
	{
		private String m_conatactphone;
		public String Conatactphone
		{
			get { return m_conatactphone; }
			set { m_conatactphone = value;}
		}
		private String m_volume;
		public String Volume
		{
			get { return m_volume; }
			set { m_volume = value;}
		}
		private Int64 m_numberid;
		public Int64 Numberid
		{
			get { return m_numberid; }
			set { m_numberid = value;}
		}
		private String m_brand;
		public String Brand
		{
			get { return m_brand; }
			set { m_brand = value;}
		}
		private String m_length;
		public String Length
		{
			get { return m_length; }
			set { m_length = value;}
		}
		private Int64 m_trunktypeid;
		public Int64 Trunktypeid
		{
			get { return m_trunktypeid; }
			set { m_trunktypeid = value;}
		}
		private String m_contactpersonname;
		public String Contactpersonname
		{
			get { return m_contactpersonname; }
			set { m_contactpersonname = value;}
		}
		private Byte m_active;
		public Byte Active
		{
			get { return m_active; }
			set { m_active = value;}
		}
		private String m_vanimageuri;
		public String Vanimageuri
		{
			get { return m_vanimageuri; }
			set { m_vanimageuri = value;}
		}
		private String m_weightcapacity;
		public String Weightcapacity
		{
			get { return m_weightcapacity; }
			set { m_weightcapacity = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private Int64 m_vantypeid;
		public Int64 Vantypeid
		{
			get { return m_vantypeid; }
			set { m_vantypeid = value;}
		}
		private String m_licenseuri;
		public String Licenseuri
		{
			get { return m_licenseuri; }
			set { m_licenseuri = value;}
		}
		private String m_trunkidentifynumber;
		public String Trunkidentifynumber
		{
			get { return m_trunkidentifynumber; }
			set { m_trunkidentifynumber = value;}
		}
		private String m_countycode;
		public String Countycode
		{
			get { return m_countycode; }
			set { m_countycode = value;}
		}
		private String m_location;
		public String Location
		{
			get { return m_location; }
			set { m_location = value;}
		}
	}
}
