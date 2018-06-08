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

namespace smart_logistics_app.control
{
	public partial class addrAnalyser : Form
	{
		mapControl m_map;
		listForm m_form;
		List<address> m_addresses;
		public addrAnalyser(listForm form)
		{
			InitializeComponent();
			m_form = form;
			m_map = new mapControl(this);
			addMap();
			loadData();
		}

		void loadData()
		{
			logMessage("正在分析定位地址");
			m_addresses = m_form.GetAddresses();
			logMessage("正在数据库中查找");

			logMessage("正在利用高德地图定位");

			logMessage("定位完毕,剩余"+"个地址未知");
			show();
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

		public void addMap()
		{
			panel2.Controls.Add(m_map);
			m_map.Visible = true;
		}

		

		public bool addSelected()
		{
			return false;
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

		}
	}
}
