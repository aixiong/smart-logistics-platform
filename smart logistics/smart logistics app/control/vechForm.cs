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
	public partial class vechForm : Form
	{
		public vechForm()
		{
			InitializeComponent();
		}
		public void load()
		{

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
		public string id;
		public string status;
	}
}
