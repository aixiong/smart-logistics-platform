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
using smart_logistics_app.map;

namespace smart_logistics_app
{
	public enum markerType { center, source, destination };
	public partial class mapForm : Form
	{
		private GMapControl m_map;
		private GMapOverlay markersOverlay = new GMapOverlay("markers");
		private addrForm m_form;

		private GMapMarker center;
		private GMapMarker addPoint;
		private GMapMarker removePoint;


		private bool addFlag, removeFlag;
		private markerType RSFlag;
		private MarkerTooltipMode mode = MarkerTooltipMode.Always;
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
			okButton.Visible = false;
			cacelButton.Visible = false;
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
			okButton.Top = 0;
			okButton.Left = addrButton.Right;
			cacelButton.Top = 0;
			cacelButton.Left = okButton.Right;
		}
		public void goFull()
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
		public void centerAt(PointLatLng p)
		{
			m_map.Position = p;
		}

		private void sizeButton_Click(object sender, EventArgs e)
		{
			zoomInOut();
		}
		public void zoomInOut()
		{
			if (this.WindowState != FormWindowState.Maximized)
			{
				goFull();
				sizeButton.BackgroundImage = images.Images[1];
			}
			else
			{
				goEmbeded();
				sizeButton.BackgroundImage = images.Images[0];
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
			m_map.Refresh();
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
							center.Tag = "0";
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
			if (marktype == GMarkerGoogleType.green) marker.Tag = "2";
			else marker.Tag = "1";
			marker.ToolTipText = name;
			marker.ToolTipMode = mode;
			markersOverlay.Markers.Add(marker);
			if (addFlag) addPoint = marker;
			else removePoint = marker;
			
		}
		public void intoAddStatus(markerType addrType)
		{
			if (addrType == markerType.source) RSFlag = markerType.source;
			if (addrType == markerType.destination) RSFlag = markerType.destination;
			addFlag = true;
			okButton.Visible = true;
			cacelButton.Visible = true;
		}
		public void outAddStatus(GMapMarker addrType,bool ok)
		{
			if(ok)
			{
				m_form.addAddress(addPoint, RSFlag);
				addPoint = null;
			}
			else
			{
				removeMarker(addPoint);
			}
			okButton.Visible = false;
			cacelButton.Visible = false;
			addFlag = false;
			m_form.enableButtons(true);
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			if(addPoint==null)
			{
				MessageBox.Show("请先添加地址!");
				return;
			}
			if(!m_form.checkAddress(addPoint.ToolTipText,RSFlag))
			{
				MessageBox.Show("该地址名称重复使用！请更换地址！");
				return;
			}
			if(addPoint.ToolTipText=="")
			{
				if (addrText.Text != "") addPoint.ToolTipText = addrText.Text;
				else MessageBox.Show("地址名称不能为空!");
				return;
			}
			outAddStatus(addPoint, true);
		}

		private void cacelButton_Click(object sender, EventArgs e)
		{
			outAddStatus(addPoint, false);
		}

		private void M_map_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right )
			{
				if (addFlag)
				{
					PointLatLng p = m_map.FromLocalToLatLng(e.X, e.Y);
					removeMarker(addPoint);
					addMarker(p, addrText.Text, RSFlag);
				}
				else
				{
					contextMenuStrip1.Show();
					contextMenuStrip1.Left = e.X-this.Left;
					contextMenuStrip1.Top = e.Y+this.Top;
				}
			}
		}

		private void mapForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void 隐藏名称ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			setMarkTooltipMode( MarkerTooltipMode.Never);
		}

		private void 掠过时显现ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			setMarkTooltipMode( MarkerTooltipMode.OnMouseOver);
		}

		private void 始终显现ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			setMarkTooltipMode(MarkerTooltipMode.Always);
		}
		private void setMarkTooltipMode(MarkerTooltipMode type)
		{
			mode = type;
			foreach(var item in markersOverlay.Markers)
			{
				item.ToolTipMode = mode;
			}
		}

		private void 全屏ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem one = sender as ToolStripMenuItem;
			if (one.Text == "全屏")
			{
				one.Text = "半屛";
			}
			else one.Text = "全屏";
			zoomInOut();
		}

		public void removeMarker(string name,string type)
		{
			foreach(var item in markersOverlay.Markers)
			{
				if(item.ToolTipText==name && item.Tag.ToString()==type)
				{
					removeMarker(item);
					break;
				}
			}
		}
	}
}
