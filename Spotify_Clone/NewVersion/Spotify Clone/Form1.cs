using AudioSwitcher.AudioApi.CoreAudio;
using Newtonsoft.Json;
using Spotify_Clone.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using WMPLib;
using DiscordRpcDemo;
using Gma.System.MouseKeyHook;
using FolderSelect;

namespace Spotify_Clone
{

	public partial class Form1 : Form
	{
		private DiscordRpc.EventHandlers handlers;
		private DiscordRpc.RichPresence presence;
		#region OLD SOURCE
		const int WS_MINIMIZEBOX = 0x20000;
		const int CS_DBLCLKS = 0x8;

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		[DllImportAttribute("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")] public static extern bool ReleaseCapture();

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.Style |= WS_MINIMIZEBOX;
				cp.ClassStyle |= CS_DBLCLKS;
				return cp;
			}
		}
		public static int IdPlayList, ecra = 0;
		private bool atualizacao, musica;
		public List<string> PlaydaLista = new List<string>();
		public List<Classes.PlayList> _listInformacoes = new List<Classes.PlayList>();
		public List<string> _Caminho_Musica = new List<string>();
		public List<double> Ordem_de_Reproducao = new List<double>();
		int dt;
		bool FormVideo = false;
		public static string[] NameMusic;
		public static string Processo = "", Posicao = "", CaMusica = "", Volume = "";
		Video fmr = new Video(); Backend bk = new Backend();
		public static int t;
		private void Lbl_Click(object sender, EventArgs e) { Label lbl = sender as Label; IdPlayList = (int)lbl.Tag; MusicaPlay(); }

		private void pnl_Click(object sender, EventArgs e)
		{
			Panel pnl = sender as Panel;
			switch (pnl.Name)
			{
				case "ds":
					IdPlayList = (int)pnl.Tag;
					MusicaPlay();
					break;
				case "pnlDown":
					this.Tag = "MusicaPlayD";
					if (!bgwCarregar.IsBusy) bgwCarregar.RunWorkerAsync();
					break;
			}
		}
		private void btnPlayMusic_Click(object sender, EventArgs e)
		{
			Random rd = new Random();
			int r; r = rd.Next(0, ((_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1)));
			pE_PauseaPlay.Image = Properties.Resources.pause; pE_PauseaPlay.Tag = "0";
			t = 0;
			labelControl2.Text = string.Empty;
			picForm3.Tag = "" + IdPlayList;

			if (pE_Random.Tag.ToString() == "0")
			{
				Ordem_de_Reproducao.Clear();
				for (int a = 0; a < _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count(); a++)
				{
					if (r >= _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count())
						r = 0;

					Ordem_de_Reproducao.Add(r);
					r++;
				}
			}
			pE_Next.Enabled = true;
			pE_PauseaPlay.Enabled = true;
			pE_previous.Enabled = true;
			r = rd.Next(0, ((_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1)));
			if (FormVideo == false)
			{
				try
				{
					axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[r]];
					NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[(r)]].Split(new string[] { "\\" }, StringSplitOptions.None);
				}
				catch
				{
					axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[0]];
					NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[(0)]].Split(new string[] { "\\" }, StringSplitOptions.None);
				}
				int TAMANHO = NameMusic.Length;
				int k = NameMusic[TAMANHO - 1].Count() - 4;
				string s = NameMusic[TAMANHO - 1].Substring(0, k);
				labelControl2.Text = s;
				axWindowsMediaPlayer1.Ctlcontrols.play();
				labelControl2.Tag = "" + r;
				//PBC.Maximum = a
				timer1.Start();
			}
			else
			{
				pE_PauseaPlay.Image = Properties.Resources.pause;
				pE_PauseaPlay.Tag = "0";
				CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[r]];
				Volume = labelControl4.Text;
				Processo = "start";
				NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[r]].Split(new string[] { "\\" }, StringSplitOptions.None);
				labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
				fmr.timer1_Tick(sender, e);
				timer1.Stop();
			}
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt"))
					txtPaths.Text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt");
				Backend bk = new Backend();
				List<Settings> lst = bk.WriteReadSettings(txtPaths.Text, true, "");
				SaveSettings(lst[0]);

				List<PlayList> lstM = bk.WriteReadMusic(true, txtPaths.Text, null, -1);
				//bk.CreateFiles(txtPaths.Text, true);
			}
			catch (Exception ex)
			{

			}
		}
		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			//Atualiza();
			if (backgroundWorker1.IsBusy) backgroundWorker1.CancelAsync();
			while (backgroundWorker1.IsBusy) Application.DoEvents();
		}

		private void ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			switch (((ToolStripMenuItem)sender).Name)
			{
				case "TSMIRemove":
					{
						try
						{
							if (picInfos.Tag != null)
								if (int.Parse(picInfos.Tag.ToString()) == (int)((ToolStripMenuItem)sender).Tag)
								{
									PBC.Value = 0;
									labelControl2.Text = "";
									labelControl2.Tag = "";
									axWindowsMediaPlayer1.URL = null;
									pE_Random.Enabled = false;
									timer1.Stop();
									timer2.Stop();
									pE_Random.Tag = 0;
									pE_PauseaPlay.Tag = 0;
									pE_PauseaPlay.Image = Properties.Resources.play;
									pE_Random.Image = Properties.Resources.change;
									axWindowsMediaPlayer1.Visible = false;
									if (FormVideo == true)
									{
										FormCollection fc = Application.OpenForms;
										foreach (Form frm in fc)
										{
											if (frm.Name == "Video")
												frm.Close();
										}
									}
								}
							if ((IdPlayList) == ((int)((ToolStripMenuItem)sender).Tag) && (pE_PauseaPlay.Tag.ToString()) != "0")
							{
								labelControl2.Text = "";
								IdPlayList = 0;
								PBC.Value = 0;
								timer1.Stop();
								timer2.Stop();
								axWindowsMediaPlayer1.URL = "";
							}
							IdPlayList = (int)((ToolStripMenuItem)sender).Tag;
							_listInformacoes.Remove(_listInformacoes.FirstOrDefault(row => row.IDList == (int)((ToolStripMenuItem)sender).Tag));
							_listInformacoes.ToList().ForEach(item =>
							{
								if (item.IDList > IdPlayList)
									item.IDList--;
							});
							var json = JsonConvert.SerializeObject(_listInformacoes);
							if (txtPaths.Text == "%appdata%")
								txtPaths.Text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
							File.WriteAllText(txtPaths.Text + "/SpotifyClone/Musics.json", json);
							Atualiza();
						}
						catch (Exception ex) { Atualiza(); }
					}
					break;
				case "TSMIEditPlayList":
					try
					{
						atualizacao = true;
						IdPlayList = (int)((ToolStripMenuItem)sender).Tag;
						AuxForm2(((ToolStripMenuItem)sender).Tag);
					}
					catch { }
					break;
			}
		}
		private void AuxForm2(object tag)
		{
			try
			{
				if (txtPaths.Text == "%appdata%")
					txtPaths.Text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				atualizacao = false;
				try
				{
					if ((int)tag != 0)
					{
						IdPlayList = (int)tag;
						atualizacao = true;
					}
					else
					{
						IdPlayList = 0;
						atualizacao = false;
					}
				}
				catch
				{
					MessageBox.Show("Your were very fast!! Take it easy,beacuse the program dont detect playList", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				Screen scrn = Screen.FromControl(this);
				ecra = int.Parse((scrn.DeviceName.Replace("\\", "").Replace(".DISPLAY", "")));
				Form2 form2 = new Form2(atualizacao, IdPlayList, ecra, (txtPaths.Text));
				form2.ShowDialog();
				form2.Close();
				_listInformacoes = bk.WriteReadMusic(true, txtPaths.Text, null, -1);
				if (!bgwCarregar.IsBusy) bgwCarregar.RunWorkerAsync();
				this.Tag = "AddPnl";
				//escrever();
				//int a = 1;
				//_listInformacoes.ToList().ForEach(item =>
				//{
				//	item.IDList = a;
				//	a++;
				//});
				//form2.Close();
				//var json = JsonConvert.SerializeObject(_listInformacoes);
				//File.WriteAllText(Environment.CurrentDirectory + "/Musics.json", json);
			}
			catch
			{
				return;
			}
			Atualiza();
		}
		private void MusicaPlay()
		{
			this.Tag = "MusicaPlay";
			if (!bgwCarregar.IsBusy) bgwCarregar.RunWorkerAsync();
		}
		private void Atualiza()
		{
			this.Tag = "AddPnl";
			if (!bgwCarregar.IsBusy) bgwCarregar.RunWorkerAsync();
		}
		private void escrever()
		{
			//try
			//{
			//	Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");
			//	var myString = File.ReadAllText(Environment.CurrentDirectory + "/Musics.json");
			//	_listInformacoes = JsonConvert.DeserializeObject<List<PlayList>>(myString);
			//	if (myString == string.Empty || myString == " ")
			//	{
			//		var json = JsonConvert.SerializeObject("[]");
			//		json = json.Replace("\"", "");
			//		File.WriteAllText(Environment.CurrentDirectory + "/Musics.json", json);
			//	}
			//}
			//catch
			//{
			//	var json = JsonConvert.SerializeObject("[]");
			//	json = json.Replace("\"", "");
			//	File.WriteAllText(Environment.CurrentDirectory + "/Musics.json", json);
			//}
		}

		//private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
		//{
		//	if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
		//	{
		//		PBC.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
		//		timer1.Start();
		//	}
		//	else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused) timer1.Stop();
		//}

		//private void RemoveinPlayList_Click(object sender, EventArgs e) { PictureBox picture = sender as PictureBox; _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.RemoveAt(int.Parse(picture.Tag.ToString())); PlaydaLista.Clear(); _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.ToList().ForEach(item => { NameMusic = item.Split(new string[] { "\\" }, StringSplitOptions.None); int TAMANHO = NameMusic.Length; int g = NameMusic[TAMANHO - 1].Count(); string f = NameMusic[TAMANHO - 1].Substring(0, g); PlaydaLista.Add(f); }); var json = JsonConvert.SerializeObject(_listInformacoes); Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp"); File.WriteAllText(Environment.CurrentDirectory + "/Musics.json", json); MusicaPlay(); }
		//private void pEAdicionar_Click(object sender, EventArgs e)
		//{
		//	string[] files, path;
		//	PictureBox button = sender as PictureBox;
		//	OpenFileDialog ofd = new OpenFileDialog();
		//	ofd.Multiselect = true;
		//	ofd.Filter = "Video and Music Files (*.mp3,*.au,*.m4a,*.mp4,*.m4v,*.mp4v)|*.mp3;*.au;*.m4a;*.mp4;*.m4v;*.mp4v";
		//	ofd.Multiselect = true;
		//	if (ofd.ShowDialog() == DialogResult.OK)
		//	{
		//		files = ofd.SafeFileNames;
		//		path = ofd.FileNames;
		//		if (PlaydaLista.Count() == 0)
		//		{
		//			path.ToList().ForEach(item =>
		//			{
		//				_Caminho_Musica.Add(item);
		//				NameMusic = item.Split(new string[] { "\\" }, StringSplitOptions.None);
		//				int TAMANHO = NameMusic.Length;
		//				int g = NameMusic[TAMANHO - 1].Count();
		//				string f = NameMusic[TAMANHO - 1].Substring(0, g);
		//				PlaydaLista.Add(f);
		//			});
		//		}
		//		else
		//		{
		//			path.ToList().ForEach(item =>
		//			{
		//				if (_listInformacoes[IdPlayList - 1].Caminho_da_Musica.Contains(item) == false)
		//				{
		//					_Caminho_Musica.Add(item);
		//					NameMusic = item.Split(new string[] { "\\" }, StringSplitOptions.None);
		//					int TAMANHO = NameMusic.Length;
		//					int g = NameMusic[TAMANHO - 1].Count();
		//					string f = NameMusic[TAMANHO - 1].Substring(0, g);
		//					PlaydaLista.Add(f);
		//				}
		//			});
		//		}
		//		_listInformacoes[IdPlayList - 1].Caminho_da_Musica = _Caminho_Musica;
		//		Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");
		//		string json = JsonConvert.SerializeObject(_listInformacoes);
		//		File.WriteAllText(Environment.CurrentDirectory + "/Musics.json", json);
		//		MusicaPlay();
		//	}
		//	Invalidate();
		//}
		#endregion
		#region NEW SOURCE
		List<Settings> settings = new List<Settings>();

		#region teste 
		//private IKeyboardMouseEvents m_Events;

		//private void Main_Closing(object sender, CancelEventArgs e)
		//{
		//	Unsubscribe();
		//}

		//private void SubscribeGlobal()
		//{
		//	Unsubscribe();
		//	Subscribe(Hook.GlobalEvents());
		//}

		//private void Subscribe(IKeyboardMouseEvents events)
		//{
		//	m_Events = events;
		//	m_Events.KeyUp += KeyPress;
		//	m_Events.MouseDown += Mouse;
		//}

		//private void OnPress(object sender, KeyPressEventArgs e)
		//{
		//	//Log("\n" + e.KeyChar);
		//}

		//private void Unsubscribe()
		//{
		//	if (m_Events == null) return;
		//	m_Events.KeyDown -= KeyPress;
		//	m_Events.KeyUp -= KeyPress;

		//	m_Events.MouseUp -= Mouse;
		//	m_Events.MouseClick -= Mouse;
		//}
		//private async void KeyPress(KeyEventArgs e, Button ds)
		//{

		//}

		#endregion

		#region Done
		private void pnlTop_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void checkBox1_Click(object sender, EventArgs e)
		{
			CheckBox check = sender as CheckBox;
			if (check.Name == "chkDiscord")
			{
				var ds = chkDiscord.Checked ? pnlDiscord.Visible = true : pnlDiscord.Visible = false;
			}
			else
			if (check.Name == "chkAtalho")
			{
				var ds = chkAtalho.Checked ? pnlAtalho.Visible = true : pnlAtalho.Visible = false;
			}
		}
		private void label11_Click(object sender, EventArgs e)
		{
			Label lbl = sender as Label;

			if (lbl.Name == "lblSO")
			{
				var ds = switchSO.IsOn == true ? switchSO.IsOn = false : switchSO.IsOn = true;
			}
			else
				if (lbl.Name == "lblNomeDisc")
			{
				var ds = switchNome.IsOn == true ? switchNome.IsOn = false : switchNome.IsOn = true;
			}
			else
				if (lbl.Name == "lblDuracao")
			{
				var ds = switchDuracao.IsOn == true ? switchDuracao.IsOn = false : switchDuracao.IsOn = true;
			}
			SaveSettings(null);
		}
		#endregion

		private async void KeyPress(object sender, KeyEventArgs e)
		{
			if (btnSel != null)
				btnSel.Text += e.KeyCode + " + ";
		}
		private void Mouse(object sender, MouseEventArgs e)
		{
			if (btnSel != null)
				if (e.Button.ToString() != "Left" && e.Button.ToString() != "Right")
					btnSel.Text += e.Button + " + ";
		}
		Button btnSel = new Button();
		private void Btn_TeclasAtalhos(object sender, EventArgs e)
		{
			btnSel = sender as Button;
			btnSel.Text = "";
		}

		private void label9_Click(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			switch (lbl.Tag.ToString())
			{
				case "Musica Anterior":
					btnAnterior.Text = btnAnterior.Text.Remove((btnAnterior.Text.Length - 3));
					break; ;
				case "Pausar e Retomar":
					btnPausa.Text = btnPausa.Text.Remove((btnPausa.Text.Length - 3));
					break;
				case "musica Seguinte":
					btnNext.Text = btnNext.Text.Remove((btnNext.Text.Length - 3));
					break;
				default:
					break;
			}
			btnSel = null;
		}
		public Form1()
		{
			InitializeComponent();
		}
		private void bgwCarregar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			Aqui:
			pnlPrincipal.Controls.Clear();
			if (this.Tag.ToString() == "MusicaPlay" || this.Tag.ToString() == "MusicaPlayD")
			{
				int widht = Screen.PrimaryScreen.Bounds.Width;
				int height = Screen.PrimaryScreen.Bounds.Height;
				musica = true;
				pnlPrincipal.Visible = true;
				axWindowsMediaPlayer1.Visible = false;
				try
				{
					PlaydaLista.Clear();
					_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.ToList().ForEach(item =>
					{
						NameMusic = item.Split(new string[]{
		"\\"}, StringSplitOptions.None);
						int TAMANHO = NameMusic.Length;
						int g = NameMusic[TAMANHO - 1].Count();
						string f = NameMusic[TAMANHO - 1].Substring(0, g);
						if (PlaydaLista.Contains(f) == false) PlaydaLista.Add(f);
					});
				}
				catch
				{
				}
				Panel pnlpri = new Panel();
				pnlpri.BackColor = Color.Red;
				pnlpri.Location = new Point(0, 0);
				pnlpri.Dock = DockStyle.Top;
				pnlpri.Size = new Size(pnlPrincipal.Width, 155);
				pnlPrincipal.Controls.Add(pnlpri);
				try
				{
					PictureBox pE_ = new PictureBox();
					pE_.Location = new Point(20, 5);
					pE_.Size = new Size(164, 136);
					pE_.BackColor = Color.Silver;
					pE_.LoadAsync(_listInformacoes[(IdPlayList - 1)].Image);
					pE_.SizeMode = PictureBoxSizeMode.Zoom;
					pE_.BorderStyle = BorderStyle.None;
					pnlpri.Controls.Add(pE_);
				}
				catch
				{
					return;
				}
				Label lblPl = new Label();
				lblPl.Text = "PLAYLIST";
				lblPl.Location = new Point(202, 25);
				lblPl.Size = new Size(61, 13);
				lblPl.BorderStyle = BorderStyle.None;
				lblPl.Font = new Font("Tahoma", 9, FontStyle.Regular);
				lblPl.BackColor = Color.Transparent;
				lblPl.ForeColor = Color.Black;
				pnlpri.Controls.Add(lblPl);
				Label lbl = new Label();
				try
				{
					//string s;
					//string s1 = _listInformacoes[(IdPlayList - 1)].Name;
					//if (s1.Count() > 30)
					//{
					//	s = s1.Substring(0, 30);
					//	if (s1.Count() > 30) s = s + " ...";
					//}
					//else s = s1;
					var ds = _listInformacoes[(IdPlayList - 1)].Name.Count() > 30 ? lbl.Text = _listInformacoes[(IdPlayList - 1)].Name.Substring(0, 30) : lbl.Text = _listInformacoes[(IdPlayList - 1)].Name;
					//lbl.Text = s;
					lbl.Location = new Point(202, 39);
					lbl.Size = new Size(195, 25);
					lbl.BorderStyle = BorderStyle.None;
					lbl.BackColor = Color.Transparent;
					lbl.Font = new Font("Times New Roman", 18, FontStyle.Bold);
					lbl.ForeColor = Color.Black;
					pnlpri.Controls.Add(lbl);
				}
				catch
				{
					return;
				}
				Label lbl1 = new Label();
				lbl1.Text = _listInformacoes[(IdPlayList - 1)].Descrição;
				lbl1.Location = new Point(202, 66);
				lbl1.AutoSize = false;
				lbl1.Size = new Size(314, 40);
				lbl1.BorderStyle = BorderStyle.None;
				lbl1.BackColor = Color.Transparent;
				lbl1.Font = new Font("Times New Roman", 9, FontStyle.Italic);
				lbl1.ForeColor = Color.Black;
				pnlpri.Controls.Add(lbl1);
				Button btn = new Button();
				btn.Location = new Point(202, 110);
				btn.Size = new Size(100, 30);
				btn.FlatStyle = FlatStyle.Flat;
				btn.BackColor = Color.FromArgb(0, 128, 71);
				btn.FlatAppearance.BorderSize = 0;
				btn.ForeColor = Color.White;
				btn.Font = new Font("Trebuchet MS", 17, FontStyle.Bold);
				btn.Text = "PLAY";
				btn.Click += btnPlayMusic_Click;
				btn.Cursor = Cursors.Hand;
				pnlpri.Controls.Add(btn);
				PictureBox pe = new PictureBox();
				pe.Location = new Point(487, 110);
				pe.Size = new Size(30, 30);
				pe.Image = Properties.Resources.mais;
				pe.BackColor = Color.Transparent;
				pe.SizeMode = PictureBoxSizeMode.Zoom;
				pe.Anchor = AnchorStyles.Right;
				pe.BorderStyle = BorderStyle.None;
				pe.Cursor = Cursors.Hand;
				pe.Name = "picAddMusic";
				pe.Click += pE_Click;
				pnlpri.Controls.Add(pe);
				//FlowLayoutPanel flp = new FlowLayoutPanel();
				//flp.Dock = DockStyle.Fill;
				//flp.AutoScroll = true;
				//flp.BackColor = Color.Transparent;
				//pnl.Controls.Add(flp);
				Panel pnlseg = new Panel();
				pnlseg.Dock = DockStyle.Fill;
				pnlseg.BackColor = Color.Blue;
				pnlPrincipal.Controls.Add(pnlseg);
				Panel pnl = new Panel();
				pnl.Location = new Point(5, 160);
				pnl.AutoScroll = true;
				pnl.Size = new Size((pnlseg.Width - 10), (pnlseg.Height - 230));
				pnl.BorderStyle = BorderStyle.None;
				//pnl.Dock = DockStyle.Fill;
				pnl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
				pnl.BackColor = Color.White;
				pnl.Margin = new Padding(15, 15, 15, 25);
				pnlseg.Controls.Add(pnl);
				PictureBox pictureEdit = new PictureBox();
				pictureEdit.Location = new Point(pnlpri.Width - 18, 0);
				pictureEdit.Size = new Size(20, 20);
				pictureEdit.Image = Properties.Resources.expand;
				pictureEdit.Anchor = AnchorStyles.Right;
				pictureEdit.BackColor = Color.Transparent;
				pictureEdit.BorderStyle = BorderStyle.None;
				pictureEdit.SizeMode = PictureBoxSizeMode.Zoom;
				pictureEdit.Cursor = Cursors.Arrow;
				pictureEdit.Name = "picAxw";
				pictureEdit.Click += pE_Click;
				pnlpri.Controls.Add(pictureEdit);
				try
				{
					int d = 0, limite = 0;
					if (_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica != null)
					{
						if (this.Tag.ToString() == "MusicaPlayD")
							limite = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count();
						else
							limite = 15;
						PlaydaLista.ToList().ForEach(Testes =>
						{
							NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[d].Split(new string[] { "\\" }, StringSplitOptions.None);

							if (d <= limite)
							{
								Panel pnl1 = new Panel();
								//if (d > 11)
								//	pnl1.Size = new Size(pnl.Width - 25, 40);
								//else if(d==6)
								//	pnl1.Size = new Size(pnl.Width - 35, 40);
								/*else*/
								//if (this.Tag.ToString() == "MusicaPlayD" && this.Size!= new Size(800, 450)  && (d>4 && d<11))
								//	pnl1.Size = new Size(pnl.Width - 25, 40);
								//else

								if (d == 5)
									pnl1.Size = new Size(pnl.Width - 31, 40);
								else if (d > 5)
									pnl1.Size = new Size(pnl.Width - 29, 40);
								else
									pnl1.Size = new Size(pnl.Width - 14, 40);

								pnl1.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;

								pnl1.BackColor = Color.FromArgb(224, 224, 209);
								if (d > 1)
									pnl1.Location = new Point(5, d * 46);
								else if (d == 1)
									pnl1.Location = new Point(5, 48);
								else
									pnl1.Location = new Point(5, 3);
								//pnl1.Dock = DockStyle.Top;
								PictureBox pic = new PictureBox();
								pic.Image = Properties.Resources.botao_play;
								pic.SizeMode = PictureBoxSizeMode.Zoom;
								pic.Size = new Size(30, 30);
								pic.BorderStyle = BorderStyle.None;
								pic.BackColor = Color.Transparent;
								pic.Location = new Point(5, 5);
								pic.Tag = d;
								pic.Name = "picBotaoPlay";
								pic.Click += pE_Click;
								pnl1.Controls.Add(pic);
								Label lbl2 = new Label();
								lbl2.Size = new Size(pnl.Width - 200, 20);
								lbl2.BackColor = Color.Transparent;
								lbl2.Location = new Point(50, 10);
								lbl2.Text = Testes.Substring(0, (Testes.Count() - 4));
								lbl2.ForeColor = Color.Black;
								lbl2.Anchor =AnchorStyles.Left;
								lbl2.Font = new Font("Arial", 8, FontStyle.Italic);
								pnl1.Controls.Add(lbl2);
								PictureBox picture = new PictureBox();
								picture.Image = Properties.Resources.close_red;
								picture.Location = new Point(pnl1.Width - 40, (pnl1.Height / 2) - 10);
								picture.Size = new Size(20, 20);
								picture.SizeMode = PictureBoxSizeMode.Zoom;
								picture.BorderStyle = BorderStyle.None;
								picture.BackColor = Color.Transparent;
								picture.Anchor = AnchorStyles.Right ;
								picture.Tag = d;
								picture.Name = "picRemoveMusic";
								picture.Click += pE_Click;
								pnl1.Controls.Add(picture);
								pnl.Controls.Add(pnl1);
								d++;
							}
							else if (d == 16)
							{
								Panel pnl1 = new Panel();
								pnl1.Size = new Size(pnl.Width - 29, 40);
								pnl1.BackColor = Color.FromArgb(224, 224, 209);
								pnl1.Margin = new Padding(0, 2, 0, 0);
								pnl1.Location = new Point(5, d * 46);
								pnl1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
								pnl1.Name = "pnlDown";
								PictureBox pic = new PictureBox();
								pic.Image = Properties.Resources.down;
								pic.SizeMode = PictureBoxSizeMode.Zoom;
								pic.Size = new Size(30, 30);
								pic.BorderStyle = BorderStyle.None;
								pic.BackColor = Color.Transparent;
								pic.Location = new Point(5, 5);
								pic.Tag = d;
								pic.Name = "picDown";
								pic.Anchor = AnchorStyles.Left;
								pic.Click += pE_Click;
								pnl1.Controls.Add(pic);
								Label lbl2 = new Label();
								lbl2.Size = new Size(pnl.Width - 120, 20);
								lbl2.BackColor = Color.Red;
								lbl2.Location = new Point(50, 10);
								lbl2.Text = "Teste";
								lbl2.ForeColor = Color.Black;
								lbl2.Font = new Font("Times New Roman", 12, FontStyle.Italic);
								lbl2.TextAlign = ContentAlignment.MiddleCenter;
								lbl2.Anchor = AnchorStyles.Right | AnchorStyles.Left;
								pnl1.Controls.Add(lbl2);
								PictureBox picture = new PictureBox();
								picture.Image = Properties.Resources.down;
								picture.Location = new Point(pnl1.Width - 40, (pnl1.Height / 2) - 10);
								picture.Size = new Size(30, 30);
								picture.SizeMode = PictureBoxSizeMode.Zoom;
								picture.BorderStyle = BorderStyle.None;
								picture.BackColor = Color.Transparent;
								picture.Tag = d;
								picture.Name = "picDown";
								picture.Anchor = AnchorStyles.Right;
								picture.Click += pE_Click;
								pnl1.Controls.Add(picture);
								pnl.Controls.Add(pnl1);
								d++;
							}
						});
					}
				}
				catch
				{
					return;
				}
			}
			else
			if (this.Tag.ToString() == "AddPnl")
			{
				pnlPrincipal.Visible = true;
				axWindowsMediaPlayer1.Visible = false;
				if (musica == true) MusicaPlay();
				PainelControl1.Size = new Size(130, 409);
				pnlPlayList.Size = new Size(PainelControl1.Size.Width, PainelControl1.Size.Height - 70);
				picAddPlaylist.Location = new Point(12, 35);
				this.FormBorderStyle = FormBorderStyle.None;
				pnlPrincipal.Size = new Size(676, 345);
				try
				{
					flowLayoutPanel1.Controls.Clear();
					flowLayoutPanel1.Dock = DockStyle.Fill;
					flowLayoutPanel1.AutoScroll = true;
					flowLayoutPanel1.BorderStyle = BorderStyle.None;
					flowLayoutPanel1.Margin = new Padding(0, 0, 0, 0);
					flowLayoutPanel1.BackColor = Color.Transparent;
					pnlPlayList.BorderStyle = BorderStyle.None;
					int temp = 1;
					_listInformacoes.ToList().ForEach(test =>
					{
						Panel pnl = new Panel();
						pnl.Size = new Size(130, 50);
						pnl.BorderStyle = BorderStyle.None;
						pnl.BackColor = Color.AntiqueWhite;
						pnl.Margin = new Padding(0, 0, 0, 0);
						pnl.BackColor = Color.FromArgb(92, 209, 213);
						pnl.Anchor = (AnchorStyles.Right | AnchorStyles.Left);
						pnl.ContextMenuStrip = cmsMenuStrip;
						pnl.Tag = temp;
						pnl.MouseDown += painel_MouseDown;
						pnl.Click += pnl_Click;
						string s1 = test.Name;
						int k = s1.Count() > 10 ? k = 10 : k = s1.Count();
						string s = s1.Substring(0, k);
						s = s1.Count() > 10 ? s = s + " ..." : s = s + "";
						PictureBox pE_ = new PictureBox();
						pE_.Size = new Size(36, 37);
						pE_.Location = new Point(6, 9);
						pE_.LoadAsync((test.Image));
						pE_.BackColor = Color.Transparent;
						pE_.BorderStyle = BorderStyle.None;
						pE_.SizeMode = PictureBoxSizeMode.Zoom;
						pE_.Tag = temp;
						pE_.MouseDown += PicEdit_MouseDown;
						pE_.Click += pE_Click;
						pE_.Name = "picPlaylist";
						pnl.Controls.Add(pE_);
						Label lbl = new Label();
						lbl.AutoSize = false;
						lbl.Text = s;
						lbl.Size = new Size(80, 37);
						lbl.Location = new Point(49, 20);
						lbl.BackColor = Color.Transparent;
						lbl.BorderStyle = BorderStyle.None;
						lbl.Tag = temp;
						lbl.MouseDown += Lbl_MouseDown;
						lbl.Click += Lbl_Click;
						pnl.Controls.Add(lbl);
						flowLayoutPanel1.Controls.Add(pnl);
						temp++;
					});
				}
				catch
				{

				}
				this.Tag = "";
			}
		}

		private void bgwCarregar_DoWork(object sender, DoWorkEventArgs e)
		{
			if (this.Tag.ToString() != "MusicaPlay")
			{
				try
				{
					//Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");
					//var json = JsonConvert.SerializeObject("[]");
					//json = json.Replace("\"", "");
					//File.WriteAllText(Environment.CurrentDirectory + "/Musics.json", json);

					if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt"))
						txtPaths.Text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt");
					Backend bk = new Backend();
					try
					{
						List<Settings> lst = bk.WriteReadSettings(txtPaths.Text, true, "");
						SaveSettings(lst[0]);
					}
					catch { }
					_listInformacoes = bk.WriteReadMusic(true, txtPaths.Text, null, -1);
					//bk.CreateFiles(txtPaths.Text, true);
				}
				catch
				{

				}
			}
		}

		private void Discord(string NomeMusic, string tempo)
		{
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("863871149598048297", ref this.handlers, true, null);
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("863871149598048297", ref this.handlers, true, null);
			this.presence.details = "" + NomeMusic;
			this.presence.state = "" + tempo;
			this.presence.largeImageKey = "catjam";
			this.presence.smallImageKey = "spotify";
			this.presence.largeImageText = "";
			this.presence.smallImageText = "";
			DiscordRpc.UpdatePresence(ref this.presence);
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			Invalidate();
			axWindowsMediaPlayer1.Visible = false;
			//pictureBox1.Click += pE_minimizar_Click;
			atualizacao = false;
			Discord("Nome da Musica", "Duração ...");
			pnlSettings.BringToFront();
			comboBox1.Text = comboBox1.Items[0].ToString();

			//if (!backgroundWorker1.IsBusy) backgroundWorker1.RunWorkerAsync();
			if (!bgwCarregar.IsBusy) bgwCarregar.RunWorkerAsync();
			this.Tag = "AddPnl";
			//SubscribeGlobal();
			//FormClosing += Main_Closing;


			//escrever();
			//Process[] procs = Process.GetProcessesByName("Spotify Clone");
			//if (procs.Length > 1) foreach (Process proc in procs)
			//	{
			//		if (proc != procs[0]) proc.Kill();
			//	}
			//CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
			//if (defaultPlaybackDevice.Volume >= 50)
			//{
			//	if (MessageBox.Show("I down volume the your computer,to your security!!!\nIf not like,click in \"Não\",else click in \"Sim\" I reduce the volume!!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			//	{
			//		System.Diagnostics.Process.Start("sndvol.exe");
			//		this.CenterToScreen();
			//	}
			//}
		}
		private void SaveSettings(Settings settings)
		{
			if (settings == null)
			{
				int SO = switchSO.IsOn ? SO = 1 : SO = 0;
				int Discord = switchSO.IsOn ? Discord = 1 : Discord = 0;
				int Enviar = switchNome.IsOn ? Enviar = 1 : Enviar = 0;
				int Duracao = switchDuracao.IsOn ? Duracao = 1 : Duracao = 0;
				int Atalho = chkAtalho.Checked ? Atalho = 1 : Atalho = 0;

				Backend back = new Backend();
				List<Settings> st = back.UpdateSettings(comboBox1.Text, SO, Discord, Enviar, Duracao, Atalho, btnAnterior.Text, btnPausa.Text, btnNext.Text, txtPaths.Text);
				string json = JsonConvert.SerializeObject(st);

				Backend bk = new Backend();
				bk.WriteReadSettings(txtPaths.Text, false, json);
			}
			else
			{
				try
				{
					var ds = settings.atal == 1 ? chkAtalho.Checked = true : chkAtalho.Checked = false;
					ds = chkAtalho.Checked == true ? pnlAtalho.Visible = true : pnlAtalho.Visible = false;
					ds = settings.disc == 1 ? chkDiscord.Checked = true : chkDiscord.Checked = false;
					ds = chkDiscord.Checked == true ? pnlDiscord.Visible = true : pnlDiscord.Visible = false;
					ds = settings.AutoRun == 1 ? switchSO.IsOn = true : switchSO.IsOn = false;
					if (settings.discord != null)
					{
						ds = settings.discord[0].Duracao == 1 ? switchDuracao.IsOn = true : switchDuracao.IsOn = false;
						ds = settings.discord[0].EnviarNome == 1 ? switchNome.IsOn = true : switchNome.IsOn = false;
					}
					if (settings.Atalhos != null)
					{
						btnAnterior.Text = settings.Atalhos[0].MusicaAnterior;
						btnPausa.Text = settings.Atalhos[0].Pausa;
						btnNext.Text = settings.Atalhos[0].MusicaSeguinte;
					}
					txtPaths.Text = settings.Paths;
					var dds = settings.Idioma == "Português" ? comboBox1.SelectedItem = "Português" : comboBox1.SelectedItem = "Inglês";
				}
				catch { }
			}
		}

		#region give tag to toolstrip
		private void painel_MouseDown(object sender, MouseEventArgs e)
		{
			TSMIRemove.Tag = (int)(((Panel)sender).Tag);
			TSMIEditPlayList.Tag = (int)((Panel)sender).Tag;
		}
		private void PicEdit_MouseDown(object sender, MouseEventArgs e)
		{
			TSMIRemove.Tag = (int)((PictureBox)sender).Tag;
			TSMIEditPlayList.Tag = (int)((PictureBox)sender).Tag;
		}
		private void Lbl_MouseDown(object sender, MouseEventArgs e)
		{
			TSMIRemove.Tag = (int)((Label)sender).Tag;
			TSMIEditPlayList.Tag = (int)((Label)sender).Tag;
		}
		#endregion

		private void pE_Click(object sender, EventArgs e)
		{
			PictureBox pE = sender as PictureBox;

			switch (pE.Name)
			{
				#region Sem Problemas
				case "pctPaths":
					string paths = "" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					var fsd = new FolderSelectDialog();
					fsd.Title = "Selecione um caminho onde quere guardar os ficheiros";//"Select path where u like save files";
					fsd.InitialDirectory = txtPaths.Text;
					if (txtPaths.Text == "%appdata%")
						fsd.InitialDirectory = paths;
					if (fsd.ShowDialog(IntPtr.Zero))
						if (!fsd.FileName.Contains("" + paths))
						{
							if (File.Exists(paths + "/SpotifyClone/Musics.json"))
								File.Delete(paths + "/SpotifyClone/Musics.json");
							if (File.Exists(paths + "/SpotifyClone/Settings.json"))
								File.Delete(paths + "/SpotifyClone/Settings.json");
							if (Directory.Exists(paths + "/SpotifyClone"))
								Directory.Delete(paths + "/SpotifyClone");
							txtPaths.Text = fsd.FileName;
						}
					//Backend bk = new Backend();
					bk.WriteReadMusic(false, txtPaths.Text, null, -1);
					//Debug.Print($"Ds: {((PictureBox)sender).Name}");//IMPORTANTE VER
					break;
				case "pE_Close":
					//IdPlayList = (int)pE.Tag;
					//MusicaPlay();
					this.Close();
					break;
				case "pE_minimizar":
					this.WindowState = FormWindowState.Minimized;
					break;
				case "picSettings":
					if (pnlSettings.Visible == true)
						SaveSettings(null);
					var ds = pnlSettings.Visible == true ? pnlSettings.Visible = false : pnlSettings.Visible = true;
					break;
				case "pE_MaxMin":
					PictureBox pct = sender as PictureBox;
					Screen scrn = Screen.FromControl(this);
					int n = int.Parse((scrn.DeviceName.Replace("\\", "").Replace(".DISPLAY", "")));
					if (this.Size == new Size(800, 450))
					{
						FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
						Left = Top = 0;
						Width = Screen.AllScreens[(n - 1)].WorkingArea.Width;
						Height = Screen.AllScreens[(n - 1)].WorkingArea.Height;
						this.Location = Screen.AllScreens[(n - 1)].WorkingArea.Location;
					}
					else
					{
						WindowState = FormWindowState.Normal;
						this.Size = new Size(800, 450);
						Width = 800;
						Height = 450;
						Left = (Screen.AllScreens[(n - 1)].WorkingArea.Width) / 5;
						Top = (Screen.AllScreens[(n - 1)].WorkingArea.Height) / 5;
						this.Location = Screen.AllScreens[(n - 1)].WorkingArea.Location;
						this.CenterToScreen();
					}
					break;

				#endregion
				#region novos
				case "picAxw":
					FormVideo = false; 
					FormCollection fc = Application.OpenForms;
					foreach (Form frm in fc) { if (frm.Name == "Video") FormVideo = true; }
					if (PBC.Value != 0 && FormVideo == false) 
					{ 
						pnlPrincipal.Visible = false;
						axWindowsMediaPlayer1.Visible = true;
						axWindowsMediaPlayer1.BringToFront(); 
						axWindowsMediaPlayer1.Dock = DockStyle.Fill;
						axWindowsMediaPlayer1.Location = new Point(0, 0);
						pnlPrincipal.Controls.Clear(); axWindowsMediaPlayer1.Ctlcontrols.play();
						musica = true;
					}

					break;
				case "picInfos":
					if (PBC.Value > 0)
						MessageBox.Show(labelControl2.Text);
					break;
				case "picBotaoPlay":
					labelControl2.Tag = pE.Tag;
					picForm3.Tag = "" + IdPlayList;
					pE_PauseaPlay.Image = Properties.Resources.pause;
					pE_PauseaPlay.Tag = "0";
					if (FormVideo == false)
					{
						axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[((int)pE.Tag)];
						axWindowsMediaPlayer1.Ctlcontrols.play();
					}
					else
					{
						CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[((int)pE.Tag)]];
						if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition != 0)
							Posicao = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
						Volume = labelControl4.Text;
						Processo = "start";
						fmr.timer1_Tick(sender, e);
					}
					try
					{
						NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[((int)pE.Tag)].Split(new string[] { "\\" }, StringSplitOptions.None);
						labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
					}
					catch
					{

					}
					pE_Next.Enabled = true; pE_PauseaPlay.Enabled = true; pE_previous.Enabled = true;
					break;
				case "pE_Repit":
					if (pE_Repit.Tag.ToString() == "0")
					{
						pE_Repit.Image = Properties.Resources.refresh;
						pE_Repit.Tag = 1;
					}
					else
					{
						pE_Repit.Image = Properties.Resources.refresh1;
						pE_Repit.Tag = 0;
					}
					break;
				case "pE_Next":
					{
						if (int.Parse(labelControl2.Tag.ToString()) == _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1)
							labelControl2.Tag = "" + 0;
						else
							labelControl2.Tag = "" + ((int.Parse(labelControl2.Tag.ToString())) + 1);
						try
						{
							if (FormVideo == false)
							{
								axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
								NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None);
								labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
								axWindowsMediaPlayer1.Ctlcontrols.play();
							}
							else
							{
								pE_PauseaPlay.Image = Properties.Resources.pause;
								pE_PauseaPlay.Tag = "0";
								CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
								Volume = labelControl4.Text;
								Processo = "start";
								NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None);
								labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
								fmr.timer1_Tick(sender, e);
								timer1.Stop();
							}
							pE_PauseaPlay.Image = Properties.Resources.pause;
							pE_PauseaPlay.Tag = "0";
							dt = 0;
						}
						catch (Exception ex)
						{
							MessageBox.Show("\nERROR 404\n" + ex.Message + "!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					break;
				case "pE_PauseaPlay":
					try
					{
						if (labelControl2.Text != "")
						{
							if (FormVideo == false)
							{
								if (pE_PauseaPlay.Tag.ToString() == "0")
								{
									pE_PauseaPlay.Image = Properties.Resources.play;
									pE_PauseaPlay.Tag = "1";
									axWindowsMediaPlayer1.Ctlcontrols.pause();
								}
								else
								{
									pE_PauseaPlay.Image = Properties.Resources.pause;
									pE_PauseaPlay.Tag = "0";
									axWindowsMediaPlayer1.Ctlcontrols.play();
								}
							}
							else
							{
								if (pE_PauseaPlay.Tag.ToString() == "0")
								{
									pE_PauseaPlay.Image = Properties.Resources.play;
									pE_PauseaPlay.Tag = "1";
									CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
									if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition != 0)
										Posicao = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
									Volume = labelControl4.Text;
									Processo = "pause";
								}
								else
								{
									pE_PauseaPlay.Image = Properties.Resources.pause;
									pE_PauseaPlay.Tag = "0";
									CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
									if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition != 0)
										Posicao = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
									Volume = labelControl4.Text;
									Processo = "start";
								}
								fmr.timer1_Tick(sender, e);
								timer1.Stop();
								var ts = pE_PauseaPlay.Tag.ToString() == "0" ? Processo = "pause" : Processo = "start";
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("\nERROR 404\n " + ex.Message + " !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						dt = 0;
					}
					break;
				case "pE_previous":
					{
						try
						{
							if (int.Parse(labelControl2.Tag.ToString()) == 0)
								labelControl2.Tag = "" + (_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1);
							else labelControl2.Tag = (int.Parse(labelControl2.Tag.ToString())) - 1;
							if (FormVideo == false)
							{
								axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
								NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None);
								labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
								axWindowsMediaPlayer1.Ctlcontrols.play();
							}
							else
							{
								if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition != 0)
									Posicao = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
								Volume = labelControl4.Text;
								Processo = "pause";
								//CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
								//NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None);
								//labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
								axwindows();
								fmr.timer1_Tick(sender, e);
								timer1.Stop();
							}
							pE_PauseaPlay.Image = Properties.Resources.pause;
							pE_PauseaPlay.Tag = "0";
							dt = 0;
						}
						catch (Exception ex)
						{
							MessageBox.Show("\nERROR 404\n" + ex.Message + "!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						break;
					}
				case "pE_Random":
					try
					{
						Ordem_de_Reproducao.Clear();
						if (pE_Random.Tag.ToString() == "0")
						{
							try
							{
								//foreach (string a in _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica)
								//	Ordem_de_Reproducao.Add(0.0001);
								//for (int d = 0; d < _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count(); d++)
								//{
								//	aqui:
								//	Random rd = new Random();
								//	int r = rd.Next(0, _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count());
								//	if (!Ordem_de_Reproducao.Contains(r))
								//	{
								//		Ordem_de_Reproducao[d] = r;
								//		pE_Random.Image = Properties.Resources.change;
								//	}
								//	else
								//	{
								//		goto aqui;
								//	}
								//}
								Ordem_de_Reproducao = bk.RandomMusic((IdPlayList - 1), (_listInformacoes));
								pE_Random.Image = Properties.Resources.random;
							}
							catch (Exception ex)
							{
								MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							pE_Random.Tag = "1";
						}
						else
						{
							for (int a = 0; a < _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count(); a++)
								Ordem_de_Reproducao.Add(a);
							pE_Random.Image = Properties.Resources.change;
							pE_Random.Tag = "0";
						}
					}
					catch
					{
						MessageBox.Show("At the moment,dont select playList!! \n OR \n The playList dont ahve musics!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					break;
				case "picForm3":
					{
						if (labelControl2.Text != "" && FormVideo == false)
						{
							Screen scr = Screen.FromControl(this);
							ecra = int.Parse((scr.DeviceName.Replace("\\", "").Replace(".DISPLAY", "")));
							if (Ordem_de_Reproducao.Count() > 1)
								CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
							else
								CaMusica = axWindowsMediaPlayer1.URL;
							axWindowsMediaPlayer1.Visible = false;
							Volume = labelControl4.Text;
							try
							{
								timer1.Stop();
								FormVideo = true;
								axWindowsMediaPlayer1.Ctlcontrols.stop();
								fmr.Show();
							}
							catch
							{
								Video frm = new Video();
								frm.Show();
							}
							timer2.Start();
						}
					}
					break;
				case "picPlaylist":
					IdPlayList = (int)pE.Tag; MusicaPlay();
					break;
				case "picAddMusic":
					string[] files, path;
					PictureBox button = sender as PictureBox;
					OpenFileDialog ofd = new OpenFileDialog();
					ofd.Multiselect = true;
					ofd.Filter = "Video and Music Files (*.mp3,*.au,*.m4a,*.mp4,*.m4v,*.mp4v)|*.mp3;*.au;*.m4a;*.mp4;*.m4v;*.mp4v";
					ofd.Multiselect = true;
					if (ofd.ShowDialog() == DialogResult.OK)
					{
						files = ofd.SafeFileNames;
						path = ofd.FileNames;
						if (PlaydaLista.Count() == 0)
						{
							path.ToList().ForEach(item =>
							{
								_Caminho_Musica.Add(item);
								NameMusic = item.Split(new string[] { "\\" }, StringSplitOptions.None);
								int TAMANHO = NameMusic.Length;
								int g = NameMusic[TAMANHO - 1].Count();
								string f = NameMusic[TAMANHO - 1].Substring(0, g);
								PlaydaLista.Add(f);
							});
							_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica = _Caminho_Musica;
							bk.WriteReadMusic(false, txtPaths.Text, _listInformacoes, -1);
						}
						else
						{
							path.ToList().ForEach(item =>
							{
								if (_listInformacoes[IdPlayList - 1].Caminho_da_Musica.Contains(item) == false)
								{
									_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Add(item);
									//_Caminho_Musica.Add(item);
									NameMusic = item.Split(new string[] { "\\" }, StringSplitOptions.None);
									int TAMANHO = NameMusic.Length;
									int g = NameMusic[TAMANHO - 1].Count();
									string f = NameMusic[TAMANHO - 1].Substring(0, g);
									PlaydaLista.Add(f);
								}
							});
							//_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Add(_Caminho_Musica);
							bk.WriteReadMusic(false, txtPaths.Text, _listInformacoes, -1);
						}
						//_listInformacoes[IdPlayList - 1].Caminho_da_Musica = _Caminho_Musica;
						//Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");
						//string jsons = JsonConvert.SerializeObject(_listInformacoes);
						//File.WriteAllText(Environment.CurrentDirectory + "/Musics.json", jsons);
						//MusicaPlay();
						//this.Tag = "MusicaPlay";
						if (!bgwCarregar.IsBusy) bgwCarregar.RunWorkerAsync();
					}
					Invalidate();
					break;
				case "picRemoveMusic":

					_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.RemoveAt(int.Parse(pE.Tag.ToString()));
					PlaydaLista.Clear();
					_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.ToList().ForEach(item =>
					{
						NameMusic = item.Split(new string[] { "\\" }, StringSplitOptions.None);
						int TAMANHO = NameMusic.Length;
						int g = NameMusic[TAMANHO - 1].Count();
						string f = NameMusic[TAMANHO - 1].Substring(0, g);
						PlaydaLista.Add(f);
					});
					var json = JsonConvert.SerializeObject(_listInformacoes);
					string Paths = "";
					var dss = txtPaths.Text == "%appdata%" ? Paths = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) : Paths = txtPaths.Text;
					File.WriteAllText(Paths + "/SpotifyClone/Musics.json", json);
					MusicaPlay();

					break;
				case "picDown":
					this.Tag = "MusicaPlayD";
					if (!bgwCarregar.IsBusy) bgwCarregar.RunWorkerAsync();
					break;
				#endregion
				default:
					break;
			}
		}

		#endregion

		#region modificando o codigo
		//private void pE_Close_Click(object sender, EventArgs e)
		//{
		//	Application.Exit();
		//}
		private void pE_Close_MouseHover(object sender, EventArgs e)//Não mexer
		{
			pE_Close.Image = Properties.Resources.close_red;
		}
		private void pictureEdit3_Click(object sender, EventArgs e)
		{
			object tag = 0;
			AuxForm2(tag);
			//_listInformacoes.Clear();
			//escrever();
			//Atualiza();
		}
		private void pE_Close_MouseLeave(object sender, EventArgs e)//Não mexer
		{
			pE_Close.Image = Properties.Resources.close_white;
		}
		//private void pE_NorMax_Click(object sender, EventArgs e)
		//{
		//	Atualiza();
		//}
		private void trackBar1_Click(object sender, EventArgs e) { labelControl2.Focus(); }
		private void trackBar1_ValueChanged(object sender, EventArgs e) { TrackBar track = sender as TrackBar; int d = (track.Value * 10); axWindowsMediaPlayer1.settings.volume = d; labelControl4.Text = d.ToString(); labelControl2.Focus(); if (FormVideo == true) { Volume = d.ToString(); fmr.timer1_Tick(sender, e); timer1.Stop(); } }

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying)
			{
				dt = 0;
			}
			if (PBC.Value == 0)
				PBC.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
			
			if (PBC.Value == PBC.Maximum)
			{
				try
				{
					var dsd = (int.Parse(labelControl2.Tag.ToString()) >= _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1) && pE_Repit.Tag.ToString() == "1" ? labelControl2.Tag = 0 : labelControl2.Tag = (int.Parse(labelControl2.Tag.ToString())) + 1;
					
					
					
					//axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
					//NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None);
					//labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
					axwindows();
					axWindowsMediaPlayer1.Ctlcontrols.play();
					PBC.Value = 0;
					dt = 0;

					PBC.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
				}
				catch
				{
					axWindowsMediaPlayer1.Ctlcontrols.stop();
					axWindowsMediaPlayer1.Ctlcontrols.pause();
					PBC.Value = 0;
					timer1.Stop();
					timer2.Stop();
				}
			}
			else if ((PBC.Value == 0) && pE_PauseaPlay.Tag.ToString() != "1" && labelControl2.Text != string.Empty && (Ordem_de_Reproducao.Count() >= 1))
				timer2.Start();
		}

		private void axwindows()
		{
				axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
				NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None);
				labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
				timer1.Start();
			
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (FormVideo == false)
			{
				dt++;
				if (((PBC.Value == 0 || PBC.Value == (PBC.Maximum - 1)) || dt > 5) && pE_PauseaPlay.Tag.ToString() != "1")
				{
					if (dt < 7 && PBC.Value != 0) PBC.Tag = "" + PBC.Value;
					else if (dt >= 12)
					{
						if (PBC.Tag != null && Ordem_de_Reproducao.Count() > 0)
							if (PBC.Value == int.Parse(PBC.Tag.ToString()) || PBC.Value == 0)
							{
								var dsd = (int.Parse(labelControl2.Tag.ToString()) >= _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1) && pE_Repit.Tag.ToString() == "1" ? labelControl2.Tag = 0 : labelControl2.Tag = (int.Parse(labelControl2.Tag.ToString())) + 1;
								axwindows();
								axWindowsMediaPlayer1.Ctlcontrols.play();
								dt = 0;
								timer2.Stop();
							}
					}
				}
				else if (pE_PauseaPlay.Tag.ToString() == "1")
					dt = 0;
			}
			else
			{
				FormCollection fc = Application.OpenForms;
				if (fc.Count != 2)
				{
					try
					{
						FormVideo = false;
						foreach (Form frm in fc)
						{
							if (frm.Name == "Video")
								FormVideo = true;
						}
						if (FormVideo != true)
						{
							axWindowsMediaPlayer1.Visible = true;
							timer1.Start();
							timer2.Stop();
							//axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
							//NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None); labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4)); axWindowsMediaPlayer1.BringToFront(); axWindowsMediaPlayer1.Dock = DockStyle.Fill; axWindowsMediaPlayer1.Visible = true; axWindowsMediaPlayer1.Ctlcontrols.play(); dt = 0;
							axwindows();
						}
					}
					catch { }
				}
				if (Video.progresso != 0)
					PBC.Maximum = (int)Video.maxprogresso;
				if (Ordem_de_Reproducao.Count > 0)
				{
					if (CaMusica != (_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]]).ToString())
					{
						NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None);
						labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
						t = int.Parse(labelControl2.Tag.ToString());
						if (Video.maxprogresso != 0)
							PBC.Maximum = (int)Video.maxprogresso;
					}
					if (PBC.Value == 1)
						dt = 0;
					if ((PBC.Value == PBC.Maximum || PBC.Value == (PBC.Maximum - 1)) && pE_PauseaPlay.Tag.ToString() != "1")
					{
						if (dt >= 12 || PBC.Value == Video.maxprogresso || PBC.Value == (PBC.Maximum - 1))
						{
							if (PBC.Tag != null && (PBC.Value == Video.maxprogresso))
								if ((PBC.Value == Video.maxprogresso))
								{
									var dsd = (int.Parse(labelControl2.Tag.ToString()) == _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1) ? labelControl2.Tag = 0 : labelControl2.Tag = (int.Parse(labelControl2.Tag.ToString())) + 1;
									Volume = labelControl4.Text;
									Processo = "start";
									//NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None);
									//CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
									//labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
									axwindows();
									fmr.timer1_Tick(sender, e);
									Video.progresso = 0;
									dt = 0;
									PBC.Tag = null;
								}
						}
					}
					if (dt == 0) { PBC.Tag = Video.progresso; dt++; }
					if ((dt > 0 && dt < 100) && pE_PauseaPlay.Tag.ToString() != "1")
					{
						dt++;
						try
						{
							if ((int.Parse(PBC.Tag.ToString()) == Video.progresso && dt > 50))
							{
								var dsd = (int.Parse(labelControl2.Tag.ToString()) == _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1) ? labelControl2.Tag = 0 : labelControl2.Tag = (int.Parse(labelControl2.Tag.ToString())) + 1;
								Volume = labelControl4.Text;
								Processo = "start";
								//NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None); 
								//CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]]; 
								//labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4)); 
								axwindows();
								fmr.timer1_Tick(sender, e);
								Video.progresso = 0;
								dt = 0;
								PBC.Tag = null;
								Processo = "start";
							}
						}
						catch { }
					}
					else
						dt = 0;
				}
				try { PBC.Value = (int)Video.progresso; }
				catch { }
			}
		}


		#endregion
	}
}