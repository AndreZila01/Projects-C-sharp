using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Login;
using Api.Models;
using Newtonsoft.Json;

namespace Api.Controllers
{
	public class Converter
	{
		public static string jsonD(List<Doutors> Ds)
		{
			string dss = JsonConvert.SerializeObject(Ds);
			return dss;
		}
		public static string jsonL(List<login> Ds)
		{
			string dss = JsonConvert.SerializeObject(Ds);
			return dss;
		}

	}

}
