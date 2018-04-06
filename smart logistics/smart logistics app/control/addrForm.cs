using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;

namespace smart_logistics_app
{
	public partial class addrForm : Form
	{
		public class address
		{
			public PointLatLng addr;
			public string name;
		}

		private mapForm m_map;
		private List<address> sendAddr;
		private List<address> recvAddr;
		
		public addrForm()
		{
			InitializeComponent();
			m_map = new mapForm(this);
			m_map.Show();
			sendAddr = new List<address>();
			recvAddr = new List<address>();
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
		private void addButtonR_Click(object sender, EventArgs e)
		{
			m_map.intoAddStatus(mapForm.markerType.destination);
		}
		public void addAddress(GMapMarker marker,mapForm.markerType type)
		{
			address tmp = new address();
			tmp.addr = marker.Position;
			tmp.name = marker.ToolTipText;
			if (type==mapForm.markerType.source)
			{
				sendAddr.Add(tmp);
				send_comBox.Items.Add(tmp.name);
				send_comBox.SelectedIndex = send_comBox.Items.Count - 1;
			}
			else
			{
				recvAddr.Add(tmp);
				recv_comBox.Items.Add(tmp.name);
				recv_comBox.SelectedIndex = recv_comBox.Items.Count - 1;
			}
		}
		public bool checkAddress(string name)
		{
			foreach(var item in recvAddr)
			{
				if (item.name == name) return false;
			}
			foreach (var item in sendAddr)
			{
				if (item.name == name) return false;
			}
			return true;
		}

		private void viewButtonS_Click(object sender, EventArgs e)
		{
			if(send_comBox.Text!="")
			{
				string str = send_comBox.Text;
				foreach (var item in sendAddr)
				{
					if (item.name == str)
					{
						m_map.centerAt(item.addr);
						break;
					}
				}
			}
		}

		private void viewButtonR_Click(object sender, EventArgs e)
		{
			if (recv_comBox.Text != "")
			{
				string str = recv_comBox.Text;
				foreach (var item in recvAddr)
				{
					if (item.name == str)
					{
						m_map.centerAt(item.addr);
						break;
					}
				}
			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			m_map.goFull();
		}

		private void deleteButtonS_Click(object sender, EventArgs e)
		{
			if(send_comBox.Text!="")
			{
				int index = send_comBox.SelectedIndex;
				send_comBox.Items.RemoveAt(index);
				while (index >= send_comBox.Items.Count) --index;
				if(index>=0)
				send_comBox.SelectedIndex = index;
			}
		}

		private void deleteButtonR_Click(object sender, EventArgs e)
		{
			if (recv_comBox.Text != "")
			{
				int index = recv_comBox.SelectedIndex;
				recv_comBox.Items.RemoveAt(index);
				while (index >= recv_comBox.Items.Count) --index;
				if (index >= 0)
					recv_comBox.SelectedIndex = index;
			}
		}
	}
}
