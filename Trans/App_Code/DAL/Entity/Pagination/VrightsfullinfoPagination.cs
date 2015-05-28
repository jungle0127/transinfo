using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class VrightsfullinfoPagination
	{
		private String m_groupname;
		public String Groupname
		{
			get { return m_groupname; }
			set { m_groupname = value;}
		}
		private Int64 m_rightId;
		public Int64 RightId
		{
			get { return m_rightId; }
			set { m_rightId = value;}
		}
		private String m_righturl;
		public String Righturl
		{
			get { return m_righturl; }
			set { m_righturl = value;}
		}
		private Int64 m_groupId;
		public Int64 GroupId
		{
			get { return m_groupId; }
			set { m_groupId = value;}
		}
		private String m_rightname;
		public String Rightname
		{
			get { return m_rightname; }
			set { m_rightname = value;}
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
