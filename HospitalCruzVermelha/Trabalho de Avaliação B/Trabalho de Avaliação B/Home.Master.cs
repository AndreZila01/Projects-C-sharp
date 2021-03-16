using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabalho_de_Avaliação_B
{
	public partial class Home : System.Web.UI.MasterPage
	{
		SqlConnection liga = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; DataBase=L1949_; Integrated Security=True");
		protected void Page_Load(object sender, EventArgs e)
		{
			Label2.Text = "Data:" + DateTime.Now.ToLongDateString();
		}
		protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
		{

		}
	}
}