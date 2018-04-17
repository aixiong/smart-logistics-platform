using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using smart_logistics_app.control;

namespace smart_logistics_app.data
{
	class vechSql:sqlTool
	{
		public vechSql(string filename):base(filename)
		{
		}

		public void insertVechType(vechType one)
		{
			string str = "insert into type (name, volume, journey) values ('" +one.name + "', " + one.volume + ", " + one.journey + ")";
			excuteCommand(str);
		}
		public void deleteVechType(vechType one)
		{

		}

		public void modifyVechType(vechType source,vechType dest)
		{

		}

		public List<vechType> getAllVechTypes()
		{
			List<vechType> li = new List<vechType>();

			return li;
		}
		public void insertAddress(address addr, markerType type)
		{
			string str = "";
			if (type == markerType.source)
				str = "insert into send (name, lat, lon) values ('" + addr.name + "', " + addr.pos.Lat + ", " + addr.pos.Lng + ")";
			else
				str = "insert into recv (name, lat, lon) values ('" + addr.name + "', " + addr.pos.Lat + ", " + addr.pos.Lng + ")";
			excuteCommand(str);
		}
		public void deleteAddress(address addr, markerType type)
		{
			string str = "";
			if (type == markerType.source)
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
