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
	public partial class boxForm : Form
	{
		boxTool m_box;
		List<box> m_boxes;
		bool changed;
		public boxForm()
		{
			InitializeComponent();
			init();
		}

		private void init()
		{
			changed = false;
			m_box = new boxTool("D:\\logistics data\\address-backup.sqlite");
			loadData();
		}

		private void loadData()
		{
			m_boxes = m_box.getBoxes();
			showData();
		}

		private void showData()
		{
			dataView.Rows.Clear();
			foreach (var c in m_boxes)
			{
				int index = dataView.Rows.Add();
				dataView.Rows[index].Cells[0].Value = c.name;
				dataView.Rows[index].Cells[1].Value = c.length;
				dataView.Rows[index].Cells[2].Value = c.width;
				dataView.Rows[index].Cells[3].Value = c.height;
			}
			logMessage("装载箱信息加载完毕");
		}

		private void 保存到数据库ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveToSqlite();
		}

		private void saveToSqlite()
		{
			enableOperation(false);
			logMessage("正在保存装载箱信息到数据库");
			if (changed)
			{
				m_box.updateBoxes(m_boxes);
				changed = false;
			}
			logMessage("装载箱信息保存完毕");
			enableOperation(true);
		}



		private void enableOperation(bool flag)
		{
			menuStrip1.Enabled = flag;
		}
		private void logMessage(string message)
		{
			status_strip.Text = message;
		}

		private void showError(string message)
		{
			MessageBox.Show(message, "装载箱设置", MessageBoxButtons.OK);
		}

		private void boxForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (changed)
			{
				if (DialogResult.OK == MessageBox.Show("是否保存修改", "装载箱设置", MessageBoxButtons.OKCancel))
				{
					saveToSqlite();
				}
			}
		}

		private string oldRecord;
		private void dataView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			try
			{
				oldRecord = dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
			}
			catch (Exception)
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
					updateBoxes(e.RowIndex, e.ColumnIndex, new_value);
				}
			}
			catch(Exception err)
			{
				showError(err.Message);
				dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldRecord;
			}
		}

		private void updateBoxes(int index, int columnIndex, string value)
		{
			try
			{
				box one = new box();
				if (index < m_boxes.Count) one = m_boxes[index];
				switch (columnIndex)
				{
					case 0:
						one.name = value; break;
					case 1:
						one.length = Convert.ToDouble(value); break;
					case 2:
						one.width = Convert.ToDouble(value); break;
					case 3:
						one.height = Convert.ToDouble(value); break;
				}
				if (index < m_boxes.Count) m_boxes[index] = one;
				else m_boxes.Add(one);
			}
			catch(Exception err)
			{
				showError(err.Message);
			}
		}

		private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveToSqlite();
			showData();
		}
		private void dataView_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				helpMenu.Show();
			}
		}

		private void 删除该项ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int index = dataView.CurrentRow.Index;
			dataView.Rows.RemoveAt(index);
			m_box.removeBox(m_boxes[index].name);
			m_boxes.RemoveAt(index);
		}
	}
}
