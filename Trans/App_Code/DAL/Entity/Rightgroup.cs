using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Rightgroup
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
		private String m_groupname;
		public String Groupname
		{
			get { return m_groupname; }
			set { m_groupname = value;}
		}
	}
}
