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
				atl.MusicaAnterior = Musicaant;
				atl.Pausa = Pausa;
				atl.MusicaSeguinte = Musicaseg;
				lstatl.Add(atl);
				st.Atalhos = lstatl;
			}
			st.Paths = paths;
			lstset.Add(st);
			return lstset;
		}
		public List<Classes.PlayList> _listInformacoes = new List<Classes.PlayList>();
		public void CreateFiles(string Paths, bool file)
		{
			if (file == false)
				Directory.CreateDirectory(Paths);
			else
				File.WriteAllText(Paths, "[]");
			//File.CreateText(Paths);
		}

		public List<string> WriteReadMusic(string json, bool readMusic, string settings, bool readSettings, string path)
		{
			var Paths = "";
			var ds = path == "%temp%" ? Paths = "%temp%" : Paths = path;
			PlayList playList = new PlayList();
			List<string> lstConteudo = new List<string>();//0 - Music | 1- Settings | 2 - Possiveis Erros

			try
			{

				if (Paths == "%Temp%")
				{
					Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");
					if (!Directory.Exists(Environment.CurrentDirectory + "/SpotifyClone"))
						CreateFiles(Environment.CurrentDirectory + "/SpotifyClone", false);
					if (!File.Exists(Environment.CurrentDirectory + "/SpotifyClone/Musics.json"))
						CreateFiles(Environment.CurrentDirectory + "/SpotifyClone/Musics.json", true);
					if (!File.Exists(Environment.CurrentDirectory + "/SpotifyClone/Settings.json"))
						CreateFiles(Environment.CurrentDirectory + "/SpotifyClone/Settings.json", true);

					//Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");
					//if (!Directory.Exists(Environment.CurrentDirectory + "/SpotifyClone"))
					//	Directory.CreateDirectory(Environment.CurrentDirectory + "/SpotifyClone");
					//if (!File.Exists(Environment.CurrentDirectory + "/SpotifyClone/Musics.json"))
					//	File.CreateText(Environment.CurrentDirectory + "/SpotifyClone/Musics.json");
					//if (!File.Exists(Environment.CurrentDirectory + "/SpotifyClone/Settings.json"))
					//	File.CreateText(Environment.CurrentDirectory + "/SpotifyClone/Settings.json");
				}
				else
				{
					if (!Directory.Exists(Paths + "/SpotifyClone"))
						CreateFiles(Paths + "/SpotifyClone", false);
					if (!File.Exists(Paths + "/SpotifyClone/Musics.json"))
						CreateFiles(Paths + "/SpotifyClone/Musics.json", true);
					if (!File.Exists(Paths + "/SpotifyClone/Settings.json"))
						CreateFiles(Paths + "/SpotifyClone/Settings.json", true);


					//if (!Directory.Exists(Paths + "/SpotifyClone"))
					//	Directory.CreateDirectory(Paths + "/SpotifyClone");
					//if (!File.Exists(Paths + "/SpotifyClone/Musics.json"))
					//	File.CreateText(Paths + "/SpotifyClone/Musics.json");
					//if (!File.Exists(Paths + "/SpotifyClone/Settings.json"))
					//	File.CreateText(Paths + "/SpotifyClone/Settings.json");
				}
			}
			catch (Exception ex)
			{
				lstConteudo[2] = ex.Message;
			}
			if (lstConteudo.Count() == 0)
			{
				lstConteudo.Add("");
				lstConteudo.Add("");
				lstConteudo.Add("");
			}
			try
			{
				if (readMusic == true)
				{
					if (Paths == "%Temp%")
					{
						var myString = File.ReadAllText(Environment.CurrentDirectory + "/SpotifyClone/Musics.json");
						if (myString != "\"[]\"" || myString != null)
						{
							lstConteudo[0] = myString;
						}
					}
					else
					{
						var myString = File.ReadAllText(Paths + "/SpotifyClone/Musics.json");
						if (myString != "\"[]\"" || myString != null)
						{
							lstConteudo[0] = myString;
						}
					}
				}
				else
				{
					if (json != null)
						if (Paths == "%temp%")
						{
							File.WriteAllText(Environment.CurrentDirectory + "/SpotifyClone/Musics.json", json);
						}
						else
						{
							File.WriteAllText(Paths + "/SpotifyClone/Musics.json", json);
						}
				}
				if (readMusic == false)
				{
					if (Paths == "%Temp%")
						File.WriteAllText(Environment.CurrentDirectory + "/SpotifyClone/Settings.json", settings);
					else
						File.WriteAllText(Paths + "/SpotifyClone/Settings.json", settings);

					using (StreamWriter w = File.AppendText(Environment.CurrentDirectory+"/helper.txt"))
					{
						w.WriteLine(Paths);
						File.SetAttributes(Environment.CurrentDirectory + "/helper.txt", FileAttributes.Hidden);
					}
				}
				else
				{
					if (Paths == "%Temp%")
					{
						var myString = File.ReadAllText(Environment.CurrentDirectory + "/SpotifyClone/Settings.json");
						lstConteudo[1] = myString;
					}
					else
					{
						var myString = File.ReadAllText(Paths + "/SpotifyClone/Settings.json");
						lstConteudo[1] = myString;
					}
				}
			}
			catch (Exception ex)
			{
				lstConteudo[2] = ex.Message;
			}
			return lstConteudo;
		}

	}
}
