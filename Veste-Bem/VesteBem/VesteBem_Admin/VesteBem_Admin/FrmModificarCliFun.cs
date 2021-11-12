using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VesteBem_Admin.Class;

namespace VesteBem_Admin
{
	public partial class FrmModificarCliFun : Form
	{
		List<Cliente> Lstcli = new List<Cliente>(); List<Funcionario> Lstfunc = new List<Funcionario>(); List<Funcao> LstFun = new List<Funcao>();
		Cliente Cli = new Cliente(); Funcionario Fun = new Funcionario(); List<Funcionario> LstAllfunc = new List<Funcionario>();
		private const int CP_NOCLOSE_BUTTON = 0x200;
		public FrmModificarCliFun(Cliente cli, Funcionario fun)
		{
			InitializeComponent();
			Lstcli.Add(cli);
			Lstfunc.Add(fun);
		}
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams myCp = base.CreateParams;
				myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
				return myCp;
			}
		}
		private void txt_Leave(object sender, EventArgs e)
		{
			TextBox Txt = sender as TextBox;
			switch (Txt.Name)
			{
				case "TxtNomeCli":
					Cli.Nome = Txt.Text;
					break;
				case "TxtNifCli":
					if (Txt.Text.Length > 8)
						Cli.Nif = Txt.Text;
					break;
				case "TxtMoradaCli":
					Cli.Morada = Txt.Text;
					break;
				case "TxtCodCli":
					if (Txt.TextLength > 7 && !(Txt.Text.Contains('-')))
					{
						char[] charArr = Txt.Text.ToCharArray();
						charArr[4] = '-';
						Txt.Text = "";
						charArr.ToList().ForEach(item =>
						{
							Txt.Text += item;
						});
					}
					Cli.CodPostal = Txt.Text;
					break;
				case "TxtTeleCli":
					if (Txt.Text.Length > 8)
						Cli.Telefone = Txt.Text;
					break;
				case "TxtEmail":
					try
					{
						var addr = new System.Net.Mail.MailAddress(Txt.Text);
						if (addr.Address != "")
							Cli.Email = Txt.Text;
					}
					catch
					{
						Cli.Email = "";
					}
					break;
				case "TxtLocCli":
					Cli.Localidade = Txt.Text;
					break;
				case "TxtNomeFun":
					Fun.Nome = Txt.Text;
					break;
				case "CmbFuncaoFun":
					Fun.Funcao = Txt.Text;
					break;
				case "TxtTelemovelFun":
					if (Txt.Text != "")
						Fun.Telemovel = Txt.Text;
					break;
				case "TxtLoginFun":
					if (Txt.Text != "")
						Fun.Username = Txt.Text;
					break;
				case "TxtPassFun":
					if (Txt.Text != "" && Txt.Text.Length > 9)
						Fun.Pass = Txt.Text;
					else
						MessageBox.Show("A password convém ter mais de 9 caracteres!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					break;
			}
		}

		private void FrmModificar_Load(object sender, EventArgs e)
		{
			this.Location = Screen.AllScreens[(frmAdmin.ecra - 1)].WorkingArea.Location;
			this.CenterToScreen();
			this.ShowIcon = false;
			if (!BgwInicio.IsBusy)
				BgwInicio.RunWorkerAsync();

			if (LstFun.Count > 0)
				LstAllfunc = Funcionarios.ConsultarFuncionario();
		}

		private void comboBox1_Leave(object sender, EventArgs e)
		{
			ComboBox Cbo = sender as ComboBox;
			if (Cbo.Name == "CboSexoCli")
				Cli.Sexo = Cbo.Text.Substring(0, 1);
			else
			{
				Fun.Funcao = Cbo.Text;
				if (Cbo.Name == "CmbFuncao")
					Fun.IdFuncionario = Cbo.SelectedIndex;
			}

		}

		private void dateTimePicker1_Leave(object sender, EventArgs e)
		{
			DateTimePicker Dtp = sender as DateTimePicker;
			Cli.DataNasc = Dtp.Value;
		}

		private void button_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;

			switch (btn.Text)
			{
				case "Guardar":
					SaveCli();
					break;
				case "Cancelar":
					Close();
					break;
				case "Guardar Alterações":
					SaveFun();
					break;
				case "Criar Novo Funcionario":
					SaveNewFun();
					break;

			}
		}
		private void SaveNewFun()
		{
			bool check = false;
			List<Cliente> lstcliente = new List<Cliente>();
			LstAllfunc = Funcionarios.ConsultarFuncionario();

			LstAllfunc.ToList().ForEach(item =>
			{
				if (item.Nome == Fun.Nome)
					check = true;
			});
			if (check != true)
			{
				Fun.IdFuncionario = Lstfunc[0].IdFuncionario;
				Fun.Id_Login = Lstfunc[0].Id_Login;
				string result = Funcionarios.InsertFuncionario(Fun);

				if (result == "sucesso")
				{
					icnNotificar.ShowBalloonTip(15, "Criação feita com sucesso", "Criou o novo Funcionario com sucesso!", ToolTipIcon.Info);
					Close();
				}
				else
					if (MessageBox.Show("" + result + "\nPretender Continuar as alterações?!?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
				{
					Close();

				}
			}
			icnNotificar.ShowBalloonTip(15, "Já existe!!", "Já existe um Funcionario com esse nome!!!", ToolTipIcon.Info);
		}

		private void SaveFun()
		{
			bool check = false;
			List<Cliente> lstcliente = new List<Cliente>();
			LstAllfunc = Funcionarios.ConsultarFuncionario();

			LstAllfunc.ToList().ForEach(item =>
			{
				if (item.Nome == Fun.Nome)
					check = true;
			});
			if (check != true)
			{
				Fun.IdFuncionario = Lstfunc[0].IdFuncionario;
				Fun.Id_Login = Lstfunc[0].Id_Login;
				Fun.id_Funcao = (LstFun[LstFun.FindIndex(r => r.Funcoes == Lstfunc[0].Funcao)].IdFuncao);
				string result = Funcionarios.AtualizarFuncionario(Fun);

				if (result == "sucesso")
				{
					icnNotificar.ShowBalloonTip(15, "Modificou Com Sucesso", "Modificou o novo Funcionario com sucesso!", ToolTipIcon.Info);
					Close();
				}
				else
					if (MessageBox.Show("" + result + "\nPretender Continuar as alterações?!?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
				{
					Close();

				}
			}
			icnNotificar.ShowBalloonTip(15, "Já existe!!", "Já existe um Funcionario com esse nome!!!", ToolTipIcon.Info);
		}

		private void SaveCli()
		{
			bool check = false;
			List<Cliente> lstcliente = new List<Cliente>();
			lstcliente = Clientes.ConsultaCliente();

			lstcliente.Count();

			lstcliente.ToList().ForEach(item =>
			{
				if (item.Nome == Cli.Nome)
					check = true;
			});
			if (check != true)
			{
				if(Cli.Nome==null)
					Cli.Nome= Lstcli[0].Nome;
				if (Cli.Sexo == null)
					Cli.Sexo = Lstcli[0].Sexo;
				if (Cli.Telefone == null)
					Cli.Telefone = Lstcli[0].Telefone;
				if (Cli.Nif == null)
					Cli.Nif = Lstcli[0].Nif;
				if (Cli.Morada == null)
					Cli.Morada = Lstcli[0].Morada;
				if (Cli.Localidade == null)
					Cli.Localidade = Lstcli[0].Localidade;
				if (Cli.DataNasc == null)
					Cli.DataNasc = Lstcli[0].DataNasc;
				if (Cli.CodPostal == null)
					Cli.CodPostal = Lstcli[0].CodPostal;
				if (Cli.Email == null)
					Cli.Email = Lstcli[0].Email;
				if (Cli.Icon == null)
					Cli.Icon = Lstcli[0].Icon;
				if(Cli.DataNasc == DateTime.Parse("01/01/0001 00:00:00"))
					Cli.DataNasc = Lstcli[0].DataNasc;

				Cli.Id_Login = Lstcli[0].Id_Login;
				Cli.Id_Cliente = Lstcli[0].Id_Cliente;
				string result = Clientes.InsertCliente(Cli);

				if (result == "sucesso")
				{
					icnNotificar.ShowBalloonTip(15, "Modificou com sucesso", "Modificou o Cliente com sucesso!", ToolTipIcon.Info);
					Close();
				}
				else
					if (MessageBox.Show("" + result + "\nPretender Continuar as alterações?!?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
					Close();
			}
			else
				icnNotificar.ShowBalloonTip(15, "Já existe!!", "Já existe um Cliente com esse nome!!!", ToolTipIcon.Info);

		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{

		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Controls.Clear();
			if (Lstcli.Count > 0 && Lstcli[0].Id_Login != 0 && Lstcli[0].Id_Cliente != 0)
			{
				this.Text = "Modificar Cliente";
				TextBox TxtNome = new TextBox();
				TxtNome.Location = new System.Drawing.Point(127, 13);
				TxtNome.MaxLength = 100;
				TxtNome.Name = "TxtNomeCli";
				TxtNome.Size = new System.Drawing.Size(172, 20);
				TxtNome.TabIndex = 0;
				TxtNome.Text = Lstcli[0].Nome;
				TxtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_KeyPress);
				TxtNome.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtNome);

				TextBox TxtNif = new TextBox();
				TxtNif.Location = new System.Drawing.Point(127, 65);
				TxtNif.MaxLength = 9;
				TxtNif.Name = "TxtNifCli";
				TxtNif.Text = "TxtNif";
				TxtNif.Size = new System.Drawing.Size(172, 20);
				TxtNif.TabIndex = 2;
				TxtNif.Text = Lstcli[0].Nif;
				TxtNif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_KeyPress);
				TxtNif.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtNif);

				TextBox TxtMorada = new TextBox();
				TxtMorada.Location = new System.Drawing.Point(127, 91);
				TxtMorada.MaxLength = 300;
				TxtMorada.Name = "TxtMoradaCli";
				TxtMorada.Text = "TxtMorada";
				TxtMorada.Size = new System.Drawing.Size(172, 20);
				TxtMorada.TabIndex = 3;
				TxtMorada.Text = Lstcli[0].Morada;
				TxtMorada.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtMorada);

				TextBox TxtCod = new TextBox();
				TxtCod.Location = new System.Drawing.Point(127, 117);
				TxtCod.MaxLength = 8;
				TxtCod.Name = "TxtCodCli";
				TxtCod.Text = "TxtCod";
				TxtCod.Size = new System.Drawing.Size(172, 20);
				TxtCod.TabIndex = 4;
				TxtCod.Text = Lstcli[0].CodPostal;
				TxtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_KeyPress);
				TxtCod.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtCod);

				TextBox TxtTele = new TextBox();
				TxtTele.Location = new System.Drawing.Point(127, 221);
				TxtTele.MaxLength = 9;
				TxtTele.Text = "TxtTeleCli";
				TxtTele.Name = "TxtTeleCli";
				TxtTele.Size = new System.Drawing.Size(172, 20);
				TxtTele.TabIndex = 8;
				TxtTele.Text = Lstcli[0].Telefone;
				TxtTele.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_KeyPress);
				TxtTele.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtTele);

				TextBox TxtEmail = new TextBox();
				TxtEmail.Location = new System.Drawing.Point(127, 195);
				TxtEmail.MaxLength = 300;
				TxtEmail.Text = "TxtEmailCli";
				TxtEmail.Name = "TxtEmail";
				TxtEmail.Size = new System.Drawing.Size(172, 20);
				TxtEmail.TabIndex = 7;
				TxtEmail.Text = Lstcli[0].Email;
				TxtEmail.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtEmail);

				TextBox TxtLoc = new TextBox();
				TxtLoc.Location = new System.Drawing.Point(127, 143);
				TxtLoc.MaxLength = 100;
				TxtLoc.Text = "TxtLocCli";
				TxtLoc.Name = "TxtLocCli";
				TxtLoc.Size = new System.Drawing.Size(172, 20);
				TxtLoc.TabIndex = 5;
				TxtLoc.Text = Lstcli[0].Localidade;
				TxtLoc.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtLoc);

				Label LblNome = new Label();
				LblNome.AutoSize = true;
				LblNome.Location = new System.Drawing.Point(17, 16);
				LblNome.Name = "LblNome";
				LblNome.Size = new System.Drawing.Size(35, 13);
				LblNome.TabIndex = 10;
				LblNome.Text = "Nome";
				this.Controls.Add(LblNome);

				Label LblSexo = new Label();
				LblSexo.AutoSize = true;
				LblSexo.Location = new System.Drawing.Point(17, 42);
				LblSexo.Name = "LblSexo";
				LblSexo.Size = new System.Drawing.Size(31, 13);
				LblSexo.TabIndex = 11;
				LblSexo.Text = "Sexo";
				this.Controls.Add(LblSexo);

				Label LblNif = new Label();
				LblNif.AutoSize = true;
				LblNif.Location = new System.Drawing.Point(17, 68);
				LblNif.Name = "LblNif";
				LblNif.Size = new System.Drawing.Size(20, 13);
				LblNif.TabIndex = 12;
				LblNif.Text = "Nif";
				this.Controls.Add(LblNif);

				Label LblLoc = new Label();
				LblLoc.AutoSize = true;
				LblLoc.Location = new System.Drawing.Point(17, 146);
				LblLoc.Name = "LblLoc";
				LblLoc.Size = new System.Drawing.Size(59, 13);
				LblLoc.TabIndex = 15;
				LblLoc.Text = "Localidade";
				this.Controls.Add(LblLoc);

				Label LlbCod = new Label();
				LlbCod.AutoSize = true;
				LlbCod.Location = new System.Drawing.Point(17, 120);
				LlbCod.Name = "LlbCod";
				LlbCod.Size = new System.Drawing.Size(72, 13);
				LlbCod.TabIndex = 14;
				LlbCod.Text = "Codigo Postal";
				this.Controls.Add(LlbCod);

				Label LblMorada = new Label();
				LblMorada.AutoSize = true;
				LblMorada.Location = new System.Drawing.Point(17, 94);
				LblMorada.Name = "LblMorada";
				LblMorada.Size = new System.Drawing.Size(43, 13);
				LblMorada.TabIndex = 13;
				LblMorada.Text = "Morada";
				this.Controls.Add(LblMorada);

				Label LblTele = new Label();
				LblTele.AutoSize = true;
				LblTele.Location = new System.Drawing.Point(17, 224);
				LblTele.Name = "LblTele";
				LblTele.Size = new System.Drawing.Size(49, 13);
				LblTele.TabIndex = 18;
				LblTele.Text = "Telefone";
				this.Controls.Add(LblTele);

				Label LblEmail = new Label();
				LblEmail.AutoSize = true;
				LblEmail.Location = new System.Drawing.Point(17, 198);
				LblEmail.Name = "LblEmail";
				LblEmail.Size = new System.Drawing.Size(32, 13);
				LblEmail.TabIndex = 17;
				LblEmail.Text = "Email";
				this.Controls.Add(LblEmail);

				Label LblData = new Label();
				LblData.AutoSize = true;
				LblData.Location = new System.Drawing.Point(17, 172);
				LblData.Name = "LblData";
				LblData.Size = new System.Drawing.Size(104, 13);
				LblData.TabIndex = 16;
				LblData.Text = "Data de Nascimento";
				this.Controls.Add(LblData);

				Button BtnSave = new Button();
				BtnSave.Location = new System.Drawing.Point(20, 258);
				BtnSave.Name = "BtnSave";
				BtnSave.Size = new System.Drawing.Size(145, 52);
				BtnSave.TabIndex = 19;
				BtnSave.Text = "Guardar";
				BtnSave.UseVisualStyleBackColor = true;
				BtnSave.Click += new System.EventHandler(button_Click);
				this.Controls.Add(BtnSave);

				Button BtnCancel = new Button();
				BtnCancel.Location = new System.Drawing.Point(184, 258);
				BtnCancel.Name = "button2";
				BtnCancel.Size = new System.Drawing.Size(145, 52);
				BtnCancel.TabIndex = 20;
				BtnCancel.Text = "Cancelar";
				BtnCancel.UseVisualStyleBackColor = true;
				BtnCancel.Click += new System.EventHandler(button_Click);
				this.Controls.Add(BtnCancel);

				ComboBox CboSexo = new ComboBox();
				CboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				CboSexo.FormattingEnabled = true;
				CboSexo.Items.AddRange(new object[] {
			"Masculino",
			"Feminino",
			"Indefenido"});
				CboSexo.Location = new System.Drawing.Point(127, 39);
				CboSexo.Name = "CboSexoCli";
				CboSexo.Size = new System.Drawing.Size(172, 21);
				CboSexo.TabIndex = 21;
				CboSexo.Leave += new System.EventHandler(comboBox1_Leave);
				if (Lstcli[0].Sexo == "M")
					CboSexo.SelectedItem = "Masculino";
				else
				if (Lstcli[0].Sexo == "F")
					CboSexo.SelectedItem = "Feminino";
				else
					CboSexo.SelectedItem = "Indefenido";
				this.Controls.Add(CboSexo);

				DateTimePicker Data = new DateTimePicker();
				Data.Location = new System.Drawing.Point(127, 166);
				Data.Name = "DTPdate";
				Data.Size = new System.Drawing.Size(172, 20);
				Data.TabIndex = 22;
				Data.MinDate = new DateTime((DateTime.Today.Year - 125), DateTime.Today.Month, DateTime.Today.Day);
				Data.MaxDate = DateTime.Now;
				DateTime time = Lstcli[0].DataNasc;
				Data.Value = time;
				Data.Leave += new System.EventHandler(dateTimePicker1_Leave);
				this.Controls.Add(Data);
			}
			else
			if (Lstfunc.Count > 0 && Lstfunc[0].Id_Login != 0 && Lstfunc[0].Nome != null)
			{
				this.Text = "Modificar Funcionario";
				Label LblNome = new Label();
				LblNome.AutoSize = true;
				LblNome.Location = new System.Drawing.Point(51, 80);
				LblNome.Name = "LblNome";
				LblNome.Size = new System.Drawing.Size(43, 13);
				LblNome.TabIndex = 1;
				LblNome.Text = "Nome:";
				this.Controls.Add(LblNome);

				TextBox TxtNome = new TextBox();
				TxtNome.Location = new System.Drawing.Point(156, 80);
				TxtNome.Name = "TxtNomeFun";
				TxtNome.Size = new System.Drawing.Size(135, 20);
				TxtNome.TabIndex = 0;
				TxtNome.MaxLength = 100;
				TxtNome.Text = Lstfunc[0].Nome;
				Fun.Nome = Lstfunc[0].Nome;
				TxtNome.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtNome);

				ComboBox CmbFuncao = new ComboBox();
				CmbFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				CmbFuncao.FormattingEnabled = true;
				CmbFuncao.Location = new System.Drawing.Point(156, 39);
				CmbFuncao.Name = "CmbFuncaoFun";
				CmbFuncao.Size = new System.Drawing.Size(135, 21);
				CmbFuncao.TabIndex = 2;
				LstFun = Funcionarios.SelectFuncao();
				CmbFuncao.Leave += new System.EventHandler(comboBox1_Leave);
				foreach (Funcao ds in LstFun)
				{
					CmbFuncao.Items.Add(ds.Funcoes);
				}
				CmbFuncao.Text = Lstfunc[0].Funcao;
				Fun.Funcao = Lstfunc[0].Funcao;
				this.Controls.Add(CmbFuncao);

				Label LblFuncao = new Label();
				LblFuncao.AutoSize = true;
				LblFuncao.Location = new System.Drawing.Point(51, 42);
				LblFuncao.Name = "LblFuncao";
				LblFuncao.Size = new System.Drawing.Size(46, 13);
				LblFuncao.TabIndex = 3;
				LblFuncao.Text = "Função:";
				this.Controls.Add(LblFuncao);

				Label LblTelemovel = new Label();
				LblTelemovel.AutoSize = true;
				LblTelemovel.Location = new System.Drawing.Point(51, 126);
				LblTelemovel.Name = "LblTelemovel";
				LblTelemovel.Size = new System.Drawing.Size(56, 13);
				LblTelemovel.TabIndex = 5;
				LblTelemovel.Text = "Telemovel: ";
				this.Controls.Add(LblTelemovel);

				TextBox TxtTelemovel = new TextBox();
				TxtTelemovel.Location = new System.Drawing.Point(156, 123);
				TxtTelemovel.Name = "TxtTelemovelFun";
				TxtTelemovel.Size = new System.Drawing.Size(135, 20);
				TxtTelemovel.TabIndex = 4;
				TxtTelemovel.MaxLength = 9;
				Fun.Telemovel = Lstfunc[0].Telemovel;
				TxtTelemovel.Text = Lstfunc[0].Telemovel;
				TxtTelemovel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_KeyPress);
				TxtTelemovel.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtTelemovel);

				Label LblLogin = new Label();
				LblLogin.AutoSize = true;
				LblLogin.Location = new System.Drawing.Point(51, 171);
				LblLogin.Name = "LblLogin";
				LblLogin.Size = new System.Drawing.Size(82, 13);
				LblLogin.TabIndex = 7;
				LblLogin.Text = "Username:";
				this.Controls.Add(LblLogin);

				TextBox TxtLogin = new TextBox();
				TxtLogin.Location = new System.Drawing.Point(156, 168);
				TxtLogin.Name = "TxtLoginFun";
				TxtLogin.Tag = "" + Lstfunc[0].Username;
				Fun.Username = Lstfunc[0].Username;
				TxtLogin.Text = Lstfunc[0].Username.ToString();
				TxtLogin.Size = new System.Drawing.Size(135, 20);
				TxtLogin.TabIndex = 6; TxtLogin.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtLogin);

				Label LblPass = new Label();
				LblPass.AutoSize = true;
				LblPass.Location = new System.Drawing.Point(51, 214);
				LblPass.Name = "LblPass";
				LblPass.Size = new System.Drawing.Size(53, 13);
				LblPass.TabIndex = 9;
				LblPass.Text = "Password: ";
				this.Controls.Add(LblPass);

				TextBox TxtPass = new TextBox();
				TxtPass.Location = new System.Drawing.Point(156, 211);
				TxtPass.Name = "TxtPassFun";
				TxtPass.Text = Lstfunc[0].Pass;
				Fun.Pass = Lstfunc[0].Pass;
				TxtPass.Size = new System.Drawing.Size(135, 20);
				TxtPass.TabIndex = 8; TxtPass.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtPass);

				Button BtnGuardar = new Button();
				BtnGuardar.Location = new System.Drawing.Point(22, 262);
				BtnGuardar.Name = "BtnGuardarFun";
				BtnGuardar.Size = new System.Drawing.Size(118, 48);
				BtnGuardar.TabIndex = 10;
				BtnGuardar.Text = "Guardar Alterações";
				BtnGuardar.UseVisualStyleBackColor = true;
				BtnGuardar.Click += new System.EventHandler(button_Click);
				this.Controls.Add(BtnGuardar);

				Button BtnCancelar = new Button();
				BtnCancelar.Location = new System.Drawing.Point(198, 262);
				BtnCancelar.Name = "BtnCancelar";
				BtnCancelar.Size = new System.Drawing.Size(122, 48);
				BtnCancelar.TabIndex = 11;
				BtnCancelar.Text = "Cancelar";
				BtnCancelar.UseVisualStyleBackColor = true;
				BtnCancelar.Click += new System.EventHandler(button_Click);
				this.Controls.Add(BtnCancelar);
			}
			else
			{
				this.Text = "Modificar Funcionario";
				TextBox TxtNome = new TextBox();
				TxtNome.Location = new System.Drawing.Point(156, 80);
				TxtNome.Name = "TxtNomeFun";
				TxtNome.Size = new System.Drawing.Size(135, 20);
				TxtNome.TabIndex = 0;
				TxtNome.MaxLength = 100;
				TxtNome.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtNome);

				Label LblNome = new Label();
				LblNome.AutoSize = true;
				LblNome.Location = new System.Drawing.Point(51, 80);
				LblNome.Name = "LblNome";
				LblNome.Size = new System.Drawing.Size(43, 13);
				LblNome.TabIndex = 1;
				LblNome.Text = "Nome:";
				this.Controls.Add(LblNome);

				ComboBox CmbFuncao = new ComboBox();
				CmbFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				CmbFuncao.FormattingEnabled = true;
				CmbFuncao.Location = new System.Drawing.Point(156, 39);
				CmbFuncao.Name = "CmbFuncao";
				CmbFuncao.Size = new System.Drawing.Size(135, 21);
				CmbFuncao.TabIndex = 2;
				CmbFuncao.Leave += new System.EventHandler(comboBox1_Leave);
				LstFun = Funcionarios.SelectFuncao();
				foreach (Funcao ds in LstFun)
				{
					CmbFuncao.Items.Add(ds.Funcoes);
				}
				CmbFuncao.Text = Lstfunc[0].Funcao;
				Fun.Funcao = Lstfunc[0].Funcao;
				this.Controls.Add(CmbFuncao);

				Label LblFuncao = new Label();
				LblFuncao.AutoSize = true;
				LblFuncao.Location = new System.Drawing.Point(51, 42);
				LblFuncao.Name = "LblFuncao";
				LblFuncao.Size = new System.Drawing.Size(46, 13);
				LblFuncao.TabIndex = 3;
				LblFuncao.Text = "Função:";
				this.Controls.Add(LblFuncao);

				Label LblTelemovel = new Label();
				LblTelemovel.AutoSize = true;
				LblTelemovel.Location = new System.Drawing.Point(51, 126);
				LblTelemovel.Name = "LblTelemovel";
				LblTelemovel.Size = new System.Drawing.Size(56, 13);
				LblTelemovel.TabIndex = 5;
				LblTelemovel.Text = "Telemovel: ";
				this.Controls.Add(LblTelemovel);

				TextBox TxtTelemovel = new TextBox();
				TxtTelemovel.Location = new System.Drawing.Point(156, 123);
				TxtTelemovel.Name = "TxtTelemovelFun";
				TxtTelemovel.Size = new System.Drawing.Size(135, 20);
				TxtTelemovel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_KeyPress);
				TxtTelemovel.TabIndex = 4;
				TxtTelemovel.MaxLength = 9;
				TxtTelemovel.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtTelemovel);

				Label LblLogin = new Label();
				LblLogin.AutoSize = true;
				LblLogin.Location = new System.Drawing.Point(51, 171);
				LblLogin.Name = "LblLogin";
				LblLogin.Size = new System.Drawing.Size(82, 13);
				LblLogin.TabIndex = 7;
				LblLogin.Text = "Username:";
				this.Controls.Add(LblLogin);

				TextBox TxtLogin = new TextBox();
				TxtLogin.Location = new System.Drawing.Point(156, 168);
				TxtLogin.Name = "TxtLoginFun";
				TxtLogin.Size = new System.Drawing.Size(135, 20);
				TxtLogin.TabIndex = 6; TxtLogin.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtLogin);

				Label LblPass = new Label();
				LblPass.AutoSize = true;
				LblPass.Location = new System.Drawing.Point(51, 214);
				LblPass.Name = "LblPass";
				LblPass.Size = new System.Drawing.Size(53, 13);
				LblPass.TabIndex = 9;
				LblPass.Text = "Password: ";
				this.Controls.Add(LblPass);

				TextBox TxtPass = new TextBox();
				TxtPass.Location = new System.Drawing.Point(156, 211);
				TxtPass.Name = "TxtPassFun";
				TxtPass.Size = new System.Drawing.Size(135, 20);
				TxtPass.TabIndex = 8; TxtPass.Leave += new System.EventHandler(txt_Leave);
				this.Controls.Add(TxtPass);

				Button BtnGuardar = new Button();
				BtnGuardar.Location = new System.Drawing.Point(22, 262);
				BtnGuardar.Name = "BtnGuardarNew";
				BtnGuardar.Size = new System.Drawing.Size(118, 48);
				BtnGuardar.TabIndex = 10;
				BtnGuardar.Text = "Criar Novo Funcionario";
				BtnGuardar.UseVisualStyleBackColor = true;
				BtnGuardar.Click += new System.EventHandler(button_Click);
				this.Controls.Add(BtnGuardar);

				Button BtnCancelar = new Button();
				BtnCancelar.Location = new System.Drawing.Point(198, 262);
				BtnCancelar.Name = "BtnCancelar";
				BtnCancelar.Size = new System.Drawing.Size(122, 48);
				BtnCancelar.TabIndex = 11;
				BtnCancelar.Text = "Cancelar";
				BtnCancelar.UseVisualStyleBackColor = true;
				BtnCancelar.Click += new System.EventHandler(button_Click);
				this.Controls.Add(BtnCancelar);
			}
		}

		private void txt_KeyPress(object sender, KeyPressEventArgs e)
		{
			TextBox Txt = sender as TextBox;

			if (Txt.Name == "TxtNifCli" || Txt.Name == "TxtTeleCli" || Txt.Name == "TxtTele" || Txt.Name == "TxtTelemovelFun")
			{
				if (e.KeyChar != '\b')
					e.Handled = !char.IsDigit(e.KeyChar);
			}
			else if (Txt.Name == "TxtCodCli")
			{
				if (e.KeyChar != '\b' && e.KeyChar != '-')
					e.Handled = !char.IsDigit(e.KeyChar);
			}
			else
			{
				if ((Txt.Name == "TxtNomeCli" && e.KeyChar != ' '))
					e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
			}
		}
	}
}
