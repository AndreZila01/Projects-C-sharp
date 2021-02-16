using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encriptação_E_Desencriptação
{

	public partial class Form1 : Form
	{
		#region variaveis globais
		int widht = Screen.PrimaryScreen.Bounds.Width;
		int height = Screen.PrimaryScreen.Bounds.Height;
		Encriptação encriptação = Encriptação.Vazio;
		#endregion

		#region Form
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			//this.BackColor = Color.LimeGreen;
			//this.TransparencyKey = Color.LimeGreen;
			this.Width = 860;
			this.Height = 491;
			encriptação = Encriptação.Vazio;
		}

		#endregion

		enum Encriptação
		{
			Vazio,
			EncriptaçãoA,
			EncriptaçãoB,
			EncriptaçãoC
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			encriptaredesencriptar();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			button1.Click += comboBox1_SelectedIndexChanged;
			var d = button1.Text == "Desincriptar Texto" ? label1.Text = "Texto Encriptado" : label1.Text = "Texto";
			d = button1.Text == "Desincriptar Texto" ? label2.Text = "Texto Desincriptado" : label2.Text = "Encriptação Texto";
			d = button1.Text == "Desincriptar Texto" ? button1.Text = "Encriptação Texto" : button1.Text = "Desincriptar Texto";
			var ds = button1.Text == "Desincriptar Texto" ? button1.Tag = "0" : button1.Tag = "1";

			comboBox1.Text = string.Empty;

			if (encriptação != Encriptação.Vazio)
				encriptação = Encriptação.Vazio;

			Debug.Print("" + encriptação);

			textBox1.Text = string.Empty;
			textBox2.Text = string.Empty;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var d = comboBox1.Text == "1- Encriptação A (fácil);" ? encriptação = Encriptação.EncriptaçãoA : (comboBox1.Text == "2- Encriptação B (médiano);" ? encriptação = Encriptação.EncriptaçãoB : (comboBox1.Text == "3- Encriptação C (dífcil e modificada);" ? encriptação = Encriptação.EncriptaçãoC : encriptação = Encriptação.Vazio));

			Debug.Print("" + encriptação);

			var dd = comboBox1.Text == "3- Encriptação C (dífcil e modificada);" ? textBox3.Visible = true : textBox3.Visible = false;
			textBox3.Text = "sblw-3hn8-sqoy19";



			encriptaredesencriptar();
		}

		private void encriptaredesencriptar()
		{
			textBox2.Text = string.Empty;

			if (button1.Text == "Desincriptar Texto")
				switch (encriptação)
				{
					case Encriptação.EncriptaçãoA:
						{
							try
							{
								if (textBox1.Text != string.Empty)
								{
									textBox2.Text = string.Empty;
									for (int i = 0; i < textBox1.Text.Length; i++)
									{
										int txtUsuario = (int)textBox1.Text[i];
										int txtCifrado = txtUsuario + 10;
										textBox2.Text += Char.ConvertFromUtf32(txtCifrado);
									}
								}
							}
							catch (Exception ex)
							{
								textBox2.Text= "ERRO 404!! \n" + ex.Message;
							}
						}
							break;
					case Encriptação.EncriptaçãoB:
						var d = textBox1.Text != string.Empty ? textBox2.Text = CrytoEngineB.Encrypt(textBox1.Text) : null;
						break;
					case Encriptação.EncriptaçãoC:
						d = textBox1.Text != string.Empty ? textBox2.Text = CryptoEngineC.Encrypt(textBox1.Text, "sblw-3hn8-sqoy19") : null;
						break;
					default:
						break;
				}
			else
			if (button1.Text == "Encriptação Texto")
				switch (encriptação)
				{
					case Encriptação.EncriptaçãoA:
						{
							try
							{
								if (textBox1.Text != string.Empty)
								{
									textBox2.Text = string.Empty;
									for (int i = 0; i < textBox1.Text.Length; i++)
									{
										int txtCifrado = (int)textBox1.Text[i];
										int txtOriginal = txtCifrado - 10;
										textBox2.Text += Char.ConvertFromUtf32(txtOriginal);
									}
								}

							}
							catch (Exception ex)
							{
								textBox2.Text = "ERRO 404!! \n" + ex.Message;
							}
						}
						break;
					case Encriptação.EncriptaçãoB:
						var d = textBox1.Text != string.Empty ? textBox2.Text = CrytoEngineB.Decrypt(textBox1.Text) : null;
						break;
					case Encriptação.EncriptaçãoC:
						d = textBox1.Text != string.Empty ? textBox2.Text = CryptoEngineC.Decrypt(textBox1.Text, "sblw-3hn8-sqoy19") : null;
						break;
					default:
						break;
				}
		}

		
	}
}
