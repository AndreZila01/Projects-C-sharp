using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Controllers;
using Api.Models;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.Serialization.Json;
using System.Text;
using Api.Login;

namespace Api
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoginController : ControllerBase
	{
		List<login> lst = new List<login>();
		[HttpGet]
		public IActionResult Get()
		{
			ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
			string d = "Login";

			return Ok(d);
		}

		[HttpPost]
		public IActionResult Post([FromBody]login login)
		{
			string result = "";
			SqlDataReader dr;
			ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
			//string str = string.Empty;
			try
			{
				using (SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; DataBase=HospCruz; Integrated Security=True"))
				{
					conn.Open();
					login matchingPerson = new login();
					using (SqlCommand command = new SqlCommand("Select login.Idlogin, pass, username, Funcao.Funcao From login, Funcionario, Funcao where Funcionario.IdLogin=login.Idlogin and Funcionario.idFuncao=Funcao.idFuncao and username='" + login.username + "'"))
					{

						command.Connection = conn;
						dr = command.ExecuteReader();
						if (dr.Read()) //throw new ArgumentException("User not found in database, please check if you write right!");
						{
							if (dr["pass"].ToString() == login.pass) 
								result = "True";
							if (dr["Funcao"].ToString() == "Admin")
								result = "Admin";
							else
								result = "Name or Password is not correct, write right username and password!";
						}

						conn.Close();
					}
				}
			}
			catch (Exception ex)
			{
				result = "" + ex;
			}


			return Ok(result);
		}

		[HttpPut]
		public IActionResult Put()
		{
			ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
			string str = string.Empty;
			using (SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; DataBase=HospCruz; Integrated Security=True"))
			{
				login matchingPerson = new login();
				using (SqlCommand command = new SqlCommand("Select * from Funcionario order by nome"))
				{
					using (SqlDataAdapter adapter = new SqlDataAdapter())
					{
						command.Connection = conn;
						adapter.SelectCommand = command;
						using (DataTable dtEmployee = new DataTable())
						{
							adapter.Fill(dtEmployee);
							foreach (DataColumn column in dtEmployee.Columns)
							{
								str += column.ColumnName + "\t\t";
							}
							str += "\r\n";
							SqlCommand oCmd = new SqlCommand("Select * from dbo.login order by Idlogin", conn);
							conn.Open();
							List<login> lstLogin = new List<login>();
							using (SqlDataReader oReader = oCmd.ExecuteReader())
							{

								while (oReader.Read())
								{
									login Login = new login();
									Login.Idlogin = int.Parse(oReader["Idlogin"].ToString());
									Login.username = oReader["username"].ToString();
									Login.pass = oReader["pass"].ToString();

									lstLogin.Add(Login);
								}
								conn.Close();
								str = Converter.jsonL(lstLogin);
							}
						}
						ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
						return Ok(str);
					}
				}
			}
		}

		public static string Serialize<T>(T obj)
		{
			DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
			using (MemoryStream ms = new MemoryStream())
			{
				serializer.WriteObject(ms, obj);
				return Encoding.Default.GetString(ms.ToArray());
			}
		}
	}
}
