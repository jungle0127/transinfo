using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Vgoodssourceinformation
	{
		private String m_goodstypename;
		public String Goodstypename
		{
			get { return m_goodstypename; }
			set { m_goodstypename = value;}
		}
		private Int64 m_goodstypeid;
		public Int64 Goodstypeid
		{
			get { return m_goodstypeid; }
			set { m_goodstypeid = value;}
		}
		private DateTime m_deadline;
		public DateTime Deadline
		{
			get { return m_deadline; }
			set { m_deadline = value;}
		}
		private Int64 m_needtrunkweight;
		public Int64 Needtrunkweight
		{
			get { return m_needtrunkweight; }
			set { m_needtrunkweight = value;}
		}
		private String m_transporttypename;
		public String Transporttypename
		{
			get { return m_transporttypename; }
			set { m_transporttypename = value;}
		}
		private String m_cautiontypename;
		public String Cautiontypename
		{
			get { return m_cautiontypename; }
			set { m_cautiontypename = value;}
		}
		private Int64 m_needtrunklength;
		public Int64 Needtrunklength
		{
			get { return m_needtrunklength; }
			set { m_needtrunklength = value;}
		}
		private String m_price;
		public String Price
		{
			get { return m_price; }
			set { m_price = value;}
		}
		private String m_goodsname;
		public String Goodsname
		{
			get { return m_goodsname; }
			set { m_goodsname = value;}
		}
		private String m_srccityname;
		public String Srccityname
		{
			get { return m_srccityname; }
			set { m_srccityname = value;}
		}
		private String m_srccitycode;
		public String Srccitycode
		{
			get { return m_srccitycode; }
			set { m_srccitycode = value;}
		}
		private String m_srcregionname;
		public String Srcregionname
		{
			get { return m_srcregionname; }
			set { m_srcregionname = value;}
		}
		private String m_content;
		public String Content
		{
			get { return m_content; }
			set { m_content = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private String m_dstregionname;
		public String Dstregionname
		{
			get { return m_dstregionname; }
			set { m_dstregionname = value;}
		}
		private Int64 m_needtrunkvolume;
		public Int64 Needtrunkvolume
		{
			get { return m_needtrunkvolume; }
			set { m_needtrunkvolume = value;}
		}
		private DateTime m_releasedate;
		public DateTime Releasedate
		{
			get { return m_releasedate; }
			set { m_releasedate = value;}
		}
		private String m_dstcityname;
		public String Dstcityname
		{
			get { return m_dstcityname; }
			set { m_dstcityname = value;}
		}
		private String m_dstcitycode;
		public String Dstcitycode
		{
			get { return m_dstcitycode; }
			set { m_dstcitycode = value;}
		}
		private String m_title;
		public String Title
		{
			get { return m_title; }
			set { m_title = value;}
		}
		private String m_titlecolor;
		public String Titlecolor
		{
			get { return m_titlecolor; }
			set { m_titlecolor = value;}
		}
		private String m_username;
		public String Username
		{
			get { return m_username; }
			set { m_username = value;}
		}
	}
}
