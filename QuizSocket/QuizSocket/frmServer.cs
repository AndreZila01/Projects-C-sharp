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
using System.Threading;

namespace QuizSocket
{
	public partial class frmServer : Form
	{
		private static List<Socket> clients = new List<Socket>();

		List<Quiz> lstjogo = new List<Quiz>();
		Socket socketServidor;
		byte[] clientData = new byte[1024];
		public frmServer()
		{
			InitializeComponent();
			lblIp.Text = frmMenu.ipv4ofuser;

			int port = 5000;
			IPAddress ip = IPAddress.Parse("127.0.0.1");
			TcpListener listener = new TcpListener(ip, port);

			listener.Start();
			Console.WriteLine("Servidor iniciado...");

			while (true)
			{
				Socket clientSocket = listener.AcceptSocket();
				var s = new Users() { User = clientSocket, AnswersRights = new List<int>(), Erradas = 0, IpUser = lblIp.Text.ToString(), NCertas = 0, UserName = "" };
				var ss = new Question() { idPergunta = 0, Certa = "", Errada1 = "", Errada3 = "", ErradaA2 = "", Pergunta = "" };

				List<Question> ssss = new List<Question>();
				ssss.Add(ss);
				List<Users> ssa = new List<Users>();
				ssa.Add(s);
				lstjogo.Add(new Quiz() { Users = ssa, Perguntas = ssss });
				Console.WriteLine("Cliente conectado...");

				Thread clientThread = new Thread(HandleClient);
				clientThread.Start(clientSocket);
			}
		}

		private static void HandleClient(object clientObj)
		{
			Socket clientSocket = (Socket)clientObj;
			byte[] buffer = new byte[1024];
			int bytesRead;

			while ((bytesRead = clientSocket.Receive(buffer)) > 0)
			{
				string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
				Console.WriteLine("Mensagem recebida: " + message);
				BroadcastMessage(message, clientSocket);
			}

			clientSocket.Close();
			clients.Remove(clientSocket);
			Console.WriteLine("Cliente desconectado...");
		}

		private static void BroadcastMessage(string message, Socket senderSocket)
		{
			byte[] messageBytes = Encoding.UTF8.GetBytes(message);
			foreach (var client in clients)
			{
				if (client != senderSocket)
				{
					client.Send(messageBytes);
				}
			}
		}

		private void frmServer_FormClosed(object sender, FormClosedEventArgs e)
		{
			socketServidor.Close();
			Application.OpenForms[0].Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			switch ((((Button)sender).Name))
			{
				case "btnAdd":
					//lstjogo.Add(new Question() {idPergunta = 0,Pergunta = txtPergunta.Text, Certa = txtCerta.Text, Errada1 =  txtErrada1.Text, ErradaA2= txtErrada2.Text, Errada3 = txtErrada3.Text });
					break; 
				case "btnNext":
					lblNext.Enabled = false;
					lblPreview.Enabled = true;

					break;
				case "btnBlock":
					break;
				case "btnOptions":
					break;
			}
		}

		private void BgwStart_DoWork(object sender, DoWorkEventArgs e)
		{

		}

		private void BgwStart_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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