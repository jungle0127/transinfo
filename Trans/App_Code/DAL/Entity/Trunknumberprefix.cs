using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Trunknumberprefix
	{
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
	}
}
