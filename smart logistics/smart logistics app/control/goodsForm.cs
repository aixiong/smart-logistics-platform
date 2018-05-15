using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using smart_logistics_app.data;

namespace smart_logistics_app.control
{
	public partial class goodsForm : Form
	{
		formStatus m_status;
		List<goods> goodsList;
		goodsSql m_sql;
		DGVPrinter m_printer;

		private goodsAForm goodsA;
		private goodsQForm goodsQ;
		public goodsForm()
		{
			m_sql = new goodsSql("D:\\goods.sqlite");
			m_status = formStatus.noneStaus;
			goodsA = new goodsAForm(this);
			goodsQ = new goodsQForm(this);
			m_printer = new DGVPrinter();
			m_printer.SourceDGV = dataView;

			InitializeComponent();
			goFull();
			load();
		}

		public void goFull()
		{
			if (m_status == formStatus.noneStaus)
			{
				goodsA.Visible = false;
				dataView.Top = toolStrip1.Bottom;
			}
			else
			{
				dataView.Top = goodsA.Bottom;
			}

			dataView.Height = this.Height - dataView.Top;
		}
		
		public void goSub()
		{
			if (m_status == formStatus.queryStatus)
			{
				goodsA.Visible = false;
				dataView.Top = goodsQ.Bottom;
			}
			else
			{
				goodsQ.Visible = false;
				dataView.Top = goodsA.Bottom;
			}
		}

		public void load()
		{
			goodsList = m_sql.getAllGoods();
			show();
		}

		public void show()
		{
			dataView.Rows.Clear();
			foreach (var item in goodsList)
			{
				int index = dataView.Rows.Add();
				dataView.Rows[index].Cells[0].Value = item.number;
				dataView.Rows[index].Cells[1].Value = item.source;
				dataView.Rows[index].Cells[2].Value = item.dest;
				dataView.Rows[index].Cells[3].Value = item.arriveTime;
				dataView.Rows[index].Cells[4].Value = item.deadline;
				dataView.Rows[index].Cells[5].Value = item.status;
				dataView.Rows[index].Cells[6].Value = item.objVechicle;
				dataView.Rows[index].Cells[7].Value = item.finishTime;
			}
			columnResize();
		}
		private void columnResize()
		{
			int cnt = dataView.Columns.Count;
			if (cnt == 0) return;
			for (int i = 0; i < cnt; ++i)
			{
				dataView.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
				dataView.Columns[i].Width = (dataView.Width-10) / cnt;
			}

		}

		public void setStatus(formStatus status)
		{
			m_status = status;
		}

		public int getSubTop()
		{
			return toolStrip1.Bottom;
		}
		private void goodsForm_Resize(object sender, EventArgs e)
		{
			goFull();
		}

		private void dataView_SizeChanged(object sender, EventArgs e)
		{
			columnResize();
		}
		private goods getGoodsfromView(int index)
		{
			goods one = new goods();
			one.number = dataView.Rows[index].Cells[0].Value.ToString();
			one.source = dataView.Rows[index].Cells[1].Value.ToString();
			one.dest = dataView.Rows[index].Cells[2].Value.ToString();
			one.arriveTime = dataView.Rows[index].Cells[3].Value.ToString();
			one.deadline = dataView.Rows[index].Cells[4].Value.ToString();
			one.status = dataView.Rows[index].Cells[5].Value.ToString();
			one.objVechicle = dataView.Rows[index].Cells[6].Value.ToString();
			one.finishTime = dataView.Rows[index].Cells[7].Value.ToString();
			return one;
		}

