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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.pE_MaxMin = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlConteudo = new System.Windows.Forms.Panel();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.cmsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TSMIRemove = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMIEditPlayList = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pE_MaxMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_minimizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Close)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			this.PainelControl1.SuspendLayout();
			this.pnlPlayList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3)).BeginInit();
			this.pnlControlo.SuspendLayout();
			this.panel3.SuspendLayout();
			this.pnlConteudo.SuspendLayout();
			this.cmsMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.CadetBlue;
			this.pnlTop.Controls.Add(this.pE_MaxMin);
			this.pnlTop.Controls.Add(this.pictureBox1);
			this.pnlTop.Controls.Add(this.pE_minimizar);
			this.pnlTop.Controls.Add(this.pE_Close);
			resources.ApplyResources(this.pnlTop, "pnlTop");
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
			// 
			// pE_MaxMin
			// 
			resources.ApplyResources(this.pE_MaxMin, "pE_MaxMin");
			this.pE_MaxMin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pE_MaxMin.Image = global::Spotify_Clone.Properties.Resources.expand__1_;
			this.pE_MaxMin.Name = "pE_MaxMin";
			this.pE_MaxMin.TabStop = false;
			this.pE_MaxMin.Click += new System.EventHandler(this.pE_Click);
			// 
			// pictureBox1
			// 
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Image = global::Spotify_Clone.Properties.Resources.full_screen;
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pE_minimizar
			// 
			resources.ApplyResources(this.pE_minimizar, "pE_minimizar");
			this.pE_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pE_minimizar.Image = global::Spotify_Clone.Properties.Resources.minimize;
			this.pE_minimizar.Name = "pE_minimizar";
			this.pE_minimizar.TabStop = false;
			// 
			// pE_Close
			// 
			resources.ApplyResources(this.pE_Close, "pE_Close");
			this.pE_Close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pE_Close.Image = global::Spotify_Clone.Properties.Resources.close_white;
			this.pE_Close.Name = "pE_Close";
			this.pE_Close.TabStop = false;
			this.pE_Close.Click += new System.EventHandler(this.pE_Click);
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
			this.pnlControlo.Controls.Add(this.panel3);
			resources.ApplyResources(this.pnlControlo, "pnlControlo");
			this.pnlControlo.Name = "pnlControlo";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.panel1);
			resources.ApplyResources(this.panel3, "panel3");
			this.panel3.Name = "panel3";
			// 
			// panel5
			// 
			resources.ApplyResources(this.panel5, "panel5");
			this.panel5.Name = "panel5";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Teal;
			resources.ApplyResources(this.panel4, "panel4");
			this.panel4.Name = "panel4";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
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
			this.pnlTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pE_MaxMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_minimizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Close)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			this.PainelControl1.ResumeLayout(false);
			this.pnlPlayList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3)).EndInit();
			this.pnlControlo.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
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
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ContextMenuStrip cmsMenuStrip;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem TSMIRemove;
		private System.Windows.Forms.ToolStripMenuItem TSMIEditPlayList;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.Windows.Forms.PictureBox pE_MaxMin;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
	}
}

