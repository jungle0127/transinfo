using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class City
	{
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
		private String m_provincecode;
		public String Provincecode
		{
			get { return m_provincecode; }
			set { m_provincecode = value;}
		}
		private String m_name;
		public String Name
		{
			get { return m_name; }
			set { m_name = value;}
		}
	}
}
