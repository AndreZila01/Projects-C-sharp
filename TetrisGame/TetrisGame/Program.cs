using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TetrisGame
{
	internal class Program
	{
		private static Jogo game = new Jogo();
		private static Timer s = new Timer();
		static void Main(string[] args)
		{
			
			if (game.Tabuleiro == null)
			{
				// int widht = 11, height = 21;
				game.Tabuleiro = Cerebro.RunCode(10, 20);
				game.indexOrder = new Random().Next(0, 7);
				game.Ordem = Cerebro.OrdemTabuleiro();
				game.y = game.Tabuleiro.GetLength(0)-1;
				game.x = game.Tabuleiro.GetLength(1)/2;
			}

			s.Interval = 1000;
			s.Elapsed += S_Elapsed;
			s.Start();

			while (true)
			{
				ConsoleKeyInfo keyinfo;

				keyinfo = Console.ReadKey();
				Program.s.Stop();
				Cerebro.KeyBinds(keyinfo.Key.ToString(), game);
				//Console.Clear();
				Program.s.Start();
			}
		}



		private static void S_Elapsed(object sender, ElapsedEventArgs e)
		{
			Console.Clear();

			if (game.y != 0)
				game.y--;
			else
				Cerebro.NextPiece(game);

			var s = Cerebro.ColocarPeca(game.Tabuleiro, game.x, game.y, game.Ordem, game.indexOrder, 0);

			if (s.GetLength(0) == 0)
				Cerebro.NextPiece(game);

			Cerebro.PrintTable(game.Tabuleiro);

			//Cerebro.PrintTable(tabuleiro);

		}
	}
}
