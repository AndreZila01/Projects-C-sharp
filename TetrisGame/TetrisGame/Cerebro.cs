using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
	internal class Cerebro
	{
		#region Inicio do Jogo
		public static int[,] RunCode(int widht, int height)
		{

			int[,] tabuleiro = new int[height, widht];

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < widht; j++)
				{
					tabuleiro[i, j] = 0;
				}
			}

			return tabuleiro;
		}

		public static int[] OrdemTabuleiro()
		{
			int index = 0;
			int[] ordem = new int[7];

			ordem[0] = -1;
			ordem[1] = -1;
			ordem[2] = -1;
			ordem[3] = -1;
			ordem[4] = -1;
			ordem[5] = -1;
			ordem[6] = -1;

			while (ordem[6] == -1)
			{
				int random = new Random().Next(14, 98);//1-7
				random = ((random) / 14) - 1;

				if (!ordem.Contains(random))
				{

					ordem[index] = random;
					index++;
				}
				else if (index == 6)
				{
					if (!ordem.Contains(0))
						ordem[6] = 0;
					if (!ordem.Contains(1))
						ordem[6] = 1;
					if (!ordem.Contains(2))
						ordem[6] = 2;
					if (!ordem.Contains(3))
						ordem[6] = 3;
					if (!ordem.Contains(4))
						ordem[6] = 4;
					if (!ordem.Contains(5))
						ordem[6] = 5;
					if (!ordem.Contains(6))
						ordem[6] = 6;
				}
			}
			return ordem;
		}

		#endregion

		#region Jogo
		public static string BuildTable(int value)
		{
			if (value == 0)
				return "  ";
			else
				return "[]";
		}

		public static void PrintTable(int[,] tabuleiro)
		{

			Console.WriteLine($"\n\n\n\n\n" +

			$"<!{Cerebro.BuildTable(tabuleiro[19, 0])}.{Cerebro.BuildTable(tabuleiro[19, 1])}.{Cerebro.BuildTable(tabuleiro[19, 2])}.{Cerebro.BuildTable(tabuleiro[19, 3])}.{Cerebro.BuildTable(tabuleiro[19, 4])}.{Cerebro.BuildTable(tabuleiro[19, 5])}.{Cerebro.BuildTable(tabuleiro[19, 6])}.{Cerebro.BuildTable(tabuleiro[19, 7])}.{Cerebro.BuildTable(tabuleiro[19, 8])}.{Cerebro.BuildTable(tabuleiro[19, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[18, 0])}.{Cerebro.BuildTable(tabuleiro[18, 1])}.{Cerebro.BuildTable(tabuleiro[18, 2])}.{Cerebro.BuildTable(tabuleiro[18, 3])}.{Cerebro.BuildTable(tabuleiro[18, 4])}.{Cerebro.BuildTable(tabuleiro[18, 5])}.{Cerebro.BuildTable(tabuleiro[18, 6])}.{Cerebro.BuildTable(tabuleiro[18, 7])}.{Cerebro.BuildTable(tabuleiro[18, 8])}.{Cerebro.BuildTable(tabuleiro[18, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[17, 0])}.{Cerebro.BuildTable(tabuleiro[17, 1])}.{Cerebro.BuildTable(tabuleiro[17, 2])}.{Cerebro.BuildTable(tabuleiro[17, 3])}.{Cerebro.BuildTable(tabuleiro[17, 4])}.{Cerebro.BuildTable(tabuleiro[17, 5])}.{Cerebro.BuildTable(tabuleiro[17, 6])}.{Cerebro.BuildTable(tabuleiro[17, 7])}.{Cerebro.BuildTable(tabuleiro[17, 8])}.{Cerebro.BuildTable(tabuleiro[17, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[16, 0])}.{Cerebro.BuildTable(tabuleiro[16, 1])}.{Cerebro.BuildTable(tabuleiro[16, 2])}.{Cerebro.BuildTable(tabuleiro[16, 3])}.{Cerebro.BuildTable(tabuleiro[16, 4])}.{Cerebro.BuildTable(tabuleiro[16, 5])}.{Cerebro.BuildTable(tabuleiro[16, 6])}.{Cerebro.BuildTable(tabuleiro[16, 7])}.{Cerebro.BuildTable(tabuleiro[16, 8])}.{Cerebro.BuildTable(tabuleiro[16, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[15, 0])}.{Cerebro.BuildTable(tabuleiro[15, 1])}.{Cerebro.BuildTable(tabuleiro[15, 2])}.{Cerebro.BuildTable(tabuleiro[15, 3])}.{Cerebro.BuildTable(tabuleiro[15, 4])}.{Cerebro.BuildTable(tabuleiro[15, 5])}.{Cerebro.BuildTable(tabuleiro[15, 6])}.{Cerebro.BuildTable(tabuleiro[15, 7])}.{Cerebro.BuildTable(tabuleiro[15, 8])}.{Cerebro.BuildTable(tabuleiro[15, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[14, 0])}.{Cerebro.BuildTable(tabuleiro[14, 1])}.{Cerebro.BuildTable(tabuleiro[14, 2])}.{Cerebro.BuildTable(tabuleiro[14, 3])}.{Cerebro.BuildTable(tabuleiro[14, 4])}.{Cerebro.BuildTable(tabuleiro[14, 5])}.{Cerebro.BuildTable(tabuleiro[14, 6])}.{Cerebro.BuildTable(tabuleiro[14, 7])}.{Cerebro.BuildTable(tabuleiro[14, 8])}.{Cerebro.BuildTable(tabuleiro[14, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[13, 0])}.{Cerebro.BuildTable(tabuleiro[13, 1])}.{Cerebro.BuildTable(tabuleiro[13, 2])}.{Cerebro.BuildTable(tabuleiro[13, 3])}.{Cerebro.BuildTable(tabuleiro[13, 4])}.{Cerebro.BuildTable(tabuleiro[13, 5])}.{Cerebro.BuildTable(tabuleiro[13, 6])}.{Cerebro.BuildTable(tabuleiro[13, 7])}.{Cerebro.BuildTable(tabuleiro[13, 8])}.{Cerebro.BuildTable(tabuleiro[13, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[12, 0])}.{Cerebro.BuildTable(tabuleiro[12, 1])}.{Cerebro.BuildTable(tabuleiro[12, 2])}.{Cerebro.BuildTable(tabuleiro[12, 3])}.{Cerebro.BuildTable(tabuleiro[12, 4])}.{Cerebro.BuildTable(tabuleiro[12, 5])}.{Cerebro.BuildTable(tabuleiro[12, 6])}.{Cerebro.BuildTable(tabuleiro[12, 7])}.{Cerebro.BuildTable(tabuleiro[12, 8])}.{Cerebro.BuildTable(tabuleiro[12, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[11, 0])}.{Cerebro.BuildTable(tabuleiro[11, 1])}.{Cerebro.BuildTable(tabuleiro[11, 2])}.{Cerebro.BuildTable(tabuleiro[11, 3])}.{Cerebro.BuildTable(tabuleiro[11, 4])}.{Cerebro.BuildTable(tabuleiro[11, 5])}.{Cerebro.BuildTable(tabuleiro[11, 6])}.{Cerebro.BuildTable(tabuleiro[11, 7])}.{Cerebro.BuildTable(tabuleiro[11, 8])}.{Cerebro.BuildTable(tabuleiro[11, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[10, 0])}.{Cerebro.BuildTable(tabuleiro[10, 1])}.{Cerebro.BuildTable(tabuleiro[10, 2])}.{Cerebro.BuildTable(tabuleiro[10, 3])}.{Cerebro.BuildTable(tabuleiro[10, 4])}.{Cerebro.BuildTable(tabuleiro[10, 5])}.{Cerebro.BuildTable(tabuleiro[10, 6])}.{Cerebro.BuildTable(tabuleiro[10, 7])}.{Cerebro.BuildTable(tabuleiro[10, 8])}.{Cerebro.BuildTable(tabuleiro[10, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[9, 0])}.{Cerebro.BuildTable(tabuleiro[9, 1])}.{Cerebro.BuildTable(tabuleiro[9, 2])}.{Cerebro.BuildTable(tabuleiro[9, 3])}.{Cerebro.BuildTable(tabuleiro[9, 4])}.{Cerebro.BuildTable(tabuleiro[9, 5])}.{Cerebro.BuildTable(tabuleiro[9, 6])}.{Cerebro.BuildTable(tabuleiro[9, 7])}.{Cerebro.BuildTable(tabuleiro[9, 8])}.{Cerebro.BuildTable(tabuleiro[9, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[8, 0])}.{Cerebro.BuildTable(tabuleiro[8, 1])}.{Cerebro.BuildTable(tabuleiro[8, 2])}.{Cerebro.BuildTable(tabuleiro[8, 3])}.{Cerebro.BuildTable(tabuleiro[8, 4])}.{Cerebro.BuildTable(tabuleiro[8, 5])}.{Cerebro.BuildTable(tabuleiro[8, 6])}.{Cerebro.BuildTable(tabuleiro[8, 7])}.{Cerebro.BuildTable(tabuleiro[8, 8])}.{Cerebro.BuildTable(tabuleiro[8, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[7, 0])}.{Cerebro.BuildTable(tabuleiro[7, 1])}.{Cerebro.BuildTable(tabuleiro[7, 2])}.{Cerebro.BuildTable(tabuleiro[7, 3])}.{Cerebro.BuildTable(tabuleiro[7, 4])}.{Cerebro.BuildTable(tabuleiro[7, 5])}.{Cerebro.BuildTable(tabuleiro[7, 6])}.{Cerebro.BuildTable(tabuleiro[7, 7])}.{Cerebro.BuildTable(tabuleiro[7, 8])}.{Cerebro.BuildTable(tabuleiro[7, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[6, 0])}.{Cerebro.BuildTable(tabuleiro[6, 1])}.{Cerebro.BuildTable(tabuleiro[6, 2])}.{Cerebro.BuildTable(tabuleiro[6, 3])}.{Cerebro.BuildTable(tabuleiro[6, 4])}.{Cerebro.BuildTable(tabuleiro[6, 5])}.{Cerebro.BuildTable(tabuleiro[6, 6])}.{Cerebro.BuildTable(tabuleiro[6, 7])}.{Cerebro.BuildTable(tabuleiro[6, 8])}.{Cerebro.BuildTable(tabuleiro[6, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[5, 0])}.{Cerebro.BuildTable(tabuleiro[5, 1])}.{Cerebro.BuildTable(tabuleiro[5, 2])}.{Cerebro.BuildTable(tabuleiro[5, 3])}.{Cerebro.BuildTable(tabuleiro[5, 4])}.{Cerebro.BuildTable(tabuleiro[5, 5])}.{Cerebro.BuildTable(tabuleiro[5, 6])}.{Cerebro.BuildTable(tabuleiro[5, 7])}.{Cerebro.BuildTable(tabuleiro[5, 8])}.{Cerebro.BuildTable(tabuleiro[5, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[4, 0])}.{Cerebro.BuildTable(tabuleiro[4, 1])}.{Cerebro.BuildTable(tabuleiro[4, 2])}.{Cerebro.BuildTable(tabuleiro[4, 3])}.{Cerebro.BuildTable(tabuleiro[4, 4])}.{Cerebro.BuildTable(tabuleiro[4, 5])}.{Cerebro.BuildTable(tabuleiro[4, 6])}.{Cerebro.BuildTable(tabuleiro[4, 7])}.{Cerebro.BuildTable(tabuleiro[4, 8])}.{Cerebro.BuildTable(tabuleiro[4, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[3, 0])}.{Cerebro.BuildTable(tabuleiro[3, 1])}.{Cerebro.BuildTable(tabuleiro[3, 2])}.{Cerebro.BuildTable(tabuleiro[3, 3])}.{Cerebro.BuildTable(tabuleiro[3, 4])}.{Cerebro.BuildTable(tabuleiro[3, 5])}.{Cerebro.BuildTable(tabuleiro[3, 6])}.{Cerebro.BuildTable(tabuleiro[3, 7])}.{Cerebro.BuildTable(tabuleiro[3, 8])}.{Cerebro.BuildTable(tabuleiro[3, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[2, 0])}.{Cerebro.BuildTable(tabuleiro[2, 1])}.{Cerebro.BuildTable(tabuleiro[2, 2])}.{Cerebro.BuildTable(tabuleiro[2, 3])}.{Cerebro.BuildTable(tabuleiro[2, 4])}.{Cerebro.BuildTable(tabuleiro[2, 5])}.{Cerebro.BuildTable(tabuleiro[2, 6])}.{Cerebro.BuildTable(tabuleiro[2, 7])}.{Cerebro.BuildTable(tabuleiro[2, 8])}.{Cerebro.BuildTable(tabuleiro[2, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[1, 0])}.{Cerebro.BuildTable(tabuleiro[1, 1])}.{Cerebro.BuildTable(tabuleiro[1, 2])}.{Cerebro.BuildTable(tabuleiro[1, 3])}.{Cerebro.BuildTable(tabuleiro[1, 4])}.{Cerebro.BuildTable(tabuleiro[1, 5])}.{Cerebro.BuildTable(tabuleiro[1, 6])}.{Cerebro.BuildTable(tabuleiro[1, 7])}.{Cerebro.BuildTable(tabuleiro[1, 8])}.{Cerebro.BuildTable(tabuleiro[1, 9])}!>\n" +

				$"<!{Cerebro.BuildTable(tabuleiro[0, 0])}.{Cerebro.BuildTable(tabuleiro[0, 1])}.{Cerebro.BuildTable(tabuleiro[0, 2])}.{Cerebro.BuildTable(tabuleiro[0, 3])}.{Cerebro.BuildTable(tabuleiro[0, 4])}.{Cerebro.BuildTable(tabuleiro[0, 5])}.{Cerebro.BuildTable(tabuleiro[0, 6])}.{Cerebro.BuildTable(tabuleiro[0, 7])}.{Cerebro.BuildTable(tabuleiro[0, 8])}.{Cerebro.BuildTable(tabuleiro[0, 9])}!>\n" +
				"<!=============================!>\n" +
				@" \/\/\/\/\/\/\/\/\/\/\/\/\/\/\/ ");


		}

		public static int[,] ColocarPeca(int[,] Tabuleiro, int x, int y, int[] OrdemPeca, int Index, int EstadoPeca, string oldvalue)
		{
			Debug.Print("2");
			if (y != -1 && Tabuleiro[y, x] == 0)
			{
				if (y + 1 != Tabuleiro.GetLength(0))
					Tabuleiro[y + 1, x] = 0;


				if (OrdemPeca[Index] + 1 == 1)
				{
					// I
					//Tabuleiro[y + 1, x] = 1;
					//Debug.Print($"{y+1}, {x}");
					//Tabuleiro[y, x] = 1;
					//Debug.Print($"{y}, {x}");
					//Tabuleiro[y - 1, x] = 1;
					//Debug.Print($"{y-1}, {x}");
					//Tabuleiro[y - 2, x] = 1;
					//Debug.Print($"{y-2}, {x}\n\n\n\n\n");

					//Já apagado o de cima...
					//if (y < Tabuleiro.GetLength(0) - 2)
					//	Tabuleiro[y + 2, x] = 0;

					Tabuleiro[y, x - 2] = 1;
					Tabuleiro[y, x - 1] = 1;
					Tabuleiro[y, x] = 1;
					Tabuleiro[y, x + 1] = 1;


					if (y < Tabuleiro.GetLength(0) - 1)
					{
						int Oy = int.Parse(oldvalue.Split(new string[] { "-" }, StringSplitOptions.None).ToArray()[1]), Ox = int.Parse(oldvalue.Split(new string[] { "-" }, StringSplitOptions.None).ToArray()[0]);
						Tabuleiro[Oy + 1, Ox - 2] = 0;
						Tabuleiro[Oy + 1, Ox - 1] = 0;
						Tabuleiro[Oy + 1, Ox + 1] = 0;
					}
				}
				else if (OrdemPeca[Index] + 1 == 2)
				{
					// 2 - J 
					Tabuleiro[y + 1, x] = 1;
					Tabuleiro[y, x] = 1;
					Tabuleiro[y, x + 1] = 1;
					Tabuleiro[y, x + 2] = 1;

					//Já apagado o de cima

					if (y < Tabuleiro.GetLength(0) - 2)
					{
						int Oy = int.Parse(oldvalue.Split(new string[] { "-" }, StringSplitOptions.None).ToArray()[1]), Ox = int.Parse(oldvalue.Split(new string[] { "-" }, StringSplitOptions.None).ToArray()[0]);

						Tabuleiro[Oy + 2, Ox] = 0;
						Tabuleiro[Oy + 1, Ox + 1] = 0;
						Tabuleiro[Oy + 1, Ox + 2] = 0;
					}
				}
				else if (OrdemPeca[Index] + 1 == 3)
				{
					// 3 - L
					Tabuleiro[y + 1, x] = 1;
					Tabuleiro[y, x] = 1;
					Tabuleiro[y, x - 1] = 1;
					Tabuleiro[y, x - 2] = 1;

					//Já apaga o de cima

					if (y < Tabuleiro.GetLength(0) - 2)
					{
						int Oy = int.Parse(oldvalue.Split(new string[] { "-" }, StringSplitOptions.None).ToArray()[1]), Ox = int.Parse(oldvalue.Split(new string[] { "-" }, StringSplitOptions.None).ToArray()[0]);

						Tabuleiro[Oy + 1, Ox - 1] = 0;
						Tabuleiro[Oy + 2, Ox] = 0;
						Tabuleiro[Oy + 1, Ox - 2] = 0;
					}
				}
				else if (OrdemPeca[Index] + 1 == 4)
				{
					//Guiar pela esquerda
					// 4 - O
					Tabuleiro[y + 1, x] = 1;
					Tabuleiro[y + 1, x + 1] = 1;
					Tabuleiro[y, x] = 1;
					Tabuleiro[y, x + 1] = 1;

					//Já apaga o de cima
					if (y < Tabuleiro.GetLength(0) - 2)
					{
						int Oy = int.Parse(oldvalue.Split(new string[] { "-" }, StringSplitOptions.None).ToArray()[1]), Ox = int.Parse(oldvalue.Split(new string[] { "-" }, StringSplitOptions.None).ToArray()[0]);

						Tabuleiro[Oy + 2, Ox + 1] = 0;
						Tabuleiro[Oy + 2, Ox] = 0;
						Tabuleiro[Oy + 2, Ox + 1] = 0;
					}
				}
				else if (OrdemPeca[Index] + 1 == 5)
				{

					//Guiar pela esquerda
					// 5 - S
					Tabuleiro[y + 1, x] = 1;
					Tabuleiro[y + 1, x + 1] = 1;
					Tabuleiro[y, x] = 1;
					Tabuleiro[y, x - 1] = 1;

					//Já apaga o de cima

					if (y < Tabuleiro.GetLength(0) - 2)
					{
						int Oy = int.Parse(oldvalue.Split(new string[] { "-" }, StringSplitOptions.None).ToArray()[1]), Ox = int.Parse(oldvalue.Split(new string[] { "-" }, StringSplitOptions.None).ToArray()[0]);

						Tabuleiro[Oy + 2, Ox + 1] = 0;
						Tabuleiro[Oy + 2, Ox] = 0;
						Tabuleiro[Oy + 1, Ox - 1] = 0;
						Tabuleiro[Oy + 2, Ox - 1] = 0;
					}
				}
				else if (OrdemPeca[Index] + 1 == 6)
				{
					// 6 - Z
					//Guiar pela direita
					Tabuleiro[y + 1, x] = 1;
					Tabuleiro[y + 1, x - 1] = 1;
					Tabuleiro[y, x] = 1;
					Tabuleiro[y, x + 1] = 1;

					//Já apaga o de cima
					//Tabuleiro[y + 1, x - 1] = 0;
					//Tabuleiro[y, x + 1] = 0;

					if (y < Tabuleiro.GetLength(0) - 2)
					{
						int Oy = int.Parse(oldvalue.Split(new string[] { "-" }, StringSplitOptions.None).ToArray()[1]), Ox = int.Parse(oldvalue.Split(new string[] { "-" }, StringSplitOptions.None).ToArray()[0]);

						Tabuleiro[Oy + 2, Ox - 1] = 0;
						Tabuleiro[Oy + 2, Ox] = 0;
						Tabuleiro[Oy + 1, Ox + 1] = 0;
					}
				}
				else if (OrdemPeca[Index] + 1 == 7)
				{
					// 7 - T
					Tabuleiro[y + 1, x] = 1;
					Tabuleiro[y, x - 1] = 1;
					Tabuleiro[y, x] = 1;
					Tabuleiro[y, x + 1] = 1;

					//Já apaga o de cima
					//Tabuleiro[y, x - 1] = 0;
					//Tabuleiro[y, x + 1] = 0;


					if (y < Tabuleiro.GetLength(0) - 2)
					{
						int Oy = int.Parse(oldvalue.Split(new string[] { "-" }, StringSplitOptions.None).ToArray()[1]), Ox = int.Parse(oldvalue.Split(new string[] { "-" }, StringSplitOptions.None).ToArray()[0]);

						Tabuleiro[Oy + 2, Ox] = 0;
						Tabuleiro[Oy + 1, Ox - 1] = 0;
						Tabuleiro[Oy + 1, Ox + 1] = 0;
					}
				}

			}
			else
				return new int[0, 0];


			Debug.Print("3");
			return Tabuleiro;
		}

		public static void NextPiece(Jogo jogo)
		{

			if (jogo.indexOrder++ != 6)
				jogo.indexOrder = jogo.indexOrder++;
			else
				jogo.indexOrder = 0;

			jogo.y = jogo.Tabuleiro.GetLength(0) - 2;
			jogo.x = (jogo.Tabuleiro.GetLength(1) / 2)-1;
		}

		public static void KeyBinds(String tecla, Jogo game)
		{
			int ymax = game.Tabuleiro.GetLength(0);
			int xmax = game.Tabuleiro.GetLength(1);

			//game.y--;
			int x = game.x;
			int y = game.y;

			Debug.Print($"{x}x{y}");

			int[,] tabuleiro = new int[0, 0];
			switch (tecla)
			{
				case "NumPad8":
				case "W":
				case "UpArrow":
					for (int i = 0; i < ymax; i++)
						if (CheckColocarPeca(game, x, xmax, i, game.StateOfPiece))
						{
							tabuleiro = ColocarPeca(game.Tabuleiro, x, i, game.Ordem, game.indexOrder, game.StateOfPiece, $"{x}-{y}");
							if (tabuleiro.GetLength(0) != 0)
								game.Tabuleiro = tabuleiro;
						}
					break;
				case "NumPad2":
				case "S":
				case "DownArrow":
					game.y--;
					break;
				case "NumPad4":
				case "A":
				case "LeftArrow":
					Debug.Print("1");
					Debug.Print($"1-{x}x{y}");
					x--;
					Debug.Print($"2-{x}x{y}");
					if (CheckColocarPeca(game, x, xmax, y, game.StateOfPiece))
					{
						Debug.Print($"3-{x}x{y}");
						game.x = x;
						tabuleiro = ColocarPeca(game.Tabuleiro, x, y, game.Ordem, game.indexOrder, game.StateOfPiece, $"{x}-{y}");
						if (tabuleiro.GetLength(0) != 0)
							game.Tabuleiro = tabuleiro;
					}
					break;
				case "NumPad6":
				case "D":
				case "RightArrow":
					x++;
					if (CheckColocarPeca(game, x, xmax, y, game.StateOfPiece))
					{
						game.x = x;
						tabuleiro = ColocarPeca(game.Tabuleiro, x, y, game.Ordem, game.indexOrder, game.StateOfPiece, $"{x}-{y}"); 
						if (tabuleiro.GetLength(0) != 0)
							game.Tabuleiro = tabuleiro;
					}
					break;

			}
			Console.Clear();
			Cerebro.PrintTable(game.Tabuleiro);

		}

		private static bool CheckColocarPeca(Jogo game, int x, int xmax, int y, int EstadoPeca)
		{
			int[,] tabuleiro = game.Tabuleiro;
			switch (game.Ordem[game.indexOrder] + 1)
			{
				case 1:
					if (x > 2 && x < xmax)
						if (game.StateOfPiece == 0)
						{
							int check = tabuleiro[y, x] + tabuleiro[y, x - 1] + tabuleiro[y, x - 2] + tabuleiro[y, x + 1];
							if (check == 0)
								return true;
						}
					break;
				case 2:
					if (x > 0 && x < xmax - 2)
						if (game.StateOfPiece == 0)
						{
							int check = tabuleiro[y + 1, x] + tabuleiro[y, x] + tabuleiro[y, x + 1] + tabuleiro[y, x + 2];
							if (check == 0)
								return true;
						}
					break;
				case 3:
					if (x > 2 && x < xmax)
						if (game.StateOfPiece == 0)
						{
							int check = tabuleiro[y + 1, x] + tabuleiro[y, x] + tabuleiro[y, x - 1] + tabuleiro[y, x - 2];
							if (check == 0)
								return true;
						}
					break;
				case 4:
					if (x > 0 && x < xmax - 1)
						if (game.StateOfPiece == 0)
						{
							int check = tabuleiro[y + 1, x] + tabuleiro[y + 1, x + 1] + tabuleiro[y, x] + tabuleiro[y, x + 1];
							if (check == 2)
								return true;
						}
					break;
				case 5:
					if (x > 1 && x < xmax - 1)
						if (game.StateOfPiece == 0)
						{
							int check = tabuleiro[y + 1, x] + tabuleiro[y + 1, x + 1] + tabuleiro[y, x] + tabuleiro[y, x - 1];
							if (check == 0)
								return true;
						}
					break;
				case 6:
					if (x > 1 && x < xmax - 1)
						if (game.StateOfPiece == 0)
						{
							int check = tabuleiro[y + 1, x] + tabuleiro[y + 1, x - 1] + tabuleiro[y, x] + tabuleiro[y, x + 1];
							if (check == 2)
								return true;
						}
					break;
				case 7:
					if (x > 1 && x < xmax - 1)
						if (game.StateOfPiece == 0)
						{
							int check = tabuleiro[y, x] + tabuleiro[y - 1, x - 1] + tabuleiro[y - 1, x] + tabuleiro[y - 1, x + 1];
							if (check == 3)
								return true;
						}
					break;
			}
			return false;
		}
		#endregion
	}
}
