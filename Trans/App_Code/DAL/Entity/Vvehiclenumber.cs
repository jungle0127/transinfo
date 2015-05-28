using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Vvehiclenumber
	{
		private Int64 m_userid;
		public Int64 Userid
		{
			get { return m_userid; }
			set { m_userid = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private String m_prefixname;
		public String Prefixname
		{
			get { return m_prefixname; }
			set { m_prefixname = value;}
		}
		private String m_number;
		public String Number
		{
			get { return m_number; }
			set { m_number = value;}
		}
	}
}
