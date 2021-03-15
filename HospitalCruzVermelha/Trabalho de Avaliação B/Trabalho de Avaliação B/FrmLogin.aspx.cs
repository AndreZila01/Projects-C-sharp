using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabalho_de_Avaliação_B
{
	public partial class FrmLogin : System.Web.UI.Page
	{
		SqlConnection liga = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; DataBase=L1949_; Integrated Security=True");
		SqlCommand command = new SqlCommand();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			liga.Open();
			SqlDataReader dr;
			try
			{
				command.CommandText = "Select * From tbl_Login where Usern='" + TextBox2.Text + "' and Passw='" + TextBox3.Text + "'";
				dr = command.ExecuteReader();

				if (dr.Read())
				{
					Session["user"] = TextBox2.Text;
					Session["Password"] = TextBox3.Text;
					Response.Redirect("FrmWelcome.aspx");
				}
			}
			catch { }
			liga.Close();
			//Select * From tbl_Login where Usern='JosePedro' and Passw='123'
		}
	}
}