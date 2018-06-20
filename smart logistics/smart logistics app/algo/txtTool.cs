using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace smart_logistics_app.algo
{
	class txtTool
	{
		private string m_file;
		private FileStream m_fs;
		public txtTool(string filename)
		{
			m_file = filename;
			m_fs = new FileStream(filename, FileMode.Truncate);
		}
		public void write(string message)
		{
			byte[] data = Encoding.Default.GetBytes(message);
			m_fs.Write(data, 0, data.Length);
			m_fs.Flush();
		}

		public void close()
		{
			try
			{
				m_fs.Close();
			}
			catch(Exception)
			{

			}
		}
	}
}
