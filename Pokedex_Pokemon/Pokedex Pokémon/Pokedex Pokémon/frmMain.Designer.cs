namespace Pokedex_Pokémon
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
			this.lblInfo = new System.Windows.Forms.Label();
			this.lblAjuda = new System.Windows.Forms.Label();
			this.lblRodar = new System.Windows.Forms.Label();
			this.lblLista = new System.Windows.Forms.Label();
			this.lblAdd = new System.Windows.Forms.Label();
			this.Clocked = new System.Windows.Forms.Timer(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Ajustar = new System.Windows.Forms.Timer(this.components);
			this.backList = new System.ComponentModel.BackgroundWorker();
			this.lbln = new System.Windows.Forms.Label();
			this.pctPokemon = new System.Windows.Forms.PictureBox();
			this.pctTip2 = new System.Windows.Forms.PictureBox();
			this.pctTip1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pctGira = new System.Windows.Forms.PictureBox();
			this.colorDlg = new System.Windows.Forms.ColorDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctPokemon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctTip2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctTip1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctGira)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(242)))), ((int)(((byte)(201)))));
			this.panel1.Controls.Add(this.lblInfo);
			this.panel1.Controls.Add(this.lblAjuda);
			this.panel1.Controls.Add(this.lblRodar);
			this.panel1.Controls.Add(this.lblLista);
			this.panel1.Controls.Add(this.lblAdd);
			this.panel1.Location = new System.Drawing.Point(55, 213);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(382, 202);
			this.panel1.TabIndex = 3;
			this.panel1.Visible = false;
			// 
			// lblInfo
			// 
			this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.lblInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblInfo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfo.Location = new System.Drawing.Point(48, 140);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(268, 28);
			this.lblInfo.TabIndex = 4;
			this.lblInfo.Text = "System";
			this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblInfo.Click += new System.EventHandler(this.lblinPanel_Click);
			// 
			// lblAjuda
			// 
			this.lblAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.lblAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblAjuda.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAjuda.Location = new System.Drawing.Point(48, 110);
			this.lblAjuda.Name = "lblAjuda";
			this.lblAjuda.Size = new System.Drawing.Size(268, 28);
			this.lblAjuda.TabIndex = 3;
			this.lblAjuda.Text = "Help";
			this.lblAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblAjuda.Click += new System.EventHandler(this.lblinPanel_Click);
			// 
			// lblRodar
			// 
			this.lblRodar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.lblRodar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblRodar.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRodar.Location = new System.Drawing.Point(48, 80);
			this.lblRodar.Name = "lblRodar";
			this.lblRodar.Size = new System.Drawing.Size(268, 28);
			this.lblRodar.TabIndex = 2;
			this.lblRodar.Text = "Rotate Display";
			this.lblRodar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblRodar.Click += new System.EventHandler(this.lblinPanel_Click);
			// 
			// lblLista
			// 
			this.lblLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.lblLista.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblLista.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLista.Location = new System.Drawing.Point(48, 50);
			this.lblLista.Name = "lblLista";
			this.lblLista.Size = new System.Drawing.Size(268, 28);
			this.lblLista.TabIndex = 1;
			this.lblLista.Text = "List Pokemon";
			this.lblLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblLista.Click += new System.EventHandler(this.lblinPanel_Click);
			// 
			// lblAdd
			// 
			this.lblAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.lblAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblAdd.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAdd.Location = new System.Drawing.Point(48, 20);
			this.lblAdd.Name = "lblAdd";
			this.lblAdd.Size = new System.Drawing.Size(268, 28);
			this.lblAdd.TabIndex = 0;
			this.lblAdd.Text = "Add Pokemon";
			this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblAdd.Click += new System.EventHandler(this.lblinPanel_Click);
			// 
			// Clocked
			// 
			this.Clocked.Tick += new System.EventHandler(this.Clocked_Tick);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Info;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new System.Drawing.Point(55, 223);
			this.textBox1.MaxLength = 18;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(170, 30);
			this.textBox1.TabIndex = 5;
			this.textBox1.Visible = false;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// lbln
			// 
			this.lbln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(242)))), ((int)(((byte)(201)))));
			this.lbln.Font = new System.Drawing.Font("Nirmala UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbln.Location = new System.Drawing.Point(247, 370);
			this.lbln.Name = "lbln";
			this.lbln.Size = new System.Drawing.Size(76, 36);
			this.lbln.TabIndex = 5;
			this.lbln.Text = "150";
			this.lbln.Visible = false;
			// 
			// pctPokemon
			// 
			this.pctPokemon.BackColor = System.Drawing.SystemColors.Info;
			this.pctPokemon.Location = new System.Drawing.Point(58, 257);
			this.pctPokemon.Name = "pctPokemon";
			this.pctPokemon.Size = new System.Drawing.Size(167, 153);
			this.pctPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pctPokemon.TabIndex = 8;
			this.pctPokemon.TabStop = false;
			this.pctPokemon.Visible = false;
			this.pctPokemon.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pctPokemon_LoadCompleted);
			// 
			// pctTip2
			// 
			this.pctTip2.BackColor = System.Drawing.SystemColors.Info;
			this.pctTip2.Location = new System.Drawing.Point(403, 264);
			this.pctTip2.Name = "pctTip2";
			this.pctTip2.Size = new System.Drawing.Size(42, 38);
			this.pctTip2.TabIndex = 7;
			this.pctTip2.TabStop = false;
			this.pctTip2.Visible = false;
			// 
			// pctTip1
			// 
			this.pctTip1.BackColor = System.Drawing.SystemColors.Info;
			this.pctTip1.Location = new System.Drawing.Point(403, 223);
			this.pctTip1.Name = "pctTip1";
			this.pctTip1.Size = new System.Drawing.Size(42, 38);
			this.pctTip1.TabIndex = 6;
			this.pctTip1.TabStop = false;
			this.pctTip1.Visible = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(242)))), ((int)(((byte)(201)))));
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox3.Image = global::Pokedex_Pokémon.Properties.Resources.back;
			this.pictureBox3.Location = new System.Drawing.Point(17, 213);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 31);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Visible = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(74)))), ((int)(((byte)(67)))));
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = global::Pokedex_Pokémon.Properties.Resources.Open_Vertical;
			this.pictureBox2.Location = new System.Drawing.Point(16, 384);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 31);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Visible = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Image = global::Pokedex_Pokémon.Properties.Resources.Telemovel_Horizontal_OFF;
			this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(499, 528);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "Horizontal";
			this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			// 
			// pctGira
			// 
			this.pctGira.Location = new System.Drawing.Point(0, 107);
			this.pctGira.Name = "pctGira";
			this.pctGira.Size = new System.Drawing.Size(464, 384);
			this.pctGira.TabIndex = 4;
			this.pctGira.TabStop = false;
			this.pctGira.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(464, 524);
			this.Controls.Add(this.lbln);
			this.Controls.Add(this.pctPokemon);
			this.Controls.Add(this.pctTip2);
			this.Controls.Add(this.pctTip1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pctGira);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = global::Pokedex_Pokémon.Properties.Resources.Rotom;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.TransparencyKey = System.Drawing.Color.Transparent;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pctPokemon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctTip2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctTip1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctGira)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Label lblAjuda;
		private System.Windows.Forms.Label lblRodar;
		private System.Windows.Forms.Label lblLista;
		private System.Windows.Forms.Label lblAdd;
		private System.Windows.Forms.PictureBox pctGira;
		private System.Windows.Forms.Timer Clocked;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox pctTip1;
		private System.Windows.Forms.PictureBox pctTip2;
		private System.Windows.Forms.PictureBox pctPokemon;
		private System.Windows.Forms.Timer Ajustar;
		private System.ComponentModel.BackgroundWorker backList;
		private System.Windows.Forms.Label lbln;
		private System.Windows.Forms.ColorDialog colorDlg;
	}
}

