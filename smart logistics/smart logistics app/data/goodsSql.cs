using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using smart_logistics_app.control;

namespace smart_logistics_app.data
{
	class goodsSql : sqlTool
	{
		public goodsSql(string filename) : base(filename)
		{
		}

		public void insertGoods(goods one)
		{
			string str = "insert into global (number, source, dest, arriveTime, deadline, status, objVechicle,finishTime) values ('" 
				+one.number+ "', '"+one.source + "', '" + one.dest + "', '" + one.arriveTime +"', '"+one.deadline + "', '" + one.status + "', '" +one.objVechicle+ "', '"+one.finishTime+ "')";
			excuteCommand(str);
		}

		public void deleteGoods(goods one)
		{
			string str = "delete from global where number =" + "'" + one.number + "'";
			excuteCommand(str);
		}

		public void updateGoods(goods one)
		{
			string str = "update global set  deadline ='" + one.deadline + "', status ='"+one.status + "', objVechicle =" + one.objVechicle + "', finishTime = '" +one.finishTime+ "' where number =" + "'" + one.number + "'";
			excuteCommand(str);
		}

		public List<goods> getAllGoods()
		{
			List<goods> li = new List<goods>();
			SQLiteCommand cmd = new SQLiteCommand(m_con);
			cmd.CommandText = "select * from global";
			SQLiteDataReader dr = cmd.ExecuteReader();
			StringBuilder sb = new StringBuilder();
			while (dr.Read())
			{
				goods one = new goods();
				one.number = dr.GetString(0);
				one.source = dr.GetString(1);
				one.dest= dr.GetString(2);
				one.arriveTime = dr.GetString(3);
				one.deadline = dr.GetString(4);
				one.status = dr.GetString(5);
				one.objVechicle = dr.GetString(6);
				one.finishTime = dr.GetString(7);
				li.Add(one);
			}
			return li;
		}

	}
}
