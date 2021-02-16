using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Timers;
using AudioSwitcher.AudioApi.CoreAudio;

namespace Jogo_Sudoku
{
	public partial class Sudoku : Form
	{
		#region Variaveis
		const int WS_MINIMIZEBOX = 0x20000;
		const int CS_DBLCLKS = 0x8;
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		List<int> _Distancia = new List<int>();
		List<string> _ListRandom = new List<string>();
		List<int> _listNumero = new List<int>();
		int x, y, i;
		CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
		System.Timers.Timer t;
		int s, m, h;
		#endregion
		#region Form
		public Sudoku()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			this.Size = new Size(480, 500);
			panel2.Location = new Point(0, 107);
			panel2.Size = new Size(480, 450);
			panel1.Size = new Size(480, 300);

			t = new System.Timers.Timer();
			t.Interval = 1000;
			t.Elapsed += OnTimeEvent;

			defaultPlaybackDevice.Volume = 30;

			/*defaultPlaybackDevice.Volume = defaultPlaybackDevice.Volume - 5.0;

			defaultPlaybackDevice.Volume = defaultPlaybackDevice.Volume + 5.0;*/
		}
		#endregion
		#region pictureBox1
		private void pictureBox1_MouseHover(object sender, EventArgs e)
		{
			pictureBox1.Image = Properties.Resources.close_red;
		}

		private void pictureBox1_MouseLeave(object sender, EventArgs e)
		{
			pictureBox1.Image = Properties.Resources.close_white;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		#endregion
		#region ComboBox
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			List<string> _ListRandom = new List<string>();
			panel2.Controls.Clear();
			_Distancia.Clear();

			axWindowsMediaPlayer1.Ctlcontrols.stop();
			panel2.Visible = false;

			timer1.Stop();

			label2.Text = "Timer:                                00:00:00";


			if (comboBox1.Text != "" && comboBox1.Text != "Personalizar")
			{
				panel1.Visible = false;

				int quantidade, f = 0;

				_listNumero.Clear();
				_ListRandom.Clear();

				for (int a = 0; a <= 81; a++)
					_listNumero.Add(0);

				var q = comboBox1.Text == "Fácil" ? quantidade = 3 : (comboBox1.Text == "Médio" ? quantidade = 5 : quantidade = 8);

				for (int a = 1; a <= quantidade + 1; a++)
					_ListRandom.Add("0" + (a));

				_ListRandom.ToList().ForEach(item =>
				{
					f++;

				Aqui:
					Random n = new Random();
					int d = n.Next(1, 10);

					if (_ListRandom.Contains("" + d))
						goto Aqui;
					else
						_ListRandom[_ListRandom.FindIndex(ind => ind.Equals("0" + f))] = "" + d;
				});

				f = 0;

				_ListRandom.ToList().ForEach(item =>
				{
					int aleatorio;

					do
					{
						Random d = new Random();
						aleatorio = d.Next(1, 82);
					} while (_listNumero[aleatorio] != 0);

					_listNumero[aleatorio] = int.Parse(_ListRandom[f]);
					f++;
				});

				DesenharQuadrados();
			}
			else
			if (comboBox1.Text == "Personalizar")
			{
				panel1.Size = new Size(panel2.Width, panel2.Height);
				panel1.Visible = true;

			}
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			button1.Enabled = true;
		}
		#endregion
		#region checkBox 
		private void checkBox(object sender, EventArgs e)
		{
			CheckBox check = sender as CheckBox;

			if (check.Checked)
				check.Checked = true;
			else
				check.Checked = false;

			var d = checkBox1.Checked ? checkBox3.Enabled = false : checkBox3.Enabled = true;
			d = checkBox3.Checked ? checkBox1.Enabled = false : checkBox1.Enabled = true;

			if (checkBox3.Checked)
			{
				label8.Visible = true;
				label9.Visible = true;
				label7.Visible = true;
				textBox1.Visible = true;
				textBox2.Visible = true;
				textBox3.Visible = true;
			}
			else
			{
				label8.Visible = false;
				label9.Visible = false;
				label7.Visible = false;
				textBox1.Visible = false;
				textBox2.Visible = false;
				textBox3.Visible = false;
			}

			if (checkBox1.Checked || checkBox3.Checked)
				label2.Visible = true;
			else
				label2.Visible = false;
		}
		#endregion
		#region Button Click
		private void button1_Click(object sender, EventArgs e)
		{
			#region Variaveis
			int[] V1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; int[] V2 = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18 }; int[] V3 = new int[] { 19, 20, 21, 22, 23, 24, 25, 26, 27 }; int[] V4 = new int[] { 28, 29, 30, 31, 32, 33, 34, 35, 36 }; int[] V5 = new int[] { 37, 38, 39, 40, 41, 42, 43, 44, 45 }; int[] V6 = new int[] { 46, 47, 48, 49, 50, 51, 52, 53, 54 }; int[] V7 = new int[] { 55, 56, 57, 58, 59, 60, 61, 62, 63 }; int[] V8 = new int[] { 64, 65, 66, 67, 68, 69, 70, 71, 72 }; int[] V9 = new int[] { 73, 74, 75, 76, 77, 78, 79, 80, 81 };

