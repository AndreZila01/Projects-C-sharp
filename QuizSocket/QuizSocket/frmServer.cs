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
	public partial class frmServer : Form
	{
		Socket socketServidor;
		byte[] clientData = new byte[1024];
		public frmServer()
		{
			InitializeComponent();
			lblIp.Text = frmMenu.ipv4ofuser;
			IPEndPoint ipend = new IPEndPoint(IPAddress.Any, 5656);
			socketServidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			socketServidor.Bind(ipend);
			socketServidor.Listen(100); // numero de ligações

			socketServidor.BeginAccept(new AsyncCallback(OnAccept), null);
		}

		private void OnAccept(IAsyncResult ar)
		{
			Socket clienteSocket = socketServidor.EndAccept(ar);

			// Inicia para receber mais clientes !!!
			socketServidor.BeginAccept(new AsyncCallback(OnAccept), null);

			clienteSocket.BeginReceive(clientData, 0, clientData.Length, SocketFlags.None
			, new AsyncCallback(OnReceive), clienteSocket);
		}
		private void OnReceive(IAsyncResult ar)
		{
			Socket clienteSocket = (Socket)ar.AsyncState;
			clienteSocket.EndReceive(ar);

			string strRecebe = Encoding.UTF8.GetString(clientData);
			strRecebe = strRecebe.Replace("\0", string.Empty);

			//txtLog.AppendText(strRecebe + "\r\n");
			clienteSocket.BeginReceive(clientData, 0, clientData.Length, SocketFlags.None,
					new AsyncCallback(OnReceive), clienteSocket);
		}

		private void frmServer_FormClosed(object sender, FormClosedEventArgs e)
		{
			socketServidor.Close();
			Application.OpenForms[0].Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}

/*
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Servidor
{
    public partial class frmServidor : Form
    {
        Socket socketServidor;
        byte[] clientData = new byte[1024];
        public frmServidor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPEndPoint ipend = new IPEndPoint(IPAddress.Any, 5656);
            socketServidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketServidor.Bind(ipend);
            socketServidor.Listen(100); // numero de ligações

            socketServidor.BeginAccept(new AsyncCallback(OnAccept), null);
        }

        private void OnAccept(IAsyncResult ar)
        {
            Socket clienteSocket = socketServidor.EndAccept(ar);

            // Inicia para receber mais clientes !!!
            socketServidor.BeginAccept(new AsyncCallback(OnAccept), null);

            clienteSocket.BeginReceive(clientData, 0, clientData.Length, SocketFlags.None
            , new AsyncCallback(OnReceive), clienteSocket);
        }
        private void OnReceive(IAsyncResult ar)
        {
            Socket clienteSocket = (Socket)ar.AsyncState;
            clienteSocket.EndReceive(ar);

            string strRecebe = Encoding.UTF8.GetString(clientData);
            strRecebe = strRecebe.Replace("\0", string.Empty);

            txtLog.AppendText(strRecebe + "\r\n");
            clienteSocket.BeginReceive(clientData, 0, clientData.Length, SocketFlags.None,
                    new AsyncCallback(OnReceive), clienteSocket);
        }
    }
}

 */