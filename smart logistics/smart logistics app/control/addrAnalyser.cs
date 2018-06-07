using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smart_logistics_app.map;

namespace smart_logistics_app.control
{
	public partial class addrAnalyser : Form
	{
		mapControl m_map;
		public addrAnalyser()
		{
			InitializeComponent();
			//m_map = new mapControl(this);
			addMap();
		}

		public void addMap()
		{
			panel1.Controls.Add(m_map);
		}

		public bool addSelected()
		{
			return false;
		}
	}
}
