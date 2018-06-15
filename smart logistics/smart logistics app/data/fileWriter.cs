using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_logistics_app.data
{
	class fileWriter
	{
		public fileWriter(string filename)
		{
			m_tool = new ExcelTool(filename);
			//m_tool.Visible = true;
		}

		public void setCaption(string name)
		{
			m_tool.setCaption(name);
		}

		public void setFormat()
		{
			m_tool.setFormat();
		}
		public void writeHeader(List<string> headers)
		{
			for(int i=0;i<headers.Count;++i)
			{
				m_tool.WriteData(headers[i], 1, i + 1);
			}
		}

		public void writeContent(List<string> contents,int row)
		{
			for (int i = 0; i < contents.Count; ++i)
			{
				m_tool.WriteData(contents[i], row, i + 1);
			}
		}

		public void close()
		{
			m_tool.Close();
		}
		public void save(string filePath)
		{
			m_tool.Save(filePath);
		}
		private ExcelTool m_tool;
	}
}
