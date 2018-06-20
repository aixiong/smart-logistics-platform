using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using smart_logistics_app.control;

namespace smart_logistics_app.map
{
	public partial class mapControl : Form
	{
		public mapControl(addrAnalyser form)
		{
			InitializeComponent();
			m_form = form;
			initAll();
		}

		private void initAll()
		{
			this.TopLevel = false;
			this.Dock = DockStyle.Fill;
			initMap();
		}
		private void initMap()
		{
			m_map = new GMapControl();
			m_map.Dock = DockStyle.Fill;
			m_map.CacheLocation = Environment.CurrentDirectory + "\\GMapCache\\";
			m_map.MapProvider = AMapProvider.Instance;
			GMapProvider.Language = LanguageType.ChineseSimplified;
			m_map.MinZoom = 6;
			m_map.MaxZoom = 18;
			m_map.Zoom = 10;
			m_map.DragButton = System.Windows.Forms.MouseButtons.Left;
			m_map.Position = new PointLatLng(39.9, 116.378);
			m_map.Overlays.Add(markersOverlay);
			m_map.MouseClick += M_map_MouseClick;
			okButton.Visible = false;
			cacelButton.Visible = false;
			this.Controls.Add(m_map);
			m_map.MouseClick += M_map_MouseClick;
		}

		public void centerAt(address addr)
		{
			addrText.Text = addr.name;
			if(addr.pos.Lat!=0 && addr.pos.Lng!=0)
			{
				addMarker(addr.pos, addr.name,markerType.center);
			}
		}


		GMapMarker oldMarker;
		private void M_map_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if(m_form.addSelected())
				{
					PointLatLng p = m_map.FromLocalToLatLng(e.X, e.Y);
					addMarker(p,addrText.Text,markerType.destination);
					okButton.Visible = true;
					cacelButton.Visible =true;
				}
			}
		}


		

		private void removeMarker(ref GMapMarker marker)
		{
			markersOverlay.Markers.Remove(marker);
			marker = null;
			m_map.Refresh();
		}

		private addrAnalyser m_form;
		private GMapControl m_map;
		private GMapOverlay markersOverlay = new GMapOverlay("markers");

		private MarkerTooltipMode mode = MarkerTooltipMode.OnMouseOver;
		private GMapMarker center;
		private GMapMarker dest;
		private GMapMarker source;

		public void clearMarkers()
		{
			markersOverlay.Markers.Clear();
			center = null;
			dest = null;
			source = null;
			m_map.Refresh();
		}
		public void addMarker(address one)
		{
			if(one.pos.Lat!=0 && one.pos.Lng!=0)
			{
				GMarkerGoogle tmp = new GMarkerGoogle(one.pos, GMarkerGoogleType.green);
				tmp.ToolTipText = one.name;
				tmp.ToolTipMode = mode;
				markersOverlay.Markers.Add(tmp);
			}
		}

		public void addMarker(PointLatLng p, string name, markerType type)
		{
			if(type==markerType.center)
			{
				if (center == null)
				{
					center = new GMarkerGoogle(p, GMarkerGoogleType.green_pushpin);
					center.ToolTipText = name;
					center.ToolTipMode = mode;
					markersOverlay.Markers.Add(center);
				}
				else
				{
					center.Position = p;
					center.ToolTipText = name;
				}
				m_map.Position = center.Position;
			}
			else if(type==markerType.destination)
			{
				if (dest == null)
				{
					dest = new GMarkerGoogle(p, GMarkerGoogleType.blue);
					dest.ToolTipText = name;
					dest.ToolTipMode = mode;
					markersOverlay.Markers.Add(dest);
				}
				else
				{
					dest.Position = p;
					dest.ToolTipText = name;
				}
			}
			else
			{
				if (source == null)
				{
					source = new GMarkerGoogle(p, GMarkerGoogleType.yellow);
					source.ToolTipText = name;
					source.ToolTipMode = mode;
					markersOverlay.Markers.Add(source);
				}
				else
				{
					source.Position = p;
					source.ToolTipText = name;
				}
			}
		}

		private void addrButton_Click(object sender, EventArgs e)
		{
			if (addrText.Text == "") return;
			PointLatLng p = m_form.querySqlite(addrText.Text);
			if (p.Lat != 0 && p.Lng != 0)
			{
				addMarker(p, addrText.Text, markerType.center);
			}
			else
			{
				point p1 = geoInfo.getPointByName(addrText.Text);
				if (p1.lat >= 39 && p1.lat <= 42 && p1.lon >= 115 && p1.lon <= 118)
				{
					m_map.Position = new PointLatLng(p1.lat, p1.lon);
					addMarker(m_map.Position, addrText.Text, markerType.center);
				}
			}

		}

		private void okButton_Click(object sender, EventArgs e)
		{
			m_form.updateAddress(dest.Position);
			okButton.Visible = false;
			cacelButton.Visible = false;
		}

		private void cacelButton_Click(object sender, EventArgs e)
		{
			okButton.Visible = false;
			cacelButton.Visible = false;
			removeMarker(ref dest);
		}

		public void setMarkTooltipMode(MarkerTooltipMode type)
		{
			mode = type;
			foreach (var item in markersOverlay.Markers)
			{
				item.ToolTipMode = mode;
			}
		}

		
	}
}
