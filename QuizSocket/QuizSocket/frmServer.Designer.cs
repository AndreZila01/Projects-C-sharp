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
            this.BgwStart = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlData = new System.Windows.Forms.Panel();
            this.lblIp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblPreview = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lbl1Q = new System.Windows.Forms.Label();
            this.lbl6Q = new System.Windows.Forms.Label();
            this.lbl2Q = new System.Windows.Forms.Label();
            this.lbl5Q = new System.Windows.Forms.Label();
            this.lbl3Q = new System.Windows.Forms.Label();
            this.lbl4Q = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtErrada3 = new System.Windows.Forms.TextBox();
            this.txtErrada1 = new System.Windows.Forms.TextBox();
            this.txtErrada2 = new System.Windows.Forms.TextBox();
            this.txtCerta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.pnlData.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BgwStart
            // 
            this.BgwStart.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwStart_DoWork);
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.pnlData.Controls.Add(this.lblIp);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1176, 91);
            this.pnlData.TabIndex = 0;
            this.pnlData.Tag = "";
            // 
            // lblIp
            // 
            this.lblIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIp.AutoSize = true;
            this.lblIp.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIp.Location = new System.Drawing.Point(11, 46);
            this.lblIp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(177, 36);
            this.lblIp.TabIndex = 2;
            this.lblIp.Text = "Ipv4: 192.168.1xx.1xx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meter data, informações, proxima pergunta etc etc";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(728, 91);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 591);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(448, 534);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox8);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(448, 86);
            this.panel6.TabIndex = 0;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox8.Location = new System.Drawing.Point(397, 26);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(35, 32);
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "label10\r\n0 Rights / 0 Wrong";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::QuizSocket.Properties.Resources.User1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero de Hosts ligados \r\ne se já responderam";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 91);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(728, 591);
            this.panel4.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 195);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(728, 396);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 66);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(728, 330);
            this.panel9.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meter uma textbox para fazer a pergunta e as varias respostas possiveis";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(728, 66);
            this.panel7.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lblPreview);
            this.panel12.Controls.Add(this.lblNext);
            this.panel12.Controls.Add(this.lbl1Q);
            this.panel12.Controls.Add(this.lbl6Q);
            this.panel12.Controls.Add(this.lbl2Q);
            this.panel12.Controls.Add(this.lbl5Q);
            this.panel12.Controls.Add(this.lbl3Q);
            this.panel12.Controls.Add(this.lbl4Q);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(200, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(328, 66);
            this.panel12.TabIndex = 9;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(11, 25);
            this.lblPreview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(55, 16);
            this.lblPreview.TabIndex = 8;
            this.lblPreview.Text = "Preview";
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(285, 26);
            this.lblNext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(34, 16);
            this.lblNext.TabIndex = 7;
            this.lblNext.Text = "Next";
            // 
            // lbl1Q
            // 
            this.lbl1Q.AutoSize = true;
            this.lbl1Q.Enabled = false;
            this.lbl1Q.Location = new System.Drawing.Point(80, 26);
            this.lbl1Q.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1Q.Name = "lbl1Q";
            this.lbl1Q.Size = new System.Drawing.Size(14, 16);
            this.lbl1Q.TabIndex = 5;
            this.lbl1Q.Text = "1";
            // 
            // lbl6Q
            // 
            this.lbl6Q.AutoSize = true;
            this.lbl6Q.Enabled = false;
            this.lbl6Q.Location = new System.Drawing.Point(260, 26);
            this.lbl6Q.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl6Q.Name = "lbl6Q";
            this.lbl6Q.Size = new System.Drawing.Size(14, 16);
            this.lbl6Q.TabIndex = 0;
            this.lbl6Q.Text = "1";
            // 
            // lbl2Q
            // 
            this.lbl2Q.AutoSize = true;
            this.lbl2Q.Enabled = false;
            this.lbl2Q.Location = new System.Drawing.Point(116, 26);
            this.lbl2Q.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2Q.Name = "lbl2Q";
            this.lbl2Q.Size = new System.Drawing.Size(14, 16);
            this.lbl2Q.TabIndex = 2;
            this.lbl2Q.Text = "1";
            // 
            // lbl5Q
            // 
            this.lbl5Q.AutoSize = true;
            this.lbl5Q.Enabled = false;
            this.lbl5Q.Location = new System.Drawing.Point(224, 26);
            this.lbl5Q.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5Q.Name = "lbl5Q";
            this.lbl5Q.Size = new System.Drawing.Size(14, 16);
            this.lbl5Q.TabIndex = 3;
            this.lbl5Q.Text = "1";
            // 
            // lbl3Q
            // 
            this.lbl3Q.AutoSize = true;
            this.lbl3Q.Enabled = false;
            this.lbl3Q.Location = new System.Drawing.Point(152, 26);
            this.lbl3Q.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3Q.Name = "lbl3Q";
            this.lbl3Q.Size = new System.Drawing.Size(14, 16);
            this.lbl3Q.TabIndex = 1;
            this.lbl3Q.Text = "1";
            // 
            // lbl4Q
            // 
            this.lbl4Q.AutoSize = true;
            this.lbl4Q.Enabled = false;
            this.lbl4Q.Location = new System.Drawing.Point(188, 26);
            this.lbl4Q.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4Q.Name = "lbl4Q";
            this.lbl4Q.Size = new System.Drawing.Size(14, 16);
            this.lbl4Q.TabIndex = 4;
            this.lbl4Q.Text = "1";
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 66);
            this.panel11.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(528, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 66);
            this.panel10.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 133);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 62);
            this.panel3.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Caso haja espaço usar isto para customizar";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnOptions);
            this.panel5.Controls.Add(this.btnBlock);
            this.panel5.Controls.Add(this.btnNext);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(373, 62);
            this.panel5.TabIndex = 0;
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.Location = new System.Drawing.Point(285, 5);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(79, 49);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "Options Question";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlock.Location = new System.Drawing.Point(195, 5);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(79, 49);
            this.btnBlock.TabIndex = 2;
            this.btnBlock.Text = "Block Answers";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Location = new System.Drawing.Point(104, 5);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(79, 49);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(11, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 49);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Question";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtErrada3);
            this.panel1.Controls.Add(this.txtErrada1);
            this.panel1.Controls.Add(this.txtErrada2);
            this.panel1.Controls.Add(this.txtCerta);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPergunta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 133);
            this.panel1.TabIndex = 2;
            // 
            // txtErrada3
            // 
            this.txtErrada3.Location = new System.Drawing.Point(453, 96);
            this.txtErrada3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtErrada3.Name = "txtErrada3";
            this.txtErrada3.Size = new System.Drawing.Size(197, 22);
            this.txtErrada3.TabIndex = 10;
            // 
            // txtErrada1
            // 
            this.txtErrada1.Location = new System.Drawing.Point(453, 57);
            this.txtErrada1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtErrada1.Name = "txtErrada1";
            this.txtErrada1.Size = new System.Drawing.Size(197, 22);
            this.txtErrada1.TabIndex = 9;
            // 
            // txtErrada2
            // 
            this.txtErrada2.Location = new System.Drawing.Point(128, 96);
            this.txtErrada2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtErrada2.Name = "txtErrada2";
            this.txtErrada2.Size = new System.Drawing.Size(197, 22);
            this.txtErrada2.TabIndex = 8;
            // 
            // txtCerta
            // 
            this.txtCerta.Location = new System.Drawing.Point(128, 57);
            this.txtCerta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCerta.Name = "txtCerta";
            this.txtCerta.Size = new System.Drawing.Size(197, 22);
            this.txtCerta.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Wrong Answer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Wrong Answer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Wrong Answer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Right Answer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Question:";
            // 
            // txtPergunta
            // 
            this.txtPergunta.Location = new System.Drawing.Point(148, 6);
            this.txtPergunta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPergunta.MaxLength = 500;
            this.txtPergunta.Multiline = true;
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(423, 42);
            this.txtPergunta.TabIndex = 0;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 682);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlData);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmServer";
            this.Text = "frmServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmServer_FormClosed);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.BackgroundWorker BgwStart;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel pnlData;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblIp;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPergunta;
		private System.Windows.Forms.TextBox txtErrada3;
		private System.Windows.Forms.TextBox txtErrada1;
		private System.Windows.Forms.TextBox txtErrada2;
		private System.Windows.Forms.TextBox txtCerta;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnOptions;
		private System.Windows.Forms.Button btnBlock;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.Label lbl1Q;
		private System.Windows.Forms.Label lbl6Q;
		private System.Windows.Forms.Label lbl2Q;
		private System.Windows.Forms.Label lbl5Q;
		private System.Windows.Forms.Label lbl3Q;
		private System.Windows.Forms.Label lbl4Q;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Label lblNext;
		private System.Windows.Forms.Label lblPreview;
	}
}