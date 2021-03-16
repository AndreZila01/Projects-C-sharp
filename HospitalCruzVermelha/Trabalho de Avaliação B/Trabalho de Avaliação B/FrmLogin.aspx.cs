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
		SqlDataReader dr;
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btn_click(object sender, EventArgs e)
		{
			if (txtUser.Text != "" && txtPassword.Text != "")
			{
				command.Connection = liga;
				liga.Open();
				try
				{
					command.CommandText = "Select * fROM tbl_Login  where Usern='" + txtUser.Text + "' and Passw='" + txtPassword.Text + "'";
					dr = command.ExecuteReader();
					if (dr.Read())
					{
						liga.Close();
						Response.Redirect("FrmHome.aspx");
					}
					else
						Response.Write("<script>alert('Error: Errou a password ou username\nTente Novamente')</script>");
				}
				catch (Exception ex)
				{
					Response.Write("<script>alert('Error: " + ex.Message + "')</script>");
					//this.RegisterClientScriptBlock(typeof(string), "key", string.Format("alert('{0}');", ex.Message), true);
					//ClientScript.RegisterClientScriptBlock(this.GetType(), "{Error}", "alert('{" + ex + "}'); ", true);
				}
				liga.Close();
				txtPassword.Text = string.Empty;
				txtUser.Text = string.Empty;
			}
		}
	}
}