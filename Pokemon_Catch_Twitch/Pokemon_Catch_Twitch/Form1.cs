using Pokemon_Catch_Twitch.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

			//PictureBox pct = new PictureBox();
			//pct.Name = "pctstart";
			//pct.Location = new Point(0, 30);
			//pct.Size = new Size(60, 50);
			//pct.Image = Properties.Resources.starxl;
			//pct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
			//pct.SizeMode = PictureBoxSizeMode.Zoom;
			//pictureBox8.Controls.Add(pct);
			//pct = new PictureBox();
			//pct.Name = "pctstart";
			//pct.Location = new Point(70, 30);
			//pct.Size = new Size(60, 50);
			//pct.Image = Properties.Resources.star1xl;
			//pct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
			//pct.SizeMode = PictureBoxSizeMode.Zoom;
			//pictureBox8.Controls.Add(pct);
			//pct = new PictureBox();
			//pct.Name = "pctstart";
			//pct.Location = new Point(140, 30);
			//pct.Size = new Size(60, 50);
			//pct.Image = Properties.Resources.starxl;
			//pct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
			//pct.SizeMode = PictureBoxSizeMode.Zoom;
			//pictureBox8.Controls.Add(pct);
			//pct = new PictureBox();
			//pct.Name = "pctstart";
			//pct.Location = new Point(35, 65);
			//pct.Size = new Size(60, 50);
			//pct.Image = Properties.Resources.starl;
			//pct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
			//pct.SizeMode = PictureBoxSizeMode.Zoom;
			//pictureBox8.Controls.Add(pct);
			//pct = new PictureBox();
			//pct.Name = "pctstart";
			//pct.Location = new Point(105, 65);
			//pct.Size = new Size(30, 25);
			//pct.Image = Properties.Resources.starxs;
			//pct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
			//pct.SizeMode = PictureBoxSizeMode.Zoom;
			//pictureBox8.Controls.Add(pct);
			tmPokeball.Start();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			//https://projectpokemon.org/home/docs/spriteindex_148/3d-models-generation-8-pok%C3%A9mon-r123/
			Data bk = new Data();
			pictureBox2.LoadAsync("https://projectpokemon.org/images/sprites-models/swsh-shiny-sprites/corviknight.gif");
			//bk.WriteRead();
		}
		int times = 0;
		private void tmPokeball_Tick(object sender, EventArgs e)
		{
			for (int ds = 1; ds < 17; ds++)
			{
				pictureBox1.Location = new Point((5 + pictureBox1.Location.X), (1 + pictureBox1.Location.Y));

				Debug.Print("" + ds);//7
			}

			times++;
			if (times == 7)
			{
				int ds = 1;
				do
				{
					pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + ds);
					ds++;
				} while (ds < 10);
				float angle = (float)80;
				RotateImage(pictureBox1, pictureBox1.Image, angle);
			}

		}
		private async void RotateImage(PictureBox pb, Image img, float angle)
		{
			tmPokeball.Stop();
			pictureBox2.Visible = false;
			bit = new Bitmap(pictureBox1.Image);

			Invalidate(true);

			for (int ds = 0; ds > -3004; ds--)
			{
				pictureBox1.Image = Utilities.RotateImage(bit, (ds / 100));
				pictureBox1.Update();
			}
			Debug.Print("rotate 1");

			bit = new Bitmap(pictureBox1.Image);

			for (int ds = 0; ds < 4008; ds++)
			{
				//Debug.Print(ds + "/2=" + (ds / 2));
				pictureBox1.Image = Utilities.RotateImage(bit, (ds) / 100);
				pictureBox1.Update();
			}

			bit = new Bitmap(pictureBox1.Image);
			for (int ds = 0; ds > -1500; ds--)
			{
				pictureBox1.Image = Utilities.RotateImage(bit, (ds / 100));
				pictureBox1.Update();
			}
			bit = new Bitmap(Properties.Resources.pokeball);
			for (int ds = 0; ds > -3004; ds--)
			{
				pictureBox1.Image = Utilities.RotateImage(bit, (ds / 100));
				pictureBox1.Update();
			}
			bit = new Bitmap(pictureBox1.Image);
			for (int ds = 0; ds < 3000; ds++)
			{
				pictureBox1.Image = Utilities.RotateImage(bit, (ds / 100));
				pictureBox1.Update();
			}
			bit = new Bitmap(Properties.Resources.pokeball);

			Debug.Print("rotate 1");


			//for (int ds = 0; ds < 30; ds++)
			//{
			//	pictureBox8.Size = new Size(pictureBox8.Size.Width + 2, pictureBox8.Size.Height + 2);
			//	pictureBox8.Location = new Point(pictureBox8.Location.X - 1, pictureBox8.Location.Y - 1);
			//	pictureBox8.Update();
			//}



		}

		Bitmap bit;
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			tmPokeball.Stop();
		}

	}
}
