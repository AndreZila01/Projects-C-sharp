using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Download_VideoEMusic
{
	public class Music
	{
		public string Name { get; set; }//
		public string Tip { get; set; }//*.mp3, *.mp4
		public string Paths { get; set; }//
		public string Link { get; set; }//
		public string PathsMusic { get; set; }
	}
	public class config
	{
		public string Paths { get; set; }
		public bool AutoRun { get; set; }
		public bool Notification { get; set; }
		public bool CheckedAudio { get; set; }
	}
}
