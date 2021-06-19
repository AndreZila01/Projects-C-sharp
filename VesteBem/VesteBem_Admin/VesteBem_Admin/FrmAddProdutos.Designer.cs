namespace VesteBem_Admin
{
	partial class frmAddChangeProdutos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddChangeProdutos));
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.txtCat = new System.Windows.Forms.TextBox();
			this.txtSubCat = new System.Windows.Forms.TextBox();
			this.txtIcon = new System.Windows.Forms.TextBox();
			this.pctImage = new System.Windows.Forms.PictureBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblValor = new System.Windows.Forms.Label();
			this.lblEmpresa = new System.Windows.Forms.Label();
			this.lblCategoria = new System.Windows.Forms.Label();
			this.lblSubCateg = new System.Windows.Forms.Label();
			this.lblSexo = new System.Windows.Forms.Label();
			this.lblIcon = new System.Windows.Forms.Label();
			this.lblImagem = new System.Windows.Forms.Label();
			this.lblEuro = new System.Windows.Forms.Label();
			this.pctAdd = new System.Windows.Forms.PictureBox();
			this.btnRegistar = new System.Windows.Forms.Button();
			this.cboSexo = new System.Windows.Forms.ComboBox();
			this.icnNotificação = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctAdd)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(109, 47);
			this.txtNome.MaxLength = 100;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(100, 20);
			this.txtNome.TabIndex = 0;
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(109, 83);
			this.txtValor.MaxLength = 9;
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(100, 20);
			this.txtValor.TabIndex = 1;
			this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
			this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.Location = new System.Drawing.Point(109, 122);
			this.txtEmpresa.MaxLength = 100;
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(100, 20);
			this.txtEmpresa.TabIndex = 2;
			// 
			// txtCat
			// 
			this.txtCat.Location = new System.Drawing.Point(109, 163);
			this.txtCat.MaxLength = 100;
			this.txtCat.Name = "txtCat";
			this.txtCat.Size = new System.Drawing.Size(100, 20);
			this.txtCat.TabIndex = 3;
			this.txtCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCats_KeyPress);
			// 
			// txtSubCat
			// 
			this.txtSubCat.Location = new System.Drawing.Point(109, 201);
			this.txtSubCat.MaxLength = 100;
			this.txtSubCat.Name = "txtSubCat";
			this.txtSubCat.Size = new System.Drawing.Size(100, 20);
			this.txtSubCat.TabIndex = 4;
			this.txtSubCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCats_KeyPress);
			// 
			// txtIcon
			// 
			this.txtIcon.Location = new System.Drawing.Point(109, 275);
			this.txtIcon.Name = "txtIcon";
			this.txtIcon.ReadOnly = true;
			this.txtIcon.Size = new System.Drawing.Size(100, 20);
			this.txtIcon.TabIndex = 6;
			// 
			// pctImage
			// 
			this.pctImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.pctImage.Location = new System.Drawing.Point(265, 47);
			this.pctImage.Name = "pctImage";
			this.pctImage.Size = new System.Drawing.Size(288, 323);
			this.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctImage.TabIndex = 7;
			this.pctImage.TabStop = false;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(10, 47);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(35, 13);
			this.lblNome.TabIndex = 8;
			this.lblNome.Text = "Nome";
			// 
			// lblValor
			// 
			this.lblValor.AutoSize = true;
			this.lblValor.Location = new System.Drawing.Point(10, 86);
			this.lblValor.Name = "lblValor";
			this.lblValor.Size = new System.Drawing.Size(31, 13);
			this.lblValor.TabIndex = 9;
			this.lblValor.Text = "Valor";
			// 
			// lblEmpresa
			// 
			this.lblEmpresa.AutoSize = true;
			this.lblEmpresa.Location = new System.Drawing.Point(10, 125);
			this.lblEmpresa.Name = "lblEmpresa";
			this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
			this.lblEmpresa.TabIndex = 10;
			this.lblEmpresa.Text = "Empresa";
			// 
			// lblCategoria
			// 
			this.lblCategoria.AutoSize = true;
			this.lblCategoria.Location = new System.Drawing.Point(12, 166);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(52, 13);
			this.lblCategoria.TabIndex = 11;
			this.lblCategoria.Text = "Categoria";
			// 
			// lblSubCateg
			// 
			this.lblSubCateg.AutoSize = true;
			this.lblSubCateg.Location = new System.Drawing.Point(12, 204);
			this.lblSubCateg.Name = "lblSubCateg";
			this.lblSubCateg.Size = new System.Drawing.Size(74, 13);
			this.lblSubCateg.TabIndex = 12;
			this.lblSubCateg.Text = "Sub Categoria";
			// 
			// lblSexo
			// 
			this.lblSexo.AutoSize = true;
			this.lblSexo.Location = new System.Drawing.Point(12, 242);
			this.lblSexo.Name = "lblSexo";
			this.lblSexo.Size = new System.Drawing.Size(31, 13);
			this.lblSexo.TabIndex = 13;
			this.lblSexo.Text = "Sexo";
			// 
			// lblIcon
			// 
			this.lblIcon.AutoSize = true;
			this.lblIcon.Location = new System.Drawing.Point(10, 278);
			this.lblIcon.Name = "lblIcon";
			this.lblIcon.Size = new System.Drawing.Size(28, 13);
			this.lblIcon.TabIndex = 14;
			this.lblIcon.Text = "Icon";
			// 
			// lblImagem
			// 
			this.lblImagem.AutoSize = true;
			this.lblImagem.Location = new System.Drawing.Point(272, 31);
			this.lblImagem.Name = "lblImagem";
			this.lblImagem.Size = new System.Drawing.Size(39, 13);
			this.lblImagem.TabIndex = 15;
			this.lblImagem.Text = "Image:";
			// 
			// lblEuro
			// 
			this.lblEuro.AutoSize = true;
			this.lblEuro.Location = new System.Drawing.Point(215, 86);
			this.lblEuro.Name = "lblEuro";
			this.lblEuro.Size = new System.Drawing.Size(13, 13);
			this.lblEuro.TabIndex = 16;
			this.lblEuro.Text = "€";
			// 
			// pctAdd
			// 
			this.pctAdd.Image = global::VesteBem_Admin.Properties.Resources.add;
			this.pctAdd.Location = new System.Drawing.Point(218, 275);
			this.pctAdd.Name = "pctAdd";
			this.pctAdd.Size = new System.Drawing.Size(19, 20);
			this.pctAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctAdd.TabIndex = 17;
			this.pctAdd.TabStop = false;
			this.pctAdd.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// btnRegistar
			// 
			this.btnRegistar.Location = new System.Drawing.Point(44, 322);
			this.btnRegistar.Name = "btnRegistar";
			this.btnRegistar.Size = new System.Drawing.Size(151, 48);
			this.btnRegistar.TabIndex = 18;
			this.btnRegistar.Text = "Registar Produtos";
			this.btnRegistar.UseVisualStyleBackColor = true;
			this.btnRegistar.Click += new System.EventHandler(this.btn_Click);
			// 
			// cboSexo
			// 
			this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSexo.FormattingEnabled = true;
			this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
			this.cboSexo.Location = new System.Drawing.Point(109, 242);
			this.cboSexo.Name = "cboSexo";
			this.cboSexo.Size = new System.Drawing.Size(100, 21);
			this.cboSexo.TabIndex = 19;
			// 
			// icnNotificação
			// 
			this.icnNotificação.Icon = ((System.Drawing.Icon)(resources.GetObject("icnNotificação.Icon")));
			this.icnNotificação.Text = "VesteBem";
			this.icnNotificação.Visible = true;
			// 
			// frmAddChangeProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 404);
			this.Controls.Add(this.cboSexo);
			this.Controls.Add(this.btnRegistar);
			this.Controls.Add(this.pctAdd);
			this.Controls.Add(this.lblEuro);
			this.Controls.Add(this.lblImagem);
			this.Controls.Add(this.lblIcon);
			this.Controls.Add(this.lblSexo);
			this.Controls.Add(this.lblSubCateg);
			this.Controls.Add(this.lblCategoria);
			this.Controls.Add(this.lblEmpresa);
			this.Controls.Add(this.lblValor);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.pctImage);
			this.Controls.Add(this.txtIcon);
			this.Controls.Add(this.txtSubCat);
			this.Controls.Add(this.txtCat);
			this.Controls.Add(this.txtEmpresa);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.txtNome);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmAddChangeProdutos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adicionar Produtos";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddProdutos_FormClosed);
			this.Load += new System.EventHandler(this.FrmAddProdutos_Load);
			((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctAdd)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.TextBox txtEmpresa;
		private System.Windows.Forms.TextBox txtCat;
		private System.Windows.Forms.TextBox txtSubCat;
		private System.Windows.Forms.TextBox txtIcon;
		private System.Windows.Forms.PictureBox pctImage;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblValor;
		private System.Windows.Forms.Label lblEmpresa;
		private System.Windows.Forms.Label lblCategoria;
		private System.Windows.Forms.Label lblSubCateg;
		private System.Windows.Forms.Label lblSexo;
		private System.Windows.Forms.Label lblIcon;
		private System.Windows.Forms.Label lblImagem;
		private System.Windows.Forms.Label lblEuro;
		private System.Windows.Forms.PictureBox pctAdd;
		private System.Windows.Forms.Button btnRegistar;
		private System.Windows.Forms.ComboBox cboSexo;
		private System.Windows.Forms.NotifyIcon icnNotificação;
	}
}