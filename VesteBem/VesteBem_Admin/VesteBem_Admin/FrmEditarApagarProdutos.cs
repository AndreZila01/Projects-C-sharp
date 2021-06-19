using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VesteBem_Admin.Class;

namespace VesteBem_Admin
{
	public partial class frmEditarApagarProdutos : Form
	{
		List<Produtos> LstProdutos = new List<Produtos>();
		List<string> LstCat = new List<string>();
		public frmEditarApagarProdutos()
		{
			InitializeComponent();
		}

		private void frmEditarApagarProdutos_Load(object sender, EventArgs e)
		{
			this.Location = Screen.AllScreens[(frmAdmin.ecra - 1)].WorkingArea.Location;
			this.CenterToScreen();
			this.ShowIcon = false;
			if (!bgwInicio.IsBusy)
				bgwInicio.RunWorkerAsync();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			LstProdutos = EncomendasEDetalhesEProduto.SelectCategoriaProdutos("");
			LstCat = EncomendasEDetalhesEProduto.SelectCategoria();

		}
		private void pctRemove_MouseEnter(object sender, EventArgs e)
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

		private void pctRemove_MouseLeave(object sender, EventArgs e)
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
		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			flwCentro.Controls.Clear();
			LstProdutos.ToList().ForEach(item =>
			{

				Panel Pnl = new Panel();
				Pnl.Dock = System.Windows.Forms.DockStyle.Top;
				Pnl.Location = new System.Drawing.Point(0, 0);
				Pnl.Margin = new System.Windows.Forms.Padding(0);
				Pnl.Name = "panel2";
				Pnl.Size = new System.Drawing.Size(800, 42);
				Pnl.TabIndex = 0;
				flwCentro.Controls.Add(Pnl);

				PictureBox PctRemove = new PictureBox();
				PctRemove.MouseLeave += new System.EventHandler(pctRemove_MouseLeave);
				PctRemove.MouseEnter += new System.EventHandler(pctRemove_MouseEnter);
				PctRemove.Click += new System.EventHandler(pct_Click);
				PctRemove.Image = global::VesteBem_Admin.Properties.Resources.Red_Remove;
				PctRemove.Location = new System.Drawing.Point(760, 6);
				PctRemove.Tag = item.IdProduto;
				PctRemove.Name = "PctRemove";
				PctRemove.Size = new System.Drawing.Size(35, 30);
				PctRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
				PctRemove.TabIndex = 1;
				PctRemove.TabStop = false;

				PictureBox PctEdit = new PictureBox();
				PctEdit.Image = global::VesteBem_Admin.Properties.Resources.Pencil;
				PctEdit.Click += new System.EventHandler(pct_Click);
				PctEdit.Location = new System.Drawing.Point(715, 6);
				PctEdit.Name = "PctEdit";
				PctEdit.Size = new System.Drawing.Size(35, 30);
				PctEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
				PctEdit.TabIndex = 0;
				PctEdit.Tag = item.IdProduto;
				PctEdit.TabStop = false;

				Label LblNomeProduto = new Label();
				LblNomeProduto.AutoSize = true;
				LblNomeProduto.Location = new System.Drawing.Point(13, 15);
				LblNomeProduto.Name = "LblNomeProduto";
				LblNomeProduto.Size = new System.Drawing.Size(86, 13);
				LblNomeProduto.TabIndex = 2;
				LblNomeProduto.Text = "" + item.Nome;

				Label LblCategoria = new Label();
				LblCategoria.AutoSize = true;
				LblCategoria.Location = new System.Drawing.Point(206, 15);
				LblCategoria.Name = "LblCategoria";
				LblCategoria.Size = new System.Drawing.Size(66, 13);
				LblCategoria.TabIndex = 3;
				LblCategoria.Text = "" + item.CategoriaClass;

				Label LblSubCategoria = new Label();
				LblSubCategoria.AutoSize = true;
				LblSubCategoria.Location = new System.Drawing.Point(383, 15);
				LblSubCategoria.Name = "LblSubCategoria";
				LblSubCategoria.Size = new System.Drawing.Size(85, 13);
				LblSubCategoria.TabIndex = 4;
				LblSubCategoria.Text = "" + item.CategoriaSubClass;

				Pnl.Controls.Add(LblSubCategoria);
				Pnl.Controls.Add(LblCategoria);
				Pnl.Controls.Add(LblNomeProduto);
				Pnl.Controls.Add(PctRemove);
				Pnl.Controls.Add(PctEdit);
			});

			cmbCategoria.Items.Clear();
			cmbCategoria.Items.Add("");
			LstCat.ToList().ForEach(item =>
			{
				cmbCategoria.Items.Add(item);
			});

			flwCentro.HorizontalScroll.Enabled = false;
			flwCentro.HorizontalScroll.Visible = false;
		}

