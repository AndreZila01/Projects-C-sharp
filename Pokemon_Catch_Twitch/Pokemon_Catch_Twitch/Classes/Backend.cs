using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Catch_Twitch.Classes
{
	public class Data
	{
		public void CheckFiles(string paths) { if (!Directory.Exists(paths + "/SpotifyClone")) CreateFiles(paths + "/SpotifyClone", false); if (!File.Exists(paths + "/SpotifyClone/Musics.json")) CreateFiles(paths + "/SpotifyClone/Musics.json", true); if (!File.Exists(paths + "/SpotifyClone/Settings.json")) CreateFiles(paths + "/SpotifyClone/Settings.json", true); }
		public void CreateFiles(string Paths, bool file) { if (file == false) Directory.CreateDirectory(Paths); else File.WriteAllText(Paths, ("[]")); }
		//public List<PlayList> WriteReadMusic(bool readMusic, string path, List<PlayList> play, int IdPlaylist) { var Paths = ""; var ds = path == "%appdata%" ? Paths = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) : Paths = path; PlayList playList = new PlayList(); List<PlayList> lstConteudo = new List<PlayList>(); try { if (!Paths.Contains("json")) CheckFiles(Paths); } catch { } try { if (readMusic == true) { { string myString = EncryptADeDecrypt.DecryptString(Properties.Resources.Key, File.ReadAllText(Paths + "/SpotifyClone/Musics.json")); if (myString != "\"[]\"" || myString != null) lstConteudo = JsonConvert.DeserializeObject<List<PlayList>>(myString.ToString()); } } else { string info = JsonConvert.SerializeObject(play); File.WriteAllText(Paths + "/SpotifyClone/Musics.json", EncryptADeDecrypt.EncryptOther(info)); } } catch { } return lstConteudo; }

	}
}
