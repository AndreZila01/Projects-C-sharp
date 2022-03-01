using Hospital.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hospital
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			#region original
			//var url = "https://localhost:44317/api/login";
			if (textBox1.Text != "" && textBox2.Text != "")
			{
				userlogins userl = new userlogins();
				string result = userl.userslogin(textBox1.Text, textBox2.Text);

				#endregion
				if (result=="True")
				{
					Form2 frm = new Form2(int.Parse(textBox1.Tag.ToString()));
					frm.ShowDialog();
					this.Close();
				}
				else if(result=="Admin")
				{
					//Hospital.
				}
				else
					MessageBox.Show("");

			}
		}

	}
}