		private void pct_Click(object sender, EventArgs e)
		{
			PictureBox Pct = sender as PictureBox;

			switch (Pct.Name)
			{
				case "PctEdit":
					frmAddChangeProdutos frm = new frmAddChangeProdutos(int.Parse(Pct.Tag.ToString()));
					frm.ShowDialog();
					break;
				case "PctRemove":
					string ds = EncomendasEDetalhesEProduto.DeleteProduto(int.Parse(Pct.Tag.ToString()));
					if (ds == "sucesso")
					{
						icnApagar.Visible = true;
						icnApagar.ShowBalloonTip(15, "Produto Apagado com Sucesso!!", "Conseguiu apagar o Produto com sucesso!!", ToolTipIcon.Info);
					}
					else
					{
						icnApagar.Visible = true;
						icnApagar.ShowBalloonTip(15, "Error ao apagar Produto!!", ""+ds, ToolTipIcon.Error);
					}
					break;
			}

			bgwInicio.RunWorkerAsync();
		}

		private void frmEditarApagarProdutos_FormClosed(object sender, FormClosedEventArgs e)
		{
			icnApagar.Visible = false;
			FormCollection fc = Application.OpenForms;
			foreach (Form frm in fc)
				frm.WindowState = FormWindowState.Normal;
		}

		private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			flwCentro.Controls.Clear();
			LstProdutos.ToList().ForEach(item =>
			{
				try
				{
					if (((item.CategoriaClass == cmbCategoria.Text) || (cmbCategoria.Text == "")) && ((item.Nome.Substring(0, txtNome.Text.Length) == txtNome.Text)))
					{
						Panel Pnl = new Panel();
						Pnl.Dock = System.Windows.Forms.DockStyle.Top;
						Pnl.Location = new System.Drawing.Point(0, 0);
						Pnl.Margin = new System.Windows.Forms.Padding(0);
						Pnl.Name = "panel2";
						Pnl.Size = new System.Drawing.Size(800, 42);
						Pnl.TabIndex = 0;
						flwCentro.Controls.Add(Pnl);

						PictureBox PctRemove = new PictureBox();
						PctRemove.MouseLeave += new System.EventHandler(pctRemove_MouseLeave);
						PctRemove.MouseEnter += new System.EventHandler(pctRemove_MouseEnter);
						PctRemove.Click += new System.EventHandler(pct_Click);
						PctRemove.Image = global::VesteBem_Admin.Properties.Resources.Red_Remove;
						PctRemove.Location = new System.Drawing.Point(760, 6);
						PctRemove.Tag = item.IdProduto;
						PctRemove.Name = "PctRemove";
						PctRemove.Size = new System.Drawing.Size(35, 30);
						PctRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
						PctRemove.TabIndex = 1;
						PctRemove.TabStop = false;

						PictureBox PctEdit = new PictureBox();
						PctEdit.Image = global::VesteBem_Admin.Properties.Resources.Pencil;
						PctEdit.Click += new System.EventHandler(pct_Click);
						PctEdit.Location = new System.Drawing.Point(715, 6);//705
						PctEdit.Name = "PctEdit";
						PctEdit.Size = new System.Drawing.Size(35, 30);
						PctEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						PctEdit.TabIndex = 0;
						PctEdit.Tag = item.IdProduto;
						PctEdit.TabStop = false;

						Label LblNomeProduto = new Label();
						LblNomeProduto.AutoSize = true;
						LblNomeProduto.Location = new System.Drawing.Point(13, 15);
						LblNomeProduto.Name = "LblNomeProduto";
						LblNomeProduto.Size = new System.Drawing.Size(86, 13);
						LblNomeProduto.TabIndex = 2;
						LblNomeProduto.Text = "" + item.Nome;

						Label LblCategoria = new Label();
						LblCategoria.AutoSize = true;
						LblCategoria.Location = new System.Drawing.Point(206, 15);
						LblCategoria.Name = "LblCategoria";
						LblCategoria.Size = new System.Drawing.Size(66, 13);
						LblCategoria.TabIndex = 3;
						LblCategoria.Text = "" + item.CategoriaClass;

						Label LblSubCategoria = new Label();
						LblSubCategoria.AutoSize = true;
						LblSubCategoria.Location = new System.Drawing.Point(383, 15);
						LblSubCategoria.Name = "LblSubCategoria";
						LblSubCategoria.Size = new System.Drawing.Size(85, 13);
						LblSubCategoria.TabIndex = 4;
						LblSubCategoria.Text = "" + item.CategoriaSubClass;

						Pnl.Controls.Add(LblSubCategoria);
						Pnl.Controls.Add(LblCategoria);
						Pnl.Controls.Add(LblNomeProduto);
						Pnl.Controls.Add(PctRemove);
						Pnl.Controls.Add(PctEdit);
					}
				}
				catch
				{

				}
			});
		}

		private void comboBox1_TextChanged(object sender, EventArgs e)
		{
			if (!bgwModificar.IsBusy)
				bgwModificar.RunWorkerAsync();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (!bgwModificar.IsBusy)
				bgwModificar.RunWorkerAsync();
		}
	}
}
