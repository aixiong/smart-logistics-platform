using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smart_logistics_app.control
{
	public partial class vechSubFormD : Form
	{
		private vechForm m_form;
		private Status m_status;
		public vechSubFormD(vechForm form)
		{
			m_form = form;
			InitializeComponent();
			init();
		}
		private void init()
		{
			this.TopLevel = false;
			this.Parent = m_form;
			m_status = Status.showStatus;
			type_comBox.Text = "";
			num_textBox.Text = "";
			status_comBox.Text = "";
			ok_button.Visible = false;
			cal_button.Visible = false;
			this.Left = 0;
			this.Visible = false;
		}
		public void intoShow(vech one)
		{
			m_status = Status.showStatus;
			this.Top = m_form.getSubTop();
			num_textBox.ReadOnly = true;
			ok_button.Visible = false;
			cal_button.Visible = false;
			type_comBox.Items.Clear();
			type_comBox.Items.Add(one.typeName);
			type_comBox.SelectedIndex = 0;
			type_comBox.Enabled = false;
			status_comBox.Enabled = false;
			num_textBox.Text = one.number;

			for (int i = 0; i < status_comBox.Items.Count; ++i)
			{
				if (status_comBox.Items[i].ToString() == one.status)
				{
					status_comBox.SelectedIndex = i;
					break;
				}
			}
			this.Visible = true;
		}
		public void intoAdd(List<vechType> li)
		{
			m_status = Status.addStatus;
			this.Top = m_form.getSubTop();
			num_textBox.ReadOnly = false;
			ok_button.Visible = true;
			cal_button.Visible = true;
			type_comBox.Enabled = true;
			status_comBox.Enabled = true;
			type_comBox.Items.Clear();
			foreach (var item in li) type_comBox.Items.Add(item.name);
			type_comBox.SelectedIndex = 0;
			this.Visible = true;
		}
		public void intoEdit(vech one)
		{
			m_status = Status.editStatus;
			this.Top = m_form.getSubTop();
			type_comBox.Enabled = false;
			num_textBox.ReadOnly = true;
			ok_button.Visible = true;
			cal_button.Visible = true;
			status_comBox.Enabled = true;
			type_comBox.Items.Clear();
			type_comBox.Items.Add(one.typeName);
			type_comBox.SelectedIndex = 0;
			status_comBox.Text = one.status;
			this.Visible = true;
		}
		private void ok_button_Click(object sender, EventArgs e)
		{
			if (m_status == Status.addStatus)
			{
				if (type_comBox.Text == "" || num_textBox.Text=="" || status_comBox.Text=="")
				{
					MessageBox.Show("请完整填写车辆信息", "车辆管理", MessageBoxButtons.OK);
					return;
				}
				else
				{
					if(m_form.containNumber(num_textBox.Text))
					{
						MessageBox.Show("车辆编码重复，请填写其它编码", "车辆管理", MessageBoxButtons.OK);
						return;
					}
					vech one = new vech();
					one.typeName = type_comBox.Text;
					one.number = num_textBox.Text;
					one.status = status_comBox.Text;
					m_form.insertVech(one);
				}
				m_form.setStatus(formStatus.noneStaus);
				m_form.goFull();
				this.Visible = false;
			}
			else if(m_status==Status.editStatus)
			{
				if (type_comBox.Text == "" || num_textBox.Text == "" || status_comBox.Text == "")
				{
					MessageBox.Show("请完整填写车辆信息","车辆管理",MessageBoxButtons.OK);
					return;
				}
				else
				{
					vech one = new vech();
					one.typeName = type_comBox.Text;
					one.number = num_textBox.Text;
					one.status = status_comBox.Text;
					m_form.updateVech(one);
				}
				m_form.setStatus(formStatus.noneStaus);
				m_form.goFull();
				this.Visible = false;
			}
		}

		private void cal_button_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			m_form.setStatus(formStatus.noneStaus);
			m_status = Status.showStatus;
			m_form.goFull();
		}
	}
}