			int[] H1 = new int[] { 1, 10, 19, 28, 37, 46, 55, 64, 73 }; int[] H2 = new int[] { 2, 11, 20, 29, 38, 47, 56, 65, 74 }; int[] H3 = new int[] { 3, 12, 21, 30, 39, 48, 57, 66, 75 }; int[] H4 = new int[] { 4, 13, 22, 31, 40, 49, 58, 67, 76 }; int[] H5 = new int[] { 5, 14, 23, 32, 41, 50, 59, 68, 77 }; int[] H6 = new int[] { 6, 15, 24, 33, 42, 51, 60, 69, 78 }; int[] H7 = new int[] { 7, 16, 25, 34, 43, 52, 61, 70, 79 }; int[] H8 = new int[] { 8, 17, 26, 35, 44, 53, 62, 71, 80 }; int[] H9 = new int[] { 9, 18, 27, 36, 45, 54, 63, 72, 81 };

			int[] Q1 = new int[] { 1, 2, 3, 10, 11, 12, 19, 20, 21 }; int[] Q2 = new int[] { 28, 29, 30, 37, 38, 39, 46, 47, 48 }; int[] Q3 = new int[] { 55, 56, 57, 64, 65, 66, 73, 74, 75 }; int[] Q4 = new int[] { 4, 5, 6, 13, 14, 15, 22, 23, 24 }; int[] Q5 = new int[] { 31, 32, 33, 40, 41, 42, 49, 50, 51 }; int[] Q6 = new int[] { 58, 59, 60, 67, 68, 69, 76, 77, 78 }; int[] Q7 = new int[] { 7, 8, 9, 16, 17, 18, 25, 26, 27 }; int[] Q8 = new int[] { 34, 35, 36, 43, 44, 45, 52, 53, 54 }; int[] Q9 = new int[] { 61, 62, 63, 70, 71, 72, 79, 80, 81 };
			#endregion

			bool CertificarV = false, CertificarH = false, CertificarQ = false;
			int quadrados = Convert.ToInt32(comboBox2.Text);
			int Vertical = 0, Horizontal = 0, Quadrado = 0;

			panel1.Visible = false;

			_listNumero.Clear();

			System.Diagnostics.Debug.Print("\n\n\n\n\n");

			for (int a = 0; a <= 81; a++)
				_listNumero.Add(0);

