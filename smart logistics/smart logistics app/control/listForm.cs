using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using smart_logistics_app.data;
using GMap.NET;

namespace smart_logistics_app.control
{
	public partial class listForm : Form
	{
		//data 
		private List<Item> m_items;
		public listForm()
		{
			InitializeComponent();

			Type type = dataView.GetType();
			PropertyInfo pi = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			pi.SetValue(dataView, true, null);
		}

		private void listForm_Load(object sender, EventArgs e)
		{
			m_items = new List<Item>();
			DoubleBuffered = true;
			resize();
		}

		private void column_Resize()
		{
			int cnt =dataView.Columns.Count;
			if (cnt == 0) return;
			dataView.Columns[0].Width = 1 * dataView.Width / 25;
			dataView.Columns[1].Width = 1 * dataView.Width / 25;
			dataView.Columns[2].Width = 1 * dataView.Width / 25;
			dataView.Columns[3].Width = 5 * dataView.Width / 25;
			dataView.Columns[4].Width = 3 * dataView.Width / 25;
			dataView.Columns[5].Width = 4 * dataView.Width / 25;
			dataView.Columns[6].Width = 2 * dataView.Width / 25;
			dataView.Columns[7].Width = 2 * dataView.Width / 25;
			dataView.Columns[8].Width = 3 * dataView.Width / 25;
			dataView.Columns[9].Width = 3 * dataView.Width / 25;
		}

		private void dataGrid_Resize(object sender, EventArgs e)
		{
			column_Resize();
		}

		private void resize()
		{
			dataView.Top = menuStrip1.Bottom;
			dataView.Height = this.Height - menuStrip1.Height-status_Strip.Height-20;
		}
		private void listForm_Resize(object sender, EventArgs e)
		{
			//dataView.Height = this.Height - addFile_button.Bottom;
			resize();
		}


		private void addItems(List<Item> items)
		{

			int newIndex = m_items.Count;
			foreach(Item one in items)
			{
				Item newOne = one;
				newOne.index = newIndex++;
				m_items.Add(newOne);
			}
			foreach(var c in m_items)
			{
				int index = dataView.Rows.Add();
				dataView.Rows[index].Cells[0].Value = c.index;
				dataView.Rows[index].Cells[1].Value = c.name;
				dataView.Rows[index].Cells[2].Value = c.number;
				dataView.Rows[index].Cells[3].Value = c.info;
				dataView.Rows[index].Cells[4].Value = c.phone;
				dataView.Rows[index].Cells[5].Value = c.Destaddr.name;
				dataView.Rows[index].Cells[6].Value = c.time;
				dataView.Rows[index].Cells[7].Value = c.sign;
				dataView.Rows[index].Cells[8].Value = c.remark;
				dataView.Rows[index].Cells[9].Value = c.source;
			}
		}

		private void 加载文件ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			OpenFileDialog handle = new OpenFileDialog();
			handle.Filter = "Excel files(*.xls)|*.xls|Excel files(*.xlsx)|*.xlsx";
			if (DialogResult.OK == handle.ShowDialog())
			{
				string fileName = handle.FileName;
				logOperation("正在加载文件 "+fileName);
				fileReader m_file = new fileReader(fileName);
				List<Item> items = m_file.GetItems();
				addItems(items);
			}
			logOperation("加载完毕");
		}

		private void logOperation(string message)
		{
			status_Label1.Text = message;
		}
		private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		string old_value;
		private void dataView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			try
			{
				old_value = dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
			}
			catch(Exception)
			{
			}
		}

		private void dataView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				string new_value = dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
				if (new_value != old_value)
				{
					if (DialogResult.OK == MessageBox.Show("是否保存更改: " + old_value + " -> " + new_value, "表单管理", MessageBoxButtons.OKCancel))
					{
						int index = (int)dataView.Rows[e.RowIndex].Cells[0].Value;
						updateItems(index, e.ColumnIndex, new_value);
					}
					else
					{
						dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
					}
				}
			}
			catch (Exception)
			{
				return;
			}
		}

		void updateItems(int index,int property,string val)
		{
			switch (property)
			{
				case 1: m_items[index].name = val; break;
				case 2: m_items[index].number =Convert.ToInt32(val); break;
				case 3:m_items[index].info = val;break;
				case 4:m_items[index].phone = val;break;
				case 5:m_items[index].Destaddr.name = val;break;
				case 6:m_items[index].time = val;break;
				case 7:m_items[index].sign = val;break;
				case 8:m_items[index].remark = val;break;
				case 9:m_items[index].source = val;break;
			}

		}

		private void 分析地址ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addrAnalyser analyser = new addrAnalyser(this);
			analyser.Show();
		}

		public List<address> GetAddresses()
		{
			List<address> li = new List<address>();
			foreach(var c in m_items)
			{ 
				li.Add(c.Destaddr);
			}
			return li;
		}

		public void setAddress(int index,PointLatLng p)
		{
			
		}

		public void refreshAddr()
		{

		}

		private void 清空表单ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dataView.Rows.Clear();
			m_items.Clear();
		}

		private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			envForm m_env = new envForm();
			m_env.Show();
		}
	}
}
