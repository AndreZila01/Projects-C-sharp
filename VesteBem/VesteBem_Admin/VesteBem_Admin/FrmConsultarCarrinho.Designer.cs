
namespace VesteBem_Admin
{
	partial class frmConsultarCarrinho
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarCarrinho));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.lblFim = new System.Windows.Forms.Label();
			this.lblInicio = new System.Windows.Forms.Label();
			this.lblCliOuId = new System.Windows.Forms.Label();
			this.lblEstado = new System.Windows.Forms.Label();
			this.dtpChegada = new System.Windows.Forms.DateTimePicker();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.txtClienteId = new System.Windows.Forms.TextBox();
			this.cmbEstado = new System.Windows.Forms.ComboBox();
			this.bgwInicio = new System.ComponentModel.BackgroundWorker();
			this.flpCentro = new System.Windows.Forms.FlowLayoutPanel();
			this.bgwModificar = new System.ComponentModel.BackgroundWorker();
			this.pnlTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.Controls.Add(this.lblFim);
			this.pnlTop.Controls.Add(this.lblInicio);
			this.pnlTop.Controls.Add(this.lblCliOuId);
			this.pnlTop.Controls.Add(this.lblEstado);
			this.pnlTop.Controls.Add(this.dtpChegada);
			this.pnlTop.Controls.Add(this.dtpInicio);
			this.pnlTop.Controls.Add(this.txtClienteId);
			this.pnlTop.Controls.Add(this.cmbEstado);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(800, 63);
			this.pnlTop.TabIndex = 0;
			// 
			// lblFim
			// 
			this.lblFim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFim.AutoSize = true;
			this.lblFim.Location = new System.Drawing.Point(642, 17);
			this.lblFim.Name = "lblFim";
			this.lblFim.Size = new System.Drawing.Size(87, 13);
			this.lblFim.TabIndex = 7;
			this.lblFim.Text = "Encomendas até";
			// 
			// lblInicio
			// 
			this.lblInicio.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblInicio.AutoSize = true;
			this.lblInicio.Location = new System.Drawing.Point(442, 17);
			this.lblInicio.Name = "lblInicio";
			this.lblInicio.Size = new System.Drawing.Size(87, 13);
			this.lblInicio.TabIndex = 6;
			this.lblInicio.Text = "Encomendas de ";
			// 
			// lblCliOuId
			// 
			this.lblCliOuId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCliOuId.AutoSize = true;
			this.lblCliOuId.Location = new System.Drawing.Point(187, 17);
			this.lblCliOuId.Name = "lblCliOuId";
			this.lblCliOuId.Size = new System.Drawing.Size(123, 13);
			this.lblCliOuId.TabIndex = 5;
			this.lblCliOuId.Text = "Cliente ou IdEncomenda";
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Location = new System.Drawing.Point(22, 17);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(45, 13);
			this.lblEstado.TabIndex = 4;
			this.lblEstado.Text = "Estados";
			// 
			// dtpChegada
			// 
			this.dtpChegada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpChegada.Location = new System.Drawing.Point(645, 36);
			this.dtpChegada.Name = "dtpChegada";
			this.dtpChegada.Size = new System.Drawing.Size(143, 20);
			this.dtpChegada.TabIndex = 3;
			// 
			// dtpInicio
			// 
			this.dtpInicio.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.dtpInicio.Location = new System.Drawing.Point(445, 35);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(143, 20);
			this.dtpInicio.TabIndex = 2;
			// 
			// txtClienteId
			// 
			this.txtClienteId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtClienteId.Location = new System.Drawing.Point(190, 36);
			this.txtClienteId.Name = "txtClienteId";
			this.txtClienteId.Size = new System.Drawing.Size(185, 20);
			this.txtClienteId.TabIndex = 1;
			this.txtClienteId.MouseLeave += new System.EventHandler(this.Object_MouseLeavee);
			// 
			// cmbEstado
			// 
			this.cmbEstado.FormattingEnabled = true;
			this.cmbEstado.Location = new System.Drawing.Point(22, 36);
			this.cmbEstado.Name = "cmbEstado";
			this.cmbEstado.Size = new System.Drawing.Size(121, 21);
			this.cmbEstado.TabIndex = 0;
			this.cmbEstado.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
			this.cmbEstado.MouseLeave += new System.EventHandler(this.Object_MouseLeavee);
			// 
			// bgwInicio
			// 
			this.bgwInicio.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.bgwInicio.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// flpCentro
			// 
			this.flpCentro.AutoSize = true;
			this.flpCentro.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.flpCentro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpCentro.Location = new System.Drawing.Point(0, 63);
			this.flpCentro.Name = "flpCentro";
			this.flpCentro.Size = new System.Drawing.Size(800, 387);
			this.flpCentro.TabIndex = 1;
			this.flpCentro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
			// 
			// bgwModificar
			// 
			this.bgwModificar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
			this.bgwModificar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
			// 
			// frmConsultarCarrinho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.flpCentro);
			this.Controls.Add(this.pnlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmConsultarCarrinho";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consultar Carrinho";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsultarCarrinho_FormClosed);
			this.Load += new System.EventHandler(this.frmConsultarCarrinho_Load);
			this.SizeChanged += new System.EventHandler(this.FrmConsultarCarrinho_SizeChanged);
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.ComboBox cmbEstado;
		private System.Windows.Forms.TextBox txtClienteId;
		private System.Windows.Forms.DateTimePicker dtpChegada;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.Label lblFim;
		private System.Windows.Forms.Label lblInicio;
		private System.Windows.Forms.Label lblCliOuId;
		private System.Windows.Forms.Label lblEstado;
		private System.ComponentModel.BackgroundWorker bgwInicio;
		private System.Windows.Forms.FlowLayoutPanel flpCentro;
		private System.ComponentModel.BackgroundWorker bgwModificar;
	}
}