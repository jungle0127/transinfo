using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class UsersPagination
	{
		private Byte m_active;
		public Byte Active
		{
			get { return m_active; }
			set { m_active = value;}
		}
		private String m_username;
		public String Username
		{
			get { return m_username; }
			set { m_username = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private Int64 m_roleid;
		public Int64 Roleid
		{
			get { return m_roleid; }
			set { m_roleid = value;}
		}
		private String m_loginname;
		public String Loginname
		{
			get { return m_loginname; }
			set { m_loginname = value;}
		}
		private String m_note;
		public String Note
		{
			get { return m_note; }
			set { m_note = value;}
		}
		private String m_password;
		public String Password
		{
			get { return m_password; }
			set { m_password = value;}
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
