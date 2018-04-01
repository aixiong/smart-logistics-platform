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
			point p1 = geoInfo.getPointByName("北京师范大学");
			point p2 = geoInfo.getPointByName("北京航天航空大学");
			route r = geoInfo.getRoute(p1, p2);
			
			Console.ReadKey();
		}
	}
}
