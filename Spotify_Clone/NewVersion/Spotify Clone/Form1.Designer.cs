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
			this.picXAMPP = new System.Windows.Forms.PictureBox();
			this.picSettings = new System.Windows.Forms.PictureBox();
			this.pE_MaxMin = new System.Windows.Forms.PictureBox();
			this.picForm3 = new System.Windows.Forms.PictureBox();
			this.pE_minimizar = new System.Windows.Forms.PictureBox();
			this.pE_Close = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlPrincipal = new System.Windows.Forms.Panel();
			this.PainelControl1 = new System.Windows.Forms.Panel();
			this.pnlPlayList = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.picAddPlaylist = new System.Windows.Forms.PictureBox();
			this.pnlControlo = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.pE_Random = new System.Windows.Forms.PictureBox();
			this.pE_Repit = new System.Windows.Forms.PictureBox();
			this.pE_Next = new System.Windows.Forms.PictureBox();
			this.pE_PauseaPlay = new System.Windows.Forms.PictureBox();
			this.pE_previous = new System.Windows.Forms.PictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.labelControl4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.picInfos = new System.Windows.Forms.PictureBox();
			this.labelControl2 = new System.Windows.Forms.Label();
			this.pnlConteudo = new System.Windows.Forms.Panel();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.cmsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TSMIRemove = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMIEditPlayList = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.bgwCarregar = new System.ComponentModel.BackgroundWorker();
			this.pnlCont = new System.Windows.Forms.Panel();
			this.pnlSettings = new System.Windows.Forms.Panel();
			this.lblVersao = new System.Windows.Forms.Label();
			this.pnlXampp = new System.Windows.Forms.Panel();
			this.pctXAMPP = new System.Windows.Forms.PictureBox();
			this.txtXAMPP = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.pnlAtalho = new System.Windows.Forms.Panel();
			this.lblSeguinte = new System.Windows.Forms.Label();
			this.lblPR = new System.Windows.Forms.Label();
			this.lblAnterior = new System.Windows.Forms.Label();
			this.lblPaRe = new System.Windows.Forms.Label();
			this.btnPausa = new System.Windows.Forms.Button();
			this.lblAnt = new System.Windows.Forms.Label();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.lblSeg = new System.Windows.Forms.Label();
			this.btnNext = new System.Windows.Forms.Button();
			this.panel10 = new System.Windows.Forms.Panel();
			this.lbltec = new System.Windows.Forms.Label();
			this.chkAtalho = new System.Windows.Forms.CheckBox();
			this.pnlDiscord = new System.Windows.Forms.Panel();
			this.lblinfoDu = new System.Windows.Forms.Label();
			this.lblDuracao = new System.Windows.Forms.Label();
			this.lblNomeDisc = new System.Windows.Forms.Label();
			this.panel9 = new System.Windows.Forms.Panel();
			this.chkDiscord = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.lblInfoMusic = new System.Windows.Forms.Label();
			this.lblnotif = new System.Windows.Forms.Label();
			this.lblMini = new System.Windows.Forms.Label();
			this.lblTitMini = new System.Windows.Forms.Label();
			this.pctPaths = new System.Windows.Forms.PictureBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtPaths = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.lblSO = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lblEscIdioma = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.lblIdioma = new System.Windows.Forms.Label();
			this.panel14 = new System.Windows.Forms.Panel();
			this.icnNotification = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TSMIPrevious = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMIPause = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMINext = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.TSMIClose = new System.Windows.Forms.ToolStripMenuItem();
			this.tmAtalho = new System.Windows.Forms.Timer(this.components);
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.PBC = new Spotify_Clone.Extensions.PBC();
			this.switchDuracao = new CustomControls.RJControls.RJToggleButton();
			this.switchNome = new CustomControls.RJControls.RJToggleButton();
			this.switchMusic = new CustomControls.RJControls.RJToggleButton();
			this.switchMini = new CustomControls.RJControls.RJToggleButton();
			this.switchSO = new CustomControls.RJControls.RJToggleButton();
			trackBar1 = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(trackBar1)).BeginInit();
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picXAMPP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_MaxMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picForm3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_minimizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Close)).BeginInit();
			this.panel2.SuspendLayout();
			this.PainelControl1.SuspendLayout();
			this.pnlPlayList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAddPlaylist)).BeginInit();
			this.pnlControlo.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pE_Random)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Repit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Next)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_PauseaPlay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_previous)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picInfos)).BeginInit();
			this.pnlConteudo.SuspendLayout();
			this.cmsMenuStrip.SuspendLayout();
			this.pnlCont.SuspendLayout();
			this.pnlSettings.SuspendLayout();
			this.pnlXampp.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctXAMPP)).BeginInit();
			this.pnlAtalho.SuspendLayout();
			this.panel10.SuspendLayout();
			this.pnlDiscord.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctPaths)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			this.SuspendLayout();
			// 
			// trackBar1
			// 
			trackBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			resources.ApplyResources(trackBar1, "trackBar1");
			trackBar1.CausesValidation = false;
			trackBar1.Cursor = System.Windows.Forms.Cursors.Default;
			trackBar1.Name = "trackBar1";
			trackBar1.TabStop = false;
			trackBar1.Value = 5;
			trackBar1.Click += new System.EventHandler(this.trackBar1_Click);
			trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.CadetBlue;
			this.pnlTop.Controls.Add(this.picXAMPP);
			this.pnlTop.Controls.Add(this.picSettings);
			this.pnlTop.Controls.Add(this.pE_MaxMin);
			this.pnlTop.Controls.Add(this.picForm3);
			this.pnlTop.Controls.Add(this.pE_minimizar);
			this.pnlTop.Controls.Add(this.pE_Close);
			resources.ApplyResources(this.pnlTop, "pnlTop");
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Tag = "0";
			this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
			// 
			// picXAMPP
			// 
			resources.ApplyResources(this.picXAMPP, "picXAMPP");
			this.picXAMPP.Name = "picXAMPP";
			this.picXAMPP.TabStop = false;
			this.picXAMPP.Click += new System.EventHandler(this.pE_Click);
			// 
			// picSettings
			// 
			resources.ApplyResources(this.picSettings, "picSettings");
			this.picSettings.Image = global::Spotify_Clone.Properties.Resources.settings;
			this.picSettings.Name = "picSettings";
			this.picSettings.TabStop = false;
			this.picSettings.Click += new System.EventHandler(this.pE_Click);
			// 
			// pE_MaxMin
			// 
			resources.ApplyResources(this.pE_MaxMin, "pE_MaxMin");
			this.pE_MaxMin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pE_MaxMin.Name = "pE_MaxMin";
			this.pE_MaxMin.TabStop = false;
			this.pE_MaxMin.Click += new System.EventHandler(this.pE_Click);
			// 
			// picForm3
			// 
			resources.ApplyResources(this.picForm3, "picForm3");
			this.picForm3.Name = "picForm3";
			this.picForm3.TabStop = false;
			this.picForm3.Click += new System.EventHandler(this.pE_Click);
			// 
			// pE_minimizar
			// 
			resources.ApplyResources(this.pE_minimizar, "pE_minimizar");
			this.pE_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pE_minimizar.Name = "pE_minimizar";
			this.pE_minimizar.TabStop = false;
			this.pE_minimizar.Click += new System.EventHandler(this.pE_Click);
			// 
			// pE_Close
			// 
			resources.ApplyResources(this.pE_Close, "pE_Close");
			this.pE_Close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pE_Close.Name = "pE_Close";
			this.pE_Close.TabStop = false;
			this.pE_Close.Click += new System.EventHandler(this.pE_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.Controls.Add(this.axWindowsMediaPlayer1);
			this.panel2.Controls.Add(this.pnlPrincipal);
			resources.ApplyResources(this.panel2, "panel2");
			this.panel2.Name = "panel2";
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
			this.PainelControl1.Controls.Add(this.picAddPlaylist);
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
			// picAddPlaylist
			// 
			this.picAddPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.picAddPlaylist, "picAddPlaylist");
			this.picAddPlaylist.Name = "picAddPlaylist";
			this.picAddPlaylist.TabStop = false;
			this.picAddPlaylist.Click += new System.EventHandler(this.pE_Click);
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
			this.panel5.Controls.Add(this.panel7);
			this.panel5.Controls.Add(this.panel6);
			resources.ApplyResources(this.panel5, "panel5");
			this.panel5.Name = "panel5";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(142)))), ((int)(((byte)(144)))));
			this.panel7.Controls.Add(this.PBC);
			resources.ApplyResources(this.panel7, "panel7");
			this.panel7.Name = "panel7";
			this.panel7.Tag = " ";
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.pE_Random);
			this.panel6.Controls.Add(this.pE_Repit);
			this.panel6.Controls.Add(this.pE_Next);
			this.panel6.Controls.Add(this.pE_PauseaPlay);
			this.panel6.Controls.Add(this.pE_previous);
			resources.ApplyResources(this.panel6, "panel6");
			this.panel6.Name = "panel6";
			// 
			// pE_Random
			// 
			resources.ApplyResources(this.pE_Random, "pE_Random");
			this.pE_Random.Name = "pE_Random";
			this.pE_Random.TabStop = false;
			this.pE_Random.Tag = "0";
			this.pE_Random.Click += new System.EventHandler(this.pE_Click);
			// 
			// pE_Repit
			// 
			resources.ApplyResources(this.pE_Repit, "pE_Repit");
			this.pE_Repit.Name = "pE_Repit";
			this.pE_Repit.TabStop = false;
			this.pE_Repit.Tag = "0";
			this.pE_Repit.Click += new System.EventHandler(this.pE_Click);
			// 
			// pE_Next
			// 
			resources.ApplyResources(this.pE_Next, "pE_Next");
			this.pE_Next.Name = "pE_Next";
			this.pE_Next.TabStop = false;
			this.pE_Next.Click += new System.EventHandler(this.pE_Click);
			// 
			// pE_PauseaPlay
			// 
			resources.ApplyResources(this.pE_PauseaPlay, "pE_PauseaPlay");
			this.pE_PauseaPlay.Name = "pE_PauseaPlay";
			this.pE_PauseaPlay.TabStop = false;
			this.pE_PauseaPlay.Tag = "0";
			this.pE_PauseaPlay.Click += new System.EventHandler(this.pE_Click);
			// 
			// pE_previous
			// 
			resources.ApplyResources(this.pE_previous, "pE_previous");
			this.pE_previous.Name = "pE_previous";
			this.pE_previous.TabStop = false;
			this.pE_previous.Click += new System.EventHandler(this.pE_Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Teal;
			this.panel4.Controls.Add(trackBar1);
			this.panel4.Controls.Add(this.labelControl4);
			resources.ApplyResources(this.panel4, "panel4");
			this.panel4.Name = "panel4";
			// 
			// labelControl4
			// 
			resources.ApplyResources(this.labelControl4, "labelControl4");
			this.labelControl4.Name = "labelControl4";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel1.Controls.Add(this.picInfos);
			this.panel1.Controls.Add(this.labelControl2);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// picInfos
			// 
			resources.ApplyResources(this.picInfos, "picInfos");
			this.picInfos.Image = global::Spotify_Clone.Properties.Resources.info;
			this.picInfos.Name = "picInfos";
			this.picInfos.TabStop = false;
			this.picInfos.Click += new System.EventHandler(this.pE_Click);
			// 
			// labelControl2
			// 
			resources.ApplyResources(this.labelControl2, "labelControl2");
			this.labelControl2.Name = "labelControl2";
			// 
			// pnlConteudo
			// 
			this.pnlConteudo.Controls.Add(this.panel2);
			this.pnlConteudo.Controls.Add(this.PainelControl1);
			resources.ApplyResources(this.pnlConteudo, "pnlConteudo");
			this.pnlConteudo.Name = "pnlConteudo";
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
			resources.ApplyResources(this.TSMIRemove, "TSMIRemove");
			this.TSMIRemove.Name = "TSMIRemove";
			this.TSMIRemove.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// TSMIEditPlayList
			// 
			resources.ApplyResources(this.TSMIEditPlayList, "TSMIEditPlayList");
			this.TSMIEditPlayList.Name = "TSMIEditPlayList";
			this.TSMIEditPlayList.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tag = "0";
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Tag = "0";
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// bgwCarregar
			// 
			this.bgwCarregar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCarregar_DoWork);
			this.bgwCarregar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCarregar_RunWorkerCompleted);
			// 
			// pnlCont
			// 
			this.pnlCont.Controls.Add(this.pnlControlo);
			this.pnlCont.Controls.Add(this.pnlConteudo);
			resources.ApplyResources(this.pnlCont, "pnlCont");
			this.pnlCont.Name = "pnlCont";
			// 
			// pnlSettings
			// 
			resources.ApplyResources(this.pnlSettings, "pnlSettings");
			this.pnlSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
			this.pnlSettings.Controls.Add(this.lblVersao);
			this.pnlSettings.Controls.Add(this.pnlXampp);
			this.pnlSettings.Controls.Add(this.pnlAtalho);
			this.pnlSettings.Controls.Add(this.panel10);
			this.pnlSettings.Controls.Add(this.pnlDiscord);
			this.pnlSettings.Controls.Add(this.panel9);
			this.pnlSettings.Controls.Add(this.panel8);
			this.pnlSettings.Controls.Add(this.panel14);
			this.pnlSettings.Name = "pnlSettings";
			this.pnlSettings.Tag = "0";
			// 
			// lblVersao
			// 
			resources.ApplyResources(this.lblVersao, "lblVersao");
			this.lblVersao.Name = "lblVersao";
			this.lblVersao.Click += new System.EventHandler(this.label11_Click);
			// 
			// pnlXampp
			// 
			this.pnlXampp.Controls.Add(this.pctXAMPP);
			this.pnlXampp.Controls.Add(this.txtXAMPP);
			this.pnlXampp.Controls.Add(this.label15);
			resources.ApplyResources(this.pnlXampp, "pnlXampp");
			this.pnlXampp.Name = "pnlXampp";
			// 
			// pctXAMPP
			// 
			resources.ApplyResources(this.pctXAMPP, "pctXAMPP");
			this.pctXAMPP.Image = global::Spotify_Clone.Properties.Resources.arquivo_aberto;
			this.pctXAMPP.Name = "pctXAMPP";
			this.pctXAMPP.TabStop = false;
			this.pctXAMPP.Click += new System.EventHandler(this.pE_Click);
			// 
			// txtXAMPP
			// 
			resources.ApplyResources(this.txtXAMPP, "txtXAMPP");
			this.txtXAMPP.Name = "txtXAMPP";
			// 
			// label15
			// 
			resources.ApplyResources(this.label15, "label15");
			this.label15.Name = "label15";
			// 
			// pnlAtalho
			// 
			this.pnlAtalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
			this.pnlAtalho.Controls.Add(this.lblSeguinte);
			this.pnlAtalho.Controls.Add(this.lblPR);
			this.pnlAtalho.Controls.Add(this.lblAnterior);
			this.pnlAtalho.Controls.Add(this.lblPaRe);
			this.pnlAtalho.Controls.Add(this.btnPausa);
			this.pnlAtalho.Controls.Add(this.lblAnt);
			this.pnlAtalho.Controls.Add(this.btnAnterior);
			this.pnlAtalho.Controls.Add(this.lblSeg);
			this.pnlAtalho.Controls.Add(this.btnNext);
			resources.ApplyResources(this.pnlAtalho, "pnlAtalho");
			this.pnlAtalho.Name = "pnlAtalho";
			this.pnlAtalho.Tag = "800, 94";
			// 
			// lblSeguinte
			// 
			resources.ApplyResources(this.lblSeguinte, "lblSeguinte");
			this.lblSeguinte.Name = "lblSeguinte";
			this.lblSeguinte.Tag = "musica Seguinte";
			this.lblSeguinte.Click += new System.EventHandler(this.label11_Click);
			// 
			// lblPR
			// 
			resources.ApplyResources(this.lblPR, "lblPR");
			this.lblPR.Name = "lblPR";
			this.lblPR.Tag = "Pausar e Retomar";
			this.lblPR.Click += new System.EventHandler(this.label11_Click);
			// 
			// lblAnterior
			// 
			resources.ApplyResources(this.lblAnterior, "lblAnterior");
			this.lblAnterior.Name = "lblAnterior";
			this.lblAnterior.Tag = "Musica Anterior";
			this.lblAnterior.Click += new System.EventHandler(this.label11_Click);
			// 
			// lblPaRe
			// 
			resources.ApplyResources(this.lblPaRe, "lblPaRe");
			this.lblPaRe.Name = "lblPaRe";
			// 
			// btnPausa
			// 
			resources.ApplyResources(this.btnPausa, "btnPausa");
			this.btnPausa.Name = "btnPausa";
			this.btnPausa.Tag = " ";
			this.btnPausa.UseVisualStyleBackColor = true;
			this.btnPausa.Click += new System.EventHandler(this.Btn_TeclasAtalhos);
			this.btnPausa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAnterior_KeyDown);
			// 
			// lblAnt
			// 
			resources.ApplyResources(this.lblAnt, "lblAnt");
			this.lblAnt.Name = "lblAnt";
			// 
			// btnAnterior
			// 
			resources.ApplyResources(this.btnAnterior, "btnAnterior");
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Tag = " ";
			this.btnAnterior.UseVisualStyleBackColor = true;
			this.btnAnterior.Click += new System.EventHandler(this.Btn_TeclasAtalhos);
			this.btnAnterior.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAnterior_KeyDown);
			// 
			// lblSeg
			// 
			resources.ApplyResources(this.lblSeg, "lblSeg");
			this.lblSeg.Name = "lblSeg";
			// 
			// btnNext
			// 
			resources.ApplyResources(this.btnNext, "btnNext");
			this.btnNext.Name = "btnNext";
			this.btnNext.Tag = " ";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.Btn_TeclasAtalhos);
			this.btnNext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAnterior_KeyDown);
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.lbltec);
			this.panel10.Controls.Add(this.chkAtalho);
			resources.ApplyResources(this.panel10, "panel10");
			this.panel10.Name = "panel10";
			// 
			// lbltec
			// 
			resources.ApplyResources(this.lbltec, "lbltec");
			this.lbltec.Name = "lbltec";
			// 
			// chkAtalho
			// 
			resources.ApplyResources(this.chkAtalho, "chkAtalho");
			this.chkAtalho.Name = "chkAtalho";
			this.chkAtalho.UseVisualStyleBackColor = true;
			this.chkAtalho.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// pnlDiscord
			// 
			this.pnlDiscord.Controls.Add(this.switchDuracao);
			this.pnlDiscord.Controls.Add(this.switchNome);
			this.pnlDiscord.Controls.Add(this.lblinfoDu);
			this.pnlDiscord.Controls.Add(this.lblDuracao);
			this.pnlDiscord.Controls.Add(this.lblNomeDisc);
			resources.ApplyResources(this.pnlDiscord, "pnlDiscord");
			this.pnlDiscord.Name = "pnlDiscord";
			// 
			// lblinfoDu
			// 
			resources.ApplyResources(this.lblinfoDu, "lblinfoDu");
			this.lblinfoDu.Name = "lblinfoDu";
			this.lblinfoDu.Tag = "";
			// 
			// lblDuracao
			// 
			resources.ApplyResources(this.lblDuracao, "lblDuracao");
			this.lblDuracao.Name = "lblDuracao";
			this.lblDuracao.Click += new System.EventHandler(this.label11_Click);
			// 
			// lblNomeDisc
			// 
			resources.ApplyResources(this.lblNomeDisc, "lblNomeDisc");
			this.lblNomeDisc.Name = "lblNomeDisc";
			this.lblNomeDisc.Click += new System.EventHandler(this.label11_Click);
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.chkDiscord);
			this.panel9.Controls.Add(this.label3);
			resources.ApplyResources(this.panel9, "panel9");
			this.panel9.Name = "panel9";
			// 
			// chkDiscord
			// 
			resources.ApplyResources(this.chkDiscord, "chkDiscord");
			this.chkDiscord.Name = "chkDiscord";
			this.chkDiscord.UseVisualStyleBackColor = true;
			this.chkDiscord.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.switchMusic);
			this.panel8.Controls.Add(this.lblInfoMusic);
			this.panel8.Controls.Add(this.lblnotif);
			this.panel8.Controls.Add(this.switchMini);
			this.panel8.Controls.Add(this.lblMini);
			this.panel8.Controls.Add(this.lblTitMini);
			this.panel8.Controls.Add(this.switchSO);
			this.panel8.Controls.Add(this.pctPaths);
			this.panel8.Controls.Add(this.label14);
			this.panel8.Controls.Add(this.txtPaths);
			this.panel8.Controls.Add(this.label13);
			this.panel8.Controls.Add(this.lblSO);
			this.panel8.Controls.Add(this.label10);
			this.panel8.Controls.Add(this.lblEscIdioma);
			this.panel8.Controls.Add(this.comboBox1);
			this.panel8.Controls.Add(this.lblIdioma);
			resources.ApplyResources(this.panel8, "panel8");
			this.panel8.Name = "panel8";
			// 
			// lblInfoMusic
			// 
			resources.ApplyResources(this.lblInfoMusic, "lblInfoMusic");
			this.lblInfoMusic.Name = "lblInfoMusic";
			this.lblInfoMusic.Tag = "En -> Hitting X will make application, invisble. But is visible in taskbar";
			this.lblInfoMusic.Click += new System.EventHandler(this.label11_Click);
			// 
			// lblnotif
			// 
			resources.ApplyResources(this.lblnotif, "lblnotif");
			this.lblnotif.Name = "lblnotif";
			// 
			// lblMini
			// 
			resources.ApplyResources(this.lblMini, "lblMini");
			this.lblMini.Name = "lblMini";
			this.lblMini.Tag = "En -> Hitting X will make application, invisble. But is visible in taskbar";
			this.lblMini.Click += new System.EventHandler(this.label11_Click);
			// 
			// lblTitMini
			// 
			resources.ApplyResources(this.lblTitMini, "lblTitMini");
			this.lblTitMini.Name = "lblTitMini";
			// 
			// pctPaths
			// 
			resources.ApplyResources(this.pctPaths, "pctPaths");
			this.pctPaths.Image = global::Spotify_Clone.Properties.Resources.arquivo_aberto;
			this.pctPaths.Name = "pctPaths";
			this.pctPaths.TabStop = false;
			this.pctPaths.Click += new System.EventHandler(this.pE_Click);
			// 
			// label14
			// 
			resources.ApplyResources(this.label14, "label14");
			this.label14.Name = "label14";
			// 
			// txtPaths
			// 
			resources.ApplyResources(this.txtPaths, "txtPaths");
			this.txtPaths.Name = "txtPaths";
			// 
			// label13
			// 
			resources.ApplyResources(this.label13, "label13");
			this.label13.Name = "label13";
			this.label13.Tag = "En -> Choose language - changes will be applied after restarting the app";
			// 
			// lblSO
			// 
			resources.ApplyResources(this.lblSO, "lblSO");
			this.lblSO.Name = "lblSO";
			this.lblSO.Tag = "En -> Choose language - changes will be applied after restarting the app";
			this.lblSO.Click += new System.EventHandler(this.label11_Click);
			// 
			// label10
			// 
			resources.ApplyResources(this.label10, "label10");
			this.label10.Name = "label10";
			// 
			// lblEscIdioma
			// 
			resources.ApplyResources(this.lblEscIdioma, "lblEscIdioma");
			this.lblEscIdioma.Name = "lblEscIdioma";
			this.lblEscIdioma.Tag = "En -> Choose language - changes will be applied after restarting the app";
			// 
			// comboBox1
			// 
			resources.ApplyResources(this.comboBox1, "comboBox1");
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Tag = "0";
			// 
			// lblIdioma
			// 
			resources.ApplyResources(this.lblIdioma, "lblIdioma");
			this.lblIdioma.Name = "lblIdioma";
			// 
			// panel14
			// 
			resources.ApplyResources(this.panel14, "panel14");
			this.panel14.Name = "panel14";
			// 
			// icnNotification
			// 
			this.icnNotification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.icnNotification.ContextMenuStrip = this.contextMenuStrip1;
			resources.ApplyResources(this.icnNotification, "icnNotification");

			this.icnNotification.Click += new System.EventHandler(this.icnNotification_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIPrevious,
            this.TSMIPause,
            this.TSMINext,
            this.toolStripSeparator1,
            this.TSMIClose});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
			// 
			// TSMIPrevious
			// 
			this.TSMIPrevious.BackColor = System.Drawing.Color.White;
			this.TSMIPrevious.Image = global::Spotify_Clone.Properties.Resources.previousB;
			this.TSMIPrevious.Name = "TSMIPrevious";
			resources.ApplyResources(this.TSMIPrevious, "TSMIPrevious");
			this.TSMIPrevious.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// TSMIPause
			// 
			this.TSMIPause.Image = global::Spotify_Clone.Properties.Resources.pauseB;
			this.TSMIPause.Name = "TSMIPause";
			resources.ApplyResources(this.TSMIPause, "TSMIPause");
			this.TSMIPause.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// TSMINext
			// 
			this.TSMINext.Image = global::Spotify_Clone.Properties.Resources.nextB;
			this.TSMINext.Name = "TSMINext";
			resources.ApplyResources(this.TSMINext, "TSMINext");
			this.TSMINext.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			// 
			// TSMIClose
			// 
			this.TSMIClose.Image = global::Spotify_Clone.Properties.Resources.close_red;
			this.TSMIClose.Name = "TSMIClose";
			resources.ApplyResources(this.TSMIClose, "TSMIClose");
			this.TSMIClose.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// axWindowsMediaPlayer1
			// 
			resources.ApplyResources(this.axWindowsMediaPlayer1, "axWindowsMediaPlayer1");
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
			// 
			// PBC
			// 
			resources.ApplyResources(this.PBC, "PBC");
			this.PBC.BackColor = System.Drawing.Color.White;
			this.PBC.ChannelColor = System.Drawing.Color.White;
			this.PBC.ChannelHeight = 6;
			this.PBC.ForeBackColor = System.Drawing.Color.Teal;
			this.PBC.ForeColor = System.Drawing.Color.White;
			this.PBC.Name = "PBC";
			this.PBC.ShowMaximun = false;
			this.PBC.ShowValue = Spotify_Clone.Extensions.TextPosition.None;
			this.PBC.SliderColor = System.Drawing.Color.Teal;
			this.PBC.SliderHeight = 6;
			this.PBC.Step = 1;
			this.PBC.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.PBC.SymbolAfter = "";
			this.PBC.SymbolBefore = "";
			// 
			// switchDuracao
			// 
			resources.ApplyResources(this.switchDuracao, "switchDuracao");
			this.switchDuracao.BackColor = System.Drawing.Color.Transparent;
			this.switchDuracao.Name = "switchDuracao";
			this.switchDuracao.OffBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.switchDuracao.OffToggleColor = System.Drawing.Color.White;
			this.switchDuracao.OnBackColor = System.Drawing.Color.DarkSlateGray;
			this.switchDuracao.OnToggleColor = System.Drawing.Color.White;
			this.switchDuracao.UseVisualStyleBackColor = false;
			// 
			// switchNome
			// 
			resources.ApplyResources(this.switchNome, "switchNome");
			this.switchNome.BackColor = System.Drawing.Color.Transparent;
			this.switchNome.Name = "switchNome";
			this.switchNome.OffBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.switchNome.OffToggleColor = System.Drawing.Color.White;
			this.switchNome.OnBackColor = System.Drawing.Color.DarkSlateGray;
			this.switchNome.OnToggleColor = System.Drawing.Color.White;
			this.switchNome.UseVisualStyleBackColor = false;
			// 
			// switchMusic
			// 
			resources.ApplyResources(this.switchMusic, "switchMusic");
			this.switchMusic.BackColor = System.Drawing.Color.Transparent;
			this.switchMusic.Name = "switchMusic";
			this.switchMusic.OffBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.switchMusic.OffToggleColor = System.Drawing.Color.White;
			this.switchMusic.OnBackColor = System.Drawing.Color.DarkSlateGray;
			this.switchMusic.OnToggleColor = System.Drawing.Color.White;
			this.switchMusic.UseVisualStyleBackColor = false;
			// 
			// switchMini
			// 
			resources.ApplyResources(this.switchMini, "switchMini");
			this.switchMini.BackColor = System.Drawing.Color.Transparent;
			this.switchMini.Name = "switchMini";
			this.switchMini.OffBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.switchMini.OffToggleColor = System.Drawing.Color.White;
			this.switchMini.OnBackColor = System.Drawing.Color.DarkSlateGray;
			this.switchMini.OnToggleColor = System.Drawing.Color.White;
			this.switchMini.UseVisualStyleBackColor = false;
			// 
			// switchSO
			// 
			resources.ApplyResources(this.switchSO, "switchSO");
			this.switchSO.BackColor = System.Drawing.Color.Transparent;
			this.switchSO.Name = "switchSO";
			this.switchSO.OffBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.switchSO.OffToggleColor = System.Drawing.Color.White;
			this.switchSO.OnBackColor = System.Drawing.Color.DarkSlateGray;
			this.switchSO.OnToggleColor = System.Drawing.Color.White;
			this.switchSO.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlCont);
			this.Controls.Add(this.pnlSettings);
			this.Controls.Add(this.pnlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(trackBar1)).EndInit();
			this.pnlTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picXAMPP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_MaxMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picForm3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_minimizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Close)).EndInit();
			this.panel2.ResumeLayout(false);
			this.PainelControl1.ResumeLayout(false);
			this.pnlPlayList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picAddPlaylist)).EndInit();
			this.pnlControlo.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pE_Random)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Repit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_Next)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_PauseaPlay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pE_previous)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picInfos)).EndInit();
			this.pnlConteudo.ResumeLayout(false);
			this.cmsMenuStrip.ResumeLayout(false);
			this.pnlCont.ResumeLayout(false);
			this.pnlSettings.ResumeLayout(false);
			this.pnlSettings.PerformLayout();
			this.pnlXampp.ResumeLayout(false);
			this.pnlXampp.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctXAMPP)).EndInit();
			this.pnlAtalho.ResumeLayout(false);
			this.pnlAtalho.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.pnlDiscord.ResumeLayout(false);
			this.pnlDiscord.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctPaths)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.PictureBox pE_minimizar;
		private System.Windows.Forms.PictureBox pE_Close;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel PainelControl1;
		private System.Windows.Forms.PictureBox picAddPlaylist;
		private System.Windows.Forms.Panel pnlPlayList;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel pnlControlo;
		private System.Windows.Forms.Panel pnlConteudo;
		private System.Windows.Forms.Panel pnlPrincipal;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ContextMenuStrip cmsMenuStrip;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem TSMIRemove;
		private System.Windows.Forms.ToolStripMenuItem TSMIEditPlayList;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.PictureBox picForm3;
		private System.ComponentModel.BackgroundWorker bgwCarregar;
		private System.Windows.Forms.PictureBox pE_MaxMin;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.PictureBox pE_Next;
		private System.Windows.Forms.PictureBox pE_PauseaPlay;
		private System.Windows.Forms.PictureBox pE_previous;
		private System.Windows.Forms.PictureBox pE_Repit;
		private System.Windows.Forms.PictureBox pE_Random;
		private System.Windows.Forms.PictureBox picSettings;
		private System.Windows.Forms.Panel pnlCont;
		private System.Windows.Forms.Panel pnlSettings;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label lblIdioma;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label lblEscIdioma;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel pnlDiscord;
		private System.Windows.Forms.Label lblNomeDisc;
		private System.Windows.Forms.Label lblDuracao;
		private System.Windows.Forms.CheckBox chkAtalho;
		private System.Windows.Forms.Label lbltec;
		private System.Windows.Forms.Panel pnlAtalho;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblSO;
		private System.Windows.Forms.Panel panel14;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Label lblSeg;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.Label lblAnt;
		private System.Windows.Forms.Button btnPausa;
		private System.Windows.Forms.Label lblPaRe;
		private System.Windows.Forms.Label lblAnterior;
		private System.Windows.Forms.Label lblSeguinte;
		private System.Windows.Forms.Label lblPR;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtPaths;
		private System.Windows.Forms.PictureBox pctPaths;
		private System.Windows.Forms.PictureBox picInfos;
		private System.Windows.Forms.Label labelControl2;
		private System.Windows.Forms.Label labelControl4;
		private System.Windows.Forms.CheckBox chkDiscord;
		private System.Windows.Forms.Panel pnlXampp;
		private System.Windows.Forms.TextBox txtXAMPP;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label lblinfoDu;
		private CustomControls.RJControls.RJToggleButton switchNome;
		private CustomControls.RJControls.RJToggleButton switchDuracao;
		private CustomControls.RJControls.RJToggleButton switchSO;
		private System.Windows.Forms.NotifyIcon icnNotification;
		private CustomControls.RJControls.RJToggleButton switchMini;
		private System.Windows.Forms.Label lblMini;
		private System.Windows.Forms.Label lblTitMini;
		private CustomControls.RJControls.RJToggleButton switchMusic;
		private System.Windows.Forms.Label lblInfoMusic;
		private System.Windows.Forms.Label lblnotif;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem TSMIPrevious;
		private System.Windows.Forms.ToolStripMenuItem TSMIPause;
		private System.Windows.Forms.ToolStripMenuItem TSMINext;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem TSMIClose;
		private System.Windows.Forms.Timer tmAtalho;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
		private System.Windows.Forms.Label lblVersao;
		private System.Windows.Forms.PictureBox pctXAMPP;
		private System.Windows.Forms.PictureBox picXAMPP;
		private Extensions.PBC PBC;
	}
}

