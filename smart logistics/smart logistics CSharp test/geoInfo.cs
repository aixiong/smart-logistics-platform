using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace smart_logistics_CSharp_test
{
	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct point
	{
		public double lat, lon;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct modifiedPoint
	{
		public double lat, lon;
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
		public string str;
	}
	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct route
	{
		public double distance, duration;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct modifiedRoute
	{
		public point from, to;
		public double distance;
		public double duration;
	}
	class Amap
	{
		[DllImport("smart logistic dll.dll")]
		public static extern void getPointByName(ref modifiedPoint p);

		[DllImport("smart logistic dll.dll")]
		public static extern void getRoute(ref modifiedRoute r);
	}
	public class geoInfo
	{
		public static point getPointByName(string name)
		{
			point p = new point();
			p.lat = p.lon = 0;
			modifiedPoint mp = new modifiedPoint();
			mp.str = name;
			try
			{
				Task t = Task.Factory.StartNew(delegate { Amap.getPointByName(ref mp); });
				t.Wait(2000);
				if (t.IsCompleted)
				{
					p.lat = mp.lat;
					p.lon = mp.lon;
				}
			}
			catch(Exception )
			{
				return p;
			}
			return p;
		}
		public static route getRoute(point from,point to)
		{
			route r = new route();
			modifiedRoute mr = new modifiedRoute();
			mr.from = from;
			mr.to = to;
			Task t = Task.Factory.StartNew(delegate { Amap.getRoute(ref mr); });
			t.Wait(2000);
			if (t.IsCompleted)
			{
				r.distance = mr.distance;
				r.duration = mr.duration;
			}
			else r.distance = r.duration = -1;
			return r;
		}
	}
}
