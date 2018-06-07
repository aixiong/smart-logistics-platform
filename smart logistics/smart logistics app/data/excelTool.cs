using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel;

namespace smart_logistics_app.data
{
	class ExcelTool
	{
		private string excelName;
		private Application myExcel;
		private Workbook myWorkBook;
		public ExcelTool(string _excelName = null)
		{
			myExcel = new Application();
			excelName = _excelName;
			if (excelName == null)
			{
				myWorkBook = myExcel.Application.Workbooks.Add(true);

			}
			else
			{
				myWorkBook = myExcel.Workbooks.Add(excelName);
			}
		}
		public void WriteData(string data, int row, int column)
		{
			myExcel.Cells[row, column] = data;
		}
		public void WriteData(string[,] data, int startRow, int startColumn)
		{
			int rowNumber = data.GetLength(0);
			int columnNumber = data.GetLength(1);
			for (int i = 0; i < rowNumber; ++i)
			{
				for (int j = 0; j < columnNumber; ++j)
				{
					myExcel.Cells[startRow + i, startColumn + j] = data[i, j];
				}
			}
		}
		public string ReadData(int row, int column)
		{
			Excel.Range range = myExcel.Range[myExcel.Cells[row, column], myExcel.Cells[row, column]];
			return range.Text.ToString();
		}
		public void Close()
		{
			myWorkBook.Close(false, Type.Missing, Type.Missing);
			myExcel.Quit();
			myWorkBook = null;
			myExcel = null;
			GC.Collect();
		}
		public bool Visible
		{
			set
			{
				myExcel.Visible = value;
			}
		}
	}

    class Item
	{
		public int index;
		public string name;
		public int number;
		public string info;
		public string phone;
		public address Destaddr;
		public string time;
		public string sign;
		public string remark;
		public string source;
	}
	enum itemProperty
	{
		index,name,number,info,phone,Destaddr,time,sign,remark,source
	};
}
