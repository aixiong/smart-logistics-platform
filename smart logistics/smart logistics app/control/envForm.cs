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
	public partial class envForm : Form
	{
		private envTool m_env;
		private bool changed;

		private string centerName;
		private double workTime;
		private double loadTime;

		public envForm()
		{
			InitializeComponent();
			m_env = new envTool("D:\\logistics data\\address-backup.sqlite");
		}

		private void envForm_Load(object sender, EventArgs e)
		{
			init();
		}

		private void init()
		{
			loadData();
			int index = dataView.Rows.Add();
			dataView.Rows[index].Cells[0].Value = "配送中心地址";
			centerName = m_env.getAddress();
			dataView.Rows[index].Cells[1].Value = centerName;

			index=dataView.Rows.Add();
			dataView.Rows[index].Cells[0].Value = "工作时长";
			workTime = m_env.getWorkTime();
			dataView.Rows[index].Cells[1].Value = workTime;

			index=dataView.Rows.Add();
			dataView.Rows[index].Cells[0].Value = "单次装卸时间";
			loadTime = m_env.getLoadTime();
			dataView.Rows[index].Cells[1].Value = loadTime;

			logMessage("数据库加载完毕");
			changed = false;
		}



		private void loadData()
		{
			m_env.querySql();
		}

		private void logMessage(string message)
		{
			status_strip.Text = message;
			Refresh();
		}

		string old_value;
		private void dataView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			try
			{
				old_value = dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
			}
			catch (Exception)
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
					if (DialogResult.Cancel == MessageBox.Show("是否保存更改: " + old_value + " -> " + new_value, "系统设置", MessageBoxButtons.OKCancel))
					{
						dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
					}
					else
					{
						if(!updateData(e.RowIndex,new_value))
						{
							dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old_value;
							MessageBox.Show("属性值:" + new_value + "无效", "系统设置", MessageBoxButtons.OK);
						}
						else changed = true;
					}
				}
			}
			catch (Exception) { }
		}

		private void saveToSqlite()
		{
			logMessage("正在保存地址到数据库");
			m_env.replaceEnv(centerName, workTime, loadTime);
			changed = false;
			logMessage("地址保存完毕");
		}

		private void envForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!changed) return;
			DialogResult result = MessageBox.Show("是否保存至数据库", "系统设置", MessageBoxButtons.OKCancel);
			if (result == DialogResult.OK)
			{
				saveToSqlite();
			}
		}

		private  bool updateData(int index,string str)
		{
			if(index==0)
			{
				centerName = str;
			}
			else if(index==1)
			{
				double d = strToDouble(str);
				if (d == -1) return false;
				workTime = d;
			}
			else
			{
				double d = strToDouble(str);
				if (d == -1) return false;
				loadTime = d;
			}
			return true;
		}
		private double strToDouble(string str)
		{
			double d;
			try
			{
				d = Convert.ToDouble(str);
			}
			catch(Exception)
			{
				return -1;
			}
			return d;
		}

		private void 保存到数据库ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveToSqlite();
		}
	}
}
