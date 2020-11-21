using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_VideoEMusic
{
	public partial class Form2 : Form
	{
		string Music;
		public Form2(string music){InitializeComponent();Music = music;}
		private void Component1_Load(object sender, EventArgs e){axWindowsMediaPlayer1.URL = Music;this.Text = Music;this.Name = "frmMain2";axWindowsMediaPlayer1.Ctlcontrols.play();progressBar1.Minimum = 0;timer1.Interval = 1000;timer1.Start();}
		private void timer1_Tick(object sender, EventArgs e){if(progressBar1.Maximum==0)progressBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;if (progressBar1.Maximum == progressBar1.Value){timer1.Stop();this.Close();}}
	}
}
