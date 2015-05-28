using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Rightgrouphasrights
	{
		private Byte m_active;
		public Byte Active
		{
			get { return m_active; }
			set { m_active = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private Int64 m_rightid;
		public Int64 Rightid
		{
			get { return m_rightid; }
			set { m_rightid = value;}
		}
		private Int64 m_groupid;
		public Int64 Groupid
		{
			get { return m_groupid; }
			set { m_groupid = value;}
		}
	}
}
