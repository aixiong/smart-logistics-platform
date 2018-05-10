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
	public partial class goodsAForm :Form
	{
		goodsForm m_form;
		Status m_status;
		public goodsAForm(goodsForm form)
		{
			m_form = form;
			m_status = Status.showStatus;
			InitializeComponent();
			init();
		}

		private void init()
		{
			this.TopLevel = false;
			this.Parent = m_form;
			m_status = Status.showStatus;
			ok_button.Visible = false;
			cal_button.Visible = false;
			this.Left = 0;
			this.Visible = false;
		}

		public void intoShow(goods one)
		{
			m_status = Status.showStatus;
			this.Top = m_form.getSubTop();
			ok_button.Visible = false;
			cal_button.Visible = false;

			number_textBox.ReadOnly = true;
			number_textBox.Text = one.number;

			source_textBox.ReadOnly = true;
			source_textBox.Text = one.source;

			dest_comBox.Items.Clear();
			dest_comBox.Items.Add(one.dest);
			dest_comBox.SelectedIndex = 0;

			arrive_time.Enabled = false;
			arrive_time.Value =Convert.ToDateTime(one.arriveTime);

			dead_time.Enabled = false;
			dead_time.Value = Convert.ToDateTime(one.deadline);

			status_comBox.Enabled = false;
			status_comBox.Items.Clear();
			status_comBox.Items.Add(one.status);
			status_comBox.SelectedIndex = 0;

			vech_textBox.ReadOnly = true;
			vech_textBox.Text = one.objVechicle;

			finish_time.Enabled = false;
			finish_time.Value = Convert.ToDateTime(one.finishTime);

			this.Visible = true;
		}

		public void intoAdd()
		{
			m_status = Status.addStatus;
			this.Top = m_form.getSubTop();
			ok_button.Visible = true;
			cal_button.Visible = true;

			number_textBox.ReadOnly = false;
			number_textBox.Text = DateTime.Now.Ticks.ToString();

			source_textBox.ReadOnly = false;
			source_textBox.Text = "";

			loadDestination();
			dest_comBox.SelectedIndex = 0;

			arrive_time.Enabled = true;
			arrive_time.Value = DateTime.Now;

			dead_time.Enabled = true;
			dead_time.Value = DateTime.Now;

			status_comBox.Enabled = true;
			loadStatus();
			for (int i = 0; i < status_comBox.Items.Count; ++i)
			{
				if (status_comBox.Items[i].ToString() =="待配送")
				{
					status_comBox.SelectedIndex = i;
					break;
				}
			}

			vech_textBox.ReadOnly = true;
			vech_textBox.Text ="";

			finish_time.Enabled = true;
			finish_time.Value = DateTime.Now;


			this.Visible = true;
		}

		private void loadDestination()
		{
			addrSql one = new addrSql("D:\\address.sqlite");
			List<string> li = one.getAllDestName();
			dest_comBox.Items.Clear();
			foreach(var item in li)
			{
				dest_comBox.Items.Add(item.ToString());
			}
		}

		private void loadStatus()
		{
			status_comBox.Items.Clear();
			status_comBox.Items.Add("待配送");
			status_comBox.Items.Add("配送中");
			status_comBox.Items.Add("已送达");
		}
		public void intoEdit(goods one)
		{
			m_status = Status.addStatus;
			this.Top = m_form.getSubTop();
			ok_button.Visible = true;
			cal_button.Visible = true;

			number_textBox.ReadOnly =true;
			number_textBox.Text = one.number;

			source_textBox.ReadOnly = false;
			source_textBox.Text = one.source;

			loadDestination();
			for (int i = 0; i < dest_comBox.Items.Count; ++i)
			{
				if (dest_comBox.Items[i].ToString() == one.status)
				{
					dest_comBox.SelectedIndex = i;
					break;
				}
			}

			arrive_time.Enabled = true;
			arrive_time.Value = Convert.ToDateTime(one.arriveTime);

			dead_time.Enabled = true;
			dead_time.Value = Convert.ToDateTime(one.deadline);

			status_comBox.Enabled = true;
			loadStatus();
			for (int i = 0; i < status_comBox.Items.Count; ++i)
			{
				if (status_comBox.Items[i].ToString() == one.status)
				{
					status_comBox.SelectedIndex = i;
					break;
				}
			}

			vech_textBox.ReadOnly = false;
			vech_textBox.Text = one.objVechicle;

			finish_time.Enabled =true;
			finish_time.Value = Convert.ToDateTime(one.finishTime);

			this.Visible = true;
		}

		private void ok_button_Click(object sender, EventArgs e)
		{
			goods one = new goods();
			one.number = number_textBox.Text;
			one.source= source_textBox.Text;
			one.dest = dest_comBox.Text;
			one.arriveTime = arrive_time.Value.ToString("yyyy-MM-dd");
			one.deadline = dead_time.Value.ToString("yyyy-MM-dd");
			one.objVechicle = vech_textBox.Text;
			one.status = status_comBox.Text;
			one.finishTime = finish_time.Value.ToString("yyyy-MM-dd");
			if (m_status==Status.addStatus)
			{
				m_form.insertGoods(one);
			}
			else
			{
				m_form.updateGoods(one);
			}
			m_form.setStatus(formStatus.noneStaus);
			m_form.goFull();
			this.Visible = false;
		}

		private void cal_button_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			m_form.setStatus(formStatus.noneStaus);
			m_status = Status.showStatus;
			m_form.goFull();
		}

		private void addrM_button_Click(object sender, EventArgs e)
		{

		}

		private void vechM_button_Click(object sender, EventArgs e)
		{

		}
	}
}
