using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone.Classes
{
	public class Backend
	{
		public List<Settings> UpdateSettings(string Idioma, int AutoRun, int Discord, int EnviarNome, int Duracao, int Atalho, string Musicaant, string Pausa, string Musicaseg, string paths)
		{
			List<Discord> lstDisc = new List<Discord>(); List<Atalho> lstatl = new List<Atalho>(); List<Settings> lstset = new List<Settings>(); Settings st = new Settings();

			st.Idioma = Idioma; st.AutoRun = AutoRun; st.disc = Discord;
			if (st.disc != 0)
			{
				Discord disc = new Discord();
				disc.EnviarNome = EnviarNome;
				disc.Duracao = Duracao;
				lstDisc.Add(disc);
				st.discord = lstDisc;
			}
			st.atal = Atalho;
			if (st.atal != 0)
			{
				Atalho atl = new Atalho();
				if (Musicaant != "Clicar no botão se acabares")
					atl.MusicaAnterior = Musicaant;
				if (Pausa != "Clicar no botão se acabares")
					atl.Pausa = Pausa;
				if (Musicaseg != "Clicar no botão se acabares")
					atl.MusicaSeguinte = Musicaseg;
				lstatl.Add(atl);
				st.Atalhos = lstatl;
			}
			st.Paths = paths;
			lstset.Add(st);
			return lstset;
		}

		private void CreateFiles(string Paths, bool file)
		{
			if (file == false)
				Directory.CreateDirectory(Paths);
			else
				File.WriteAllText(Paths, EncryptADeDecrypt.EncryptOther("[]"));

		}

		private void CheckFiles(string paths)
		{
			if (!Directory.Exists(paths + "/SpotifyClone"))
				CreateFiles(paths + "/SpotifyClone", false);
			if (!File.Exists(paths + "/SpotifyClone/Musics.json"))
				CreateFiles(paths + "/SpotifyClone/Musics.json", true);
			if (!File.Exists(paths + "/SpotifyClone/Settings.json"))
				CreateFiles(paths + "/SpotifyClone/Settings.json", true);
		}

		public List<Settings> WriteReadSettings(string path, bool readSettings, string settings)
		{
			string Paths = "";
			string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt") && path == null)
			{
				Paths = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt");
				CheckFiles(Paths);
			}
			else
			{
				var ds = path == "%appdata%" ? Paths = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) : Paths = path;
				CheckFiles(Paths);
			}
			if (readSettings == true)
			{
				var myString = EncryptADeDecrypt.DecryptString(Properties.Resources.Key, (File.ReadAllText(Paths + "/SpotifyClone/Settings.json")));
				return JsonConvert.DeserializeObject<List<Settings>>(myString);
			}
			else
			{
				File.WriteAllText(Paths + "/SpotifyClone/Settings.json", EncryptADeDecrypt.EncryptOther(settings));

				if (!(Paths.Contains("Roaming")))
					using (StreamWriter w = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt"))
					{
						w.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
						File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt", FileAttributes.Hidden);
					}

				return null;
			}
		}
		public List<PlayList> WriteReadMusic(string json, bool readMusic, string path)
		{
			var Paths = "";
			var ds = path == "%appdata%" ? Paths = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) : Paths = path;
			PlayList playList = new PlayList();
			List<PlayList> lstConteudo = new List<PlayList>();

			try
			{
				if (!Paths.Contains("json"))
					CheckFiles(Paths);
			}
			catch (Exception ex)
			{
				//lstConteudo[2] = ex.Message;
			}
			if (lstConteudo.Count() == 0)
			{

			}
			try
			{
				if (readMusic == true)
				{
					{
						string myString = /*EncryptADeDecrypt.DecryptOther*/(File.ReadAllText(@"C:\Users\andre\AppData\Local\Temp\Musics.json"/*Paths + "/SpotifyClone/Musics.json"*/));
						if (myString != "\"[]\"" || myString != null)
						{
							//myString.Replace(@"\\", @"\");
							lstConteudo = JsonConvert.DeserializeObject<List<PlayList>>(myString.ToString());
						}
					}
				}
				else
				{
					if (json != null)
					{
						File.WriteAllText(Paths + "/SpotifyClone/Musics.json", /*EncryptADeDecrypt.EncryptOther*/json);
					}
				}
			}
			catch (Exception ex)
			{
				//lstConteudo[2] = ex.Message;
			}
			return lstConteudo;
		}


		List<double> ProduceRandom = new List<double>();
		public List<double> RandomMusic(int IdPlayList, List<PlayList> _lst)
		{
			//foreach (string a in _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica)
			//	Ordem_de_Reproducao.Add(0.0001);
			//ProduceRandom.Add(0);
			//ProduceRandom.RemoveAt(1);
			_lst[IdPlayList].Caminho_da_Musica.ToList().ForEach(item =>//for (int d = 0; d < _lst[(IdPlayList)].Caminho_da_Musica.Count(); d++)
			{
				aqui:
				Random rd = new Random();
				int r = rd.Next(0, _lst[(IdPlayList)].Caminho_da_Musica.Count());
				try
				{
					if ((!ProduceRandom.Contains(r)))
						ProduceRandom.Add(r);
					else
						goto aqui;
				}
				catch
				{
					ProduceRandom.Add(r);
				}
			});
			return ProduceRandom;
		}
	}
}
