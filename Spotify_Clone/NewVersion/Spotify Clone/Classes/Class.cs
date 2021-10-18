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
		public int Minimizar { get; set; }
		public int NotifMusic { get; set; }
		public string XAMPP { get; set; }

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
	public class ConfIdioma
	{
		public string Idioma { get; set; }
		public List<Forms1> form1 { get; set; }
		public List<Forms2> form2 { get; set; }
	}
	public class Forms1
	{
		public string lblEscIdioma { get; set; }
		public string lblSO { get; set; }
		public string lblTitMini { get; set; }
		public string lblMini { get; set; }
		public string lblnotif { get; set; }
		public string lblInfoMusic { get; set; }
		public string chkDiscord { get; set; }
		public string lblNomeDisc { get; set; }
		public string lblDuracao { get; set; }
		public string lblinfoDu { get; set; }
		public string lbltec { get; set; }
		public string chkAtalho { get; set; }
		public string lblAnt { get; set; }
		public string lblPaRe { get; set; }
		public string lblSeg { get; set; }
		public string MSGRANDOM { get; set; }
		public string MSGFLASH { get; set; }
		public string ICNXAMPP { get; set; }
		//public string MSGCOPY { get; set; }
	}
	public class Forms2
	{
		public string Form2Text { get; set; }
		public string lblNome { get; set; }
		public string lblDescription { get; set; }
		public string button1 { get; set; }
		public string MSGBUTTON { get; set; }
		public string MSGPICT { get; set; }
	}
	public class Xampp
	{
		public string NomePlay { get; set; }
		public List<string> PathsXampp { get; set; }
		public string IpUser { get; set; }
	}

}
