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

namespace Spotify_Clone
{
	public partial class Form1 : Form
	{
		#region propriedades do windows
		const int WS_MINIMIZEBOX = 0x20000; const int CS_DBLCLKS = 0x8;
		private void pnlTop_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
		public const int WM_NCLBUTTONDOWN = 0xA1; public const int HT_CAPTION = 0x2;[DllImportAttribute("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);[DllImportAttribute("user32.dll")] public static extern bool ReleaseCapture();
		protected override CreateParams CreateParams { get { CreateParams cp = base.CreateParams; cp.Style |= WS_MINIMIZEBOX; cp.ClassStyle |= CS_DBLCLKS; return cp; } }
		#endregion
		#region variaveis globais
		public static int IdPlayList; private bool atualizacao, musica; public List<string> PlaydaLista = new List<string>(); public List<PlayList> _listInformacoes = new List<PlayList>(); public List<string> _Caminho_Musica = new List<string>(); public List<double> Ordem_de_Reproducao = new List<double>(); int dt; bool FormVideo = false; public static string[] NameMusic; public static string Processo = "", Posicao = "", CaMusica = "", Volume = ""; Video fmr = new Video(); public static int t;
		#endregion
		#region Form
		public Form1() { InitializeComponent(); }
		private void Form1_Load(object sender,EventArgs e){Invalidate();pictureBox1.Click+=pE_minimizar_Click;atualizacao=false;if(!backgroundWorker1.IsBusy)backgroundWorker1.RunWorkerAsync();escrever();Process[]procs=Process.GetProcessesByName("Spotify Clone");if(procs.Length>1)foreach(Process proc in procs){if(proc!=procs[0])proc.Kill();}CoreAudioDevice defaultPlaybackDevice=new CoreAudioController().DefaultPlaybackDevice;if(defaultPlaybackDevice.Volume>=50){if(MessageBox.Show("I down the volume the your computer,to your security!!!\nIf not like,click in \"Não\",if click in \"Sim\" I am reduce the volume!!","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){System.Diagnostics.Process.Start("sndvol.exe");defaultPlaybackDevice.Volume = 30;}}}
		#endregion
		#region PictureBox
		private void pE_Close_Click(object sender, EventArgs e) { Application.Exit(); }
		private void pE_Close_MouseHover(object sender, EventArgs e) { pE_Close.Image = Properties.Resources.close_red; }
		private void pictureEdit3_Click(object sender, EventArgs e) { object tag = 0; AuxForm2(tag); _listInformacoes.Clear(); escrever(); Atualiza(); }
		private void pE_Close_MouseLeave(object sender, EventArgs e) { pE_Close.Image = Properties.Resources.close_white; }
		private void pE_NorMax_Click(object sender, EventArgs e) { Atualiza(); }
		private void pE_minimizar_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
		private void pictureBox5_Click(object sender, EventArgs e) { if (pE_Repit.Tag.ToString() == "0") { pE_Repit.Image = Properties.Resources.refresh__2_; pE_Repit.Tag = 1; } else { pE_Repit.Image = Properties.Resources.refresh__3_; pE_Repit.Tag = 0; } }
		public void pictureBox4_Click(object sender, EventArgs e) { if (int.Parse(labelControl2.Tag.ToString()) == _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1) labelControl2.Tag = "" + 0; else labelControl2.Tag = "" + ((int.Parse(labelControl2.Tag.ToString())) + 1); try { if (FormVideo == false) { axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]]; NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None); labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4)); axWindowsMediaPlayer1.Ctlcontrols.play(); } else { pE_PauseaPlay.Image = Properties.Resources.pause; pE_PauseaPlay.Tag = "0"; CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]]; Volume = labelControl4.Text; Processo = "start"; NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None); labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4)); fmr.timer1_Tick(sender, e); timer1.Stop(); } } catch { try { axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int.Parse(labelControl2.Tag.ToString()) + 1)]; NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None); labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4)); axWindowsMediaPlayer1.Ctlcontrols.play(); } catch { MessageBox.Show("\t            Erro 404\nIn " + _listInformacoes[(IdPlayList - 1)].Name + " dont exist music!!\nClick in Play!!", "ERRO 404", MessageBoxButtons.OK, MessageBoxIcon.Error); } } pE_PauseaPlay.Image = Properties.Resources.pause; pE_PauseaPlay.Tag = "0"; }
		private void PIC_Click(object sender, EventArgs e) { FormVideo = false; FormCollection fc = Application.OpenForms; foreach (Form frm in fc) { if (frm.Name == "Video") FormVideo = true; } if (PBC.Value != 0 && FormVideo == false) { pnlPrincipal.Visible = false; axWindowsMediaPlayer1.Visible = true; axWindowsMediaPlayer1.BringToFront(); axWindowsMediaPlayer1.Dock = DockStyle.Fill; axWindowsMediaPlayer1.Location = new Point(0, 0); pnlPrincipal.Controls.Clear(); axWindowsMediaPlayer1.Ctlcontrols.play(); musica = true; } }
		private void pEAdicionar_Click(object sender, EventArgs e)
		{
			string[] files, path; PictureBox button = sender as PictureBox; OpenFileDialog ofd = new OpenFileDialog(); ofd.Multiselect = true; ofd.Filter = "Video and Music Files (*.mp3,*.au,*.m4a,*.mp4,*.m4v,*.mp4v)|*.mp3;*.au;*.m4a;*.mp4;*.m4v;*.mp4v"; ofd.Multiselect = true; if (ofd.ShowDialog() == DialogResult.OK)
			{
				files = ofd.SafeFileNames; path = ofd.FileNames; if (PlaydaLista.Count() == 0) { path.ToList().ForEach(item => { _Caminho_Musica.Add(item); NameMusic = item.Split(new string[] { "\\" }, StringSplitOptions.None); int TAMANHO = NameMusic.Length; int g = NameMusic[TAMANHO - 1].Count(); string f = NameMusic[TAMANHO - 1].Substring(0, g); PlaydaLista.Add(f); }); } else { path.ToList().ForEach(item => { if (_listInformacoes[IdPlayList - 1].Caminho_da_Musica.Contains(item) == false) { _Caminho_Musica.Add(item); NameMusic = item.Split(new string[] { "\\" }, StringSplitOptions.None); int TAMANHO = NameMusic.Length; int g = NameMusic[TAMANHO - 1].Count(); string f = NameMusic[TAMANHO - 1].Substring(0, g); PlaydaLista.Add(f); } }); }
				_listInformacoes[IdPlayList - 1].Caminho_da_Musica = _Caminho_Musica;
				Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");
				string json = JsonConvert.SerializeObject(_listInformacoes);
				File.WriteAllText(Environment.CurrentDirectory + "/Musicas.json", json);
				MusicaPlay(IdPlayList - 1);
			}
			Invalidate();
		}
		private void pE_PauseaPlay_Click(object sender, EventArgs e)
		{
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
							pE_PauseaPlay.Tag = "0"; axWindowsMediaPlayer1.Ctlcontrols.play();
						}
					}
					else
					{
						if (pE_PauseaPlay.Tag.ToString() == "0")
						{
							pE_PauseaPlay.Image = Properties.Resources.play; pE_PauseaPlay.Tag = "1";
							CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
							if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition != 0) Posicao = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
							Volume = labelControl4.Text;
							Processo = "pause";
						}
						else
						{
							pE_PauseaPlay.Image = Properties.Resources.pause; pE_PauseaPlay.Tag = "0";
							CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
							if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition != 0)
								Posicao = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
							Volume = labelControl4.Text;
							Processo = "start";
						}
						fmr.timer1_Tick(sender, e);
						timer1.Stop();
					}
				}
			}catch (Exception ex){MessageBox.Show("\t            ERROR 404\n " + ex.Message + " !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);}}

		private void pE_previous_Click(object sender, EventArgs e) { try { if (int.Parse(labelControl2.Tag.ToString()) == 0) labelControl2.Tag = "" + (_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1); else labelControl2.Tag = (int.Parse(labelControl2.Tag.ToString())) - 1; if (FormVideo == false) { axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]]; NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None); labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4)); axWindowsMediaPlayer1.Ctlcontrols.play(); } else { CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]]; if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition != 0) Posicao = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString(); Volume = labelControl4.Text; Processo = "pause"; NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None); labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4)); fmr.timer1_Tick(sender, e); timer1.Stop(); } } catch (Exception ex) { MessageBox.Show("\t            ERROR 404\n " + ex.Message + " !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); } pE_PauseaPlay.Image = Properties.Resources.pause; pE_PauseaPlay.Tag = "0"; }
		private void pE_Random_Click(object sender, EventArgs e){try{Ordem_de_Reproducao.Clear();if (pE_Random.Tag.ToString() == "0"){try{foreach (string a in _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica)Ordem_de_Reproducao.Add(0.0001);for (int d = 0; d < _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count(); d++){aqui:Random rd = new Random();int r = rd.Next(0, _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count());if (!Ordem_de_Reproducao.Contains(r)){Ordem_de_Reproducao[d] = r;pE_Random.Image = Properties.Resources.change_1;}else{goto aqui;}}}catch (Exception ex){MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}pE_Random.Tag = "1";}else{for(int a = 0; a < _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count(); a++)Ordem_de_Reproducao.Add(a);pE_Random.Image = Properties.Resources.change;pE_Random.Tag = "0";}}catch{MessageBox.Show("At the moment,dont select playList!! \n OR \n The playList dont ahve musics!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);}}

		private void pE_Click(object sender, EventArgs e) { PictureBox pE = sender as PictureBox; IdPlayList = (int)pE.Tag; MusicaPlay((int)pE.Tag - 1); }
		private void PicEdit_MouseHover(object sender, EventArgs e) { PictureBox picture = sender as PictureBox; TSMIRemove.Tag = (int)picture.Tag; TSMIEditPlayList.Tag = (int)picture.Tag; }
		#endregion
		#region Background
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e){try{Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");var myString = File.ReadAllText(Environment.CurrentDirectory + "/Musicas.json");if (myString == "\"[]\""){var json = JsonConvert.SerializeObject("[]");json = json.Replace("\"", "");File.WriteAllText(Environment.CurrentDirectory + "/Musicas.json", json);return;}}catch(Exception ex){Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");MessageBox.Show("Erro: " + ex.Message + "\n\n Lose all musics!!!\n I create a new playList!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);File.CreateText(Environment.CurrentDirectory + "Musicas.json");MessageBox.Show("I'm create new paste,see there,if you don't lose this document again!!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);}}
		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) { Atualiza(); }
		#endregion
		#region ToolStripMenuItem
		private void removeThePlayListToolStripMenuItem_Click(object sender, EventArgs e){try{Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");ToolStripMenuItem tag = sender as ToolStripMenuItem;if (pictureBox2.Tag != null)if (int.Parse(pictureBox2.Tag.ToString()) == (int)tag.Tag){PBC.Value = 0;labelControl2.Text = "";labelControl2.Tag = "";axWindowsMediaPlayer1.URL = null;pE_Random.Enabled = false;timer1.Stop(); timer2.Stop();pE_Random.Tag = 0;labelControl4.Text = 50.ToString();pE_PauseaPlay.Tag = 0; pE_PauseaPlay.Image = Properties.Resources.play; pE_Random.Image = Properties.Resources.change;axWindowsMediaPlayer1.Visible = false;if (FormVideo == true){FormCollection fc = Application.OpenForms;foreach (Form frm in fc){if (frm.Name == "Video")frm.Close();}}}IdPlayList = (int)tag.Tag;_listInformacoes.Remove(_listInformacoes.FirstOrDefault(row => row.IDList == (int)tag.Tag));var json = JsonConvert.SerializeObject(_listInformacoes);File.WriteAllText(Environment.CurrentDirectory + "/Musicas.json", json);Atualiza();}catch{Atualiza();}}
		private void editPlayListToolStripMenuItem_Click(object sender, EventArgs e) { try { ToolStripMenuItem tsmi = sender as ToolStripMenuItem; atualizacao = true; IdPlayList = (int)tsmi.Tag; AuxForm2(tsmi.Tag); } catch { MessageBox.Show("\t            Erro to detect the playList!!\nyou were very fast!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error); } }
		#endregion
		#region Funções Criadas
		private void AuxForm2(object tag){try{Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");atualizacao = false;try{if ((int)tag != 0){IdPlayList = (int)tag;atualizacao = true;}else{IdPlayList = 0;atualizacao = false;}}catch{MessageBox.Show("Your were very fast!! Take it easy,beacuse the program dont detect playList", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);return;}Form2 form2 = new Form2(atualizacao, IdPlayList);form2.ShowDialog();form2.Close();escrever();int a = 1;_listInformacoes.ToList().ForEach(item =>{item.IDList = a; a++;});form2.Close();var json = JsonConvert.SerializeObject(_listInformacoes);File.WriteAllText(Environment.CurrentDirectory + "/Musicas.json", json);}catch{return;}Atualiza();}
		private void MusicaPlay(int tag) { pnlPrincipal.Controls.Clear(); int widht = Screen.PrimaryScreen.Bounds.Width; int height = Screen.PrimaryScreen.Bounds.Height; musica = true; pnlPrincipal.Visible = true; axWindowsMediaPlayer1.Visible = false; try { PlaydaLista.Clear(); _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.ToList().ForEach(item => { NameMusic = item.Split(new string[] { "\\" }, StringSplitOptions.None); int TAMANHO = NameMusic.Length; int g = NameMusic[TAMANHO - 1].Count(); string f = NameMusic[TAMANHO - 1].Substring(0, g); if (PlaydaLista.Contains(f) == false) PlaydaLista.Add(f); }); } catch { } try { PictureBox pE_ = new PictureBox(); pE_.Location = new Point(20, 5); pE_.Size = new Size(164, 136); pE_.BackColor = Color.Silver; pE_.LoadAsync(_listInformacoes[(tag)].Image); pE_.SizeMode = PictureBoxSizeMode.Zoom; pE_.BorderStyle = BorderStyle.None; pnlPrincipal.Controls.Add(pE_); } catch { return; } Label lblPl = new Label(); lblPl.Text = "PLAYLIST"; lblPl.Location = new Point(202, 25); lblPl.Size = new Size(61, 13); lblPl.BorderStyle = BorderStyle.None; lblPl.Font = new Font("Tahoma", 9, FontStyle.Regular); lblPl.BackColor = Color.Transparent; lblPl.ForeColor = Color.Black; pnlPrincipal.Controls.Add(lblPl); Label lbl = new Label(); try { string s; string s1 = _listInformacoes[(tag)].Name; if (s1.Count() > 30) { s = s1.Substring(0, 30); if (s1.Count() > 30) s = s + " ..."; } else s = s1; lbl.Text = s; lbl.Location = new Point(202, 39); lbl.Size = new Size(195, 25); lbl.BorderStyle = BorderStyle.None; lbl.BackColor = Color.Transparent; lbl.Font = new Font("Times New Roman", 18, FontStyle.Bold); lbl.ForeColor = Color.Black; pnlPrincipal.Controls.Add(lbl); } catch { return; } Label lbl1 = new Label(); lbl1.Text = _listInformacoes[(tag)].Descrição; lbl1.Location = new Point(202, 66); lbl1.AutoSize = false; lbl1.Size = new Size(314, 40); lbl1.BorderStyle = BorderStyle.None; lbl1.BackColor = Color.Transparent; lbl1.Font = new Font("Times New Roman", 9, FontStyle.Italic); lbl1.ForeColor = Color.Black; pnlPrincipal.Controls.Add(lbl1); Button btn = new Button(); btn.Location = new Point(202, 110); btn.Size = new Size(100, 30); btn.FlatStyle = FlatStyle.Flat; btn.BackColor = Color.FromArgb(0, 128, 71); btn.FlatAppearance.BorderSize = 0; btn.ForeColor = Color.White; btn.Font = new Font("Trebuchet MS", 17, FontStyle.Bold); btn.Text = "PLAY"; btn.Click += btnPlayMusic_Click; btn.Cursor = Cursors.Hand; pnlPrincipal.Controls.Add(btn); PictureBox pe = new PictureBox(); pe.Location = new Point(487, 110); pe.Size = new Size(30, 30); pe.Image = Properties.Resources.icons8_plus_500__1_; pe.BackColor = Color.Transparent; pe.SizeMode = PictureBoxSizeMode.Zoom; pe.BorderStyle = BorderStyle.None; pe.Cursor = Cursors.Hand; pe.Click += pEAdicionar_Click; pnlPrincipal.Controls.Add(pe); Panel pnl = new Panel(); pnl.Location = new Point(5, 160); pnl.Size = new Size(662, 180); pnl.BorderStyle = BorderStyle.None; pnl.BackColor = Color.White; pnlPrincipal.Controls.Add(pnl); FlowLayoutPanel flp = new FlowLayoutPanel(); flp.Dock = DockStyle.Fill; flp.AutoScroll = true; flp.BackColor = Color.Transparent; pnl.Controls.Add(flp); PictureBox pictureEdit = new PictureBox(); pictureEdit.Location = new Point(pnlPrincipal.Width - 18, 0); pictureEdit.Size = new Size(20, 20); pictureEdit.Image = Properties.Resources.expand__1_; pictureEdit.BackColor = Color.Transparent; pictureEdit.BorderStyle = BorderStyle.None; pictureEdit.SizeMode = PictureBoxSizeMode.Zoom; pictureEdit.Cursor = Cursors.Arrow; pictureEdit.Click += PIC_Click; pnlPrincipal.Controls.Add(pictureEdit); flp.Controls.Clear(); try { int d = 0; if (_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica != null) { PlaydaLista.ToList().ForEach(Testes => { Panel pnl1 = new Panel(); pnl1.Size = new Size(flp.Width - 18, 40); pnl1.BackColor = Color.FromArgb(224, 224, 209); pnl1.Margin = new Padding(0, 2, 0, 0); PictureBox pic = new PictureBox(); pic.Image = Properties.Resources.botao_play; pic.SizeMode = PictureBoxSizeMode.Zoom; pic.Size = new Size(30, 30); pic.BorderStyle = BorderStyle.None; pic.BackColor = Color.Transparent; pic.Location = new Point(5, 5); pic.Tag = d; pic.Click += BotaoPlay_Click; pnl1.Controls.Add(pic); Label lbl2 = new Label(); lbl2.Size = new Size(flp.Width - 200, 20); lbl2.BackColor = Color.Transparent; lbl2.Location = new Point(50, 10); int g = Testes.Count() - 4; lbl2.Text = Testes.Substring(0, g); lbl2.ForeColor = Color.Black; lbl2.Font = new Font("Arial", 8, FontStyle.Italic); pnl1.Controls.Add(lbl2); PictureBox picture = new PictureBox(); picture.Image = Properties.Resources.close_red; picture.Location = new Point(pnl1.Width - 40, (pnl1.Height / 2) - 10); picture.Size = new Size(20, 20); picture.SizeMode = PictureBoxSizeMode.Zoom; picture.BorderStyle = BorderStyle.None; picture.BackColor = Color.Transparent; picture.Tag = d; picture.Click += RemoveinPlayList_Click; pnl1.Controls.Add(picture); flp.Controls.Add(pnl1); d++; }); } } catch { return; } }
		private void Atualiza(){pnlPrincipal.Visible = true; axWindowsMediaPlayer1.Visible = false; if (musica == true) MusicaPlay(IdPlayList - 1); PainelControl1.Size = new Size(130, 409); pE_PauseaPlay.Location = new Point(400, 5); pE_previous.Location = new Point(350, 6); pE_Random.Location = new Point(300, 5); pE_Next.Location = new Point(450, 6); pE_Repit.Location = new Point(500, 6); PBC.Size = new Size(311, 18); PBC.Location = new Point((pnlConteudo.Width / 2) - 140, 40); pnlPlayList.Size = new Size(PainelControl1.Size.Width, PainelControl1.Size.Height - 70); pictureEdit3.Location = new Point(12, 35); this.FormBorderStyle = FormBorderStyle.None; pnlPrincipal.Size = new Size(676, 345); try { flowLayoutPanel1.Controls.Clear(); flowLayoutPanel1.Dock = DockStyle.Fill; flowLayoutPanel1.AutoScroll = true; flowLayoutPanel1.BorderStyle = BorderStyle.None; flowLayoutPanel1.Margin = new Padding(0, 0, 0, 0); flowLayoutPanel1.BackColor = Color.Transparent; pnlPlayList.BorderStyle = BorderStyle.None; _listInformacoes.ToList().ForEach(test => { Panel pnl = new Panel(); pnl.Size = new Size(130, 50); pnl.BorderStyle = BorderStyle.None; pnl.BackColor = Color.AntiqueWhite; pnl.Margin = new Padding(0, 0, 0, 0); pnl.BackColor = Color.FromArgb(92, 209, 213); pnl.Anchor = (AnchorStyles.Right | AnchorStyles.Left); pnl.ContextMenuStrip = cmsMenuStrip; pnl.Tag = test.IDList; pnl.MouseHover += painel_MouseHover; pnl.Click += pnl_Click; string s1 = test.Name; int k = s1.Count() > 10 ? k = 10 : k = s1.Count(); string s = s1.Substring(0, k); s = s1.Count() > 10 ? s = s + " ..." : s = s + ""; PictureBox pE_ = new PictureBox(); pE_.Size = new Size(36, 37); pE_.Location = new Point(6, 9); pE_.LoadAsync((test.Image)); pE_.BackColor = Color.Transparent; pE_.BorderStyle = BorderStyle.None; pE_.SizeMode = PictureBoxSizeMode.Zoom; pE_.Tag = test.IDList; pE_.MouseHover += PicEdit_MouseHover; pE_.Click += pE_Click; pnl.Controls.Add(pE_); Label lbl = new Label(); lbl.AutoSize = false; lbl.Text = s; lbl.Size = new Size(80, 37); lbl.Location = new Point(49, 20); lbl.BackColor = Color.Transparent; lbl.BorderStyle = BorderStyle.None; lbl.Tag = test.IDList; lbl.MouseHover += Lbl_MouseHover; lbl.Click += Lbl_Click; pnl.Controls.Add(lbl); flowLayoutPanel1.Controls.Add(pnl);});}catch{Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");var json = JsonConvert.SerializeObject("[]");json = json.Replace("\"", "");File.WriteAllText(Environment.CurrentDirectory + "/Musicas.json", json);MessageBox.Show("Erro in playList!!!!\n I need remove all text,the playlist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}}

		private void escrever(){try{Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");var myString = File.ReadAllText(Environment.CurrentDirectory + "/Musicas.json");_listInformacoes = JsonConvert.DeserializeObject<List<PlayList>>(myString);if (myString == string.Empty || myString == "  "){var json = JsonConvert.SerializeObject("[]");json = json.Replace("\"", "");File.WriteAllText(Environment.CurrentDirectory + "/Musicas.json", json);}}catch{var json = JsonConvert.SerializeObject("[]");json = json.Replace("\"", "");File.WriteAllText(Environment.CurrentDirectory + "/Musicas.json", json);MessageBox.Show("Erro in playList!!!!\n I need remove all text,the playlist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}}
		#endregion
		#region Click
		private void RemoveinPlayList_Click(object sender, EventArgs e){PictureBox picture = sender as PictureBox; _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.RemoveAt(int.Parse(picture.Tag.ToString())); PlaydaLista.Clear(); _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.ToList().ForEach(item => { NameMusic = item.Split(new string[] { "\\" }, StringSplitOptions.None); int TAMANHO = NameMusic.Length; int g = NameMusic[TAMANHO - 1].Count(); string f = NameMusic[TAMANHO - 1].Substring(0, g); PlaydaLista.Add(f); });var json = JsonConvert.SerializeObject(_listInformacoes); Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");File.WriteAllText(Environment.CurrentDirectory + "/Musicas.json", json);MusicaPlay((IdPlayList - 1));}
		private void BotaoPlay_Click(object sender, EventArgs e) { PictureBox pe = sender as PictureBox; labelControl2.Tag = pe.Tag; pictureBox2.Tag = "" + IdPlayList; pE_PauseaPlay.Image = Properties.Resources.pause; pE_PauseaPlay.Tag = "0"; if (FormVideo == false) { axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[((int)pe.Tag)]; axWindowsMediaPlayer1.Ctlcontrols.play(); } else { CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[((int)pe.Tag)]]; if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition != 0) Posicao = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString(); Volume = labelControl4.Text; Processo = "start"; fmr.timer1_Tick(sender, e); } try { NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[((int)pe.Tag)].Split(new string[] { "\\" }, StringSplitOptions.None); labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4)); } catch { return; } pE_Next.Enabled = true; pE_PauseaPlay.Enabled = true; pE_previous.Enabled = true; }
		private void pictureBox2_Click(object sender, EventArgs e) { if (labelControl2.Text != "") MessageBox.Show("" + labelControl2.Text); }
		private void trackBar1_Click(object sender, EventArgs e) { labelControl2.Focus(); }
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (labelControl2.Text != "" && FormVideo == false)
			{
				if (Ordem_de_Reproducao.Count() > 1)
					CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
				else 
					CaMusica = axWindowsMediaPlayer1.URL; 
				axWindowsMediaPlayer1.Visible = false;
				Volume = labelControl4.Text;
				try
				{
					Screen scrn = Screen.FromControl(this);
					int n = int.Parse((scrn.DeviceName.Replace("\\", "").Replace(".DISPLAY", "")));
					this.Location = Screen.AllScreens[(n - 1)].WorkingArea.Location;
					timer1.Stop();
					FormVideo = true;
					axWindowsMediaPlayer1.Ctlcontrols.stop();
					fmr.Show();
					timer2.Start();
				}
				catch
				{
					Video frm = new Video();
					frm.Show();
					Screen scrn = Screen.FromControl(fmr);
					int n = int.Parse((scrn.DeviceName.Replace("\\", "").Replace(".DISPLAY", "")));
					this.Location = Screen.AllScreens[(n - 1)].WorkingArea.Location;
				}
			}
		}
		private void btnPlayMusic_Click(object sender, EventArgs e){Random rd = new Random();int r;r = rd.Next(0, ((_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1)));pE_PauseaPlay.Image = Properties.Resources.pause;pE_PauseaPlay.Tag = "0";t = 0;labelControl2.Text = string.Empty;pictureBox2.Tag = "" + IdPlayList;if (pE_Random.Tag.ToString() == "0"){Ordem_de_Reproducao.Clear();for (int a = 0; a < _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count(); a++){if (r >= _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count())r = 0;Ordem_de_Reproducao.Add(r);r++;}}pE_Next.Enabled = true;pE_PauseaPlay.Enabled = true;pE_previous.Enabled = true;r = rd.Next(0, ((_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1)));try{axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[r]];NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[(r)]].Split(new string[] { "\\" }, StringSplitOptions.None);}catch{axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[0]];NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[(0)]].Split(new string[] { "\\" }, StringSplitOptions.None);}int TAMANHO = NameMusic.Length;	int k = NameMusic[TAMANHO - 1].Count() - 4;string s = NameMusic[TAMANHO - 1].Substring(0, k);labelControl2.Text = s;axWindowsMediaPlayer1.Ctlcontrols.play();labelControl2.Tag = "" + r;}
		#endregion
		#region Eventos Random
		private void timer1_Tick(object sender, EventArgs e) { if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying) { PBC.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition; dt = 0; } if (PBC.Value == PBC.Maximum) { try { var dsd = (int.Parse(labelControl2.Tag.ToString()) >= _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1) && pE_Repit.Tag.ToString() == "1" ? labelControl2.Tag = 0 : labelControl2.Tag = (int.Parse(labelControl2.Tag.ToString())) + 1; axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]]; NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None); labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4)); axWindowsMediaPlayer1.Ctlcontrols.play(); PBC.Value = 0; dt = 0; } catch { axWindowsMediaPlayer1.Ctlcontrols.stop(); PBC.Value = 0; } } else if ((PBC.Value == 0) && pE_PauseaPlay.Tag.ToString() != "1" && labelControl2.Text != string.Empty && (Ordem_de_Reproducao.Count() >= 1)) timer2.Start(); }
		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			TrackBar track = sender as TrackBar;
			int d = (track.Value * 10);
			axWindowsMediaPlayer1.settings.volume = d;
			labelControl4.Text = d.ToString();
			labelControl2.Focus();
			if (FormVideo == true)
			{
				Volume = d.ToString();
				fmr.timer1_Tick(sender, e);
				timer1.Stop();
			}
		}
		private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e) { if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying) { PBC.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration; timer1.Start(); } else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused) timer1.Stop(); }
		private void timer2_Tick(object sender, EventArgs e)
		{
			if (FormVideo == false)
			{
				dt++;
				if (((PBC.Value == 0 || PBC.Value == (PBC.Maximum - 1)) || dt > 5) && pE_PauseaPlay.Tag.ToString() != "1")
				{
					if (dt < 7 && PBC.Value != 0)
						PBC.Tag = "" + PBC.Value;
					else if (dt >= 12)
					{
						if (PBC.Tag != null)
							if (PBC.Value == int.Parse(PBC.Tag.ToString()) || PBC.Value == 0)
							{
								var dsd = (int.Parse(labelControl2.Tag.ToString()) >= _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1) && pE_Repit.Tag.ToString() == "1" ? labelControl2.Tag = 0 : labelControl2.Tag = (int.Parse(labelControl2.Tag.ToString())) + 1;
								axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
								NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None);
								labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
								axWindowsMediaPlayer1.Ctlcontrols.play(); dt = 0; timer2.Stop();
							}
					}
				}
				else if (pE_PauseaPlay.Tag.ToString() == "1")
					dt = 0;
			}
			else
			{
				FormCollection fc = Application.OpenForms;//fazer uma condição para ver se o fc é !=1 se for vai para as proximas duas condições

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
							axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
							NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None);
							labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
							axWindowsMediaPlayer1.BringToFront();
							axWindowsMediaPlayer1.Dock = DockStyle.Fill;
							axWindowsMediaPlayer1.Visible = true;
							axWindowsMediaPlayer1.Ctlcontrols.play();
							dt = 0;
						}
					}
					catch { }
				}
				if (Video.progresso != 0)
					PBC.Maximum = (int)Video.maxprogresso;
				if (Ordem_de_Reproducao.Count > 1)
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
					if ((PBC.Value == PBC.Maximum || PBC.Value == (PBC.Maximum - 1) || PBC.Value == 0 || dt > 5) && pE_PauseaPlay.Tag.ToString() != "1")
					{
						dt++;
						if (dt < 7 && PBC.Value != 0) PBC.Tag = "" + PBC.Value;
						else if (dt >= 12 || PBC.Value == PBC.Maximum || PBC.Value == (PBC.Maximum - 1))
						{
							if (PBC.Tag != null)
								if ((PBC.Value == int.Parse(PBC.Tag.ToString()) || PBC.Value == 0))
								{
									var dsd = (int.Parse(labelControl2.Tag.ToString()) == _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1) ? labelControl2.Tag = 0 : labelControl2.Tag = (int.Parse(labelControl2.Tag.ToString())) + 1;
									Volume = labelControl4.Text; Processo = "start";
									NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]].Split(new string[] { "\\" }, StringSplitOptions.None);
									CaMusica = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[int.Parse(labelControl2.Tag.ToString())]];
									labelControl2.Text = NameMusic[NameMusic.Length - 1].Substring(0, (NameMusic[NameMusic.Length - 1].Count() - 4));
									fmr.timer1_Tick(sender, e);
									Video.progresso = 0;
									dt = 0;
									PBC.Tag = null;
								}
						}
					}
				}
				PBC.Value = (int)Video.progresso;
			}
		}
		#endregion

		#region panel
		private void pnl_Click(object sender, EventArgs e) 
		{ 
			Panel pnl = sender as Panel; 
			IdPlayList = (int)pnl.Tag; 
			MusicaPlay((int)pnl.Tag - 1);
		}
		private void painel_MouseHover(object sender, EventArgs e)
		{ 
			Panel pnl = sender as Panel;
			TSMIRemove.Tag = (int)pnl.Tag; 
			TSMIEditPlayList.Tag = (int)pnl.Tag; 
			var aux = (int)pnl.Tag; 
		}
		#endregion
		#region lbl
		private void Lbl_Click(object sender, EventArgs e) { Label lbl = sender as Label; IdPlayList = (int)lbl.Tag; MusicaPlay((int)lbl.Tag - 1); }
		private void Lbl_MouseHover(object sender, EventArgs e) { Label lbl = sender as Label; TSMIRemove.Tag = (int)lbl.Tag; TSMIEditPlayList.Tag = (int)lbl.Tag; var aux = (int)lbl.Tag; }
		#endregion
	}
}
