using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class SpeciallineinfoPagination
	{
		private Int64 m_userid;
		public Int64 Userid
		{
			get { return m_userid; }
			set { m_userid = value;}
		}
		private Int64 m_destinationplaceinfoid;
		public Int64 Destinationplaceinfoid
		{
			get { return m_destinationplaceinfoid; }
			set { m_destinationplaceinfoid = value;}
		}
		private Int64 m_departuretypeid;
		public Int64 Departuretypeid
		{
			get { return m_departuretypeid; }
			set { m_departuretypeid = value;}
		}
		private String m_title;
		public String Title
		{
			get { return m_title; }
			set { m_title = value;}
		}
		private Int32 m_volumeprice;
		public Int32 Volumeprice
		{
			get { return m_volumeprice; }
			set { m_volumeprice = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private Int32 m_weightprice;
		public Int32 Weightprice
		{
			get { return m_weightprice; }
			set { m_weightprice = value;}
		}
		private String m_description;
		public String Description
		{
			get { return m_description; }
			set { m_description = value;}
		}
		private Int64 m_sourceplaceinfoid;
		public Int64 Sourceplaceinfoid
		{
			get { return m_sourceplaceinfoid; }
			set { m_sourceplaceinfoid = value;}
		}
		private Int64 m_speciallinetypeid;
		public Int64 Speciallinetypeid
		{
			get { return m_speciallinetypeid; }
			set { m_speciallinetypeid = value;}
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
