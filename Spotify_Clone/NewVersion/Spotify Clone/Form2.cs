﻿using Spotify_Clone.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Spotify_Clone
{
	public partial class Form2 : Form
	{
		private string caminhoImg, paths;
		private bool Aux;
		private int Id, ecra;
		Backend bk = new Backend();
		private List<Classes.PlayList> _lsts = new List<Classes.PlayList>();
		List<Classes.PlayList> _lst = new List<Classes.PlayList>();
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
			openFileDialog.Filter = "Image files(*.jpg,*.jpeg,*.jpe,*.jfif,*.png)|*.jpg;*.jpeg;*.jpe;*.jfif;*.png;";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (openFileDialog.FileName.Split('.')[openFileDialog.FileName.Split('.').Length - 1] != "jpg" && openFileDialog.FileName.Split('.')[openFileDialog.FileName.Split('.').Length - 1] != "jpeg" && openFileDialog.FileName.Split('.')[openFileDialog.FileName.Split('.').Length - 1] != "jpe" && openFileDialog.FileName.Split('.')[openFileDialog.FileName.Split('.').Length - 1] != "jfif" && openFileDialog.FileName.Split('.')[openFileDialog.FileName.Split('.').Length - 1] != "png")
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
			//meter a lista _list do form1 publica para poder aceder aqui e depois adicionar a nova playlist na lista
			if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && pictureBox1.Image != null)
			{
				Aqui: char[] letter = textBox1.Text.ToCharArray();
				if (letter[letter.Length - 1].ToString() == " ")
				{
					textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
					goto Aqui;
				}
				if (Id == 0)
				{
					try
					{
						Classes.PlayList play = new Classes.PlayList();
						play.Name = textBox1.Text;
						play.Image = caminhoImg;
						play.Descrição = textBox2.Text;
						var ds = _lst == null ? play.IDList = 1 : play.IDList = ((_lst.Count()) + 1);
						_lst.Add(play);
					}
					catch { }
					bk.WriteReadMusic(false, paths, _lst, -1);
				}
				else
				{
					Classes.PlayList play = new Classes.PlayList();
					_lst = bk.WriteReadMusic(true, paths, null, Id);
					_lst[(Id - 1)].Descrição = textBox2.Text;
					_lst[(Id - 1)].Name = textBox1.Text;
					_lst[(Id - 1)].IDList = Id;
					if (caminhoImg != "" && caminhoImg == "null") _lst[(Id - 1)].Image = caminhoImg;
					bk.WriteReadMusic(false, paths, _lst, Id);
				}
				this.Close();
			}
			else MessageBox.Show("You have not completed the data !!\n Please complete !!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		private void Form2_Load(object sender, EventArgs e)
		{
			_lst = bk.WriteReadMusic(true, paths, _lst, -1);
			Form1 frm1 = new Form1();
			this.Location = Screen.AllScreens[ecra].WorkingArea.Location;
			this.CenterToScreen();
			try
			{
				_lsts = bk.WriteReadMusic(true, paths, null, Id);
			}
			catch { }
			panel1.Size = new Size(this.Width, this.Height);
			if (Aux == true)
			{
				textBox2.Text = _lsts[(Id - 1)].Descrição;
				textBox1.Text = _lsts[(Id - 1)].Name;
				pictureBox1.Image = new Bitmap(_lsts[(Id - 1)].Image);
			}
		}
	}
}