using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Trunknumber
	{
		private String m_number;
		public String Number
		{
			get { return m_number; }
			set { m_number = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private Int64 m_userid;
		public Int64 Userid
		{
			get { return m_userid; }
			set { m_userid = value;}
		}
		private Int64 m_prefixid;
		public Int64 Prefixid
		{
			get { return m_prefixid; }
			set { m_prefixid = value;}
		}
		private Byte m_active;
		public Byte Active
		{
			get { return m_active; }
			set { m_active = value;}
		}
	}
}
