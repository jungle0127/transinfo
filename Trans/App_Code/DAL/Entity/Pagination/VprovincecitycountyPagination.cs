using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class VprovincecitycountyPagination
	{
		private String m_fullname;
		public String Fullname
		{
			get { return m_fullname; }
			set { m_fullname = value;}
		}
		private String m_cityname;
		public String Cityname
		{
			get { return m_cityname; }
			set { m_cityname = value;}
		}
		private String m_provincecode;
		public String Provincecode
		{
			get { return m_provincecode; }
			set { m_provincecode = value;}
		}
		private String m_citycode;
		public String Citycode
		{
			get { return m_citycode; }
			set { m_citycode = value;}
		}
		private String m_countyname;
		public String Countyname
		{
			get { return m_countyname; }
			set { m_countyname = value;}
		}
		private String m_provincename;
		public String Provincename
		{
			get { return m_provincename; }
			set { m_provincename = value;}
		}
		private String m_countycode;
		public String Countycode
		{
			get { return m_countycode; }
			set { m_countycode = value;}
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
