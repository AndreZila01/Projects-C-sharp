using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using VesteBem.Classes;

namespace VesteBem_Site.Classes
{
	public class CheckAdmin
	{
		public static int SelectFuncionario(int idlogin, string username, string pass)
		{
			SqlConnection liga = new SqlConnection(@"Server=tcp:srv-epbjc.database.windows.net,1433;Initial Catalog=bd;Persist Security Info=False;User ID=epbjc;Password=Teste123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			SqlCommand comando = new SqlCommand("Select Funcionario, IdLogin From tbl_Cliente, tbl_login where tbl_Cliente.Id_Login = tbl_login.IdLogin and IdLogin = "+idlogin+"", liga);
			int idcli = 0;
			try
			{
				comando.Connection = liga;
				liga.Open();
				using (SqlDataReader oReader = comando.ExecuteReader())
				{
					if (oReader.Read())
					{
						string Paths = Path.Combine(Path.GetTempPath());
						Logins logins = new Logins();
						List<Logins> ListLogin = new List<Logins>();
						try
						{
							if (int.Parse(oReader["Funcionario"].ToString())==1)
							{
								if (File.Exists($"{Paths + @"\Login.json"}"))
									File.Delete($"{Paths + @"\Login.json"}");

								logins.UserName = username;
								logins.Password = pass;

								ListLogin.Clear();
								ListLogin.Add(logins);

								string json = JsonConvert.SerializeObject(ListLogin);
								File.WriteAllText(Paths + "\\Login.json", json); }
						}
						catch (Exception Ex)
						{
							Console.WriteLine(Ex.ToString());
						}
					}
				}
			}
			catch
			{
				return 0;
			}
			finally
			{
				liga.Close();
			}
			return 0;
		}
	}
}