using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace VesteBem
{
    public partial class FrmCMulher : System.Web.UI.Page
    {
        SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;




        protected void Page_Load(object sender, EventArgs e)
        {

            FillPage();

        }
        private void FillPage()
        {
            string art = Request.QueryString["CategoriaClasse"].ToString();
            string sexo = "F";


            command.Connection = liga;
            liga.Open();
            command.CommandText = "Select IdProduto ,Icon, CategoriaClasse, Nome from Tbl_Produtos where CategoriaClasse like '" + art + "' and Sexo ='" + sexo + "'";


            dr = command.ExecuteReader();

            while (dr.Read())
            {
                Panel productPanel = new Panel();
                Label LBL = new Label();
                ImageButton images = new ImageButton();
                LBL.Text = dr["Nome"].ToString();
                byte[] image = (byte[])dr["Icon"];
                string PROFILE_PIC = Convert.ToBase64String(image);
                images.ImageUrl = String.Format("data:image/jpg;base64,{0}", PROFILE_PIC);
                images.Width = 376;
                images.Height = 500;
                images.CssClass = "productImage";
                images.PostBackUrl = "~/Detalhes.aspx?IdProduto=" + dr["IdProduto"];
                
                productPanel.Controls.Add(images);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(LBL);
                productPanel.Controls.Add(new Literal { Text = "<p>" });
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                
               

                Imagems.Controls.Add(productPanel);
               
                
            }
        }


    }
}