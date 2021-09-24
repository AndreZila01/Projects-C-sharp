using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Cobra__Aventura
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			Bitmap bmp = new Bitmap(new Bitmap(Properties.Resources.Cobra), 48, 48);
			this.Cursor = new Cursor(bmp.GetHicon());
		}
	}
}
