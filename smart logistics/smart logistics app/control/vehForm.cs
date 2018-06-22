using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smart_logistics_app.data;

namespace smart_logistics_app.control
{
	public partial class vehForm : Form
	{
		vehTool m_veh;

		List<Veh> m_vehs;
		bool changed;
		public vehForm()
		{
			InitializeComponent();
			init();
		}

		private void init()
		{
			changed = false;
			m_veh = new vehTool("D:\\logistics data\\address-backup.sqlite");
			loadData();
		}

		private void loadData()
		{
			m_vehs=m_veh.GetVehs();
			showData();
		}

		private void showData()
		{
			dataView.Rows.Clear();
			foreach(var c in m_vehs)
			{
				int index = dataView.Rows.Add();
				dataView.Rows[index].Cells[0].Value = c.name;
				dataView.Rows[index].Cells[1].Value = c.distance;
				dataView.Rows[index].Cells[2].Value = c.speed;
				dataView.Rows[index].Cells[3].Value = c.cost;
				dataView.Rows[index].Cells[4].Value = c.capacity;
				dataView.Rows[index].Cells[5].Value = c.number;
			}
			logMessage("车辆信息加载完毕");
		}

		private void saveToSqlite()
		{
			enableOperation(false);
			logMessage("正在保存车辆信息到数据库");
			if (changed)
			{
				m_veh.UpdateVehs(m_vehs);
				changed = false;
			}
			logMessage("车辆信息保存完毕");
			enableOperation(true);
		}
		private void 保存到数据库ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveToSqlite();
		}

		private string oldRecord;
		private void dataView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			try
			{
				oldRecord = dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
			}
			catch(Exception)
			{
				oldRecord = "";
			}
		}

		private void dataView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				string new_value = dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
				if (oldRecord != new_value)
				{
					changed = true;
					updateVehs(e.RowIndex, e.ColumnIndex, new_value);
				}
			}
			catch(Exception err)
			{
				showError(err.Message);
				dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldRecord;
			}
		}

		private void updateVehs(int index,int columnIndex,string value)
		{
			Veh one = m_vehs[index].Clone();
			switch(columnIndex)
			{
				case 0:
					one.name = value;break;
				case 1:
					one.distance = Convert.ToDouble(value);break;
				case 2:
					one.speed = Convert.ToDouble(value); break;
				case 3:
					one.cost = Convert.ToDouble(value); break;
				case 4:
					one.capacity = Convert.ToDouble(value); break;
				case 5:
					one.number = Convert.ToInt32(value); break;
			}
			m_vehs[index] = one;
		}

		private void showError(string message)
		{
			MessageBox.Show(message, "车辆设置", MessageBoxButtons.OK);
		}

		private void logMessage(string message)
		{
			status_strip.Text = message;
		}

		private void enableOperation(bool flag)
		{
			menuStrip1.Enabled = flag;
		}

		private void vehForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(changed)
			{
				if(DialogResult.OK== MessageBox.Show("是否保存修改","车辆设置",MessageBoxButtons.OKCancel))
				{
					saveToSqlite();
				}
			}
			m_veh.close();
		}
	}
}
