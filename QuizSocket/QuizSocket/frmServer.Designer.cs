namespace QuizSocket
{
	partial class frmServer
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
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pnlData = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pnlData.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlData
			// 
			this.pnlData.Controls.Add(this.label1);
			this.pnlData.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlData.Location = new System.Drawing.Point(0, 0);
			this.pnlData.Name = "pnlData";
			this.pnlData.Size = new System.Drawing.Size(882, 74);
			this.pnlData.TabIndex = 0;
			this.pnlData.Tag = "";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(635, 74);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(247, 480);
			this.panel2.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 74);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(635, 480);
			this.panel4.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(185, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(244, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Meter data, informações, proxima pergunta etc etc";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(96, 181);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(346, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Meter uma textbox para fazer a pergunta e as varias respostas possiveis";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(65, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 26);
			this.label3.TabIndex = 1;
			this.label3.Text = "Numero de Hosts ligados \r\ne se já responderam";
			// 
			// frmServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 554);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pnlData);
			this.Name = "frmServer";
			this.Text = "frmServer";
			this.pnlData.ResumeLayout(false);
			this.pnlData.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel pnlData;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}