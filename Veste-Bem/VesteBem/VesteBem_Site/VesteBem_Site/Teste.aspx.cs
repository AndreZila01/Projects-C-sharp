using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VesteBem_Site
{
	//public class Logins
	//{
	//	public string UserName { get; set; }
	//	public string Password { get; set; }
	//}
	//public partial class WebForm1 : System.Web.UI.Page
	//{
	//	protected void Page_Load(object sender, EventArgs e)
	//	{
	//		string Paths = Path.Combine(Path.GetTempPath());
	//		Logins login = new Logins();
	//		List<Logins> ListLogin = new List<Logins>();
	//		try
	//		{
	//			if (File.Exists($"{Paths + @"\Login.json"}"))
	//			{
	//				File.Delete($"{Paths + @"\Login.json"}");
	//			}
	//			login.UserName = EncryptADeDecrypt.EncryptOther("Admin");
	//			login.Password = EncryptADeDecrypt.EncryptRSA("Admin");

	//			ListLogin.Clear();
	//			ListLogin.Add(login);

	//			string json = JsonConvert.SerializeObject(ListLogin);
	//			File.WriteAllText(Paths + "\\Login.json", json);
	//		}
	//		catch (Exception Ex)
	//		{
	//			Console.WriteLine(Ex.ToString());
	//		}
	//	}
	//}
}