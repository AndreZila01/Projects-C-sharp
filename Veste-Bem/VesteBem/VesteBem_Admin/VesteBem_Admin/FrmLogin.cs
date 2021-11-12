using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VesteBem_Admin.Class;

namespace VesteBem_Admin
{
	public partial class frmLogin : Form
	{
		SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		SqlCommand command = new SqlCommand();
		SqlDataReader dr;
		//string mes, hora, minuto, segundo;
		List<Logins> lst = new List<Logins>();
		public frmLogin()
		{
			InitializeComponent();
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
			try
			{
				this.ShowIcon = false;
				Process[] procs = Process.GetProcessesByName("VesteBem_Admin");
				if (procs.Length > 1) foreach (Process proc in procs) { if (proc != procs[0]) proc.Kill(); }
				var myString = File.ReadAllText(Path.Combine(Path.GetTempPath()) + "\\Login.json"); lst = JsonConvert.DeserializeObject<List<Logins>>(myString);

				txtUser.Text = (lst[0].UserName);
				txtPass.Text = (lst[0].Password);
				tmrTimer.Start();
				txtPass.Enabled = false; txtUser.Enabled = false;
				File.Delete(Path.Combine(Path.GetTempPath()) + "\\Login.json");
			}
			catch
			{
				icnNotificação.ShowBalloonTip(25, "Error no Login", "Faça Login, no site!!!", ToolTipIcon.Warning);
				tmrTimer.Start();
				txtPass.Enabled = false; txtUser.Enabled = false;
			}

		}

		private void btbLogin_Click(object sender, EventArgs e)
		{
			tmrTimer.Stop();
			if (txtUser.Text != "" && txtPass.Text != "")
			{
				string pass = EncryptADeDecrypt.DecryptRSA(txtPass.Text), user = "";
				user = /*EncryptADeDecrypt.EncryptOther*/(txtUser.Text);
				command.Connection = liga;
				liga.Open();
				try
				{
					command.CommandText = "Select * fROM tbl_Login where Funcionario=1 and Usern='" + user + "'";
					dr = command.ExecuteReader();
					if (dr.Read())
					{
						if (pass == EncryptADeDecrypt.DecryptRSA(dr["Passw"].ToString()))
						{ 
							string dsss = DateTime.Now.Hour > 0 && DateTime.Now.Hour < 13 ? dsss = "Bom dia" : (DateTime.Now.Hour > 13 && DateTime.Now.Hour < 20 ? dsss = "Boa tarde" : dsss = "Boa noite");
							icnNotificação.ShowBalloonTip(15,"Bem vindo!!", "" + dsss + ", " + txtUser.Text + "!!", ToolTipIcon.None);
							liga.Close();
							frmAdmin frm = new frmAdmin(user, pass);
							frm.Show();
							this.Hide();
						}
						else
						{
							icnNotificação.ShowBalloonTip(15, "Error Login", "Login sem sucesso!\nCertifique se a password e username está correto!", ToolTipIcon.Error);
							tmrTimer.Start();
						}
					}
					else
					{
						icnNotificação.ShowBalloonTip(15, "Error Login", "Login sem sucesso!\nCertifique se a password e username está correto!", ToolTipIcon.Error);
						tmrTimer.Start();
					}
				}
				catch (Exception ex)
				{
					icnNotificação.ShowBalloonTip(15, "Error Login", ""+ ex.Message + "", ToolTipIcon.Error);

					tmrTimer.Start();
				}
				liga.Close();
			}
			else
				icnNotificação.ShowBalloonTip(15, "Error Login", "Faça Login, no site!!!", ToolTipIcon.Warning);
		}

		private void tmrTime_Tick(object sender, EventArgs e)
		{
			DateTime dt = new DateTime(int.Parse(DateTime.Now.Year.ToString()), int.Parse(DateTime.Now.Month.ToString()), int.Parse(DateTime.Now.Day.ToString()), int.Parse(DateTime.Now.Hour.ToString()), int.Parse(DateTime.Now.Minute.ToString()), int.Parse(DateTime.Now.Second.ToString()));
			lblTimer.Text = (dt.ToString("dd.MM.yyyy \t\t HH:mm:ss").Replace('.', '/'));

		}

		private void lblAjuda_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Para conseguir registar no aplicativo, terá de fazer primeiro sessão no site da empresa!\nSó após isso poderá entrar", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			icnNotificação.Visible = false;
		}
	}
}
