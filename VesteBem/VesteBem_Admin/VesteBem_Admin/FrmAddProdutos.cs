using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VesteBem_Admin.Class;

namespace VesteBem_Admin
{
	public partial class frmAddChangeProdutos : Form
	{
		SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		SqlCommand command = new SqlCommand();
		int idProdutos = 0;
		public frmAddChangeProdutos(int idProduto)
		{
			InitializeComponent();
			if (idProduto != 0)
				idProdutos = idProduto;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

			OpenFileDialog ofd = new OpenFileDialog(); ofd.Multiselect = false; ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				txtIcon.Text = ofd.FileNames[0].ToString();
				pctImage.ImageLocation = ofd.FileName.ToString();

			}
		}

		private void FrmAddProdutos_Load(object sender, EventArgs e)
		{
			this.Location = Screen.AllScreens[(frmAdmin.ecra - 1)].WorkingArea.Location;
			this.CenterToScreen();
			this.ShowIcon = false;
			if (idProdutos != 0)
			{
				List<Produtos> LstProdutos = new List<Produtos>();
				LstProdutos = EncomendasEDetalhesEProduto.SelectCategoriaProdutos("");
				int index = LstProdutos.FindIndex(r => r.IdProduto == idProdutos);
				txtCat.Text = LstProdutos[index].CategoriaClass;
				txtEmpresa.Text = LstProdutos[index].NomedaEmpresa;
				pctImage.Image = LstProdutos[index].Icon;
				txtNome.Text = LstProdutos[index].Nome;
				txtSubCat.Text = LstProdutos[index].CategoriaSubClass;
				txtValor.Text = LstProdutos[index].Valor.ToString();
				var ds = LstProdutos[index].Sexo == "F" ? cboSexo.Text = "Feminino" : (LstProdutos[index].Sexo == "M" ? cboSexo.Text = "Masculino" : cboSexo.Text = "Indefenido");
				btnRegistar.Text = "Alterar os Dados";
				this.Text = "Alterar os Produtos";
			}
			else
				this.Text = "Adicionar Produtos";
		}

		private void btn_Click(object sender, EventArgs e)
		{
			if (btnRegistar.Text != "Alterar os Dados")
			{
				try
				{
					if (txtValor.Text != "" && txtNome.Text != "" && txtEmpresa.Text != "" && txtIcon.Text != "" && cboSexo.Text != "" && txtSubCat.Text != "" && txtCat.Text != "")
					{
						Produtos produtos = new Produtos();
						produtos.Nome = txtNome.Text;
						produtos.NomedaEmpresa = txtEmpresa.Text;
						produtos.Sexo = cboSexo.Text.Substring(0, 1);
						try
						{
							produtos.Valor = double.Parse(txtValor.Text);
						}
						catch
						{
							produtos.Valor = double.Parse(txtValor.Text.Replace(',', '.'));//Fiz isto por causa dos computadores da escola, ... problemas de formato do windows
						}
						produtos.CategoriaClass = txtCat.Text;
						produtos.CategoriaSubClass = txtSubCat.Text;
						produtos.CaminhoImg = txtIcon.Text;
						string dss = CreateProdutos.InsertProdutos(produtos);

						if (dss == "Correu bem")
						{
							txtCat.Text = null;
							txtIcon.Text = null;
							txtNome.Text = null;
							txtSubCat.Text = null;
							txtValor.Text = null;
							txtEmpresa.Text = null;
							cboSexo.Text = "";
							pctImage.Image = null; 
							icnNotificação.ShowBalloonTip(100,"Produto Registado", "O produto "+produtos.Nome+", foi registado com sucesso!", ToolTipIcon.None);
							this.Close();
						}

					}
					else
						icnNotificação.ShowBalloonTip(25, "Registe os dados", "Completes os campos todos!!", ToolTipIcon.Warning);
				}
				catch (Exception ex)
				{
					icnNotificação.ShowBalloonTip(25, "Error", ""+ex.Message+"", ToolTipIcon.Error);
				}
			}
			else
			{
				try
				{
					if (txtValor.Text != "" && txtNome.Text != "" && txtEmpresa.Text != "" && cboSexo.Text != "" && txtSubCat.Text != "" && txtCat.Text != "")
					{
						Produtos produtos = new Produtos();
						produtos.Nome = txtNome.Text;
						produtos.NomedaEmpresa = txtEmpresa.Text;
						produtos.Sexo = cboSexo.Text.Substring(0, 1);
						try
						{
							produtos.Valor = double.Parse(txtValor.Text);
						}
						catch
						{
							produtos.Valor = double.Parse(txtValor.Text.Replace(',', '.'));
						}
						produtos.CategoriaClass = txtCat.Text;
						produtos.CategoriaSubClass = txtSubCat.Text;
						produtos.CaminhoImg = txtIcon.Text;
						produtos.IdProduto = idProdutos;
							if (txtIcon.Text == "")
								produtos.Icon = pctImage.Image;
						string dss = EncomendasEDetalhesEProduto.AtualizarProdutos(produtos);

						if (dss == "sucesso")
						{
							this.Close();
							icnNotificação.ShowBalloonTip(25, "Registado com sucesso", "Produto modificado com sucesso", ToolTipIcon.None);							
						}

					}
				}
				catch (Exception ex)
				{
					icnNotificação.ShowBalloonTip(25, "Error", ""+ex.Message+"", ToolTipIcon.Error);
				}
			}
		}

		private void txtValor_Leave(object sender, EventArgs e)
		{
			if (!txtValor.Text.Contains('.') && txtValor.Text != "")
				txtValor.Text += ".00";
			if (txtValor.Text.Contains('-'))
				txtValor.Text = "";
			if (Regex.IsMatch(txtValor.Text, @"\.\d\d"))
			{
				string[] ds = txtValor.Text.Split('.');
				txtValor.Text = "" + ds[0] + "." + ds[1].Substring(0, 2);
			}

		}

		private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '.' && e.KeyChar != '\u0016' && e.KeyChar != '\b' && e.KeyChar != '\u0016' && e.KeyChar != '\u0003')
				e.Handled = !char.IsDigit(e.KeyChar);
		}

		private void txtCats_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '\u0016' && e.KeyChar != '\b' && e.KeyChar != ' ' && e.KeyChar != '\u0003' && e.KeyChar != '-')
				e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
		}

		private void FrmAddProdutos_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (idProdutos == 0)
			{
				FormCollection fc = Application.OpenForms;
				foreach (Form frm in fc)
					frm.WindowState = FormWindowState.Normal;
			}
		}
	}
}
