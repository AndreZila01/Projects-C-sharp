using Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Api.Controllers
{

	[Route("api/[controller]")]//https://localhost:44391/api/doutor
	[ApiController]
	public class DoutorController : ControllerBase
	{

		List<Doutors> lst = new List<Doutors>();

		[HttpGet]
		public IActionResult Get()
		{
			ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
			string d = "Funcionario";

			Response.Redirect("loginController.cs");
			return Ok(d);
		}

		[HttpPut]
		public IActionResult Put()
		{
			ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
			string str = string.Empty;
			using (SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; DataBase=HospCruz; Integrated Security=True"))
			{
				Doutors matchingPerson = new Doutors();
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
							SqlCommand oCmd = new SqlCommand("Select * from Funcionario order by IdFuncionario", conn);
							conn.Open();
							List<Doutors> lstdoutors = new List<Doutors>();
							using (SqlDataReader oReader = oCmd.ExecuteReader())
							{

								while (oReader.Read())
								{
									Doutors doutors = new Doutors();
									doutors.IdFuncionario = int.Parse(oReader["IdFuncionario"].ToString());
									doutors.Nome = oReader["Nome"].ToString();
									doutors.Apelido = oReader["Apelido"].ToString();
									var dsss = oReader["NordemMedicos"].ToString() != "" ? doutors.NOrdemMedicos = oReader["NOrdemMedicos"].ToString() : doutors.NOrdemMedicos = "NULL";
									doutors.IdLogin = int.Parse(oReader["IdLogin"].ToString());
									doutors.idFuncao = int.Parse(oReader["idFuncao"].ToString());

									lstdoutors.Add(doutors);
								}
								conn.Close();
								str = Converter.jsonD(lstdoutors);
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