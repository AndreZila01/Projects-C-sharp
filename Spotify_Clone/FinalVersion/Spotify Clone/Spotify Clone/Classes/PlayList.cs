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
}
