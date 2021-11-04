using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Forca
{
	public partial class Form2 : Form
	{
		int letra = 1;
		public string palavra, dica;
		Button btn; //var não funciona como tipo de variavel global!!
		public Form2()
		{
			InitializeComponent();
		}

		private void Palavras()
		{
			palavra = palavra + btn.Tag.ToString();

		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void LetraClick(object sender, EventArgs e)
		{
			btn = (Button)sender;

			if (letra == 1)
			{
				label1.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 2)
			{
				label2.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 3)
			{
				label3.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 4)
			{
				label4.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 5)
			{
				label5.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 6)
			{
				label6.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 7)
			{
				label7.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 8)
			{
				label8.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 9)
			{
				label9.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 10)
			{
				label10.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 11)
			{
				label11.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 12)
			{
				label12.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 13)
			{
				label13.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 14)
			{
				label14.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 15)
			{
				label15.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 16)
			{
				label16.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}
			else
			if (letra == 17)
			{
				label17.Text = btn.Tag.ToString();
				letra++;
				Palavras();
			}

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			string pal, dic;
			if (textBox1.Text != "" && palavra != "")
			{
				pal = palavra;
				dica = textBox1.Text;
				dic = dica;
				
				this.Close();//fecha este formulario
				 
			}
				

		}
	}
}
