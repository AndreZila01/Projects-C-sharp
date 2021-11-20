using System;

namespace Spotify_Clone
{
	partial class Video
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.AuxMusic = new System.Windows.Forms.Timer(this.components);
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.AuxMouse = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pctPausa = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctPausa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// AuxMusic
			// 
			this.AuxMusic.Tick += new System.EventHandler(this.AuxMusic_Tick);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(358, 154);
			this.progressBar1.Maximum = 10000;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(100, 23);
			this.progressBar1.TabIndex = 1;
			this.progressBar1.Visible = false;
			// 
			// AuxMouse
			// 
			this.AuxMouse.Tick += new System.EventHandler(this.AuxMouse_Tick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.CadetBlue;
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 365);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(713, 46);
			this.panel1.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel5.BackColor = System.Drawing.Color.PowderBlue;
			this.panel5.Controls.Add(this.pictureBox3);
			this.panel5.Controls.Add(this.pctPausa);
			this.panel5.Controls.Add(this.pictureBox1);
			this.panel5.Location = new System.Drawing.Point(256, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(202, 46);
			this.panel5.TabIndex = 6;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::Spotify_Clone.Properties.Resources.nextB;
			this.pictureBox3.Location = new System.Drawing.Point(154, 3);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(42, 40);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Tag = "pE_Next";
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pctPausa
			// 
			this.pctPausa.Image = global::Spotify_Clone.Properties.Resources.playB;
			this.pctPausa.Location = new System.Drawing.Point(87, 3);
			this.pctPausa.Name = "pctPausa";
			this.pctPausa.Size = new System.Drawing.Size(42, 40);
			this.pctPausa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctPausa.TabIndex = 1;
			this.pctPausa.TabStop = false;
			this.pctPausa.Tag = "pE_PauseaPlay";
			this.pctPausa.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Spotify_Clone.Properties.Resources.previousB;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(42, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "pE_previous";
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.CadetBlue;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(457, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(256, 46);
			this.panel3.TabIndex = 5;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.CadetBlue;
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(256, 46);
			this.panel4.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.axWindowsMediaPlayer1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(713, 365);
			this.panel2.TabIndex = 3;
			// 
			// axWindowsMediaPlayer1
			// 
			this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(713, 365);
			this.axWindowsMediaPlayer1.TabIndex = 0;
			this.axWindowsMediaPlayer1.Tag = "expand";
			this.axWindowsMediaPlayer1.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.axWindowsMediaPlayer1_ClickEvent);
			this.axWindowsMediaPlayer1.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.axWindowsMediaPlayer1_MouseMoveEvent);
			// 
			// Video
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(713, 411);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.progressBar1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Video";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Tag = "expand";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.SizeChanged += new System.EventHandler(this.Form3_SizeChanged);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctPausa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer AuxMusic;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer AuxMouse;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pctPausa;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}