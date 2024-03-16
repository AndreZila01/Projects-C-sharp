using Microsoft.VisualStudio.OLE.Interop;

using Pokedex_Pokémon.Classes;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Data.OleDb;

using System.Diagnostics;

using System.Drawing;

using System.Drawing.Imaging;

using System.IO;

using System.Linq;

using System.Linq.Expressions;

using System.Reflection;

using System.Runtime.InteropServices;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

namespace Pokedex_Pokémon
{
	public partial class Form1 : Form
	{
		int Aux = 0, y, x, index;
		PictureBox pct = new PictureBox();
		Panel pnl = new Panel();
		PictureBox pic = new PictureBox();
		PictureBox pcct = new PictureBox();
		Bitmap TelacianoV, TelacianoH, ListaPokemonV, ListaPokemonH, PokemonE, PokemonNE;
		Color Colorofbackground = Color.FromArgb(232, 103, 73);
		List<string> Pokemons = new List<string>();
		List<AddPokemon> NomePokemon = new List<AddPokemon>();
		List<Point> locofpic = new List<Point>();
		List<Point> locoflbl = new List<Point>();
		OleDbConnection conexao = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}\Pokemon.accdb", Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)));
		OleDbCommand comando = new OleDbCommand("SELECT*FROM Lista_Pokemon ORDER BY len(NPokemon), NPokemon");
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		[DllImportAttribute("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")] public static extern bool ReleaseCapture();
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			Process[] procs = Process.GetProcessesByName("Pokedex Pokémon");
			if (procs.Length > 1) foreach (Process proc in procs)
				{
					if (proc != procs[0]) proc.Kill();
				}
			x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
			y = Screen.PrimaryScreen.WorkingArea.Height - (this.Height + 100);
			this.Location = new Point(x, y);
			this.FormBorderStyle = FormBorderStyle.None;
			this.BackColor = Color.FromArgb(255, 243, 232);
			this.TransparencyKey = Color.FromArgb(255, 243, 232);
			pictureBox1.BackColor = Color.Transparent;
			if (!backgroundWorker1.IsBusy) backgroundWorker1.RunWorkerAsync();
			pct.MouseMove += pictureBox1_MouseMove;
			this.Controls.Add(pct);
			pictureBox3.BringToFront();
			pictureBox3.Visible = false;
			this.CenterToScreen();
		}
		private void RodarEcra()
		{
			lbln.Visible = false;
			pct.Visible = false;
			var d = pictureBox1.Tag.ToString() == "Horizontal" ? pctGira.Image = Pokedex_Pokémon.Properties.Resources.Roda_Vertical : pctGira.Image = Pokedex_Pokémon.Properties.Resources.roda_Horizontal;
			pctGira.SizeMode = PictureBoxSizeMode.StretchImage;
			pctGira.Size = new Size(this.Width, this.Height);
			pctGira.Visible = true;
			pctGira.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.Visible = false;
			pictureBox2.Visible = false;
			pictureBox3.Visible = false;
			panel1.Visible = false;
			Aux = 0;
			Clocked.Start();
		}
		private void pictureBox1_DoubleClick(object sender, EventArgs e)
		{
			if (pictureBox3.Visible != true)
			{
				pictureBox2.Visible = true;
				pictureBox2.BringToFront();
				var d = pictureBox1.Tag.ToString() == "Horizontal" ? pictureBox1.Image = Pokedex_Pokémon.Properties.Resources.Telemovel_Horizontal_Pokedex : pictureBox1.Image = Pokedex_Pokémon.Properties.Resources.Telemovel_Vertical_Pokedex;
			}
		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			var d = pictureBox1.Tag.ToString() == "Horizontal" ? pictureBox1.Image = TelacianoH : pictureBox1.Image = TelacianoV;
			pictureBox2.Visible = false;
			pictureBox3.Visible = true;
			pictureBox3.BringToFront();
			pnl.Visible = false;
			panel1.Visible = true;
			panel1.BringToFront();
		}
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			pictureBox3.Visible = false;
			pictureBox2.Visible = true;
			pct.Visible = false;
			pictureBox1.BringToFront();
			pictureBox2.BringToFront();
			textBox1.Text = "";
			pctPokemon.Image = null;
			pctTip1.Image = null;
			pctTip2.Image = null;
			pnl.Visible = false;
			var d = pictureBox1.Tag.ToString() == "Horizontal" ? pictureBox1.Image = ListaPokemonH : pictureBox1.Image = ListaPokemonV;
		}
		private void pctPokemon_LoadCompleted(object sender, AsyncCompletedEventArgs e)
		{
			if ((pctPokemon.ImageLocation != null || pctPokemon.ImageLocation != "") && (NomePokemon[index].Certification == "X" || textBox1.Text == NomePokemon[index].Name))
			{
				if (textBox1.Text != "")
				{
					{
						Image img = pctPokemon.Image;
						Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
						ImageAttributes ia = new ImageAttributes();
						ColorMatrix cmPicture = new ColorMatrix(new float[][] { new float[] { 0.299f, 0.299f, 0.299f, 0, 0 }, new float[] { 0.587f, 0.587f, 0.587f, 0, 0 }, new float[] { 0.114f, 0.114f, 0.114f, 0, 0 }, new float[] { 0, 0, 0, 0.15f, 0 }, new float[] { 0, 0, 0, 0, 0 } });
						ia.SetColorMatrix(cmPicture);
						Graphics g = Graphics.FromImage(bmpInverted);
						g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
						g.Dispose();
						pctPokemon.Image = bmpInverted;
					}
				}
			}
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			lbln.Text = "";
			lbln.Visible = true;
			int vetor = 0;
			if (textBox1.Text != "")
			{
				if (textBox1.Text == "\r\n") textBox1.Text = "";
				if (textBox1.Text.Count() == 1 || Pokemons.Count() == 0)
				{
					Pokemons.Clear();
					NomePokemon.ToList().ForEach(item =>
					{
						try
						{
							if ((item.Name.Substring(0, textBox1.Text.Count())).ToLower() == textBox1.Text.ToLower()) Pokemons.Add(item.Name);
						}
						catch { }
					});
				}
				if (NomePokemon.Count > 0 && Pokemons.Count() > 0)
				{
					try
					{
						if (textBox1.Text != "")
						{
							Pokemons.ToList().ForEach(item =>
							{
								if (item.Count() >= textBox1.Text.Count())
								{
									string d = item.Substring(0, textBox1.Text.Count()).ToLower();
									if (textBox1.Tag.ToString() != "D" && Pokemons[0] != item) vetor++;
									if (d == textBox1.Text.ToLower() && textBox1.Tag.ToString() != "D") textBox1.Tag = "D";
								}
								else if (textBox1.Tag.ToString() != "D" && Pokemons[0] != item) vetor++;
							});
							if (textBox1.Tag.ToString() == "D")
							{
								textBox1.Tag = "C";
								index = NomePokemon.FindIndex(x => x.Name == Pokemons[vetor]);
								if (pctPokemon.Tag == null || (index != int.Parse(pctPokemon.Tag.ToString())))
								{
									pctPokemon.Tag = index.ToString();
									pctPokemon.BackColor = Color.FromArgb(157, 242, 201);
									pctTip1.SizeMode = PictureBoxSizeMode.Zoom;
									pctTip2.SizeMode = PictureBoxSizeMode.Zoom;
									pctTip1.Image = null;
									pctTip2.Image = null;
									pctTip1.BackColor = Color.FromArgb(157, 242, 201);
									pctTip2.BackColor = Color.FromArgb(157, 242, 201);
									pctTip2.Visible = true;
									switch (NomePokemon[index].Tipo1)
									{
										case "Water":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.water);
											break;
										case "Bug":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.bug);
											break;
										case "Dark":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.dark);
											break;
										case "Dragon":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.dragon);
											break;
										case "Electric":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.eletric);
											break;
										case "Fairy":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.fairy);
											break;
										case "Fighting":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.fighting);
											break;
										case "Fire":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.fire);
											break;
										case "Flying":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.flying);
											break;
										case "Ghost":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.ghost);
											break;
										case "Grass":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.grass);
											break;
										case "Ground":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.ground);
											break;
										case "Ice":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.ice);
											break;
										case "Normal":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.normal);
											break;
										case "Poison":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.poison);
											break;
										case "Psychic":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.psychic);
											break;
										case "Rock":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.rock);
											break;
										case "Steel":
											pctTip1.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.steel);
											break;
										default:
											pctTip1.Image = null;
											break;
									}
									switch (NomePokemon[index].Tipo2)
									{
										case "Water":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.water);
											break;
										case "Bug":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.bug);
											break;
										case "Dark":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.dark);
											break;
										case "Dragon":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.dragon);
											break;
										case "Electric":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.eletric);
											break;
										case "Fairy":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.fairy);
											break;
										case "Fighting":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.fighting);
											break;
										case "Fire":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.fire);
											break;
										case "Flying":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.flying);
											break;
										case "Ghost":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.ghost);
											break;
										case "Grass":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.grass);
											break;
										case "Ground":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.ground);
											break;
										case "Ice":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.ice);
											break;
										case "Normal":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.normal);
											break;
										case "Poison":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.poison);
											break;
										case "Psychic":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.psychic);
											break;
										case "Rock":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.rock);
											break;
										case "Steel":
											pctTip2.LoadAsync(Pokedex_Pokémon.Properties.Settings.Default.steel);
											break;
										default:
											pctTip2.Visible = false;
											break;
									}
									string nome = NomePokemon[index].NameEx != "" ? nome = NomePokemon[index].NameEx.ToLower() : nome = NomePokemon[index].Name.ToLower();

									if (NomePokemon[index].Region != "Paldea")
										pctPokemon.LoadAsync("https://img.pokemondb.net/sprites/home/normal/" + nome + ".png");
									else
										pctPokemon.LoadAsync("https://img.pokemondb.net/sprites/scarlet-violet/normal/" + nome + ".png");
								}
							}
						}
					}
					catch { }
					if ((NomePokemon[index].Name.ToLower().Contains(textBox1.Text.ToLower()) == true) && (NomePokemon[index].Name.Count() == textBox1.Text.Count()) && NomePokemon[index].Certification != "C")
					{
						if (conexao.State != ConnectionState.Open) conexao.Open();
						comando.Connection = conexao;
						comando.CommandText = $"UPDATE Lista_Pokemon set Certificar='C' WHERE NomePokemon='{NomePokemon[index].Name}'";
						comando.ExecuteNonQuery();
						string nome = NomePokemon[index].NameEx != "" ? nome = NomePokemon[index].NameEx.ToLower() : nome = NomePokemon[index].Name.ToLower();

						if (NomePokemon[index].Region != "Paldea")
							pctPokemon.LoadAsync("https://img.pokemondb.net/sprites/home/normal/" + nome + ".png");
						else
							pctPokemon.LoadAsync("https://img.pokemondb.net/sprites/scarlet-violet/normal/" + nome + ".png");
						NomePokemon[index].Certification = "C";
						conexao.Close();
						lbln.Visible = true;
						lbln.Text = "" + NomePokemon[index].number;
						var d = pictureBox1.Tag.ToString() == "Horizontal" ? lbln.Location = new Point(247, 370) : lbln.Location = new Point(130, 550);
					}
				}
				if ((NomePokemon[index].Name.ToLower().Contains(textBox1.Text.ToLower()) == true) && NomePokemon[index].Certification == "C")
				{
					lbln.Visible = true;
					lbln.Text = "" + NomePokemon[index].number;
				}
			}
			else
			{
				pctPokemon.Image = null;
				pctTip1.Image = null;
				pctTip2.Image = null;
				lbln.Text = "";
			}
		}
		private void lblinPanel_Click(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			if (textBox1.Tag == null)
			{
				textBox1.Tag = "C";
				if (conexao.State != System.Data.ConnectionState.Open) conexao.Open();
				comando.Connection = conexao;
				var reader = comando.ExecuteReader();
				while (reader.Read())
				{
					var pokemon = new AddPokemon();
					pokemon.number = reader["NPokemon"].ToString();
					pokemon.Name = reader["NomePokemon"].ToString();
					pokemon.Tipo1 = reader["Tipo1"].ToString();
					pokemon.Tipo2 = reader["Tipo2"].ToString();
					pokemon.Region = reader["Região/Geração"].ToString();
					pokemon.NameEx = reader["Nomeex"].ToString();
					pokemon.Certification = reader["Certificar"].ToString();
					NomePokemon.Add(pokemon);
				}
				conexao.Close();
			}
			pnl.Controls.Clear();
			switch (lbl.Text)
			{
				case "Add Pokemon":
					AddPokemon();
					break;
				case "List Pokemon":
					pct.Tag = 0.ToString();
					ListaPokemon();
					break;
				case "Rotate Display":
					var d = pictureBox1.Tag.ToString() == "Horizontal" ? pictureBox1.Tag = "Vertical" : pictureBox1.Tag = "Horizontal";
					pctPokemon.Visible = false;
					pctTip2.Visible = false;
					pctTip1.Visible = false;
					textBox1.Visible = false;
					RodarEcra();
					Clocked.Start();
					break;
				case "Help":
					Ajuda();
					break;
				case "System":
					Sistema();
					break;
			}
		}
		private void Sistema()
		{
			pnl.BackColor = Color.FromArgb(157, 242, 201);
			if (pictureBox1.Tag.ToString() == "Vertical")
			{
				pnl.Location = new Point(12, 223);
				pnl.Size = new Size(219, 373);
				this.Controls.Add(pnl);
				pnl.BringToFront();
			}
			else
			{
				pnl.Location = new Point(50, 204);
				pnl.Size = new Size(390, 215);
				this.Controls.Add(pnl);
				pnl.BringToFront();
			}
			panel1.Visible = false;
			pictureBox2.Visible = false;
			pnl.Visible = true;
			Button butn = new Button();
			butn.Text = "Close Application";
			butn.Click += button1_Click;
			var d = pictureBox1.Tag.ToString() == "Horizontal" ? butn.Location = new Point(15, 35) : butn.Location = new Point(35, 35);
			butn.Size = new Size(155, 50);
			butn.BackColor = Color.FromArgb(157, 242, 201);
			pnl.Controls.Add(butn);
			pictureBox3.Focus();
			butn.BringToFront();
			Button btn = new Button();
			btn.Text = "Change color of mobile";
			btn.Click += button1_Click;
			d = pictureBox1.Tag.ToString() == "Horizontal" ? btn.Location = new Point(15, 90) : btn.Location = new Point(35, 90);
			btn.Size = new Size(155, 50);
			btn.BackColor = Color.FromArgb(157, 242, 201);
			pnl.Controls.Add(btn);
			btn.BringToFront();
			pictureBox3.Focus();
			Button buttn = new Button();
			buttn.Text = "List Pokemon Online";
			buttn.Click += button1_Click;
			d = pictureBox1.Tag.ToString() == "Horizontal" ? buttn.Location = new Point(15, 145) : buttn.Location = new Point(35, 145);
			buttn.Size = new Size(155, 50);
			buttn.BackColor = Color.FromArgb(157, 242, 201);
			pnl.Controls.Add(buttn);
			buttn.BringToFront();
			pictureBox3.Focus();
			Button button = new Button();
			button.Text = "Edit List of pokemon";
			button.Click += button1_Click;
			d = pictureBox1.Tag.ToString() == "Horizontal" ? button.Location = new Point(190, 35) : button.Location = new Point(35, 200);
			button.Size = new Size(155, 50);
			button.BackColor = Color.FromArgb(157, 242, 201);
			pnl.Controls.Add(button);
			button.BringToFront();
			pictureBox3.Focus();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			switch (button.Text)
			{
				case "Close Application":
					Application.Exit();
					break;
				case "Change color of mobile":
					ColorDialog colorDlg = new ColorDialog();
					if ((colorDlg.ShowDialog() == DialogResult.OK) && colorDlg.Color != Color.FromArgb(255, 255, 255))
					{
						Color c;
						TelacianoH = Pokedex_Pokémon.Properties.Resources.Telemovel_Horizontal_OFF;
						TelacianoV = Pokedex_Pokémon.Properties.Resources.Telemovel_Vertical_OFF;
						ListaPokemonH = Pokedex_Pokémon.Properties.Resources.Telemovel_Horizontal_Pokedex;
						ListaPokemonV = Pokedex_Pokémon.Properties.Resources.Telemovel_Vertical_Pokedex;
						for (int i = 0;
						i < TelacianoH.Width;
						i++)
						{
							for (int j = 0;
						j < TelacianoH.Height;
						j++)
							{
								c = TelacianoH.GetPixel(i, j);
								if (c == Colorofbackground || c == Color.FromArgb(232, 103, 73)) TelacianoH.SetPixel(i, j, colorDlg.Color);
								if (c == Color.FromArgb(51, 49, 49)) TelacianoH.SetPixel(i, j, Color.FromArgb(157, 242, 201));
							}
						}
						for (int i = 0;
							i < TelacianoV.Width;
							i++)
						{
							for (int j = 0;
							j < TelacianoV.Height;
							j++)
							{
								c = TelacianoV.GetPixel(i, j);
								if (c == Colorofbackground || c == Color.FromArgb(232, 103, 73)) TelacianoV.SetPixel(i, j, colorDlg.Color);
								if (c == Color.FromArgb(51, 49, 49)) TelacianoV.SetPixel(i, j, Color.FromArgb(157, 242, 201));
							}
						}
						for (int i = 0;
							i < ListaPokemonH.Width;
							i++)
						{
							for (int j = 0;
							j < ListaPokemonH.Height;
							j++)
							{
								c = ListaPokemonH.GetPixel(i, j);
								if (c == Colorofbackground || c == Color.FromArgb(232, 103, 73)) ListaPokemonH.SetPixel(i, j, colorDlg.Color);
							}
						}
						for (int i = 0;
							i < ListaPokemonV.Width;
							i++)
						{
							for (int j = 0;
							j < ListaPokemonV.Height;
							j++)
							{
								c = ListaPokemonV.GetPixel(i, j);
								if (c == Colorofbackground || c == Color.FromArgb(232, 103, 73)) ListaPokemonV.SetPixel(i, j, colorDlg.Color);
							}
						}
						Colorofbackground = colorDlg.Color;
						var d = pictureBox1.Tag.ToString() == "Horizontal" ? pictureBox1.Image = TelacianoH : pictureBox1.Image = TelacianoV;
					}
					break;
				case "List Pokemon Online":
					System.Diagnostics.Process.Start("https://pokemondb.net/pokedex/all");
					break;
				case "Edit List of pokemon":
					var caminhoficheiro = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
					System.Diagnostics.Process.Start(caminhoficheiro + "\\Pokemon.accdb");
					break;
			}
		}
		private void Ajuda()
		{
			TextBox txt = new TextBox();
			panel1.Visible = false;
			pictureBox2.Visible = false;
			pnl.Visible = true;
			if (pictureBox1.Tag.ToString() == "Vertical")
			{
				pnl.Location = new Point(12, 223);
				pnl.Size = new Size(219, 373);
				pnl.BackColor = Color.FromArgb(157, 242, 201);
				this.Controls.Add(pnl);
				pnl.BringToFront();
				txt.Text = "In this application,the object is completed the pokedex!! The user need go to \"add pokemon\" and write in TextBox!!!\r\nSome problems off name f pokemon!!\r\nExample.:Farfetch'd==Farfetchd&&Nidoran♀==Nidoran F\r\nIn this list have " + NomePokemon.Count() + ",all region (Kanto,Johto,Hoeen,Sinnoh,Unova,Kalos,Alola,Galar and Hisui).";
				txt.Size = new Size(200, 250);
				txt.Multiline = true;
				txt.Font = new Font("Berlin Sans FB", 10, FontStyle.Regular);
				txt.BorderStyle = BorderStyle.None;
				txt.Location = new Point(10, 25);
				txt.BackColor = Color.FromArgb(157, 242, 201);
				txt.ForeColor = Color.Black;
				txt.ReadOnly = true;
				pnl.Controls.Add(txt);
			}
			else
			{
				pnl.Location = new Point(50, 204);
				pnl.Size = new Size(390, 215);
				pnl.BackColor = Color.FromArgb(157, 242, 201);
				this.Controls.Add(pnl);
				pnl.BringToFront();
				txt.Text = "In this application,the object is completed the pokedex!!\r\nSome problems off name of pokemon!!\r\nExample.:Farfetch'd==Farfetchd&&Nidoran♀==Nidoran F\r\nIn this list have " + NomePokemon.Count() + ",all region(Kanto,Johto,Hoeen,Sinnoh,Unova,Kalos,Alola,Galar and Hisui).";
				txt.Size = new Size(350, 150);
				txt.Multiline = true;
				txt.Font = new Font("Berlin Sans FB", 10, FontStyle.Regular);
				txt.BorderStyle = BorderStyle.None;
				txt.Location = new Point(10, 25);
				txt.BackColor = Color.FromArgb(157, 242, 201);
				txt.ForeColor = Color.Black;
				txt.ReadOnly = true;
				pnl.Controls.Add(txt);
			}
		}
		private void ListaPokemon()
		{
			if (locofpic.Count == 0 && locoflbl.Count == 0)
			{
				pic.Click += picture_downEup_click;
				pcct.Click += picture_downEup_click;
			}
			locoflbl.Clear();
			locofpic.Clear();
			pnl.Controls.Clear();
			while (pnl.Controls.Count > 0)
			{
				pnl.Controls[0].Dispose();
			}
			if (pictureBox1.Tag.ToString() == "Vertical")
			{
				int[] locofpicvalorX = { 0, 70, 140, 0, 70, 140, 0, 70, 140, 0, 70, 140, 0, 70, 140 };
				int[] locoflblvalorX = { 2, 72, 142, 2, 72, 142, 2, 72, 142, 2, 72, 142, 2, 72, 142 };
				int auxiliarx = 0, auxiliary, temp = 0, Temp = 0;
				int[,] medidas = new int[NomePokemon.Count(), NomePokemon.Count()];
				pictureBox3.Visible = false;
				pictureBox2.Visible = true;
				panel1.Visible = false;
				if (pct.Tag == null) pct.Tag = 0.ToString();
				if ((int.Parse(pct.Tag.ToString()) * 15) < (NomePokemon.Count() + 1))
				{
					pnl.Visible = true;
					if (locoflbl.Count() == 0 && locofpic.Count() == 0)
					{
						auxiliary = 20;
						for (int d = 0;
						d < 15;
						d++)
						{
							Point point = new Point(locofpicvalorX[auxiliarx], auxiliary);
							locofpic.Add(point);
							auxiliarx++;
							if (auxiliarx == 3 || auxiliarx == 6 || auxiliarx == 9 || auxiliarx == 12 || auxiliarx == 15) auxiliary += 65;
						}
						auxiliarx = 0;
						auxiliary = 52;
						for (int d = 0;
						d < 15;
						d++)
						{
							Point point = new Point(locoflblvalorX[auxiliarx], auxiliary);
							locoflbl.Add(point);
							auxiliarx++;
						}
					}
					pnl.Location = new Point(12, 223);
					pnl.Size = new Size(219, 373);
					pnl.BackColor = Color.FromArgb(51, 49, 49);
					this.Controls.Add(pnl);
					temp = 0;
					temp = (int.Parse(pct.Tag.ToString()) * 15) + temp;
					locofpic.ToList().ForEach(item =>
					{
						if (((int.Parse(pct.Tag.ToString()) * 15) + Temp) < (NomePokemon.Count()))
						{
							PictureBox pcdt = new PictureBox();
							pcdt.Size = new Size(64, 50);
							pcdt.Location = new Point(item.X, item.Y);
							var d = NomePokemon[temp].Certification == "C" ? pcdt.Image = PokemonE : pcdt.Image = PokemonNE;
							pcdt.SizeMode = PictureBoxSizeMode.Zoom;
							pnl.Controls.Add(pcdt);
							if (NomePokemon[temp].Certification == "C")
							{
								PictureBox pctPok = new PictureBox();
								pctPok.Size = new Size(64, 50);
								pctPok.Location = new Point(0, -8);
								string nome = NomePokemon[temp].NameEx != "" ? nome = NomePokemon[temp].NameEx.ToLower() : nome = NomePokemon[temp].Name.ToLower();
								if (NomePokemon[temp].Region != "Paldea")
									pctPok.LoadAsync("https://img.pokemondb.net/sprites/home/normal/" + nome + ".png");
								else
									pctPok.LoadAsync("https://img.pokemondb.net/sprites/scarlet-violet/normal/" + nome + ".png");
								pctPok.SizeMode = PictureBoxSizeMode.Zoom;
								pcdt.Controls.Add(pctPok);
								pctPok.BackColor = Color.Transparent;
							}
							if ((int.Parse(pct.Tag.ToString()) * 15) < (NomePokemon.Count()))
							{
								Label lbl = new Label();
								lbl.Location = new Point(locoflbl[Temp].X, (item.Y + 50));
								var dd = NomePokemon[temp].Certification == "C" ? lbl.Text = NomePokemon[temp].number.ToString() : lbl.Text = "---";
								lbl.Size = new Size(35, 13);
								pnl.Controls.Add(lbl);
							}
							Temp++;
							temp++;
						}
					});
					pnl.BringToFront();
					pictureBox1.Image = ListaPokemonV;
				}
				temp = 0;
				if (NomePokemon.Count() >= ((int.Parse(pct.Tag.ToString()) * 15) + 15))
				{
					pic.Size = new Size((pnl.Width / 4), 20);
					pic.Location = new Point((75), (pnl.Height - 25));
					pic.SizeMode = PictureBoxSizeMode.Zoom;
					pic.Image = Pokedex_Pokémon.Properties.Resources.seta_baixo;
					pic.Visible = true;
					pic.Name = "DOWN";
					pnl.Controls.Add(pic);
					pic.BringToFront();
				}
				if (pct.Tag.ToString() != "0")
				{
					pcct.Visible = true;
					pcct.Name = "UP";
					pcct.Size = new Size((pnl.Width / 4), 20);
					pcct.Location = new Point(75, 0);
					pcct.SizeMode = PictureBoxSizeMode.Zoom;
					pcct.Image = Pokedex_Pokémon.Properties.Resources.seta_cima;
					pcct.Name = "UP";
					pnl.Controls.Add(pcct);
					pcct.BringToFront();
				}
				else pcct.Visible = false;
			}
			else
			{
				int[] locofpicvalorX = { 16, 80, 144, 208, 272, 16, 80, 144, 208, 272, 16, 80, 144, 208, 272, 16, 80, 144, 208, 272, 16, 80, 144, 208, 272 };
				int[] locoflblvalorX = { 18, 82, 146, 210, 274, 18, 82, 146, 210, 274, 18, 82, 146, 210, 274 };
				int auxiliarx = 0, auxiliary, temp = 0, Temp = 0;
				int[,] medidas = new int[NomePokemon.Count(), NomePokemon.Count()];
				pictureBox3.Visible = false;
				pictureBox2.Visible = true;
				panel1.Visible = false;
				if (pct.Tag == null) pct.Tag = 0.ToString();
				if ((int.Parse(pct.Tag.ToString()) * 15) < (NomePokemon.Count() + 1))
				{
					pnl.Visible = true;
					if (locoflbl.Count() == 0 && locofpic.Count() == 0)
					{
						auxiliary = 5;
						for (int d = 0;
						d < 15;
						d++)
						{
							Point point = new Point(locofpicvalorX[auxiliarx], auxiliary);
							locofpic.Add(point);
							auxiliarx++;
							if (auxiliarx == 5 || auxiliarx == 10 || auxiliarx == 15) auxiliary += 69;
						}
						auxiliarx = 0;
						auxiliary = 52;
						for (int d = 0;
						d < 15;
						d++)
						{
							Point point = new Point(locoflblvalorX[auxiliarx], auxiliary);
							locoflbl.Add(point);
							auxiliarx++;
							if (auxiliarx == 5 || auxiliarx == 10 || auxiliarx == 15) auxiliarx = 0;
						}
					}
					pnl.Location = new Point(70, 204);
					pnl.Size = new Size(370, 215);
					pnl.BackColor = Color.FromArgb(51, 49, 49);
					this.Controls.Add(pnl);
					temp = 0;
					temp = (int.Parse(pct.Tag.ToString()) * 15) + temp;
					locofpic.ToList().ForEach(item =>
					{
						if ((int.Parse(pct.Tag.ToString()) * 15 + Temp) < (NomePokemon.Count()))
						{
							PictureBox pcdt = new PictureBox();
							pcdt.Size = new Size(64, 50);
							pcdt.Location = new Point(item.X, item.Y);
							var d = NomePokemon[temp].Certification == "C" ? pcdt.Image = PokemonE : pcdt.Image = PokemonNE;
							pcdt.SizeMode = PictureBoxSizeMode.Zoom;
							pnl.Controls.Add(pcdt);
							if (NomePokemon[temp].Certification == "C")
							{
								PictureBox pctPok = new PictureBox();
								pctPok.Size = new Size(64, 50);
								pctPok.Location = new Point(0, 0);
								string nome = NomePokemon[temp].NameEx != "" ? nome = NomePokemon[temp].NameEx.ToLower() : nome = NomePokemon[temp].Name.ToLower();
								if (NomePokemon[temp].Region != "Paldea")
									pctPok.LoadAsync("https://img.pokemondb.net/sprites/home/normal/" + nome.ToLower() + ".png");
								else
									pctPok.LoadAsync("https://img.pokemondb.net/sprites/scarlet-violet/normal/" + nome.ToLower() + ".png");
								pctPok.SizeMode = PictureBoxSizeMode.Zoom;
								pcdt.Controls.Add(pctPok);
								pctPok.BackColor = Color.Transparent;
							}
							if ((int.Parse(pct.Tag.ToString()) * 15) < (NomePokemon.Count()))
							{
								Label lbl = new Label();
								lbl.Location = new Point(locoflbl[Temp].X, (item.Y + 50));
								var dd = NomePokemon[temp].Certification == "C" ? lbl.Text = NomePokemon[temp].number.ToString() : lbl.Text = "---";
								lbl.Size = new Size(35, 13);
								pnl.Controls.Add(lbl);
							}
							Temp++;
							temp++;
						}
					});
					temp = 0;
					if (NomePokemon.Count() >= ((int.Parse(pct.Tag.ToString()) * 15) + 15))
					{
						pic.Size = new Size(20, (pnl.Width / 4));
						pic.Location = new Point((pnl.Width - 25), (pnl.Height / 2 - 50));
						pic.SizeMode = PictureBoxSizeMode.Zoom;
						var d = pictureBox1.Tag.ToString() == "Horizontal" ? pic.Image = Pokedex_Pokémon.Properties.Resources.seta_direita : pic.Image = Pokedex_Pokémon.Properties.Resources.seta_baixo;
						pic.Name = "DOWN";
						pic.Visible = true;
						pnl.Controls.Add(pic);
						pic.BringToFront();
					}
					if (pct.Tag.ToString() != "0")
					{
						pcct.Visible = true;
						pcct.Size = new Size(20, (pnl.Width / 4));
						pcct.Location = new Point(0, (pnl.Height - 160));
						pcct.SizeMode = PictureBoxSizeMode.Zoom;
						var d = pictureBox1.Tag.ToString() == "Horizontal" ? pcct.Image = Pokedex_Pokémon.Properties.Resources.seta_esquerda : pcct.Image = Pokedex_Pokémon.Properties.Resources.seta_cima;
						pcct.Name = "UP";
						pnl.Controls.Add(pcct);
						pcct.BringToFront();
					}
					else pcct.Visible = false;
					pnl.BringToFront();
					pictureBox1.Image = ListaPokemonH;
				}
			}
		}
		private void picture_downEup_click(object sender, EventArgs e)
		{
			PictureBox picture = sender as PictureBox;
			int temp = int.Parse(pct.Tag.ToString());
			if (picture.Name == "UP") temp--;
			pct.Tag = "" + temp;
			if (picture.Name == "DOWN") temp++;
			pct.Tag = "" + temp;
			if ((temp < (NomePokemon.Count()))) ListaPokemon();
		}
		private void AddPokemon()
		{
			textBox1.Visible = true;
			panel1.Visible = false;
			pictureBox2.Visible = false;
			pictureBox3.Visible = true;
			pctTip1.Visible = true;
			pctTip2.Visible = true;
			pctPokemon.Visible = true;
			pctPokemon.BringToFront();
			pctTip1.BringToFront();
			pctTip2.BringToFront();
			pictureBox3.BringToFront();
			textBox1.BringToFront();
			var dd = pictureBox1.Tag.ToString() == "Horizontal" ? textBox1.Size = new Size(170, 30) : textBox1.Size = new Size(170, 30);
			var ddd = pictureBox1.Tag.ToString() == "Horizontal" ? textBox1.Location = new Point(55, 223) : textBox1.Location = new Point(24, 258);
			var dddd = pictureBox1.Tag.ToString() == "Horizontal" ? pctPokemon.Size = new Size(167, 153) : pctPokemon.Size = new Size(210, 196);
			var ddddd = pictureBox1.Tag.ToString() == "Horizontal" ? pctPokemon.Location = new Point(58, 257) : pctPokemon.Location = new Point(19, 294);
			var dddddd = pictureBox1.Tag.ToString() == "Horizontal" ? pctTip1.Size = new Size(42, 38) : pctTip1.Size = new Size(42, 38);
			var d = pictureBox1.Tag.ToString() == "Horizontal" ? pctTip1.Location = new Point(403, 223) : pctTip1.Location = new Point(24, 215);
			var a = pictureBox1.Tag.ToString() == "Horizontal" ? pctTip2.Size = new Size(42, 38) : pctTip2.Size = new Size(42, 38);
			var da = pictureBox1.Tag.ToString() == "Horizontal" ? pctTip2.Location = new Point(403, 264) : pctTip2.Location = new Point(70, 215);
			var ddddddd = pictureBox1.Tag.ToString() == "Horizontal" ? pctPokemon.SizeMode = PictureBoxSizeMode.Normal : pctPokemon.SizeMode = PictureBoxSizeMode.Zoom;
		}
		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			Color c;
			TelacianoH = Pokedex_Pokémon.Properties.Resources.Telemovel_Horizontal_OFF;
			TelacianoV = Pokedex_Pokémon.Properties.Resources.Telemovel_Vertical_OFF;
			ListaPokemonH = Pokedex_Pokémon.Properties.Resources.Telemovel_Horizontal_Pokedex;
			ListaPokemonV = Pokedex_Pokémon.Properties.Resources.Telemovel_Vertical_Pokedex;
			PokemonE = Pokedex_Pokémon.Properties.Resources.PokemonE;
			PokemonNE = Pokedex_Pokémon.Properties.Resources.PokemonNE;
			for (int i = 0;
			i < TelacianoH.Width;
			i++)
			{
				for (int j = 0;
			j < TelacianoH.Height;
			j++)
				{
					c = TelacianoH.GetPixel(i, j);
					if (c == Color.FromArgb(51, 49, 49)) TelacianoH.SetPixel(i, j, Color.FromArgb(157, 242, 201));
				}
			}
			for (int i = 0;
				i < TelacianoV.Width;
				i++)
			{
				for (int j = 0;
				j < TelacianoV.Height;
				j++)
				{
					c = TelacianoV.GetPixel(i, j);
					if (c == Color.FromArgb(51, 49, 49)) TelacianoV.SetPixel(i, j, Color.FromArgb(157, 242, 201));
				}
			}
			for (int i = 0;
				i < PokemonE.Width;
				i++)
			{
				for (int j = 0;
				j < PokemonE.Height;
				j++)
				{
					c = PokemonE.GetPixel(i, j);
					if (c == Color.FromArgb(255, 255, 255)) PokemonE.SetPixel(i, j, Color.FromArgb(051, 49, 49));
				}
			}
			for (int i = 0;
				i < PokemonE.Width;
				i++)
			{
				for (int j = 0;
				j < PokemonNE.Height;
				j++)
				{
					try
					{
						c = PokemonNE.GetPixel(i, j);
					}
					catch
					{
						c = Color.FromArgb(0, 0, 0);
					}
					if (c == Color.FromArgb(255, 255, 255)) PokemonNE.SetPixel(i, j, Color.FromArgb(051, 49, 49));
				}
			}
		}
		private void Clocked_Tick(object sender, EventArgs e)
		{
			Aux++;
			if ((Aux > 7 && pictureBox1.Tag.ToString() == "Horizontal") || Aux > 10 && pictureBox1.Tag.ToString() != "Horizontal")
			{
				pct.Visible = false;
				pctGira.Visible = false;
				pictureBox1.Visible = true;
				pictureBox3.Visible = true;
				panel1.Visible = true;
				var d = pictureBox1.Tag.ToString() == "Horizontal" ? pictureBox1.Image = TelacianoH : pictureBox1.Image = TelacianoV;
				var dd = pictureBox1.Tag.ToString() == "Horizontal" ? pictureBox1.Size = new Size(499, 528) : pictureBox1.Size = new Size(500, 720);
				var ddd = pictureBox1.Tag.ToString() == "Horizontal" ? pictureBox1.Location = new Point(-4, 1) : pictureBox1.Location = new Point(-6, 0);
				ddd = pictureBox1.Tag.ToString() == "Horizontal" ? pictureBox2.Location = new Point(16, 380) : pictureBox2.Location = new Point(20, 180);
				dd = pictureBox1.Tag.ToString() == "Horizontal" ? pictureBox2.Size = new Size(32, 31) : pictureBox2.Size = new Size(28, 24);
				ddd = pictureBox1.Tag.ToString() == "Horizontal" ? pictureBox3.Location = new Point(17, 213) : pictureBox3.Location = new Point(180, 180);
				dd = pictureBox1.Tag.ToString() == "Horizontal" ? pictureBox3.Size = new Size(32, 31) : pictureBox3.Size = new Size(32, 28);
				dd = pictureBox1.Tag.ToString() == "Horizontal" ? this.Size = new Size(485, 565) : this.Size = new Size(300, 676);
				dd = pictureBox1.Tag.ToString() == "Horizontal" ? panel1.Size = new Size(382, 202) : panel1.Size = new Size(210, 266);
				ddd = pictureBox1.Tag.ToString() == "Horizontal" ? panel1.Location = new Point(55, 213) : panel1.Location = new Point(20, 226);
				dd = pictureBox1.Tag.ToString() == "Horizontal" ? lblAdd.Size = new Size(268, 28) : lblAdd.Size = new Size(220, 28);
				dd = pictureBox1.Tag.ToString() == "Horizontal" ? lblLista.Size = new Size(268, 28) : lblLista.Size = new Size(220, 28);
				dd = pictureBox1.Tag.ToString() == "Horizontal" ? lblRodar.Size = new Size(268, 28) : lblRodar.Size = new Size(220, 28);
				dd = pictureBox1.Tag.ToString() == "Horizontal" ? lblAjuda.Size = new Size(268, 28) : lblAjuda.Size = new Size(220, 28);
				dd = pictureBox1.Tag.ToString() == "Horizontal" ? lblInfo.Size = new Size(268, 28) : lblInfo.Size = new Size(220, 28);
				ddd = pictureBox1.Tag.ToString() == "Horizontal" ? lblAdd.Location = new Point(48, 20) : lblAdd.Location = new Point(-20, 24);
				ddd = pictureBox1.Tag.ToString() == "Horizontal" ? lblLista.Location = new Point(48, 50) : lblLista.Location = new Point(-20, 64);
				ddd = pictureBox1.Tag.ToString() == "Horizontal" ? lblRodar.Location = new Point(48, 80) : lblRodar.Location = new Point(-20, 109);
				ddd = pictureBox1.Tag.ToString() == "Horizontal" ? lblAjuda.Location = new Point(48, 110) : lblAjuda.Location = new Point(-20, 151);
				ddd = pictureBox1.Tag.ToString() == "Horizontal" ? lblInfo.Location = new Point(48, 140) : lblInfo.Location = new Point(-20, 191);
				var dddd = pictureBox1.Tag.ToString() == "Horizontal" ? this.lblInfo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0))) : this.lblInfo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				dddd = pictureBox1.Tag.ToString() == "Horizontal" ? this.lblAdd.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0))) : this.lblAdd.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				dddd = pictureBox1.Tag.ToString() == "Horizontal" ? this.lblAjuda.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0))) : this.lblAjuda.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				dddd = pictureBox1.Tag.ToString() == "Horizontal" ? this.lblLista.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0))) : this.lblLista.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				dddd = pictureBox1.Tag.ToString() == "Horizontal" ? this.lblRodar.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0))) : this.lblRodar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				d = pictureBox1.Tag.ToString() == "Horizontal" ? pictureBox2.Image = Pokedex_Pokémon.Properties.Resources.Open_Vertical : pictureBox2.Image = Pokedex_Pokémon.Properties.Resources.Open_Horizontal;
				ddd = pictureBox1.Tag.ToString() == "Horizontal" ? this.Location = new Point((x -= 230), (y += 50)) : this.Location = new Point((x += 230), (y -= 50));
				Clocked.Stop();
				pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
				Aux = 0;
			}
		}
	}
}