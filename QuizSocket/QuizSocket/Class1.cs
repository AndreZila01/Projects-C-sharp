using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSocket
{
	public class Jogo
	{
		/// <summary>
		/// Perguntas que o host fez
		/// </summary>
		List<string> Pergunta { get; set; }
		/// <summary>
		/// Todas as hipoteses certas
		/// </summary>
		List<string> Certa { get; set; }
		/// <summary>
		/// Todas as hipoteses erradas
		/// </summary>
		List<string> Errada1 { get; set; }
		/// <summary>
		/// Todas as hipoteses erradas
		/// </summary>
		List<string> ErradaA2 { get; set; }
		/// <summary>
		/// Todas as hipoteses erradas
		/// </summary>
		List<string> Errada3 { get; set; }
		/// <summary>
		/// Todas as hipoteses erradas
		/// </summary>
		List<Users> NoJogo { get; set; }
		//PERGUNTAS, CERTA, ERRADA, ERRADA, ERRADA, TIMER, ...
	}

	public class Users
	{
		/// <summary>
		/// Ip do User
		/// </summary>
		string IpUser { get; set; }
		/// <summary>
		/// Nome do User
		/// </summary>
		string UserName { get; set; }
		/// <summary>
		/// Numero de perguntas certas
		/// </summary>
		string NCertas { get; set; }
		/// <summary>
		/// Index de Respostas Certas
		/// </summary>
		List<int> Certas { get; set; }
		/// <summary>
		/// Numero de Erradas
		/// </summary>
		int Erradas { get; set; }
	}
}
