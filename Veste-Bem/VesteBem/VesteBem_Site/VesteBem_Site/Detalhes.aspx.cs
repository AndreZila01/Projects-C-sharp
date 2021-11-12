using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace VesteBem_Site
{
    public partial class Detalhes : System.Web.UI.Page
    {
        SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        private void FillPage()
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["IdProduto"]))
            {
                int id = Convert.ToInt32(Request.QueryString["IdProduto"]);
                comando.Connection = liga;
                liga.Open();
                comando.CommandText = "Select * from Tbl_Produtos where IdProduto='" + id + "'";
                dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    lblItem.Text = id.ToString();
                    byte[] image = (byte[])dr["Icon"];
                    string PROFILE_PIC = Convert.ToBase64String(image);
                    imgProduct.ImageUrl = String.Format("data:image/jpg;base64,{0}", PROFILE_PIC);
                    imgProduct.Width = 376;
                    imgProduct.Height = 500;
                    // <!-- src="roupa%20HM/cl2.jfif">
                    lblTitle.Text = dr["Nome"].ToString();
                    lblPreco.Text = dr["Valor"].ToString() + "€";
                }
                liga.Close();
            }
        }

        protected void btncomprar_Click(object sender, EventArgs e)
        {
            comando.Connection = liga;
            liga.Open();



            comando.CommandText = "Insert into tblCarrinho (Id_Cliente, Id_Produtos, QuantCar) " + "VALUES(" + Session["IdCliente"].ToString() + "," + lblItem.Text + "," + txtquant.Text + ")";

            try
            {
                int estado = comando.ExecuteNonQuery();

                if (estado == 1)
                    Response.Write($"<script>alert('Item adicionado ao carrinho!!!')</script>");


            }
            catch (Exception er)
            {
                Response.Write($"<script>alert('{er.Message}')</script>");
            }
            liga.Close();
        }
    }
}