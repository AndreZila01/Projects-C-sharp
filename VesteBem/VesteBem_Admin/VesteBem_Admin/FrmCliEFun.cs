using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VesteBem_Admin.Class;


namespace VesteBem_Admin
{
	public partial class frmCliEFun : Form
	{
		List<Cliente> lstCli = new List<Cliente>();
		List<Funcionario> lstFun = new List<Funcionario>();
		public frmCliEFun()
		{
			InitializeComponent();
		}

		private void FrmCliEFun_Load(object sender, EventArgs e)
		{
			this.Location = Screen.AllScreens[(frmAdmin.ecra - 1)].WorkingArea.Location;
			this.CenterToScreen();
			this.ShowIcon = false;
			if (!bgwCliente.IsBusy)
				bgwCliente.RunWorkerAsync();
		}

		private void ToolstripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem dss = sender as ToolStripMenuItem;
			tsmiNovoFuncionario.Visible = false;
			if (dss.Text == "Cliente")
			{
				tstbFuncionario.Visible = false; tstbCliente.Visible = true;
				CreateObjectsCli();
				this.Tag = "Cliente";
			}
			else
			if (dss.Text == "Funcionario")
			{
				tstbFuncionario.Visible = true;tstbCliente.Visible = false;
				CreateObjectsFun(); this.Tag = "Funcionario";
			}
			else
			{
				Cliente cli = new Cliente(); Funcionario fun = new Funcionario();
				CreateObjectsFun(); this.Tag = "New Funcionario";
				FrmModificarCliFun frm = new FrmModificarCliFun(cli, fun);
				frm.ShowDialog();
				lstFun.Clear();
				lstFun = Funcionarios.ConsultarFuncionario();
				CreateObjectsFun();
			}

		}
		private void CreateObjectsFun()
		{
			tsmiNovoFuncionario.Visible = true;

			pnlCentro.Visible = true;
			pnlCentro.Controls.Clear();
			MemoryStream stream = new MemoryStream();
			int ds = 0;

			lstFun.ToList().ForEach(item =>
			{
				Panel pnl = new Panel();
				pnl.Location = new Point(0, 82 * ds);
				pnl.Size = new Size(800, 82); pnl.BorderStyle = BorderStyle.None; pnl.BackColor = Color.AntiqueWhite; pnl.Margin = new Padding(0, 0, 0, 0); pnl.BackColor = Color.FromArgb((15 * ds), (20 * ds), 213);
				pnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
		| System.Windows.Forms.AnchorStyles.Right)));
				pnl.AutoScroll = true;
				pnlCentro.Controls.Add(pnl);

				Label lblUser = new Label();
				lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
				lblUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
				lblUser.Location = new System.Drawing.Point(73, 21);
				lblUser.Name = "lblFun";
				lblUser.Size = new System.Drawing.Size(209, 27);
				lblUser.TabIndex = 1;
				lblUser.Text = item.Nome;
				pnl.Controls.Add(lblUser);

				PictureBox pctEdit = new PictureBox();
				pctEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
				pctEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
				pctEdit.Image = Properties.Resources.Pencil;
				pctEdit.SizeMode = PictureBoxSizeMode.Zoom;
				pctEdit.Location = new System.Drawing.Point(700, 21);
				pctEdit.Name = @"pctEdit\" + ds;
				pctEdit.Size = new System.Drawing.Size(33, 35);
				pctEdit.TabIndex = 2;
				pctEdit.TabStop = false;
				pctEdit.Click += new System.EventHandler(pctEditFun_Click);
				pctEdit.Image = Properties.Resources.Pencil;
				pctEdit.Tag = "" + item.Id_Login;
				pnl.Controls.Add(pctEdit);

				PictureBox pctRemove = new PictureBox();
				pctRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
				pctRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
				pctRemove.Location = new System.Drawing.Point(755, 21);
				pctRemove.Name = "pctRemoveF";
				pctRemove.Image = Properties.Resources.Close_trash;
				pctRemove.SizeMode = PictureBoxSizeMode.Zoom;
				pctRemove.Size = new System.Drawing.Size(33, 35);
				pctRemove.TabIndex = 3;
				pctRemove.TabStop = false;
				pctRemove.MouseEnter += new System.EventHandler(pctRemove_MouseEnter);
				pctRemove.Click += new System.EventHandler(pctRemove_Click);
				pctRemove.MouseLeave += new System.EventHandler(pctRemove_MouseLeave);
				pctRemove.Tag = "" + item.IdFuncionario;
				pnl.Controls.Add(pctRemove);

				PictureBox pctUser = new PictureBox();
				pctUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
				pctUser.BackColor = System.Drawing.SystemColors.ButtonShadow;
				pctUser.Image = Properties.Resources.Admin;
				pctUser.Location = new System.Drawing.Point(12, 13);
				pctUser.Name = "pctUser";
				pctUser.SizeMode = PictureBoxSizeMode.Zoom;
				pctUser.Size = new System.Drawing.Size(44, 45);
				pctUser.TabIndex = 0;
				pctUser.TabStop = false;
				pnl.Controls.Add(pctUser);

