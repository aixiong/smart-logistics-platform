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

		public void insertVech(vech one)
		{
			string str = "insert into detail (typeName, number, status) values ('" + one.typeName+ "', '" + one.number + "', '" + one.status + "')";
			excuteCommand(str);
		}
		public void deleteVechType(vechType one)
		{
			string str = "delete from type where name=" + "'" + one.name + "'";
			excuteCommand(str);
		}

		public void deleteVech(vech one)
		{
			string str = "delete from detail where typename=" + "'" + one.typeName + "' and number ='" + one.number + "'";
			excuteCommand(str);
		}

		public void updateVechType(vechType one)
		{
			string str = "update type set volume=" + one.volume + ", journey=" + one.journey + " where name=" + "'" + one.name + "'";
			excuteCommand(str);
		}

		public void updateVech(vech one)
		{
			string str = "update detail set status ='"+one.status+ "' where typeName=" + "'" + one.typeName + "' and number ='"+one.number+"'";
			excuteCommand(str);
		}

		public List<vechType> getAllVechTypes()
		{
			List<vechType> li = new List<vechType>();
			SQLiteCommand cmd = new SQLiteCommand(m_con);
			cmd.CommandText = "select * from type";
			SQLiteDataReader dr = cmd.ExecuteReader();
			StringBuilder sb = new StringBuilder();
			while (dr.Read())
			{
				vechType one = new vechType();
				one.name = dr.GetString(0);
				one.volume = dr.GetDouble(1);
				one.journey = dr.GetDouble(2);
				li.Add(one);
			}
			return li;
		}

		public List<vech> getAllVechs()
		{
			List<vech> li = new List<vech>();
			SQLiteCommand cmd = new SQLiteCommand(m_con);
			cmd.CommandText = "select * from detail";
			SQLiteDataReader dr = cmd.ExecuteReader();
			StringBuilder sb = new StringBuilder();
			while (dr.Read())
			{
				vech one = new vech();
				one.typeName = dr.GetString(0);
				one.number = dr.GetString(1);
				one.status = dr.GetString(2);
				li.Add(one);
			}
			return li;
		}

		public List<string> getAllVechName()
		{
			List<string> li = new List<string>();
			SQLiteCommand cmd = new SQLiteCommand(m_con);
			cmd.CommandText = "select * from detail";
			SQLiteDataReader dr = cmd.ExecuteReader();
			StringBuilder sb = new StringBuilder();
			while (dr.Read())
			{
				string one = "";
				one += dr.GetString(0);
				one += "(";
				one += dr.GetString(1);
				one += ")";
				li.Add(one);
			}
			return li;
		}
	}
}
