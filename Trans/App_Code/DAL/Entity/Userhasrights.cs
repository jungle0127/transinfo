using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Userhasrights
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
		private Int64 m_rightid;
		public Int64 Rightid
		{
			get { return m_rightid; }
			set { m_rightid = value;}
		}
		private Byte m_acitve;
		public Byte Acitve
		{
			get { return m_acitve; }
			set { m_acitve = value;}
		}
	}
}
