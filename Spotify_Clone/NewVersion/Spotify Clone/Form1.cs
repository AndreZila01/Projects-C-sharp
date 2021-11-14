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
using DiscordRPC;
using Microsoft.Win32;
using IWshRuntimeLibrary;
using System.Reactive.Linq;
using System.Net;

namespace Spotify_Clone
{

	public partial class Form1 : Form
	{
		#region OLD SOURCE
		//private DiscordRpc.EventHandlers handlers;
		//private DiscordRpc.RichPresence presence;
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
		List<ConfIdioma> conf = new List<ConfIdioma>();
		public List<double> Ordem_de_Reproducao = new List<double>();
		int dt;
		bool FormVideo = false;
		public static string[] NameMusic;
		public static string Processo = "", Posicao = "", CaMusica = "", Volume = "";
		Video fmr = new Video(); Backend bk = new Backend();

		private void pnl_Click(object sender, EventArgs e)
		{

		}
		private void btnPlayMusic_Click(object sender, EventArgs e)
		{
			Random rd = new Random();
			int r; r = rd.Next(0, ((_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1)));
			pE_PauseaPlay.Image = Properties.Resources.pause; pE_PauseaPlay.Tag = "0";
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
				Discord(labelControl2.Text, int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString()), int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration.ToString()));
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
			Discord(labelControl2.Text, int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString()), int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration.ToString()));
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
							if (picForm3.Tag != null)
								if ((int.Parse(picForm3.Tag.ToString())) == (((int)((ToolStripMenuItem)sender).Tag)) /*&& (pE_PauseaPlay.Tag.ToString()) != "0"*/)
								{
									labelControl2.Text = "";
									IdPlayList = 0;
									PBC.Value = 0;
									timer1.Stop();
									timer2.Stop();
									axWindowsMediaPlayer1.URL = "";
									pE_PauseaPlay.Image = Properties.Resources.play;
								}
							IdPlayList = (int)((ToolStripMenuItem)sender).Tag;
							_listInformacoes.Remove(_listInformacoes.FirstOrDefault(row => row.IDList == (int)((ToolStripMenuItem)sender).Tag));
							int id = 1;
							_listInformacoes.ToList().ForEach(item =>
							{
								item.IDList = id;
								id++;
							});
							//var json = JsonConvert.SerializeObject(_listInformacoes);
							if (txtPaths.Text == "%appdata%")
								txtPaths.Text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
							//System.IO.File.WriteAllText(txtPaths.Text + "/SpotifyClone/Musics.json", json);
							bk.WriteReadMusic(false, txtPaths.Text, _listInformacoes, -1);
							Atualiza();
						}
						catch { Atualiza(); }
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
				case "TSMIPrevious":
					EventosPE("pE_previous");
					break;
				case "TSMIPause":
					try
					{
						if (labelControl2.Text != "")
						{
							if (FormVideo == false)
							{
								if (pE_PauseaPlay.Tag.ToString() == "0")
								{
									pE_PauseaPlay.Image = Properties.Resources.play;
									TSMIPause.Image = Properties.Resources.playB;
									pE_PauseaPlay.Tag = "1";
									axWindowsMediaPlayer1.Ctlcontrols.pause();
								}
								else
								{
									pE_PauseaPlay.Image = Properties.Resources.pause;
									pE_PauseaPlay.Tag = "0";
									axWindowsMediaPlayer1.Ctlcontrols.play();
									TSMIPause.Image = Properties.Resources.pauseB;
								}
							}
							else
							{
								if (pE_PauseaPlay.Tag.ToString() == "0")
								{
									pE_PauseaPlay.Image = Properties.Resources.play;
									TSMIPause.Image = Properties.Resources.playB;
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
									TSMIPause.Image = Properties.Resources.pauseB;
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
				case "TSMINext":
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
						Discord(labelControl2.Text, int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString()), int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration.ToString()));
						pE_PauseaPlay.Tag = "0";
						dt = 0;
					}
					catch (Exception ex)
					{
						MessageBox.Show("\nERROR 404\n" + ex.Message + "!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
				case "TSMIClose":
					Application.Exit();
					break;

			}
		}
		private void AuxForm2(object tag)
		{
			int idplay = 0;
			try
			{
				if (txtPaths.Text == "%appdata%")
					txtPaths.Text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				atualizacao = false;
				try
				{
					if ((int)tag != 0)
					{
						idplay = (int)tag;
						atualizacao = true;
					}
					else
					{
						idplay = 0;
						atualizacao = false;
					}
				}
				catch
				{
					MessageBox.Show("Your were very fast!! Take it easy,beacuse the program dont detect playList", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				Screen scr = Screen.FromControl(this);
				List<Screen> lstemps = new List<Screen>();
				foreach (var screen in Screen.AllScreens)
					lstemps.Add(screen);
				ecra = (lstemps.FindIndex(dsssss => dsssss.DeviceName == scr.DeviceName));
				Form2 form2 = new Form2(atualizacao, idplay, ecra, (txtPaths.Text));
				icnNotification.Visible = false;
				form2.ShowDialog();
				form2.Close();
				_listInformacoes = bk.WriteReadMusic(true, txtPaths.Text, null, (idplay - 1)).OrderBy(x => x.Caminho_da_Musica).ToList();
				if (!bgwCarregar.IsBusy) bgwCarregar.RunWorkerAsync();
				this.Tag = "AddPnl";
			}
			catch (Exception ex)
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

		private void trackBar1_Click(object sender, EventArgs e)
		{
			labelControl2.Focus();
		}
		#endregion
		#region NEW SOURCE
		List<Settings> settings = new List<Settings>();

		#region teste 
		public void EventosPE(string nome)
		{
			switch (nome)
			{
				case "pE_Next":
					{
						try
						{
							if (int.Parse(labelControl2.Tag.ToString()) == _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1)
								labelControl2.Tag = "" + 0;
							else
								labelControl2.Tag = "" + ((int.Parse(labelControl2.Tag.ToString())) + 1);
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
								fmr.timer1_Tick(senders, es);
								timer1.Stop();
							}
							pE_PauseaPlay.Image = Properties.Resources.pause;
							Discord(labelControl2.Text, int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString()), int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration.ToString()));
							pE_PauseaPlay.Tag = "0";
							dt = 0; PBC.Value = 0;
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
									TSMIPause.Image = Properties.Resources.playB;
									axWindowsMediaPlayer1.Ctlcontrols.pause();
								}
								else
								{
									pE_PauseaPlay.Image = Properties.Resources.pause;
									TSMIPause.Image = Properties.Resources.pauseB;
									pE_PauseaPlay.Tag = "0";
									axWindowsMediaPlayer1.Ctlcontrols.play();
								}
							}
							else
							{
								if (pE_PauseaPlay.Tag.ToString() == "0")
								{
									pE_PauseaPlay.Image = Properties.Resources.play;
									TSMIPause.Image = Properties.Resources.playB;
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
									TSMIPause.Image = Properties.Resources.pauseB;
									pE_PauseaPlay.Tag = "0";
									CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
									if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition != 0)
										Posicao = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
									Volume = labelControl4.Text;
									Processo = "start";
								}
								fmr.timer1_Tick(senders, es);
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
								CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
								fmr.timer1_Tick(senders, es);
							}
							pE_PauseaPlay.Image = Properties.Resources.pause;
							pE_PauseaPlay.Tag = "0";
							Discord(labelControl2.Text, int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString()), int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration.ToString()));
							dt = 0; PBC.Value = 0;
						}
						catch (Exception ex)
						{
							MessageBox.Show("\nERROR 404\n" + ex.Message + "!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						break;
					}
			}
			if (FormVideo == true)
				Video.info = "";

			pnlTop.Tag = "0";
		}
		object senders;
		EventArgs es;
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

			switch (((Label)sender).Name)
			{
				//case "lblAnterior":
				//	btnAnterior.Text = btnAnterior.Text.Remove((btnAnterior.Text.Length - 3));
				//	break; ;
				//case "lblPR":
				//	btnPausa.Text = btnPausa.Text.Remove((btnPausa.Text.Length - 3));
				//	break;
				//case "lblSeguinte":
				//	btnNext.Text = btnNext.Text.Remove((btnNext.Text.Length - 3));
				//	break;
				case "lblSO":
					var ds = switchSO.Checked == true ? switchSO.Checked = false : switchSO.Checked = true;
					break;
				case "lblNomeDisc":
					ds = switchNome.Checked == true ? switchNome.Checked = false : switchSO.Checked = true;
					break;
				case "lblDuracao":
					ds = switchDuracao.Checked == true ? switchDuracao.Checked = false : switchDuracao.Checked = true;
					break;
				case "lblVersao":
					pnlXampp.Visible = true;
					break;
				case "lblMusic":
					IdPlayList = (int)((Label)sender).Tag; MusicaPlay();
					break;
				case "lblMini":
					ds = switchMini.Checked == true ? switchMini.Checked = false : switchMini.Checked = true;
					break;
				case "lblInfoMusic":
					ds = switchMusic.Checked == true ? switchMusic.Checked = false : switchMusic.Checked = true;
					break;
				default:
					break;
			}
			if (((Label)sender).Name == "lblDuracao" || ((Label)sender).Name == "lblNomeDisc" || ((Label)sender).Name == "lblSO")
				SaveSettings(null);
			//btnSel = null;
		}
		#endregion
		//System.Windows.Forms.Button btnSel;
		private void Btn_TeclasAtalhos(object sender, EventArgs e)
		{
			((System.Windows.Forms.Button)sender).Text = "";
		}
		private void trackBar1_ValueChanged(object sender, EventArgs e) { TrackBar track = sender as TrackBar; int d = (track.Value * 10); axWindowsMediaPlayer1.settings.volume = d; labelControl4.Text = d.ToString(); labelControl2.Focus(); if (FormVideo == true) { Volume = d.ToString(); fmr.timer1_Tick(sender, e); timer1.Stop(); } }
		public Form1()
		{
			InitializeComponent();
		}
		private void bgwCarregar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
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
				pnlpri.BackColor = Color.FromArgb(200, 200, 174);
				pnlpri.Location = new Point(0, 0);
				pnlpri.Dock = DockStyle.Top;
				pnlpri.Size = new Size(pnlPrincipal.Width, 155);
				pnlPrincipal.Controls.Add(pnlpri);
				try
				{
					PictureBox pE_ = new PictureBox();
					pE_.Location = new Point(20, 5);
					pE_.Size = new Size(164, 136);
					pE_.BackColor = Color.FromArgb(200, 200, 174);
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
				lblPl.Location = new Point(220, 25);
				lblPl.Size = new Size(61, 13);
				lblPl.BorderStyle = BorderStyle.None;
				lblPl.Font = new Font("Tahoma", 9, FontStyle.Regular);
				lblPl.BackColor = Color.Transparent;
				lblPl.ForeColor = Color.Black;
				pnlpri.Controls.Add(lblPl);
				Label lbl = new Label();
				try
				{
					var ds = _listInformacoes[(IdPlayList - 1)].Name.Count() > 30 ? lbl.Text = _listInformacoes[(IdPlayList - 1)].Name.Substring(0, 30) : lbl.Text = _listInformacoes[(IdPlayList - 1)].Name;
					lbl.Location = new Point(220, 39);
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
				lbl1.Location = new Point(220, 66);
				lbl1.AutoSize = false;
				lbl1.Size = new Size(314, 40);
				lbl1.BorderStyle = BorderStyle.None;
				lbl1.BackColor = Color.Transparent;
				lbl1.Font = new Font("Times New Roman", 9, FontStyle.Italic);
				lbl1.ForeColor = Color.Black;
				pnlpri.Controls.Add(lbl1);
				System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
				btn.Location = new Point(220, 110);
				btn.Size = new Size(150, 30);
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
				pe.Location = new Point(587, 110);
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
				Panel pnlseg = new Panel();
				pnlseg.Dock = DockStyle.Fill;
				pnlseg.BackColor = Color.FromArgb(200, 200, 174);
				pnlPrincipal.Controls.Add(pnlseg);
				Panel pnl = new Panel();
				pnl.Location = new Point(5, 160);
				pnl.AutoScroll = true;
				pnl.Size = new Size((pnlseg.Width - 10), (pnlseg.Height - 230));
				pnl.BorderStyle = BorderStyle.None;
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
								lbl2.Anchor = AnchorStyles.Left;
								lbl2.Font = new Font("Arial", 8, FontStyle.Italic);
								pnl1.Controls.Add(lbl2);
								PictureBox picture = new PictureBox();
								picture.Image = Properties.Resources.close_red;
								picture.Location = new Point(pnl1.Width - 40, (pnl1.Height / 2) - 10);
								picture.Size = new Size(20, 20);
								picture.SizeMode = PictureBoxSizeMode.Zoom;
								picture.BorderStyle = BorderStyle.None;
								picture.BackColor = Color.Transparent;
								picture.Anchor = AnchorStyles.Right;
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
								lbl2.Text = "Vê todas as musicas, ...";
								lbl2.ForeColor = Color.Black;
								lbl2.Font = new Font("Times New Roman", 12, FontStyle.Italic);
								lbl2.TextAlign = ContentAlignment.MiddleCenter;
								lbl2.Anchor = AnchorStyles.Right | AnchorStyles.Left;
								pnl1.Controls.Add(lbl2);
								PictureBox picture = new PictureBox();
								picture.Image = Properties.Resources.down;
								picture.Location = new Point(pnl1.Width - 40, 5);
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
						lbl.Name = "lblMusic";
						lbl.MouseDown += Lbl_MouseDown;
						lbl.Click += label11_Click;
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
			if (this.Tag.ToString() == "")
			{
				try
				{
					conf = JsonConvert.DeserializeObject<List<ConfIdioma>>(Properties.Resources.SettingsIdioma);

					lblEscIdioma.Text = conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].lblEscIdioma;
					lblSO.Text = conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].lblEscIdioma;
					lblTitMini.Text = conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].lblTitMini;
					lblMini.Text = conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].lblMini;
					lblnotif.Text = conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].lblnotif;
					lblInfoMusic.Text = conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].lblInfoMusic;
					chkDiscord.Text = conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].chkDiscord;
					lblNomeDisc.Text = conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].lblNomeDisc;
					lblDuracao.Text = conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].lblDuracao;
					lblinfoDu.Text = conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].lblinfoDu;
					lbltec.Text = conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].lbltec;
					chkAtalho.Text = conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].chkAtalho;
					lblAnt.Text = conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].lblAnt;
					lblPaRe.Text = conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].lblPaRe;
					lblSeg.Text = conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].lblSeg;
				}
				catch { MessageBox.Show("ERROR"); }
			}
			icnNotification.Visible = true;
		}
		private void bgwCarregar_DoWork(object sender, DoWorkEventArgs e)
		{
			if (this.Tag.ToString() != "MusicaPlay")
			{
				try
				{
					if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt"))
						txtPaths.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/helper.txt");
					Backend bk = new Backend();
					try
					{
						List<Settings> lst = bk.WriteReadSettings(txtPaths.Text, true, "");
						SaveSettings(lst[0]);
						if (lst[0].atal == 1)
						{
							//SubscribeGlobal();
							//FormClosing += Main_Closing;
							//Ativar evento do keybind

						}
					}
					catch { }
					Discord("Nome da Musica", 0, 0);
					_listInformacoes = bk.WriteReadMusic(true, txtPaths.Text, null, -1).OrderBy(x => x.IDList).ToList();
				}
				catch
				{

				}
			}
		}

		private TimeSpan time(int time)
		{
			TimeSpan result = TimeSpan.FromSeconds(time);
			return result;
		}
		#region teste discord5
		DiscordRpcClient client;
		DateTime start = DateTime.UtcNow;
		private void Discord(string NomeMusic, int tempoatual, int duracao)
		{
			if (chkDiscord.Checked)
			{
				if (!switchNome.Checked)
					NomeMusic = "catJAM catJAM catJAM catJAM ";
				if (client == null)
				{
					client = new DiscordRpcClient("863871149598048297", -1);

					client.Initialize();
				}
				string temp = "";
				if (tempoatual != 0 && duracao != 0 && switchDuracao.Checked)
					try
					{
						TimeSpan timesat = time(tempoatual);
						TimeSpan timesend = time(duracao);
						temp = "" + timesat + "/" + timesend;
					}
					catch { }
				var rp = new RichPresence()
				{
					Details = "" + NomeMusic,
					State = "" + temp,
					Assets = new Assets()
					{
						SmallImageKey = "spotifyicon",
						LargeImageKey = "catjam",
					}
				};

				if (!(switchDuracao.Checked) || duracao == 0)
					rp.Timestamps = new Timestamps(start);

				client.SetPresence(rp);
			}
		}
		#endregion

		private void Form1_Load(object sender, EventArgs e)
		{
			Invalidate();
			axWindowsMediaPlayer1.Visible = false;
			atualizacao = false;
			pnlSettings.BringToFront();
			comboBox1.Text = comboBox1.Items[0].ToString();

			this.Tag = "AddPnl";

			Process[] procs = Process.GetProcessesByName("Spotify Clone");
			if (procs.Length > 1) foreach (Process proc in procs)
				{
					if (proc != procs[0]) proc.Kill();
				}
			CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
			if (defaultPlaybackDevice.Volume >= 50)
			{
				if (MessageBox.Show("I down volume the your computer,to your security!!!\nIf not like,click in \"Não\",else click in \"Sim\" I reduce the volume!!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					System.Diagnostics.Process.Start("sndvol.exe");
					this.CenterToScreen();
				}
			}

			if (!bgwCarregar.IsBusy) bgwCarregar.RunWorkerAsync();
		}
		private void SaveSettings(Settings settings)
		{
			if (settings == null)
			{
				int SO = switchSO.Checked ? SO = 1 : SO = 0;
				int Discord = chkDiscord.Checked ? Discord = 1 : Discord = 0;
				int Enviar = switchNome.Checked ? Enviar = 1 : Enviar = 0;
				int Duracao = switchDuracao.Checked ? Duracao = 1 : Duracao = 0;
				int Atalho = chkAtalho.Checked ? Atalho = 1 : Atalho = 0;
				int Mini = switchMini.Checked ? Mini = 1 : Mini = 0;
				int NotifMusic = switchMusic.Checked ? NotifMusic = 1 : NotifMusic = 0;
				string Xampp = txtXAMPP.Text;
				if (Xampp != "")
				{
					pnlXampp.Visible = true;
					picXAMPP.LoadAsync("https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Flabinator.com%2Fwp-content%2Fuploads%2F2019%2F07%2FXAMPP-Logo.png&f=1&nofb=1");
				}

				Backend back = new Backend();
				List<Settings> st = back.UpdateSettings(comboBox1.Text, SO, Discord, Enviar, Duracao, Atalho, Mini, NotifMusic, btnAnterior.Text, btnPausa.Text, btnNext.Text, txtPaths.Text, Xampp);
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
					ds = settings.AutoRun == 1 ? switchSO.Checked = true : switchSO.Checked = false;
					ds = settings.Minimizar == 1 ? switchMini.Checked = true : switchMini.Checked = false;
					ds = settings.NotifMusic == 1 ? switchMusic.Checked = true : switchMusic.Checked = false;
					var dss = settings.Idioma != "Português" ? comboBox1.Text = comboBox1.Items[0].ToString() : comboBox1.Text = comboBox1.Items[1].ToString();
					if (settings.XAMPP != "")
					{
						txtXAMPP.Text = settings.XAMPP;
						pnlXampp.Visible = true;
						picXAMPP.LoadAsync("https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Flabinator.com%2Fwp-content%2Fuploads%2F2019%2F07%2FXAMPP-Logo.png&f=1&nofb=1");
					}

					var dsss = txtXAMPP.Text != "" ? picXAMPP.Invoke((MethodInvoker)(() => picXAMPP.Visible = true)) : picXAMPP.Invoke((MethodInvoker)(() => picXAMPP.Visible = false));

					if (settings.discord != null)
					{
						ds = settings.discord[0].Duracao == 1 ? switchDuracao.Checked = true : switchDuracao.Checked = false;
						ds = settings.discord[0].EnviarNome == 1 ? switchNome.Checked = true : switchNome.Checked = false;
					}
					if (settings.Atalhos != null)
					{
						btnAnterior.Text = settings.Atalhos[0].MusicaAnterior;
						btnPausa.Text = settings.Atalhos[0].Pausa;
						btnNext.Text = settings.Atalhos[0].MusicaSeguinte;
					}
					txtPaths.Text = settings.Paths;
					var dds = settings.Idioma == "Português" ? comboBox1.Invoke((MethodInvoker)(() => comboBox1.SelectedItem = "Português")) : comboBox1.Invoke((MethodInvoker)(() => comboBox1.SelectedItem = "Inglês"));
				}
				catch { }

			}
			RegistryKey startupKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
			if (switchSO.Checked)
			{
				startupKey.Close();
				startupKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				startupKey.SetValue("Spotify Clone", "\"" + Application.ExecutablePath + "\"");
				startupKey.Close();
			}
			else
			{
				startupKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				startupKey.DeleteValue("Spotify Clone", false);
				startupKey.Close();
			}

			if (txtXAMPP.Text != "")
				picXAMPP.Invoke((MethodInvoker)(() => picXAMPP.Visible = true));
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
					string paths = "" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);//meter o valor da txtpaths.text
					var fsd = new FolderSelectDialog();
					fsd.Title = "Selecione um caminho onde quere guardar os ficheiros";
					fsd.InitialDirectory = txtPaths.Text;
					if (txtPaths.Text == "%appdata%")
						fsd.InitialDirectory = paths;
					if (fsd.ShowDialog(IntPtr.Zero))
						if (!fsd.FileName.Contains("" + paths))
						{
							if (System.IO.File.Exists(paths + "/SpotifyClone/Musics.json"))
								System.IO.File.Delete(paths + "/SpotifyClone/Musics.json");
							if (System.IO.File.Exists(paths + "/SpotifyClone/Settings.json"))
								System.IO.File.Delete(paths + "/SpotifyClone/Settings.json");
							if (Directory.Exists(paths + "/SpotifyClone"))
								Directory.Delete(paths + "/SpotifyClone");
							txtPaths.Text = fsd.FileName;
						}
					bk.WriteReadMusic(false, txtPaths.Text, null, -1);
					break;
				case "pE_Close":
					if (switchMini.Checked)
					{
						FormCollection Sfc = Application.OpenForms;
						foreach (Form frm in Sfc) { frm.Visible = false; }
						this.WindowState = FormWindowState.Minimized;
					}
					else
						Application.Exit();
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
					List<Screen> lstemp = new List<Screen>();
					foreach (var screen in Screen.AllScreens)
						lstemp.Add(screen);
					int n = lstemp.FindIndex(dsssss => dsssss.DeviceName == scrn.DeviceName);
					if (this.Size == new Size(800, 450))
					{
						FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
						Left = Top = 0;
						Width = Screen.AllScreens[n].WorkingArea.Width;
						Height = Screen.AllScreens[n].WorkingArea.Height;
						this.Location = Screen.AllScreens[n].WorkingArea.Location;
					}
					else
					{
						WindowState = FormWindowState.Normal;
						this.Size = new Size(800, 450);
						Width = 800;
						Height = 450;
						Left = (Screen.AllScreens[n].WorkingArea.Width) / 5;
						Top = (Screen.AllScreens[n].WorkingArea.Height) / 5;
						this.Location = Screen.AllScreens[n].WorkingArea.Location;
						this.CenterToScreen();
					}
					break;

				#endregion
				#region novos
				case "pctXAMPP":
					OpenFileDialog ofds = new OpenFileDialog();
					ofds.Filter = "Exe XAMPP (*.exe)|*.exe";
					ofds.Multiselect = false;
					if ((ofds.ShowDialog() == DialogResult.OK) && ofds.SafeFileName.Contains("xampp-control.exe"))
					{
						txtXAMPP.Tag = "";
						txtXAMPP.Text = ofds.FileName;
						string[] pathsss = ofds.FileNames[0].Split('\\');
						foreach (string ext in pathsss)
							if (ext != pathsss[(pathsss.Length - 1)])
								txtXAMPP.Tag += ext + '\\';

						txtXAMPP.Tag = txtXAMPP.Tag.ToString().Remove((txtXAMPP.Tag.ToString().Length - 1));
						if (MessageBox.Show("Ele vai mandar as musicas todas para a pasta do XAMPP!!\nPoderá demorar algum tempo ... tem a certeza que quer continuar?!!?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
						{
							bk.Xampp(txtXAMPP.Tag.ToString(), _listInformacoes);
							icnNotification.ShowBalloonTip(15, "Spotify Clone", conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].ICNXAMPP, ToolTipIcon.Info);
						}
					}
					break;
				case "picXAMPP":
#pragma warning disable CS0618
					string myIP = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
#pragma warning restore CS0618
					Process.Start($"http://{myIP}/Spotify_Clone_Site.html");
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
						timer1.Start();
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
					Discord(labelControl2.Text, int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString()), int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration.ToString()));
					break;
				case "pE_Repit":
					if (pE_Repit.Tag.ToString() == "0")
					{
						pE_Repit.Image = Properties.Resources.refresh1;
						pE_Repit.Tag = 1;
					}
					else
					{
						pE_Repit.Image = Properties.Resources.refresh;
						pE_Repit.Tag = 0;
					}
					break;
				case "pE_Next":
					EventosPE("pE_Next");
					break;
				case "pE_PauseaPlay":
					EventosPE("pE_PauseaPlay");
					break;
				case "pE_previous":
					EventosPE("pE_previous");
					break;
				case "pE_Random":
					try
					{
						Ordem_de_Reproducao.Clear();
						if (pE_Random.Tag.ToString() == "0")
						{
							try
							{
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
						MessageBox.Show(conf[comboBox1.Items.IndexOf(comboBox1.Text)].form1[0].MSGRANDOM, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					break;
				case "picAxw":
					FormVideo = false;
					FormCollection fc = Application.OpenForms;
					foreach (Form frm in fc) { if (frm.Name == "Video") FormVideo = true; }
					if (PBC.Value != 0 && FormVideo == false)
					{
						pnlPrincipal.Visible = false;
						axWindowsMediaPlayer1.Visible = true;
						axWindowsMediaPlayer1.BringToFront();
						axWindowsMediaPlayer1.Location = new Point(0, 0);
						pnlPrincipal.Controls.Clear(); axWindowsMediaPlayer1.Ctlcontrols.play();
						musica = true;
					}

					break;
				case "picForm3":
					{
						if (labelControl2.Text != "" && FormVideo == false)
						{
							Screen scr = Screen.FromControl(this);
							List<Screen> lstemps = new List<Screen>();
							foreach (var screen in Screen.AllScreens)
								lstemps.Add(screen);
							ecra = (lstemps.FindIndex(dsssss => dsssss.DeviceName == scr.DeviceName));
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
							try
							{
								Discord(labelControl2.Text, int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString()), int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration.ToString()));
							}
							catch { }
						}
					}
					break;
				case "picPlaylist":
					IdPlayList = (int)pE.Tag; MusicaPlay();
					break;
				case "picAddMusic":
					List<string> _Caminho_Musica = new List<string>();
					string[] files, path;
					PictureBox button = sender as PictureBox;
					OpenFileDialog ofd = new OpenFileDialog();
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
							_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica = _Caminho_Musica.OrderBy(x => x).ToList();
							bk.WriteReadMusic(false, txtPaths.Text, _listInformacoes, -1);
						}
						else
						{
							path.ToList().ForEach(item =>
							{
								if (_listInformacoes[IdPlayList - 1].Caminho_da_Musica.Contains(item) == false)
								{
									_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Add(item);
									NameMusic = item.Split(new string[] { "\\" }, StringSplitOptions.None);
									int TAMANHO = NameMusic.Length;
									int g = NameMusic[TAMANHO - 1].Count();
									string f = NameMusic[TAMANHO - 1].Substring(0, g);
									PlaydaLista.Add(f);
								}
							});
							bk.WriteReadMusic(false, txtPaths.Text, _listInformacoes, -1);
						}
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
					string Paths = "";
					var dss = txtPaths.Text == "%appdata%" ? Paths = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) : Paths = txtPaths.Text;
					bk.WriteReadMusic(false, txtPaths.Text, _listInformacoes, -1);
					MusicaPlay();
					break;
				case "picDown":
					this.Tag = "MusicaPlayD";
					if (!bgwCarregar.IsBusy) bgwCarregar.RunWorkerAsync();
					break;
				case "picInfos":
					MessageBox.Show("" + labelControl2.Text);
					break;
				case "pE_Form":
					FormVideo = false;
					FormCollection fcs = Application.OpenForms;
					foreach (Form frm in fcs)
					{
						if (frm.Name == "Video")
							FormVideo = true;
					}
					if (PBC.Value != 0 && FormVideo == false)
					{
						pnlPrincipal.Visible = false;
						axWindowsMediaPlayer1.Visible = true;
						axWindowsMediaPlayer1.BringToFront();
						axWindowsMediaPlayer1.Dock = DockStyle.Fill;
						axWindowsMediaPlayer1.Location = new Point(0, 0);
						pnlPrincipal.Controls.Clear();
						axWindowsMediaPlayer1.Ctlcontrols.play();
						musica = true;
					}
					break;
				case "picAddPlaylist":
					object tag = 0;
					AuxForm2(tag);
					break;
				#endregion
				default:
					break;
			}
		}

		private void icnNotification_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			icnNotification.Visible = false;
		}

		private void btnAnterior_KeyDown(object sender, KeyEventArgs e)
		{
			if (((System.Windows.Forms.Button)sender).Text == "")
				((System.Windows.Forms.Button)sender).Text += "" + e.KeyCode.ToString();
			else
				((System.Windows.Forms.Button)sender).Text += " + " + e.KeyCode.ToString();
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (pnlTop.Tag.ToString() == "0")
				pnlTop.Tag = "" + e.KeyCode.ToString();
			else
				pnlTop.Tag += " + " + e.KeyCode.ToString();

			Debug.Print("" + pnlTop.Tag.ToString());
		}




		#endregion

		#region modificando o codigo
		private void pE_Close_MouseHover(object sender, EventArgs e)
		{
			pE_Close.Image = Properties.Resources.close_red;
		}
		private void pE_Close_MouseLeave(object sender, EventArgs e)
		{
			pE_Close.Image = Properties.Resources.close_white;
		}


		private void timer1_Tick(object sender, EventArgs e)
		{
			if(pnlSettings.Visible != true)
				textBox1.Focus();
			dt++;
			if ((int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition != 0)
			{
				dt = 0;
				PBC.Value = ((int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
				PBC.Tag = ((int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
			}
			if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying)
			{
				PBC.Maximum = ((int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration);
				dt = 0;
			}
			if (PBC.Value == PBC.Maximum || PBC.Maximum == 0)
			{
				try
				{
					if ((panel6.Tag == null) && _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() != 1)
					{
						Debug.Print("" + labelControl2.Tag);
						var dsd = (int.Parse(labelControl2.Tag.ToString()) >= _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1) && pE_Repit.Tag.ToString() == "1" ? labelControl2.Tag = 0 : labelControl2.Tag = (int.Parse(labelControl2.Tag.ToString())) + 1;

						axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
						NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None);
						labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
						if (((int.Parse(labelControl2.Tag.ToString() + 1) != _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count()) && pE_Repit.Tag.ToString() != "1") && labelControl2.Text != _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[int.Parse(labelControl2.Tag.ToString())])
						{
							axWindowsMediaPlayer1.Ctlcontrols.play();
							dt = 0;
							if (switchMusic.Checked)
								icnNotification.ShowBalloonTip(25, "Next Music ", "" + labelControl2.Text, ToolTipIcon.Info);
						}
						PBC.Value = 0;
					}
					else
					{
						labelControl2.Tag = -1;
						labelControl2.Text = "";
						timer1.Stop();
						timer2.Stop();
						PBC.Value = 0;
						dt = 0;
						pE_PauseaPlay.Image = Properties.Resources.play;
						axWindowsMediaPlayer1.Ctlcontrols.stop();
						panel6.Tag = "";
					}
				}
				catch
				{
					axWindowsMediaPlayer1.Ctlcontrols.stop();
					PBC.Value = 0;
					timer1.Stop();
					PBC.Value = 0;
					timer2.Stop();
					dt = 0;
					pE_PauseaPlay.Image = Properties.Resources.play;
				}
			}
			else if (PBC.Tag != null)
				if (dt > 15 && panel6.Tag == null && PBC.Value == int.Parse(PBC.Tag.ToString()))
					timer2.Start();

			try
			{
				Discord(labelControl2.Text, (int)(axWindowsMediaPlayer1.Ctlcontrols.currentPosition), (int)(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration));
			}
			catch { }


			if (chkAtalho.Checked)
			{
				timer1.Tag = int.Parse(timer1.Tag.ToString()) + 1;
				if (pnlTop.Tag.ToString() != "0")
				{

					try
					{
						int temp = 0;
						bool btnAnte = true, btnNexts = true, btnPause = true;

						string[] key = pnlTop.Tag.ToString()/*.Replace(" ", string.Empty)*/.Split('+');
						if (key.Length == 1)
							//	key = key.Where(w => w != key[(key.Length - 1)]).ToArray();
							//else
							key = new[] { pnlTop.Tag.ToString() };
						string[] ant = btnAnterior.Text.Replace(" ", string.Empty).Split('+');
						string[] pau = btnPausa.Text.Replace(" ", string.Empty).Split('+');
						string[] nex = btnNext.Text.Replace(" ", string.Empty).Split('+');

						//Debug.Print("" + key.Length);
						if (key.Length == 2)
							Debug.Print("");
						key.ToList().ForEach(item =>
						{
							try
							{

								if ((ant[temp] == item.Replace(" ", string.Empty) && (key.Length) == ant.Length) && btnAnte == true && temp >= 0)
									btnAnte = true;
								else
									btnAnte = false;
							}
							catch { btnAnte = false; }
							try
							{
								if ((pau[temp] == item.Replace(" ", string.Empty) && (key.Length) == pau.Length) && btnPause == true && temp >= 0)
									btnPause = true;
								else
									btnPause = false;
							}
							catch { btnPause = false; }

							try
							{
								if ((nex[temp] == item.Replace(" ", string.Empty) && (key.Length) == nex.Length) && btnNexts == true && temp >= 0)
									btnNexts = true;
								else
									btnNexts = false;
							}
							catch { btnNexts = false; }
							temp++;
						});
						Debug.Print("Anterior: " + btnAnte + "\t Next: " + btnNexts + "\t Pause " + btnPause);
						if (btnNexts == true)
							EventosPE("pE_Next");
						else
						if (btnAnte == true)
							EventosPE("pE_previous");
						else
						if (btnPause == true)
							EventosPE("pE_PauseaPlay");

						if (int.Parse(timer1.Tag.ToString()) > 40)
						{
							timer1.Tag = 0;
							pnlTop.Tag = "0";
						}
						tmAtalho.Stop();
						key = key.Where(w => w != "").ToArray();
						temp = 0;

						//btnPause = false;
						//btnAnte = false;
						//btnNexts = false;
					}
					catch (Exception ex) { }
				}
			}
		}

		private void axwindows()
		{
			axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
			NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None);
			labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
			Discord(labelControl2.Text, int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString()), int.Parse(axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration.ToString()));
			timer1.Start();
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (FormVideo == false)
			{
				dt++;
				if (((PBC.Value == 0 || PBC.Value == (PBC.Maximum - 1)) || dt > 5) && pE_PauseaPlay.Tag.ToString() != "1" || dt > 10)
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
								if (switchMusic.Checked)
									icnNotification.ShowBalloonTip(25, "Next Music ", "" + labelControl2.Text, ToolTipIcon.Info);
								dt = 0;
								timer2.Stop();
							}
					}
				}
				else if (pE_PauseaPlay.Tag.ToString() == "1")
				{
					dt = 0;
				}
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
							timer2.Stop();
							PBC.Tag = 0;
							axwindows();
						}
					}
					catch { }
				}
				if (Video.progresso != 0)
					PBC.Maximum = (int)Video.maxprogresso;
				if (Ordem_de_Reproducao.Count > 0)
				{
					PBC.Tag = Video.progresso;
					if (CaMusica != (_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]]).ToString())
					{
						NameMusic = CaMusica.Split(new string[] { "\\" }, StringSplitOptions.None);
						labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
						if (Video.maxprogresso != 0)
							PBC.Maximum = (int)Video.maxprogresso;
					}
					if (PBC.Value == 1)
						dt = 0;
					if ((PBC.Value == PBC.Maximum || PBC.Value == (PBC.Maximum - 1)) && pE_PauseaPlay.Tag.ToString() != "1")
					{
						if (dt >= 12 || PBC.Value == Video.maxprogresso || PBC.Value == (PBC.Maximum - 1))
						{
							if (PBC.Tag != null && (PBC.Value == Video.maxprogresso) || PBC.Value == (PBC.Maximum - 1))
							{
								var dsd = (int.Parse(labelControl2.Tag.ToString()) == _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1) ? labelControl2.Tag = 0 : labelControl2.Tag = (int.Parse(labelControl2.Tag.ToString())) + 1;
								Volume = labelControl4.Text;
								Processo = "start";
								CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
								fmr.timer1_Tick(sender, e);
								Video.progresso = 0;
								dt = 0;
								PBC.Tag = null;
								PBC.Value = 0;
							}
						}
					}
					if (dt == 0) { PBC.Tag = Video.progresso; dt++; }
					if (int.Parse(PBC.Tag.ToString()) == Video.progresso) { dt = 0; }
					if ((dt > 0 && dt < 100) && pE_PauseaPlay.Tag.ToString() != "1")
					{
						dt++;
						try
						{
							if ((((int.Parse(PBC.Tag.ToString()) + 1) != Video.progresso || (int.Parse(PBC.Tag.ToString())) != Video.progresso) && dt > 70))
							{
								var dsd = (int.Parse(labelControl2.Tag.ToString()) == _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1) ? labelControl2.Tag = 0 : labelControl2.Tag = (int.Parse(labelControl2.Tag.ToString())) + 1;
								Volume = labelControl4.Text;
								Processo = "start";
								fmr.timer1_Tick(sender, e);
								Video.progresso = 0;
								dt = 0;
								PBC.Tag = null;
								Processo = "start";
							}
						}
						catch
						{
						}
					}
					else
						dt = 0;
				}
				try
				{
					if ((int)Video.progresso != 0)
						PBC.Value = (int)Video.progresso;
				}
				catch { }
				if (Video.info != "" && Video.info != null)
					EventosPE(Video.info);
				timer1.Start();
			}
		}


		#endregion
	}
}