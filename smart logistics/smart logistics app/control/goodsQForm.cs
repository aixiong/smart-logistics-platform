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
	public partial class goodsQForm : Form
	{
		goodsForm m_form;
		public goodsQForm(goodsForm form)
		{
			m_form = form;
			InitializeComponent();
			init();
		}

		private void init()
		{
			this.TopLevel = false;
			this.Parent = m_form;
			this.Left = 0;
			this.Visible = false;
			loadDestination();
		}

		public void intoShow()
		{
			this.Top = m_form.getSubTop();
			this.Visible =true;
		}

		public void intoFinish()
		{

		}
		private void loadDestination()
		{
			addrSql one = new addrSql("D:\\address.sqlite");
			List<string> li = one.getAllDestName();
			dest_comBox.Items.Clear();
			foreach (var item in li)
			{
				dest_comBox.Items.Add(item.ToString());
			}
		}

		private void loadVech()
		{
			vechSql one = new vechSql("D:\\vechicle.sqlite");
			List<string> li = one.getAllVechName();
			vech_comBox.Items.Clear();
			foreach(var item in li)
			{
				vech_comBox.Items.Add(item.ToString());
			}
		}
		private void ok_button_Click(object sender, EventArgs e)
		{
			string str = " where ";
			bool first = true;
			if(num_checkBox.Checked)
			{
				if(first)
				{
					str += " number = '" + number_textBox.Text + "' ";
					first = false;
				}
			}
			if(arrive_checkBox.Checked)
			{
				if (first)
				{
					str += " arriveTime >= '" + arriveS_time.Value.ToString("yyyy-MM-dd") + "' and arriveTime <= '" + arriveF_time.Value.ToString("yyyy-MM-dd") + "' ";
					first = false;
				}
				else str += " and arriveTime >= '" + arriveS_time.Value.ToString("yyyy-MM-dd") + "' and arriveTime <= '" + arriveF_time.Value.ToString("yyyy-MM-dd") + "' ";
			}
			if(finish_checkBox.Checked)
			{
				if(first)
				{
					str += " finishTime >= '" + finishS_time.Value.ToString("yyyy-MM-dd") + "' and finishTime <= '" + finishF_time.Value.ToString("yyyy-MM-dd") + "' ";
					first = false;
				}
				else str += " and finishTime >= '" + finishS_time.Value.ToString("yyyy-MM-dd") + "' and finishTime <= '" + finishF_time.Value.ToString("yyyy-MM-dd") + "' ";
			}
			if(status_checkBox.Checked)
			{
				if(first)
				{
					str += " status = '" + status_comBox.Text + "' ";
					first = false;
				}
				else str += " and status = '" + status_comBox.Text + "' ";
			}
			if(vech_checkBox.Checked)
			{
				if(first)
				{
					str += " objVechicle = '" + deferVech() + " '";
					first = false;
				}
				else str += " and objVechicle = '" + deferVech() + " '";
			}
			if(dest_checkBox.Checked)
			{
				if(first)
				{
					str += " dest = '" + dest_comBox.Text + "'";
					first = false;
				}
				else str += " and dest = '" + dest_comBox.Text + "'";
			}
			m_form.queryGoods(str);
			m_form.setStatus(formStatus.noneStaus);
			this.Visible = false;
		}

		private string deferVech()
		{
			string str = vech_comBox.Text;
			int pos = str.IndexOf('(');
			return str.Substring(0, pos);
		}
		private void cal_button_Click(object sender, EventArgs e)
		{
			m_form.setStatus(formStatus.noneStaus);
			this.Visible = false;
		}
	}
}
