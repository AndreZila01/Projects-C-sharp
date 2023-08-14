namespace QuizSocket
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblIp = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.bgwStart = new System.ComponentModel.BackgroundWorker();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblIp);
			this.panel1.Controls.Add(this.lblTime);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(481, 45);
			this.panel1.TabIndex = 0;
			// 
			// lblIp
			// 
			this.lblIp.AutoSize = true;
			this.lblIp.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIp.Location = new System.Drawing.Point(12, 9);
			this.lblIp.Name = "lblIp";
			this.lblIp.Size = new System.Drawing.Size(139, 28);
			this.lblIp.TabIndex = 1;
			this.lblIp.Text = "Ipv4: 192.168.1xx.1xx";
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lblTime.Location = new System.Drawing.Point(379, 9);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(90, 25);
			this.lblTime.TabIndex = 0;
			this.lblTime.Text = "00:00:00";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(197)))), ((int)(((byte)(218)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
			this.button1.Location = new System.Drawing.Point(41, 83);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 97);
			this.button1.TabIndex = 1;
			this.button1.Text = "Host of Game";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.btn_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(197)))), ((int)(((byte)(218)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
			this.button2.Location = new System.Drawing.Point(281, 83);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(160, 97);
			this.button2.TabIndex = 2;
			this.button2.Text = "Guest of Game";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.btn_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 220);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(481, 46);
			this.panel2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
			this.label2.Location = new System.Drawing.Point(277, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(198, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Developed by Andrezila <3";
			this.label2.Click += new System.EventHandler(this.lbl_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// bgwStart
			// 
			this.bgwStart.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.bgwStart.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwStart_RunWorkerCompleted);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(481, 266);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblIp;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.BackgroundWorker bgwStart;
	}
}

