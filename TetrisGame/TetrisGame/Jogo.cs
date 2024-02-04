using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
	internal class Jogo
	{
		public int Points { get; set; }
		public int[,] Tabuleiro { get; set; }
		public int indexOrder { get; set; }
		/// <summary>
		/// 1 - I 
		/// 2 - J 
		/// 3 - L
		/// 4 - O
		/// 5 - S
		/// 6 - Z
		/// 7 - T
		/// </summary>
		public int [] Ordem { get; set; }
		public int x { get; set; }
		public int y { get; set; }
		/// <summary>
		/// 1- Estado Normal...
		/// 2- Direita
		/// 3- Baixo
		/// 4- Esquerda
		/// </summary>
		public int StateOfPiece { get; set; }
	}


	/*
	 1. I

	|
	|
	|
	 
	2. J

	|
	|_ _ _

	3. L

		  |
	_ _ _ |

	4. O

	_ _
	_ _

	5. S
	
	  _ _
	_ _

	6. Z

	_ _
	  _ _
	 
	7. T
	
	  _
	_ _ _

	https://tetris.wiki/Tetris_Guideline
	 */
}
