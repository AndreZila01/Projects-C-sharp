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
		public string img;		private string caminho;		private bool Aux;		private int Id;
		public string nameplaylist, description;		public List<PlayList> _listInformacoes = new List<PlayList>();
		public Form2(bool a, int tag)
		{
			InitializeComponent();			Aux = a;			Id = tag;
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			PictureBox button = sender as PictureBox;			OpenFileDialog openFileDialog = new OpenFileDialog();			openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (openFileDialog.FileName.Split('.')[openFileDialog.FileName.Split('.').Length - 1] != "png" && openFileDialog.FileName.Split('.')[openFileDialog.FileName.Split('.').Length - 1] != "jpg")
				{
					MessageBox.Show("Selecione apenas ficheiros executáveis", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);					return;
				}
				else
				{
					Form1 frm1 = new Form1();					caminho = openFileDialog.FileName;					pictureBox1.Image = new Bitmap(openFileDialog.FileName);
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
					PlayList play = new PlayList();					List<PlayList> _listT = new List<PlayList>();					play.Name = textBox1.Text;					play.Image = caminho;					play.Descrição = textBox2.Text;					play.IDList = (_listInformacoes.Count() + 1);
					_listInformacoes.Add(play);										var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);					string json = JsonConvert.SerializeObject(_listInformacoes);					File.WriteAllText(path + "/Musicas.json", json);
				}
				else
				{
					var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);					var myString = File.ReadAllText(path + "/Musicas.json");					_listInformacoes = JsonConvert.DeserializeObject<List<PlayList>>(myString);
					_listInformacoes[(Id - 1)].Descrição = textBox2.Text;					_listInformacoes[(Id - 1)].Name = textBox1.Text;
					if (caminho != "" && caminho == "null")
						_listInformacoes[(Id - 1)].Image = caminho;
					string json = JsonConvert.SerializeObject(_listInformacoes);					File.WriteAllText(path + "/Musicas.json", json);
				}
				this.Close();
			}
			else
				MessageBox.Show("Tem dados em falta!! \n Por favor complete!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void Form2_Load(object sender, EventArgs e)
		{
			Form1 frm1 = new Form1();			this.Location = new Point((frm1.Size.Width / 4), (frm1.Size.Height / 4));
			try
			{
				var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);				var myString = File.ReadAllText(path+"/Musicas.json");				_listInformacoes = JsonConvert.DeserializeObject<List<PlayList>>(myString);
			}
			catch
			{
				var json = JsonConvert.SerializeObject("[]");				json = json.Replace("\"", "");				var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);				File.WriteAllText(path + "/Musicas.json", json);								var myString = File.ReadAllText(path+"/Musicas.json");				_listInformacoes = JsonConvert.DeserializeObject<List<PlayList>>(myString);
			}
			panel1.Size = new Size(this.Width, this.Height);
			if (Aux == true)
			{
				textBox2.Text = _listInformacoes[(Id - 1)].Descrição;				textBox1.Text = _listInformacoes[(Id - 1)].Name;				pictureBox1.Image = new Bitmap(_listInformacoes[(Id - 1)].Image);
			}
		}
	}
}
