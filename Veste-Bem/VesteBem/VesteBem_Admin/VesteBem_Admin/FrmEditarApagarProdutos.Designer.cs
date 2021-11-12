
namespace VesteBem_Admin
{
	partial class frmEditarApagarProdutos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarApagarProdutos));
			this.pnlCima = new System.Windows.Forms.Panel();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblCat = new System.Windows.Forms.Label();
			this.cmbCategoria = new System.Windows.Forms.ComboBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.flwCentro = new System.Windows.Forms.FlowLayoutPanel();
			this.bgwInicio = new System.ComponentModel.BackgroundWorker();
			this.bgwModificar = new System.ComponentModel.BackgroundWorker();
			this.LblNomeProduto = new System.Windows.Forms.Label();
			this.LblCategoria = new System.Windows.Forms.Label();
			this.LblSubCategoria = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.icnApagar = new System.Windows.Forms.NotifyIcon(this.components);
			this.pnlCima.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlCima
			// 
			this.pnlCima.Controls.Add(this.lblNome);
			this.pnlCima.Controls.Add(this.lblCat);
			this.pnlCima.Controls.Add(this.cmbCategoria);
			this.pnlCima.Controls.Add(this.txtNome);
			this.pnlCima.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCima.Location = new System.Drawing.Point(0, 0);
			this.pnlCima.Margin = new System.Windows.Forms.Padding(0);
			this.pnlCima.Name = "pnlCima";
			this.pnlCima.Size = new System.Drawing.Size(824, 42);
			this.pnlCima.TabIndex = 0;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(8, 13);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(93, 13);
			this.lblNome.TabIndex = 3;
			this.lblNome.Text = "Nome do Produto:";
			// 
			// lblCat
			// 
			this.lblCat.AutoSize = true;
			this.lblCat.Location = new System.Drawing.Point(559, 13);
			this.lblCat.Name = "lblCat";
			this.lblCat.Size = new System.Drawing.Size(55, 13);
			this.lblCat.TabIndex = 2;
			this.lblCat.Text = "Categoria:";
			// 
			// cmbCategoria
			// 
			this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategoria.FormattingEnabled = true;
			this.cmbCategoria.Location = new System.Drawing.Point(620, 10);
			this.cmbCategoria.Name = "cmbCategoria";
			this.cmbCategoria.Size = new System.Drawing.Size(168, 21);
			this.cmbCategoria.TabIndex = 1;
			this.cmbCategoria.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(104, 10);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(200, 20);
			this.txtNome.TabIndex = 0;
			this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// flwCentro
			// 
			this.flwCentro.AutoScroll = true;
			this.flwCentro.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.flwCentro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flwCentro.Location = new System.Drawing.Point(0, 42);
			this.flwCentro.Name = "flwCentro";
			this.flwCentro.Size = new System.Drawing.Size(824, 408);
			this.flwCentro.TabIndex = 1;
			// 
			// bgwInicio
			// 
			this.bgwInicio.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.bgwInicio.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// bgwModificar
			// 
			this.bgwModificar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
			// 
			// LblNomeProduto
			// 
			this.LblNomeProduto.Location = new System.Drawing.Point(0, 0);
			this.LblNomeProduto.Name = "LblNomeProduto";
			this.LblNomeProduto.Size = new System.Drawing.Size(100, 23);
			this.LblNomeProduto.TabIndex = 0;
			// 
			// LblCategoria
			// 
			this.LblCategoria.Location = new System.Drawing.Point(0, 0);
			this.LblCategoria.Name = "LblCategoria";
			this.LblCategoria.Size = new System.Drawing.Size(100, 23);
			this.LblCategoria.TabIndex = 0;
			// 
			// LblSubCategoria
			// 
			this.LblSubCategoria.Location = new System.Drawing.Point(0, 0);
			this.LblSubCategoria.Name = "LblSubCategoria";
			this.LblSubCategoria.Size = new System.Drawing.Size(100, 23);
			this.LblSubCategoria.TabIndex = 0;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 50);
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// icnApagar
			// 
			this.icnApagar.Icon = ((System.Drawing.Icon)(resources.GetObject("icnApagar.Icon")));
			this.icnApagar.Text = "Apagar Produto";
			this.icnApagar.Visible = true;
			// 
			// frmEditarApagarProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 450);
			this.Controls.Add(this.flwCentro);
			this.Controls.Add(this.pnlCima);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmEditarApagarProdutos";
			this.Text = "Editar ou Apagar Produto";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditarApagarProdutos_FormClosed);
			this.Load += new System.EventHandler(this.frmEditarApagarProdutos_Load);
			this.pnlCima.ResumeLayout(false);
			this.pnlCima.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlCima;
		private System.Windows.Forms.FlowLayoutPanel flwCentro;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.ComboBox cmbCategoria;
		private System.Windows.Forms.Label lblCat;
		private System.Windows.Forms.Label lblNome;
		private System.ComponentModel.BackgroundWorker bgwInicio;
		private System.ComponentModel.BackgroundWorker bgwModificar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label LblNomeProduto;
		private System.Windows.Forms.Label LblCategoria;
		private System.Windows.Forms.Label LblSubCategoria;
		private System.Windows.Forms.NotifyIcon icnApagar;
	}
}