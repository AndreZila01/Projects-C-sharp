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
    public partial class frmCliente : Form
    {
        string username, ipSv, myip;
        Socket SocketServer;

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            chbFirst.Checked = false;
            chbSecond.Checked = false;
            chbThird.Checked = false;
            chbFirst.Checked = false;
            switch ((((CheckBox)sender).Name))
            {
                case "chbFirst":
                    chbFirst.Checked = true;
                    break;

                case "chbSecond":
                    chbSecond.Checked = true;
                    break;

                case "chbThird":
                    chbThird.Checked = true;
                    break;

                case "chbFour":
                    chbFirst.Checked = true;
                    break;
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            chbFirst.Checked = false;
            chbSecond.Checked = false;
            chbThird.Checked = false;
            chbFirst.Checked = false;
            switch ((((Label)sender).Name))
            {
                case "lblFirst":
                    chbFirst.Checked = true;
                    break;

                case "lblSecond":
                    chbSecond.Checked = true;
                    break;

                case "lblThird":
                    chbThird.Checked = true;
                    break;

                case "lblFour":
                    chbFirst.Checked = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!chbFirst.Checked || !chbSecond.Checked || !chbThird.Checked || !chbFour.Checked)
                MessageBox.Show("You need select one option at least!");
            else
                SendMessageToServer();
        }

        public frmCliente(string ip, string username)
        {
            this.ipSv = ip;
            this.username = username;
            InitializeComponent();
        }

        private void bgwStart_DoWork(object sender, DoWorkEventArgs e)
        {

            int port = 5000;
            IPAddress ip = IPAddress.Parse(this.ipSv);
            IPEndPoint endPoint = new IPEndPoint(ip, port);
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            clientSocket.Connect(endPoint);
            Console.WriteLine("Conectado ao servidor...");

            Thread receiveThread = new Thread(ReceiveMessages);
            receiveThread.Start(clientSocket);

            while (true)
            {
                int resposta = chbFirst.Checked ? 1 : (chbSecond.Checked ? 2 : (chbThird.Checked ? 3 : (chbFour.Checked ? 4 : -1)));
                string message = "{\"IdQuestion\":1, \"Option\":" + resposta + ", \"Username\":\"" + username + "\"}";
                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                clientSocket.Send(messageBytes);
            }
        }

        private static void ReceiveMessages(object clientObj)
        {
            Socket clientSocket = (Socket)clientObj;
            byte[] buffer = new byte[1024];
            int bytesRead;

            while ((bytesRead = clientSocket.Receive(buffer)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Mensagem recebida: " + message);
            }

            clientSocket.Close();
        }

        private async void frmCliente_Load(object sender, EventArgs e)
        {
            if (!bgwStart.IsBusy) bgwStart.RunWorkerAsync();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //byte[] byData = System.Text.Encoding.UTF8.GetBytes(txtEnvia.Text);
        //SocketCliente.Send(byData);
        //}

        private async void SendMessageToServer()
        {

        }
	}


}
