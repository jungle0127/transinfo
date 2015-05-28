using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Rights
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
		private String m_righturl;
		public String Righturl
		{
			get { return m_righturl; }
			set { m_righturl = value;}
		}
		private String m_rightname;
		public String Rightname
		{
			get { return m_rightname; }
			set { m_rightname = value;}
		}
	}
}
