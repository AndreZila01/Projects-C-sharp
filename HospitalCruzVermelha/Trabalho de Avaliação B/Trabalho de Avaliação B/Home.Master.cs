using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabalho_de_Avaliação_B
{
	public partial class Home : System.Web.UI.MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Label2.Text = "Data:" + DateTime.Now.ToLongDateString();
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			Button1.Visible = false;
			Response.Redirect("FrmLogin.aspx");//Response.Redirect("FrmLogin.aspx");
		}

		protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
		{

		}
	}
}