		private void dataView_Click(object sender, EventArgs e)
		{
			if (m_status != formStatus.noneStaus) return;
			int index = dataView.CurrentRow.Index;
			if (index >= goodsList.Count) return;
			goods one = getGoodsfromView(index);
			goodsA.intoShow(one);
			goSub();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{   //add
			if (m_status == formStatus.queryStatus) return;
			m_status = formStatus.addStatus;
			goodsA.intoAdd();
			goSub();
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{   //edit
			if (m_status == formStatus.queryStatus) return;
			m_status = formStatus.editStatus;
			goodsA.intoAdd();
			goSub();
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{   //delete
			if (m_status == formStatus.queryStatus) return;
			DialogResult result = MessageBox.Show("确定删除选中的数据", "货物管理", MessageBoxButtons.OKCancel);
			if (result == DialogResult.Cancel) return;
			List<goods> li = new List<goods>();
			foreach(DataGridViewRow item in dataView.SelectedRows)
			{
				if (item.Index >= dataView.RowCount-1) continue;
				goods one = getGoodsfromView(item.Index);
				li.Add(one);
			}
			deleteGoods(li);
		}

		public void insertGoods(goods one)
		{
			m_sql.insertGoods(one);
			load();
		}

		public void updateGoods(List<goods> li)
		{
			foreach (goods one in li) m_sql.updateGoods(one);
			load();
		}
		public void updateGoods(goods one)
		{
			m_sql.updateGoods(one);
			load();
		}
		
		public void deleteGoods(List<goods> li)
		{
			foreach (goods one in li) m_sql.deleteGoods(one);
			load();
		}
		public void deleteGoods(goods one)
		{
			m_sql.deleteGoods(one);
			load();
		}

		public void queryGoods(string request)
		{
			goodsList = m_sql.getAllGoods(request);
			show();
		}

		private void 打印ToolStripMenuItem1_Click(object sender, EventArgs e)
		{   //打印
			m_printer.mainTitle = "货物清单";
			m_printer.subTitle = "配送单";
			m_printer.PrintDataGridView(dataView);
		}

		private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
		{   //打印预览
			m_printer.mainTitle = "货物清单";
			m_printer.subTitle = "配送单";
			m_printer.SourceDGV = dataView;
			m_printer.PrintPreview();
		}

		private void 打印设置ToolStripMenuItem_Click(object sender, EventArgs e)
		{   //打印设置
			m_printer.SetupPage();
		}

		private void 货物查询ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			m_status = formStatus.queryStatus;
			goodsQ.intoShow();
			goSub();
		}
		private void 货物完成ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			m_status = formStatus.queryStatus;
			goodsQ.intoShow();
			goSub();
		}
		private void 货物信息ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void 设为配送中ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			List<goods> li = new List<goods>();
			foreach (DataGridViewRow item in dataView.SelectedRows)
			{
				if (item.Index >= dataView.RowCount - 1) continue;
				goods one = getGoodsfromView(item.Index);
				if(one.status=="待配送")
				{
					one.status = "配送中";
					li.Add(one);
				}
			}
			updateGoods(li);
		}

		private void 设为完成ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			List<goods> li = new List<goods>();
			foreach (DataGridViewRow item in dataView.SelectedRows)
			{
				if (item.Index >= dataView.RowCount - 1) continue;
				goods one = getGoodsfromView(item.Index);
				if (one.status == "配送中")
				{
					one.status = "已送达";
					one.finishTime = DateTime.Now.ToString("yyyy-MM-dd");
					li.Add(one);
				}
			}
			updateGoods(li);
		}

		private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (m_status == formStatus.queryStatus) return;
			DialogResult result = MessageBox.Show("确定删除选中的数据", "货物管理", MessageBoxButtons.OKCancel);
			if (result == DialogResult.Cancel) return;
			List<goods> li = new List<goods>();
			foreach (DataGridViewRow item in dataView.SelectedRows)
			{
				if (item.Index >= dataView.RowCount - 1) continue;
				goods one = getGoodsfromView(item.Index);
				li.Add(one);
			}
			deleteGoods(li);
		}

		private void dataView_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				help_menuStrip.Show();
				help_menuStrip.Left = e.X+dataView.Left+20;
				help_menuStrip.Top = e.Y+dataView.Top;
			}
		}

		private void goodsForm_MouseClick(object sender, MouseEventArgs e)
		{
		}

	}
	public struct goods
	{
		public string number;
		public string source, dest;
		public string arriveTime;
		public string deadline;
		public string status;
		public string objVechicle;
		public string finishTime;
	}
}
