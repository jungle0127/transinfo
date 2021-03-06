using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class ArticlePagination
	{
		private Int64 m_userid;
		public Int64 Userid
		{
			get { return m_userid; }
			set { m_userid = value;}
		}
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
		private Byte m_istop;
		public Byte Istop
		{
			get { return m_istop; }
			set { m_istop = value;}
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
		private Byte m_ispass;
		public Byte Ispass
		{
			get { return m_ispass; }
			set { m_ispass = value;}
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
