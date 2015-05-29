using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class VuserroleinfoPagination
	{
		private Int64 m_userid;
		public Int64 Userid
		{
			get { return m_userid; }
			set { m_userid = value;}
		}
		private String m_loginname;
		public String Loginname
		{
			get { return m_loginname; }
			set { m_loginname = value;}
		}
		private String m_username;
		public String Username
		{
			get { return m_username; }
			set { m_username = value;}
		}
		private Int64 m_roleid;
		public Int64 Roleid
		{
			get { return m_roleid; }
			set { m_roleid = value;}
		}
		private String m_rolename;
		public String Rolename
		{
			get { return m_rolename; }
			set { m_rolename = value;}
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
