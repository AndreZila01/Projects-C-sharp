using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Forca
{
	public partial class lblAviso : Form
	{
		int ContadorCheckBoxes = 0, gf = 1, win = 0, c = 0;
		string resultado = "";
		bool ajuda = false;
		//Boolean Encontrou = false;
		bool wine = false, jogovsjogo = false;
		string dic;
		int NumLetras, d = 0, n = 0;


		private void LetraClick(object sender, EventArgs e)
		{
			var btn = (Button)sender;//var =variavel de qualquer tipo; (Button) sender = propriedades do objeto sender
									 //Boolean Encontrou = false;

			if (jogovsjogo == false)
			{
				NumLetras = resultado.Count();


				ajuda = false;

				for (c = 0; c <= arpALAVRA.Length - 1; c = c + 1)//length=comprimento, não preciso de ter um valor, completa consoante a palavra misterio 
				{


					if (arpALAVRA[c] == btn.Tag.ToString())//erro, porque está sempre a somar
					{
						btn.Enabled = false;

						//Encontrou = true;
						ajuda = true;
						//win = win + 1;

						if (0 == c)
						{
							label0.Text = btn.Tag.ToString();
						}
						if (1 == c)
						{
							label1.Text = btn.Tag.ToString();
						}
						if (2 == c)
						{
							label2.Text = btn.Tag.ToString();
						}
						if (3 == c)
						{
							label3.Text = btn.Tag.ToString();
						}
						if (4 == c)
						{
							label4.Text = btn.Tag.ToString();
						}
						if (5 == c)
						{
							label5.Text = btn.Tag.ToString();
						}
						if (6 == c)
						{
							label6.Text = btn.Tag.ToString();
						}
						if (7 == c)
						{
							label7.Text = btn.Tag.ToString();
						}
						if (8 == c)
						{
							label8.Text = btn.Tag.ToString();
						}
						if (9 == c)
						{
							label9.Text = btn.Tag.ToString();
						}
						if (10 == c)
						{
							label10.Text = btn.Tag.ToString();
						}
						if (11 == c)
						{
							label11.Text = btn.Tag.ToString();
						}
						if (12 == c)
						{
							label12.Text = btn.Tag.ToString();
						}
						if (13 == c)
						{
							label13.Text = btn.Tag.ToString();
						}
						if (14 == c)
						{
							label14.Text = btn.Tag.ToString();
						}
						if (15 == c)
						{
							label15.Text = btn.Tag.ToString();
						}
						if (16 == c)
						{
							label16.Text = btn.Tag.ToString();
						}

						d = d + 1;

						if (NumLetras == d)
						{
							wine = true;
							bloqueio();
						}
					}

				}

				if (ajuda == false)
				{
					picImagem.Visible = false;
					pictureBox1.Visible = true;

					btn.Enabled = false;

					if (gf == 1)
					{
						pictureBox1.Image = new Bitmap(Properties.Resources._1);
						gf = gf + 1;
					}
					else
					if (gf == 2)
					{
						pictureBox1.Image = new Bitmap(Properties.Resources._2);
						gf = gf + 1;
					}
					else
					if (gf == 3)
					{
						pictureBox1.Image = new Bitmap(Properties.Resources._3);
						gf = gf + 1;
					}
					else
					if (gf == 4)
					{
						pictureBox1.Image = new Bitmap(Properties.Resources._4);
						gf = gf + 1;
					}
					else
					if (gf == 5)
					{
						pictureBox1.Image = new Bitmap(Properties.Resources._5);
						gf = gf + 1;
					}
					else
					if (gf == 6)
					{
						pictureBox1.Image = new Bitmap(Properties.Resources._6);
						gf = gf + 1;
					}
					else
					if (gf == 7)
					{
						pictureBox1.Image = new Bitmap(Properties.Resources._7);
						gf = gf + 1;
					}
					else
					if (gf == 8)
					{
						pictureBox1.Image = new Bitmap(Properties.Resources._8);
						gf = gf + 1;
					}
					else
					if (gf == 9)
					{
						bloqueio();
					}
				}
			}

			if (jogovsjogo == true)
			{

				n = resultado.Count();
				ajuda = false;
				grp3letras.Visible = true;
				if (n == 3)
				{
					//lbl4 para lbl19
					label0.Visible = true;
					label1.Visible = true;
					label2.Visible = true;
				}
				if (n == 4)
				{
					label0.Visible = true;
					label1.Visible = true;
					label2.Visible = true;
					label3.Visible = true;
				}
				if (n == 5)
				{
					label0.Visible = true;
					label1.Visible = true;
					label2.Visible = true;
					label3.Visible = true;
					label4.Visible = true;
				}
				if (n == 6)
				{
					label0.Visible = true;
					label1.Visible = true;
					label2.Visible = true;
					label3.Visible = true;
					label4.Visible = true;
					label5.Visible = true;
				}
				if (n == 7)
				{
					label0.Visible = true;
					label1.Visible = true;
					label2.Visible = true;
					label3.Visible = true;
					label4.Visible = true;
					label5.Visible = true;
					label6.Visible = true;
				}
				if (n == 8)
				{
					label0.Visible = true;
					label1.Visible = true;
					label2.Visible = true;
					label3.Visible = true;
					label4.Visible = true;
					label5.Visible = true;
					label6.Visible = true;
					label7.Visible = true;
				}
				if (n == 9)
				{
					label0.Visible = true;
					label1.Visible = true;
					label2.Visible = true;
					label3.Visible = true;
					label4.Visible = true;
					label5.Visible = true;
					label6.Visible = true;
					label7.Visible = true;
					label8.Visible = true;
				}
				if (n == 10)
				{
					label0.Visible = true;
					label1.Visible = true;
					label2.Visible = true;
					label3.Visible = true;
					label4.Visible = true;
					label5.Visible = true;
					label6.Visible = true;
					label7.Visible = true;
					label8.Visible = true;
					label9.Visible = true;
				}
				if (n == 11)
				{
					label0.Visible = true;
					label1.Visible = true;
					label2.Visible = true;
					label3.Visible = true;
					label4.Visible = true;
					label5.Visible = true;
					label6.Visible = true;
					label7.Visible = true;
					label8.Visible = true;
					label9.Visible = true;
					label10.Visible = true;
				}
				if (n == 12)
				{
					label0.Visible = true;
					label1.Visible = true;
					label2.Visible = true;
					label3.Visible = true;
					label4.Visible = true;
					label5.Visible = true;
					label6.Visible = true;
					label7.Visible = true;
					label8.Visible = true;
					label9.Visible = true;
					label10.Visible = true;
					label11.Visible = true;
				}
				if (n == 13)
				{
					label0.Visible = true;
					label1.Visible = true;
					label2.Visible = true;
					label3.Visible = true;
					label4.Visible = true;
					label5.Visible = true;
					label6.Visible = true;
					label7.Visible = true;
					label8.Visible = true;
					label9.Visible = true;
					label10.Visible = true;
					label11.Visible = true;
					label12.Visible = true;
				}
				if (n == 14)
				{
					label0.Visible = true;
					label1.Visible = true;
					label2.Visible = true;
					label3.Visible = true;
					label4.Visible = true;
					label5.Visible = true;
					label6.Visible = true;
					label7.Visible = true;
					label8.Visible = true;
					label9.Visible = true;
					label10.Visible = true;
					label11.Visible = true;
					label12.Visible = true;
					label13.Visible = true;
				}
				if (n == 15)
				{
					label0.Visible = true;
					label1.Visible = true;
					label2.Visible = true;
					label3.Visible = true;
					label4.Visible = true;
					label5.Visible = true;
					label6.Visible = true;
					label7.Visible = true;
					label8.Visible = true;
					label9.Visible = true;
					label10.Visible = true;
					label11.Visible = true;
					label12.Visible = true;
					label13.Visible = true;
					label14.Visible = true;
				}
				if (n == 16)
				{
					label0.Visible = true;
					label1.Visible = true;
					label2.Visible = true;
					label3.Visible = true;
					label4.Visible = true;
					label5.Visible = true;
					label6.Visible = true;
					label7.Visible = true;
					label8.Visible = true;
					label9.Visible = true;
					label10.Visible = true;
					label11.Visible = true;
					label12.Visible = true;
					label13.Visible = true;
					label14.Visible = true;
					label15.Visible = true;
				}

				for (c = 0; c <= arpALAVRAVS.Length - 1; c = c + 1)//length=comprimento, não preciso de ter um valor, completa consoante a palavra misterio 
				{
					btn = (Button)sender;

					if (arpALAVRAVS[c] == btn.Tag.ToString())//erro, porque está sempre a somar!!!
					{
						btn.Enabled = false;

						//Encontrou = true;
						ajuda = true;
						win = win + 1;

						if (0 == c)
						{
							label0.Text = btn.Tag.ToString();
						}
						if (1 == c)
						{
							label1.Text = btn.Tag.ToString();
						}
						if (2 == c)
						{
							label2.Text = btn.Tag.ToString();
						}
						if (3 == c)
						{
							label3.Text = btn.Tag.ToString();
						}
						if (4 == c)
						{
							label4.Text = btn.Tag.ToString();
						}
						if (5 == c)
						{
							label5.Text = btn.Tag.ToString();
						}
						if (6 == c)
						{
							label6.Text = btn.Tag.ToString();
						}
						if (7 == c)
						{
							label7.Text = btn.Tag.ToString();
						}
						if (8 == c)
						{
							label8.Text = btn.Tag.ToString();
						}
						if (9 == c)
						{
							label9.Text = btn.Tag.ToString();
						}
						if (10 == c)
						{
							label10.Text = btn.Tag.ToString();
						}
						if (11 == c)
						{
							label11.Text = btn.Tag.ToString();
						}
						if (12 == c)
						{
							label12.Text = btn.Tag.ToString();
						}
						if (13 == c)
						{
							label13.Text = btn.Tag.ToString();
						}
						if (14 == c)
						{
							label14.Text = btn.Tag.ToString();
						}
						if (15 == c)
						{
							label15.Text = btn.Tag.ToString();
						}
						if (16 == c)
						{
							label16.Text = btn.Tag.ToString();
						}

						d = d + 1;

						if (n == d)
						{
							wine = true;
							bloqueio();
						}


					}

				}

				if (ajuda == false)
				{
					picImagem.Visible = false;
					pictureBox1.Visible = true;

					btn.Enabled = false;

					if (gf == 1)
					{
						pictureBox1.Visible = true;
						pictureBox1.Image = new Bitmap(Properties.Resources._1);
						gf = gf + 1;
					}
					else
					if (gf == 2)
					{
						pictureBox1.Image = new Bitmap(Properties.Resources._2);
						gf = gf + 1;
					}
					else
					if (gf == 3)
					{
						pictureBox1.Image = new Bitmap(Properties.Resources._3);
						gf = gf + 1;
					}
					else
					if (gf == 4)
					{
						pictureBox1.Image = new Bitmap(Properties.Resources._4);
						gf = gf + 1;
					}
					else
					if (gf == 5)
					{
						pictureBox1.Image = new Bitmap(Properties.Resources._5);
						gf = gf + 1;
					}
					else
					if (gf == 6)
					{
						pictureBox1.Image = new Bitmap(Properties.Resources._6);
						gf = gf + 1;
					}
					else
					if (gf == 7)
					{
						pictureBox1.Image = new Bitmap(Properties.Resources._7);
						gf = gf + 1;
					}
					else
					if (gf == 8)
					{
						pictureBox1.Image = new Bitmap(Properties.Resources._8);
						gf = gf + 1;
					}
					else
					if (gf == 9)
					{
						bloqueio();
					}
				}

			}
		}

		private void bloqueio()
		{
			picImagem.Visible = false;
			pictureBox1.Visible = false;
			grp3letras.Visible = false;
			grpTeclado.Visible = false;
			lbl20.Visible = false;
			lbl21.Visible = false;
			lbl24.Visible = false;
			lblDica.Visible = false;
			Dica.Visible = false;

			if (gf == 9 && ajuda == false)
			{
				lblGame.Visible = true;
			}
			if (wine == true && gf < 9)
			{
				lblwin.Visible = true;
			}

		}

		private void Label4_Click(object sender, EventArgs e)
		{

		}

		private void Grp3letras_Enter(object sender, EventArgs e)
		{

		}

		private void jg2()
		{

		}

		string[] Dicas = new string[18];

		private void BtnIniciar_Click(object sender, EventArgs e)
		{


		}


		string[] arpALAVRA;
		string[] arpALAVRAVS;

		private void Label3_Click(object sender, EventArgs e)
		{

		}

		public lblAviso()
		{
			InitializeComponent();
		}

		private void JogadorVSComputadorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnStart1.Visible = true;
			lbl20.Visible = false;
			grpTeclado.Visible = false;
			grp3letras.Visible = false;
			lbl20.Visible = true;

			picImagem.Visible = true;
			pictureBox1.Visible = false;
			lbl21.Visible = true;
			lblGame.Visible = false;
			lblwin.Visible = false;
			label0.Text = "_";
			label1.Text = "_";
			label2.Text = "_";
			label3.Text = "_";
			label4.Text = "_";
			label5.Text = "_";
			label6.Text = "_";
			label7.Text = "_";
			label8.Text = "_";
			label9.Text = "_";
			label10.Text = "_";
			label11.Text = "_";
			label12.Text = "_";
			label13.Text = "_";
			label14.Text = "_";
			label15.Text = "_";
			label16.Text = "_";
		}

		private void BtnStart2_Click(object sender, EventArgs e)
		{
			lbl20.Visible = false;
		}

		private void valor()
		{

			if (chkProfissões.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "Profissões";
			}

			if (chkFruta.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "Frutas";
			}

			if (chkAnimais.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "Animais";
			}

			if (chkPaíses.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "Países";
			}

			if (chkJogos.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "Jogos";
			}

			if (chkNomes.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "Nomes";
			}

			if (chkMarcasdeRoupa.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "MarcasDeRoupa";
			}

			if (chkFilmes.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "Filmes";
			}

			if (chkPokemon.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "Pokemon";
			}

			if (chkMarcasdeCarros.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "MarcasDeCarros";
			}

			if (chkClubes.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "Clubes";
			}

			if (chkDesporto.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "Desporto";
			}

			if (chkFlores.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "Flores";
			}

			if (chkMarcasdeTelemovel.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "MarcasDeTelemovel";
			}

			if (chkCanaisdeTV.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "CanaisDeTV";
			}

			if (chkBandasFamosas.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "BandasFamosas";
			}

			if (chkMusicas.Checked)
			{
				ContadorCheckBoxes++;
				Dicas[ContadorCheckBoxes] = "Musicas";
			}

			do
			{

				//Random r = new Random();
				int i = new Random().Next(1, ContadorCheckBoxes);
				//r = new Random().Next();

				lblDica.Text = Dicas[i];

			} while (lblDica.Text == "");

		}

		private void palavra(object sender, EventArgs e)
		{
			var btn = (Button)sender;//var =variavel de qualquer tipo; (Button) sender = propriedades do objeto sender
			Random r = new Random();
			int i = r.Next(1, 20);

			if (lblDica.Text == "Profissões")
			{

				if (i == 1)
				{
					resultado = "PROFESSOR";
				}
				if (i == 2)
				{
					resultado = "JORNALISTA";
				}
				if (i == 3)
				{
					resultado = "INFORMATICO";
				}
				if (i == 4)
				{
					resultado = "TALHANTE";
				}
				if (i == 5)
				{
					resultado = "PEIXEIRO";
				}
				if (i == 6)
				{
					resultado = "PASTELEIRO";
				}
				if (i == 7)
				{
					resultado = "ACTOR";
				}
				if (i == 8)
				{
					resultado = "MAQUENISTA";
				}
				if (i == 9)
				{
					resultado = "PSICOLOGO";
				}
				if (i == 10)
				{
					resultado = "COMEDIANTE";
				}
				if (i == 11)
				{
					resultado = "COZINHEIRO";
				}
				if (i == 12)
				{
					resultado = "GERENTE-DE-BANCO";//8,
					label8.Text = "-";
					label11.Text = "-";
				}
				if (i == 13)
				{
					resultado = "MEDICO";
				}
				if (i == 14)
				{
					resultado = "AGRICULTOR";
				}
				if (i == 15)
				{
					resultado = "BIOLOGO";
				}
				if (i == 16)
				{
					resultado = "CARTEIRO";
				}
				if (i == 17)
				{
					resultado = "AVIADOR";
				}
				if (i == 18)
				{
					resultado = "DENTISTA";
				}
				if (i == 19)
				{
					resultado = "MODELO";
				}
				if (i == 20)
				{
					resultado = "TRADUTOR";
				}
			}

			if (lblDica.Text == "Frutas")
			{

				if (i == 1)
				{
					resultado = "BANANA";
				}
				if (i == 2)
				{
					resultado = "KIWI";
				}
				if (i == 3)
				{
					resultado = "PERA";
				}
				if (i == 4)
				{
					resultado = "MAÇA";
				}
				if (i == 5)
				{
					resultado = "LARANJA";
				}
				if (i == 6)
				{
					resultado = "TANGERINA";
				}
				if (i == 7)
				{
					resultado = "UVAS";
				}
				if (i == 8)
				{
					resultado = "MAMAO";
				}
				if (i == 9)
				{
					resultado = "MELAO";
				}
				if (i == 10)
				{
					resultado = "MELOA";
				}
				if (i == 11)
				{
					resultado = "MARACUJA";
				}
				if (i == 12)
				{
					resultado = "ROMA";
				}
				if (i == 13)
				{
					resultado = "PESSEGO";
				}
				if (i == 14)
				{
					resultado = "FIGO";
				}
				if (i == 15)
				{
					resultado = "AMEIXA";
				}
				if (i == 16)
				{
					resultado = "MELANCIA";
				}
				if (i == 17)
				{
					resultado = "MORANGOS";
				}
				if (i == 18)
				{
					resultado = "ALPERSES";
				}
				if (i == 19)
				{
					resultado = "ANANAS";
				}
				if (i == 20)
				{
					resultado = "MANGA";
				}
			}

			if (lblDica.Text == "Nomes")
			{

				if (i == 1)
				{
					resultado = "ANDRE";
				}
				if (i == 2)
				{
					resultado = "DIONISIO";
				}
				if (i == 3)
				{
					resultado = "MIGUEL";
				}
				if (i == 4)
				{
					resultado = "MARIO";
				}
				if (i == 5)
				{
					resultado = "ISABEL";
				}
				if (i == 6)
				{
					resultado = "DANIELA";
				}
				if (i == 7)
				{
					resultado = "ANTONIO";
				}
				if (i == 8)
				{
					resultado = "PEDRO";
				}
				if (i == 9)
				{
					resultado = "DANIEL";
				}
				if (i == 10)
				{
					resultado = "MATILDE";
				}
				if (i == 11)
				{
					resultado = "CRISTINA";
				}
				if (i == 12)
				{
					resultado = "MANUELA";
				}
				if (i == 13)
				{
					resultado = "GUSTAVO";
				}
				if (i == 14)
				{
					resultado = "JOANA";
				}
				if (i == 15)
				{
					resultado = "SALVADOR";
				}
				if (i == 16)
				{
					resultado = "TIAGO";
				}
				if (i == 17)
				{
					resultado = "CLAUDIA";
				}
				if (i == 18)
				{
					resultado = "DIANA";
				}
				if (i == 19)
				{
					resultado = "MARIA";
				}
				if (i == 20)
				{
					resultado = "CONCEIÇÃO";
				}

			}

			if (lblDica.Text == "Animais")
			{

				if (i == 1)
				{
					resultado = "GATO";
				}
				if (i == 2)
				{
					resultado = "CAO";
				}
				if (i == 3)
				{
					resultado = "PASSARO";
				}
				if (i == 4)
				{
					resultado = "GOLFINHO";
				}
				if (i == 5)
				{
					resultado = "LEAO";
				}
				if (i == 6)
				{
					resultado = "PEIXE";
				}
				if (i == 7)
				{
					resultado = "TIGRE";
				}
				if (i == 8)
				{
					resultado = "ELEFANTE";
				}
				if (i == 9)
				{
					resultado = "CORCODILO";
				}
				if (i == 10)
				{
					resultado = "TARTARUGA";
				}
				if (i == 11)
				{
					resultado = "LAMA";
				}
				if (i == 12)
				{
					resultado = "VACA";
				}
				if (i == 13)
				{
					resultado = "OVELHA";
				}
				if (i == 14)
				{
					resultado = "COELHO";
				}
				if (i == 15)
				{
					resultado = "GIRAFA";
				}
				if (i == 16)
				{
					resultado = "ZEBRA";
				}
				if (i == 17)
				{
					resultado = "COBRA";
				}
				if (i == 18)
				{
					resultado = "TUBARAO";
				}
				if (i == 19)
				{
					resultado = "CAMARAO";
				}
				if (i == 20)
				{
					resultado = "ESQUILO";
				}
			}

			if (lblDica.Text == "Países")
			{

				if (i == 1)
				{
					resultado = "PORTUGAL";
				}
				if (i == 2)
				{
					resultado = "FRANÇA";
				}
				if (i == 3)
				{
					resultado = "INGLATERRA";
				}
				if (i == 4)
				{
					resultado = "ALEMANHA";
				}
				if (i == 5)
				{
					resultado = "RUSSIA";
				}
				if (i == 6)
				{
					resultado = "ANGOLA";
				}
				if (i == 7)
				{
					resultado = "MOCAMBIQUE";
				}
				if (i == 8)
				{
					resultado = "BRASIL";
				}
				if (i == 9)
				{
					resultado = "EUA";
				}
				if (i == 10)
				{
					resultado = "COLOMBIA";
				}
				if (i == 11)
				{
					resultado = "CANADA";
				}
				if (i == 12)
				{
					resultado = "MARROCOS";
				}
				if (i == 13)
				{
					resultado = "HUNGRIA";
				}
				if (i == 14)
				{
					resultado = "CROACIA";
				}
				if (i == 15)
				{
					resultado = "GIRAFA";
				}
				if (i == 16)
				{
					resultado = "IRLANDA";
				}
				if (i == 17)
				{
					resultado = "BARBADOS";
				}
				if (i == 18)
				{
					resultado = "PANAMA";
				}
				if (i == 19)
				{
					resultado = "FILIPINAS";
				}
				if (i == 20)
				{
					resultado = "ITALIA";
				}
			}

			if (lblDica.Text == "Jogos")
			{
				if (i == 1)
				{
					resultado = "LEAGUE OF LEGENDS";

					label7.Text = " ";
					label10.Text = " ";
				}
				if (i == 2)
				{
					resultado = "COUNTER-STRIKE";

					label8.Text = "-";
				}
				if (i == 3)
				{
					resultado = "FORTNITE";
				}
				if (i == 4)
				{
					resultado = "HEARTHSTONE";
				}
				if (i == 5)
				{
					resultado = "MINECRAFT";
				}
				if (i == 6)
				{
					resultado = "BATTLEGROUDS";
				}
				if (i == 7)
				{
					resultado = "OVERWATCH";
				}
				if (i == 8)
				{
					resultado = "RAINBOW SIX";

					label8.Text = " ";
				}
				if (i == 9)
				{
					resultado = "WORLD OF WARCRAFT";

					label6.Text = " ";
					label9.Text = " ";

				}
				if (i == 10)
				{
					resultado = "GTA V";

					label4.Text = " ";
				}
				if (i == 11)
				{
					resultado = "WORLD OF TANKS";

					label6.Text = " ";
					label9.Text = " ";
				}
				if (i == 12)
				{
					resultado = "DOTA 2";
					label5.Text = " ";
					label6.Text = "2";
				}
				if (i == 13)
				{
					resultado = "GARRY’S MOD";
					label6.Text = "'";
					label8.Text = " ";
				}
				if (i == 14)
				{
					resultado = "ROCKET LEAGUE";
					label7.Text = " ";
				}
				if (i == 15)
				{
					resultado = "RING OF ELYSIUM";
					label5.Text = " ";
					label8.Text = " ";
				}
				if (i == 16)
				{
					resultado = "CALL OF DUTY";
					label5.Text = " ";
					label8.Text = " ";
				}
				if (i == 17)
				{
					resultado = "SUBNAUTICA";
				}
				if (i == 18)
				{
					resultado = "BATTLEFIELD V";
					label12.Text = " ";
				}
				if (i == 19)
				{
					resultado = "RUST";
				}
				if (i == 20)
				{
					resultado = "ARMA 3";
					label5.Text = " ";
					label6.Text = "3";
				}
			}

			if (lblDica.Text == "MarcasDeRoupa")
			{
				if (i == 1)
				{
					resultado = "NIKE";
				}
				if (i == 2)
				{
					resultado = "H&M";
					label1.Text = "&";
				}
				if (i == 3)
				{
					resultado = "ZARA";
				}
				if (i == 4)
				{
					resultado = "LOUIS VUITTON";
					label5.Text = " ";
				}
				if (i == 5)
				{
					resultado = "ADIDAS";
				}
				if (i == 6)
				{
					resultado = "ROLEX";
				}
				if (i == 7)
				{
					resultado = "UNIQLO";
				}
				if (i == 8)
				{
					resultado = "GUCCI";
				}
				if (i == 9)
				{
					resultado = "HERMES";
				}
				if (i == 10)
				{
					resultado = "CARTIER";
				}
			}

			if (lblDica.Text == "Pokemon")
			{
				if (i == 1)
				{
					resultado = "BULBASSAURO";
				}
				if (i == 2)
				{
					resultado = "MEWTWO";
				}
				if (i == 3)
				{
					resultado = "JIGGLYPUFF";
				}
				if (i == 4)
				{
					resultado = "ZUBAT";
				}
				if (i == 5)
				{
					resultado = "EXEGGUTOR";
				}
				if (i == 6)
				{
					resultado = "DITTO";
				}
				if (i == 7)
				{
					resultado = "PIKACHU";
				}
				if (i == 8)
				{
					resultado = "EEVEE";
				}
				if (i == 9)
				{
					resultado = "TOGEPI";
				}
				if (i == 10)
				{
					resultado = "SEEL";
				}
				if (i == 11)
				{
					resultado = "PIPLUP";
				}
				if (i == 12)
				{
					resultado = "ODDISH";
				}
				if (i == 13)
				{
					resultado = "COMFEY";
				}
				if (i == 14)
				{
					resultado = "COSMOG";
				}
				if (i == 15)
				{
					resultado = "SOLGALEO";
				}
				if (i == 16)
				{
					resultado = "NINETALES";
				}
				if (i == 17)
				{
					resultado = "COBALION";
				}
				if (i == 18)
				{
					resultado = "DEOXYS";
				}
				if (i == 19)
				{
					resultado = "MEW";
				}
				if (i == 20)
				{
					resultado = "KYOGRE";
				}
			}

			if (lblDica.Text == "MarcasDeCarros")
			{
				if (i == 1)
				{
					resultado = "INFINITI";
				}
				if (i == 2)
				{
					resultado = "HONDA";
				}
				if (i == 3)
				{
					resultado = "SUZUKI";
				}
				if (i == 4)
				{
					resultado = "SUBARU";
				}
				if (i == 5)
				{
					resultado = "JAGUAR";
				}
				if (i == 6)
				{
					resultado = "CHEVROLET";
				}
				if (i == 7)
				{
					resultado = "ACURA";
				}
				if (i == 8)
				{
					resultado = "MINI";
				}
				if (i == 9)
				{
					resultado = "FORD";
				}
				if (i == 10)
				{
					resultado = "PORSCHE";
				}
				if (i == 11)
				{
					resultado = "DODGE";
				}
				if (i == 12)
				{
					resultado = "JEEP";
				}
				if (i == 13)
				{
					resultado = "FIAT";
				}
				if (i == 14)
				{
					resultado = "TOYOTA";
				}
				if (i == 15)
				{
					resultado = "KIA";
				}
			}

			if (lblDica.Text == "Clubes")
			{
				if (i == 1)
				{
					resultado = "BENFICA";
				}
				if (i == 2)
				{
					resultado = "ARSENAL";
				}
				if (i == 3)
				{
					resultado = "BARCELONA";
				}
				if (i == 4)
				{
					resultado = "BAYERN MUNIQUE";
					label6.Text = " ";
				}
				if (i == 5)
				{
					resultado = "LIVERPOOL";
				}
				if (i == 6)
				{
					resultado = "AC MILIAN";
					label2.Text = " ";
				}
				if (i == 7)
				{
					resultado = "JUVENTUS";
				}
				if (i == 8)
				{
					resultado = "CHELSEA";
				}
			}

			if (lblDica.Text == "Desporto")
			{
				if (i == 1)
				{
					resultado = "BASQUETE";
				}
				if (i == 2)
				{
					resultado = "GOLFE";
				}
				if (i == 3)
				{
					resultado = "BEISEBOL";
				}
				if (i == 4)
				{
					resultado = "RUGBY";
				}
				if (i == 5)
				{
					resultado = "VOLEI";
				}
				if (i == 6)
				{
					resultado = "TENIS";
				}
				if (i == 7)
				{
					resultado = "CRIQUETE";
				}
				if (i == 8)
				{
					resultado = "FUTEBOL";
				}
			}

			if (lblDica.Text == "Flores")
			{
				if (i == 1)
				{
					resultado = "Dominica";
				}
				if (i == 2)
				{
					resultado = "Índico";
				}
				if (i == 3)
				{
					resultado = "Delicadeza";
				}
				if (i == 4)
				{
					resultado = "Provença";
				}
				if (i == 5)
				{
					resultado = "Sussurro";
				}




			}

			if (lblDica.Text == "MarcasDeTelemovel")
			{
				if (i == 1)
				{
					resultado = "WIKO";
				}
				if (i == 2)
				{
					resultado = "MICROSOFT";
				}
				if (i == 3)
				{
					resultado = "XIAOMI";
				}
				if (i == 4)
				{
					resultado = "MOTOROLA";
				}
				if (i == 5)
				{
					resultado = "HONOR";
				}
				if (i == 6)
				{
					resultado = "LG";
				}
				if (i == 7)
				{
					resultado = "NOKIA";
				}
				if (i == 8)
				{
					resultado = "HUAWEI";
				}
				if (i == 9)
				{
					resultado = "ASUS";
				}
				if (i == 10)
				{
					resultado = "GOOGLE";
				}
				if (i == 11)
				{
					resultado = "SAMSUNG";
				}
			}

			if (lblDica.Text == "CanaisDeTV")
			{
				if (i == 1)
				{
					resultado = "SIC";
				}
				if (i == 2)
				{
					resultado = "TVI";
				}
				if (i == 3)
				{
					resultado = "RTP";
				}
				if (i == 4)
				{
					resultado = "DISNEY";
				}
				if (i == 5)
				{
					resultado = "AWN";
				}
				if (i == 6)
				{
					resultado = "HOLLYWOOD";
				}
				if (i == 7)
				{
					resultado = "AWN";
				}
				if (i == 8)
				{
					resultado = "GLOBO";
				}
				if (i == 9)
				{
					resultado = "BCC";
				}
			}

			if (lblDica.Text == "BandasFamosas")
			{
				if (i == 1)
				{
					resultado = "Marshmello";
				}
				if (i == 2)
				{
					resultado = "THE BEATLES";
					label3.Text = " ";
				}
				if (i == 3)
				{
					resultado = "BLACK SABBATH";
					label5.Text = " ";
				}
				if (i == 4)
				{
					resultado = "KISS";
				}
				if (i == 5)
				{
					resultado = "QUEEN";
				}
				if (i == 6)
				{
					resultado = "U2";
					label1.Text = "2";
				}
				if (i == 7)
				{
					resultado = "COLDPLAY";
				}
				if (i == 8)
				{
					resultado = "ONE DIRECTION";
					label3.Text = " ";
				}
			}

			if (lblDica.Text == "Musica")
			{
				if (i == 1)
				{
					resultado = "HAPIER";
				}
				if (i == 2)
				{
					resultado = "Dunas";
				}
				if (i == 3)
				{

				}
			}
			int NumLetras = resultado.Count();//vai contar o resultado do NumLetras
			Array.Resize(ref arpALAVRA, NumLetras);//ref=referencia (em cima, está separado e o ref junta tudo); Resize=redimensioamento; Array.Resize=se não houver mais dimensões o resize adiciona mais dimensões vazias ao array 



			for (NumLetras = 0; NumLetras <= resultado.Count() - 1; NumLetras++)
			{
				arpALAVRA[NumLetras] = resultado.Substring(NumLetras, 1); //NumLetras, 1 -> vai metendo as letras da palavra uma a uma; resultado.Substring=vai dividir a palavra consoante pedido; arpALAVRA[NumLetras]= manda para o array;
			}

			if (NumLetras == 3)
			{
				//lbl4 para lbl19
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
			}
			if (NumLetras == 4)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
			}
			if (NumLetras == 5)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
			}
			if (NumLetras == 6)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
			}
			if (NumLetras == 7)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
			}
			if (NumLetras == 8)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
			}
			if (NumLetras == 9)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
			}
			if (NumLetras == 10)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
				label9.Visible = true;
			}
			if (NumLetras == 11)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
				label9.Visible = true;
				label10.Visible = true;
			}
			if (NumLetras == 12)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
				label9.Visible = true;
				label10.Visible = true;
				label11.Visible = true;
			}
			if (NumLetras == 13)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
				label9.Visible = true;
				label10.Visible = true;
				label11.Visible = true;
				label12.Visible = true;
			}
			if (NumLetras == 14)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
				label9.Visible = true;
				label10.Visible = true;
				label11.Visible = true;
				label12.Visible = true;
				label13.Visible = true;
			}
			if (NumLetras == 15)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
				label9.Visible = true;
				label10.Visible = true;
				label11.Visible = true;
				label12.Visible = true;
				label13.Visible = true;
				label14.Visible = true;
			}
			if (NumLetras == 16)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
				label9.Visible = true;
				label10.Visible = true;
				label11.Visible = true;
				label12.Visible = true;
				label13.Visible = true;
				label14.Visible = true;
				label15.Visible = true;
			}
		}

		private void BtnStart1_Click(object sender, EventArgs e)
		{
			lbl20.Visible = false;
			valor();

			if (ContadorCheckBoxes >= 2)
			{
				lbl21.Visible = false;
				label17.Visible = false;
				label18.Visible = false;

				picImagem.Visible = false;

				Dica.Visible = true;

				palavra(sender, e);

				lbl24.Visible = false;
			}


			if (lblDica.Text != "")
			{

				btnStart1.Visible = false;
				picImagem.Visible = false;
				lblDica.Visible = true;

				grp3letras.Visible = true;
				grpTeclado.Visible = true;

				jg2();
			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void PictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void AjudaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
			System.Diagnostics.Process.Start(path+ "/Ajuda.txt");
		}

		private void CheckBox11_CheckedChanged(object sender, EventArgs e)
		{
		}



		private void JogadorVSJogadorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 frm = new Form2();
			frm.ShowDialog(); // impede que o formulario1 seja mexido
			resultado = frm.palavra;
			dic = frm.dica;

			lblDica.Text = dic;

			jogadorvsjogador();
		}

		private void jogadorvsjogador()
		{
			picImagem.Visible = false;
			label17.Visible = false;
			label18.Visible = false;
			lbl21.Visible = false;
			btnStart1.Visible = false;
			grpTeclado.Visible = true;
			grp3letras.Visible = true;
			jogovsjogo = true;
			lblDica.Visible = true;

			int n = resultado.Count();//vai contar o resultado do NumLetras
			Array.Resize(ref arpALAVRAVS, n);//ref=referencia (em cima, está separado e o ref junta tudo); Resize=redimensioamento; Array.Resize=se não houver mais dimensões o resize adiciona mais dimensões vazias ao array 

			if (n == 3)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
			}
			if (n == 4)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
			}
			if (n == 5)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
			}
			if (n == 6)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
			}
			if (n == 7)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
			}
			if (n == 8)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
			}
			if (n == 9)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
			}
			if (n == 10)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
				label9.Visible = true;
			}
			if (n == 11)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
				label9.Visible = true;
				label10.Visible = true;
			}
			if (n == 12)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
				label9.Visible = true;
				label10.Visible = true;
				label11.Visible = true;
			}
			if (n == 13)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
				label9.Visible = true;
				label10.Visible = true;
				label11.Visible = true;
				label12.Visible = true;
			}
			if (n == 14)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
				label9.Visible = true;
				label10.Visible = true;
				label11.Visible = true;
				label12.Visible = true;
				label13.Visible = true;
			}
			if (n == 15)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
				label9.Visible = true;
				label10.Visible = true;
				label11.Visible = true;
				label12.Visible = true;
				label13.Visible = true;
				label14.Visible = true;
			}
			if (n == 16)
			{
				label0.Visible = true;
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
				label7.Visible = true;
				label8.Visible = true;
				label9.Visible = true;
				label10.Visible = true;
				label11.Visible = true;
				label12.Visible = true;
				label13.Visible = true;
				label14.Visible = true;
				label15.Visible = true;
			}

			for (n = 0; n <= resultado.Count() - 1; n++)
			{
				arpALAVRAVS[n] = resultado.Substring(n, 1); //NumLetras, 1 -> vai metendo as letras da palavra uma a uma; resultado.Substring=vai dividir a palavra consoante pedido; arpALAVRA[NumLetras]= manda para o array;
			}

		}
	}
}
