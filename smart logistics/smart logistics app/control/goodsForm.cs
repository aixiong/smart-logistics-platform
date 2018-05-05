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
		public goodsForm()
		{
			m_sql = new goodsSql("D:\\goods.sqlite");
			m_status = formStatus.noneStaus;

			InitializeComponent();
			goFull();
			load();
		}

		public void goFull()
		{
			if (m_status == formStatus.noneStaus)
			{
				dataView.Top = toolStrip1.Bottom;
			}
			else
			{
				//if (m_type == formType.vechType)
				//{
				//	dataView.Top = vechA.Bottom;
				//}
				//else
				//{
				//	dataView.Top = vechD.Bottom;
				//}

			}

			dataView.Height = this.Height - dataView.Top;
		}
		
		public void goSub()
		{

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
				dataView.Rows[index].Cells[1].Value = item.from;
				dataView.Rows[index].Cells[2].Value = item.to;
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
				dataView.Columns[i].Width = dataView.Width / cnt;
			}

		}

		private void goodsForm_Resize(object sender, EventArgs e)
		{
			goFull();
		}

		private void dataView_SizeChanged(object sender, EventArgs e)
		{
			columnResize();
		}
	}
	public struct goods
	{
		public string number;
		public string from, to;
		public string arriveTime;
		public string deadline;
		public string status;
		public string objVechicle;
		public string finishTime;
	}
}
