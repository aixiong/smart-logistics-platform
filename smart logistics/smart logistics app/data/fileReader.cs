using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_logistics_app.data
{
	class fileReader
	{
		public fileReader(string filename)
		{
			m_tool = new ExcelTool(filename);
		}

		public List<Item> GetItems()
		{
			List<Item> li = new List<Item>();
			int r = 0;
			while(true)
			{
				++r;
				if (m_tool.ReadData(r, 1) == "") break;

				//next line is just for unnormal excel file
				string flag = m_tool.ReadData(r, 6);
				if (flag == "" || flag=="配送地址" || flag=="地址") continue;

				Item one = new Item();
				one.name=m_tool.ReadData(r, 2);
				if (m_tool.ReadData(r, 3) != "")
					one.number = strToInt(m_tool.ReadData(r, 3));
				one.info = m_tool.ReadData(r, 4);
				one.phone = m_tool.ReadData(r, 5);
				one.Destaddr = new address();
				one.Destaddr.name = m_tool.ReadData(r, 6);
				one.time = m_tool.ReadData(r, 7);
				one.sign = m_tool.ReadData(r, 8);
				one.remark = m_tool.ReadData(r, 9);
				one.source = m_tool.ReadData(r, 10);
				li.Add(one);
			}
			return li;
		}
	
		private int strToInt(string str)
		{
			int n;
			try
			{
				n = Convert.ToInt32(str);
			}
			catch(Exception)
			{
				return 1;
			}
			return n;
		}
		private ExcelTool m_tool;

	}
}
