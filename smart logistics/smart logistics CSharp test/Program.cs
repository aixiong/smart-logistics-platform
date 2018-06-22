using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace smart_logistics_CSharp_test
{
	
	class Program
	{
		static void Main(string[] args)
		{
			int num = 0;
			while(true)
			{
				string str = Console.ReadLine();
				if (str == "0") break;
				point one = geoInfo.getPointByName(str);
				Console.WriteLine(one.lat.ToString() + " " + one.lon.ToString() + "\n");
				if (one.lat == 0) ++num;
			}
			Console.WriteLine(num);
			Console.ReadKey();
			Console.ReadKey();
		}
	}
}
