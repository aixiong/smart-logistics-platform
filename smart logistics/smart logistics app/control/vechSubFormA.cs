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
			InitializeComponent();
		}
		private void init()
		{
			m_status = Status.showStatus;
			name_textBox.ReadOnly = true;
			vol_textBox.ReadOnly = true;
			jour_textBox.ReadOnly = true;
			ok_button.Visible = false;
			cal_button.Visible = false;
		}

		public void intoShow(vechType one)
		{
			name_textBox.ReadOnly = true;
			vol_textBox.ReadOnly = true;
			jour_textBox.ReadOnly = true;
			ok_button.Visible = false;
			cal_button.Visible = false;
			name_textBox.Text = one.name;
			vol_textBox.Text = one.volume.ToString();
			jour_textBox.Text = one.journey.ToString();

		}
		public void intoAdd()
		{
			m_status = Status.addStatus;

		}

		public void intoEdit()
		{
			m_status = Status.editStatus;

		}

		private void ok_button_Click(object sender, EventArgs e)
		{

		}

		private void cal_button_Click(object sender, EventArgs e)
		{

		}
	}
}
