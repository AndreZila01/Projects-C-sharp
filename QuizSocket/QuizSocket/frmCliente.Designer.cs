namespace QuizSocket
{
	partial class frmCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblFour = new System.Windows.Forms.Label();
            this.chbFour = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblThird = new System.Windows.Forms.Label();
            this.chbThird = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblSecond = new System.Windows.Forms.Label();
            this.chbSecond = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblfirst = new System.Windows.Forms.Label();
            this.chbFirst = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bgwStart = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 73);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 481);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 48);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1067, 433);
            this.panel5.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.lblFour);
            this.panel9.Controls.Add(this.chbFour);
            this.panel9.Location = new System.Drawing.Point(532, 169);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(532, 167);
            this.panel9.TabIndex = 2;
            // 
            // lblFour
            // 
            this.lblFour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFour.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFour.Location = new System.Drawing.Point(11, 41);
            this.lblFour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(509, 108);
            this.lblFour.TabIndex = 3;
            this.lblFour.Text = "label3";
            this.lblFour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFour.Click += new System.EventHandler(this.label_Click);
            // 
            // chbFour
            // 
            this.chbFour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbFour.AutoSize = true;
            this.chbFour.Font = new System.Drawing.Font("Calibri", 10F);
            this.chbFour.Location = new System.Drawing.Point(252, 20);
            this.chbFour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbFour.Name = "chbFour";
            this.chbFour.Size = new System.Drawing.Size(18, 17);
            this.chbFour.TabIndex = 2;
            this.chbFour.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chbFour.UseVisualStyleBackColor = true;
            this.chbFour.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.lblThird);
            this.panel8.Controls.Add(this.chbThird);
            this.panel8.Location = new System.Drawing.Point(0, 169);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(532, 167);
            this.panel8.TabIndex = 2;
            // 
            // lblThird
            // 
            this.lblThird.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblThird.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblThird.Location = new System.Drawing.Point(11, 41);
            this.lblThird.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(509, 108);
            this.lblThird.TabIndex = 3;
            this.lblThird.Text = "label4";
            this.lblThird.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblThird.Click += new System.EventHandler(this.label_Click);
            // 
            // chbThird
            // 
            this.chbThird.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbThird.AutoSize = true;
            this.chbThird.Font = new System.Drawing.Font("Calibri", 10F);
            this.chbThird.Location = new System.Drawing.Point(252, 20);
            this.chbThird.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbThird.Name = "chbThird";
            this.chbThird.Size = new System.Drawing.Size(18, 17);
            this.chbThird.TabIndex = 2;
            this.chbThird.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chbThird.UseVisualStyleBackColor = true;
            this.chbThird.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.lblSecond);
            this.panel7.Controls.Add(this.chbSecond);
            this.panel7.Location = new System.Drawing.Point(533, -1);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(531, 167);
            this.panel7.TabIndex = 2;
            // 
            // lblSecond
            // 
            this.lblSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSecond.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSecond.Location = new System.Drawing.Point(11, 41);
            this.lblSecond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(509, 108);
            this.lblSecond.TabIndex = 3;
            this.lblSecond.Text = "label2";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSecond.Click += new System.EventHandler(this.label_Click);
            // 
            // chbSecond
            // 
            this.chbSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbSecond.AutoSize = true;
            this.chbSecond.Font = new System.Drawing.Font("Calibri", 10F);
            this.chbSecond.Location = new System.Drawing.Point(252, 20);
            this.chbSecond.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbSecond.Name = "chbSecond";
            this.chbSecond.Size = new System.Drawing.Size(18, 17);
            this.chbSecond.TabIndex = 2;
            this.chbSecond.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chbSecond.UseVisualStyleBackColor = true;
            this.chbSecond.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.lblfirst);
            this.panel6.Controls.Add(this.chbFirst);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(531, 167);
            this.panel6.TabIndex = 1;
            // 
            // lblfirst
            // 
            this.lblfirst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblfirst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblfirst.Location = new System.Drawing.Point(12, 43);
            this.lblfirst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfirst.Name = "lblfirst";
            this.lblfirst.Size = new System.Drawing.Size(509, 108);
            this.lblfirst.TabIndex = 1;
            this.lblfirst.Text = "label1";
            this.lblfirst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblfirst.Click += new System.EventHandler(this.label_Click);
            // 
            // chbFirst
            // 
            this.chbFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbFirst.AutoSize = true;
            this.chbFirst.Font = new System.Drawing.Font("Calibri", 10F);
            this.chbFirst.Location = new System.Drawing.Point(253, 22);
            this.chbFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbFirst.Name = "chbFirst";
            this.chbFirst.Size = new System.Drawing.Size(18, 17);
            this.chbFirst.TabIndex = 0;
            this.chbFirst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chbFirst.UseVisualStyleBackColor = true;
            this.chbFirst.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblQuestion);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1067, 48);
            this.panel4.TabIndex = 0;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(8, 7);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(140, 35);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 457);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 97);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(421, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send My Option";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bgwStart
            // 
            this.bgwStart.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwStart_DoWork);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.CheckBox chbFirst;
		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label lblFour;
		private System.Windows.Forms.CheckBox chbFour;
		private System.Windows.Forms.Label lblThird;
		private System.Windows.Forms.CheckBox chbThird;
		private System.Windows.Forms.Label lblSecond;
		private System.Windows.Forms.CheckBox chbSecond;
		private System.Windows.Forms.Label lblfirst;
		private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker bgwStart;
    }
}