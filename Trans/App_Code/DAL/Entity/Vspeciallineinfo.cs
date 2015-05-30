using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Vspeciallineinfo
	{
		private DateTime m_releasedate;
		public DateTime Releasedate
		{
			get { return m_releasedate; }
			set { m_releasedate = value;}
		}
		private String m_speciallinetypename;
		public String Speciallinetypename
		{
			get { return m_speciallinetypename; }
			set { m_speciallinetypename = value;}
		}
		private String m_srccontactpersonname;
		public String Srccontactpersonname
		{
			get { return m_srccontactpersonname; }
			set { m_srccontactpersonname = value;}
		}
		private String m_description;
		public String Description
		{
			get { return m_description; }
			set { m_description = value;}
		}
		private Int64 m_userid;
		public Int64 Userid
		{
			get { return m_userid; }
			set { m_userid = value;}
		}
		private String m_srccontactphone;
		public String Srccontactphone
		{
			get { return m_srccontactphone; }
			set { m_srccontactphone = value;}
		}
		private Int32 m_volumeprice;
		public Int32 Volumeprice
		{
			get { return m_volumeprice; }
			set { m_volumeprice = value;}
		}
		private String m_dstcontactpersonname;
		public String Dstcontactpersonname
		{
			get { return m_dstcontactpersonname; }
			set { m_dstcontactpersonname = value;}
		}
		private String m_srcplaceaddress;
		public String Srcplaceaddress
		{
			get { return m_srcplaceaddress; }
			set { m_srcplaceaddress = value;}
		}
		private Int32 m_weightprice;
		public Int32 Weightprice
		{
			get { return m_weightprice; }
			set { m_weightprice = value;}
		}
		private String m_srccontactcellphone;
		public String Srccontactcellphone
		{
			get { return m_srccontactcellphone; }
			set { m_srccontactcellphone = value;}
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
		private String m_dstcontactphone;
		public String Dstcontactphone
		{
			get { return m_dstcontactphone; }
			set { m_dstcontactphone = value;}
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
		private String m_departuretypename;
		public String Departuretypename
		{
			get { return m_departuretypename; }
			set { m_departuretypename = value;}
		}
		private String m_dstplaceaddress;
		public String Dstplaceaddress
		{
			get { return m_dstplaceaddress; }
			set { m_dstplaceaddress = value;}
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
		private String m_title;
		public String Title
		{
			get { return m_title; }
			set { m_title = value;}
		}
		private String m_dstcontactcellphone;
		public String Dstcontactcellphone
		{
			get { return m_dstcontactcellphone; }
			set { m_dstcontactcellphone = value;}
		}
		private String m_username;
		public String Username
		{
			get { return m_username; }
			set { m_username = value;}
		}
	}
}
