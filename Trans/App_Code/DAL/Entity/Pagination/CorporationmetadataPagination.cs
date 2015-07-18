using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class CorporationmetadataPagination
	{
		private String m_bizcontactperson;
		public String Bizcontactperson
		{
			get { return m_bizcontactperson; }
			set { m_bizcontactperson = value;}
		}
		private String m_postcode;
		public String Postcode
		{
			get { return m_postcode; }
			set { m_postcode = value;}
		}
		private String m_corporationname;
		public String Corporationname
		{
			get { return m_corporationname; }
			set { m_corporationname = value;}
		}
		private Int64 m_userid;
		public Int64 Userid
		{
			get { return m_userid; }
			set { m_userid = value;}
		}
		private String m_logourl;
		public String Logourl
		{
			get { return m_logourl; }
			set { m_logourl = value;}
		}
		private Byte m_active;
		public Byte Active
		{
			get { return m_active; }
			set { m_active = value;}
		}
		private String m_customerQQ;
		public String CustomerQQ
		{
			get { return m_customerQQ; }
			set { m_customerQQ = value;}
		}
		private String m_biztelephone;
		public String Biztelephone
		{
			get { return m_biztelephone; }
			set { m_biztelephone = value;}
		}
		private String m_url;
		public String Url
		{
			get { return m_url; }
			set { m_url = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private String m_address;
		public String Address
		{
			get { return m_address; }
			set { m_address = value;}
		}
		private String m_introduction;
		public String Introduction
		{
			get { return m_introduction; }
			set { m_introduction = value;}
		}
		private String m_customerEmail;
		public String CustomerEmail
		{
			get { return m_customerEmail; }
			set { m_customerEmail = value;}
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
