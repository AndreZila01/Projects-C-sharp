using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace Criar_texto_no_Gif
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			PrivateFontCollection pfc = new PrivateFontCollection();

			pfc.AddFontFile(Path.Combine(Environment.CurrentDirectory+ @"\Montserrat-VariableFont_wght.ttf"));
			string originalImgPath = Environment.CurrentDirectory + @"\1.gif";


			System.Drawing.Image IMG = System.Drawing.Image.FromFile(originalImgPath);
			FrameDimension dimension = new FrameDimension(IMG.FrameDimensionsList[0]);
			int frameCount = IMG.GetFrameCount(dimension);
			GifBitmapEncoder gEnc = new GifBitmapEncoder();
			for (int i = 0; i < frameCount; i++)
			{
				// Get each frame
				IMG.SelectActiveFrame(dimension, i);
				var aFrame = new Bitmap(IMG);

				// Draw a white rectangle

				Graphics graphics = Graphics.FromImage(aFrame);
				int cornerRadius = 10;
				int rectangleX = aFrame.Width / 10;
				int rectangleY = aFrame.Height - 60;
				int rectangleWidth = Convert.ToInt32(aFrame.Width / 1.21);
				int rectangleHeight = aFrame.Height / 4;

				// Create a GraphicsPath with rounded rectangle shape
				GraphicsPath path = new GraphicsPath();
				path.AddArc(rectangleX, rectangleY, cornerRadius, cornerRadius, 180, 90); // Top-left corner
				path.AddArc(rectangleX + rectangleWidth - cornerRadius, rectangleY, cornerRadius, cornerRadius, 270, 90); // Top-right corner
				path.AddArc(rectangleX + rectangleWidth - cornerRadius, rectangleY + rectangleHeight - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Bottom-right corner
				path.AddArc(rectangleX, rectangleY + rectangleHeight - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Bottom-left corner
				path.CloseFigure();

				// Fill the rounded rectangle with white color
				graphics.FillPath(System.Drawing.Brushes.White, path);
				// Write the text on the rectangle

				string nome = "text";
				System.Drawing.FontFamily fontFamily = pfc.Families[0];
				int fontSize = 13;
				Font font = new Font(fontFamily, fontSize, System.Drawing.FontStyle.Bold);
				SizeF textSize = graphics.MeasureString(nome, font);
				graphics.DrawString($"\tWelcome!!", new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Black, Convert.ToInt32(aFrame.Width / 3.7), aFrame.Height - 50);
				graphics.DrawString($"\n{nome}!!", new System.Drawing.Font(pfc.Families[0], 13, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Black, (rectangleX + (rectangleWidth - (int)textSize.Width) / 2), aFrame.Height - 50);

				var src = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
							aFrame.GetHbitmap(),
							IntPtr.Zero,
							System.Windows.Int32Rect.Empty,
							BitmapSizeOptions.FromEmptyOptions());

				// Merge frames
				gEnc.Frames.Add(BitmapFrame.Create(src));
			}

			using (var ms = new MemoryStream())
			{
				gEnc.Save(ms);
				var fileBytes = ms.ToArray();
				// This is the NETSCAPE2.0 Application Extension.
				var newBytes = new List<byte>();
				newBytes.AddRange(fileBytes.Take(13));
				newBytes.AddRange(new byte[] { 33, 255, 11, 78, 69, 84, 83, 67, 65, 80, 69, 50, 46, 48, 3, 1, 0, 0, 0 });
				newBytes.AddRange(fileBytes.Skip(13));
				File.WriteAllBytes(@"..\tenor-1.gif", newBytes.ToArray());
			}
		}
	}
}
