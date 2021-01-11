using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Cobra__Aventura
{
	public partial class Form1 : Form
	{
		//proibir de fazer comida apos ao tamanho x da cobra
		bool para = true, naoapareca;

		// Lista com os pontos da cobra
		private List<Point> cobra = new List<Point>();

		//Posição do portão em y
		public int[] portay = new int[12];

		//Posição do portão em x
		public int[] portax = new int[12];

		// Posição da comida
		public Point comida = new Point();

		// Random para colocação da comida
		private Random _rnd = new Random();

		// Direção da cobra - Sentido
		private Point DirCobra = new Point(10, 0);

		//Entrada das portas em y
		int[] PontEncontrary = new int[8];

		// Step da cobra
		private const int StepCobra = 10;

		//As coordenadas da porta
		public Point porta = new Point();

		//Os Obstaculos
		//public int[] obstaculosy;
		//public int[] obstaculosx;

		public int[] obstaculosy = new int[300];
		public int[] obstaculosx = new int[300];


		//Diz o lvl do Jogador e a quantas comidas comeu!!
		int lvl = 1, Fcomida =0, aux = 0, CO = 0, comidacomida, Ccomida;//comrpiemnto=x, altura=y
		Color Cor;

		public Form1()
		{
			InitializeComponent();

			int valor = 10;

			cobra.Add(new Point(valor, 10));//vai dizer que tem adicionar as 9 coordenadas no cobra;

			timer1.Enabled = true;
			CriaComida();

			Random x = new Random();
			int p = x.Next(1, 10);

			if(p==1 || p==2 || p==3)
			{
				Cor = Color.Blue; 
			}
			else
			if(p==4)
			{
				Cor = Color.Brown;
			}
			else
			if(p==5)
			{
				Cor = Color.Black;
			}
			else
			if(p==6)
			{
				Cor = Color.DarkViolet;
			}
			else
			if(p==7 || p==8 || p==9)
			{
				Cor= Color.Green;
			}
			else
			{
				Cor = Color.Azure;
			}
			

		}

		private void descobre()
		{
			aux = 0;

			//Point newHeadPosition = new Point(cobra[0].X + DirCobra.X, cobra[0].Y + DirCobra.Y);

			for (int a = 0; a < cobra.Count; a++)
				//cobra.RemoveAt(cobra[a]);
				cobra.Clear();

			//DirCobra.X = 10;
			//DirCobra.Y = 10;

			//if (lvl != 1)
			//{
			//	Random s = new Random();
			//	int a = s.Next(2, 10);//vai criar x obstaculos

			//	CO += a;

			//}

			if (Fcomida == 11 && lvl == 1)
			{
				Random s = new Random();
				CO = s.Next(5, 20);//vai criar x obstaculos
				para = true;
				lvl2();
			}

			if (lvl != 1)
			{
				Random y = new Random();
				int co = y.Next(5, 40);//vai criar x obstaculos
				CO += co;
			}

			if (Fcomida >= 15 && lvl == 2)
			{
				para = true;
				lvl3();
			}

			if (Fcomida >= 20 && lvl == 3)
			{
				para = true;
				lvl4();
			}

			if (Fcomida >= 20 && lvl == 4)
			{
				para = true;
				lvl5();
			}

			if (Fcomida >= 23 && lvl == 5)
			{
				para = true;
				lvl6();
			}

			if (Fcomida >= 25 && lvl == 6)
			{
				para = true;
				lvl7();
			}

			if (Fcomida >= 28 && lvl == 7)
			{
				para = true;
				lvl8();
			}

			if (Fcomida >= 29 && lvl == 8)
			{
				para = true;
				lvl9();
			}

			if (Fcomida >= 30 && lvl == 9)
			{
				para = true;
				lvl10();
			}

			if (Fcomida >= 50 && lvl == 10)
			{
				MessageBox.Show("Parabéns, \n O Sr. é um excelente jogador!!!");
				this.Close();
			}

			Fcomida = 0;
			lvl++;

			for (int d = 0; d < portax.Length; d++)
			{
				portax[d] = -10;
				portay[d] = -10;
			}

			InitializeComponent();

			cobra.Add(new Point(10, 10));//vai dizer que tem adicionar as 9 coordenadas no cobra;
			DirCobra.X = 0;
			DirCobra.Y = 0;

			CriaComida();

			Atualiza();

			naoapareca = false;

		}

		private void Cria_Obstaculos()
		{
			for (int a = 0; a < CO; a++)
			{
			Aqui:
				int c = 0;

				
					Random x = new Random();
					int p = x.Next(10, 700);

					int dr = 0;

					dr = p % 10;

					p -= dr;

					c = 790 - p;//comprimento

				

				Random Y = new Random();
				int d = Y.Next(30, 400);//altura

				int dt = 0;

				dt = d % 10;

				d -= dt;


				for (int s = 0; s < obstaculosx.Length; s++)
				{
					int pv = 0;
					int P = 0;

					pv = obstaculosx[s] - c;
					P = obstaculosy[s] - d;

					if (pv == 0 && P == 0)
					{
						goto Aqui;
					}
				}

				for(int s=0; s<obstaculosx.Length; s++)
				{
					if(obstaculosx[s]==0)
					{
						obstaculosy[s] = d;
						obstaculosx[s] = c;

						break;
					}
				}

				//MessageBox.Show("X: " + d + "   Y:" + c);

				DesenhaRectangulo(obstaculosx[a], obstaculosy[a], Color.Gray);
			}
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			if ((Fcomida <= 10 && lvl == 1) || (Fcomida <= 15 && lvl == 2) || (Fcomida <= 20 && lvl == 3) || (Fcomida <= 20 && lvl == 4) || (Fcomida <= 23 && lvl == 5) || (Fcomida <= 25 && lvl == 6) || (Fcomida <= 28 && lvl == 7) || (Fcomida <= 29 && lvl == 8) || (Fcomida <= 29 && lvl == 9) || (Fcomida <= 50 && lvl == 10))
			{
				DesenhaRectangulo(comida.X, comida.Y, Color.OrangeRed);

			}

			foreach (Point ponto in cobra)
			{
				DesenhaRectangulo(ponto.X, ponto.Y, Cor);//vai a função e desenha a cobra
			}
			if (obstaculosx[0] != 0)
			{
				for (int d = 0; d < obstaculosy.Length; d++)
				{
					if (obstaculosy[d] != 0)
						DesenhaRectangulo(obstaculosx[d], obstaculosy[d], Color.Gray);
				}
			}


			if (aux == 0 && ((Fcomida == 11 && lvl == 1) || (Fcomida == 16 && lvl == 2) || (Fcomida == 21 && lvl == 3) || (Fcomida == 21 && lvl == 4) || (Fcomida == 24 && lvl == 5) || (Fcomida == 26 && lvl == 6) || (Fcomida == 29 && lvl == 7) || (Fcomida == 30 && lvl == 8) || (Fcomida == 31 && lvl == 9) || (Fcomida == 51 && lvl == 10)))
			{
				if (para == true)
				{
					Random X = new Random();
					int D = X.Next(1, 50);

					int g = D % 2;

					if (g == 0)
					{
						porta.X = 10;
					}
					else
					{
						int a = 780;//comprimento

						porta.X = a;
					}

					Random Y = new Random();
					int d = Y.Next(10, 380);//altura

					//if (this.Height > 50)
					//{
					//	MessageBox.Show("" + this.Height);
					//}

					//pula para o paint ?!? Como?!?


					int dt = 0;

					dt = d % 10;

					d -= dt;

					porta.Y = d;

				}

				for (int s = 0; s <= 11; s++)
				{
					//Identar Ctrl+K+d

					//if (s == 5 || s == 6 || s == 7)
					//{
					//	PontEncontrar[s, 0] = porta.X;
					//	PontEncontrar[0, s] = porta.Y;
					//}

					if (s != 0 && s != 1 && s != 2 && s != 10 && s != 11)
					{
						portay[s] = porta.Y;
						portax[s] = porta.X;

						porta.Y += 10;
					}

				}

				aux++;
				para = false;
			}

			if (para == false)
			{
				for (int s = 1; s < portay.Length; s++)
				{
					if (s == 3 || s == 4 || s == 8 || s == 9)
					{
						DesenhaRectangulo(portax[s], portay[s], Color.Brown);//voltar para o metodo anterior ctrl + -

						if (s == 4 || s == 8)
						{
							if (portax[s] == 10)
								DesenhaRectangulo(portax[s] - 10, portay[s], Color.Brown);
							else
								DesenhaRectangulo(portax[s] + 10, portay[s], Color.Brown);
						}

					}

					//Identar Ctrl+K+d

					porta.Y += 10;
				}
				aux++;
			}
		}

		private void DesenhaRectangulo(int x, int y, Color color, int size = 10)//desenha a cobra
		{
			Graphics g = CreateGraphics();
			SolidBrush brush = new SolidBrush(color);
			g.FillRectangle(brush, new Rectangle(x, y, size, size));
			brush.Dispose();
			g.Dispose();
		}

		private void CriaComida()//cria a comida
		{

			if ((Fcomida <= 10 && lvl == 1) || (Fcomida <= 15 && lvl == 2) || (Fcomida <= 20 && lvl == 3) || (Fcomida <= 20 && lvl == 4) || (Fcomida <= 23 && lvl == 5) || (Fcomida <= 25 && lvl == 6) || (Fcomida <= 28 && lvl == 7) || (Fcomida <= 29 && lvl == 8) || (Fcomida <= 29 && lvl == 9) || (Fcomida <= 50 && lvl == 10))
			{
			aQUI:
				comida.X = 10 * _rnd.Next(2, this.Width / 10 - 5);
				comida.Y = 10 * _rnd.Next(2, this.Height / 10 - 5);

				if (timer1.Enabled == true)
				{
					comidacomida = +Ccomida;
					comidacomida = (comidacomida * 10);
				}

				for (int a = 0; a < obstaculosx.Length; a++)
				{
					if (obstaculosy[a] != 0)
					{
						for (int s = 0; s < obstaculosx.Length; s++)
						{
							if (obstaculosx[s] == comida.X && obstaculosy[s] == comida.Y)
								goto aQUI;
						}
					}

					if (obstaculosx[0] == 0)
					{
						break;
					}
				}

				Fcomida++;

				if(timer1.Enabled==true)
					Ccomida++;
			}

		}
		private void GameLoop(object sender, System.EventArgs e)
		{
			Atualiza();

			// Força a que o form atualize!
			Invalidate();
		}

		private void Atualiza()
		{
			timer1.Start();
			int Faltacomida = 0;
			this.Width = 816;
			this.Height = 489;

			// Novo ponto com a direção da cobra a seguir
			Point newHeadPosition = new Point(cobra[0].X + DirCobra.X, cobra[0].Y + DirCobra.Y);

			{
				if (lvl == 1)
				{
					Faltacomida = 10;
				}

				if (lvl == 2)
				{
					Faltacomida = 15;
				}

				if (lvl == 3)
				{
					Faltacomida = 20;
				}

				if (lvl == 4)
				{
					Faltacomida = 20;
				}

				if (lvl == 5)
				{
					Faltacomida = 23;
				}

				if (lvl == 6)
				{
					Faltacomida = 25;
				}

				if (lvl == 7)
				{
					Faltacomida = 28;
				}

				if (lvl == 8)
				{
					Faltacomida = 29;
				}

				if (Fcomida == 30 && lvl == 9)
				{
					Faltacomida = 30;
				}

				if (lvl == 10)
				{
					Faltacomida = 50;
				}
			}

			this.Text = "Pontos: " + comidacomida + "           Lvl:" + lvl + "             Falta " + (Faltacomida - (Fcomida - 1)) + " frutas";
			
			if (naoapareca == false && (newHeadPosition.X < 0 || newHeadPosition.X > 790 || newHeadPosition.Y < 0 || newHeadPosition.Y > 440))
			{
				timer1.Enabled = false;
				MessageBox.Show("\"Ai a minha cabeça\" \nCOLISÃO com a parede!!!!");
				Application.Exit();
			}

			for (int i = 1; i < cobra.Count; i++)
			{
				if (naoapareca == false && (newHeadPosition.X == cobra[i].X && newHeadPosition.Y == cobra[i].Y))//quando a cabeça é igual ao corpo, entra
				{
					timer1.Enabled = false;
					MessageBox.Show("\"Ai a minha cauda\" \nCOLISÃO com o corpo ou cauda!!!!");
					Application.Exit();
				}
			}

			if (aux != 0)
			{
				if (naoapareca == false && (portay[3] == newHeadPosition.Y && portax[3] == newHeadPosition.X) || (portay[4] == newHeadPosition.Y && portax[4] == newHeadPosition.X) || (portay[8] == newHeadPosition.Y && portax[8] == newHeadPosition.X) || (portay[9] == newHeadPosition.Y && portax[9] == newHeadPosition.X) || (portax[1] == 10 && (portay[4] == newHeadPosition.Y && portax[4] - 10 == newHeadPosition.X)) || (portax[1] == 10 && (portay[8] == newHeadPosition.Y && portax[8] - 10 == newHeadPosition.X)) || (portax[1] != 10 && (portay[4] == newHeadPosition.Y && portax[4] + 10 == newHeadPosition.X)) || (portax[1] != 10 && (portay[8] == newHeadPosition.Y && portax[8] + 10 == newHeadPosition.X)))
				{
					timer1.Enabled = false;
					MessageBox.Show("COLISÃO com o portão!!!!");
					Application.Exit();
				}

			}

			// Insere a nova posição da cabeça da cobra na lista
			cobra.Insert(0, newHeadPosition);

			// Remove o último elemento
			cobra.RemoveAt(cobra.Count - 1);

			// Verifica se encontrou comida
			if (cobra[0].X == comida.X && cobra[0].Y == comida.Y)
			{
				// Adiciona o novo elemento à cobra
				cobra.Add(new Point(comida.X, comida.Y));

				// Cria uma nova posição da comida
				CriaComida();
			}

			if ((newHeadPosition.X == portax[3] && newHeadPosition.Y == portay[5]) || (newHeadPosition.X == portax[3] && newHeadPosition.Y == portay[6]) || (newHeadPosition.X == portax[3] && newHeadPosition.Y == portay[7]))//certificar-se passou o portão
			{
				naoapareca = true;
				timer1.Enabled = false;
				MessageBox.Show("Clique nas seguintes teclas ou setas!!!\n \"p\" serve para parar o Tempo\n\"a\" || seta da esquerda -> Cobra para a esquerda\n \"s\" || seta para baixo -> Cobra desce \n\"d\" || seta para a direita -> Cobra para a direita \n\"w\" || seta para cima -> Cobra sobe ");
				descobre();
			}
			if (obstaculosx[0] != 0)
			{
				for (int g = 0; g < obstaculosy.Length; g++)
				{
					if (newHeadPosition.X == obstaculosx[g] && newHeadPosition.Y == obstaculosy[g])
					{
						timer1.Enabled = false;
						MessageBox.Show("COLISÃO os muros!!!!");
						Application.Exit();
					}
				}
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{

			switch (e.KeyCode)
			{

				case Keys.Up:
				case Keys.W:
					if (DirCobra.Y == 0)
					{
						DirCobra.X = 0;
						DirCobra.Y = -StepCobra;
					}
					break;
				case Keys.Left:
				case Keys.A:
					if (DirCobra.X == 0)
					{
						DirCobra.X = -StepCobra;
						DirCobra.Y = 0;
					}
					break;
				case Keys.Down:
				case Keys.S:
					if (DirCobra.Y == 0)
					{
						DirCobra.X = 0;
						DirCobra.Y = StepCobra;
					}
					break;
				case Keys.Right:
				case Keys.D:
					if (DirCobra.X == 0)
					{
						DirCobra.X = StepCobra;
						DirCobra.Y = 0;
					}
					break;
				case Keys.P:
					if (timer1.Enabled)
						timer1.Enabled = false;
					else
						timer1.Enabled = true;
					break;

			}

		}

		private void lvl2()
		{
			Cria_Obstaculos();
		}

		private void lvl3()
		{
			Cria_Obstaculos();
		}

		private void lvl4()
		{
			Cria_Obstaculos();
		}

		private void lvl5()
		{
			Cria_Obstaculos();
		}

		private void lvl6()
		{
			Cria_Obstaculos();
		}

		private void lvl7()
		{
			Cria_Obstaculos();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void lvl8()
		{
			Cria_Obstaculos();
		}

		private void lvl9()
		{
			Cria_Obstaculos();
		}

		private void lvl10()
		{
			Cria_Obstaculos();
		}


	}
}
