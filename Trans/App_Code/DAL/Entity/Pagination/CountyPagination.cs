using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class CountyPagination
	{
		private String m_citycode;
		public String Citycode
		{
			get { return m_citycode; }
			set { m_citycode = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private String m_code;
		public String Code
		{
			get { return m_code; }
			set { m_code = value;}
		}
		private String m_name;
		public String Name
		{
			get { return m_name; }
			set { m_name = value;}
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
