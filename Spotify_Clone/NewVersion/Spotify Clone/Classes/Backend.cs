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
		public List<Settings> UpdateSettings(string Idioma, int AutoRun, int Discord, int EnviarNome, int Duracao, int Atalho, int Mini, int NotifMusi, string Musicaant, string Pausa, string Musicaseg, string paths, string XAMPP)
		{
			List<Discord> lstDisc = new List<Discord>(); List<Atalho> lstatl = new List<Atalho>(); List<Settings> lstset = new List<Settings>(); Settings st = new Settings();

			st.Idioma = Idioma; st.AutoRun = AutoRun; st.disc = Discord; st.Minimizar = Mini; st.NotifMusic = NotifMusi;
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
			st.XAMPP = XAMPP;
			lstset.Add(st);
			return lstset;
		}

		private void CreateFiles(string Paths, bool file)
		{
			if (file == false)
				Directory.CreateDirectory(Paths);
			else
				File.WriteAllText(Paths, /*EncryptADeDecrypt.EncryptOther*/("[]"));

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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt"))
					File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt");
				if (!(Paths.Contains("Roaming")))
					using (StreamWriter w = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt"))
					{
						string fileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt";
						w.Write(path);
						File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt", FileAttributes.Hidden);
					}

				return null;
			}
		}
		public List<PlayList> WriteReadMusic(bool readMusic, string path, List<PlayList> play, int IdPlaylist)
		{
			var Paths = "";
			var ds = path == "%appdata%" ? Paths = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) : Paths = path/*.Replace("\r\n", "")*/;//remover \r\n
			PlayList playList = new PlayList();
			List<PlayList> lstConteudo = new List<PlayList>();

			try
			{
				if (!Paths.Contains("json"))
					CheckFiles(Paths);
			}
			catch { }
			try
			{
				if (readMusic == true)
				{
					{
						string myString = EncryptADeDecrypt.DecryptString(Properties.Resources.Key, File.ReadAllText(Paths + "/SpotifyClone/Musics.json"));
						if (myString != "\"[]\"" || myString != null)
							lstConteudo = JsonConvert.DeserializeObject<List<PlayList>>(myString.ToString());

					}
				}
				else
				{
					string info = JsonConvert.SerializeObject(play);
					File.WriteAllText(Paths + "/SpotifyClone/Musics.json", EncryptADeDecrypt.EncryptOther(info));
				}
			}
			catch { }
			return lstConteudo;
		}
		List<double> ProduceRandom = new List<double>();
		public List<double> RandomMusic(int IdPlayList, List<PlayList> _lst)
		{

			_lst[IdPlayList].Caminho_da_Musica.ToList().ForEach(item =>
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

		public void Xampp(string Paths, List<PlayList> lst)
		{
			List<Xampp> lstXampp = new List<Xampp>();
			Paths += @"\htdocs";
			if (!(File.Exists(Paths + @"\.htaccess")))
				File.WriteAllText(Paths + @"\.htaccess", ("Header Set Access-Control-Allow-Origin \"*\""));
			if (!(Directory.Exists(Paths + @"\Spotify_Clone_Music")))
				Directory.CreateDirectory(Paths + @"\Spotify_Clone_Music");


			//lst.ToList().ForEach(item=>
			//{
			//	string[] name = item.Caminho_da_Musica[index].Split('\\');
			//	string destinationFile = Paths + @"\Spotify_Clone_Music\" + name[(name.Length - 1)];
			//	if (!File.Exists(destinationFile))
			//		File.Copy(item.Caminho_da_Musica[index], destinationFile);
			//	index++;
			//});
			lst.ToList().ForEach(item =>
			{
				try
				{
					Xampp xp = new Xampp(); List<string> st = new List<string>();
					lst[(item.IDList - 1)].Caminho_da_Musica.ToList().ForEach(items =>
					{
						string[] name = items.Split('\\');
						if (!(Directory.Exists(Paths + @"\Spotify_Clone_Music\" + lst[(item.IDList - 1)].Name + @"\" + name[name.Length - 2])))
							Directory.CreateDirectory(Paths + @"\Spotify_Clone_Music\" + lst[(item.IDList - 1)].Name + @"\" + name[name.Length - 2]);
						string destinationFile = Paths + @"\Spotify_Clone_Music\" + lst[(item.IDList - 1)].Name + @"\" + name[(name.Length - 2)] + @"\" + name[(name.Length - 1)];
						if (!File.Exists(destinationFile))
							File.Copy(items, destinationFile);
						st.Add(destinationFile);
					});
					xp.NomePlay = "" + lst[(item.IDList - 1)].Name;
					xp.PathsXampp = st;

					lstXampp.Add(xp);
				}
				catch { }
			});

			if (lstXampp.Count > 0)
			{
				if (!(File.Exists(Paths + @"\Paths.json")))
					File.Delete(Paths + @"\Paths.json");

				File.WriteAllText(Paths + @"\Paths.json", (JsonConvert.SerializeObject(lstXampp)));
			}
		}
	}
}
