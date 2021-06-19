namespace VesteBem_Admin
{
	partial class FrmModificarCliFun
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarCliFun));
			this.BgwInicio = new System.ComponentModel.BackgroundWorker();
			this.icnNotificar = new System.Windows.Forms.NotifyIcon(this.components);
			this.SuspendLayout();
			// 
			// BgwInicio
			// 
			this.BgwInicio.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.BgwInicio.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// icnNotificar
			// 
			this.icnNotificar.Icon = ((System.Drawing.Icon)(resources.GetObject("icnNotificar.Icon")));
			this.icnNotificar.Text = "Modificação Com Sucesso";
			this.icnNotificar.Visible = true;
			// 
			// FrmModificarCliFun
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(359, 322);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmModificarCliFun";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modificar Cliente";
			this.Load += new System.EventHandler(this.FrmModificar_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.BackgroundWorker BgwInicio;
		private System.Windows.Forms.NotifyIcon icnNotificar;
	}
}