using System;
using System.Collections.Generic;

using System.Drawing;

using System.Linq;
using System.Windows.Forms;
namespace Spotify_Clone
{
	public partial class Video : Form
	{
		public static string info;
		public static int progresso;
		public static double maxprogresso;
		string OldMusic;
		private const int CP_NOCLOSE_BUTTON = 0x200;
		public Video()
		{
			InitializeComponent();
		}
		public void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				axWindowsMediaPlayer1.settings.volume = int.Parse(Form1.Volume);
			}
			catch { }
			if (OldMusic != Form1.CaMusica)
			{
				try
				{
					axWindowsMediaPlayer1.URL = Form1.CaMusica;
				}
				catch { }
				OldMusic = axWindowsMediaPlayer1.URL;
				timer1.Stop();
				string[] DT = OldMusic.Split(new string[] { "\\" }, StringSplitOptions.None);
				this.Text = DT[DT.Length - 1].Substring(0, DT[DT.Length - 1].Length - 4);
				progressBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
				AuxMusic.Start();
			}
			if (axWindowsMediaPlayer1.settings.volume != int.Parse(Form1.Volume)) axWindowsMediaPlayer1.settings.volume = int.Parse(Form1.Volume);
			switch (Form1.Processo)
			{
				case "start":
					try
					{
						axWindowsMediaPlayer1.Ctlcontrols.play();
						AuxMusic.Stop();
						pctPausa.Image = Properties.Resources.pauseB;
						AuxMusic.Start();
					}
					catch { }
					break;
				case "pause":
					axWindowsMediaPlayer1.Ctlcontrols.pause();
					pctPausa.Image = Properties.Resources.playB;
					AuxMusic.Stop();
					break;
			}
			if (progressBar1.Value == progressBar1.Maximum || progressBar1.Value == (progressBar1.Maximum - 1) && progressBar1.Value != 0)
			{
				axWindowsMediaPlayer1.URL = Form1.CaMusica;
				axWindowsMediaPlayer1.settings.volume = int.Parse(Form1.Volume);
				OldMusic = axWindowsMediaPlayer1.URL;
				axWindowsMediaPlayer1.Ctlcontrols.play();
				string[] DT = Form1.CaMusica.Split(new string[] { "\\" }, StringSplitOptions.None);
				this.Text = DT[DT.Length - 1].Substring(0, DT[DT.Length - 1].Length - 4);
			}
			Form1.Processo = ".";

		}
		private void Form3_SizeChanged(object sender, EventArgs e)
		{
			if (this.Width < 215) this.Size = new Size(215, this.Height);
			if (this.Height < 175) this.Size = new Size(this.Width, 175);
		}
		private void Form3_Load(object sender, EventArgs e)
		{
			timer1.Tag = 0;
			MessageBox.Show("If you like the Video full screen,or normal!!\nClick on time in video!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			timer1.Start();
			axWindowsMediaPlayer1.URL = Form1.CaMusica;
			axWindowsMediaPlayer1.settings.volume = int.Parse(Form1.Volume);
			OldMusic = axWindowsMediaPlayer1.URL;
			axWindowsMediaPlayer1.Ctlcontrols.play();
			string[] DT = Form1.CaMusica.Split(new string[] { "\\" }, StringSplitOptions.None);
			this.Text = DT[DT.Length - 1].Substring(0, DT[DT.Length - 1].Length - 4);
			AuxMusic.Interval = 1;
			AuxMusic.Start();
			timer1.Stop();
			Width = 729;
			Height = 450;
			try
			{
				this.Location = Screen.AllScreens[(Form1.ecra - 1)].WorkingArea.Location;
			}
			catch
			{
				this.Location = Screen.AllScreens[0].WorkingArea.Location;
			}
			this.CenterToScreen();
		}
		private void AuxMusic_Tick(object sender, EventArgs e)
		{
			if ((DateTime.Now.TimeOfDay.TotalSeconds - dateTime.TimeOfDay.TotalSeconds) >= 5)
			{
				dateTime = new DateTime();
				panel1.Visible = false;
			}
			if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
			{
				progressBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
				maxprogresso = axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
				try
				{
					progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
				}
				catch { }
				progresso = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
			}
		}
		private void axWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
		{
			Screen scrn = Screen.FromControl(this);
			Screen scr = Screen.FromControl(this);
			List<Screen> lstemps = new List<Screen>();
			foreach (var screen in Screen.AllScreens) lstemps.Add(screen);
			int n = (lstemps.FindIndex(dsssss => dsssss.DeviceName == scr.DeviceName));
			Left = Top = 0;
			switch (this.Tag.ToString())
			{
				case "expand":
					FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
					this.Location = Screen.AllScreens[n].WorkingArea.Location;
					Width = (Screen.AllScreens[n].WorkingArea.Width);
					Height = (Screen.AllScreens[n].WorkingArea.Height);
					this.Tag = "fullscreen";
					break;
				case "diminuir":
					WindowState = FormWindowState.Normal;
					FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
					Width = 729;
					Height = 450;
					this.Location = Screen.AllScreens[n].WorkingArea.Location;
					this.CenterToScreen();
					this.Tag = "expand";
					break;
				case "fullscreen":
					FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
					this.Tag = "diminuir";
					this.Location = Screen.AllScreens[n].WorkingArea.Location;
					WindowState = FormWindowState.Maximized;
					break;
			}
			axWindowsMediaPlayer1.Ctlcontrols.pause();
			if (Form1.Processo != "start") axWindowsMediaPlayer1.Ctlcontrols.play();
		}
		DateTime dateTime;
		private void axWindowsMediaPlayer1_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
		{
			AuxMouse.Start();
			if (coordenadas != "" + e.fX + "," + e.fY)
			{
				panel1.Visible = true;
				dateTime = DateTime.Now;
				coordenadas = "" + e.fX + "," + e.fY;
			}
		}
		string coordenadas = "inicio";
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			info = (((PictureBox)sender).Tag.ToString());
		}
	}
}