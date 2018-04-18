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
	enum formType { vech,vechType};
	enum formStatus { addStatus,editStatus,noneStaus};
	public partial class vechForm : Form
	{
		private vechSql m_sql;
		formType m_type;
		formStatus m_status;

		List<vech> vechList;
		List<vechType> vechTypeList;
		public vechForm()
		{
			InitializeComponent();
			m_sql = new vechSql("D:\\vechicle.sqlite");
			m_type = formType.vech;
			m_status = formStatus.noneStaus;
			goFull();
			load();
		}
		public void goFull()
		{
			dataView.Top = toolStrip1.Bottom;
			dataView.Height = this.Height - dataView.Top;
		}
		public void goSub()
		{

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
				dataView.Columns.Add(new DataGridViewButtonColumn());
				dataView.Columns[1].HeaderCell.Value = "  车牌号或编号";
				dataView.Columns.Add(new DataGridViewButtonColumn());
				dataView.Columns[2].HeaderCell.Value = "  车辆状态";
				foreach(var item in vechList)
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
				dataView.Columns.Add(new DataGridViewButtonColumn());
				dataView.Columns[1].HeaderCell.Value = "  配送容量";
				dataView.Columns.Add(new DataGridViewButtonColumn());
				dataView.Columns[2].HeaderCell.Value = "  续航里程";
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
			if(m_status==formStatus.noneStaus)
			{
				goFull();
			}
		}

		private void dataView_SizeChanged(object sender, EventArgs e)
		{
			columnResize();
		}

		private void 车型管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			m_type = formType.vechType;
			load();
		}

		private void 车辆管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			m_type = formType.vech;
			load();
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
