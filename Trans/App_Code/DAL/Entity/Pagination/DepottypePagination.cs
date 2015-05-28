using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class DepottypePagination
	{
		private Byte m_active;
		public Byte Active
		{
			get { return m_active; }
			set { m_active = value;}
		}
		private String m_typename;
		public String Typename
		{
			get { return m_typename; }
			set { m_typename = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
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
