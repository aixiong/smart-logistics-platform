using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace smart_logistics_app.data
{
	class boxTool:sqlTool
	{
		public boxTool(string filename):base(filename)
		{

		}

		public List<box> getBoxes()
		{
			List<box> boxes = new List<box>();
			SQLiteCommand cmd = new SQLiteCommand(m_con);
			cmd.CommandText = "select * from box";
			SQLiteDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				box one = new box();
				one.name = dr.GetString(0);
				one.length = dr.GetDouble(1);
				one.width = dr.GetDouble(2);
				one.height = dr.GetDouble(3);
				one.volume = dr.GetDouble(4);
				boxes.Add(one);
			}
			return boxes;
		}

		public double getBoxVol(string name)
		{
			SQLiteCommand cmd = new SQLiteCommand(m_con);
			cmd.CommandText = "select * from box where name = '"+name+"'";
			SQLiteDataReader dr = cmd.ExecuteReader();
			double res = 0;
			if(dr.Read())
			{
				res = dr.GetDouble(4);
			}
			return res;
		}

		public void updateBoxes(List<box> boxes)
		{
			foreach (var b in boxes)
			{
				b.volume = b.length * b.width * b.height/1000000;
				string str = str = "replace into box (name, length, width, height, volume) values ('" + b.name + "', " + b.length + ", " + b.width + ", " + b.height + ", " + b.volume+  ")";
				excuteCommand(str);
			}
		}

		public void removeBox(string source)
		{
			string str = "delete from box where name = '" + source + "'";
			excuteCommand(str);
		}
	}

	class box
	{
		public string name;
		public double length;
		public double width;
		public double height;
		public double volume;

		public box Clone()
		{
			box one = new box();
			one.name = name.Clone().ToString();
			one.length = length;
			one.width = width;
			one.height = height;
			one.volume = volume;
			return one;
		}
	}
}