			for (int ef = 0; ef < quadrados; ef++)
			{
			Aqui:
				Random n = new Random();
				int d = n.Next(1, 82);

				if (_listNumero[d] != 0)
					goto Aqui;

				Random v = new Random();
				int Valor = v.Next(1, 10);

				string ondesta = Escolher.Identificar(d);

				string[] Lista = ondesta.Split(',');//Horizontal, Vertical

				Vertical = 0;
				Horizontal = 0;
				Quadrado = 0;

				#region Criar valor

				#region Vertical
				if (Lista[1] == "V1")
				{
					foreach (int valor in V1)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Vertical == 8)
							CertificarV = true;

						Vertical++;
					}
				}
				else
					if (Lista[1] == "V2")
				{
					foreach (int valor in V2)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Vertical == 8)
							CertificarV = true;

						Vertical++;
					}
				}
				else
					if (Lista[1] == "V3")
				{
					foreach (int valor in V3)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Vertical == 8)
							CertificarV = true;

						Vertical++;
					}
				}
				else
					if (Lista[1] == "V4")
				{
					foreach (int valor in V4)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Vertical == 8)
							CertificarV = true;

						Vertical++;
					}
				}
				else
					if (Lista[1] == "V5")
				{
					foreach (int valor in V5)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Vertical == 8)
							CertificarV = true;

						Vertical++;
					}
				}
				else
					if (Lista[1] == "V6")
				{
					foreach (int valor in V6)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Vertical == 8)
							CertificarV = true;

						Vertical++;
					}
				}
				else
					if (Lista[1] == "V7")
				{
					foreach (int valor in V7)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Vertical == 8)
							CertificarV = true;

						Vertical++;
					}
				}
				else
					if (Lista[1] == "V8")
				{
					foreach (int valor in V8)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Vertical == 8)
							CertificarV = true;

						Vertical++;
					}
				}
				else
					if (Lista[1] == "V9")
				{
					foreach (int valor in V9)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Vertical == 8)
							CertificarV = true;

						Vertical++;
					}
				}
				else
				{
					MessageBox.Show("ERRO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				//});
				#endregion

				#region Horizontal
				if (Lista[0] == "H1")
				{
					foreach (int valor in H1)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Horizontal == 8)
							CertificarH = true;

						Horizontal++;
					}
				}
				else
				if (Lista[0] == "H2")
				{
					foreach (int valor in H2)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Horizontal == 8)
							CertificarH = true;

						Horizontal++;
					}
				}
				else
				if (Lista[0] == "H3")
				{
					foreach (int valor in H3)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Horizontal == 8)
							CertificarH = true;

						Horizontal++;
					}
				}
				else
				if (Lista[0] == "H4")
				{
					foreach (int valor in H4)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Horizontal == 8)
							CertificarH = true;

						Horizontal++;
					}
				}
				else
				if (Lista[0] == "H5")
				{
					foreach (int valor in H5)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Horizontal == 8)
							CertificarH = true;

						Horizontal++;
					}
				}
				else
				if (Lista[0] == "H6")
				{
					foreach (int valor in H6)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Horizontal == 8)
							CertificarH = true;

						Horizontal++;
					}
				}
				else
				if (Lista[0] == "H7")
				{
					foreach (int valor in H7)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Horizontal == 8)
							CertificarH = true;

						Horizontal++;
					}
				}
				else
				if (Lista[0] == "H8")
				{
					foreach (int valor in H8)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Horizontal == 8)
							CertificarH = true;

						Horizontal++;
					}
				}
				else
				if (Lista[0] == "H9")
				{
					foreach (int valor in H9)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Horizontal == 8)
							CertificarH = true;

						Horizontal++;
					}
				}
				else
				{
					MessageBox.Show("ERRO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				#endregion

				#region Quadrado
				if (Lista[2] == "Q1")
				{
					foreach (int valor in Q1)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Quadrado == 8)
							CertificarQ = true;

						Quadrado++;
					}
				}
				else
				if (Lista[2] == "Q2")
				{
					foreach (int valor in Q2)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Quadrado == 8)
							CertificarQ = true;

						Quadrado++;
					}
				}
				else
				if (Lista[2] == "Q3")
				{
					foreach (int valor in Q3)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Quadrado == 8)
							CertificarQ = true;

						Quadrado++;
					}
				}
				else
				if (Lista[2] == "Q4")
				{
					foreach (int valor in Q4)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Quadrado == 8)
							CertificarQ = true;

						Quadrado++;
					}
				}
				else
				if (Lista[2] == "Q5")
				{
					foreach (int valor in Q1)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Quadrado == 8)
							CertificarQ = true;

						Quadrado++;
					}
				}
				else
				if (Lista[2] == "Q6")
				{
					foreach (int valor in Q1)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Quadrado == 8)
							CertificarQ = true;

						Quadrado++;
					}
				}
				else
				if (Lista[2] == "Q7")
				{
					foreach (int valor in Q7)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Quadrado == 8)
							CertificarQ = true;

						Quadrado++;
					}
				}
				else
				if (Lista[2] == "Q8")
				{
					foreach (int valor in Q8)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Quadrado == 8)
							CertificarQ = true;

						Quadrado++;
					}
				}
				else
				if (Lista[2] == "Q9")
				{
					foreach (int valor in Q9)
					{
						if (_listNumero[valor] == Valor)
							break;
						else if (Quadrado == 8)
							CertificarQ = true;

						Quadrado++;
					}
				}
				#endregion

				#endregion

				if (CertificarH && CertificarV && CertificarQ)
				{
					_listNumero[d] = Valor;
					System.Diagnostics.Debug.Print(d + "->" + _listNumero[d] + "(" + ef + ")");
				}
				else
				{
					CertificarV = false;
					CertificarH = false;
					CertificarQ = false;
					//System.Diagnostics.Debug.Print("ERROR: "+d + "->" + Valor + "(" + ef + ")");
					goto Aqui;
				}

				CertificarV = false;
				CertificarH = false;
				CertificarQ = false;

			}

			DesenharQuadrados();

			//MessageBox.Show("hey my name is Andre if you can help conctate my in linkdin:\n https://www.linkedin.com/in/andre-custodio-08522b181/ \n Thanks");
		}
		private void btn_Click(object sender, EventArgs e)
		{
			int valor = 0, a;
			//try
			//{
			Button btn = sender as Button;

			try
			{
				a = Convert.ToInt32(btn.Text);
			}
			catch
			{
				a = 0;
			}

			a++;

			if (a > 9)
				btn.Text = 1.ToString();
			else
				btn.Text = a.ToString();

			_listNumero[int.Parse(btn.Tag.ToString())] = int.Parse(btn.Text);

			valor = 0;
			_listNumero.ToList().ForEach(item =>
			{
				valor += item;
			});

			if (valor >= 405)
			{
				bool Certo = Escolher.Certificar(_listNumero);

				if (Certo != false)
				{
					//WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
					var caminhoficheiro = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

					t.Stop();
					defaultPlaybackDevice.Volume = 30;

					axWindowsMediaPlayer1.URL = caminhoficheiro + "/Mario & Sonic at the Olympic Winter Games (DS) - Award Ceremony ~Rank 1st~.mp3";
					axWindowsMediaPlayer1.Ctlcontrols.play();
					axWindowsMediaPlayer1.settings.volume = 15;

					panel2.Controls.Clear();

					MessageBox.Show("\tParabéns Conseguiu Ganhar!!!\n        Para voltar a jogar selecione outro modo!!", "PARABÉNS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}

			button2.Focus();
		}
		#endregion
		#region funções Auxilar
		private void DesenharQuadrados()
		{
			i = 0;

			panel2.Visible = true;
			#region create the button's
			x += 15;

			for (int a = 0; a <= 2; a++)
			{
				for (int d = 0; d <= 2; d++)
				{
					if (d != 0)
						x = x + 35;

					_Distancia.Add(x);
				}

				x += 60;
			}

			x = 0;

			if (comboBox1.Text != "" && comboBox1.Text != "Personalizar")
			{
				_ListRandom.ToList().ForEach(item =>
				{
				Aqui:
					Random n = new Random();
					int d = n.Next(1, 82);

					if (_listNumero[(d - 1)] == 0)
						_listNumero[(d - 1)] = int.Parse(item);
					else
						goto Aqui;

				});
			}

			for (int ab = 0; ab <= 2; ab++)
			{
				for (int s = 0; s <= 2; s++)
				{
					foreach (int lado in _Distancia)
					{
						i++;

						Button btn = new Button();
						btn.Location = new Point(_Distancia[x] + 30, lado);
						btn.Size = new Size(30, 30);
						btn.Click += btn_Click;
						btn.Tag = i;
						btn.Text = _listNumero[(i)] == 0 ? "" : _listNumero[(i)] + "";
						btn.TabStop = false;
						//btn.Text = i.ToString();
						var pod = btn.Text != "" ? btn.ForeColor = Color.Red : btn.ForeColor = Color.Black;
						panel2.Controls.Add(btn);
					}
					x++;
				}
			}
			#endregion
			if (checkBox1.Checked)
				t.Start();

			if (checkBox3.Checked)
			{
				var d = textBox2.Text != "" ? s = int.Parse(textBox2.Text) : s = 0;
				d = textBox1.Text != "" ? m = int.Parse(textBox1.Text) : m = 0;
				d = textBox3.Text != "" ? h = int.Parse(textBox3.Text) : h = 0;
				timer1.Start();
				timer1.Interval = 1000;
			}
		}
		private void Gameover()
		{
			//WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
			var caminhoficheiro = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

			t.Stop();
			defaultPlaybackDevice.Volume = 30;

			axWindowsMediaPlayer1.URL = caminhoficheiro + "/Mario & Sonic at the Olympic Winter Games (DS) - Award Ceremony ~Rank 4th~.mp3";
			axWindowsMediaPlayer1.Ctlcontrols.play();
			axWindowsMediaPlayer1.settings.volume = 25;

			panel2.Controls.Clear();

			MessageBox.Show("\t       Ohhh, Perdeu!!!\n        Para voltar a jogar selecione outro modo!!", "BOA SORTE PARA A PRÓXIMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}
		private void OnTimeEvent(object sender, ElapsedEventArgs e)
		{
			Invoke(new Action(() =>
			{
				s += 1;
				if (s == 60)
				{
					s = 0;
					m += 1;
				}
				if (m == 60)
				{
					m = 0;
					h += 1;
				}
				label2.Text = String.Format("Timer:                                {0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
			}));
		}
		#endregion
		#region Eventos Random
		private void timer1_Tick(object sender, EventArgs e)
		{
			label2.Text = String.Format("Timer:                                {0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
			Invoke(new Action(() =>
			{
				if (m == 0 && h >= 1)
				{
					m = 60;
					h -= 1;
				}
				if (s == 0 && m >= 1)
				{
					s = 60;
					m -= 1;
				}
				s -= 1;
				label2.Text = String.Format("Timer:                                {0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
			}));

			if (s == 0 && h == 0 && m == 0)
			{
				timer1.Stop();
				Gameover();
			}

		}
		private void pnlTop_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)//este codigo demonstrado em baixo é para movimentar a app
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			TextBox txt = sender as TextBox;

			if (txt.Text != "")
			{
				try
				{
					int vtxt = int.Parse(txt.Text);

					if (vtxt < 0 || vtxt > 60)
						txt.Text = "";
				}
				catch
				{
					txt.Text = "";
				}
			}
		}
		#endregion
	}
}
