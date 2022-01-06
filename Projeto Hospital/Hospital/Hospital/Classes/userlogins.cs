using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net.Http;

namespace Hospital.Classes
{
	public class userlogins
	{
		public string userslogin(string name, string pass)
		{
			try
			{
				HttpWebRequest webRequest;
				string requestParams = "{\"username\":\"" + name + "\",\"pass\":\"" + pass + "\"}";
				webRequest = (HttpWebRequest)WebRequest.Create(Properties.Resources.Login);
				webRequest.Method = "POST";
				webRequest.ContentType = "application/json";

				byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
				webRequest.ContentLength = byteArray.Length;
				using (Stream requestStream = webRequest.GetRequestStream())
				{
					requestStream.Write(byteArray, 0, byteArray.Length);
				}
				string Json;
				using (WebResponse response = webRequest.GetResponse())
				{
					using (Stream responseStream = response.GetResponseStream())
					{
						StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
						Json = rdr.ReadToEnd();
					}
				}
				return Json;
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
