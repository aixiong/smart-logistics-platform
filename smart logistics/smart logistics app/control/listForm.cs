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
using System.IO;
using System.Threading;

namespace smart_logistics_app.control
{
	public partial class listForm : Form
	{
		//data 
		private List<Item> m_items;
		private envTool m_envTool;

		private delegate void addRowD(Item c,int num);
		addRowD addRowF;

		private delegate void logD(string message);
		logD logF;
		public listForm()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;

			Type type = dataView.GetType();
			PropertyInfo pi = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			pi.SetValue(dataView, true, null);

			addRowF = new addRowD(addRow);
			logF = new logD(logOperation);
		}

		private void listForm_Load(object sender, EventArgs e)
		{
			m_items = new List<Item>();
			DoubleBuffered = true;
			m_envTool = new envTool("D:\\logistics data\\address-backup.sqlite");
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
			dataView.Width = this.Width;
		}
		private void listForm_Resize(object sender, EventArgs e)
		{
			resize();
		}


		private void addItems(fileReader m_file)
		{
			status_progress.Value = 0;
			List<Item> items = m_file.GetItems();
			m_file.close();
			int old_num = m_items.Count;
			int newIndex = m_items.Count;
			foreach(Item one in items)
			{
				Item newOne = one;
				newOne.index = newIndex++;
				m_items.Add(newOne);
			}
			status_progress.Maximum = m_items.Count - old_num;
			int num = 0;
			for(int i=old_num;i<m_items.Count;++i)
			{
				Item c = m_items[i];
				this.BeginInvoke(addRowF, c,++num);
			}
			logOperation("加载完毕,共有"+m_items.Count+"个订单");
			this.Refresh();
		}
		private void addRow(Item c,int num)
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
			status_progress.Value = num;
		}
		private void 加载文件ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			OpenFileDialog handle = new OpenFileDialog();
			handle.Filter = "Excel files(*.xls)|*.xls|Excel files(*.xlsx)|*.xlsx";
			handle.Multiselect = true;
			handle.Title = "请选择订单文件";
			if (DialogResult.OK == handle.ShowDialog())
			{
				Task t = new Task(delegate { loadFiles(handle.FileNames);  });
				t.Start();
			}
		}

		private void loadFiles(string[] fileNames)
		{
			enableOperation(false);
			for (int i = 0; i < fileNames.Length; ++i)
			{
				string fileName =fileNames[i];
				this.BeginInvoke(logF,"正在加载文件 " + fileName);
				try
				{
					fileReader m_file = new fileReader(fileName);
					addItems(m_file);
				}
				catch (Exception err)
				{
					showError(fileName + " 文件加载失败: " + err.Message);
					this.BeginInvoke(logF,"加载失败");
				}
			}
			enableOperation(true);
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
				old_value = "";
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
			addrAnalyser analyser = new addrAnalyser(m_items);
			analyser.Show();
		}

		public List<address> GetAddresses()
		{
			List<address> li = new List<address>();

			address source = new address();
			source.name = m_envTool.getAddress();
			li.Add(source);

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

		private void 车辆设置ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			vehForm m_veh = new vehForm();
			m_veh.Show();
		}

		private void 导出ExcelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "Excel files(*.xls)|*.xls|Excel files(*.xlsx)|*.xlsx";
			if(DialogResult.OK==dialog.ShowDialog())
			{
				string fileName = dialog.FileName;
				Task t = new Task(delegate { saveExcel(fileName);  });
				t.Start();
			}
			
		}

		private void saveExcel(string fileName)
		{
			enableOperation(false);
			try
			{
				this.BeginInvoke(logF,"正在保存文件 " + fileName);
				fileWriter writer = new fileWriter(null);
				List<string> headers = new List<string>();
				status_progress.Maximum = 1 + m_items.Count;
				int num = 1;
				foreach (DataGridViewColumn c in dataView.Columns)
				{
					if (c.Index != 0)
						headers.Add(c.HeaderText);
				}
				writer.setCaption(DateTime.Now.ToShortDateString() + " 订单详情");
				writer.setFormat();
				writer.writeHeader(headers);
				for (int i = 0; i < dataView.RowCount - 1; ++i)
				{
					List<string> contents = new List<string>();
					for (int j = 0; j < dataView.ColumnCount; ++j)
					{
						contents.Add(dataView.Rows[i].Cells[j].Value.ToString());
					}
					writer.writeContent(contents, i + 2);
					status_progress.Value = ++num;
				}
				writer.save(fileName);
				writer.close();
				this.BeginInvoke(logF,"保存完毕");
			}
			catch (Exception err)
			{
				showError("文件保存失败: " + err.Message);
				this.BeginInvoke(logF,fileName+" 保存失败");
			}
			finally
			{
				enableOperation(true);
			}
		}
		private void showError(string message)
		{
			MessageBox.Show(message, "表单管理", MessageBoxButtons.OK);
		}

		private void loadDirectory(string dirPath)
		{
			enableOperation(false);
			DirectoryInfo directoryInfo = new DirectoryInfo(dirPath);
			List<string> fileNames = new List<string>();
			foreach (FileInfo file in directoryInfo.GetFiles())
			{
				if (file.Extension == ".xls" || file.Extension == ".xlsx")
				{
					fileNames.Add(file.FullName);
				}
			}
			loadFiles(fileNames.ToArray());
			enableOperation(true);
		}
		private void 加载文件夹ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folder = new FolderBrowserDialog();
			folder.Description = "请选择订单文件所在文件夹";
			if (DialogResult.OK==folder.ShowDialog())
			{
				if (string.IsNullOrEmpty(folder.SelectedPath))
				{
					showError("文件夹路径不能为空");
					return;
				}
				Task t = new Task(delegate { loadDirectory(folder.SelectedPath); });
				t.Start();
			}
		}

		private void enableOperation(bool flag)
		{
			menuStrip1.Enabled = flag;
		}

		private void 装载箱设置ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			boxForm m_box = new boxForm();
			m_box.Show();
		}

		private void 执行ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			algoForm m_algo = new algoForm(m_items);
			m_algo.Show();
		}
	}
}
