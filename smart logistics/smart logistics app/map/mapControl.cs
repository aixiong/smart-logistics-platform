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
		//public mapControl(addrAnalyser form)
		//{
		//	InitializeComponent();
		//	m_form = form;
		//	initAll();
		//}
		public mapControl()
		{
			InitializeComponent();
			initMap();
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
		}


		GMapMarker oldMarker;
		private void M_map_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if(m_form.addSelected())
				{
					PointLatLng p = m_map.FromLocalToLatLng(e.X, e.Y);
					if(oldMarker!=null)removeMarker(oldMarker);
					addMarker(p);
					okButton.Visible = true;
					cacelButton.Visible =true;
				}
			}
		}

		private void addMarker(PointLatLng point,markerType type=markerType.destination)
		{
			GMapMarker marker =new GMarkerGoogle(point, GMarkerGoogleType.yellow);
			markersOverlay.Markers.Add(marker);
		}

		private void removeMarker(GMapMarker marker)
		{
			markersOverlay.Markers.Remove(marker);
			marker = null;
			m_map.Refresh();
		}

		private addrAnalyser m_form;
		private GMapControl m_map;
		private GMapOverlay markersOverlay = new GMapOverlay("markers");

		private MarkerTooltipMode mode = MarkerTooltipMode.OnMouseOver;
	}
}
