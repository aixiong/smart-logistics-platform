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

namespace smart_logistics_app
{
	public partial class mapForm : Form
	{
		private GMapControl m_map;
		private GMapOverlay markersOverlay = new GMapOverlay("markers");
		private addrForm m_form;
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
	}
}
