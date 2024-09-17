using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace QuizSocket
{
	public class Question
	{
		/*private string text1;
		private string text2;
		private string text3;
		private string text4;
		private string text5;
		private Users users;*/

		/*public Questions(string text1, string text2, string text3, string text4, string text5, Users users)
		{
			this.text1 = text1;
			this.text2 = text2;
			this.text3 = text3;
			this.text4 = text4;
			this.text5 = text5;
			this.users = users;
		}*/

		public int idPergunta { get; set; }
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
		public string Errada2 { get; set; }
		/// <summary>
		/// Todas as hipoteses erradas
		/// </summary>
		public string Errada3 { get; set; }
		/// <summary>
		/// Todas as hipoteses erradas
		/// </summary>
		//public List<Users> NoJogo { get; set; }
		//PERGUNTAS, CERTA, ERRADA, ERRADA, ERRADA, TIMER, ...
	}

	public class Users
	{
		/// <summary>
		/// Ip do User
		/// </summary>
		public string IpUser { get; set; }
		/// <summary>
		/// Nome do User
		/// </summary>
		public string UserName { get; set; }
		/// <summary>
		/// Numero de perguntas certas
		/// </summary>
		public int NCertas { get; set; }
		/// <summary>
		/// Index de Respostas Certas
		/// </summary>
		public List<int> AnswersRights { get; set; }
		/// <summary>
		/// Numero de Erradas
		/// </summary>
		public int Erradas { get; set; }
		public Socket User { get; set; }
	}

	public class Quiz
	{
		/// <summary>
		/// Lista de Jogadores no jogo
		/// </summary>
		public List<Users> Users { get; set; }
		public List <Question> Perguntas { get; set; }

	}
}
