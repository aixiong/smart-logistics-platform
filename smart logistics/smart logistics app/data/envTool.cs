using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace smart_logistics_app.data
{
	class envTool: sqlTool
	{
		private string centerName;
		private double workTime;
		private double loadTime;
		public envTool(string filename):base(filename)
		{
		}
		
		public void replaceEnv(string name,double wTime,double lTime)
		{
			centerName = name;
			workTime = wTime;
			loadTime = lTime;
			string str = str = "replace into environment (index, centerName, workTime, loadTime) values (1 + '" + centerName + "', " + workTime + ", " + loadTime + ")";
			excuteCommand(str);
		}

		public void querySql()
		{
			SQLiteCommand cmd = new SQLiteCommand(m_con);
            cmd.CommandText = "select * from environment";
			SQLiteDataReader dr = cmd.ExecuteReader();
			StringBuilder sb = new StringBuilder();
			if(dr.Read())
			{
				centerName = dr.GetString(1);
				workTime = dr.GetDouble(2);
				loadTime = dr.GetDouble(3);
			}
		}

		public string getAddress()
		{
			querySql();
			return centerName;
		}

		public double getWorkTime()
		{
			querySql();
			return workTime;
		}

		public double getLoadTime()
		{
			querySql();
			return loadTime;
		}
	}
}
