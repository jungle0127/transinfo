using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class VtrunkinformationPagination
	{
		private DateTime m_takeofftime;
		public DateTime Takeofftime
		{
			get { return m_takeofftime; }
			set { m_takeofftime = value;}
		}
		private String m_licenseuri;
		public String Licenseuri
		{
			get { return m_licenseuri; }
			set { m_licenseuri = value;}
		}
		private String m_srcregionname;
		public String Srcregionname
		{
			get { return m_srcregionname; }
			set { m_srcregionname = value;}
		}
		private String m_title;
		public String Title
		{
			get { return m_title; }
			set { m_title = value;}
		}
		private String m_trunktypename;
		public String Trunktypename
		{
			get { return m_trunktypename; }
			set { m_trunktypename = value;}
		}
		private DateTime m_releasedate;
		public DateTime Releasedate
		{
			get { return m_releasedate; }
			set { m_releasedate = value;}
		}
		private String m_dstcityname;
		public String Dstcityname
		{
			get { return m_dstcityname; }
			set { m_dstcityname = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private String m_dstregionname;
		public String Dstregionname
		{
			get { return m_dstregionname; }
			set { m_dstregionname = value;}
		}
		private String m_trunkcountyname;
		public String Trunkcountyname
		{
			get { return m_trunkcountyname; }
			set { m_trunkcountyname = value;}
		}
		private String m_conatactphone;
		public String Conatactphone
		{
			get { return m_conatactphone; }
			set { m_conatactphone = value;}
		}
		private String m_vanimageuri;
		public String Vanimageuri
		{
			get { return m_vanimageuri; }
			set { m_vanimageuri = value;}
		}
		private Int64 m_trunktypeid;
		public Int64 Trunktypeid
		{
			get { return m_trunktypeid; }
			set { m_trunktypeid = value;}
		}
		private String m_prefixname;
		public String Prefixname
		{
			get { return m_prefixname; }
			set { m_prefixname = value;}
		}
		private Int32 m_length;
		public Int32 Length
		{
			get { return m_length; }
			set { m_length = value;}
		}
        private Int32 m_lengthlow;
        public Int32 Lengthlow
        {
            get { return m_lengthlow; }
            set { m_lengthlow = value; }
        }
        private Int32 m_lengthhigh;
        public Int32 Lengthhigh
        {
            get { return m_lengthhigh; }
            set { m_lengthhigh = value; }
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
		private String m_trunkidentifynumber;
		public String Trunkidentifynumber
		{
			get { return m_trunkidentifynumber; }
			set { m_trunkidentifynumber = value;}
		}
		private String m_vantypename;
		public String Vantypename
		{
			get { return m_vantypename; }
			set { m_vantypename = value;}
		}
		private Int32 m_weightcapacity;
		public Int32 Weightcapacity
		{
			get { return m_weightcapacity; }
			set { m_weightcapacity = value;}
		}
        private Int32 m_weightlow;
        public Int32 Weightlow
        {
            get { return m_weightlow; }
            set { m_weightlow = value; }
        }
        private Int32 m_weighthigh;
        public Int32 Weighthigh
        {
            get { return m_weighthigh; }
            set { m_weighthigh = value; }
        }
		private Int64 m_vantypeid;
		public Int64 Vantypeid
		{
			get { return m_vantypeid; }
			set { m_vantypeid = value;}
		}
		private String m_number;
		public String Number
		{
			get { return m_number; }
			set { m_number = value;}
		}
		private String m_dstcitycode;
		public String Dstcitycode
		{
			get { return m_dstcitycode; }
			set { m_dstcitycode = value;}
		}
		private Int32 m_volume;
		public Int32 Volume
		{
			get { return m_volume; }
			set { m_volume = value;}
		}
		private String m_contactpersonname;
		public String Contactpersonname
		{
			get { return m_contactpersonname; }
			set { m_contactpersonname = value;}
		}
		private String m_brand;
		public String Brand
		{
			get { return m_brand; }
			set { m_brand = value;}
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
		private String m_location;
		public String Location
		{
			get { return m_location; }
			set { m_location = value;}
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
