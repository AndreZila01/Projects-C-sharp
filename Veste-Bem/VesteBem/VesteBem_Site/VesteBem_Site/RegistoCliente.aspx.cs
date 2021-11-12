using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VesteBem.Classes;
using VesteBem_Site;
using System.Data.SqlClient;

namespace VesteBem
{
    public partial class Teste : System.Web.UI.Page
    {
        SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433; Database=bd; User ID=epbjc;Password=Teste123; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;");
        SqlCommand comando = new SqlCommand();
        SqlCommand comando2 = new SqlCommand();
        SqlCommand comando3 = new SqlCommand();
        SqlCommand comando4 = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnVoltar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("FrmHome.aspx");
        }

        protected void BtnRegistar_Click(object sender, EventArgs e)
        {
            comando.Connection = liga;
            comando2.Connection = liga;
            comando3.Connection = liga;
            comando4.Connection = liga;
            
            




            liga.Open();


            comando4.CommandText = "Select Count(*) from tbl_login where Usern='" + txtUsername.Text + "'";
            int existe = (int)comando4.ExecuteScalar();
            if(existe > 0 )
            {
                lblMensagem.Text = "O username já existe!!";
            }
                else
            {
                if (txtPassword.Text == txtPasswordConfirmar.Text)
                {
                    comando.CommandText = "Insert into Tbl_Login(Usern ,Passw, Funcionario) " + "VALUES('" + txtUsername.Text + "', '" + EncryptADeDecrypt.EncryptRSA(txtPassword.Text) + "', '0')";
                SqlDataReader dr;
                try
                {
                    comando.ExecuteNonQuery();
                    //lblMensagem.Text = "Registado com sucesso";
                    //txtNomeCliente.Text = "";
                    //txtEmail.Text = "";
                    //txtCodPostal.Text = "";
                    //txtDataNasc.Text = "";
                    //txtLocalidade.Text = "";
                    //txtMorada.Text = "";
                    //txtNif.Text = "";
                    //txtPassword.Text = "";
                    //txtPasswordConfirmar.Text = "";
                    //txtTelefone.Text = "";
                    //txtUsername.Text = "";



                    liga.Close();


                    liga.Open();
                    comando2.CommandText = "Select IdLogin, Passw from tbl_Login where Usern like '" + txtUsername.Text + "'";
                    dr = comando2.ExecuteReader();

                    if (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["IdLogin"].ToString());
                        if (txtPassword.Text == EncryptADeDecrypt.DecryptRSA(dr["Passw"].ToString()))
                        {

                            liga.Close();
                            liga.Open();

                            
                                comando3.CommandText = "Insert into Tbl_Cliente(Nome ,Sexo , Nif,Morada ,CodPostal ,Localidade , DataNasc ,Email ,Telefone, Id_Login) " + "VALUES('" + txtNomeCliente.Text + "', '" + RadioButtonList1.SelectedValue + "', '" + txtNif.Text + "', '" + txtMorada.Text + "', '" + txtCodPostal.Text + "', '" + txtLocalidade.Text + "', '" + txtDataNasc.Text + "', '" + txtEmail.Text + "', '" + txtTelefone.Text + "', '" + id + "')";
                                comando3.ExecuteNonQuery();
                                lblMensagem.Text = "Registado com sucesso";
                           

                        }
                    }


                }
 

                catch (Exception er)
                {
                    lblMensagem.Text = er.Message;
                }
                liga.Close();

                }
                else
                    lblMensagem.Text = "As passwords não são iguais, verifique se estão as duas iguais!";


            }

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
