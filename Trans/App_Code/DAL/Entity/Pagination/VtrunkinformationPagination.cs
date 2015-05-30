using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class VtrunkinformationPagination
	{
		private String m_vantypename;
		public String Vantypename
		{
			get { return m_vantypename; }
			set { m_vantypename = value;}
		}
		private String m_trunktypename;
		public String Trunktypename
		{
			get { return m_trunktypename; }
			set { m_trunktypename = value;}
		}
		private String m_dstregionname;
		public String Dstregionname
		{
			get { return m_dstregionname; }
			set { m_dstregionname = value;}
		}
		private String m_volume;
		public String Volume
		{
			get { return m_volume; }
			set { m_volume = value;}
		}
		private String m_number;
		public String Number
		{
			get { return m_number; }
			set { m_number = value;}
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
		private String m_conatactphone;
		public String Conatactphone
		{
			get { return m_conatactphone; }
			set { m_conatactphone = value;}
		}
		private String m_contactpersonname;
		public String Contactpersonname
		{
			get { return m_contactpersonname; }
			set { m_contactpersonname = value;}
		}
		private String m_location;
		public String Location
		{
			get { return m_location; }
			set { m_location = value;}
		}
		private String m_srccityname;
		public String Srccityname
		{
			get { return m_srccityname; }
			set { m_srccityname = value;}
		}
		private String m_srccitycode;
		public String Srccitycode
		{
			get { return m_srccitycode; }
			set { m_srccitycode = value;}
		}
		private String m_srcregionname;
		public String Srcregionname
		{
			get { return m_srcregionname; }
			set { m_srcregionname = value;}
		}
		private String m_weightcapacity;
		public String Weightcapacity
		{
			get { return m_weightcapacity; }
			set { m_weightcapacity = value;}
		}
		private String m_trunkcountyname;
		public String Trunkcountyname
		{
			get { return m_trunkcountyname; }
			set { m_trunkcountyname = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private String m_prefixname;
		public String Prefixname
		{
			get { return m_prefixname; }
			set { m_prefixname = value;}
		}
		private String m_vanimageuri;
		public String Vanimageuri
		{
			get { return m_vanimageuri; }
			set { m_vanimageuri = value;}
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
		private String m_dstcityname;
		public String Dstcityname
		{
			get { return m_dstcityname; }
			set { m_dstcityname = value;}
		}
		private String m_dstcitycode;
		public String Dstcitycode
		{
			get { return m_dstcitycode; }
			set { m_dstcitycode = value;}
		}
		private String m_routetype;
		public String Routetype
		{
			get { return m_routetype; }
			set { m_routetype = value;}
		}
		private String m_username;
		public String Username
		{
			get { return m_username; }
			set { m_username = value;}
		}
		private Int32 m_limit;
		public Int32 Limit
		{
			get { return m_limit; }
			set { m_limit = value;}
		}
		private Int32 m_offset;
		public Int32 Offset
		{
			get { return m_offset; }
			set { m_offset = value;}
		}
	}
}
