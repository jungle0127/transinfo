using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Trunktimetype
	{
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private String m_typename;
		public String Typename
		{
			get { return m_typename; }
			set { m_typename = value;}
		}
	}
}
