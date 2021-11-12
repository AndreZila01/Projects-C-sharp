using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VesteBem_Admin.Class;

namespace VesteBem_Admin
{
	public partial class frmCarrinho : Form
	{
		public frmCarrinho()
		{
			InitializeComponent();
		}
		List<Estados> lstEstado = new List<Estados>();
		List<DetalhesEncomendas> lstDetalhesEncomendas = new List<DetalhesEncomendas>();
		List<Cliente> lstcli = new List<Cliente>();
		List<Produtos> lstProduto = new List<Produtos>();
		private void FrmCarrinho_Load(object sender, EventArgs e)
		{
			this.Location = Screen.AllScreens[(frmAdmin.ecra - 1)].WorkingArea.Location;
			this.CenterToScreen();
			this.ShowIcon = false;
			cboEstado.Text = "Pendente";
			cboEstado.Items.Add("Pendente");
			if (!bgwInicio.IsBusy)
				bgwInicio.RunWorkerAsync();
		}
		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void PctRemove_MouseEnter(object sender, EventArgs e)
		{
			PictureBox Pct = sender as PictureBox;
			try
			{
				Pct.Image = Properties.Resources.White_Remove;
			}
			catch
			{

			}
		}

		private void PctRemove_MouseLeave(object sender, EventArgs e)
		{
			PictureBox Pct = sender as PictureBox;
			try
			{
				Pct.Image = Properties.Resources.Red_Remove;
			}
			catch
			{

			}
		}

		private void PctRemove_Click(object sender, EventArgs e)
		{
			PictureBox Pct = sender as PictureBox;
			int value = 0;
			flpProdutos.Controls.Clear();
			if (Pct.Name == "Remove")
				lstDetalhesEncomendas.Remove(lstDetalhesEncomendas[int.Parse(Pct.Tag.ToString())]); lblTotal.Tag = "00";
			lstDetalhesEncomendas.ToList().ForEach(item =>
			{
				#region ds
				int index = lstProduto.FindIndex(r => r.IdProduto == item.Id_Produtos);
				DetalhesEncomendas Detalhes = new DetalhesEncomendas();
				Panel pnl = new Panel();
				pnl.Location = new System.Drawing.Point(0, 0);
				pnl.Name = "panel1";
				pnl.Size = new System.Drawing.Size(245, 30);//271; 150
				pnl.TabIndex = 0;
				flpProdutos.Controls.Add(pnl);

				Label LblNome = new Label();
				LblNome.AutoSize = true;
				LblNome.Location = new System.Drawing.Point(5, 10);
				LblNome.Name = "label6";
				LblNome.Size = new System.Drawing.Size(35, 13);
				LblNome.TabIndex = 0;
				LblNome.Tag = pctEncomenda.Tag.ToString();
				var ds = lstProduto[index].Nome.Length > 20 ? LblNome.Text = "" + lstProduto[index].Nome.Substring(0, 20) : LblNome.Text = "" + lstProduto[index].Nome;
				LblNome.Click += new System.EventHandler(label_Click);
				pnl.Controls.Add(LblNome);

				Label LblPreco = new Label();
				LblPreco.AutoSize = true;
				LblPreco.Location = new System.Drawing.Point(175, 10);
				LblPreco.Name = "label7";
				LblPreco.Size = new System.Drawing.Size(25, 13);
				LblPreco.TabIndex = 1;
				LblPreco.Text = "" + lstProduto[index].Valor + "€";
				LblPreco.Tag = "" + lstProduto[index].Valor;
				pnl.Controls.Add(LblPreco);

				Label LblQuantidade = new Label();
				LblQuantidade.Location = new System.Drawing.Point(135, 10);
				LblQuantidade.Name = "label7";
				LblQuantidade.Size = new System.Drawing.Size(35, 13);
				LblQuantidade.TabIndex = 1;
				LblQuantidade.Text = " " + item.QuantEnc + " x";
				LblQuantidade.Tag = "" + item.QuantEnc;
				pnl.Controls.Add(LblQuantidade);

				PictureBox PctRemove = new PictureBox();
				PctRemove.Image = Properties.Resources.Red_Remove;
				PctRemove.Location = new System.Drawing.Point(225, 10);
				PctRemove.Size = new System.Drawing.Size(15, 13);
				PctRemove.Name = "Remove";
				PctRemove.SizeMode = PictureBoxSizeMode.Zoom;
				PctRemove.Click += new System.EventHandler(PctRemove_Click);
				PctRemove.MouseLeave += new System.EventHandler(PctRemove_MouseLeave);
				PctRemove.MouseEnter += new System.EventHandler(PctRemove_MouseEnter);
				PctRemove.Tag = "" + value;
				pnl.Controls.Add(PctRemove);

				lblTotal.Tag = "" + (double.Parse(lblTotal.Tag.ToString()) + ((item.QuantEnc * lstProduto[index].Valor)));
				lblTotal.Text = "Total: " + lblTotal.Tag + "€";
				value++;
				#endregion
			});
			if (lstDetalhesEncomendas.Count == 0)
			{
				lblTotal.Tag = "0";
				lblTotal.Text = "Total: " + lblTotal.Tag + "€";
			}
		}

