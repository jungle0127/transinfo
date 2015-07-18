using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class CorporationhonorPagination
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
