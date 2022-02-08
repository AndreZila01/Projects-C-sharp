using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace Spotify_Clone.Classes
{
	public class Backend
	{
		public List<Settings> UpdateSettings(string Idioma, int AutoRun, int Discord, int EnviarNome, int Duracao, int Atalho, int Mini, int NotifMusi, string Musicaant, string Pausa, string Musicaseg, string paths, string XAMPP) { List<Discord> lstDisc = new List<Discord>(); List<Atalho> lstatl = new List<Atalho>(); List<Settings> lstset = new List<Settings>(); Settings st = new Settings(); st.Idioma = Idioma; st.AutoRun = AutoRun; st.disc = Discord; st.Minimizar = Mini; st.NotifMusic = NotifMusi; if (st.disc != 0) { Discord disc = new Discord(); disc.EnviarNome = EnviarNome; disc.Duracao = Duracao; lstDisc.Add(disc); st.discord = lstDisc; } st.atal = Atalho; if (st.atal != 0) { Atalho atl = new Atalho(); if (Musicaant != "Clicar no botão se acabares") atl.MusicaAnterior = Musicaant; if (Pausa != "Clicar no botão se acabares") atl.Pausa = Pausa; if (Musicaseg != "Clicar no botão se acabares") atl.MusicaSeguinte = Musicaseg; lstatl.Add(atl); st.Atalhos = lstatl; } st.Paths = paths; st.XAMPP = XAMPP; lstset.Add(st); return lstset; }
		private void CreateFiles(string Paths, bool file) { if (file == false) Directory.CreateDirectory(Paths); else File.WriteAllText(Paths, ("[]")); }
		private void CheckFiles(string paths) { if (!Directory.Exists(paths + "/SpotifyClone")) CreateFiles(paths + "/SpotifyClone", false); if (!File.Exists(paths + "/SpotifyClone/Musics.json")) CreateFiles(paths + "/SpotifyClone/Musics.json", true); if (!File.Exists(paths + "/SpotifyClone/Settings.json")) CreateFiles(paths + "/SpotifyClone/Settings.json", true); }
		public List<Settings> WriteReadSettings(string path, bool readSettings, string settings) { string Paths = ""; string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt") && path == null) { Paths = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt"); CheckFiles(Paths); } else { var ds = path == "%appdata%" ? Paths = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) : Paths = path; CheckFiles(Paths); } if (readSettings == true) { var myString = EncryptADeDecrypt.DecryptString(Properties.Resources.Key, (File.ReadAllText(Paths + "/SpotifyClone/Settings.json"))); return JsonConvert.DeserializeObject<List<Settings>>(myString); } else { File.WriteAllText(Paths + "/SpotifyClone/Settings.json", EncryptADeDecrypt.EncryptOther(settings)); if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt")) File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt"); if (!(Paths.Contains("Roaming"))) using (StreamWriter w = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt")) { string fileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt"; w.Write(path); File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt", FileAttributes.Hidden); } return null; } }
		public List<PlayList> WriteReadMusic(bool readMusic, string path, List<PlayList> play, int IdPlaylist) { var Paths = ""; var ds = path == "%appdata%" ? Paths = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) : Paths = path; PlayList playList = new PlayList(); List<PlayList> lstConteudo = new List<PlayList>(); try { if (!Paths.Contains("json")) CheckFiles(Paths); } catch { } try { if (readMusic == true) { { string myString = EncryptADeDecrypt.DecryptString(Properties.Resources.Key, File.ReadAllText(Paths + "/SpotifyClone/Musics.json")); if (myString != "\"[]\"" || myString != null) lstConteudo = JsonConvert.DeserializeObject<List<PlayList>>(myString.ToString()); } } else { string info = JsonConvert.SerializeObject(play); File.WriteAllText(Paths + "/SpotifyClone/Musics.json", EncryptADeDecrypt.EncryptOther(info)); } } catch { } return lstConteudo; }
		List<double> ProduceRandom = new List<double>(); public List<double> RandomMusic(int IdPlayList, List<PlayList> _lst)
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
		public int Atalho(string[] Atalho, string keybind)
		{
			int index = -1;
			Atalho.ToList().ForEach(item =>
			{
				int temp = 0;
				item.Split('+').ToArray().ToList().ForEach(key =>
				{
					try
					{
						if (key.ToString() == keybind.Split('+').ToArray()[temp])
						{

						}
						temp++;
					}
					catch { }
				});
			});

			return 0;
		}

		public void Xampp(string Paths, List<PlayList> lst) { List<Xampp> lstXampp = new List<Xampp>(); Paths += @"\htdocs"; try { if (!(File.Exists(Paths + @"\.htaccess"))) File.WriteAllText(Paths + @"\.htaccess", ("Header Set Access-Control-Allow-Origin \"*\"")); } catch { } try { if (Directory.Exists(Paths + @"\Spotify_Clone_Music")) Directory.Delete(Paths + @"\Spotify_Clone_Music", true); } catch { } try { if (!(Directory.Exists(Paths + @"\Spotify_Clone_Music"))) Directory.CreateDirectory(Paths + @"\Spotify_Clone_Music"); } catch { } string myIP = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString(); lst.ToList().ForEach(item => { try { Xampp xp = new Xampp(); List<string> st = new List<string>(); lst[(item.IDList - 1)].Caminho_da_Musica.ToList().ForEach(items => { string[] name = items.Split('\\'); if (!(Directory.Exists(Paths + @"\Spotify_Clone_Music\" + lst[(item.IDList - 1)].Name + @"\" + name[name.Length - 2]))) Directory.CreateDirectory(Paths + @"\Spotify_Clone_Music\" + lst[(item.IDList - 1)].Name + @"\" + name[name.Length - 2]); string destinationFile = Paths + @"\Spotify_Clone_Music\" + lst[(item.IDList - 1)].Name + @"\" + name[(name.Length - 2)] + @"\" + name[(name.Length - 1)]; if (!File.Exists(destinationFile)) File.Copy(items, destinationFile); st.Add("http://" + myIP + @"\Spotify_Clone_Music\" + lst[(item.IDList - 1)].Name + @"\" + name[(name.Length - 2)] + @"\" + name[(name.Length - 1)]); }); xp.NomePlay = "" + lst[(item.IDList - 1)].Name; xp.PathsXampp = st; if (lstXampp.Count() == 0) xp.IpUser = myIP; lstXampp.Add(xp); } catch { } }); if (lstXampp.Count > 0) { if (!(File.Exists(Paths + @"\Paths.json"))) File.Delete(Paths + @"\Paths.json"); File.WriteAllText(Paths + @"\Paths.json", (JsonConvert.SerializeObject(lstXampp))); } if (!(File.Exists(Paths + @"\Spotify Clone.html"))) File.Delete(Paths + @"\Spotify Clone.html"); File.WriteAllText(Paths + @"\Spotify Clone.html", "<html><style>#fixo{position:fixed;bottom:0px;left:0;background:CadetBlue;margin-left:0%;}body{margin:0px;margin-bottom:0px;}img{align-items:center;margin-left:5%;height:100%;position:relative;}.child{width:80%;height:55%;text-align:center;background-color:rgb(1,154,158);}#video{text-align:center;}</style><head><meta name=\"viewport\"content=\"width=device-width,initial-scale=1.0\"><title>Spotify Clone</title><link rel=\"icon\"href=\"https://raw.githubusercontent.com/AndreZila01/Projects-C-sharp/master/Spotify_Clone/NewVersion/Spotify_Clone_Site/Spotify.webp\"></head><body name=\"Teste\"><script>var vid=document.getElementById(\"myVideo\");var index=0;var lstValue=0;var xmlHttp=new XMLHttpRequest();xmlHttp.open(\"GET\",\"http://" + myIP + "/Paths.json\",false);xmlHttp.send(null);var lst=(JSON.parse((xmlHttp.responseText).replace(\"#\",\"%23\")));</script><div style=\"background-color:rgb(1,154,158);width:100%;height:20%;max-height:20%;\"><div style=\"top:25%;position:relative;background-color:rgb(1,154,158);\"><div style=\"max-width:50%;height:25%;position:relative;top:30%;left:25%;text-align:center;\"><label style=\"background-color:rgb(1,230,236);font-size:95%;font-family:'Times New Roman',Times,serif;\"id=\"NomeMusic\"></label></div></div></div><div style=\"background-color:rgb(1,192,197);width:100%;height:65%;max-height:65%;\"style=\"position:relative;\"><video width=\"80%\"height=\"70%\"style=\"margin-right:10%;margin-left:10%;margin-top:5%;position:relative;\"controls autoplay id=\"myVideo\"><source src=\"\"></video></div><div style=\"background-color:rgb(1,154,158);width:100%;height:15%;max-height:35%;\"id=\"fixo\"><div><div style=\"width:50%;height:25%;position:relative;bottom:20%;left:25%;right:25%;\"></div><div class=\"child\"style=\"vertical-align:middle;\"><img id=\"previou\"style=\"margin-left:25%;\"src=\"https://github.com/AndreZila01/Projects-C-sharp/blob/master/Spotify_Clone/NewVersion/Spotify%20Clone/Resources/previousB.png?raw=true\"></img><img id=\"pauseEplay\"name=\"Play\"src=\"https://github.com/AndreZila01/Projects-C-sharp/blob/master/Spotify_Clone/NewVersion/Spotify%20Clone/Resources/playB.png?raw=true\"></img><img id=\"next\"src=\"https://github.com/AndreZila01/Projects-C-sharp/blob/master/Spotify_Clone/NewVersion/Spotify%20Clone/Resources/nextB.png?raw=true\"></img></div></div></div></body><script type='text/javascript'>var vid=document.getElementById(\"myVideo\");var lblNome=document.getElementById(\"NomeMusic\");vid.volume=0.5;document.getElementById('myVideo').addEventListener('ended',myHandler,false);function myHandler(){index++;var vid=document.getElementById(\"myVideo\");if(lst[lstValue].PathsXampp.length==index){lstValue++;index=0;}vid.src=lst[lstValue].PathsXampp[index];vid.load();}window.onload=function(){var index=0;document.getElementById('myVideo').addEventListener('ended',myHandler,false);video();};document.getElementById('pauseEplay').addEventListener('click',function(e){var pct=document.getElementById(\"pauseEplay\");if(pct.name==\"Pause\"){vid.pause();pct.name=\"Play\";pct.src=\"https://github.com/AndreZila01/Projects-C-sharp/blob/master/Spotify_Clone/NewVersion/Spotify%20Clone/Resources/playB.png?raw=true\";}else{vid.play();pct.name=\"Pause\";pct.src=\"https://github.com/AndreZila01/Projects-C-sharp/blob/master/Spotify_Clone/NewVersion/Spotify%20Clone/Resources/pauseB.png?raw=true\";}});document.getElementById('next').addEventListener('click',function(e){index++;if((lst.length-1)==lstValue&&(lst[lstValue].PathsXampp.length)==index){lstValue=0;index=0;}if(lst[lstValue].PathsXampp.length==index){lstValue++;index=0;}video();var pct=document.getElementById(\"pauseEplay\");pct.src=\"https://github.com/AndreZila01/Projects-C-sharp/blob/master/Spotify_Clone/NewVersion/Spotify%20Clone/Resources/pauseB.png?raw=true\";});document.getElementById('previou').addEventListener('click',function(e){index--;if((lst[lstValue].PathsXampp.length)==index){lstValue--;index=lst[lstValue].length;}if(index==-1&&lstValue==0){lstValue=(lst.length-1);index=(lst[lstValue].PathsXampp.length-1);}if(index==-1){lstValue--;index=(lst[lstValue].PathsXampp.length-1);}video();var pct=document.getElementById(\"pauseEplay\");pct.src=\"https://github.com/AndreZila01/Projects-C-sharp/blob/master/Spotify_Clone/NewVersion/Spotify%20Clone/Resources/pauseB.png?raw=true\";});function video(){vid.src=lst[lstValue].PathsXampp[index];vid.load();var ds=lst[lstValue].PathsXampp[index].split(\"\\\\\");document.getElementById(\"NomeMusic\").innerHTML=lst[lstValue].NomePlay+\"<br>\"+ds[ds.length-1].slice(0,ds[ds.length-1].length-4).replace(\"%23\",\"#\");}</script></html>"); }
	}
}