		private void label_Click(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			MessageBox.Show("" + lstProduto[int.Parse(lbl.Tag.ToString())].Nome);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				Encomenda enc = new Encomenda();
				enc.EstadoEncomendas = cboEstado.Text;
				enc.Id_Cliente = Clientes.SelectIdCliente(cboCliente.Text);
				enc.ValorEncomendas = double.Parse(txtValor.Text);
				enc.DataEncomenda = dtpEntrega.Value;
				EncomendasEDetalhesEProduto.InsertEncomendas(enc, 1);
				enc.IdEncomendas = EncomendasEDetalhesEProduto.SelectIdEncomenda(enc.ValorEncomendas, enc.Id_Cliente, enc.DataEncomenda, lstEstado[lstEstado.FindIndex(p => p.Estado == enc.EstadoEncomendas)].IdEstado);
				int temp = 0;
				lstDetalhesEncomendas.ToList().ForEach(item =>
				{
					lstDetalhesEncomendas[temp].Id_Encomendas = enc.IdEncomendas;
					temp++;
				});
				EncomendasEDetalhesEProduto.InsertDetalhes(lstDetalhesEncomendas);
				lstDetalhesEncomendas.Clear();
				pnlRegistar.Enabled = false;
				txtValor.Text = "";
				cboCliente.Text = "";
				flpProdutos.Controls.Clear();
				icnNotificacao.ShowBalloonTip(15, "Error Login", "Faça Login, no site!!!", ToolTipIcon.Info);
			}
			catch(Exception ex)
			{
				icnNotificacao.ShowBalloonTip(15, "Error Login", "Error: "+ex, ToolTipIcon.Error);
			}
		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			pctEncomenda.Image = lstProduto[cmbProduto.SelectedIndex].Icon;
			pctEncomenda.Tag = cmbProduto.SelectedIndex;
		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			//int count = 0;
			List<int> lstIdProduto = new List<int>();
			List<int> lstId = new List<int>();
			List<DetalhesEncomendas> lst = new List<DetalhesEncomendas>();
			Encomenda enc = new Encomenda();
			enc.ValorEncomendas = double.Parse(lblTotal.Tag.ToString());
			int ds = 0;
			List<DetalhesEncomendas> indexT = new List<DetalhesEncomendas>();//new int[lstDetalhesEncomendas.Count()];

			lstDetalhesEncomendas.ToList().ForEach(item =>
			{
				DetalhesEncomendas Pre = new DetalhesEncomendas();
				Pre.Id_Produtos = item.Id_Produtos;
				Pre.QuantEnc = item.QuantEnc;
				Pre.Id_Encomendas = ds;
				lst.Add(Pre);
				ds++;
			});

