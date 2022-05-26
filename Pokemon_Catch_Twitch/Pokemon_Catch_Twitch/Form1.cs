using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Catch_Twitch
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (!backgroundWorker1.IsBusy) backgroundWorker1.RunWorkerAsync();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+"/Pokemon"))
			{

			}
			else
			{
				Directory.CreateDirectory(Environment.SpecialFolder.ApplicationData))
			}
		}
	}
}
