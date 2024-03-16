using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSocket
{
	public class Jogo
	{
		private string text1;
		private string text2;
		private string text3;
		private string text4;
		private string text5;
		private Users users;

		public Jogo(string text1, string text2, string text3, string text4, string text5, Users users)
		{
			this.text1 = text1;
			this.text2 = text2;
			this.text3 = text3;
			this.text4 = text4;
			this.text5 = text5;
			this.users = users;
		}

		/// <summary>
		/// Perguntas que o host fez
		/// </summary>
		public string Pergunta { get; set; }
		/// <summary>
		/// Todas as hipoteses certas
		/// </summary>
		public string Certa { get; set; }
		/// <summary>
		/// Todas as hipoteses erradas
		/// </summary>
		public string Errada1 { get; set; }
		/// <summary>
		/// Todas as hipoteses erradas
		/// </summary>
		public string ErradaA2 { get; set; }
		/// <summary>
		/// Todas as hipoteses erradas
		/// </summary>
		public string Errada3 { get; set; }
		/// <summary>
		/// Todas as hipoteses erradas
		/// </summary>
		public List<Users> NoJogo { get; set; }
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
