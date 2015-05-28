using System;
using System.Collections.Generic; 
using System.Text;
namespace Trans.DAL.Entity 
{
	[Serializable]
	public class DepotinformationPagination
	{
		private String m_cellphone;
		public String Cellphone
		{
			get { return m_cellphone; }
			set { m_cellphone = value;}
		}
		private String m_validtime;
		public String Validtime
		{
			get { return m_validtime; }
			set { m_validtime = value;}
		}
		private String m_contactperson;
		public String Contactperson
		{
			get { return m_contactperson; }
			set { m_contactperson = value;}
		}
		private Int64 m_userid;
		public Int64 Userid
		{
			get { return m_userid; }
			set { m_userid = value;}
		}
		private Int32 m_useablearea;
		public Int32 Useablearea
		{
			get { return m_useablearea; }
			set { m_useablearea = value;}
		}
		private String m_price;
		public String Price
		{
			get { return m_price; }
			set { m_price = value;}
		}
		private Int64 m_depottype;
		public Int64 Depottype
		{
			get { return m_depottype; }
			set { m_depottype = value;}
		}
		private Int64 m_bizscopetype;
		public Int64 Bizscopetype
		{
			get { return m_bizscopetype; }
			set { m_bizscopetype = value;}
		}
		private String m_title;
		public String Title
		{
			get { return m_title; }
			set { m_title = value;}
		}
		private String m_description;
		public String Description
		{
			get { return m_description; }
			set { m_description = value;}
		}
		private Int64 m_id;
		public Int64 Id
		{
			get { return m_id; }
			set { m_id = value;}
		}
		private String m_address;
		public String Address
		{
			get { return m_address; }
			set { m_address = value;}
		}
		private Int32 m_area;
		public Int32 Area
		{
			get { return m_area; }
			set { m_area = value;}
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
