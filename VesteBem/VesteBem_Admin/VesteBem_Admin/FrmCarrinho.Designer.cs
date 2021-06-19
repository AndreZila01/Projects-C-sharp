namespace VesteBem_Admin
{
	partial class frmCarrinho
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarrinho));
			this.txtValor = new System.Windows.Forms.TextBox();
			this.cboCliente = new System.Windows.Forms.ComboBox();
			this.lblValor = new System.Windows.Forms.Label();
			this.lblEstado = new System.Windows.Forms.Label();
			this.lblData = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.cboEstado = new System.Windows.Forms.ComboBox();
			this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.cmbProduto = new System.Windows.Forms.ComboBox();
			this.flpProdutos = new System.Windows.Forms.FlowLayoutPanel();
			this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
			this.lblTotal = new System.Windows.Forms.Label();
			this.pctRegistar = new System.Windows.Forms.PictureBox();
			this.pctEncomenda = new System.Windows.Forms.PictureBox();
			this.bgwInicio = new System.ComponentModel.BackgroundWorker();
			this.pnlEncomendar = new System.Windows.Forms.Panel();
			this.lblQuantidade = new System.Windows.Forms.Label();
			this.pctAdd = new System.Windows.Forms.PictureBox();
			this.pnlRegistar = new System.Windows.Forms.Panel();
			this.icnNotificacao = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctRegistar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctEncomenda)).BeginInit();
			this.pnlEncomendar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctAdd)).BeginInit();
			this.pnlRegistar.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(122, 65);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(139, 20);
			this.txtValor.TabIndex = 0;
			// 
			// cboCliente
			// 
			this.cboCliente.FormattingEnabled = true;
			this.cboCliente.Location = new System.Drawing.Point(122, 146);
			this.cboCliente.Name = "cboCliente";
			this.cboCliente.Size = new System.Drawing.Size(139, 21);
			this.cboCliente.TabIndex = 4;
			// 
			// lblValor
			// 
			this.lblValor.AutoSize = true;
			this.lblValor.Location = new System.Drawing.Point(15, 68);
			this.lblValor.Name = "lblValor";
			this.lblValor.Size = new System.Drawing.Size(96, 13);
			this.lblValor.TabIndex = 5;
			this.lblValor.Text = "Valor Encomendas";
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Location = new System.Drawing.Point(15, 94);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(105, 13);
			this.lblEstado.TabIndex = 6;
			this.lblEstado.Text = "Estado Encomendas";
			// 
			// lblData
			// 
			this.lblData.AutoSize = true;
			this.lblData.Location = new System.Drawing.Point(15, 122);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(70, 13);
			this.lblData.TabIndex = 8;
			this.lblData.Text = "Data Entrega";
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Location = new System.Drawing.Point(15, 149);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(39, 13);
			this.lblCliente.TabIndex = 9;
			this.lblCliente.Text = "Cliente";
			// 
			// cboEstado
			// 
			this.cboEstado.FormattingEnabled = true;
			this.cboEstado.Location = new System.Drawing.Point(122, 91);
			this.cboEstado.Name = "cboEstado";
			this.cboEstado.Size = new System.Drawing.Size(139, 21);
			this.cboEstado.TabIndex = 10;
			// 
			// dtpEntrega
			// 
			this.dtpEntrega.Location = new System.Drawing.Point(122, 120);
			this.dtpEntrega.Name = "dtpEntrega";
			this.dtpEntrega.Size = new System.Drawing.Size(200, 20);
			this.dtpEntrega.TabIndex = 12;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(32, 191);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(164, 46);
			this.btnGuardar.TabIndex = 13;
			this.btnGuardar.Text = "Efectuar Compra";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
			// 
			// cmbProduto
			// 
			this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProduto.FormattingEnabled = true;
			this.cmbProduto.Location = new System.Drawing.Point(209, 12);
			this.cmbProduto.Name = "cmbProduto";
			this.cmbProduto.Size = new System.Drawing.Size(239, 21);
			this.cmbProduto.TabIndex = 15;
			this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// flpProdutos
			// 
			this.flpProdutos.AutoScroll = true;
			this.flpProdutos.Location = new System.Drawing.Point(177, 250);
			this.flpProdutos.Name = "flpProdutos";
			this.flpProdutos.Size = new System.Drawing.Size(271, 163);
			this.flpProdutos.TabIndex = 19;
			// 
			// nudQuantidade
			// 
			this.nudQuantidade.Location = new System.Drawing.Point(18, 224);
			this.nudQuantidade.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.nudQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudQuantidade.Name = "nudQuantidade";
			this.nudQuantidade.Size = new System.Drawing.Size(75, 20);
			this.nudQuantidade.TabIndex = 20;
			this.nudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(325, 427);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(40, 13);
			this.lblTotal.TabIndex = 21;
			this.lblTotal.Text = "Total : ";
			// 
			// pctRegistar
			// 
			this.pctRegistar.Image = global::VesteBem_Admin.Properties.Resources.shopping_cart;
			this.pctRegistar.Location = new System.Drawing.Point(413, 419);
			this.pctRegistar.Name = "pctRegistar";
			this.pctRegistar.Size = new System.Drawing.Size(35, 27);
			this.pctRegistar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctRegistar.TabIndex = 22;
			this.pctRegistar.TabStop = false;
			this.pctRegistar.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pctEncomenda
			// 
			this.pctEncomenda.Location = new System.Drawing.Point(209, 39);
			this.pctEncomenda.Name = "pctEncomenda";
			this.pctEncomenda.Size = new System.Drawing.Size(239, 205);
			this.pctEncomenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctEncomenda.TabIndex = 14;
			this.pctEncomenda.TabStop = false;
			// 
			// bgwInicio
			// 
			this.bgwInicio.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// pnlEncomendar
			// 
			this.pnlEncomendar.Controls.Add(this.lblQuantidade);
			this.pnlEncomendar.Controls.Add(this.pctAdd);
			this.pnlEncomendar.Controls.Add(this.cmbProduto);
			this.pnlEncomendar.Controls.Add(this.pctRegistar);
			this.pnlEncomendar.Controls.Add(this.pctEncomenda);
			this.pnlEncomendar.Controls.Add(this.lblTotal);
			this.pnlEncomendar.Controls.Add(this.nudQuantidade);
			this.pnlEncomendar.Controls.Add(this.flpProdutos);
			this.pnlEncomendar.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlEncomendar.Location = new System.Drawing.Point(340, 0);
			this.pnlEncomendar.Name = "pnlEncomendar";
			this.pnlEncomendar.Size = new System.Drawing.Size(460, 450);
			this.pnlEncomendar.TabIndex = 23;
			// 
			// lblQuantidade
			// 
			this.lblQuantidade.AutoSize = true;
			this.lblQuantidade.Location = new System.Drawing.Point(15, 201);
			this.lblQuantidade.Name = "lblQuantidade";
			this.lblQuantidade.Size = new System.Drawing.Size(71, 13);
			this.lblQuantidade.TabIndex = 24;
			this.lblQuantidade.Text = "Quantidade : ";
			// 
			// pctAdd
			// 
			this.pctAdd.Image = global::VesteBem_Admin.Properties.Resources.add;
			this.pctAdd.Location = new System.Drawing.Point(119, 217);
			this.pctAdd.Name = "pctAdd";
			this.pctAdd.Size = new System.Drawing.Size(32, 33);
			this.pctAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctAdd.TabIndex = 23;
			this.pctAdd.TabStop = false;
			this.pctAdd.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pnlRegistar
			// 
			this.pnlRegistar.Controls.Add(this.cboCliente);
			this.pnlRegistar.Controls.Add(this.txtValor);
			this.pnlRegistar.Controls.Add(this.btnGuardar);
			this.pnlRegistar.Controls.Add(this.lblValor);
			this.pnlRegistar.Controls.Add(this.dtpEntrega);
			this.pnlRegistar.Controls.Add(this.lblEstado);
			this.pnlRegistar.Controls.Add(this.cboEstado);
			this.pnlRegistar.Controls.Add(this.lblData);
			this.pnlRegistar.Controls.Add(this.lblCliente);
			this.pnlRegistar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlRegistar.Enabled = false;
			this.pnlRegistar.Location = new System.Drawing.Point(0, 0);
			this.pnlRegistar.Name = "pnlRegistar";
			this.pnlRegistar.Size = new System.Drawing.Size(340, 450);
			this.pnlRegistar.TabIndex = 24;
			// 
			// icnNotificacao
			// 
			this.icnNotificacao.Icon = ((System.Drawing.Icon)(resources.GetObject("icnNotificacao.Icon")));
			this.icnNotificacao.Text = "VesteBem";
			this.icnNotificacao.Visible = true;
			// 
			// frmCarrinho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlRegistar);
			this.Controls.Add(this.pnlEncomendar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmCarrinho";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adicionar Carrinho";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCarrinho_FormClosed);
			this.Load += new System.EventHandler(this.FrmCarrinho_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctRegistar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctEncomenda)).EndInit();
			this.pnlEncomendar.ResumeLayout(false);
			this.pnlEncomendar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctAdd)).EndInit();
			this.pnlRegistar.ResumeLayout(false);
			this.pnlRegistar.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.ComboBox cboCliente;
		private System.Windows.Forms.Label lblValor;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.ComboBox cboEstado;
		private System.Windows.Forms.DateTimePicker dtpEntrega;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.PictureBox pctEncomenda;
		private System.Windows.Forms.ComboBox cmbProduto;
		private System.Windows.Forms.FlowLayoutPanel flpProdutos;
		private System.Windows.Forms.NumericUpDown nudQuantidade;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.PictureBox pctRegistar;
		private System.ComponentModel.BackgroundWorker bgwInicio;
		private System.Windows.Forms.Panel pnlEncomendar;
		private System.Windows.Forms.PictureBox pctAdd;
		private System.Windows.Forms.Panel pnlRegistar;
		private System.Windows.Forms.Label lblQuantidade;
		private System.Windows.Forms.NotifyIcon icnNotificacao;
	}
}