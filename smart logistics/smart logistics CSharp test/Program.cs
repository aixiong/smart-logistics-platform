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

			sqlTool one = new sqlTool("D:\\address.sqlite");
			one.insertAddress();
			Console.ReadKey();
		}
	}
}
