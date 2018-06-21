using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;

namespace smart_logistics_app.algo
{
	class InputTool
	{
		private txtTool m_input;
		public InputTool(string filename)
		{
			m_input = new txtTool(filename);
		}

		public void inputInfo(info one)
		{
			string mss = one.ToString();
			m_input.write(one.to_string());
		}
	}

	class info
	{
		public int n, m, k;
		public List<PointLatLng> targets;
		public double Lj, Lx;//endurance distance of Jinbei and Xinnengyuan
		public double Vj, Vx;//volume of Jinbei and Xinnengyuan
		public double Cj, Cx;//cost of one kilometer for Jinbei and Xinnengyuan
		public double Pt, At;//unloading time per target and longest work time per day

		public string to_string()
		{
			string str = n.ToString() + " " + m.ToString() + " " + k.ToString() + "\r\n";
			foreach(var t in targets)
			{
				str += t.ToString();
				str += "\r\n";
			}
			str += Lj.ToString() + " " + Lx.ToString() + "\r\n";
			str += Vj.ToString() + " " + Vx.ToString() + "\r\n";
			str += Cj.ToString() + " " + Cx.ToString() + "\r\n";
			str += Pt.ToString() + " " + At.ToString() + "\r\n";
			return str;
		}
	}
}
