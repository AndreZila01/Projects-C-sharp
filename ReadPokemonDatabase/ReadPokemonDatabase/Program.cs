using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bulbapedia
{
	class Program
	{
		static void Main(string[] args)
		{
			//Read this website and data of pokémon: https://pokemondb.net/pokedex/national

			var client = new WebClient();
			client.Encoding = Encoding.UTF8;

			string[] array = (client.DownloadString("https://bulbapedia.bulbagarden.net/wiki/List_of_Pok%C3%A9mon_by_National_Pok%C3%A9dex_number")).Split(new string[] { " id=\"Generation_I\"" }, StringSplitOptions.None).ToArray()[1].Split(new string[] { "(Pokémon)\">" }, StringSplitOptions.None);

			List<string> name = new List<string>();
			array.ToList().ForEach(item =>
			{
				if (item != array[0])
					name.Add(item.Split(new string[] { "</a>" }, StringSplitOptions.None).ToArray()[0]);

			});
			List<DataPokemon> data = new List<DataPokemon>();
			foreach(string item in name)
			{
				if (data.Count() == 898)
					break;
				client.Encoding = Encoding.UTF8;
				string arrays = (client.DownloadString($"https://bulbapedia.bulbagarden.net/wiki/{item}")).ToLower();
				string[] types = new string[2];

				types[0] = "" + (CultureInfo.CurrentCulture.TextInfo).ToTitleCase(arrays.Split(new string[] { "</i>) is a" }, StringSplitOptions.None).ToArray()[1].Replace("dual-type", "").Split(new string[] { ")\">" }, StringSplitOptions.None).ToArray()[1]).Split(new string[] { "</A>" }, StringSplitOptions.None).ToArray()[0];

				if (arrays.Split(new string[] { "(type)\">" }, StringSplitOptions.None).ToArray().Count() == 2)
					types[1] = (CultureInfo.CurrentCulture.TextInfo).ToTitleCase(arrays.Split(new string[] { "(type)\">" }, StringSplitOptions.None).ToArray()[1].Split(new string[] { ")\">" }, StringSplitOptions.None).ToArray()[1]).Split(new string[] { "</a>" }, StringSplitOptions.None).ToArray()[0];

				data.Add(new DataPokemon()
				{
					id = int.Parse(arrays.Split(new string[] { "<th>National &#8470;</th>\n<td><strong>" }, StringSplitOptions.None).ToArray()[1].Split(new string[] { "</strong>" }, StringSplitOptions.None).ToArray()[0]),
					nameP = new NamePokemon()
					{
						english = arrays.Split(new string[] { "<th>English, Spanish, Italian</th>" }, StringSplitOptions.None).ToArray()[1].Split(new string[] { "</td>" }, StringSplitOptions.None).ToArray()[0].Replace("<td>", "").Replace("\n", ""),
						German = arrays.Split(new string[] { "<th>German</th>" }, StringSplitOptions.None).ToArray()[1].Split(new string[] { "</td>" }, StringSplitOptions.None).ToArray()[0].Replace("<td>", "").Replace("\n", ""),
						french = arrays.Split(new string[] { "<th>French</th>" }, StringSplitOptions.None).ToArray()[1].Split(new string[] { "</td>" }, StringSplitOptions.None).ToArray()[0].Replace("<td>", "").Replace("\n", ""),
						japanese = arrays.Split(new string[] { "<th>Japanese</th>" }, StringSplitOptions.None).ToArray()[1].Split(new string[] { "</td>" }, StringSplitOptions.None).ToArray()[0].Replace("<td>", "").Replace("\n", ""),

					},
					type = new Array[] { types },
					baseP = new BasePokemon() { 
						Attack = int.Parse(arrays.Split(new string[] { "<tr>\n<th>Attack</th>\n<td class=\"cell-num\">" }, StringSplitOptions.None).ToArray()[1].Split(new string[] { "</td>\n" }, StringSplitOptions.None).ToArray()[0]), 
						Defense = int.Parse(arrays.Split(new string[] { "\n</tr>\n<tr>\n<th>Defense</th>\n<td class=\"cell-num\">" }, StringSplitOptions.None).ToArray()[1].Split(new string[] { "</td>\n" }, StringSplitOptions.None).ToArray()[0]), 
						HP = int.Parse(arrays.Split(new string[] { "<tr>\n<th>HP</th>\n<td class=\"cell-num\">" }, StringSplitOptions.None).ToArray()[1].Split(new string[] { "</td>\n" }, StringSplitOptions.None).ToArray()[0]), 
						SpAttack = int.Parse(arrays.Split(new string[] { "\n<th>Sp. Atk</th>\n<td class=\"cell-num\">" }, StringSplitOptions.None).ToArray()[1].Split(new string[] { "</td>\n" }, StringSplitOptions.None).ToArray()[0]), 
						SpDefense = int.Parse(arrays.Split(new string[] { "\n<tr>\n<th>Sp. Def</th>\n<td class=\"cell-num\">" }, StringSplitOptions.None).ToArray()[1].Split(new string[] { "</td>\n" }, StringSplitOptions.None).ToArray()[0]), 
						Speed = int.Parse(arrays.Split(new string[] { "\n<th>Speed</th>\n<td class=\"cell-num\">" }, StringSplitOptions.None).ToArray()[1].Split(new string[] { "</td>\n" }, StringSplitOptions.None).ToArray()[0])
					}


				});
				Console.WriteLine(""+data.Count());
			}
			File.WriteAllText("../data.json", JsonConvert.SerializeObject(data));
			Console.WriteLine("");
			//<span class="infocard-lg-img">
			/*{
    "id": 810,
    "name": {
      "english": "Grookey",
      "japanese": "サルノリ",
      "chinese": "Chimpep",
      "french": "Ouistempo"
    },
    "type": [
      "Grass"
    ],
    "base": {
      "HP": 50,
      "Attack": 65,
      "Defense": 50,
      "Sp. Attack": 10,
      "Sp. Defense": 40,
      "Speed": 65
    }*/
		}

		public class DataPokemon
		{
			public int id { get; set; }
			public NamePokemon nameP { get; set; }
			public Array type { get; set; }
			public BasePokemon baseP { get; set; }
		}
		public class NamePokemon
		{
			public string english { get; set; }
			public string japanese { get; set; }
			public string German { get; set; }
			public string french { get; set; }
		}
		public class BasePokemon
		{
			public int HP { get; set; }
			public int Attack { get; set; }
			public int Defense { get; set; }
			public int SpAttack { get; set; }
			public int SpDefense { get; set; }
			public int Speed { get; set; }
		}
	}
}