			lst.ToList().ForEach(item =>
			{
				#region Rascunho 
				//var index = lstDetalhesEncomendas.IndexOf(lst);
				//int indexT = listEmployee.FindIndex(r >= r.Name == findName);
				//int [] dsssssss = lstDetalhesEncomendas.FindAll(""+item.IdProduto);
				#endregion

				int index = 0;
				int quant = 0;

				var count = lstDetalhesEncomendas.Count(s => (s.Id_Produtos == item.Id_Produtos));
				if (count > 1)
				{
					#region Rascunho 
					//lstDetalhesEncomendas.ToList().ForEach(itemss =>
					//{
					//	if (item.Id_Produtos == itemss.Id_Produtos)
					//	{
					//		DetalhesEncomendas detalhes = new DetalhesEncomendas();
					//		detalhes.Id_Encomendas = itemss.Id_Encomendas;
					//		detalhes.QuantEnc = item.QuantEnc;
					//		indexT.Add(detalhes);//indexT[index] = item.QuantEnc;
					//	}
					//	index++;
					//});
					//indexT.ToList().ForEach(items =>
					//{
					//	var dss = indexT[indexT.LastIndexOf(items)];
					//	quant += items;
					//});
					#endregion
					index = 0;
					lstDetalhesEncomendas.ToList().ForEach(itemss =>
					{
						if (item.Id_Produtos == itemss.Id_Produtos)
						{

							//lstDetalhesEncomendas.ToList().ForEach(itemsss =>
							//{
							//	if (item.IdProduto == itemsss.Id_Produtos)
							//	{
							DetalhesEncomendas detalhes = itemss;
							count = lstDetalhesEncomendas.Count(s => (s.Id_Produtos == item.Id_Produtos));
							if (lstDetalhesEncomendas.Count > 1 && (count > 1) && !((lst[lstDetalhesEncomendas.Count() - 1].Id_Encomendas == itemss.Id_Encomendas && lst[lstDetalhesEncomendas.Count() - 1].Id_Produtos == itemss.Id_Produtos)))
							{
								quant += itemss.QuantEnc;
								lstDetalhesEncomendas.Remove(detalhes);
								int test = lstDetalhesEncomendas.FindIndex(ash => ash.Id_Produtos == (itemss.Id_Produtos));//lstDetalhesEncomendas.IndexOf(lst.Where(p => p.Id_Encomendas == itemss.Id_Encomendas).FirstOrDefault());
								lstDetalhesEncomendas[test].QuantEnc += quant;
							}
							index++;
							//Verificar se é o ultimo index da lista, se for não apagar o valor

							//indexT.Add(item.QuantEnc);//indexT[index] = item.QuantEnc;
							//	}
							//});
						}
						//index++;
					});

					//lstDetalhesEncomendas
				}
				//count++;
			});
			//Encomenda obj = lstDetalhesEncomendas.Find(x => (x.Name == "product name"));
			//Certificar se o utilizador meteu varias vezes os produtos
			if (lstDetalhesEncomendas.Count() > 0)
			{
				txtValor.Text = lblTotal.Tag.ToString();
				cboEstado.SelectedItem = "Na Fabrica";
				txtValor.Enabled = false;
				pnlRegistar.Enabled = true;
			}
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			lblTotal.Tag = "00";
			lstEstado = Funcionarios.SelectEstado();
			lstEstado.ToList().ForEach(item =>
			{
				if (item.Estado == "Na Fabrica")
					cboEstado.Items.Add(item.Estado);
			});
			lstcli = Clientes.SelectId();
			lstcli.ToList().ForEach(item =>
			{
				cboCliente.Items.Add(item.Nome);
			});
			lstProduto = EncomendasEDetalhesEProduto.SelectProdutos();
			lstProduto.ToList().ForEach(item =>
			{
				cmbProduto.Items.Add(item.IdProduto + " - " + item.Nome);
			});

