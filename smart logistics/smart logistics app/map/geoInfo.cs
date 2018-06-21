using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace smart_logistics_app.map
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

	//private const string dllAddr = Environment.CurrentDirectory + "\\smart logistic dll.dll";
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
			p.lat = 0;
			p.lon = 0;
			try
			{
				name = extractAddress(name);
				modifiedPoint mp = new modifiedPoint();
				mp.str = name;
				Task t = Task.Factory.StartNew(delegate { Amap.getPointByName(ref mp); });
				t.Wait(400);
				if (t.IsCompleted)
				{
					p.lat = mp.lat;
					p.lon = mp.lon;
				}
			}
			catch (Exception)
			{
				return p;
			}
			finally
			{
				GC.Collect();
			}
			return p;
		}
		public static route getRoute(point from, point to)
		{
			route r = new route();
			r.duration = r.distance = 0;
			modifiedRoute mr = new modifiedRoute();
			mr.from = from;
			mr.to = to;
			Task t = Task.Factory.StartNew(delegate { Amap.getRoute(ref mr); });
			try
			{
				t.Wait(500);
				if (t.IsCompleted)
				{
					r.distance = mr.distance;
					r.duration = mr.duration;
				}
			}
			catch(Exception)
			{
				return r;
			}
			finally
			{
				GC.Collect();
			}
			return r;
		}

		private static string extractAddress(string name)
		{
			string str = "北京市";
			foreach (var c in name)
			{
				if (c != ' ' && c != '(' && c != ')' && c != ',' && c != '#' && c!='（' && c!='）')
				{
					str += c;
				}
			}
			return str;
		}
	}
}
