using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smart_logistics_app.map;
using smart_logistics_app.data;
using GMap.NET;
using GMap.NET.WindowsForms;

namespace smart_logistics_app.control
{
	public partial class addrAnalyser : Form
	{
		mapControl m_map;
		listForm m_form;
		List<address> m_addresses;
		addrTool m_addr;
		bool changed;

		private delegate void logD(string message);
		logD logF;
		public addrAnalyser(listForm form)
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
			m_form = form;
			logF = new logD(logMessage);
			init();
		}

		private void init()
		{
			m_map = new mapControl(this);
			m_addr = new addrTool("D:\\logistics data\\address-backup.sqlite");
			addMap();
			m_addresses = m_form.GetAddresses();
			status_progress.Minimum = 0;
			status_progress.Maximum = m_addresses.Count;
			loadSqlite();
			int cnt = getUnknown();
			show();
			logMessage("数据库加载完毕,剩余" + cnt + "个地址未知");
			changed = false;
		}

		private void enableOperation(bool flag)
		{
			menuStrip1.Enabled = flag;
		}
		private void loadData()
		{
			enableOperation(false);
			loadAmap();
			int cnt = getUnknown();
			this.BeginInvoke(logF,"定位完毕,剩余" + cnt + "个地址未知");
			reShow();
			enableOperation(true);
		}

		private int getUnknown()
		{
			int cnt = 0;
			foreach (var c in m_addresses)
			{
				if (c.pos.Lat == 0 && c.pos.Lng == 0) ++cnt;
			}
			return cnt;
		}
		private void loadSqlite()
		{
			logMessage("正在加载地址数据库");
			int num = 0;
			foreach (var c in m_addresses)
			{
				c.pos = m_addr.anchorTarget(c.name);
				status_progress.Value = ++num;
			}
			logMessage("地址数据库加载完毕");
		}

		public PointLatLng querySqlite(string name)
		{
			PointLatLng p = m_addr.anchorTarget(name);
			return p;
		}
		private void loadAmap()
		{
			this.BeginInvoke(logF,"正在利用高德地图定位");
			int num = 0;
			foreach (var c in m_addresses)
			{
				if (c.pos.Lat == 0 && c.pos.Lng == 0)
				{
					point one = geoInfo.getPointByName(c.name);
					if (one.lat >= 39 && one.lat <= 42 && one.lon >= 115 && one.lon <= 118)
					{
						c.pos.Lat = one.lat;
						c.pos.Lng = one.lon;
						changed = true;
					}
				}
				status_progress.Value = ++num;
			}
			this.BeginInvoke(logF,"高德地图定位完毕");
		}

		void show()
		{
			foreach (var c in m_addresses)
			{
				int index = dataView.Rows.Add();
				dataView.Rows[index].Cells[0].Value = index;
				dataView.Rows[index].Cells[1].Value = c.name;
				dataView.Rows[index].Cells[2].Value = c.pos.Lat;
				dataView.Rows[index].Cells[3].Value = c.pos.Lng;
			}
		}

		void reShow()
		{
			for (int i = 0; i < dataView.Rows.Count; ++i)
			{
				int index = Convert.ToInt32(dataView.Rows[i].Cells[0].Value);
				if (m_addresses[index].pos.Lat != Convert.ToDouble(dataView.Rows[i].Cells[2].Value))
				{
					dataView.Rows[i].Cells[2].Value = m_addresses[index].pos.Lat;
				}
				if (m_addresses[index].pos.Lng != Convert.ToDouble(dataView.Rows[i].Cells[3].Value))
				{
					dataView.Rows[i].Cells[3].Value = m_addresses[index].pos.Lng;
				}
			}
		}

		public void addMap()
		{
			panel2.Controls.Add(m_map);
			m_map.Visible = true;
		}

		public bool addSelected()
		{
			return dataView.SelectedRows.Count > 0;
		}

