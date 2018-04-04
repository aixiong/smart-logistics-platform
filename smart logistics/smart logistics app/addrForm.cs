using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smart_logistics_app
{
	public partial class addrForm : Form
	{
		private mapForm m_map;
		public addrForm()
		{
			InitializeComponent();
			m_map = new mapForm(this);
			m_map.Show();
			send_comBox.Items.Add("北京交通大学(默认)");
			send_comBox.Items.Add("北京师范大学");
			send_comBox.SelectedIndex = 0;
		}
		public int getSubLeft()
		{
			return recv_comBox.Left;
		}
		public int getSubTop()
		{
			return recv_comBox.Bottom + 20;
		}
		public int getSubWidth()
		{
			return this.Width-getSubLeft()-40;
		}
		public int getSubHeight()
		{
			return this.Height-getSubTop();
		}

		private void addrForm_Resize(object sender, EventArgs e)
		{
			m_map.resize();
		}

		private void addButtonS_Click(object sender, EventArgs e)
		{
			m_map.intoAddStatus(mapForm.markerType.source);
		}
	}
}
