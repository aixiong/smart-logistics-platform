using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using smart_logistics_app.control;
using smart_logistics_app.data;
using smart_logistics_app.map;
using smart_logistics_app.algo;

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
			//Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new listForm());
			txtTool one = new txtTool(@"D:\logistics data\in.txt");
			one.write("This is input data for logistics algorithm.");
			one.close();
		}
	}
}
