using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSocket
{
	public partial class frmCliente : Form
	{
		Socket SocketCliente;
		public frmCliente()
		{
			InitializeComponent();
		}

		private void frmCliente_Load(object sender, EventArgs e)
		{
			IPAddress[] ipAddress = Dns.GetHostAddresses("127.0.0.1");
			IPEndPoint ipEnd = new IPEndPoint(ipAddress[0], 5656);
			SocketCliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			SocketCliente.Connect(ipEnd);

			byte[] byData = System.Text.Encoding.UTF8.GetBytes("Teste");
			SocketCliente.Send(byData);
		}

		//private void button1_Click(object sender, EventArgs e)
		//{
		//byte[] byData = System.Text.Encoding.UTF8.GetBytes(txtEnvia.Text);
		//SocketCliente.Send(byData);
		//}
	}
}
