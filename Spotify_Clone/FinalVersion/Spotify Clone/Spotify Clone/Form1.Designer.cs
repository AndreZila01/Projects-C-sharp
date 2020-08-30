namespace Spotify_Clone
{
	partial class Form1
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
			System.Windows.Forms.TrackBar trackBar1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.pE_minimizar = new System.Windows.Forms.PictureBox();
			this.pE_Close = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.pnlPrincipal = new System.Windows.Forms.Panel();
			this.PainelControl1 = new System.Windows.Forms.Panel();
			this.pnlPlayList = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.pictureEdit3 = new System.Windows.Forms.PictureBox();
			this.pnlControlo = new System.Windows.Forms.Panel();
			this.labelControl2 = new System.Windows.Forms.Label();
			this.labelControl4 = new System.Windows.Forms.Label();
			this.PBC = new System.Windows.Forms.ProgressBar();
			this.pE_Repit = new System.Windows.Forms.PictureBox();
			this.pE_Next = new System.Windows.Forms.PictureBox();
			this.pE_previous = new System.Windows.Forms.PictureBox();
			this.pE_PauseaPlay = new System.Windows.Forms.PictureBox();
			this.pE_Random = new System.Windows.Forms.PictureBox();
			this.pnlConteudo = new System.Windows.Forms.Panel();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.cmsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TSMIRemove = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMIAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMIEditPlayList = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			trackBar1 = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(trackBar1)).BeginInit();
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pE_minimizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Close)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			this.PainelControl1.SuspendLayout();
			this.pnlPlayList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3)).BeginInit();
			this.pnlControlo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pE_Repit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Next)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_previous)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_PauseaPlay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Random)).BeginInit();
			this.pnlConteudo.SuspendLayout();
			this.cmsMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// trackBar1
			// 
			trackBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			resources.ApplyResources(trackBar1, "trackBar1");
			trackBar1.Cursor = System.Windows.Forms.Cursors.Default;
			trackBar1.Name = "trackBar1";
			trackBar1.TabStop = false;
			trackBar1.Value = 5;
			trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.CadetBlue;
			this.pnlTop.Controls.Add(this.pE_minimizar);
			this.pnlTop.Controls.Add(this.pE_Close);
			resources.ApplyResources(this.pnlTop, "pnlTop");
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
			// 
			// pE_minimizar
			// 
			resources.ApplyResources(this.pE_minimizar, "pE_minimizar");
			this.pE_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pE_minimizar.Image = global::Spotify_Clone.Properties.Resources.minimize;
			this.pE_minimizar.Name = "pE_minimizar";
			this.pE_minimizar.TabStop = false;
			this.pE_minimizar.Click += new System.EventHandler(this.pE_minimizar_Click);
			// 
			// pE_Close
			// 
			resources.ApplyResources(this.pE_Close, "pE_Close");
			this.pE_Close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pE_Close.Image = global::Spotify_Clone.Properties.Resources.close_white;
			this.pE_Close.Name = "pE_Close";
			this.pE_Close.TabStop = false;
			this.pE_Close.Click += new System.EventHandler(this.pE_Close_Click);
			this.pE_Close.MouseLeave += new System.EventHandler(this.pE_Close_MouseLeave);
			this.pE_Close.MouseHover += new System.EventHandler(this.pE_Close_MouseHover);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.Controls.Add(this.axWindowsMediaPlayer1);
			this.panel2.Controls.Add(this.pnlPrincipal);
			resources.ApplyResources(this.panel2, "panel2");
			this.panel2.Name = "panel2";
			// 
			// axWindowsMediaPlayer1
			// 
			resources.ApplyResources(this.axWindowsMediaPlayer1, "axWindowsMediaPlayer1");
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.TabStop = false;
			this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
			// 
			// pnlPrincipal
			// 
			this.pnlPrincipal.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.pnlPrincipal, "pnlPrincipal");
			this.pnlPrincipal.Name = "pnlPrincipal";
			// 
			// PainelControl1
			// 
			this.PainelControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(154)))), ((int)(((byte)(158)))));
			this.PainelControl1.Controls.Add(this.pnlPlayList);
			this.PainelControl1.Controls.Add(this.pictureEdit3);
			resources.ApplyResources(this.PainelControl1, "PainelControl1");
			this.PainelControl1.Name = "PainelControl1";
			// 
			// pnlPlayList
			// 
			this.pnlPlayList.BackColor = System.Drawing.Color.Transparent;
			this.pnlPlayList.Controls.Add(this.flowLayoutPanel1);
			resources.ApplyResources(this.pnlPlayList, "pnlPlayList");
			this.pnlPlayList.Name = "pnlPlayList";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			// 
			// pictureEdit3
			// 
			this.pictureEdit3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureEdit3.Image = global::Spotify_Clone.Properties.Resources.add;
			resources.ApplyResources(this.pictureEdit3, "pictureEdit3");
			this.pictureEdit3.Name = "pictureEdit3";
			this.pictureEdit3.TabStop = false;
			this.pictureEdit3.Click += new System.EventHandler(this.pictureEdit3_Click);
			// 
			// pnlControlo
			// 
			this.pnlControlo.BackColor = System.Drawing.Color.CadetBlue;
			this.pnlControlo.Controls.Add(this.labelControl2);
			this.pnlControlo.Controls.Add(trackBar1);
			this.pnlControlo.Controls.Add(this.labelControl4);
			this.pnlControlo.Controls.Add(this.PBC);
			this.pnlControlo.Controls.Add(this.pE_Repit);
			this.pnlControlo.Controls.Add(this.pE_Next);
			this.pnlControlo.Controls.Add(this.pE_previous);
			this.pnlControlo.Controls.Add(this.pE_PauseaPlay);
			this.pnlControlo.Controls.Add(this.pE_Random);
			resources.ApplyResources(this.pnlControlo, "pnlControlo");
			this.pnlControlo.Name = "pnlControlo";
			// 
			// labelControl2
			// 
			resources.ApplyResources(this.labelControl2, "labelControl2");
			this.labelControl2.Name = "labelControl2";
			// 
			// labelControl4
			// 
			resources.ApplyResources(this.labelControl4, "labelControl4");
			this.labelControl4.Name = "labelControl4";
			// 
			// PBC
			// 
			resources.ApplyResources(this.PBC, "PBC");
			this.PBC.Name = "PBC";
			// 
			// pE_Repit
			// 
			resources.ApplyResources(this.pE_Repit, "pE_Repit");
			this.pE_Repit.BackColor = System.Drawing.Color.Transparent;
			this.pE_Repit.Image = global::Spotify_Clone.Properties.Resources.refresh__3_;
			this.pE_Repit.Name = "pE_Repit";
			this.pE_Repit.TabStop = false;
			this.pE_Repit.Click += new System.EventHandler(this.pictureBox5_Click);
			// 
			// pE_Next
			// 
			resources.ApplyResources(this.pE_Next, "pE_Next");
			this.pE_Next.BackColor = System.Drawing.Color.Transparent;
			this.pE_Next.Image = global::Spotify_Clone.Properties.Resources.next;
			this.pE_Next.Name = "pE_Next";
			this.pE_Next.TabStop = false;
			this.pE_Next.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// pE_previous
			// 
			resources.ApplyResources(this.pE_previous, "pE_previous");
			this.pE_previous.BackColor = System.Drawing.Color.Transparent;
			this.pE_previous.Image = global::Spotify_Clone.Properties.Resources.previous;
			this.pE_previous.Name = "pE_previous";
			this.pE_previous.TabStop = false;
			this.pE_previous.Click += new System.EventHandler(this.pE_previous_Click);
			// 
			// pE_PauseaPlay
			// 
			resources.ApplyResources(this.pE_PauseaPlay, "pE_PauseaPlay");
			this.pE_PauseaPlay.BackColor = System.Drawing.Color.Transparent;
			this.pE_PauseaPlay.Image = global::Spotify_Clone.Properties.Resources.play;
			this.pE_PauseaPlay.Name = "pE_PauseaPlay";
			this.pE_PauseaPlay.TabStop = false;
			this.pE_PauseaPlay.Click += new System.EventHandler(this.pE_PauseaPlay_Click);
			// 
			// pE_Random
			// 
			resources.ApplyResources(this.pE_Random, "pE_Random");
			this.pE_Random.BackColor = System.Drawing.Color.Transparent;
			this.pE_Random.Image = global::Spotify_Clone.Properties.Resources.change;
			this.pE_Random.Name = "pE_Random";
			this.pE_Random.TabStop = false;
			this.pE_Random.Click += new System.EventHandler(this.pE_Random_Click);
			// 
			// pnlConteudo
			// 
			this.pnlConteudo.Controls.Add(this.panel2);
			this.pnlConteudo.Controls.Add(this.PainelControl1);
			resources.ApplyResources(this.pnlConteudo, "pnlConteudo");
			this.pnlConteudo.Name = "pnlConteudo";
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// cmsMenuStrip
			// 
			this.cmsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIRemove,
            this.TSMIAdd,
            this.TSMIEditPlayList});
			this.cmsMenuStrip.Name = "contextMenuStrip1";
			resources.ApplyResources(this.cmsMenuStrip, "cmsMenuStrip");
			// 
			// TSMIRemove
			// 
			this.TSMIRemove.Image = global::Spotify_Clone.Properties.Resources.delete;
			this.TSMIRemove.Name = "TSMIRemove";
			resources.ApplyResources(this.TSMIRemove, "TSMIRemove");
			this.TSMIRemove.Click += new System.EventHandler(this.removeThePlayListToolStripMenuItem_Click);
			// 
			// TSMIAdd
			// 
			this.TSMIAdd.Image = global::Spotify_Clone.Properties.Resources.iconfinder_00_ELASTOFONT_STORE_READY_music_2703070;
			this.TSMIAdd.Name = "TSMIAdd";
			resources.ApplyResources(this.TSMIAdd, "TSMIAdd");
			this.TSMIAdd.Click += new System.EventHandler(this.addMusicToolStripMenuItem_Click);
			// 
			// TSMIEditPlayList
			// 
			this.TSMIEditPlayList.Image = global::Spotify_Clone.Properties.Resources.iconfinder_00_ELASTOFONT_STORE_READY_sliders_2738302;
			this.TSMIEditPlayList.Name = "TSMIEditPlayList";
			resources.ApplyResources(this.TSMIEditPlayList, "TSMIEditPlayList");
			this.TSMIEditPlayList.Click += new System.EventHandler(this.editPlayListToolStripMenuItem_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlConteudo);
			this.Controls.Add(this.pnlControlo);
			this.Controls.Add(this.pnlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)(trackBar1)).EndInit();
			this.pnlTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pE_minimizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Close)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			this.PainelControl1.ResumeLayout(false);
			this.pnlPlayList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3)).EndInit();
			this.pnlControlo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pE_Repit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Next)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_previous)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_PauseaPlay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Random)).EndInit();
			this.pnlConteudo.ResumeLayout(false);
			this.cmsMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.PictureBox pE_minimizar;
		private System.Windows.Forms.PictureBox pE_Close;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel PainelControl1;
		private System.Windows.Forms.PictureBox pictureEdit3;
		private System.Windows.Forms.Panel pnlPlayList;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel pnlControlo;
		private System.Windows.Forms.Panel pnlConteudo;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
		private System.Windows.Forms.Panel pnlPrincipal;
		private System.Windows.Forms.PictureBox pE_Repit;
		private System.Windows.Forms.PictureBox pE_Next;
		private System.Windows.Forms.PictureBox pE_previous;
		private System.Windows.Forms.PictureBox pE_PauseaPlay;
		private System.Windows.Forms.PictureBox pE_Random;
		private System.Windows.Forms.ProgressBar PBC;
		private System.Windows.Forms.Label labelControl4;
		private System.Windows.Forms.Label labelControl2;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ContextMenuStrip cmsMenuStrip;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem TSMIRemove;
		private System.Windows.Forms.ToolStripMenuItem TSMIAdd;
		private System.Windows.Forms.ToolStripMenuItem TSMIEditPlayList;
		private System.Windows.Forms.Timer timer2;
	}
}

