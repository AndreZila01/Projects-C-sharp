
namespace Pokemon_Catch_Twitch
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
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.tmPokeball = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Pokemon_Catch_Twitch.Properties.Resources.pokeball;
			this.pictureBox1.Location = new System.Drawing.Point(-127, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(153, 118);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(492, 104);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(296, 283);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// tmPokeball
			// 
			this.tmPokeball.Interval = 150;
			this.tmPokeball.Tick += new System.EventHandler(this.tmPokeball_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Name = "Form1";
			this.Text = " ";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Timer tmPokeball;
	}
}

