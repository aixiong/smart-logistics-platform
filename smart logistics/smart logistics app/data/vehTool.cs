using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace smart_logistics_app.data
{
	class vehTool:sqlTool
	{
		public vehTool(string fileName):base(fileName)
		{

		}

		public List<Veh> GetVehs()
		{
			List<Veh> vehs = new List<Veh>();
			SQLiteCommand cmd = new SQLiteCommand(m_con);
			cmd.CommandText = "select * from vehicle";
			SQLiteDataReader dr = cmd.ExecuteReader();
			while(dr.Read())
			{
				Veh one= new Veh();
				one.name = dr.GetString(0);
				one.distance = dr.GetDouble(1);
				one.speed = dr.GetDouble(2);
				one.cost = dr.GetDouble(3);
				one.capacity = dr.GetDouble(4);
				one.number = dr.GetInt32(5);
				vehs.Add(one);
			}
			return vehs;
		}

		public void UpdateVehs(List<Veh> vehs)
		{
			foreach (var c in vehs)
			{
				string str = str = "replace into vehicle (name, distance, speed, cost, capacity, number) values ('" + c.name + "', " + c.distance + ", " + c.speed+", "+c.cost+", "+c.capacity+", "+c.number + ")";
				excuteCommand(str);
			}
		}
	}
	class Veh
	{
		public string name;
		public double distance;
		public double speed;
		public double cost;
		public double capacity;
		public int number;
		public Veh Clone()
		{
			Veh one = new Veh();
			one.name = name.Clone().ToString();
			one.distance = distance;
			one.speed = speed;
			one.cost = cost;
			one.capacity = capacity;
			one.number = number;
			return one;
		}
	}


}