		public void updateAddress(PointLatLng p)
		{
			int index = dataView.CurrentRow.Index;
			if (index >= 1 && index < dataView.Rows.Count)
			{
				int num = Convert.ToInt32(dataView.Rows[index].Cells[0].Value);
				m_addresses[num].pos = p;
				dataView.Rows[index].Cells[2].Value = p.Lat;
				dataView.Rows[index].Cells[3].Value = p.Lng;
				changed = true;
			}
		}

		private void resize()
		{
			panel2.Left = 0;
			panel2.Width = this.Width;
			panel2.Top = menuStrip1.Bottom;
			panel2.Height = (this.Height - menuStrip1.Height - statusStrip1.Height) * 3 / 5;

			panel1.Left = 0;
			panel1.Width = this.Width;
			panel1.Top = panel2.Bottom;
			panel1.Height = (this.Height - menuStrip1.Height - statusStrip1.Height) * 2 / 5 - 10;
			dataView.Width = panel1.Width - 10;
			dataView.Height = panel1.Height - 10;
		}
		private void addrAnalyser_Resize(object sender, EventArgs e)
		{
			resize();
		}

		private void addrAnalyser_Load(object sender, EventArgs e)
		{
			resize();
		}

		private void columnResize()
		{
			dataView.Columns[0].Width = dataView.Width * 1 / 10;
			dataView.Columns[1].Width = dataView.Width / 2;
			dataView.Columns[2].Width = dataView.Width * 2 / 10;
			dataView.Columns[3].Width = dataView.Width * 2 / 10;
		}
		private void dataGridView1_Resize(object sender, EventArgs e)
		{
			columnResize();
		}

		private void logMessage(string message)
		{
			status_strip.Text = message;
		}

		private void 自动定位ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Task t = new Task(delegate { loadData(); });
			t.Start();
		}

		private void saveToSqlite()
		{
			enableOperation(false);
			this.Invoke(logF,"正在保存地址到数据库");
			if (changed)
			{
				int num = 0;
				foreach (var c in m_addresses)
				{
					m_addr.replaceAddress(c);
					status_progress.Value = ++num;
				}
			}
			this.Invoke(logF,"地址保存完毕");
			enableOperation(true);
		}

		private void 保存至数据库ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Task t = new Task(delegate { saveToSqlite(); });
			t.Start();
		}

		private void dataView_Click(object sender, EventArgs e)
		{
			if (dataView.SelectedRows.Count == 0) return;
			DataGridViewRow row = dataView.SelectedRows[0];
			if (row.Cells[0].Value == null || row.Cells[0].Value.ToString() == "" || row.Cells[0].Value.ToString() == "序号") return;
			int index= Convert.ToInt32(row.Cells[0].Value);
			m_map.centerAt(m_addresses[index]);
		}

		private void drawTargets()
		{
			enableOperation(false);
			this.BeginInvoke(logF,"正在绘制目标点");
			m_map.addMarker(m_addresses[0].pos, m_addresses[0].name, markerType.source);
			for (int i = 1; i < m_addresses.Count; ++i)
			{
				m_map.addMarker(m_addresses[i]);
				status_progress.Value = i + 1;
			}
			this.BeginInvoke(logF,"目标点绘制完毕");
			enableOperation(true);
		}
		private void 显示所有目标点ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem one = sender as ToolStripMenuItem;
			m_map.clearMarkers();
			if (one.Text == "显示所有目标点")
			{
				one.Text = "隐藏所有目标点";
				Task t = new Task(delegate { drawTargets(); });
				t.Start();
			}
			else
			{
				one.Text = "显示所有目标点";
			}
		}

		private void addrAnalyser_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!changed) return;
			DialogResult result=MessageBox.Show("是否保存至数据库", "地址管理", MessageBoxButtons.OKCancel);
			if(result==DialogResult.OK)
			{
				saveToSqlite();
			}
		}

		private void 掠过时显示ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			m_map.setMarkTooltipMode(MarkerTooltipMode.OnMouseOver);
		}

		private void 始终显示ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			m_map.setMarkTooltipMode(MarkerTooltipMode.Always);
		}

		private void 始终隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			m_map.setMarkTooltipMode(MarkerTooltipMode.Never);
		}
	}
}