			pctRegistar.Click += PctRemove_Click;
			try
			{
				var ds = DateTime.Today.Month != 12 ? dtpEntrega.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day + 4) : dtpEntrega.Value = new DateTime((DateTime.Today.Year + 1), 1, 4);
			}
			catch
			{
				var ds = DateTime.Today.Month != 12 ? dtpEntrega.Value = new DateTime(DateTime.Today.Year, (DateTime.Today.Month + 1), 1) : dtpEntrega.Value = new DateTime((DateTime.Today.Year + 1), 1, 1);
			}
			try
			{
				var ds = DateTime.Today.Month != 12 ? dtpEntrega.MinDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day + 1) : dtpEntrega.MinDate = new DateTime((DateTime.Today.Year + 1), 1, 1);
			}
			catch
			{
				var ds = DateTime.Today.Month != 12 ? dtpEntrega.MinDate = new DateTime(DateTime.Today.Year, (DateTime.Today.Month + 1), 1) : dtpEntrega.MinDate = new DateTime((DateTime.Today.Year + 1), 1, 1);
			}
			int data; int mes = DateTime.Today.Month + 4;
			if (mes > 12)
				mes -= 12;
			if (mes != 2)
			{
				var temp = mes == 1 && mes == 3 && mes == 5 && mes == 7 && mes == 8 && mes == 9 && mes == 12 ? data = 31 : data = 30;
			}
			else
				if (DateTime.Today.Year % 400 == 0 || (DateTime.Today.Year % 4 == 0 && DateTime.Today.Year % 100 != 0))
				data = 29;
			else
				data = 28;


			dtpEntrega.MaxDate = new DateTime(DateTime.Today.Year, mes, data);
		}

		private void FrmCarrinho_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormCollection fc = Application.OpenForms;
			foreach (Form frm in fc)
				frm.WindowState = FormWindowState.Normal;
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			if (cmbProduto.Text != "")
				try
				{
					DetalhesEncomendas Detalhes = new DetalhesEncomendas();
					Panel pnl = new Panel();
					pnl.Location = new System.Drawing.Point(0, 0);
					pnl.Name = "panel1";
					pnl.Size = new System.Drawing.Size(245, 30);//271; 150
					pnl.TabIndex = 0;
					flpProdutos.Controls.Add(pnl);

					Label LblNome = new Label();
					LblNome.AutoSize = true;
					LblNome.Location = new System.Drawing.Point(5, 10);
					LblNome.Name = "label6";
					LblNome.Size = new System.Drawing.Size(35, 13);
					LblNome.TabIndex = 0;
					LblNome.Tag = pctEncomenda.Tag.ToString();
					var ds = lstProduto[int.Parse(pctEncomenda.Tag.ToString())].Nome.Length > 20 ? LblNome.Text = "" + lstProduto[int.Parse(pctEncomenda.Tag.ToString())].Nome.Substring(0, 20) : LblNome.Text = "" + lstProduto[int.Parse(pctEncomenda.Tag.ToString())].Nome;
					LblNome.Click += new System.EventHandler(label_Click);
					pnl.Controls.Add(LblNome);

					Label LblPreco = new Label();
					LblPreco.AutoSize = true;
					LblPreco.Location = new System.Drawing.Point(175, 10);
					LblPreco.Name = "label7";
					LblPreco.Size = new System.Drawing.Size(25, 13);
					LblPreco.TabIndex = 1;
					LblPreco.Text = "" + lstProduto[int.Parse(pctEncomenda.Tag.ToString())].Valor + "€";
					LblPreco.Tag = "" + lstProduto[int.Parse(pctEncomenda.Tag.ToString())].Valor;
					pnl.Controls.Add(LblPreco);

					Label LblQuantidade = new Label();
					LblQuantidade.Location = new System.Drawing.Point(135, 10);
					LblQuantidade.Name = "label7";
					LblQuantidade.Size = new System.Drawing.Size(35, 13);
					LblQuantidade.TabIndex = 1;
					LblQuantidade.TextAlign = ContentAlignment.MiddleLeft;
					LblQuantidade.Text = nudQuantidade.Value + " x";
					LblQuantidade.Tag = "" + nudQuantidade.Value;
					pnl.Controls.Add(LblQuantidade);

					PictureBox PctRemove = new PictureBox();
					PctRemove.Image = Properties.Resources.Red_Remove;
					PctRemove.Name = "Remove";
					PctRemove.Location = new System.Drawing.Point(225, 10);
					PctRemove.Size = new System.Drawing.Size(15, 13);
					PctRemove.SizeMode = PictureBoxSizeMode.Zoom;
					PctRemove.Click += new System.EventHandler(PctRemove_Click);
					PctRemove.MouseLeave += new System.EventHandler(PctRemove_MouseLeave);
					PctRemove.MouseEnter += new System.EventHandler(PctRemove_MouseEnter);
					PctRemove.Tag = "" + lstDetalhesEncomendas.Count();
					pnl.Controls.Add(PctRemove);

					lblTotal.Tag = "" + (double.Parse(lblTotal.Tag.ToString()) + ((int.Parse(LblQuantidade.Tag.ToString()) * double.Parse(LblPreco.Tag.ToString()))));
					lblTotal.Text = "Total: " + lblTotal.Tag + "€";

					Detalhes.Id_Encomendas = lstDetalhesEncomendas.Count();
					Detalhes.Id_Produtos = lstProduto[int.Parse(pctEncomenda.Tag.ToString())].IdProduto;
					Detalhes.QuantEnc = int.Parse(nudQuantidade.Value.ToString());
					lstDetalhesEncomendas.Add(Detalhes);
				}
				catch { }
		}
	}
}
