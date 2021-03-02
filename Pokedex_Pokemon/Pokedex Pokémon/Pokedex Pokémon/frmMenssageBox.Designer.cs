namespace Pokedex_Pokémon
{
	partial class frmMenssageBox
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
			this.picIcon = new System.Windows.Forms.PictureBox();
			this.lblText = new System.Windows.Forms.Label();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// picIcon
			// 
			this.picIcon.Location = new System.Drawing.Point(23, 30);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new System.Drawing.Size(70, 51);
			this.picIcon.TabIndex = 0;
			this.picIcon.TabStop = false;
			// 
			// lblText
			// 
			this.lblText.Location = new System.Drawing.Point(112, 30);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(267, 51);
			this.lblText.TabIndex = 1;
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(137, 11);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(75, 23);
			this.btn1.TabIndex = 2;
			this.btn1.Text = "button1";
			this.btn1.UseVisualStyleBackColor = true;
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(222, 11);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(75, 23);
			this.btn2.TabIndex = 3;
			this.btn2.Text = "button2";
			this.btn2.UseVisualStyleBackColor = true;
			// 
			// btn
			// 
			this.btn.Location = new System.Drawing.Point(304, 11);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(75, 23);
			this.btn.TabIndex = 4;
			this.btn.Text = "button3";
			this.btn.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.btn2);
			this.panel1.Controls.Add(this.btn);
			this.panel1.Controls.Add(this.btn1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 100);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(391, 46);
			this.panel1.TabIndex = 5;
			// 
			// frmMenssageBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 146);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblText);
			this.Controls.Add(this.picIcon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMenssageBox";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picIcon;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn;
		private System.Windows.Forms.Panel panel1;
	}
}