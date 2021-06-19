namespace VesteBem_Admin
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.lblUser = new System.Windows.Forms.Label();
			this.lblPass = new System.Windows.Forms.Label();
			this.lblTimer = new System.Windows.Forms.Label();
			this.tmrTimer = new System.Windows.Forms.Timer(this.components);
			this.pctLogo = new System.Windows.Forms.PictureBox();
			this.lblAjuda = new System.Windows.Forms.Label();
			this.icnNotificação = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(351, 173);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(90, 38);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btbLogin_Click);
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(99, 71);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(214, 20);
			this.txtUser.TabIndex = 1;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(99, 122);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(214, 20);
			this.txtPass.TabIndex = 2;
			// 
			// lblUser
			// 
			this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(20, 74);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(58, 13);
			this.lblUser.TabIndex = 3;
			this.lblUser.Text = "Username:";
			// 
			// lblPass
			// 
			this.lblPass.AutoSize = true;
			this.lblPass.Location = new System.Drawing.Point(20, 125);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(56, 13);
			this.lblPass.TabIndex = 4;
			this.lblPass.Text = "Password:";
			// 
			// lblTimer
			// 
			this.lblTimer.Enabled = false;
			this.lblTimer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimer.Location = new System.Drawing.Point(12, 9);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(251, 42);
			this.lblTimer.TabIndex = 5;
			this.lblTimer.Text = "label3";
			// 
			// tmrTimer
			// 
			this.tmrTimer.Tick += new System.EventHandler(this.tmrTime_Tick);
			// 
			// pctLogo
			// 
			this.pctLogo.Image = global::VesteBem_Admin.Properties.Resources.Logo;
			this.pctLogo.Location = new System.Drawing.Point(351, 71);
			this.pctLogo.Name = "pctLogo";
			this.pctLogo.Size = new System.Drawing.Size(77, 71);
			this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctLogo.TabIndex = 6;
			this.pctLogo.TabStop = false;
			// 
			// lblAjuda
			// 
			this.lblAjuda.AutoSize = true;
			this.lblAjuda.Location = new System.Drawing.Point(220, 149);
			this.lblAjuda.Name = "lblAjuda";
			this.lblAjuda.Size = new System.Drawing.Size(101, 13);
			this.lblAjuda.TabIndex = 7;
			this.lblAjuda.Text = "Precisa de ajuda?!?";
			this.lblAjuda.Click += new System.EventHandler(this.lblAjuda_Click);
			// 
			// icnNotificação
			// 
			this.icnNotificação.Icon = ((System.Drawing.Icon)(resources.GetObject("icnNotificação.Icon")));
			this.icnNotificação.Text = "VesteBem";
			this.icnNotificação.Visible = true;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 223);
			this.Controls.Add(this.lblAjuda);
			this.Controls.Add(this.pctLogo);
			this.Controls.Add(this.lblTimer);
			this.Controls.Add(this.lblPass);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.btnLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
			this.Load += new System.EventHandler(this.frmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblPass;
		private System.Windows.Forms.Label lblTimer;
		private System.Windows.Forms.Timer tmrTimer;
		private System.Windows.Forms.PictureBox pctLogo;
		private System.Windows.Forms.Label lblAjuda;
		private System.Windows.Forms.NotifyIcon icnNotificação;
	}
}

