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
	public partial class frmConsultarDetalhe : Form
	{
		List<ConsultarDetalhesEncomenda> lstConsultar = new List<ConsultarDetalhesEncomenda>();
		public frmConsultarDetalhe(int id)
		{
			InitializeComponent();
			this.Tag = id;
		}

		private void bgwInicio_DoWork(object sender, DoWorkEventArgs e)
		{
			lstConsultar = EncomendasEDetalhesEProduto.ConsultarDetalhesDaEncomenda(int.Parse(this.Tag.ToString()));
		}

		private void bgwInicio_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			lstConsultar.ToList().ForEach(item=>
			{
				Panel pnlDetalhes = new Panel();
				pnlDetalhes.BackColor = System.Drawing.SystemColors.ActiveCaption;
				pnlDetalhes.Dock = System.Windows.Forms.DockStyle.Top;
				pnlDetalhes.Location = new System.Drawing.Point(0, 0);
				pnlDetalhes.Margin = new System.Windows.Forms.Padding(0);
				pnlDetalhes.Name = "pnlDetalhes";
				pnlDetalhes.Size = new System.Drawing.Size(799, 77);
				pnlDetalhes.TabIndex = 0;

				Label lblCli = new Label();
				lblCli.AutoSize = true;
				lblCli.Location = new System.Drawing.Point(23, 28);
				lblCli.Name = "lblCli";
				lblCli.Size = new System.Drawing.Size(35, 13);
				lblCli.TabIndex = 0;
				lblCli.Text = ""+item.NomeCliente;

				PictureBox pctImagem = new PictureBox();
				pctImagem.Location = new System.Drawing.Point(705, 13);
				pctImagem.Name = "pctImagem";
				pctImagem.Size = new System.Drawing.Size(74, 50);
				pctImagem.TabIndex = 1;
				pctImagem.TabStop = false;
				pctImagem.Image = item.Icon;
				pctImagem.SizeMode = PictureBoxSizeMode.Zoom;

				Label lblNomeProduto = new Label();
				lblNomeProduto.AutoSize = true;
				lblNomeProduto.Location = new System.Drawing.Point(302, 28);
				lblNomeProduto.Name = "lblNomeProduto";
				lblNomeProduto.Size = new System.Drawing.Size(35, 13);
				lblNomeProduto.TabIndex = 2;
				lblNomeProduto.Text = ""+item.NomeProduto;

				pnlDetalhes.Controls.Add(lblNomeProduto);
				pnlDetalhes.Controls.Add(pctImagem);
				pnlDetalhes.Controls.Add(lblCli);
				flowLayoutPanel1.Controls.Add(pnlDetalhes);
			});
			if (lstConsultar.Count == 0)
				this.Close();
		}

		private void frmConsultarDetalhe_Load(object sender, EventArgs e)
		{
			if (!bgwInicio.IsBusy)
				bgwInicio.RunWorkerAsync();
		}
	}
}
