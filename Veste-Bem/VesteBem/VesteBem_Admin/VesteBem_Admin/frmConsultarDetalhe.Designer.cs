namespace VesteBem_Admin
{
	partial class frmConsultarDetalhe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarDetalhe));
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlDetalhes = new System.Windows.Forms.Panel();
			this.lblCli = new System.Windows.Forms.Label();
			this.pctImagem = new System.Windows.Forms.PictureBox();
			this.lblNomeProduto = new System.Windows.Forms.Label();
			this.bgwInicio = new System.ComponentModel.BackgroundWorker();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.pnlDetalhes);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// pnlDetalhes
			// 
			this.pnlDetalhes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDetalhes.Location = new System.Drawing.Point(3, 3);
			this.pnlDetalhes.Name = "pnlDetalhes";
			this.pnlDetalhes.Size = new System.Drawing.Size(200, 0);
			this.pnlDetalhes.TabIndex = 0;
			// 
			// lblCli
			// 
			this.lblCli.Location = new System.Drawing.Point(0, 0);
			this.lblCli.Name = "lblCli";
			this.lblCli.Size = new System.Drawing.Size(100, 23);
			this.lblCli.TabIndex = 0;
			// 
			// pctImagem
			// 
			this.pctImagem.Location = new System.Drawing.Point(0, 0);
			this.pctImagem.Name = "pctImagem";
			this.pctImagem.Size = new System.Drawing.Size(100, 50);
			this.pctImagem.TabIndex = 0;
			this.pctImagem.TabStop = false;
			// 
			// lblNomeProduto
			// 
			this.lblNomeProduto.Location = new System.Drawing.Point(0, 0);
			this.lblNomeProduto.Name = "lblNomeProduto";
			this.lblNomeProduto.Size = new System.Drawing.Size(100, 23);
			this.lblNomeProduto.TabIndex = 0;
			// 
			// bgwInicio
			// 
			this.bgwInicio.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwInicio_DoWork);
			this.bgwInicio.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwInicio_RunWorkerCompleted);
			// 
			// frmConsultarDetalhe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmConsultarDetalhe";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consultar Detalhe";
			this.Load += new System.EventHandler(this.frmConsultarDetalhe_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel pnlDetalhes;
		private System.Windows.Forms.Label lblNomeProduto;
		private System.Windows.Forms.PictureBox pctImagem;
		private System.Windows.Forms.Label lblCli;
		private System.ComponentModel.BackgroundWorker bgwInicio;
	}
}