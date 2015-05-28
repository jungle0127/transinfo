using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class TrunkinformationPagination
	{
		private String m_router;
		public String Router
		{
			get { return m_router; }
			set { m_router = value;}
		}
		private Int64 m_trunkid;
		public Int64 Trunkid
		{
			get { return m_trunkid; }
			set { m_trunkid = value;}
		}
		private String m_marketprice;
		public String Marketprice
		{
			get { return m_marketprice; }
			set { m_marketprice = value;}
		}
		private Int64 m_timetypeid;
		public Int64 Timetypeid
		{
			get { return m_timetypeid; }
			set { m_timetypeid = value;}
		}
		private DateTime m_takeofftime;
		public DateTime Takeofftime
		{
			get { return m_takeofftime; }
			set { m_takeofftime = value;}
		}
		private String m_srccountycode;
		public String Srccountycode
		{
			get { return m_srccountycode; }
			set { m_srccountycode = value;}
		}
		private String m_description;
		public String Description
		{
			get { return m_description; }
			set { m_description = value;}
		}
		private Int64 m_userid;
		public Int64 Userid
		{
			get { return m_userid; }
			set { m_userid = value;}
		}
		private String m_negotiateprice;
		public String Negotiateprice
		{
			get { return m_negotiateprice; }
			set { m_negotiateprice = value;}
		}
		private Int64 m_returntypeid;
		public Int64 Returntypeid
		{
			get { return m_returntypeid; }
			set { m_returntypeid = value;}
		}
		private Byte m_active;
		public Byte Active
		{
			get { return m_active; }
			set { m_active = value;}
		}
		private String m_title;
		public String Title
		{
			get { return m_title; }
			set { m_title = value;}
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
		private DateTime m_releasedate;
		public DateTime Releasedate
		{
			get { return m_releasedate; }
			set { m_releasedate = value;}
		}
		private Int64 m_routetypeid;
		public Int64 Routetypeid
		{
			get { return m_routetypeid; }
			set { m_routetypeid = value;}
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
