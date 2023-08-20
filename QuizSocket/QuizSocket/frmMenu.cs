using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSocket
{
	public partial class frmMenu : Form
	{
		public static string ipv4ofuser;
		public frmMenu()
		{
			InitializeComponent();
			if (!bgwStart.IsBusy)
				bgwStart.RunWorkerAsync();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void lbl_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/AndreZila01");
		}

		private void btn_Click(object sender, EventArgs e)
		{
			FormCollection fc = Application.OpenForms;
			bool check = false;
			if (fc.Count == 1)
			{
				if ((((Button)sender).Text != "Host of Game"))
				{
					do
					{
						string ipv4 = Interaction.InputBox($"Whitch is the ip of host");//Interaction.InputBox($"Whitch is the ip of {(((ToolStripMenuItem)sender).Name == "Host of Game" ? "guess" : "host")}");
						System.Net.IPAddress ipAddress = null;

						//if (System.Net.IPAddress.TryParse(ipv4, out ipAddress) && ipv4 != ipv4ofuser && ipv4 != "127.0.0.1")
						check = true;
						//else
						//MessageBox.Show("Error IPV4", "The ipv4 do you wrote are not correct!!\n Go to your command line and write \"ipconfig\", next write the ipv4 adress on textbox!", MessageBoxButtons.OK, MessageBoxIcon.Error);

					} while (!check);
					this.Hide();
					new frmCliente().Show();
				}
				else
				{
					timer1.Stop();
					this.Hide();
					new frmServer().Show();
				}
			}
			else
				MessageBox.Show("Local Server", "You cannot played in same computer!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString("HH:MM:ss");
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			var host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (var ip in host.AddressList)
				if (ip.AddressFamily == AddressFamily.InterNetwork && ip.ToString().Contains("192.168"))
					ipv4ofuser = ip.ToString();
		}

		private void bgwStart_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			panel1.Focus();
			timer1.Start();
			lblIp.Text = $"Ipv4: {ipv4ofuser}";
		}
	}
}
