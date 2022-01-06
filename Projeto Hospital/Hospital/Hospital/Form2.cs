using Hospital.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
	public partial class Form2 : Form
	{
		public static int user;
		List<Funcionario> lstf = new List<Funcionario>();
		public Form2(int users)
		{
			InitializeComponent();
			user = users;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			var time = new timerofnetwork();

			label1.Text = String.Format("{0}:{1}\n{2}, {3}/{4}/{5}", time.GetNetworkTime().Hour.ToString(), time.GetNetworkTime().Minute.ToString(), time.GetNetworkTime().DayOfWeek.ToString(), time.GetNetworkTime().Day.ToString(), time.GetNetworkTime().Month.ToString(), time.GetNetworkTime().Year);

			timer1.Interval = 60000;
			Debug.Print("" + timer1.Interval);
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			var time = new timerofnetwork();
			label1.Text = String.Format("{0}:{1}\n{2}, {3}/{4}/{5}", time.GetNetworkTime().Hour.ToString(), time.GetNetworkTime().Minute.ToString(),  time.GetNetworkTime().DayOfWeek.ToString(), time.GetNetworkTime().Day.ToString(), time.GetNetworkTime().Month.ToString(), time.GetNetworkTime().Year);
			timer1.Interval = 60000 - (time.GetNetworkTime().Second*1000);
			timer1.Start();

			PFuncionarios fun = new PFuncionarios();
			lstf=fun.funcionario();

		}

       
    }
}
