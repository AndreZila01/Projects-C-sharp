using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace VesteBem_Site
{
    public partial class AlterarInfo : System.Web.UI.Page
    {
        SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void BtnAlterações_Click(object sender, EventArgs e)
        {
            try
            {
                comando.Connection = liga;
                liga.Open();
                comando.CommandText = "Update tbl_Cliente set Nome='" + txtNome.Text + "', Sexo = '" + RadioButtonList1.SelectedValue + "', Nif = '"  + txtNif.Text + "' , Morada = '" + txtMorada.Text + "', CodPostal = '" + txtCP.Text + "' , Localidade = '" + txtLocalidade.Text + "' , Email = '" + txtEmail.Text + "' , Telefone = '" + txtTelefone.Text + "' where IdCLiente = '" + Session["IdCliente"] + "'";
                dr = comando.ExecuteReader();
                Response.Write($"<script>alert('Alterações registadas')</script>");

            }
            catch (Exception er)
            {
                Response.Write($"<script>alert('{er.Message}')</script>");
            }
            liga.Close();
           
        }

        protected void BtnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmHome.aspx");
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            BtnAlterações.Visible = true;

            comando.Connection = liga;
            liga.Open();

            try
            {
                comando.CommandText = "Select IdCliente, Nome, Sexo, Nif, Id_Login, Morada, CodPostal, Localidade, DataNasc, Email, Telefone from tbl_CLiente where IdCLiente = '" + Session["IdCliente"] + "'";
                dr = comando.ExecuteReader();

                if (dr.Read())
                {


                    txtNome.Text = dr["Nome"].ToString();
                    txtNif.Text = dr["Nif"].ToString();
                    txtMorada.Text = dr["Morada"].ToString();
                    txtCP.Text = dr["CodPostal"].ToString();
                    txtLocalidade.Text = dr["Localidade"].ToString();
                    txtDataNasc.Text = dr["DataNasc"].ToString();
                    txtEmail.Text = dr["Email"].ToString();
                    txtTelefone.Text = dr["Telefone"].ToString();

                }
            }
            catch { }
            liga.Close();
        }
    }
    }
