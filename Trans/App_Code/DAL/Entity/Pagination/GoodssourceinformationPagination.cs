using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class GoodssourceinformationPagination
	{
		private Int64 m_cautiontypeid;
		public Int64 Cautiontypeid
		{
			get { return m_cautiontypeid; }
			set { m_cautiontypeid = value;}
		}
		private Byte m_active;
		public Byte Active
		{
			get { return m_active; }
			set { m_active = value;}
		}
		private DateTime m_deadline;
		public DateTime Deadline
		{
			get { return m_deadline; }
			set { m_deadline = value;}
		}
		private String m_srccountycode;
		public String Srccountycode
		{
			get { return m_srccountycode; }
			set { m_srccountycode = value;}
		}
		private DateTime m_releasedate;
		public DateTime Releasedate
		{
			get { return m_releasedate; }
			set { m_releasedate = value;}
		}
		private Int64 m_userid;
		public Int64 Userid
		{
			get { return m_userid; }
			set { m_userid = value;}
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
		private String m_title;
		public String Title
		{
			get { return m_title; }
			set { m_title = value;}
		}
		private Int64 m_transporttypeid;
		public Int64 Transporttypeid
		{
			get { return m_transporttypeid; }
			set { m_transporttypeid = value;}
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
		private String m_dstcountycode;
		public String Dstcountycode
		{
			get { return m_dstcountycode; }
			set { m_dstcountycode = value;}
		}
		private Int64 m_goodstypeid;
		public Int64 Goodstypeid
		{
			get { return m_goodstypeid; }
			set { m_goodstypeid = value;}
		}
		private String m_titlecolor;
		public String Titlecolor
		{
			get { return m_titlecolor; }
			set { m_titlecolor = value;}
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
