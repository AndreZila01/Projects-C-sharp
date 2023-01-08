using Bytescout.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LerFicheiroExcel
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			List<string> value = new List<string>();
			string file = @"CAMINHODOFICHEIRO";
			Spreadsheet document = new Spreadsheet();
			document.LoadFromFile(file);
			Worksheet worksheet = document.Workbook.Worksheets.ByName("Sheet1");
			for (int i = 0; i < 1113; i++)
			{
				for (int j = 0; j < 1; j++)
				{
					value.Add(worksheet.Cell(i, j).ToString());
					document.Close();

				}
			}

			IEnumerable<string> duplicates = value.GroupBy(x => x)
										.Where(g => g.Count() > 1)
										.Select(x => x.Key);

			List<string> noDupes = value.Distinct().ToList();
			MessageBox.Show("Duplicate elements are: " + String.Join(",", duplicates));
		}
	}
}
