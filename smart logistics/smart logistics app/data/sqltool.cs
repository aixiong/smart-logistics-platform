using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace smart_logistics_app.data
{
	public class sqlTool
	{
		private string fileName;
		public SQLiteConnection m_con;
		public sqlTool(string fileName)
		{
			this.fileName = fileName;
			m_con = new SQLiteConnection();
			SQLiteConnectionStringBuilder scon = new SQLiteConnectionStringBuilder();
			scon.DataSource = fileName;
			m_con.ConnectionString = scon.ToString();
			m_con.Open();
		}
		public bool excuteCommand(string str)
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
	}
}
