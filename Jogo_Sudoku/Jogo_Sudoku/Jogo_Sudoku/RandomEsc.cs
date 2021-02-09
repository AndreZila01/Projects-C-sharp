using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Sudoku
{
	public class Escolher
	{
		public static string Identificar(int Random)
		{
			string tabela = "";

			#region Variaveis
			int[] V1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			int[] V2 = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18 };
			int[] V3 = new int[] { 19, 20, 21, 22, 23, 24, 25, 26, 27 };
			int[] V4 = new int[] { 28, 29, 30, 31, 32, 33, 34, 35, 36 };
			int[] V5 = new int[] { 37, 38, 39, 40, 41, 42, 43, 44, 45 };
			int[] V6 = new int[] { 46, 47, 48, 49, 50, 51, 52, 53, 54 };
			int[] V7 = new int[] { 55, 56, 57, 58, 59, 60, 61, 62, 63 };
			int[] V8 = new int[] { 64, 65, 66, 67, 68, 69, 70, 71, 72 };
			int[] V9 = new int[] { 73, 74, 75, 76, 77, 78, 79, 80, 81 };

			int[] H1 = new int[] { 1, 10, 19, 28, 37, 46, 55, 64, 73 };
			int[] H2 = new int[] { 2, 11, 20, 29, 38, 47, 56, 65, 74 };
			int[] H3 = new int[] { 3, 12, 21, 30, 39, 48, 57, 66, 75 };
			int[] H4 = new int[] { 4, 13, 22, 31, 40, 49, 58, 67, 76 };
			int[] H5 = new int[] { 5, 14, 23, 32, 41, 50, 59, 68, 77 };
			int[] H6 = new int[] { 6, 15, 24, 33, 42, 51, 60, 69, 78 };
			int[] H7 = new int[] { 7, 16, 25, 34, 43, 52, 61, 70, 79 };
			int[] H8 = new int[] { 8, 17, 26, 35, 44, 53, 62, 71, 80 };
			int[] H9 = new int[] { 9, 18, 27, 36, 45, 54, 63, 72, 81 };

			int[] Q1 = new int[] { 1, 2, 3, 10, 11, 12, 19, 20, 21 };
			int[] Q2 = new int[] { 28, 29, 30, 37, 38, 39, 46, 47, 48 };
			int[] Q3 = new int[] { 55, 56, 57, 64, 65, 66, 73, 74, 75 };
			int[] Q4 = new int[] { 4, 5, 6, 13, 14, 15, 22, 23, 24 };
			int[] Q5 = new int[] { 31, 32, 33, 40, 41, 42, 49, 50, 51 };
			int[] Q6 = new int[] { 58, 59, 60, 67, 68, 69, 76, 77, 78 };
			int[] Q7 = new int[] { 7, 8, 9, 16, 17, 18, 25, 26, 27 };
			int[] Q8 = new int[] { 34, 35, 36, 43, 44, 45, 52, 53, 54 };
			int[] Q9 = new int[] { 61, 62, 63, 70, 71, 72, 79, 80, 81 };

			#endregion

			var d = H1.Contains(Random) ? tabela = "H1" : null;
			d = H2.Contains(Random) ? tabela = "H2" : null;
			d = H3.Contains(Random) ? tabela = "H3" : null;
			d = H4.Contains(Random) ? tabela = "H4" : null;
			d = H5.Contains(Random) ? tabela = "H5" : null;
			d = H6.Contains(Random) ? tabela = "H6" : null;
			d = H7.Contains(Random) ? tabela = "H7" : null;
			d = H8.Contains(Random) ? tabela = "H8" : null;
			d = H9.Contains(Random) ? tabela = "H9" : null;

			var c = V1.Contains(Random) ? tabela = tabela + ",V1" : null;
			c = V2.Contains(Random) ? tabela = tabela + ",V2" : null;
			c = V3.Contains(Random) ? tabela = tabela + ",V3" : null;
			c = V4.Contains(Random) ? tabela = tabela + ",V4" : null;
			c = V5.Contains(Random) ? tabela = tabela + ",V5" : null;
			c = V6.Contains(Random) ? tabela = tabela + ",V6" : null;
			c = V7.Contains(Random) ? tabela = tabela + ",V7" : null;
			c = V8.Contains(Random) ? tabela = tabela + ",V8" : null;
			c = V9.Contains(Random) ? tabela = tabela + ",V9" : null;

			var q = Q1.Contains(Random) ? tabela = tabela + ",Q1" : null;
			q = Q2.Contains(Random) ? tabela = tabela + ",Q2" : null;
			q = Q3.Contains(Random) ? tabela = tabela + ",Q3" : null;
			q = Q4.Contains(Random) ? tabela = tabela + ",Q4" : null;
			q = Q5.Contains(Random) ? tabela = tabela + ",Q5" : null;
			q = Q6.Contains(Random) ? tabela = tabela + ",Q6" : null;
			q = Q7.Contains(Random) ? tabela = tabela + ",Q7" : null;
			q = Q8.Contains(Random) ? tabela = tabela + ",Q8" : null;
			q = Q9.Contains(Random) ? tabela = tabela + ",Q9" : null;

			return tabela;

		}

		public static bool Certificar(List<int> Teste)
		{
			bool Certificado = false;
			int ComprovarBool = 0;
			int UM = 0, DOIS = 0, TRES = 0, QUATRO = 0, CINCO = 0, SEIS = 0, SETE = 0, OITO = 0, NOVE = 0;
			#region Variaveis
			int[] V1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			int[] V2 = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18 };
			int[] V3 = new int[] { 19, 20, 21, 22, 23, 24, 25, 26, 27 };
			int[] V4 = new int[] { 28, 29, 30, 31, 32, 33, 34, 35, 36 };
			int[] V5 = new int[] { 37, 38, 39, 40, 41, 42, 43, 44, 45 };
			int[] V6 = new int[] { 46, 47, 48, 49, 50, 51, 52, 53, 54 };
			int[] V7 = new int[] { 55, 56, 57, 58, 59, 60, 61, 62, 63 };
			int[] V8 = new int[] { 64, 65, 66, 67, 68, 69, 70, 71, 72 };
			int[] V9 = new int[] { 73, 74, 75, 76, 77, 78, 79, 80, 81 };

			int[] H1 = new int[] { 1, 10, 19, 28, 37, 46, 55, 64, 73 };
			int[] H2 = new int[] { 2, 11, 20, 29, 38, 47, 56, 65, 74 };
			int[] H3 = new int[] { 3, 12, 21, 30, 39, 48, 57, 66, 75 };
			int[] H4 = new int[] { 4, 13, 22, 31, 40, 49, 58, 67, 76 };
			int[] H5 = new int[] { 5, 14, 23, 32, 41, 50, 59, 68, 77 };
			int[] H6 = new int[] { 6, 15, 24, 33, 42, 51, 60, 69, 78 };
			int[] H7 = new int[] { 7, 16, 25, 34, 43, 52, 61, 70, 79 };
			int[] H8 = new int[] { 8, 17, 26, 35, 44, 53, 62, 71, 80 };
			int[] H9 = new int[] { 9, 18, 27, 36, 45, 54, 63, 72, 81 };

			int[] Q1 = new int[] { 1, 2, 3, 10, 11, 12, 19, 20, 21 };
			int[] Q2 = new int[] { 28, 29, 30, 37, 38, 39, 46, 47, 48 };
			int[] Q3 = new int[] { 55, 56, 57, 64, 65, 66, 73, 74, 75 };
			int[] Q4 = new int[] { 4, 5, 6, 13, 14, 15, 22, 23, 24 };
			int[] Q5 = new int[] { 31, 32, 33, 40, 41, 42, 49, 50, 51 };
			int[] Q6 = new int[] { 58, 59, 60, 67, 68, 69, 76, 77, 78 };
			int[] Q7 = new int[] { 7, 8, 9, 16, 17, 18, 25, 26, 27 };
			int[] Q8 = new int[] { 34, 35, 36, 43, 44, 45, 52, 53, 54 };
			int[] Q9 = new int[] { 61, 62, 63, 70, 71, 72, 79, 80, 81 };

			#endregion
			Random n = new Random();
			int d = n.Next(1, 10);

			#region Quadrado
			if (d == 1)
			{
				Q1.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;

				});
			}
			else
			if (d == 2)
			{
				Q2.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 3)
			{
				Q3.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 4)
			{
				Q4.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 5)
			{
				Q5.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 6)
			{
				Q6.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 7)
			{
				Q7.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 8)
			{
				Q8.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 9)
			{
				Q9.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			#endregion

			UM = 0; DOIS = 0; TRES = 0; QUATRO = 0; CINCO = 0; SEIS = 0; SETE = 0; OITO = 0; NOVE = 0;

			#region Vertical
			if (d == 1)
			{
				V1.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;

				});
			}
			else
			if (d == 2)
			{
				V2.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 3)
			{
				V3.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 4)
			{
				V4.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 5)
			{
				V5.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 6)
			{
				V6.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 7)
			{
				V7.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 8)
			{
				V8.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 9)
			{
				V9.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			#endregion

			UM = 0; DOIS = 0; TRES = 0; QUATRO = 0; CINCO = 0; SEIS = 0; SETE = 0; OITO = 0; NOVE = 0;

			#region Horizontal
			if (d == 1)
			{
				H1.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;

				});
			}
			else
			if (d == 2)
			{
				H2.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 3)
			{
				H3.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 4)
			{
				H4.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 5)
			{
				H5.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 6)
			{
				H6.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 7)
			{
				H7.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 8)
			{
				H8.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			else
			if (d == 9)
			{
				H9.ToList().ForEach(item =>
				{
					if (Teste[item] == 1)
						UM++;
					else
					if (Teste[item] == 2)
						DOIS++;
					else
					if (Teste[item] == 3)
						TRES++;
					else
					if (Teste[item] == 4)
						QUATRO++;
					else
					if (Teste[item] == 5)
						CINCO++;
					else
					if (Teste[item] == 6)
						SEIS++;
					else
					if (Teste[item] == 7)
						SETE++;
					else
					if (Teste[item] == 8)
						OITO++;
					else
					if (Teste[item] == 9)
						NOVE++;

					if (NOVE == 1 && OITO == 1 && SETE == 1 && SEIS == 1 && CINCO == 1 && QUATRO == 1 && TRES == 1 && DOIS == 1 && UM == 1)
						ComprovarBool++;
				});
			}
			#endregion

			if (ComprovarBool == 3)
				Certificado = true;

			return Certificado;
		}
	}
}
