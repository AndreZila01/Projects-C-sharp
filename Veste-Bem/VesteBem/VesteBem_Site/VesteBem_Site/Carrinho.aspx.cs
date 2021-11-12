using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VesteBem_Site
{
    

    public partial class Carrinho : System.Web.UI.Page
    {
        SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        int total = 0;
        string data = DateTime.Now.ToString("yyyy-MM-dd");
        string numero;
        int situacao = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }
        public void FillPage()
        {
            comando.Connection = liga;
            liga.Open();

            comando.CommandText = "select tblCarrinho.Id_Produtos, Nome, Valor, QuantCar from tblCarrinho, tbl_Produtos where tblCarrinho.Id_Produtos = Tbl_Produtos.IdProduto and tblCarrinho.Id_Cliente = '" + Session["IdCliente"] + "'";
            try
            {
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    lstProduto.Items.Add(dr["Nome"].ToString() + " - " + dr["QuantCar"].ToString());
                    total = total + (Convert.ToInt32(dr["Valor"]) * Convert.ToInt32(dr["QuantCar"]));
                }
                lblpreco.Text = total.ToString() + " € ";
            }
            catch (Exception er)
            {
                Response.Write($"<script>alert('{er.Message}')</script>");
            }
            liga.Close();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            comando.Connection = liga;
            liga.Open();
            comando.CommandText = "Delete from tblCarrinho where Id_Cliente = '" + Session["IdCliente"] + "'";
            comando.ExecuteNonQuery();
            liga.Close();

            lstProduto.Items.Clear();
            lblpreco.Text = "";
        }


        protected void btnContinuarCompras_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmHome.aspx");
        }

        protected void BtnFinalizar_Click(object sender, EventArgs e)
        {
            comando.Connection = liga;
            liga.Open();

            comando.CommandText = "Insert into tbl_Encomendas (Id_Cliente, DataEncomenda, ValorEncomendas, EstadoEncomendas) Values ('" + Session["IdCliente"] + "', '" + data + "', '" + total + "', '" + situacao + "')";
            try
            {
                comando.ExecuteNonQuery();
                liga.Close();
                liga.Open();
                comando.CommandText = "Select Max(IdEncomendas) from Tbl_Encomendas";
                dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    numero = dr.GetValue(0).ToString();
                    comando.CommandText = "Insert into tblDetalheEncomendas (Id_Encomendas, Id_Produtos, QuantEnc) Select " + "'" + numero + "', Id_Produtos, QuantCar from tblCarrinho where tblCarrinho.Id_Cliente = '" + Session["IdCliente"] + "'";
                   
                    liga.Close();
                    liga.Open();
                    comando.ExecuteNonQuery();
                    liga.Close();
                    liga.Open();
                    comando.CommandText = "Delete from tblCarrinho where Id_Cliente = '" + Session["IdCliente"] + "'";
                    comando.ExecuteNonQuery();
                    Response.Write($"<script>alert('Encomenda finalizada com sucesso')</script>");
                    liga.Close();
                   
                }
                lstProduto.Items.Clear();
                lblpreco.Text = "";
            }

            catch (Exception er)
            {
                Response.Write($"<script>alert('{er.Message}')</script>");
            }
            liga.Close();

        }
    }
}