using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using smart_logistics_app.map;
using System.Data.SQLite;

namespace smart_logistics_app.data
{
	
	public class addrSql:sqlTool
	{
		public addrSql(string filename):base(filename)
		{
		}
		public void insertAddress(address addr,markerType type)
		{
			string str = "";
			if(type==markerType.source)
				str = "insert into send (name, lat, lon) values ('" + addr.name+ "', " + addr.pos.Lat + ", " + addr.pos.Lng + ")";
			else
				str = "insert into recv (name, lat, lon) values ('" + addr.name + "', " + addr.pos.Lat + ", " + addr.pos.Lng + ")";
			excuteCommand(str);
		}
		public void deleteAddress(address addr,markerType type)
		{
			string str = "";
			if(type==markerType.source)
				str = "delete from send where name=" + "'" + addr.name + "'";
			else
				str = "delete from recv where name=" + "'" + addr.name + "'";
			excuteCommand(str);
		}
		public List<address> getAllAddress(markerType type)
		{
			List<address> li = new List<address>();
			SQLiteCommand cmd = new SQLiteCommand(m_con);
			if (type == markerType.source)
				cmd.CommandText = "select * from send";
			else
				cmd.CommandText = "select * from recv";
			SQLiteDataReader dr = cmd.ExecuteReader();
			StringBuilder sb = new StringBuilder();
			while (dr.Read())
			{
				address one = new address();
				one.name = dr.GetString(0);
				one.pos.Lat = dr.GetDouble(1);
				one.pos.Lng = dr.GetDouble(2);
				li.Add(one);
			}
			return li;
		}
	}
}