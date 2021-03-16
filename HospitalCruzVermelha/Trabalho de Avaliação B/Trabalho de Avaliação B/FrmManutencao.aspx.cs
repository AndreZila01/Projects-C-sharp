using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabalho_de_Avaliação_B
{
	public partial class FrmManutencao : System.Web.UI.Page
	{
		SqlConnection liga = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; DataBase=L1949_; Integrated Security=True");
		SqlCommand command = new SqlCommand();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
		}

		protected void Button3_Click(object sender, EventArgs e)
		{
			command.Connection = liga;
			liga.Open();
			try
			{
				command.CommandText = "Insert into Tbl_Medicos (NomeMed, Especialidade, Sexo, NumOrdemMed, Telefone) values('" + txtNome.Text + "','" + txtEspe.Text + "', '"+txtSexo.Text+"', '"+txtN.Text+"', '"+txtFone.Text+"')";
				command.ExecuteNonQuery();

				
			}
			catch(Exception ex) {
				Response.Write("<script>alert('Error: " + ex.Message + "')</script>");

			}
			liga.Close();
			Response.Redirect("FrmManutencao.aspx", true);
		}

		protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
		{

		}

		protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
		{
			//string nome = GridView1.Rows[e.RowIndex].Cells[2].Text;
			//char sexo = GridView1.Rows[e.RowIndex].Cells[3].Text.ToCharArray();
			//int nmed = GridView1
		}
	}
}