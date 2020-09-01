﻿using AudioSwitcher.AudioApi.CoreAudio;
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
		const int WS_MINIMIZEBOX=0x20000; const int CS_DBLCLKS=0x8;
		private void pnlTop_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button==MouseButtons.Left)
			{
				ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
		public const int WM_NCLBUTTONDOWN=0xA1; public const int HT_CAPTION=0x2; [DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam); [DllImportAttribute("user32.dll")]	public static extern bool ReleaseCapture();		
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp=base.CreateParams; cp.Style |= WS_MINIMIZEBOX; cp.ClassStyle |= CS_DBLCLKS; return cp;
			}
		}
		#endregion
		#region variaveis globais
		private int IdPlayList,d,random=0,repetir=0,pausa=0,t,ultimaMnaTag,aux; private bool atualizacao,musica; public List<string> PlaydaLista=new List<string>(); public List<PlayList> _listInformacoes=new List<PlayList>(); public PlayList _Play=new PlayList();	public List<string> _Caminho_Musica=new List<string>(); public List<double> Ordem_de_Reproducao=new List<double>(); string[] NameMusic; int VPB,dt;
		#endregion
		#region Form
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			Invalidate(); atualizacao=false;
			if (!backgroundWorker1.IsBusy)
				backgroundWorker1.RunWorkerAsync();

			Ler(); Process[] procs=Process.GetProcessesByName("Spotify Clone");
			if (procs.Length > 1)
			 foreach (Process proc in procs)
			 {
 				if(proc!=procs[0])
 					proc.Kill();
			 }
			CoreAudioDevice defaultPlaybackDevice=new CoreAudioController().DefaultPlaybackDevice;
			if (defaultPlaybackDevice.Volume >= 50)
			{
				if (MessageBox.Show("I down the volume the your computer, to your security!!!\nIf not like, click in \"Não\", if click in \"Sim\" I am reduce the volume!!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
				{
 					System.Diagnostics.Process.Start("sndvol.exe");
 					defaultPlaybackDevice.Volume=30;
				}
			}			
		}
		#endregion
		#region PictureBox
		private void pE_Close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void pE_Close_MouseHover(object sender, EventArgs e)
		{
			pE_Close.Image=Properties.Resources.close_red;
		}
		private void pictureEdit3_Click(object sender, EventArgs e)
		{
			object tag=0; AuxForm2(tag); _listInformacoes.Clear(); Ler(); Atualiza();
		}
		private void pE_Close_MouseLeave(object sender, EventArgs e)
		{
			pE_Close.Image=Properties.Resources.close_white;
		}
		private void pE_NorMax_Click(object sender, EventArgs e)
		{
			d=1; Atualiza();
		}
		private void pE_minimizar_Click(object sender, EventArgs e)
		{
			this.WindowState=FormWindowState.Minimized;
		}
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			if (repetir==0)
			{
				pE_Repit.Image=Properties.Resources.refresh__2_; repetir=1;
			}
			else
			{
				pE_Repit.Image=Properties.Resources.refresh__3_; repetir=0;
			}
		}
		private void pictureBox4_Click(object sender, EventArgs e)
		{
			if (t==_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1)
				t=0;
			else
				t++;
			try
			{
				axWindowsMediaPlayer1.URL=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[(t)]]; NameMusic=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[(t)]].Split(new string[] { "\\" }, StringSplitOptions.None); int TAMANHO=NameMusic.Length; int k=NameMusic[TAMANHO - 1].Count()-4; string s=NameMusic[TAMANHO - 1].Substring(0, k); labelControl2.Text=s; axWindowsMediaPlayer1.Ctlcontrols.play();
			}
			catch
			{
				 try
				 {
 					axWindowsMediaPlayer1.URL=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(ultimaMnaTag + 1)]; 	NameMusic=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[(t)]].Split(new string[] { "\\" }, StringSplitOptions.None); 	int TAMANHO=NameMusic.Length; int k=NameMusic[TAMANHO - 1].Count()-4; 	string s=NameMusic[TAMANHO - 1].Substring(0, k); 	labelControl2.Text=s; 	axWindowsMediaPlayer1.Ctlcontrols.play();
				 }
				 catch
				 {
 					MessageBox.Show("\t            Erro 404\nIn " + _listInformacoes[(IdPlayList - 1)].Name + " dont exist music!!\nClick in Play!!", "ERRO 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
				 }
			}
			pE_PauseaPlay.Image = Properties.Resources.pause; pausa = 0; labelControl2.Tag = "" + t;
		}
		private void PIC_Click(object sender, EventArgs e)
		{
			if (PBC.Value!=0)
			{
				pnlPrincipal.Visible=false; axWindowsMediaPlayer1.Visible=true; axWindowsMediaPlayer1.Size=new Size(panel2.Width, panel2.Height); axWindowsMediaPlayer1.Location=new Point(0, 0); pnlPrincipal.Controls.Clear(); musica=true;
			}
		}
		private void pEAdicionar_Click(object sender, EventArgs e)
		{
			string[] files, path; PictureBox button=sender as PictureBox; OpenFileDialog ofd=new OpenFileDialog(); ofd.Multiselect=true; ofd.Filter="Video and Music Files (*.mp3,*.au, *.m4a, *.mp4, *.m4v, *.mp4v)|*.mp3;*.au; *.m4a; *.mp4; *.m4v; *.mp4v"; ofd.Multiselect=true; List<string> test=new List<string>();
			if (ofd.ShowDialog()==DialogResult.OK)
			{
				files=ofd.SafeFileNames; path=ofd.FileNames;
				if (PlaydaLista.Count()==0)
				{
					path.ToList().ForEach(item =>
					{
 						_Caminho_Musica.Add(item); 		NameMusic=item.Split(new string[] { "\\" }, StringSplitOptions.None); 		int TAMANHO=NameMusic.Length; int g=NameMusic[TAMANHO - 1].Count(); 		string f=NameMusic[TAMANHO - 1].Substring(0, g); 		PlaydaLista.Add(f);
					});
				}
				else
				{
					path.ToList().ForEach(item =>
					{
 						if (_listInformacoes[IdPlayList - 1].Caminho_da_Musica.Contains(item)==false)
 						{
 						_Caminho_Musica.Add(item); 			NameMusic=item.Split(new string[] { "\\" }, StringSplitOptions.None); 			int TAMANHO=NameMusic.Length; int g=NameMusic[TAMANHO - 1].Count(); 			string f=NameMusic[TAMANHO - 1].Substring(0, g); 			PlaydaLista.Add(f);
 						}
					});
				}
					_listInformacoes[IdPlayList - 1].Caminho_da_Musica=_Caminho_Musica; var caminhoficheiro=Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); string json=JsonConvert.SerializeObject(_listInformacoes); File.WriteAllText(caminhoficheiro + "/Musicas.json", json); MusicaPlay(IdPlayList - 1);
			}
			Invalidate();
		}
		private void pE_PauseaPlay_Click(object sender, EventArgs e)
		{
			try
			{
				if (pausa==0)
				{
					pE_PauseaPlay.Image=Properties.Resources.play; 	pausa=1; 	axWindowsMediaPlayer1.Ctlcontrols.pause();
				}
				else
				{
					pE_PauseaPlay.Image=Properties.Resources.pause; 	pausa=0; 	axWindowsMediaPlayer1.Ctlcontrols.play();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("\t            ERROR 404\n " + ex + " !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void pE_previous_Click(object sender, EventArgs e)
		{
			try
			{
				if (t==0)
					t=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count() - 1;
				 else
					t--;
				axWindowsMediaPlayer1.URL=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[(t)]]; NameMusic=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[(t)]].Split(new string[] { "\\" }, StringSplitOptions.None); int TAMANHO=NameMusic.Length; int k=NameMusic[TAMANHO - 1].Count()-4; string s=NameMusic[TAMANHO - 1].Substring(0, k); labelControl2.Text=s; axWindowsMediaPlayer1.Ctlcontrols.play();	labelControl2.Tag = "" + t;
			}
			catch (Exception ex)
			{
				MessageBox.Show("\t            ERROR 404\n " + ex + " !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			pE_PauseaPlay.Image = Properties.Resources.pause; pausa = 0;
		}
		private void pE_Random_Click(object sender, EventArgs e)
		{
			try
			{
				Ordem_de_Reproducao.Clear();
				if (random==0)
					{
					try
					{
 						foreach (string a in _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica)
 							Ordem_de_Reproducao.Add(0.0001);
 						for (d=0; d < _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count(); d++)
 						{
 						aqui:
 							Random rd=new Random(); int r=rd.Next(0, _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count());
 							for (int a=0; a < _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count(); a++)
 							{
								if (Ordem_de_Reproducao[a]==r)		goto aqui;
 							}
 							Ordem_de_Reproducao[d]=r; pE_Random.Image=Properties.Resources.change_1; random=1;
 						}
					}
					catch (Exception ex)
					{
 						MessageBox.Show("" + ex.Message);
					}				
					random = 1;
				}
				else
				{
 				for (int a=0; a < _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count(); a++)
 					Ordem_de_Reproducao.Add(a);				pE_Random.Image=Properties.Resources.change; random=0;
				}
			}
			catch
			{
				MessageBox.Show("At the moment, dont select playList!! \n OU \n The playList dont ahve musics!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}
		private void pE_Click(object sender, EventArgs e)
		{
			PictureBox pE=sender as PictureBox;	IdPlayList=(int)pE.Tag;	MusicaPlay((int)pE.Tag - 1);
		}
		private void PicEdit_MouseHover(object sender, EventArgs e)
		{
			PictureBox picture=sender as PictureBox; TSMIRemove.Tag=(int)picture.Tag; TSMIEditPlayList.Tag=(int)picture.Tag;			TSMIAdd.Tag=(int)picture.Tag;
		}
		#endregion
		#region Background
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				 var caminhoficheiro=Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); var myString=File.ReadAllText(caminhoficheiro + "/Musicas.json");
				 if (myString=="\"[]\"")
				 {
 					var json=JsonConvert.SerializeObject("[]"); 	json=json.Replace("\"", ""); 	caminhoficheiro=Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); 	File.WriteAllText(caminhoficheiro + "/Musicas.json", json); 	return;
				 }
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex.Message + "\n\n                                           Lose all musics!!!\n                                           Vou criar uma nova playList!!!"); var caminhoficheiro=Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); File.CreateText(caminhoficheiro + "Musicas.json"); MessageBox.Show("I'm create new paste, see there, if you don't lose this document again!!!!");
			}
		}
		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			Atualiza();
		}
		#endregion
		#region ToolStripMenuItem
		private void removeThePlayListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				ToolStripMenuItem tag=sender as ToolStripMenuItem; IdPlayList=(int)tag.Tag; _listInformacoes.Remove(_listInformacoes.FirstOrDefault(row => row.IDList==(int)tag.Tag)); var json=JsonConvert.SerializeObject(_listInformacoes); var caminhoficheiro=Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); File.WriteAllText(caminhoficheiro + "/Musicas.json", json); Atualiza();
			}
			catch
			{
				Atualiza();
			}
		}
		private void addMusicToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				ToolStripMenuItem tool=sender as ToolStripMenuItem; IdPlayList=(int)tool.Tag; MusicaPlay((int)tool.Tag - 1);
			}
			catch
			{
				MessageBox.Show("Your were very fast!! Take it easy, beacuse the program dont detect playList", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
			}
		}
		private void editPlayListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				ToolStripMenuItem tsmi=sender as ToolStripMenuItem; atualizacao=true; IdPlayList=(int)tsmi.Tag; AuxForm2(tsmi.Tag);
			}
			catch
			{
				MessageBox.Show("\t            Erro to detect the playList!!\nyou were very fast!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion
		#region Funções Criadas
		private void AuxForm2(object tag)
		{
			try
			{
				 atualizacao=false;
				 try
				 {
 					if ((int)tag!=0)
 					{
 						IdPlayList=(int)tag; atualizacao=true;
 					}
 					else
 					{
 						IdPlayList=0; atualizacao=false;
 					}
				 }
				 catch
				 {
 					MessageBox.Show("Your were very fast!! Take it easy, beacuse the program dont detect playList", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
				 }
				 Form2 form2=new Form2(atualizacao, IdPlayList); form2.ShowDialog(); form2.Close(); var caminhoficheiro=Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); Ler(); int a=1;
				 _listInformacoes.ToList().ForEach(item =>
				 {
 					item.IDList=a; 	a++;
				 });
				 form2.Close(); var json=JsonConvert.SerializeObject(_listInformacoes); File.WriteAllText(caminhoficheiro + "/Musicas.json", json);
			}
			catch
			{
				return;
			}
			Atualiza();
		}
		private void MusicaPlay(int tag)
		{
			int widht=Screen.PrimaryScreen.Bounds.Width; int height = Screen.PrimaryScreen.Bounds.Height; object q; musica=true; pnlPrincipal.Visible=true; axWindowsMediaPlayer1.Visible=false; pnlPrincipal.Controls.Clear();
			try
			{
				 _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.ToList().ForEach(item =>
				 {
 					NameMusic=item.Split(new string[] { "\\" }, StringSplitOptions.None); 	int TAMANHO=NameMusic.Length; int g=NameMusic[TAMANHO - 1].Count(); 	string f=NameMusic[TAMANHO - 1].Substring(0, g);
 					if (PlaydaLista.Contains(f)==false)
 						PlaydaLista.Add(f);
				 });
			}
			catch{}
			try
			{
				PictureBox pE_=new PictureBox(); pE_.Location=new Point(20, 5); pE_.Size=new Size(164, 136); pE_.BackColor=Color.Silver; pE_.LoadAsync(_listInformacoes[(tag)].Image); pE_.SizeMode=PictureBoxSizeMode.Zoom; pE_.BorderStyle=BorderStyle.None; pnlPrincipal.Controls.Add(pE_);
			}
			catch { return;}
			Label lblPl=new Label();lblPl.Text="PLAYLIST";lblPl.Location=new Point(202, 25);lblPl.Size=new Size(61, 13);lblPl.BorderStyle=BorderStyle.None; lblPl.Font=new Font("Tahoma", 9, FontStyle.Regular); lblPl.BackColor=Color.Transparent; lblPl.ForeColor=Color.Black; pnlPrincipal.Controls.Add(lblPl); Label lbl=new Label();
			try
			{
				 int k;
				 string s1=_listInformacoes[(tag)].Name;
				 if ((s1.Count() > 29&&this.WindowState==FormWindowState.Normal)|| (s1.Count() > 74&&this.WindowState==FormWindowState.Maximized))
 					q=this.WindowState==FormWindowState.Normal ? k=30 : k=75;
				 else
 					k=s1.Count();
				 string s=s1.Substring(0, k);
				 if ((s1.Count() > 30&&this.WindowState==FormWindowState.Normal)|| (s1.Count() > 74&&this.WindowState==FormWindowState.Maximized))
 					s=s + " ...";
				 lbl.Text=s; lbl.Location=new Point(202, 39); lbl.Size=new Size(195, 25); lbl.BorderStyle=BorderStyle.None; lbl.BackColor=Color.Transparent; lbl.Font=new Font("Times New Roman", 18, FontStyle.Bold); lbl.ForeColor=Color.Black; pnlPrincipal.Controls.Add(lbl);
			}
			catch { return;}
			
			Label lbl1=new Label(); lbl1.Text=_listInformacoes[(tag)].Descrição; lbl1.Location=new Point(202, 66); lbl1.AutoSize=false; lbl1.Size=new Size(314, 40); lbl1.BorderStyle=BorderStyle.None;	lbl1.BackColor=Color.Transparent; lbl1.Font=new Font("Times New Roman", 9, FontStyle.Italic); lbl1.ForeColor=Color.Black; pnlPrincipal.Controls.Add(lbl1); Button btn=new Button(); btn.Location=new Point(202, 110); btn.Size=new Size(100, 30); btn.FlatStyle=FlatStyle.Flat; btn.BackColor=Color.FromArgb(0, 128, 71); btn.FlatAppearance.BorderSize=0; btn.ForeColor=Color.White; btn.Font=new Font("Trebuchet MS", 17, FontStyle.Bold); btn.Text="PLAY"; btn.Click += btnPlayMusic_Click; btn.Cursor=Cursors.Hand; pnlPrincipal.Controls.Add(btn); PictureBox pe=new PictureBox(); pe.Location=new Point(487, 110); pe.Size=new Size(30, 30); pe.Image=Properties.Resources.icons8_plus_500__1_; pe.BackColor=Color.Transparent; pe.SizeMode=PictureBoxSizeMode.Zoom; pe.BorderStyle=BorderStyle.None; pe.Cursor=Cursors.Hand; pe.Click += pEAdicionar_Click; pnlPrincipal.Controls.Add(pe); Panel pnl=new Panel(); pnl.Location=new Point(5, 160); pnl.Size=new Size(662, 180); pnl.BorderStyle=BorderStyle.None; pnl.BackColor=Color.White; pnlPrincipal.Controls.Add(pnl); FlowLayoutPanel flp=new FlowLayoutPanel(); flp.Dock=DockStyle.Fill;			flp.AutoScroll=true; flp.BackColor=Color.Transparent; pnl.Controls.Add(flp); PictureBox pictureEdit=new PictureBox(); pictureEdit.Location=new Point(pnlPrincipal.Width - 18, 0);	pictureEdit.Size=new Size(20, 20); pictureEdit.Image=Properties.Resources.expand__1_; pictureEdit.BackColor=Color.Transparent; pictureEdit.BorderStyle=BorderStyle.None; pictureEdit.SizeMode=PictureBoxSizeMode.Zoom; pictureEdit.Cursor=Cursors.Arrow; pictureEdit.Click += PIC_Click; pnlPrincipal.Controls.Add(pictureEdit);
			try
			{
				 int d=0;
				 if (_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica!=null)
				 {
 						PlaydaLista.ToList().ForEach(Testes =>
						{
 							Panel pnl1=new Panel(); 	pnl1.Size=new Size(flp.Width - 18, 40); 	pnl1.BackColor=Color.FromArgb(224, 224, 209); 	pnl1.Margin=new Padding(0, 2, 0, 0); 	PictureBox pic=new PictureBox(); 	pic.Image=Properties.Resources.botao_play; 	pic.SizeMode=PictureBoxSizeMode.Zoom; 	pic.Size=new Size(30, 30); 	pic.BorderStyle=BorderStyle.None; 	pic.BackColor=Color.Transparent; 	pic.Location=new Point(5, 5); 	pic.Tag=d; 	pic.Click += BotaoPlay_Click; 	pnl1.Controls.Add(pic); 	Label lbl2=new Label(); 	lbl2.Size=new Size(flp.Width - 200, 20); 	lbl2.BackColor=Color.Transparent; 	lbl2.Location=new Point(50, 10); 	int g=Testes.Count() - 4; 	lbl2.Text=Testes.Substring(0, g); 	lbl2.ForeColor=Color.Black; 	lbl2.Font=new Font("Arial", 8, FontStyle.Italic); 	pnl1.Controls.Add(lbl2); 	PictureBox picture=new PictureBox(); 	picture.Image=Properties.Resources.close_red; 	picture.Location=new Point(pnl1.Width - 40, (pnl1.Height / 2) - 10); 	picture.Size=new Size(20, 20); 	picture.SizeMode=PictureBoxSizeMode.Zoom; 	picture.BorderStyle=BorderStyle.None; 	picture.BackColor=Color.Transparent; 	picture.Tag=d; 	picture.Click += RemoveinPlayList_Click; 	pnl1.Controls.Add(picture); 	flp.Controls.Add(pnl1); 	d++;
						});
				 }
			}
			catch{ return;}
		}
		private void Atualiza()
		{
			pnlPrincipal.Visible=true;
			axWindowsMediaPlayer1.Visible=false;
			if (d==1)
				this.MaximizedBounds=Screen.FromHandle(this.Handle).WorkingArea;
			if (musica==true)
				MusicaPlay(IdPlayList - 1);			PainelControl1.Size=new Size(130, 409);			pE_PauseaPlay.Location=new Point(400, 5);			pE_previous.Location=new Point(350, 6);			pE_Random.Location=new Point(300, 5);			pE_Next.Location=new Point(450, 6);			pE_Repit.Location=new Point(500, 6);			PBC.Size=new Size(311, 18);			PBC.Location=new Point((pnlConteudo.Width / 2) - 140, 40);			pnlPlayList.Size=new Size(PainelControl1.Size.Width, PainelControl1.Size.Height - 70);			pictureEdit3.Location=new Point(12, 35);			this.FormBorderStyle=FormBorderStyle.None;			pnlPrincipal.Size=new Size(676, 345);
			try
			{
				flowLayoutPanel1.Controls.Clear(); flowLayoutPanel1.Dock=DockStyle.Fill; flowLayoutPanel1.AutoScroll=true; flowLayoutPanel1.BorderStyle=BorderStyle.None; flowLayoutPanel1.Margin=new Padding(0, 0, 0, 0); flowLayoutPanel1.BackColor=Color.Transparent; pnlPlayList.BorderStyle=BorderStyle.None;
				_listInformacoes.ToList().ForEach(test =>
				{
 				Panel pnl=new Panel(); 	pnl.Size=new Size(130, 50); 	pnl.BorderStyle=BorderStyle.None; 	pnl.BackColor=Color.AntiqueWhite; 	pnl.Margin=new Padding(0, 0, 0, 0); 	pnl.BackColor=Color.FromArgb(92, 209, 213); 	pnl.Anchor=(AnchorStyles.Right | AnchorStyles.Left); 	pnl.ContextMenuStrip=cmsMenuStrip; 	pnl.Tag=test.IDList; 	pnl.MouseHover += painel_MouseHover; 	pnl.Click += pnl_Click; 	string s1=test.Name; 	int k=s1.Count() > 10 ? k=10 : k=s1.Count(); 	string s=s1.Substring(0, k); 	s=s1.Count() > 10 ? s=s + " ..." : s=s + ""; 	PictureBox pE_=new PictureBox(); 	pE_.Size=new Size(36, 37); 	pE_.Location=new Point(6, 9); 	pE_.LoadAsync((test.Image)); 	pE_.BackColor=Color.Transparent; 	pE_.BorderStyle=BorderStyle.None; 	pE_.SizeMode=PictureBoxSizeMode.Zoom; 	pE_.Tag=test.IDList; 	pE_.MouseHover += PicEdit_MouseHover; 	pE_.Click += pE_Click; 	pnl.Controls.Add(pE_); 	Label lbl=new Label(); 	lbl.AutoSize=false; 	lbl.Text=s; 	lbl.Size=new Size(80, 37); 	lbl.Location=new Point(49, 20); 	lbl.BackColor=Color.Transparent; 	lbl.BorderStyle=BorderStyle.None; 	lbl.Tag=test.IDList; 	lbl.MouseHover += Lbl_MouseHover; 	lbl.Click += Lbl_Click; 	pnl.Controls.Add(lbl); 	flowLayoutPanel1.Controls.Add(pnl);
				});
			}
			catch	{ var json=JsonConvert.SerializeObject("[]"); json=json.Replace("\"", ""); var caminhoficheiro=Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); File.WriteAllText(caminhoficheiro + "/Musicas.json", json); MessageBox.Show("Erro in playList!!!!\n I need format the playlist");			}
			d=0;
		}
		private void Ler()
		{
			var caminhoficheiro=Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);			var myString=File.ReadAllText(caminhoficheiro + "/Musicas.json");			_listInformacoes=JsonConvert.DeserializeObject<List<PlayList>>(myString);
			if (myString==string.Empty|| myString=="  ")
			{
				var json=JsonConvert.SerializeObject("[]"); json=json.Replace("\"", ""); caminhoficheiro=Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); File.WriteAllText(caminhoficheiro + "/Musicas.json", json);
			}
		}
		#endregion
		#region Click
		private void RemoveinPlayList_Click(object sender, EventArgs e)
		{
			PictureBox picture=sender as PictureBox;			_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.RemoveAt(int.Parse(picture.Tag.ToString()));			PlaydaLista.Clear();
			_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.ToList().ForEach(item =>
			{
				NameMusic=item.Split(new string[] { "\\" }, StringSplitOptions.None); int TAMANHO=NameMusic.Length; int g=NameMusic[TAMANHO - 1].Count(); string f=NameMusic[TAMANHO - 1].Substring(0, g); PlaydaLista.Add(f);
			});
			var json=JsonConvert.SerializeObject(_listInformacoes);			var caminhoficheiro=Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);			File.WriteAllText(caminhoficheiro + "/Musicas.json", json);			MusicaPlay((IdPlayList - 1));
		}
		private void BotaoPlay_Click(object sender, EventArgs e)
		{
			PictureBox pe=sender as PictureBox;			pE_PauseaPlay.Image=Properties.Resources.pause;			pausa=0;			axWindowsMediaPlayer1.URL=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[((int)pe.Tag)]; 
			try
			{
				NameMusic=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[d].Split(new string[] { "\\" }, StringSplitOptions.None); int TAMANHO=NameMusic.Length; int k=NameMusic[TAMANHO - 1].Count()-4; string s=NameMusic[TAMANHO - 1].Substring(0, k); labelControl2.Text=s; axWindowsMediaPlayer1.Ctlcontrols.play();
			}
			catch			{ return;			}
			pE_Next.Enabled=true;			pE_PauseaPlay.Enabled=true;			pE_previous.Enabled=true;
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.K:
					if (pausa == 0)
					{
						pE_PauseaPlay.Image = Properties.Resources.play; pausa = 1; axWindowsMediaPlayer1.Ctlcontrols.pause();
					}
					else
					{
						pE_PauseaPlay.Image = Properties.Resources.pause; pausa = 0; axWindowsMediaPlayer1.Ctlcontrols.play();
					}
					break;
				case Keys.Space:
					if (pausa == 0)
					{
						pE_PauseaPlay.Image = Properties.Resources.play; pausa = 1; axWindowsMediaPlayer1.Ctlcontrols.pause();
					}
					else
					{
						pE_PauseaPlay.Image = Properties.Resources.pause; pausa = 0; axWindowsMediaPlayer1.Ctlcontrols.play();
					}
					break;
			}
		}

		private void btnPlayMusic_Click(object sender, EventArgs e)
		{
			Random rd=new Random();			int t=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count();			int r=rd.Next(0, t);			pE_PauseaPlay.Image=Properties.Resources.pause;			pausa=0;			t=0;labelControl2.Text = string.Empty;
			if (random==0)
			{
				Ordem_de_Reproducao.Clear();
				for (int a=0; a < _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count(); a++)
				{
 					if (r >= _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica.Count())
 						r=0;
 					Ordem_de_Reproducao.Add(r); 	r++;
				}
			}
			pE_Next.Enabled=true;pE_PauseaPlay.Enabled=true;pE_previous.Enabled=true; 			
			try	{axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[r]]; NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[(r)]].Split(new string[] { "\\" }, StringSplitOptions.None); }
			catch{axWindowsMediaPlayer1.URL = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[0]]; NameMusic = _listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[(0)]].Split(new string[] { "\\" }, StringSplitOptions.None); }
			int TAMANHO = NameMusic.Length; int k = NameMusic[TAMANHO - 1].Count() - 4; string s = NameMusic[TAMANHO - 1].Substring(0, k); labelControl2.Text = s; axWindowsMediaPlayer1.Ctlcontrols.play(); labelControl2.Tag=""+r;
		}
		#endregion
		#region Eventos Random
		private void timer1_Tick(object sender, EventArgs e)
		{
			t = int.Parse(labelControl2.Tag.ToString());
			if (axWindowsMediaPlayer1.playState==WMPPlayState.wmppsPlaying)
			{
				PBC.Value=(int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition; VPB=PBC.Value; dt=0;
			}
			if (PBC.Value==PBC.Maximum)
			{
				try
				{
 					t++;
 					if (repetir==1&&(Ordem_de_Reproducao.Count==t))
 						t=0;
 					axWindowsMediaPlayer1.URL=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[t]]; 	NameMusic=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[(t)]].Split(new string[] { "\\" }, StringSplitOptions.None); 	int TAMANHO=NameMusic.Length; int k=NameMusic[TAMANHO - 1].Count()-4; 	string s=NameMusic[TAMANHO - 1].Substring(0, k); 	labelControl2.Text=s;
				}
				catch
				{
 					t++;
 					if (repetir==1&&(Ordem_de_Reproducao.Count==t))
 						t=0;
 					axWindowsMediaPlayer1.URL=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[t]]; NameMusic=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[(t)]].Split(new string[] { "\\" }, StringSplitOptions.None); int TAMANHO=NameMusic.Length; int k=NameMusic[TAMANHO - 1].Count() - 4; string s=NameMusic[TAMANHO - 1].Substring(0, k); labelControl2.Text=s;
				}
				labelControl2.Tag = "" + t;
			}
			else
				if ((VPB==PBC.Value|| VPB==0)&&pausa!=1&&labelControl2.Text!=string.Empty&&t!=0&&(Ordem_de_Reproducao.Count() > 1))//VPB==PBC.Value&&pausa!=1&&labelControl2.Text==string.Empty
					timer2.Start();		
		}
		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			TrackBar track=sender as TrackBar;			int d=(track.Value * 10);			axWindowsMediaPlayer1.settings.volume=d;			labelControl4.Text=d.ToString();  labelControl2.Focus();
		}
		private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
		{
			if (axWindowsMediaPlayer1.playState==WMPLib.WMPPlayState.wmppsPlaying)
			{
				PBC.Maximum=(int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration; timer1.Start();
			}
			else if (axWindowsMediaPlayer1.playState==WMPLib.WMPPlayState.wmppsPaused)
				timer1.Stop();
			else if (PBC.Value >= PBC.Maximum)
			{
				PBC.Value=0; labelControl2.Text="";
			}
		}
		private void timer2_Tick(object sender, EventArgs e)
		{
			dt++;
			if ((PBC.Value==0|| PBC.Value==(PBC.Maximum - 1))&&dt > 5)
			{
				t++; axWindowsMediaPlayer1.URL=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[t]]; NameMusic=_listInformacoes[(IdPlayList - 1)].Caminho_da_Musica[(int)Ordem_de_Reproducao[(t)]].Split(new string[] { "\\" }, StringSplitOptions.None); int TAMANHO=NameMusic.Length; int k=NameMusic[TAMANHO - 1].Count()-4; string s=NameMusic[TAMANHO - 1].Substring(0, k); labelControl2.Text=s; axWindowsMediaPlayer1.Ctlcontrols.play(); timer2.Stop(); dt=0;
			}
			else
			{
				timer2.Stop(); return;
			}
		}
		#endregion
		#region panel
		private void pnl_Click(object sender, EventArgs e)
		{
			Panel pnl=sender as Panel; IdPlayList=(int)pnl.Tag; MusicaPlay((int)pnl.Tag - 1);
		}
		private void painel_MouseHover(object sender, EventArgs e)
		{
			Panel pnl=sender as Panel; TSMIRemove.Tag=(int)pnl.Tag;	TSMIEditPlayList.Tag=(int)pnl.Tag; TSMIAdd.Tag=(int)pnl.Tag;aux=(int)pnl.Tag;
		}
		#endregion
		#region lbl
		private void Lbl_Click(object sender, EventArgs e)
		{
			Label lbl=sender as Label; IdPlayList=(int)lbl.Tag; MusicaPlay((int)lbl.Tag - 1);
		}
		private void Lbl_MouseHover(object sender, EventArgs e)		
		{			
			Label lbl=sender as Label; TSMIRemove.Tag=(int)lbl.Tag;	TSMIEditPlayList.Tag=(int)lbl.Tag; TSMIAdd.Tag=(int)lbl.Tag; aux=(int)lbl.Tag;		
		}
		#endregion
	}
}