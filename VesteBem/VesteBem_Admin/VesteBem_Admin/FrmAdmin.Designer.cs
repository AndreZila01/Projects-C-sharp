namespace VesteBem_Admin
{
	partial class frmAdmin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.pctFlow = new System.Windows.Forms.PictureBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.pctSettings = new System.Windows.Forms.PictureBox();
			this.flpForms = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlAdd = new System.Windows.Forms.Panel();
			this.pctAdd = new System.Windows.Forms.PictureBox();
			this.lblAdd = new System.Windows.Forms.Label();
			this.pnlEditar = new System.Windows.Forms.Panel();
			this.pctEditar = new System.Windows.Forms.PictureBox();
			this.lblEditar = new System.Windows.Forms.Label();
			this.pnlModificar = new System.Windows.Forms.Panel();
			this.pctModificar = new System.Windows.Forms.PictureBox();
			this.lblModificar = new System.Windows.Forms.Label();
			this.pnlEncomendas = new System.Windows.Forms.Panel();
			this.pctEncomendas = new System.Windows.Forms.PictureBox();
			this.lblEncomendas = new System.Windows.Forms.Label();
			this.pnlConsultar = new System.Windows.Forms.Panel();
			this.pctConsultar = new System.Windows.Forms.PictureBox();
			this.lblConsultar = new System.Windows.Forms.Label();
			this.pnlDef = new System.Windows.Forms.Panel();
			this.pctDef = new System.Windows.Forms.PictureBox();
			this.lblDef = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlPrincipal = new System.Windows.Forms.Panel();
			this.pnlSettings = new System.Windows.Forms.Panel();
			this.chkAuto = new System.Windows.Forms.CheckBox();
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctFlow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctSettings)).BeginInit();
			this.flpForms.SuspendLayout();
			this.pnlAdd.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctAdd)).BeginInit();
			this.pnlEditar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctEditar)).BeginInit();
			this.pnlModificar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctModificar)).BeginInit();
			this.pnlEncomendas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctEncomendas)).BeginInit();
			this.pnlConsultar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctConsultar)).BeginInit();
			this.pnlDef.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctDef)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pnlPrincipal.SuspendLayout();
			this.pnlSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.Controls.Add(this.pctFlow);
			this.pnlTop.Controls.Add(this.lblNome);
			this.pnlTop.Controls.Add(this.pctSettings);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(800, 58);
			this.pnlTop.TabIndex = 5;
			// 
			// pctFlow
			// 
			this.pctFlow.Image = global::VesteBem_Admin.Properties.Resources.menu;
			this.pctFlow.Location = new System.Drawing.Point(12, 12);
			this.pctFlow.Name = "pctFlow";
			this.pctFlow.Size = new System.Drawing.Size(40, 36);
			this.pctFlow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctFlow.TabIndex = 7;
			this.pctFlow.TabStop = false;
			this.pctFlow.Click += new System.EventHandler(this.pct_Click);
			// 
			// lblNome
			// 
			this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(707, 22);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(35, 13);
			this.lblNome.TabIndex = 6;
			this.lblNome.Text = "label1";
			// 
			// pctSettings
			// 
			this.pctSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pctSettings.Image = global::VesteBem_Admin.Properties.Resources.Admin;
			this.pctSettings.Location = new System.Drawing.Point(748, 12);
			this.pctSettings.Name = "pctSettings";
			this.pctSettings.Size = new System.Drawing.Size(40, 36);
			this.pctSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctSettings.TabIndex = 5;
			this.pctSettings.TabStop = false;
			this.pctSettings.Click += new System.EventHandler(this.pct_Click);
			// 
			// flpForms
			// 
			this.flpForms.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.flpForms.Controls.Add(this.pnlAdd);
			this.flpForms.Controls.Add(this.pnlEditar);
			this.flpForms.Controls.Add(this.pnlModificar);
			this.flpForms.Controls.Add(this.pnlEncomendas);
			this.flpForms.Controls.Add(this.pnlConsultar);
			this.flpForms.Controls.Add(this.pnlDef);
			this.flpForms.Controls.Add(this.panel1);
			this.flpForms.Dock = System.Windows.Forms.DockStyle.Left;
			this.flpForms.Location = new System.Drawing.Point(0, 58);
			this.flpForms.Name = "flpForms";
			this.flpForms.Size = new System.Drawing.Size(159, 392);
			this.flpForms.TabIndex = 6;
			// 
			// pnlAdd
			// 
			this.pnlAdd.Controls.Add(this.pctAdd);
			this.pnlAdd.Controls.Add(this.lblAdd);
			this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlAdd.Location = new System.Drawing.Point(0, 10);
			this.pnlAdd.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.pnlAdd.Name = "pnlAdd";
			this.pnlAdd.Size = new System.Drawing.Size(158, 52);
			this.pnlAdd.TabIndex = 0;
			this.pnlAdd.Tag = "0";
			this.pnlAdd.Click += new System.EventHandler(this.panel2_Click);
			// 
			// pctAdd
			// 
			this.pctAdd.Image = global::VesteBem_Admin.Properties.Resources.add_to_basket;
			this.pctAdd.Location = new System.Drawing.Point(8, 8);
			this.pctAdd.Name = "pctAdd";
			this.pctAdd.Size = new System.Drawing.Size(40, 36);
			this.pctAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctAdd.TabIndex = 7;
			this.pctAdd.TabStop = false;
			this.pctAdd.Tag = "0";
			this.pctAdd.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// lblAdd
			// 
			this.lblAdd.AutoSize = true;
			this.lblAdd.Location = new System.Drawing.Point(58, 17);
			this.lblAdd.Name = "lblAdd";
			this.lblAdd.Size = new System.Drawing.Size(96, 13);
			this.lblAdd.TabIndex = 0;
			this.lblAdd.Tag = "0";
			this.lblAdd.Text = "Adicionar Produtos";
			this.lblAdd.Click += new System.EventHandler(this.label3_Click);
			// 
			// pnlEditar
			// 
			this.pnlEditar.Controls.Add(this.pctEditar);
			this.pnlEditar.Controls.Add(this.lblEditar);
			this.pnlEditar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlEditar.Location = new System.Drawing.Point(0, 64);
			this.pnlEditar.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.pnlEditar.Name = "pnlEditar";
			this.pnlEditar.Size = new System.Drawing.Size(158, 52);
			this.pnlEditar.TabIndex = 4;
			this.pnlEditar.Tag = "1";
			this.pnlEditar.Click += new System.EventHandler(this.label3_Click);
			// 
			// pctEditar
			// 
			this.pctEditar.Image = global::VesteBem_Admin.Properties.Resources.Pencil;
			this.pctEditar.Location = new System.Drawing.Point(8, 8);
			this.pctEditar.Name = "pctEditar";
			this.pctEditar.Size = new System.Drawing.Size(40, 36);
			this.pctEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctEditar.TabIndex = 9;
			this.pctEditar.TabStop = false;
			this.pctEditar.Tag = "1";
			this.pctEditar.Click += new System.EventHandler(this.label3_Click);
			// 
			// lblEditar
			// 
			this.lblEditar.AutoSize = true;
			this.lblEditar.Location = new System.Drawing.Point(54, 13);
			this.lblEditar.Name = "lblEditar";
			this.lblEditar.Size = new System.Drawing.Size(89, 26);
			this.lblEditar.TabIndex = 8;
			this.lblEditar.Tag = "1";
			this.lblEditar.Text = "Editar ou Apagar \r\nProdutos";
			this.lblEditar.Click += new System.EventHandler(this.label3_Click);
			// 
			// pnlModificar
			// 
			this.pnlModificar.Controls.Add(this.pctModificar);
			this.pnlModificar.Controls.Add(this.lblModificar);
			this.pnlModificar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlModificar.Location = new System.Drawing.Point(0, 118);
			this.pnlModificar.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.pnlModificar.Name = "pnlModificar";
			this.pnlModificar.Size = new System.Drawing.Size(158, 52);
			this.pnlModificar.TabIndex = 1;
			this.pnlModificar.Tag = "2";
			this.pnlModificar.Click += new System.EventHandler(this.panel2_Click);
			// 
			// pctModificar
			// 
			this.pctModificar.Image = global::VesteBem_Admin.Properties.Resources.Pencil;
			this.pctModificar.Location = new System.Drawing.Point(8, 8);
			this.pctModificar.Name = "pctModificar";
			this.pctModificar.Size = new System.Drawing.Size(40, 36);
			this.pctModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctModificar.TabIndex = 9;
			this.pctModificar.TabStop = false;
			this.pctModificar.Tag = "2";
			this.pctModificar.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// lblModificar
			// 
			this.lblModificar.AutoSize = true;
			this.lblModificar.Location = new System.Drawing.Point(58, 14);
			this.lblModificar.Name = "lblModificar";
			this.lblModificar.Size = new System.Drawing.Size(88, 26);
			this.lblModificar.TabIndex = 8;
			this.lblModificar.Tag = "2";
			this.lblModificar.Text = "Modificar Cliente \r\ne Funcionario";
			this.lblModificar.Click += new System.EventHandler(this.label3_Click);
			// 
			// pnlEncomendas
			// 
			this.pnlEncomendas.Controls.Add(this.pctEncomendas);
			this.pnlEncomendas.Controls.Add(this.lblEncomendas);
			this.pnlEncomendas.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlEncomendas.Location = new System.Drawing.Point(0, 172);
			this.pnlEncomendas.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.pnlEncomendas.Name = "pnlEncomendas";
			this.pnlEncomendas.Size = new System.Drawing.Size(158, 52);
			this.pnlEncomendas.TabIndex = 2;
			this.pnlEncomendas.Tag = "3";
			this.pnlEncomendas.Click += new System.EventHandler(this.panel2_Click);
			// 
			// pctEncomendas
			// 
			this.pctEncomendas.Image = global::VesteBem_Admin.Properties.Resources.shopping_cart;
			this.pctEncomendas.Location = new System.Drawing.Point(8, 8);
			this.pctEncomendas.Name = "pctEncomendas";
			this.pctEncomendas.Size = new System.Drawing.Size(40, 36);
			this.pctEncomendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctEncomendas.TabIndex = 9;
			this.pctEncomendas.TabStop = false;
			this.pctEncomendas.Tag = "3";
			this.pctEncomendas.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// lblEncomendas
			// 
			this.lblEncomendas.AutoSize = true;
			this.lblEncomendas.Location = new System.Drawing.Point(54, 19);
			this.lblEncomendas.Name = "lblEncomendas";
			this.lblEncomendas.Size = new System.Drawing.Size(98, 13);
			this.lblEncomendas.TabIndex = 8;
			this.lblEncomendas.Tag = "3";
			this.lblEncomendas.Text = "Fazer Encomendas";
			this.lblEncomendas.Click += new System.EventHandler(this.label3_Click);
			// 
			// pnlConsultar
			// 
			this.pnlConsultar.Controls.Add(this.pctConsultar);
			this.pnlConsultar.Controls.Add(this.lblConsultar);
			this.pnlConsultar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlConsultar.Location = new System.Drawing.Point(0, 226);
			this.pnlConsultar.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.pnlConsultar.Name = "pnlConsultar";
			this.pnlConsultar.Size = new System.Drawing.Size(158, 52);
			this.pnlConsultar.TabIndex = 3;
			this.pnlConsultar.Tag = "4";
			this.pnlConsultar.Click += new System.EventHandler(this.panel2_Click);
			// 
			// pctConsultar
			// 
			this.pctConsultar.Image = global::VesteBem_Admin.Properties.Resources.magnifying_glass;
			this.pctConsultar.Location = new System.Drawing.Point(8, 8);
			this.pctConsultar.Name = "pctConsultar";
			this.pctConsultar.Size = new System.Drawing.Size(40, 36);
			this.pctConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctConsultar.TabIndex = 9;
			this.pctConsultar.TabStop = false;
			this.pctConsultar.Tag = "4";
			this.pctConsultar.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// lblConsultar
			// 
			this.lblConsultar.AutoSize = true;
			this.lblConsultar.Location = new System.Drawing.Point(54, 19);
			this.lblConsultar.Name = "lblConsultar";
			this.lblConsultar.Size = new System.Drawing.Size(93, 13);
			this.lblConsultar.TabIndex = 8;
			this.lblConsultar.Tag = "4";
			this.lblConsultar.Text = "Consultar Carrinho";
			this.lblConsultar.Click += new System.EventHandler(this.label3_Click);
			// 
			// pnlDef
			// 
			this.pnlDef.Controls.Add(this.pctDef);
			this.pnlDef.Controls.Add(this.lblDef);
			this.pnlDef.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDef.Location = new System.Drawing.Point(0, 280);
			this.pnlDef.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.pnlDef.Name = "pnlDef";
			this.pnlDef.Size = new System.Drawing.Size(158, 52);
			this.pnlDef.TabIndex = 5;
			this.pnlDef.Tag = "5";
			this.pnlDef.Click += new System.EventHandler(this.panel2_Click);
			// 
			// pctDef
			// 
			this.pctDef.Image = global::VesteBem_Admin.Properties.Resources.settings;
			this.pctDef.Location = new System.Drawing.Point(8, 8);
			this.pctDef.Name = "pctDef";
			this.pctDef.Size = new System.Drawing.Size(40, 36);
			this.pctDef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctDef.TabIndex = 9;
			this.pctDef.TabStop = false;
			this.pctDef.Tag = "5";
			this.pctDef.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// lblDef
			// 
			this.lblDef.AutoSize = true;
			this.lblDef.Location = new System.Drawing.Point(54, 19);
			this.lblDef.Name = "lblDef";
			this.lblDef.Size = new System.Drawing.Size(57, 13);
			this.lblDef.TabIndex = 8;
			this.lblDef.Tag = "5";
			this.lblDef.Text = "Definições";
			this.lblDef.Click += new System.EventHandler(this.label3_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 334);
			this.panel1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(158, 52);
			this.panel1.TabIndex = 6;
			this.panel1.Tag = "6";
			this.panel1.Click += new System.EventHandler(this.panel2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::VesteBem_Admin.Properties.Resources.logout;
			this.pictureBox1.Location = new System.Drawing.Point(8, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(40, 36);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "6";
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 8;
			this.label1.Tag = "6";
			this.label1.Text = "Terminar Sessão";
			this.label1.Click += new System.EventHandler(this.label3_Click);
			// 
			// pnlPrincipal
			// 
			this.pnlPrincipal.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pnlPrincipal.Controls.Add(this.pnlSettings);
			this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlPrincipal.Location = new System.Drawing.Point(159, 58);
			this.pnlPrincipal.Name = "pnlPrincipal";
			this.pnlPrincipal.Size = new System.Drawing.Size(641, 392);
			this.pnlPrincipal.TabIndex = 7;
			// 
			// pnlSettings
			// 
			this.pnlSettings.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.pnlSettings.Controls.Add(this.chkAuto);
			this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSettings.Location = new System.Drawing.Point(0, 0);
			this.pnlSettings.Name = "pnlSettings";
			this.pnlSettings.Size = new System.Drawing.Size(641, 392);
			this.pnlSettings.TabIndex = 0;
			this.pnlSettings.Visible = false;
			// 
			// chkAuto
			// 
			this.chkAuto.AutoSize = true;
			this.chkAuto.Location = new System.Drawing.Point(45, 27);
			this.chkAuto.Name = "chkAuto";
			this.chkAuto.Size = new System.Drawing.Size(243, 17);
			this.chkAuto.TabIndex = 0;
			this.chkAuto.Text = "Auto Run (Abrir com o SO, Sistema Operativo)";
			this.chkAuto.UseVisualStyleBackColor = true;
			this.chkAuto.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// frmAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlPrincipal);
			this.Controls.Add(this.flpForms);
			this.Controls.Add(this.pnlTop);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Administrador";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdmin_FormClosed);
			this.Load += new System.EventHandler(this.FrmAdmin_Load);
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctFlow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctSettings)).EndInit();
			this.flpForms.ResumeLayout(false);
			this.pnlAdd.ResumeLayout(false);
			this.pnlAdd.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctAdd)).EndInit();
			this.pnlEditar.ResumeLayout(false);
			this.pnlEditar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctEditar)).EndInit();
			this.pnlModificar.ResumeLayout(false);
			this.pnlModificar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctModificar)).EndInit();
			this.pnlEncomendas.ResumeLayout(false);
			this.pnlEncomendas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctEncomendas)).EndInit();
			this.pnlConsultar.ResumeLayout(false);
			this.pnlConsultar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctConsultar)).EndInit();
			this.pnlDef.ResumeLayout(false);
			this.pnlDef.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctDef)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pnlPrincipal.ResumeLayout(false);
			this.pnlSettings.ResumeLayout(false);
			this.pnlSettings.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.PictureBox pctSettings;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.FlowLayoutPanel flpForms;
		private System.Windows.Forms.PictureBox pctFlow;
		private System.Windows.Forms.Panel pnlAdd;
		private System.Windows.Forms.Panel pnlModificar;
		private System.Windows.Forms.Panel pnlEncomendas;
		private System.Windows.Forms.Panel pnlConsultar;
		private System.Windows.Forms.Label lblAdd;
		private System.Windows.Forms.PictureBox pctAdd;
		private System.Windows.Forms.PictureBox pctModificar;
		private System.Windows.Forms.Label lblModificar;
		private System.Windows.Forms.PictureBox pctEncomendas;
		private System.Windows.Forms.Label lblEncomendas;
		private System.Windows.Forms.PictureBox pctConsultar;
		private System.Windows.Forms.Label lblConsultar;
		private System.Windows.Forms.Panel pnlPrincipal;
		private System.Windows.Forms.Panel pnlSettings;
		private System.Windows.Forms.CheckBox chkAuto;
		private System.Windows.Forms.Panel pnlEditar;
		private System.Windows.Forms.PictureBox pctEditar;
		private System.Windows.Forms.Label lblEditar;
		private System.Windows.Forms.Panel pnlDef;
		private System.Windows.Forms.PictureBox pctDef;
		private System.Windows.Forms.Label lblDef;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}