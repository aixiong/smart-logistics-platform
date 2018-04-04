﻿using System;
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
using smart_logistics_app.map;

namespace smart_logistics_app
{
	public partial class mapForm : Form
	{
		private GMapControl m_map;
		private GMapOverlay markersOverlay = new GMapOverlay("markers");
		private addrForm m_form;

		private GMapMarker center;
		private GMapMarker addPoint;
		private GMapMarker removePoint;

		public enum markerType {center,source,destination };

		private bool addFlag, removeFlag;
		private markerType RSFlag;
		public mapForm(addrForm form)
		{
			InitializeComponent();
			m_form = form;
			init();
		}
		private void init()
		{
			TopLevel = false;
			this.Parent = m_form;
			this.FormBorderStyle = FormBorderStyle.None;
			resize();
			initMap();
			this.Controls.Add(m_map);
		}
		public void resize()
		{
			if(this.WindowState==FormWindowState.Maximized)
			{
				this.WindowState = FormWindowState.Normal;
				this.WindowState = FormWindowState.Maximized;
			}
			else
			{
				this.Left = m_form.getSubLeft();
				this.Top = m_form.getSubTop();
				this.Width = m_form.getSubWidth();
				this.Height = m_form.getSubHeight();
			}
			sizeButton.Left = this.Width - sizeButton.Width;
			sizeButton.Top = 0;
			addrText.Left = 0;
			addrText.Top = 0;
			addrButton.Left = addrText.Right;
			addrButton.Top = 0;
		}
		private void goFull()
		{
			this.WindowState = FormWindowState.Maximized;
			sizeButton.Left = this.Width - sizeButton.Width;
			sizeButton.Top = 0;
		}
		private void goEmbeded()
		{
			this.WindowState = FormWindowState.Normal;
			resize();
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
		}


		private void sizeButton_Click(object sender, EventArgs e)
		{
			if(this.WindowState!=FormWindowState.Maximized)
			{
				goFull();
			}
			else
			{
				goEmbeded();
			}
		}

		private void addrButton_Click(object sender, EventArgs e)
		{
			if (addrText.Text == "") return;
			point p=geoInfo.getPointByName(addrText.Text);
			m_map.Position= new PointLatLng(p.lat, p.lon);
			//if (center != null) removeMarker(center);
			addMarker(m_map.Position, addrText.Text,markerType.center);

		}
		private void removeMarker(GMapMarker marker)
		{
			if(marker!=null)
			markersOverlay.Markers.Remove(marker);
			marker = null;
		}

		public void addMarker(PointLatLng p,string name,markerType type)
		{
			GMarkerGoogleType marktype=GMarkerGoogleType.green;
			switch(type)
			{
				case markerType.center:
					{
						if(center==null)
						{
							center = new GMarkerGoogle(p, GMarkerGoogleType.green_pushpin);
							center.ToolTipText = name;
							center.ToolTipMode = MarkerTooltipMode.OnMouseOver;
							markersOverlay.Markers.Add(center);
						}
						else
						{
							center.Position = p;
							center.ToolTipText = name;
						}
						return;
					}
				case markerType.source:
					{
						marktype = GMarkerGoogleType.blue;
						break;
					}
				case markerType.destination:
					{
						marktype = GMarkerGoogleType.green;
						break;
					}
				default:
					marktype = GMarkerGoogleType.green;
					break;
			}
			GMapMarker marker = new GMarkerGoogle(p, marktype);
			marker.ToolTipText = name;
			marker.ToolTipMode = MarkerTooltipMode.Always;
			markersOverlay.Markers.Add(marker);
			if (addFlag) addPoint = marker;
			else removePoint = marker;
			
		}
		public void intoAddStatus(markerType addrType)
		{
			if (addrType == markerType.source) RSFlag = markerType.source;
			if (addrType == markerType.destination) RSFlag = markerType.destination;
			addFlag = true;
		}
		public void outAddStatus(markerType addrType,bool ok)
		{

		}

		private void M_map_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && addFlag)
			{
				PointLatLng p = m_map.FromLocalToLatLng(e.X, e.Y);
				removeMarker(addPoint);
				addMarker(p, addrText.Text, RSFlag);
			}
		}
	}
}
