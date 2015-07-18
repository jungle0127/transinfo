using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class Corporationhonor
	{
		private Int64 m_corporationid;
		public Int64 Corporationid
		{
			get { return m_corporationid; }
			set { m_corporationid = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private Byte m_active;
		public Byte Active
		{
			get { return m_active; }
			set { m_active = value;}
		}
		private String m_honortitle;
		public String Honortitle
		{
			get { return m_honortitle; }
			set { m_honortitle = value;}
		}
		private String m_honorimageurl;
		public String Honorimageurl
		{
			get { return m_honorimageurl; }
			set { m_honorimageurl = value;}
		}
	}
}
