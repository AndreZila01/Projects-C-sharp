using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabalho_de_Avaliação_B
{
	public partial class FrmHome : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["user"] == null && Session["password"] == null)
			{
				Response.Redirect("FrmLogin.aspx");
				Session["user"] = null;
				Session["password"] = null;
			}
		}
	}
}