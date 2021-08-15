﻿using Newtonsoft.Json;
using Spotify_Clone.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Spotify_Clone
{
	public partial class Form2 : Form
	{
		private string caminhoImg, paths;
		private bool Aux;
		private int Id, ecra;
		private string nameplaylist, description;
		private List<Classes.PlayList> _listInformacoes = new List<Classes.PlayList>();
		Backend bk = new Backend();
		public Form2(bool a, int tag, int d, string path)
		{
			InitializeComponent();
			Aux = a;
			Id = tag;
			ecra = d;
			paths = path;
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image files(*.jpg,*.jpeg,*.jpe,*.jfif,*.png)|*.jpg;*.jpeg;*.jpe;*.jfif;*.png";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (openFileDialog.FileName.Split('.')[openFileDialog.FileName.Split('.').Length - 1] != "png" && openFileDialog.FileName.Split('.')[openFileDialog.FileName.Split('.').Length - 1] != "jpg")
				{
					MessageBox.Show("The selected files must be in the format\n\t*.jpg,*.jpeg,*.jpe,*.jfif,*.png", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				else
				{
					Form1 frm1 = new Form1();
					caminhoImg = openFileDialog.FileName;
					pictureBox1.Image = new Bitmap(openFileDialog.FileName);
				}
			}
			Invalidate();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && pictureBox1.Image != null)
			{
				if (Id == 0)
				{
					Classes.PlayList play = new Classes.PlayList();
					List<Classes.PlayList> _listT = new List<Classes.PlayList>();
					play.Name = textBox1.Text;
					play.Image = caminhoImg;
					play.Descrição = textBox2.Text;
					play.IDList = (_listInformacoes.Count() + 1);
					_listT.Add(play);

					//string ds = JsonConvert.SerializeObject(_listT);
					// JsonConvert.DeserializeObject<List<PlayList>>(JsonConvert.SerializeObject(play));
					bk.WriteReadMusic(false, paths, play);

					//_listInformacoes.Add(play);
					//string json = JsonConvert.SerializeObject(_listInformacoes);
					//File.WriteAllText(Environment.CurrentDirectory + "/Musics.json", json);
				}
				else
				{
					Classes.PlayList play = new Classes.PlayList();
					_listInformacoes =bk.WriteReadMusic(true, paths, null);
					//var myString = File.ReadAllText(Environment.CurrentDirectory + "/Musics.json");
					//_listInformacoes = JsonConvert.DeserializeObject<List<PlayList>>(myString);
					//_listInformacoes[(Id - 1)].Descrição = textBox2.Text;
					//_listInformacoes[(Id - 1)].Name = textBox1.Text;
					//if (caminhoImg != "" && caminhoImg == "null")
					//	_listInformacoes[(Id - 1)].Image = caminhoImg;

					play.Descrição = textBox2.Text;
					play.Name = textBox1.Text;
					if (caminhoImg != "" && caminhoImg == "null")
						play.Image = caminhoImg;

					bk.WriteReadMusic(false, paths, play);
					//string json = JsonConvert.SerializeObject(_listInformacoes);
					//File.WriteAllText(Environment.CurrentDirectory + "/Musics.json", json);
				}
				this.Close();
			}
			else
				MessageBox.Show("You have not completed the data !!\n Please complete !!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		private void Form2_Load(object sender, EventArgs e)
		{
			//Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");
			Form1 frm1 = new Form1();
			this.Location = Screen.AllScreens[(ecra - 1)].WorkingArea.Location;
			this.CenterToScreen();
			try
			{
				_listInformacoes = bk.WriteReadMusic(true, paths, null);
				//var myString = File.ReadAllText(Environment.CurrentDirectory + "/Musics.json");
				//_listInformacoes = JsonConvert.DeserializeObject<List<PlayList>>(myString);
			}
			catch
			{
				//var json = JsonConvert.SerializeObject("[]");
				//json = json.Replace("\"", "");
				//File.WriteAllText(Environment.CurrentDirectory + "/Musics.json", json);
				//var myString = File.ReadAllText(Environment.CurrentDirectory + "/Musics.json");
				//_listInformacoes = JsonConvert.DeserializeObject<List<PlayList>>(myString);
			}
			panel1.Size = new Size(this.Width, this.Height);
			if (Aux == true)
			{
				textBox2.Text = _listInformacoes[(Id - 1)].Descrição;
				textBox1.Text = _listInformacoes[(Id - 1)].Name;
				pictureBox1.Image = new Bitmap(_listInformacoes[(Id - 1)].Image);
			}
		}
	}
}