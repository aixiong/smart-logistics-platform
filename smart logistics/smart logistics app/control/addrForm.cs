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
using smart_logistics_app.data;

namespace smart_logistics_app
{
	public partial class addrForm : Form
	{
		private mapForm m_map;
		private List<address> sendAddr;
		private List<address> recvAddr;

		private addrSql m_sql;
		
		public addrForm()
		{
			InitializeComponent();
			m_map = new mapForm(this);
			m_map.Show();
			loadData();
		}
		private void loadData()
		{
			m_sql = new addrSql("D:\\address.sqlite");
			sendAddr = m_sql.getAllAddress(markerType.source);
			recvAddr = m_sql.getAllAddress(markerType.destination);
			foreach(var addr in sendAddr)
			{
				addAddress(addr, markerType.source);
			}
			foreach(var addr in recvAddr)
			{
				addAddress(addr, markerType.destination);
			}
		}
		public void addAddress(address addr,markerType type)
		{
			if (type == markerType.source)
				send_comBox.Items.Add(addr.name);
			else
				recv_comBox.Items.Add(addr.name);
			m_map.addMarker(addr.pos, addr.name, type);
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
			enableButtons(false);
			m_map.intoAddStatus(markerType.source);
		}
		private void addButtonR_Click(object sender, EventArgs e)
		{
			enableButtons(false);
			m_map.intoAddStatus(markerType.destination);
		}
		public void addAddress(GMapMarker marker,markerType type)
		{
			address tmp = new address();
			tmp.pos = marker.Position;
			tmp.name = marker.ToolTipText;
			if (type==markerType.source)
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
		public bool checkAddress(string name,markerType type)
		{
			if (type == markerType.destination)
			{
				foreach (var item in recvAddr)
				{
					if (item.name == name) return false;
				}
			}
			else
			{
				foreach (var item in sendAddr)
				{
					if (item.name == name) return false;
				}
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
						m_map.centerAt(item.pos);
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
						m_map.centerAt(item.pos);
						break;
					}
				}
			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			m_map.zoomInOut();
		}

		private void deleteButtonS_Click(object sender, EventArgs e)
		{
			if(send_comBox.Text!="")
			{
				deleteAddress(sendAddr, send_comBox.Text);
				m_map.removeMarker(send_comBox.Text,"1");
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
				deleteAddress(recvAddr, recv_comBox.Text);
				m_map.removeMarker(recv_comBox.Text,"2");
				int index = recv_comBox.SelectedIndex;
				recv_comBox.Items.RemoveAt(index);
				while (index >= recv_comBox.Items.Count) --index;
				if (index >= 0)
					recv_comBox.SelectedIndex = index;
			}
		}
		private void deleteAddress(List<address> li,string name)
		{
			foreach(var item in li)
			{
				if(item.name==name)
				{
					li.Remove(item);
					break;
				}
			}
		}
		public void enableButtons(bool flag)
		{
			addButtonR.Enabled = flag;
			addButtonS.Enabled = flag;
			deleteButtonR.Enabled = flag;
			deleteButtonS.Enabled = flag;
		}
		
	}
	public class address
	{
		public string name;
		public PointLatLng pos;
	}
}
