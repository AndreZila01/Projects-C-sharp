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
	public partial class FrmConsultas : System.Web.UI.Page
	{
		//SqlConnection liga = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; DataBase=L1949_; Integrated Security=True");
		//SqlCommand command = new SqlCommand();
		protected void Page_Load(object sender, EventArgs e)
		{
			//TextBox2.TextChanged += TextBox2_TextChanged;
		}

		protected void TextBox2_TextChanged(object sender, EventArgs e)
		{
			//Select NumCons, DataCons, NomePac, NomeMed, MotivoDaConsulta, ResultadoMed From Tbl_Consulta, Tbl_Medicos, Tbl_Pacientes  where Tbl_Consulta.NPac = Tbl_Pacientes.NumPac  and Tbl_Consulta.NMed = Tbl_Medicos.NumMed and Nmed like '%1%'
			//command.Connection = liga;
			//liga.Open();

			//try
			//{
				//int value = int.Parse(TextBox2.Text);
				//SqlDataAdapter command = new SqlDataAdapter("Select NumCons, DataCons, NomePac, NomeMed, ValorCon, MotivoDaConsulta, ResultadoMed From Tbl_Consulta, Tbl_Medicos, Tbl_Pacientes  where Tbl_Consulta.NPac=Tbl_Pacientes.NumPac  and Tbl_Consulta.NMed=Tbl_Medicos.NumMed and  Nmed like '%" + value + "%'", liga);
				//DataTable tbl = new DataTable();
				//command.Fill(tbl);
				//GridView1.DataSource = tbl;
				//GridView1.DataBind();
				//GridView1.Rows[3].DataIt
				//DataFormatString="{0:###.##}%"

			//}
			//catch
			//{

			//}

			//liga.Close();

		}

		protected void TextBox2_TextChanged1(object sender, EventArgs e)
		{

		}
	}
}