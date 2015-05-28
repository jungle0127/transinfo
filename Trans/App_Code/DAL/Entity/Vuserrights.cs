using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Vuserrights
	{
		private Int64 m_userid;
		public Int64 Userid
		{
			get { return m_userid; }
			set { m_userid = value;}
		}
		private Int64 m_rightid;
		public Int64 Rightid
		{
			get { return m_rightid; }
			set { m_rightid = value;}
		}
		private String m_righturl;
		public String Righturl
		{
			get { return m_righturl; }
			set { m_righturl = value;}
		}
		private String m_groupname;
		public String Groupname
		{
			get { return m_groupname; }
			set { m_groupname = value;}
		}
		private String m_rightname;
		public String Rightname
		{
			get { return m_rightname; }
			set { m_rightname = value;}
		}
	}
}
