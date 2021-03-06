﻿using System;
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
	public enum formType { vech,vechType};
	public enum formStatus { addStatus,editStatus,noneStaus,queryStatus};
	public partial class vechForm : Form
	{
		private vechSql m_sql;
		private vechSubFormA vechA;
		private vechSubFormD vechD;
		formType m_type;
		formStatus m_status;

		List<vech> vechList;
		List<vechType> vechTypeList;
		public vechForm()
		{
			m_sql = new vechSql("D:\\vechicle.sqlite");
			vechA = new vechSubFormA(this);
			vechD = new vechSubFormD(this);

			m_type = formType.vech;
			m_status = formStatus.noneStaus;
			InitializeComponent();
			goFull();
			load();
		}
		public void setStatus(formStatus status)
		{
			m_status = status;
		}
		public void goFull()
		{
			if (m_status == formStatus.noneStaus)
			{
				dataView.Top = toolStrip1.Bottom;
				vechA.Visible = false;
				vechD.Visible = false;
			}
			else
			{
				if(m_type == formType.vechType)
				{
					dataView.Top = vechA.Bottom;
				}
				else
				{
					dataView.Top = vechD.Bottom;
				}
			
			}
			dataView.Height = this.Height - dataView.Top;
		}
		public void goSub()
		{
			if (m_type == formType.vechType)
				dataView.Top = vechA.Bottom;
			else dataView.Top = vechD.Bottom;
		}
		public void load()
		{
			vechList = m_sql.getAllVechs();
			vechTypeList = m_sql.getAllVechTypes();
			show();
		}
		public void show()
		{
			dataView.Columns.Clear();
			dataView.Rows.Clear();
			if (m_type==formType.vech)
			{
				dataView.Columns.Add(new DataGridViewButtonColumn());
				dataView.Columns[0].HeaderCell.Value = "  车辆类别";
				dataView.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
				dataView.Columns.Add(new DataGridViewButtonColumn());
				dataView.Columns[1].HeaderCell.Value = "  车牌号或编号";
				dataView.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
				dataView.Columns.Add(new DataGridViewButtonColumn());
				dataView.Columns[2].HeaderCell.Value = "  车辆状态";
				dataView.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;
				foreach (var item in vechList)
				{
					int index=dataView.Rows.Add();
					dataView.Rows[index].Cells[0].Value = item.typeName;
					dataView.Rows[index].Cells[1].Value = item.number;
					dataView.Rows[index].Cells[2].Value = item.status;
				}
			}
			else
			{
				dataView.Columns.Add(new DataGridViewButtonColumn());
				dataView.Columns[0].HeaderCell.Value = "  车辆类别名称";
				dataView.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
				dataView.Columns.Add(new DataGridViewButtonColumn());
				dataView.Columns[1].HeaderCell.Value = "  配送容量";
				dataView.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
				dataView.Columns.Add(new DataGridViewButtonColumn());
				dataView.Columns[2].HeaderCell.Value = "  续航里程";
				dataView.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;
				foreach (var item in vechTypeList)
				{
					int index = dataView.Rows.Add();
					dataView.Rows[index].Cells[0].Value = item.name;
					dataView.Rows[index].Cells[1].Value = item.volume;
					dataView.Rows[index].Cells[2].Value = item.journey;
				}
			}
			columnResize();
		}
		private void columnResize()
		{
			int cnt = dataView.Columns.Count;
			if (cnt == 0) return;
			for(int i=0;i<cnt;++i)
			{
				//dataView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataView.Columns[i].Width = dataView.Width / cnt;
			}
			
		}

		private void vechForm_Resize(object sender, EventArgs e)
		{
			goFull();
		}

		private void dataView_SizeChanged(object sender, EventArgs e)
		{
			columnResize();
		}

		private void 车型管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			m_type = formType.vechType;
			vechD.Visible = false;
			load();
			goFull();
		}

		private void 车辆管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			m_type = formType.vech;
			vechA.Visible = false;
			load();
			goFull();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			m_status = formStatus.addStatus;
			if(m_type==formType.vechType)
			{
				vechA.intoAdd();
				goSub();
			}
			else
			{
				vechD.intoAdd(vechTypeList);
				goSub();
			}
		}

		public void insertVech(vech one)
		{
			m_sql.insertVech(one);
			load();
			m_status = formStatus.noneStaus;
		}
		public void insertVechType(vechType one)
		{
			m_sql.insertVechType(one);
			load();
			m_status = formStatus.noneStaus;
		}
		public void updateVech(vech one)
		{
			m_sql.updateVech(one);
			load();
			m_status = formStatus.noneStaus;
		}

		public void updateVechType(vechType one)
		{
			m_sql.updateVechType(one);
			load();
			m_status = formStatus.noneStaus;
		}

		public int getSubTop()
		{
			return toolStrip1.Bottom;
		}

		private void dataView_Click(object sender, EventArgs e)
		{
			if (m_status != formStatus.noneStaus) return;
			if (m_type == formType.vechType)
			{
				int index = dataView.CurrentRow.Index;
				if (index >= vechTypeList.Count) return;
				vechType one = new vechType();
				one.name = dataView.Rows[index].Cells[0].Value.ToString();
				one.volume = Convert.ToDouble(dataView.Rows[index].Cells[1].Value);
				one.journey = Convert.ToDouble(dataView.Rows[index].Cells[2].Value);
				vechA.intoShow(one);
			}
			else
			{
				int index = dataView.CurrentRow.Index;
				if (index >= vechList.Count) return;
				vech one = new vech();
				one.typeName = dataView.Rows[index].Cells[0].Value.ToString();
				one.number = dataView.Rows[index].Cells[1].Value.ToString();
				one.status = dataView.Rows[index].Cells[2].Value.ToString();
				vechD.intoShow(one);
			}
			goSub();
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			if (m_type == formType.vechType)
			{
				int index = dataView.CurrentRow.Index;
				vechType one = new vechType();
				one.name = dataView.Rows[index].Cells[0].Value.ToString();
				one.volume = Convert.ToDouble(dataView.Rows[index].Cells[1].Value);
				one.journey = Convert.ToDouble(dataView.Rows[index].Cells[2].Value);
				vechA.intoEdit(one);
			}
			else
			{
				int index = dataView.CurrentRow.Index;
				vech one = new vech();
				one.typeName= dataView.Rows[index].Cells[0].Value.ToString();
				one.number =  dataView.Rows[index].Cells[1].Value.ToString();
				one.status =  dataView.Rows[index].Cells[2].Value.ToString();
				vechD.intoEdit(one);
			}
		}
		//注意判断误删
		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			DialogResult result= MessageBox.Show("确定删除该项数据", "车辆管理",MessageBoxButtons.OKCancel);
			if (result == DialogResult.Cancel) return;
			if (m_type == formType.vechType)
			{
				int index = dataView.CurrentRow.Index;
				vechType one = new vechType();
				one.name = dataView.Rows[index].Cells[0].Value.ToString();
				one.volume = Convert.ToDouble(dataView.Rows[index].Cells[1].Value);
				one.journey = Convert.ToDouble(dataView.Rows[index].Cells[2].Value);
				m_sql.deleteVechType(one);
				load();
			}
			else
			{
				int index = dataView.CurrentRow.Index;
				vech one = new vech();
				one.typeName = dataView.Rows[index].Cells[0].Value.ToString();
				one.number = dataView.Rows[index].Cells[1].Value.ToString();
				one.status = dataView.Rows[index].Cells[2].Value.ToString();
				m_sql.deleteVech(one);
				load();
			}
		}
		public bool containNumber(string number)
		{
			foreach(var item in vechList)
			{
				if (item.number == number) return true;
			}
			return false;
		}
		public bool containTypeName(string name)
		{
			foreach (var item in vechTypeList)
			{
				if (item.name==name) return true;
			}
			return false;
		}
	}
	public class vechType
	{
		public string name;
		public double volume;
		public double journey;
	}
	public class vech
	{
		public string typeName;
		public string number;
		public string status;
	}
}
