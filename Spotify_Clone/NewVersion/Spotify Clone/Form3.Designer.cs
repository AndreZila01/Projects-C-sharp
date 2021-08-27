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
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pE_previous = new System.Windows.Forms.PictureBox();
			this.pE_PauseaPlay = new System.Windows.Forms.PictureBox();
			this.pE_Next = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pE_previous)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_PauseaPlay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Next)).BeginInit();
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
			// axWindowsMediaPlayer1
			// 
			this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(800, 450);
			this.axWindowsMediaPlayer1.TabIndex = 0;
			this.axWindowsMediaPlayer1.Tag = "expand";
			this.axWindowsMediaPlayer1.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.axWindowsMediaPlayer1_ClickEvent);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 400);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 50);
			this.panel1.TabIndex = 2;
			this.panel1.Visible = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(267, 50);
			this.panel2.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(533, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(267, 50);
			this.panel3.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
			this.panel4.Controls.Add(this.pE_Next);
			this.panel4.Controls.Add(this.pE_PauseaPlay);
			this.panel4.Controls.Add(this.pE_previous);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(267, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(266, 50);
			this.panel4.TabIndex = 2;
			// 
			// pE_previous
			// 
			this.pE_previous.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pE_previous.Image = global::Spotify_Clone.Properties.Resources.previous;
			this.pE_previous.Location = new System.Drawing.Point(47, 6);
			this.pE_previous.Name = "pE_previous";
			this.pE_previous.Size = new System.Drawing.Size(46, 35);
			this.pE_previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pE_previous.TabIndex = 0;
			this.pE_previous.TabStop = false;
			this.pE_previous.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pE_PauseaPlay
			// 
			this.pE_PauseaPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pE_PauseaPlay.Image = global::Spotify_Clone.Properties.Resources.pause;
			this.pE_PauseaPlay.Location = new System.Drawing.Point(110, 6);
			this.pE_PauseaPlay.Name = "pE_PauseaPlay";
			this.pE_PauseaPlay.Size = new System.Drawing.Size(46, 35);
			this.pE_PauseaPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pE_PauseaPlay.TabIndex = 1;
			this.pE_PauseaPlay.TabStop = false;
			this.pE_PauseaPlay.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pE_Next
			// 
			this.pE_Next.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pE_Next.Image = global::Spotify_Clone.Properties.Resources.next;
			this.pE_Next.Location = new System.Drawing.Point(173, 6);
			this.pE_Next.Name = "pE_Next";
			this.pE_Next.Size = new System.Drawing.Size(46, 35);
			this.pE_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pE_Next.TabIndex = 2;
			this.pE_Next.TabStop = false;
			this.pE_Next.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// Video
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.axWindowsMediaPlayer1);
			this.Controls.Add(this.progressBar1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Video";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Load += new System.EventHandler(this.Form3_Load);
			this.SizeChanged += new System.EventHandler(this.Form3_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pE_previous)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_PauseaPlay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Next)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer AuxMusic;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pE_previous;
		private System.Windows.Forms.PictureBox pE_Next;
		private System.Windows.Forms.PictureBox pE_PauseaPlay;
	}
}