using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VesteBem_Admin
{
	public partial class frmAdmin : Form
	{
		public static int ecra = 0;
		private string Username, Password;
		public frmAdmin(string user, string pass)
		{
			InitializeComponent();
			Username = user;
			Password = pass;
		}

		Form frm;

		private void button_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;

			switch (btn.Text)
			{
				case "Adicionar Produtos":
					frm = new frmAddChangeProdutos(0);
					//frm.Show();
					break;
				case "Clientes E Funcionarios":
					frm = new frmCliEFun();
					//frm.Show();
					break;
				case "Adicionar Carrinho":
					frm = new frmCarrinho();
					//frm.Show();
					break;
				case "Consultar Carrinho":
					frm = new frmConsultarCarrinho();
					//frm.Show();
					break;
			}

			//Process[] procs = Process.GetProcessesByName("VesteBem_Admin");
			//	foreach (Process proc in procs)
			//	{
			//		if (proc.MainWindowTitle == frm.Name)
			//			this.Tag = true;
			//	}


		}

		private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}


		private void label3_Click(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			try
			{

				switch (int.Parse(lbl.Tag.ToString()))
				{
					case 0:
						frm = new frmAddChangeProdutos(0);
						//frm.Show();
						break;
					case 1:
						frm = new frmEditarApagarProdutos();
						break;
					case 2:
						frm = new frmCliEFun();
						//frm.Show();
						break;
					case 3:
						frm = new frmCarrinho();
						//frm.Show();
						break;
					case 4:
						frm = new frmConsultarCarrinho();
						//frm.Show();
						break;
					case 5:
						var ds = pnlSettings.Visible == true ? pnlSettings.Visible = false : pnlSettings.Visible = true;
						break;
					case 6:
						FormCollection fc = Application.OpenForms;
						foreach (Form frms in fc)
							if (frms.Text == "Login")
							{
								this.Hide();
								frms.Show();
							}
						break;
				}
				if (int.Parse(lbl.Tag.ToString()) != 5 && int.Parse(lbl.Tag.ToString()) != 6)
					Forms();
			}
			catch
			{

			}
			//Forms();
		}

		private void Forms()
		{
			this.Tag = "false";
			foreach (Form frms in Application.OpenForms)
			{
				if (frms.Name == frm.Name)
					this.Tag = "true";
			}


			if (this.Tag.ToString() != "true")
				frm.Show();


			this.WindowState = FormWindowState.Minimized;
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			try
			{

				PictureBox pct = sender as PictureBox;

				switch (int.Parse(pct.Tag.ToString()))
				{
					case 0:
						frm = new frmAddChangeProdutos(0);
						//frm.Show();
						break;
					case 1:
						frm = new frmEditarApagarProdutos();
						break;
					case 2:
						frm = new frmCliEFun();
						//frm.Show();
						break;
					case 3:
						frm = new frmCarrinho();
						//frm.Show();
						break;
					case 4:
						frm = new frmConsultarCarrinho();
						//frm.Show();
						break;
					case 5:
						var ds = pnlSettings.Visible == true ? pnlSettings.Visible = false : pnlSettings.Visible = true;
						break;
					case 6:
						FormCollection fc = Application.OpenForms;
						foreach (Form frm in fc)
							foreach (Form frms in fc)
								if (frms.Text == "Login")
								{
									this.Hide();
									frms.Show();
								}
						break;
				}
				if(int.Parse(pct.Tag.ToString())!=5 && int.Parse(pct.Tag.ToString()) != 6)
					Forms();
			}
			catch
			{

			}
		}

		private void panel2_Click(object sender, EventArgs e)
		{
			try
			{

				Panel pnl = sender as Panel;

				switch (int.Parse(pnl.Tag.ToString()))
				{
					case 0:
						frm = new frmAddChangeProdutos(0);
						//frm.Show();
						break;
					case 1:
						frm = new frmEditarApagarProdutos();
						break;
					case 2:
						frm = new frmCliEFun();
						//frm.Show();
						break;
					case 3:
						frm = new frmCarrinho();
						//frm.Show();
						break;
					case 4:
						frm = new frmConsultarCarrinho();
						//frm.Show();
						break;
					case 5:
						var ds = pnlSettings.Visible == true ? pnlSettings.Visible = false : pnlSettings.Visible = true;
						break;
					case 6:
						FormCollection fc = Application.OpenForms;
						foreach (Form frms in fc)
							if (frms.Text == "Login")
							{
								this.Hide();
								frms.Show();
							}
						break;
				}
				if (int.Parse(pnl.Tag.ToString()) != 5 && int.Parse(pnl.Tag.ToString()) != 6)
					Forms();
			}
			catch
			{

			}
		}


		private void pct_Click(object sender, EventArgs e)
		{
			PictureBox pct = sender as PictureBox;
			if (pct.Name == "pctFlow")
			{
				var ds = flpForms.Visible == true ? flpForms.Visible = false : flpForms.Visible = true;
			}
			else
			{
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (checkBox.Text == "Auto Run (Abrir com o SO, Sistema Operativo)")
			{
				RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				if (chkAuto.Checked)
				{
					Application.EnableVisualStyles();
					rkApp.SetValue("VesteBem Admin", Application.ExecutablePath.ToString());
				}
				else
					rkApp.DeleteValue("VesteBem Admin", false);
			}
		}

		private void Modes_Clicks(object sender, EventArgs e)
		{
			//Button BtnMode = sender as Button;

			//if (BtnMode.Text == "White Mode")
			//{

			//}
			//else
			//{

			//}

		}

		private void FrmAdmin_Load(object sender, EventArgs e)
		{
			Screen scrn = Screen.FromControl(this); ecra = int.Parse((scrn.DeviceName.Replace("\\", "").Replace(".DISPLAY", "")));
			lblNome.Text = Username;
			this.ShowIcon = false;
			this.Tag = false;
		}
	}
}
