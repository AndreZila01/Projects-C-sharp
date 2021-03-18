using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabalho_de_Avaliação_B
{
	public partial class FrmRegConsulta : System.Web.UI.Page
	{
		SqlConnection liga = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; DataBase=L1949_; Integrated Security=True");
		SqlCommand command = new SqlCommand();
		protected void Page_Load(object sender, EventArgs e)
		{
			Panel1.Visible = false;
		}

		protected void Button3_Click(object sender, EventArgs e)
		{
			if (txtData.Text != "" && TextBox3.Text != "" && TextBox5.Text != "")
			{
				command.Connection = liga;
				liga.Open();
				try
				{
					command.CommandText = "Insert into Tbl_Consulta(DataCons, NMed, NPac, ValorCon, MotivoDaConsulta) values('" + txtData.Text + "', '" + DropDownList1.SelectedValue + "', '" + DropDownList2.SelectedValue + "', '" + TextBox3.Text + "', '" + TextBox5.Text + "')";
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Response.Write("<script>alert('Error: " + ex.Message + "')</script>");
				}
				liga.Close();
				Response.Redirect("FrmRegConsulta.aspx");
			}
			else
				Response.Write("<script>alert('Error: Complete os campos')</script>");
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
		}
	}
}