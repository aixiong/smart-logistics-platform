using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace smart_logistics_CSharp_test
{
	class sqlTool
	{
		private string fileName;
		private SQLiteConnection m_con;
		public sqlTool(string fileName)
		{
			this.fileName = fileName;
			m_con = new SQLiteConnection();
			SQLiteConnectionStringBuilder scon = new SQLiteConnectionStringBuilder();
			scon.DataSource = fileName;
			m_con.ConnectionString = scon.ToString();
			m_con.Open();
		}
		private bool excuteCommand(string str)
		{
			try
			{
				SQLiteCommand sc = new SQLiteCommand(str, m_con);
				sc.ExecuteNonQuery();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		public void insertAddress()
		{
			string name = "北京交通大学";
			double lat = 123.22;
			double lon = 54.33;
			string str= "insert into send (name, lat, lon) values ('" + name + "', " +lat + ", " + lon + ")";
			excuteCommand(str);
		}
		//public void insertBase(baseStation one)
		//{
		//	string str = "insert into BaseInfo (name, filename, address) values ('" + one.baseName + "', '" + one.fileName + "', '" + toString(one.baseAddress) + "')";
		//	excuteCommand(str);
		//}
		//public void deleteBase(baseStation one)
		//{
		//	string str = "delete from BaseInfo where name=" + "'" + one.baseName + "'";
		//	excuteCommand(str);
		//}
		//public void insertRegion(region one)
		//{
		//	string str = "insert into RegionInfo (name, address, zoom, p1, p2, p3, p4) values ('" +
		//		one.regionName + "', '" + toString(one.mCenter) + "', '" + one.magnifyRate.ToString() + "', '" +
		//		toString(one.mBorder[0]) + "', '" + toString(one.mBorder[1]) + "', '" +
		//		toString(one.mBorder[2]) + "', '" + toString(one.mBorder[3]) + "')";
		//	excuteCommand(str);
		//}
		//public void deleteRegion(region one)
		//{
		//	string str = "delete from RegionInfo where name=" + "'" + one.regionName + "'";
		//	excuteCommand(str);
		//}
		//public List<baseStation> getBases()
		//{
		//	List<baseStation> li = new List<baseStation>();
		//	SQLiteCommand cmd = new SQLiteCommand(m_con);
		//	cmd.CommandText = "select * from BaseInfo";
		//	SQLiteDataReader dr = cmd.ExecuteReader();
		//	StringBuilder sb = new StringBuilder();
		//	while (dr.Read())
		//	{
		//		baseStation one = new baseStation();
		//		one.baseName = dr.GetString(0);
		//		one.fileName = dr.GetString(1);
		//		one.baseAddress = fromString(dr.GetString(2));
		//		li.Add(one);
		//	}
		//	return li;
		//}
		//public List<region> getRegions()
		//{
		//	List<region> li = new List<region>();
		//	SQLiteCommand cmd = new SQLiteCommand(m_con);
		//	cmd.CommandText = "select * from RegionInfo";
		//	SQLiteDataReader dr = cmd.ExecuteReader();
		//	StringBuilder sb = new StringBuilder();
		//	while (dr.Read())
		//	{
		//		region one = new region();
		//		one.regionName = dr.GetString(0);
		//		one.mCenter = fromString(dr.GetString(1));
		//		one.magnifyRate = dr.GetString(2);
		//		one.mBorder = new List<PointLatLng>();
		//		one.mBorder.Add(fromString(dr.GetString(3)));
		//		one.mBorder.Add(fromString(dr.GetString(4)));
		//		one.mBorder.Add(fromString(dr.GetString(5)));
		//		one.mBorder.Add(fromString(dr.GetString(6)));
		//		li.Add(one);
		//	}
		//	return li;
		//}
		//private bool excuteCommand(string str)
		//{
		//	try
		//	{
		//		SQLiteCommand sc = new SQLiteCommand(str, m_con);
		//		sc.ExecuteNonQuery();
		//		return true;
		//	}
		//	catch (Exception)
		//	{
		//		return false;
		//	}
		//}
		//private PointLatLng fromString(string str)
		//{
		//	PointLatLng point = new PointLatLng();
		//	string[] strs = str.Split(',');
		//	point.Lat = Convert.ToDouble(strs[0]);
		//	point.Lng = Convert.ToDouble(strs[1]);
		//	return point;
		//}
		//private string toString(PointLatLng point)
		//{
		//	return point.Lat.ToString() + "," + point.Lng.ToString();
		//}
	}
}