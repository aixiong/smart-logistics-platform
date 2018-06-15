using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_logistics_app.data
{
	class vehTool:sqlTool
	{
		public vehTool(string fileName):base(fileName)
		{

		}

		public List<Veh> GetVehs()
		{
			List<Veh> vehs = new List<Veh>();

		}

		public void UpdateVehs(List<Veh>)
		{

		}
		class Veh
		{
			string name;
			double distance;
			double speed;
			double cost;
			double capacity;
			int num;
		}

	}


}
