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

namespace smart_logistics_app.control
{
	public partial class listForm : Form
	{
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
			dataView.Columns[0].Width = 1 * dataView.Width / 24;
			dataView.Columns[1].Width = 1 * dataView.Width / 24;
			dataView.Columns[2].Width = 5 * dataView.Width / 24;
			dataView.Columns[3].Width = 3 * dataView.Width / 24;
			dataView.Columns[4].Width = 4 * dataView.Width / 24;
			dataView.Columns[5].Width = 2 * dataView.Width / 24;
			dataView.Columns[6].Width = 2 * dataView.Width / 24;
			dataView.Columns[7].Width = 3 * dataView.Width / 24;
			dataView.Columns[8].Width = 3 * dataView.Width / 24;
		}

		private void dataGrid_Resize(object sender, EventArgs e)
		{
			column_Resize();
		}

		private void resize()
		{
			dataView.Top = menuStrip1.Bottom;
			dataView.Height = this.Height - menuStrip1.Height-status_Strip.Height-10;
		}
		private void listForm_Resize(object sender, EventArgs e)
		{
			//dataView.Height = this.Height - addFile_button.Bottom;
			resize();
		}


		private void addItems(List<Item> items)
		{
			m_items.AddRange(items);
			foreach(var c in items)
			{
				int index = dataView.Rows.Add();
				dataView.Rows[index].Cells[0].Value = c.name;
				dataView.Rows[index].Cells[1].Value = c.number;
				dataView.Rows[index].Cells[2].Value = c.info;
				dataView.Rows[index].Cells[3].Value = c.phone;
				dataView.Rows[index].Cells[4].Value = c.Destaddr.name;
				dataView.Rows[index].Cells[5].Value = c.time;
				dataView.Rows[index].Cells[6].Value = c.sign;
				dataView.Rows[index].Cells[7].Value = c.remark;
				dataView.Rows[index].Cells[8].Value = c.source;
			}
		}

		
		//data 
		private List<Item> m_items;

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
	}
}
