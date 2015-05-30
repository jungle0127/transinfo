using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Varticleinfo
	{
		private String m_title;
		public String Title
		{
			get { return m_title; }
			set { m_title = value;}
		}
		private Int64 m_hittimes;
		public Int64 Hittimes
		{
			get { return m_hittimes; }
			set { m_hittimes = value;}
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
		private String m_titlecolor;
		public String Titlecolor
		{
			get { return m_titlecolor; }
			set { m_titlecolor = value;}
		}
		private Int64 m_typeid;
		public Int64 Typeid
		{
			get { return m_typeid; }
			set { m_typeid = value;}
		}
		private String m_content;
		public String Content
		{
			get { return m_content; }
			set { m_content = value;}
		}
		private String m_releaseip;
		public String Releaseip
		{
			get { return m_releaseip; }
			set { m_releaseip = value;}
		}
		private DateTime m_releasedate;
		public DateTime Releasedate
		{
			get { return m_releasedate; }
			set { m_releasedate = value;}
		}
	}
}
