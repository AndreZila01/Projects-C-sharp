
namespace VesteBem_Admin
{
	partial class frmCliEFun
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliEFun));
			this.msMenu = new System.Windows.Forms.MenuStrip();
			this.tsmiCliente = new System.Windows.Forms.ToolStripMenuItem();
			this.tstbCliente = new System.Windows.Forms.ToolStripTextBox();
			this.tsmiFuncionario = new System.Windows.Forms.ToolStripMenuItem();
			this.tstbFuncionario = new System.Windows.Forms.ToolStripTextBox();
			this.tsmiNovoFuncionario = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlCentro = new System.Windows.Forms.Panel();
			this.bgwCliente = new System.ComponentModel.BackgroundWorker();
			this.icnApagar = new System.Windows.Forms.NotifyIcon(this.components);
			this.msMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// msMenu
			// 
			this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCliente,
            this.tstbCliente,
            this.tsmiFuncionario,
            this.tstbFuncionario,
            this.tsmiNovoFuncionario});
			this.msMenu.Location = new System.Drawing.Point(0, 0);
			this.msMenu.Name = "msMenu";
			this.msMenu.Size = new System.Drawing.Size(800, 24);
			this.msMenu.TabIndex = 48;
			this.msMenu.Text = "menuStrip1";
			// 
			// tsmiCliente
			// 
			this.tsmiCliente.Image = global::VesteBem_Admin.Properties.Resources.user;
			this.tsmiCliente.Name = "tsmiCliente";
			this.tsmiCliente.Size = new System.Drawing.Size(72, 20);
			this.tsmiCliente.Text = "Cliente";
			this.tsmiCliente.Click += new System.EventHandler(this.ToolstripMenuItem_Click);
			// 
			// tstbCliente
			// 
			this.tstbCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tstbCliente.Name = "tstbCliente";
			this.tstbCliente.Size = new System.Drawing.Size(100, 23);
			this.tstbCliente.Visible = false;
			this.tstbCliente.TextChanged += new System.EventHandler(this.tstbClienteEFun_TextChanged);
			// 
			// tsmiFuncionario
			// 
			this.tsmiFuncionario.Image = global::VesteBem_Admin.Properties.Resources.Admin;
			this.tsmiFuncionario.Name = "tsmiFuncionario";
			this.tsmiFuncionario.Size = new System.Drawing.Size(98, 20);
			this.tsmiFuncionario.Text = "Funcionario";
			this.tsmiFuncionario.Click += new System.EventHandler(this.ToolstripMenuItem_Click);
			// 
			// tstbFuncionario
			// 
			this.tstbFuncionario.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tstbFuncionario.Name = "tstbFuncionario";
			this.tstbFuncionario.Size = new System.Drawing.Size(100, 23);
			this.tstbFuncionario.Visible = false;
			this.tstbFuncionario.TextChanged += new System.EventHandler(this.tstbClienteEFun_TextChanged);
			// 
			// tsmiNovoFuncionario
			// 
			this.tsmiNovoFuncionario.Image = global::VesteBem_Admin.Properties.Resources.add;
			this.tsmiNovoFuncionario.Name = "tsmiNovoFuncionario";
			this.tsmiNovoFuncionario.Size = new System.Drawing.Size(140, 20);
			this.tsmiNovoFuncionario.Text = "Novos Funcionarios";
			this.tsmiNovoFuncionario.Visible = false;
			this.tsmiNovoFuncionario.Click += new System.EventHandler(this.ToolstripMenuItem_Click);
			// 
			// pnlCentro
			// 
			this.pnlCentro.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlCentro.Location = new System.Drawing.Point(0, 24);
			this.pnlCentro.Name = "pnlCentro";
			this.pnlCentro.Size = new System.Drawing.Size(800, 532);
			this.pnlCentro.TabIndex = 49;
			this.pnlCentro.Visible = false;
			// 
			// bgwCliente
			// 
			this.bgwCliente.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.bgwCliente.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// icnApagar
			// 
			this.icnApagar.Icon = ((System.Drawing.Icon)(resources.GetObject("icnApagar.Icon")));
			this.icnApagar.Text = "Cliente Apagado com Sucesso";
			this.icnApagar.Visible = true;
			// 
			// frmCliEFun
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 556);
			this.Controls.Add(this.pnlCentro);
			this.Controls.Add(this.msMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.msMenu;
			this.MaximizeBox = false;
			this.Name = "frmCliEFun";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cliente e Funcionario";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCliEFun_FormClosed);
			this.Load += new System.EventHandler(this.FrmCliEFun_Load);
			this.SizeChanged += new System.EventHandler(this.frmCliEFun_SizeChanged);
			this.msMenu.ResumeLayout(false);
			this.msMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip msMenu;
		private System.Windows.Forms.ToolStripMenuItem tsmiCliente;
		private System.Windows.Forms.ToolStripMenuItem tsmiFuncionario;
		private System.Windows.Forms.Panel pnlCentro;
		private System.ComponentModel.BackgroundWorker bgwCliente;
		private System.Windows.Forms.ToolStripMenuItem tsmiNovoFuncionario;
		private System.Windows.Forms.ToolStripTextBox tstbCliente;
		private System.Windows.Forms.ToolStripTextBox tstbFuncionario;
		private System.Windows.Forms.NotifyIcon icnApagar;
	}
}