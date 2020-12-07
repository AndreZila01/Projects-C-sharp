using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify_Clone
{
	
	public partial class Video : Form
	{
		public static int progresso;public static double maxprogresso;string OldMusic;
		public Video(){InitializeComponent();}
		public void timer1_Tick(object sender,EventArgs e)
		{
			try
			{
				axWindowsMediaPlayer1.settings.volume=int.Parse(Form1.Volume);
			}
			catch{}
			
			if(OldMusic!= Form1.CaMusica)
			{
				axWindowsMediaPlayer1.URL=Form1.CaMusica;
				OldMusic=axWindowsMediaPlayer1.URL;
				timer1.Stop();
				string[] DT=OldMusic.Split(new string[]{"\\"},StringSplitOptions.None);
				this.Text=DT[DT.Count()-1];
				progressBar1.Maximum=(int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
				AuxMusic.Start();
			}
			
			switch(Form1.Processo)
			{
				case "start":
					axWindowsMediaPlayer1.Ctlcontrols.play();
					AuxMusic.Stop();
					AuxMusic.Start();
					break;
				case "pause":
					axWindowsMediaPlayer1.Ctlcontrols.pause();
					AuxMusic.Stop();break;}if(progressBar1.Value==progressBar1.Maximum || progressBar1.Value==(progressBar1.Maximum-1) && progressBar1.Value!=0){axWindowsMediaPlayer1.URL=Form1.CaMusica;axWindowsMediaPlayer1.settings.volume=int.Parse(Form1.Volume);OldMusic=axWindowsMediaPlayer1.URL;axWindowsMediaPlayer1.Ctlcontrols.play();this.Text=(Form1.NameMusic[(Form1.NameMusic.Length-1)].Substring(0,(Form1.NameMusic[(Form1.NameMusic.Length-1)].Count()-4)));}Form1.Processo=".";}
		private void Form3_SizeChanged(object sender,EventArgs e){if(this.Width<215)this.Size=new Size(215,this.Height);if(this.Height<175)this.Size=new Size(this.Width,175);}
		private void Form3_Load(object sender,EventArgs e)
		{
			timer1.Start();
			axWindowsMediaPlayer1.URL=Form1.CaMusica;
			axWindowsMediaPlayer1.settings.volume=int.Parse(Form1.Volume);
			OldMusic=axWindowsMediaPlayer1.URL;
			axWindowsMediaPlayer1.Ctlcontrols.play();
			this.Text=(Form1.NameMusic[(Form1.NameMusic.Length-1)].Substring(0,(Form1.NameMusic[(Form1.NameMusic.Length-1)].Count()-4)));
			AuxMusic.Interval=1;
			AuxMusic.Start();
			timer1.Stop();
		}

		private void AuxMusic_Tick(object sender,EventArgs e)
		{
			if(axWindowsMediaPlayer1.playState==WMPLib.WMPPlayState.wmppsPlaying)
			{
				progressBar1.Maximum=(int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
				maxprogresso=axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
				progressBar1.Value=(int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
				progresso=(int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
			}
		}
	}
}
