using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone.Classes
{
	public class PlayList
	{
		public int IDList { get; set; }
		public string Image { get; set; }
		public string Name { get; set; }
		public string Descrição { get; set; }
		//public List<string> Musicas { get; set; }
		public List<string> Caminho_da_Musica { get; set; }
	}
	// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
	public class Settings
	{
		public string Idioma { get; set; }
		public int AutoRun { get; set; }
		public int disc { get; set; }
		public List<Discord> discord { get; set; }
		public int atal { get; set; }
		public List<Atalho> Atalhos { get; set; }
		public string Paths { get; set; }
		//public string XAMPP { get; set; }
		//public int FecharOuMinimizar { get; set; }
	}
	public class Discord
	{
		public int EnviarNome { get; set; }
		public int Duracao { get; set; }
	}
	public class Atalho
	{
		public string MusicaAnterior { get; set; }
		public string Pausa { get; set; }
		public string MusicaSeguinte { get; set; }
	}


}
