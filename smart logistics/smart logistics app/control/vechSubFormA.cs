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
	public enum Status { showStatus,editStatus,addStatus};
	public partial class vechSubFormA : Form
	{
		private vechForm m_form;
		Status m_status;
		public vechSubFormA(vechForm form)
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
			name_textBox.ReadOnly = true;
			vol_textBox.ReadOnly = true;
			jour_textBox.ReadOnly = true;
			ok_button.Visible = false;
			cal_button.Visible = false;
			this.Left = 0;
			this.Visible = false;
		}

		public void intoShow(vechType one)
		{
			m_status = Status.showStatus;
			this.Top = m_form.getSubTop();
			name_textBox.ReadOnly = true;
			vol_textBox.ReadOnly = true;
			jour_textBox.ReadOnly = true;
			ok_button.Visible = false;
			cal_button.Visible = false;
			name_textBox.Text = one.name;
			vol_textBox.Text = one.volume.ToString();
			jour_textBox.Text = one.journey.ToString();
			this.Visible = true;
		}
		public void intoAdd()
		{
			m_status = Status.addStatus;
			this.Top = m_form.getSubTop();
			this.Visible = true;
			name_textBox.ReadOnly = false;
			vol_textBox.ReadOnly = false;
			jour_textBox.ReadOnly = false;
			ok_button.Visible = true;
			cal_button.Visible = true;
		}

		public void intoEdit(vechType one)
		{
			this.Top = m_form.getSubTop();
			m_status = Status.editStatus;
			name_textBox.ReadOnly = true;
			vol_textBox.ReadOnly = false;
			jour_textBox.ReadOnly = false;
			name_textBox.Text = one.name;
			vol_textBox.Text = one.volume.ToString();
			jour_textBox.Text = one.journey.ToString();
			this.Visible = true;
			ok_button.Visible = true;
			cal_button.Visible = true;
		}

		private void ok_button_Click(object sender, EventArgs e)
		{
			if(m_status==Status.addStatus)
			{
				if(name_textBox.Text=="" || vol_textBox.Text=="" || jour_textBox.Text=="")
				{
					MessageBox.Show("请完整填写车型信息");
					return;
				}
				else
				{
					vechType one = new vechType();
					one.name = name_textBox.Text;
					one.volume = Convert.ToDouble(vol_textBox.Text);
					one.journey = Convert.ToDouble(jour_textBox.Text);
					m_form.insertVechType(one);
				}
			}
			else if(m_status==Status.editStatus)
			{
				if (vol_textBox.Text == "" || jour_textBox.Text == "")
				{
					MessageBox.Show("请完整填写车型信息");
					return;
				}
				else
				{
					vechType one = new vechType();
					one.name = name_textBox.Text;
					one.volume = Convert.ToDouble(vol_textBox.Text);
					one.journey = Convert.ToDouble(jour_textBox.Text);
					m_form.updateVechType(one);
				}
			}
			m_form.setStatus(formStatus.noneStaus);
			m_form.goFull();
			this.Visible = false;
		}

		private void cal_button_Click(object sender, EventArgs e)
		{
			m_form.goFull();
			this.Visible = false;
		}

	}
}
