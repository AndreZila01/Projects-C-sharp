using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Classes
{
	public class PFuncionarios
	{
		static byte[] data;
		public List<Funcionario> funcionario()
		{
			List<Funcionario> lstFun = new List<Funcionario>(); Funcionario funcionario = new Funcionario();
			List<string> lst = new List<string>();
			try
			{
				var httpRequest = (HttpWebRequest)WebRequest.Create(Properties.Resources.Login);
				httpRequest.Method = "PUT";
				ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
				using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
				{
					streamWriter.Write(data);
				}

				var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
				using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
				{
					var result = streamReader.ReadToEnd().ToString().Replace(@"\", "");
					lst = result.Split(new string[] { "\"" }, StringSplitOptions.None).ToList();


					result = "";
					for (int d = 1; d < (lst.Count) - 1; d++)
					{
						if (lst.Count - 2 > d)
							result += lst[d] + "\"";
						else
							result += lst[d];
					}

					lstFun = JsonConvert.DeserializeObject<List<Funcionario>>(result);
					for (int d = 0; d < lstFun.Count(); d++)
					{
						if (Form2.user != d)
							lstFun.RemoveAt(d);
					}
					return lstFun;
				}
			}
			catch (Exception ex)
			{

			}

			return null;
		}

	}
}