				ds++;
			});
		}

		private void pctRemove_Click(object sender, EventArgs e)
		{
			string name = "";
			PictureBox Pct = sender as PictureBox;
			if (Pct.Name != "pctRemoveF")
			{


				string ds = Clientes.ApagarCliente(int.Parse(Pct.Tag.ToString()), lstCli[lstCli.FindIndex(lst => lst.Id_Cliente == int.Parse(Pct.Tag.ToString()))].Nome, lstCli[lstCli.FindIndex(lst => lst.Id_Cliente == int.Parse(Pct.Tag.ToString()))].Id_Login);
				if (ds == "sucesso")
				{
					lstCli.RemoveAt(lstCli.FindIndex(lst => lst.Id_Cliente == int.Parse(Pct.Tag.ToString())));
					icnApagar.Visible = true;
					icnApagar.ShowBalloonTip(15, "Cliente Apagado com Sucesso!!", "Conseguiu apagar o Cliente com sucesso!!", ToolTipIcon.Info);
					CreateObjectsCli();
				}
				else
				{
					icnApagar.Visible = true;
					icnApagar.ShowBalloonTip(15, "Error ao apagar cliente!!", "" + ds, ToolTipIcon.Error);
				}
			}
			else
			{
				string ds = Funcionarios.DeleteFuncionario(int.Parse(Pct.Tag.ToString()), lstFun[lstFun.FindIndex(lst => lst.IdFuncionario == int.Parse(Pct.Tag.ToString()))].Id_Login);
				if (ds == "sucesso")
				{
					lstFun.RemoveAt(lstFun.FindIndex(lst => lst.IdFuncionario == int.Parse(Pct.Tag.ToString())));
					icnApagar.Visible = true;
					icnApagar.ShowBalloonTip(15, "Cliente Apagado com Sucesso!!", "Conseguiu apagar o Cliente com sucesso!!", ToolTipIcon.Info);
					CreateObjectsFun();
				}
				else
				{
					icnApagar.Visible = true;
					icnApagar.ShowBalloonTip(15, "Error ao apagar cliente!!", "" + ds, ToolTipIcon.Error);
				}
			}
		}

		private void pctEditFun_Click(object sender, EventArgs e)
		{
			Cliente cli = new Cliente(); Funcionario fun = new Funcionario();
			PictureBox pct = sender as PictureBox;
			fun.IdFuncionario = lstFun[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].IdFuncionario;
			fun.Id_Login = lstFun[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].Id_Login;
			fun.Nome = lstFun[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].Nome;
			fun.Telemovel = lstFun[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].Telemovel;
			fun.Funcao = lstFun[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].Funcao;
			fun.Pass = lstFun[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].Pass;
			fun.Username = lstFun[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].Username;



			FrmModificarCliFun frm = new FrmModificarCliFun(cli, fun);
			frm.ShowDialog();
			lstFun.Clear();
			lstFun = Funcionarios.ConsultarFuncionario();
			if (this.Tag.ToString() == "Cliente")
				CreateObjectsCli();
			else
				CreateObjectsFun();
		}

		private void CreateObjectsCli()
		{
			pnlCentro.Visible = true;
			pnlCentro.Controls.Clear();
			MemoryStream stream = new MemoryStream();
			int ds = 0;

			lstCli.ToList().ForEach(item =>
			{
				Panel pnl = new Panel();
				pnl.Location = new Point(0, 82 * ds);
				pnl.Size = new Size(800, 82); pnl.BorderStyle = BorderStyle.None; pnl.BackColor = Color.AntiqueWhite; pnl.Margin = new Padding(0, 0, 0, 0); pnl.BackColor = Color.FromArgb((15 * ds), (20 * ds), 213);
				pnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
		| System.Windows.Forms.AnchorStyles.Right)));
				pnl.AutoScroll = true;
				pnlCentro.Controls.Add(pnl);

				Label lblUser = new Label();
				lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
				lblUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
				lblUser.Location = new System.Drawing.Point(73, 21);
				lblUser.Name = "lblUser";
				lblUser.Size = new System.Drawing.Size(209, 27);
				lblUser.TabIndex = 1;
				lblUser.Text = item.Nome;
				pnl.Controls.Add(lblUser);

				PictureBox pctEdit = new PictureBox();
				pctEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
				pctEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
				pctEdit.Image = Properties.Resources.Pencil;
				pctEdit.SizeMode = PictureBoxSizeMode.Zoom;
				pctEdit.Location = new System.Drawing.Point(700, 21);
				pctEdit.Name = @"pctEdit\" + ds;
				pctEdit.Size = new System.Drawing.Size(33, 35);
				pctEdit.TabIndex = 2;
				pctEdit.TabStop = false;
				pctEdit.Click += new System.EventHandler(pctEdit_Click);
				pctEdit.Image = Properties.Resources.Pencil;
				pctEdit.Tag = "" + item.Id_Login;
				pnl.Controls.Add(pctEdit);

				PictureBox pctRemove = new PictureBox();
				pctRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
				pctRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
				pctRemove.Location = new System.Drawing.Point(755, 21);
				pctRemove.Name = "pctRemoveU";
				pctRemove.Image = Properties.Resources.Close_trash;
				pctRemove.SizeMode = PictureBoxSizeMode.Zoom;
				pctRemove.Size = new System.Drawing.Size(33, 35);
				pctRemove.TabIndex = 3;
				pctRemove.TabStop = false;
				pctRemove.Tag = "" + item.Id_Cliente;
				pctRemove.Click += new System.EventHandler(pctRemove_Click);
				pctRemove.MouseEnter += new System.EventHandler(pctRemove_MouseEnter);
				pctRemove.MouseLeave += new System.EventHandler(pctRemove_MouseLeave);
				pnl.Controls.Add(pctRemove);

				PictureBox pctUser = new PictureBox();
				pctUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
				pctUser.BackColor = System.Drawing.SystemColors.ButtonShadow;
				pctUser.Image = item.Icon;
				pctUser.Location = new System.Drawing.Point(12, 13);
				pctUser.Name = "pctUser";
				pctUser.SizeMode = PictureBoxSizeMode.Zoom;
				pctUser.Size = new System.Drawing.Size(44, 45);
				pctUser.TabIndex = 0;
				pctUser.TabStop = false;
				pnl.Controls.Add(pctUser);

				ds++;
			});
		}


		private void pctEdit_Click(object sender, EventArgs e)
		{
			Cliente cli = new Cliente(); Funcionario fun = new Funcionario();
			PictureBox pct = sender as PictureBox;
			cli.Nome = lstCli[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].Nome;
			cli.Sexo = lstCli[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].Sexo;
			cli.Telefone = lstCli[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].Telefone;
			cli.Nif = lstCli[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].Nif;
			cli.Morada = lstCli[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].Morada;
			cli.CodPostal = lstCli[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].CodPostal;
			cli.DataNasc = lstCli[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].DataNasc;
			cli.Email = lstCli[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].Morada;
			cli.Localidade = lstCli[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].Localidade;
			cli.Id_Login = int.Parse(pct.Tag.ToString());
			cli.Id_Cliente = lstCli[int.Parse(pct.Name.Substring(8, (pct.Name.Length - 8)))].Id_Cliente;



			FrmModificarCliFun frm = new FrmModificarCliFun(cli, fun);
			frm.ShowDialog();
			lstCli.Clear();
			lstCli = Clientes.ConsultaCliente();
			CreateObjectsCli();

		}

		private void pctRemove_MouseLeave(object sender, EventArgs e)
		{
			PictureBox pct = sender as PictureBox;

			pct.Image = Properties.Resources.Close_trash;
		}

		private void pctRemove_MouseEnter(object sender, EventArgs e)
		{
			PictureBox pct = sender as PictureBox;

			pct.Image = Properties.Resources.Open_trash;
		}

		private void frmCliEFun_SizeChanged(object sender, EventArgs e)
		{

		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			lstCli = Clientes.ConsultaCliente();
			lstFun = Funcionarios.ConsultarFuncionario();
			bgwCliente.DoWork += ToolstripMenuItem_Click;
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{

		}

		private void frmCliEFun_FormClosed(object sender, FormClosedEventArgs e)
		{
			icnApagar.Visible = false;
			FormCollection fc = Application.OpenForms;
			foreach (Form frm in fc)
				frm.WindowState = FormWindowState.Normal;

		}

		private void tstbClienteEFun_TextChanged(object sender, EventArgs e)
		{
			ToolStripTextBox Tslb = sender as ToolStripTextBox;

			switch (Tslb.Name)
			{
				case "tstbCliente":
					if (Tslb.Text != "")
					{
						lstCli.ToList().ForEach(item =>
						{
							try
							{
								if (item.Nome.Remove(Tslb.Text.Length) != Tslb.Text)
									lstCli.Remove(item);
							}
							catch { }
						});
					}
					else
						lstCli = Clientes.ConsultaCliente();
					CreateObjectsCli();
					break;
				case "tstbFuncionario":
					if (Tslb.Text != "")
					{

						lstFun.ToList().ForEach(item =>
						{
							try { 
							if (item.Nome.Remove(Tslb.Text.Length) != Tslb.Text)
								lstFun.Remove(item);
							}
							catch { }
						});
					}
					else
						lstFun = Funcionarios.ConsultarFuncionario();
					CreateObjectsFun();
					break;
			}

		}
	}
}
