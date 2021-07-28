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
		public List<Settings> UpdateSettings(string Idioma, int AutoRun, int Discord, int EnviarNome, int Duracao, int Atalho, string Musicaant, string Pausa, string Musicaseg)
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

			lstset.Add(st);
			return lstset;
		}

		public string Write(string json, bool read)
		{
			Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");
			if (File.Exists(Environment.CurrentDirectory + "/Musics.json"))
				File.CreateText(Environment.CurrentDirectory + "Musics.json");
			if (Directory.Exists(Environment.CurrentDirectory + "/SpotifyClone"))
				Directory.CreateDirectory(Environment.CurrentDirectory + "/SpotifyClone");
			if (File.Exists(Environment.CurrentDirectory + "/Settings.json"))
				File.CreateText(Environment.CurrentDirectory + "Settings.json");



			return null;
		}

	}
}
