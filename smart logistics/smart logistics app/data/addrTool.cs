using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using GMap.NET;

namespace smart_logistics_app.data
{
	class addrTool:sqlTool
	{
		public addrTool(string filename) : base(filename)
		{
		}

		public void replaceAddress(address addr)
		{
			string str= str = "replace into all_address (name, lat, lon) values ('" + addr.name + "', " + addr.pos.Lat + ", " + addr.pos.Lng + ")";
			excuteCommand(str);
		}

		public PointLatLng anchorTarget(string name)
		{
			SQLiteCommand cmd = new SQLiteCommand(m_con);
			cmd.CommandText = "select * from all_address where name = '"+name+"'";
			SQLiteDataReader dr = cmd.ExecuteReader();
			PointLatLng point = new PointLatLng();
			if (dr.Read())
			{
				point.Lat = dr.GetDouble(1);
				point.Lng = dr.GetDouble(2);
			}
			return point;
		}
		
	}
}
