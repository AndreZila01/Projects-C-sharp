using FolderSelect;
using MediaToolkit;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace Download_VideoEMusic
{
	public partial class Form1 : Form
	{
		List<Music> ListofMusic = new List<Music>(); List<config> ListConfig = new List<config>(); List<Music> ListofMusicError = new List<Music>(); Music music = new Music(); config Config = new config();
		string FULLname;
		public const int WM_NCLBUTTONDOWN = 0xA1; public const int HT_CAPTION = 0x2;[DllImportAttribute("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);[DllImportAttribute("user32.dll")] public static extern bool ReleaseCapture();
		public Form1()
		{
			InitializeComponent();

			Process[] procs = Process.GetProcessesByName("Download_VideoEMusic");
			if (procs.Length > 1)
				foreach (Process proc in procs)
				{
					if (proc != procs[0])
						proc.Kill();
				}
		}
		private void pictureBox_Click(object sender, EventArgs e)
		{
			PictureBox pct = sender as PictureBox;
			switch (pct.Tag)
			{
				case "expand":
					WindowState = FormWindowState.Maximized;
					pct.Tag = "Diminuir";
					panel2.Size = new Size((this.Height - 400), 348);
					break;
				case "settings":
					if (pnl2.Tag != null)
					{
						pnl2.Visible = false;
						panel2.Visible = false;
						panel3.Visible = false;
						panel3.SendToBack();
						pnl2.Visible = true;
						panel2.Visible = true;
						panel3.Visible = true;
						panel2.BringToFront();
						pnl2.Tag = null;
					}
					else
					{
						pnl2.Visible = false;
						panel2.Visible = false;
						panel3.Visible = false;
						panel2.SendToBack();
						pnl2.Visible = true;
						panel2.Visible = true;
						panel3.Visible = true;
						panel3.BringToFront();
						pnl2.SendToBack();
						pnl2.Tag = "1";
					}
					pnl.Visible = true;
					break;
				case "minimize":
					WindowState = FormWindowState.Minimized;
					break;
				case "close":
					icn.Visible = false;
					Application.Exit();
					break;
				case "Diminuir":
					WindowState = FormWindowState.Normal;
					pct.Tag = "expand";
					panel2.Size = new Size(238, 348);
					break;
			}
			var d = pictureBox2.Tag.ToString() == "Diminuir" ? pictureBox2.Image = Download_VideoEMusic.Properties.Resources.Diminuir : pictureBox2.Image = Download_VideoEMusic.Properties.Resources.expand__;
		}
		private void button_WOC_Click(object sender, EventArgs e)
		{
			pictureBox1.Focus();
			Button btn = sender as Button;
			switch (btn.Text)
			{
				case "Convert":
					try
					{
						GetTitle();
						DownloadVideo();
					}
					catch { DownloadVideo(); }
					break;
				default:
					comboBox1.DroppedDown = true;
					break;
			}
		}
		void GetTitle()
		{
			if (textBox1.Text != string.Empty)
			{
				try
				{
					WebRequest istek = HttpWebRequest.Create(TxtUrl.Text);
					WebResponse yanıt;
					yanıt = istek.GetResponse();
					StreamReader bilgiler = new StreamReader(yanıt.GetResponseStream());
					string gelen = bilgiler.ReadToEnd();
					int baslangic = gelen.IndexOf("<title>") + 7;
					int bitis = gelen.Substring(baslangic).IndexOf("</title>");
					string gelenbilgiler = gelen.Substring(baslangic, bitis);
				}
				catch (Exception ex)
				{
					icn.Visible = false;
					MessageBox.Show("" + ex.Message);
				}
			}
		}
		private void lblProgress_Click(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			switch (lbl.Text)
			{
				case "In Progress":
					pnlInProgress.Visible = true;
					pnlProgressCompleted.Visible = false;
					break;
				case "Progress Completed":
					pnlInProgress.Visible = false;
					pnlProgressCompleted.Visible = true;
					break;
			}

		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			button_WOC1.Text = "" + comboBox1.Text;
			switch (comboBox1.Text)
			{
				case "*.MP3":
					comboBox1.Tag = ".mp3";
					break;
				case "*.MP4":
					comboBox1.Tag = ".mp4";
					break;
				case "*.AVI":
					comboBox1.Tag = ".avi";
					break;
				case "*.FLV":
					comboBox1.Tag = ".flv";
					break;
				case "*.MOV":
					comboBox1.Tag = ".mov";
					break;
				case "*.WMV":
					comboBox1.Tag = ".wmv";
					break;
				case "*.WMA":
					comboBox1.Tag = ".wma";
					break;
			}
		}
		private void pictureBox1_MouseHover(object sender, EventArgs e)
		{
			pictureBox1.Image = Download_VideoEMusic.Properties.Resources.close_red;
		}
		private void pictureBox1_MouseLeave(object sender, EventArgs e)
		{
			pictureBox1.Image = Download_VideoEMusic.Properties.Resources.close_white;
		}
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void backWorker1()
		{
			try
			{
				var inputFile = new MediaToolkit.Model.MediaFile { Filename = textBox1.Text + @"\" + FULLname + ".mp4" };
				var outputFile = new MediaToolkit.Model.MediaFile { Filename = $"{textBox1.Text + @"\" + FULLname}" + comboBox1.Tag.ToString() };
				string path = textBox1.Text + @"\" + FULLname + comboBox1.Tag.ToString();
				using (var enging = new Engine())
				{
					enging.GetMetadata(inputFile);
					enging.Convert(inputFile, outputFile);
				}
				icn.Tag = "True";
			}
			catch (Exception EX)
			{
				icn.Visible = false;
				MessageBox.Show("" + EX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void label_Click(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			panel7.Visible = true;
		}

		private void label5_Click(object sender, EventArgs e)
		{
			flowLayoutPanel1.Controls.Clear();
			ListofMusic.ToList().ForEach(item =>
			{
				Panel pnlAUX = new Panel();
				pnlAUX.BackColor = Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
				pnlAUX.Dock = DockStyle.Top;
				pnlAUX.Location = new Point(0, 0);
				pnlAUX.Size = new Size((flowLayoutPanel1.Width - 10), 42);
				pnlAUX.TabIndex = 0;
				flowLayoutPanel1.Controls.Add(pnlAUX);

				PictureBox pctRemove = new PictureBox();
				pctRemove.Image = global::Download_VideoEMusic.Properties.Resources.close_red;
				pctRemove.Location = new Point((pnlAUX.Width - 35), 9);
				pctRemove.Tag = "" + item.PathsMusic;
				pctRemove.Size = new Size(29, 27);
				pctRemove.SizeMode = PictureBoxSizeMode.Zoom;
				pctRemove.TabIndex = 2;
				pctRemove.Click += picture_click;
				pctRemove.TabStop = false;
				pctRemove.Name = "pctremove";
				pnlAUX.Controls.Add(pctRemove);

				PictureBox pctFile = new PictureBox();
				pctFile.Image = global::Download_VideoEMusic.Properties.Resources.folder1;
				pctFile.Location = new Point((pnlAUX.Width - 70), 9);
				pctFile.Tag = "" + item.Paths;
				pctFile.Size = new Size(29, 27);
				pctFile.SizeMode = PictureBoxSizeMode.Zoom;
				pctFile.TabIndex = 1;
				pctFile.Click += picture_click;
				pctFile.TabStop = false;
				pctFile.Name = "pctfile";
				pnlAUX.Controls.Add(pctFile);

				PictureBox pctplay = new PictureBox();
				pctplay.Image = global::Download_VideoEMusic.Properties.Resources.play;
				pctplay.Location = new Point((pnlAUX.Width - 105), 9);
				pctplay.Tag = "" + item.PathsMusic;
				pctplay.Size = new Size(29, 27);
				pctplay.SizeMode = PictureBoxSizeMode.Zoom;
				pctplay.TabIndex = 1;
				pctplay.Name = "pctplay";
				pctplay.TabStop = false;
				pctplay.Click += picture_click;
				pnlAUX.Controls.Add(pctplay);
				pctplay.BringToFront();

				int lenght;
				var x = FormWindowState.Maximized == this.WindowState ? lenght = 200 : lenght = 55;
				Label LBLAUX = new Label();
				LBLAUX.AutoSize = true;
				LBLAUX.BackColor = SystemColors.ActiveCaption;
				LBLAUX.Location = new Point(17, 16);
				LBLAUX.Name = "LBLAUX";
				LBLAUX.Size = new Size(274, 13);
				LBLAUX.TabIndex = 0;
				try
				{
					LBLAUX.Text = "" + item.Name.Substring(0, lenght) + "           ";
				}
				catch { LBLAUX.Text = "" + item.Name + "           "; }
				pnlAUX.Controls.Add(LBLAUX);
			});
		}
		private void picture_click(object sender, EventArgs e)
		{
			PictureBox picture = sender as PictureBox;
			switch (picture.Name)
			{
				case "pctremove":
					try
					{
						File.Delete(picture.Tag.ToString());
						flowLayoutPanel1.Controls.Clear();
						picture.Click += label5_Click;
					}
					catch (Exception ex)
					{
						icn.Visible = false;
						MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
				case "pctplay":
					try
					{
						Form2 frm = new Form2(picture.Tag.ToString());
						frm.Show();
					}
					catch (Exception ex)
					{
						icn.Visible = false;
						MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
				case "pctfile":
					Process.Start(picture.Tag.ToString());
					break;
				case "pctrefresh":
					try
					{
						textBox1.Text = picture.Tag.ToString();
						GetTitle();
						DownloadVideo();
					}
					catch (Exception ex)
					{
						icn.Visible = false;
						MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
				case "pctBrowser":
					try
					{
						Process.Start(picture.Tag.ToString());
					}
					catch (Exception ex)
					{
						icn.Visible = false;
						MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
			}
		}

		private async void DownloadVideo()
		{
			string path;
			using (var cli = Client.For(YouTube.Default))
			{
				try
				{
					string downloadUri;
					icn.Tag = null;
					String link = TxtUrl.Text;

					if (TxtUrl.Text.Contains("youtu.be/"))
					{
						string[] dss = TxtUrl.Text.Split(new string[] { "youtu.be/" }, StringSplitOptions.None);
						string dsss = dss[0] + "youtube.com/watch?v=" + dss[1];
						link = dsss;
					}
					var videoInfos = await cli.GetAllVideosAsync(link);
					try
					{
						TxtUrl.Text = link;

						var downloadInfo = videoInfos.Where(i => i.Format == VideoFormat.Mp4 && i.Resolution == int.Parse(cboResolucao.Text)).FirstOrDefault(); // if 720p is possible
						downloadUri = downloadInfo.Uri;

						File.WriteAllBytes(textBox1.Text + @"\" + downloadInfo.FullName, /*downloadInfo.GetBytes()*/await downloadInfo.GetBytesAsync());
						FULLname = downloadInfo.FullName;
						FULLname = FULLname.Replace(".mp4", "");
						if (comboBox1.Tag.ToString() != ".mp4")
						{
							backWorker1();
						}
						if (chkAudio.Checked)
						{
							Process.Start(textBox1.Text + @"\" + downloadInfo.FullName);
							if ((MessageBox.Show("Please check if your music or video, have sound.\n If you dont listenning please click in button \"yes\".", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
							{
								TxtUrl.Text = link;
								File.Delete($"{textBox1.Text + @"\" + downloadInfo.FullName}");
								DownloadAux();
							}
						}
					}
					catch (Exception ex)
					{
						if (MessageBox.Show("\"   "+ex.Message + "\"  \r\nError in the download, if you like transfer the music/video, click in button \"Yes\". If you dont like transfer click in button \"No\"", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
						{
							DownloadAux();
						}
					}

				aqui:
					await Task.Delay(100000000);

					if (File.Exists(textBox1.Text + @"\" + FULLname + comboBox1.Tag.ToString()))
						icn.Visible = true;
					else
					{
						await Task.Delay(100000000);
						goto aqui;
					}

					if (chkNotification.Checked)
					{
						icn.Visible = true;
						icn.ShowBalloonTip(1500, "Download Completed", "" + FULLname + ", can listening in this moment!!", ToolTipIcon.Info); icn.Tag = textBox1.Text;
					}
					if (icn.Tag.ToString() != "")
					{
						path = textBox1.Text + @"\" + FULLname + comboBox1.Tag.ToString();
						music.Name = FULLname; music.Tip = comboBox1.Tag.ToString(); music.Paths = textBox1.Text; music.Link = TxtUrl.Text; if (path != string.Empty) music.PathsMusic = path;
						ListofMusic.Add(music);

						if (comboBox1.Tag.ToString() != ".mp4" && !chkAudio.Checked)
							File.Delete($"{textBox1.Text + @"\" + FULLname + ".mp4"}");
					}

					TxtUrl.Text = string.Empty;
					icn.Tag = "";

				}
				catch (Exception ex)
				{
					icn.Visible = false;
					MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				TxtUrl.Text = string.Empty;


			}
		}

		private async void DownloadAux()
		{
			try
			{
				String link = TxtUrl.Text;
				TxtUrl.Text = link;
				var youtube = YouTube.Default;
				var video = await youtube.GetVideoAsync(TxtUrl.Text);
				File.WriteAllBytes(textBox1.Text + @"\" + video.FullName, await video.GetBytesAsync());
				var inputFile = new MediaToolkit.Model.MediaFile { Filename = textBox1.Text + @"\" + video.FullName };
				FULLname = video.FullName.Replace(".mp4", "");
				if (comboBox1.Tag.ToString() != ".mp4")
				{
					var outputFile = new MediaToolkit.Model.MediaFile { Filename = $"{textBox1.Text + @"\" + FULLname}" + comboBox1.Tag.ToString() };
					string path = textBox1.Text + @"\" + FULLname + comboBox1.Tag.ToString();
					using (var enging = new Engine())
					{
						enging.GetMetadata(inputFile);
						enging.Convert(inputFile, outputFile);
					}
					File.Delete($"{textBox1.Text + @"\" + video.FullName}");
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("The video/music, Cannot do download!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				icn.Visible = false;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				if (!(File.Exists(Environment.CurrentDirectory + "\\Paths.json")))
					File.CreateText(Environment.CurrentDirectory + "\\Paths.json");

				Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");
				textBox1.Tag = "Inicio";
				var information = File.ReadAllText(Environment.CurrentDirectory + "\\Paths.json");
				if (information == string.Empty || information == "  ")
				{
					var json = JsonConvert.SerializeObject("[]");
					json = json.Replace("\"", "");
					File.WriteAllText(Environment.CurrentDirectory + "\\Paths.json", json);
				}
				else
					backgroundWorker2.RunWorkerAsync();
				pictureBox2.Click += label5_Click;
			}
			catch
			{
				MessageBox.Show("File dont found!!\nCreate new file, where are save the configurations", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}

		}

		private void label7_Click(object sender, EventArgs e)
		{
			flowLayoutPanel1.Controls.Clear();
			ListofMusicError.ToList().ForEach(item =>
			{
				Panel pnlAUX = new Panel();
				pnlAUX.BackColor = Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
				pnlAUX.Dock = DockStyle.Top;
				pnlAUX.Location = new Point(0, 0);
				pnlAUX.Size = new Size((flowLayoutPanel1.Width - 10), 42);
				pnlAUX.TabIndex = 0;
				flowLayoutPanel1.Controls.Add(pnlAUX);

				PictureBox pctrefresh = new PictureBox();
				pctrefresh.Image = global::Download_VideoEMusic.Properties.Resources.refresh_arrow;
				pctrefresh.Location = new Point((pnlAUX.Width - 35), 9);
				pctrefresh.Tag = "" + item.Link;
				pctrefresh.Size = new Size(29, 27);
				pctrefresh.SizeMode = PictureBoxSizeMode.Zoom;
				pctrefresh.TabIndex = 2;
				pctrefresh.Click += picture_click;
				pctrefresh.TabStop = false;
				pctrefresh.Name = "pctrefresh";
				pnlAUX.Controls.Add(pctrefresh);

				PictureBox pctBrowser = new PictureBox();
				pctBrowser.Location = new Point((pnlAUX.Width - 70), 9);
				pctBrowser.Image = global::Download_VideoEMusic.Properties.Resources.globe;
				pctBrowser.Tag = "" + item.Link;
				pctBrowser.Size = new Size(29, 27);
				pctBrowser.SizeMode = PictureBoxSizeMode.Zoom;
				pctBrowser.Click += picture_click;
				pctBrowser.TabStop = false;
				pctBrowser.Name = "pctBrowser";
				pnlAUX.Controls.Add(pctBrowser);

				TextBox text = new TextBox();
				var x = FormWindowState.Maximized == this.WindowState ? text.Tag = 200 : text.Tag = 55;
				text.AutoSize = true;
				text.BackColor = SystemColors.ActiveCaption;
				text.Location = new Point(17, 16);
				text.Name = "LBLAUX";
				text.Size = new Size(274, 13);
				text.TabIndex = 0;
				text.ReadOnly = true;
				text.Text = "" + item.Link;
				pnlAUX.Controls.Add(text);
			});
		}

		private void ckbAuto_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (checkBox.Text == "Auto Run (Open with windows)")
			{
				RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				if (ckbAuto.Checked)
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					rkApp.SetValue("Download VideoMusic", Application.ExecutablePath.ToString());
				}
				else
					rkApp.DeleteValue("Download VideoMusic", false);
			}
			if (textBox1.Text != "")
				update();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			var fsd = new FolderSelectDialog();
			fsd.Title = "Select where you save your musics or videos";
			fsd.InitialDirectory = @"c:\";
			if (fsd.ShowDialog(IntPtr.Zero))
			{
				textBox1.Text = fsd.FileName;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Check if have update!!", "Update!?!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Process.Start("https://github.com/AndreZila01/Projects-C-sharp");
		}

		private void ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStrip = sender as ToolStripMenuItem;

			switch (toolStrip.Text)
			{
				case "Settings":
					if (panel3.Visible == false)
						panel3.Visible = true;
					else
						panel3.Visible = false;
					break;
				case "View Music":
					if (textBox1.Text != "")
						Process.Start(textBox1.Text);
					else
						MessageBox.Show("Go to settings, and select the paths, where you save your musics!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				case "Exit":
					icn.Visible = false;
					Application.Exit();
					break;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");
			try
			{
				if (!(File.Exists(Environment.CurrentDirectory + "\\Paths.json")))
					File.CreateText(Environment.CurrentDirectory + "\\Paths.json");
				update();
			}
			catch
			{
				icn.Visible = false;
			}

		}

		private void update()
		{
			try
			{
				Config.AutoRun = ckbAuto.Checked;
				Config.Notification = chkNotification.Checked;
				Config.CheckedAudio = chkAudio.Checked;
				Config.Paths = textBox1.Text;

				ListConfig.Clear();
				ListConfig.Add(Config);

				string json = JsonConvert.SerializeObject(ListConfig);
				File.WriteAllText(Environment.CurrentDirectory + "\\Paths.json", json);
			}
			catch (Exception ex)
			{
				icn.Visible = false;
				MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void icn_BalloonTipClicked(object sender, EventArgs e)
		{
			NotifyIcon icn = sender as NotifyIcon;
			Process.Start(icn.Tag.ToString());
		}

		private void checkBox1_MouseHover(object sender, EventArgs e)
		{
			label11.Visible = true;
		}

		private void checkBox1_MouseLeave(object sender, EventArgs e)
		{
			label11.Visible = false;
		}

		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			var myString = File.ReadAllText(Environment.CurrentDirectory + "\\Paths.json"); ListConfig = JsonConvert.DeserializeObject<List<config>>(myString);

			ckbAuto.Checked = ListConfig[0].AutoRun;
			chkNotification.Checked = ListConfig[0].Notification;
			chkAudio.Checked = ListConfig[0].CheckedAudio;
			textBox1.Text = ListConfig[0].Paths;
		}
	}
}
