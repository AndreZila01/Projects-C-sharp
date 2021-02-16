namespace Jogo_Sudoku
{
	partial class Sudoku
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sudoku));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.pnlTop.Controls.Add(this.label2);
			this.pnlTop.Controls.Add(this.pictureBox1);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(480, 50);
			this.pnlTop.TabIndex = 0;
			this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(89, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(260, 30);
			this.label2.TabIndex = 1;
			this.label2.Text = "Timer:                                00:00:00";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::Jogo_Sudoku.Properties.Resources.close_white;
			this.pictureBox1.Location = new System.Drawing.Point(428, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(44, 36);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
			this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Fácil",
            "Médio",
            "Difícil",
            "Personalizar"});
			this.comboBox1.Location = new System.Drawing.Point(9, 67);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.TabStop = false;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Escolha o modo:";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80"});
			this.comboBox2.Location = new System.Drawing.Point(332, 37);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(92, 21);
			this.comboBox2.TabIndex = 0;
			this.comboBox2.TabStop = false;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(18, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(198, 15);
			this.label4.TabIndex = 1;
			this.label4.Text = "&Digite os quadrados selecionados : ";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label5.Location = new System.Drawing.Point(18, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 15);
			this.label5.TabIndex = 2;
			this.label5.Text = "&Timer :";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(332, 68);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(48, 17);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.TabStop = false;
			this.checkBox1.Text = "True";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label6.Location = new System.Drawing.Point(18, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "&Limite de Tempo";
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(332, 97);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(48, 17);
			this.checkBox3.TabIndex = 6;
			this.checkBox3.TabStop = false;
			this.checkBox3.Text = "True";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(285, 172);
			this.textBox1.MaxLength = 2;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(76, 20);
			this.textBox1.TabIndex = 7;
			this.textBox1.Visible = false;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(383, 172);
			this.textBox2.MaxLength = 2;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(76, 20);
			this.textBox2.TabIndex = 8;
			this.textBox2.Visible = false;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label8.Location = new System.Drawing.Point(297, 154);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 15);
			this.label8.TabIndex = 11;
			this.label8.Text = "&Minutes";
			this.label8.Visible = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label9.Location = new System.Drawing.Point(395, 154);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 15);
			this.label9.TabIndex = 12;
			this.label9.Text = "&Seconds";
			this.label9.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Location = new System.Drawing.Point(0, 94);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(480, 300);
			this.panel1.TabIndex = 0;
			this.panel1.Visible = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label10.ForeColor = System.Drawing.Color.DarkRed;
			this.label10.Location = new System.Drawing.Point(304, 10);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(144, 15);
			this.label10.TabIndex = 14;
			this.label10.Text = ">= 20, poderá demorar!!";
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(293, 239);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(166, 46);
			this.button1.TabIndex = 13;
			this.button1.Text = "Ready??";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label7.Location = new System.Drawing.Point(211, 154);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 15);
			this.label7.TabIndex = 10;
			this.label7.Text = "&Hours";
			this.label7.Visible = false;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(193, 172);
			this.textBox3.MaxLength = 2;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(76, 20);
			this.textBox3.TabIndex = 9;
			this.textBox3.Visible = false;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(19, 13);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.Location = new System.Drawing.Point(0, 94);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(480, 406);
			this.panel2.TabIndex = 5;
			this.panel2.Visible = false;
			// 
			// axWindowsMediaPlayer1
			// 
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(276, 56);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
			this.axWindowsMediaPlayer1.TabIndex = 4;
			this.axWindowsMediaPlayer1.Visible = false;
			// 
			// Sudoku
			// 
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(480, 500);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlTop);
			this.Controls.Add(this.axWindowsMediaPlayer1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Sudoku";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.pnlTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label10;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label2;
	}
}

