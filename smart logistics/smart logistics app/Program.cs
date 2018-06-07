using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using smart_logistics_app.control;
using smart_logistics_app.data;
using smart_logistics_app.map;

namespace smart_logistics_app
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new mapControl());
			//ExcelTool tool = new ExcelTool("D:\\2018.4.6周五分享、中农配送清单.xls");
			//string one=tool.ReadData(1, 1);

		}
	}
}
