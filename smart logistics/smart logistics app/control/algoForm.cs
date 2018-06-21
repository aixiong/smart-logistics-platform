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
using smart_logistics_app.algo;

namespace smart_logistics_app.control
{
	public partial class algoForm : Form
	{
		private List<Item> m_items;

		Dictionary<string, int> source;
		Dictionary<string, double> boxes;

		int addrKnown, addrAll;
		int Jinbei, XinNengyuan;

		bool flagg, flaga, flagv, flagb;
		public algoForm(List<Item> items)
		{
			InitializeComponent();
			m_items = items;
			init();
		}

		private void init()
		{
			flagg = flaga = flagv = flagb = false;

			run_button.Enabled = false;
			run_button.Cursor = Cursors.Hand;

			int index=dataView1.Rows.Add();
			dataView1.Rows[index].Cells[0].Value = "订单数量";
			dataView1.Height = dataView1.ColumnHeadersHeight + dataView1.Rows[0].Height;
			source = new Dictionary<string, int>();

			index = dataView4.Rows.Add();
			dataView4.Rows[index].Cells[0].Value = "装载箱体积(m*m*m)";
			boxes = new Dictionary<string, double>();

			index = dataView3.Rows.Add();

			index = dataView2.Rows.Add();

			loadData();
		}


		private void loadData()
		{
			logGood("正在扫描订单...");
			loadGoods();
			logGood("订单扫描完毕");
			showGoods();

			logAddr("正在扫描地址...");
			loadAddr();
			logAddr("地址扫描完毕",flaga);
			showAddr();

			logVeh("正在扫描车辆...");
			loadVeh();
			logVeh("车辆扫描完毕", flagv);
			showVeh();

			logBox("正在扫描装载箱...");
			loadBox();
			logBox("装载箱扫描完毕", flagb);
			showBox();

			enableOperation();
		}

		private void loadGoods()
		{
		    foreach(var g in m_items)
			{
				if(!source.ContainsKey(g.source))
				{
					source.Add(g.source, 0);
				}
				++source[g.source];
			}
			flagg = true;
		}

		private void showGoods()
		{
			int sum = 0;
			int index;
			foreach(var g in source)
			{
				int tmp = dataView1.ColumnCount + 1;
				index = dataView1.Columns.Add("column" + tmp.ToString(), g.Key);
				dataView1.Rows[0].Cells[index].Value = g.Value;
				sum += g.Value;
			}
			index=dataView1.Columns.Add("column-all", "合计");
			dataView1.Rows[0].Cells[index].Value = sum;
		}
		private void loadAddr()
		{
			addrAnalyser m_addr = new addrAnalyser(m_items,false);
			addrAll = m_items.Count;
			addrKnown = addrAll - m_addr.getUnknwon();
			m_addr.Dispose();
			flaga = addrKnown == addrAll;
		}

		private void showAddr()
		{
			dataView2.Rows[0].Cells[0].Value = addrKnown;
			dataView2.Rows[0].Cells[1].Value = addrAll - addrKnown;
			dataView2.Rows[0].Cells[2].Value = addrAll;
		}

		private void loadVeh()
		{
			vehTool veh = new vehTool("D:\\logistics data\\address-backup.sqlite");
			List<Veh> vehs=veh.GetVehs();
			Jinbei = 0;
			XinNengyuan = 0;
			foreach(var c in vehs)
			{
				if(c.name.IndexOf("金杯")!=-1)
				{
					Jinbei = c.number;
				}
				else if(c.name.IndexOf("新能源")!=-1)
				{
					XinNengyuan = c.number;
				}
			}
			flagv = !(Jinbei == 0 && XinNengyuan == 0);
		}

		private void showVeh()
		{
			dataView3.Rows[0].Cells[0].Value = Jinbei;
			dataView3.Rows[0].Cells[1].Value = XinNengyuan;
			dataView3.Rows[0].Cells[2].Value = Jinbei + XinNengyuan;
		}

		private void loadBox()
		{
			boxTool m_box = new boxTool("D:\\logistics data\\address-backup.sqlite");
			flagb = true;
			foreach (var item in m_items)
			{
				if(!boxes.ContainsKey(item.source))
				{
					double vol = m_box.getBoxVol(item.source);
					boxes.Add(item.source, vol);
					if (vol == 0) flagb = false;
				}
			}
		}

		private void showBox()
		{
			foreach (var b in boxes)
			{
				int tmp = dataView4.ColumnCount + 1;
				int index = dataView4.Columns.Add("columnb" + tmp.ToString(), b.Key);
				dataView4.Rows[0].Cells[index].Value = b.Value;
			}
		}

		private void reloadBox()
		{
			boxTool m_box = new boxTool("D:\\logistics data\\address-backup.sqlite");
			flagb = true;
			Dictionary<string, double> newBoxes=new Dictionary<string, double>();
			foreach (var b in boxes)
			{
				double vol = m_box.getBoxVol(b.Key);
				newBoxes.Add(b.Key,b.Value);
				if (vol == 0) flagb = false;
			}
			boxes = newBoxes;
		}

		private void reshowBox()
		{
			for(int i=0;i<boxes.Count;++i)
			{
				string name = dataView4.Columns[i+1].HeaderText;
				double vol = boxes[name];
				dataView4.Rows[0].Cells[i + 1].Value = vol;
			}
		}

		private void run_button_Click(object sender, EventArgs e)
		{
			InputTool m_input = new InputTool("D:\\logistics data\\in.txt");
			info one = new info();
			
		}


		private void addr_button_Click(object sender, EventArgs e)
		{
			addrAnalyser m_addr = new addrAnalyser(m_items,true);
			m_addr.Show();
		}

		private void veh_button_Click(object sender, EventArgs e)
		{
			vehForm m_veh = new vehForm();
			m_veh.Show();
		}

		private void box_button_Click(object sender, EventArgs e)
		{
			boxForm m_box = new boxForm();
			m_box.Show();
		}

		private void addr_refresh_Click(object sender, EventArgs e)
		{
			enableMenu(false);
			logAddr("正在扫描地址...");
			loadAddr();
			logAddr("地址扫描完毕", flaga);
			showAddr();
			enableOperation();
			enableMenu(true);
		}

		private void veh_refresh_Click(object sender, EventArgs e)
		{
			enableMenu(false);
			logVeh("正在扫描车辆...");
			loadVeh();
			logVeh("车辆扫描完毕", flagv);
			showVeh();
			enableOperation();
			enableMenu(true);
		}

		private void box_refresh_Click(object sender, EventArgs e)
		{
			enableMenu(false);
			logBox("正在扫描装载箱...");
			reloadBox();
			logBox("装载箱扫描完毕", flagb);
			reshowBox();
			enableOperation();
			enableMenu(true);
		}

		private void loadOthers()
		{

		}

		private void logGood(string message,bool flag=true)
		{
			changeLabel(label1, message, flag);
		}

		private void logAddr(string message,bool flag=true)
		{
			changeLabel(label2, message, flag);
		}

		private void logVeh(string message,bool flag=true)
		{
			changeLabel(label3, message, flag);
		}

		private void logBox(string message,bool flag=true)
		{
			changeLabel(label4,message,flag);
		}

		private void changeLabel(Label label,string message,bool flag)
		{
			if (flag) label.ForeColor = Color.Black;
			else label.ForeColor = Color.Red;
			label.Text = message;
		}

		private void enableOperation()
		{
			run_button.Enabled = flagg && flaga && flagv && flagb;
		}

		private void enableMenu(bool flag)
		{
			menuStrip1.Enabled = flag;
		}
		private void setSign(int index,int type)
		{

		}
	}
}
