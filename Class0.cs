using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Win32;
using RestSharp;

internal class Class0
{
	public class Class1<E5E91UhHNlTK7sjDsAB>
	{
		[CompilerGenerated]
		private E5E91UhHNlTK7sjDsAB gparam_0;

		[CompilerGenerated]
		private List<Class3> fvkhedtamO;

		public E5E91UhHNlTK7sjDsAB Data
		{
			[CompilerGenerated]
			get
			{
				return gparam_0;
			}
			[CompilerGenerated]
			set
			{
				gparam_0 = value;
			}
		}

		public List<Class3> Errors
		{
			[CompilerGenerated]
			get
			{
				return fvkhedtamO;
			}
			[CompilerGenerated]
			set
			{
				fvkhedtamO = value;
			}
		}
	}

	public class Class2<da8sy1hnD9Zxt7Ie9J2, RAUmtAhI85Zp6tqTvgs> : Class1<da8sy1hnD9Zxt7Ie9J2>
	{
		[CompilerGenerated]
		private RAUmtAhI85Zp6tqTvgs gparam_1;

		public RAUmtAhI85Zp6tqTvgs Meta
		{
			[CompilerGenerated]
			get
			{
				return gparam_1;
			}
			[CompilerGenerated]
			set
			{
				gparam_1 = value;
			}
		}
	}

	public class Class3
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string ohkhUamJtQ;

		public string Title
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			set
			{
				string_0 = value;
			}
		}

		public string Detail
		{
			[CompilerGenerated]
			get
			{
				return string_1;
			}
			[CompilerGenerated]
			set
			{
				string_1 = value;
			}
		}

		public string Code
		{
			[CompilerGenerated]
			get
			{
				return ohkhUamJtQ;
			}
			[CompilerGenerated]
			set
			{
				ohkhUamJtQ = value;
			}
		}
	}

	public class Class4
	{
		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string alLhoaKlPV;

		public bool Valid
		{
			[CompilerGenerated]
			get
			{
				return bool_0;
			}
			[CompilerGenerated]
			set
			{
				bool_0 = value;
			}
		}

		public string Detail
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			set
			{
				string_0 = value;
			}
		}

		public string Code
		{
			[CompilerGenerated]
			get
			{
				return string_1;
			}
			[CompilerGenerated]
			set
			{
				string_1 = value;
			}
		}

		public string Constant
		{
			[CompilerGenerated]
			get
			{
				return alLhoaKlPV;
			}
			[CompilerGenerated]
			set
			{
				alLhoaKlPV = value;
			}
		}
	}

	public class Class5
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		public string Type
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			set
			{
				string_0 = value;
			}
		}

		public string ID
		{
			[CompilerGenerated]
			get
			{
				return string_1;
			}
			[CompilerGenerated]
			set
			{
				string_1 = value;
			}
		}
	}

	public class Class6
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		public string Type
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			set
			{
				string_0 = value;
			}
		}

		public string ID
		{
			[CompilerGenerated]
			get
			{
				return string_1;
			}
			[CompilerGenerated]
			set
			{
				string_1 = value;
			}
		}
	}

	private RestClient restClient_0;

	public Class0(string string_0)
	{
		restClient_0 = new RestClient("https://api.keygen.sh/v1/accounts/d73e6445-0144-4c29-9ab4-3bb289ace2b4");
	}

	public Class2<Class5, Class4> method_0(string string_0, string string_1)
	{
		RestRequest restRequest = new RestRequest("licenses/actions/validate-key", Method.POST);
		restRequest.AddHeader("Content-Type", "application/vnd.api+json");
		restRequest.AddHeader("Accept", "application/vnd.api+json");
		restRequest.AddJsonBody(new
		{
			meta = new
			{
				key = string_0,
				scope = new
				{
					fingerprint = string_1
				}
			}
		});
		IRestResponse<Class2<Class5, Class4>> restResponse = restClient_0.Execute<Class2<Class5, Class4>>(restRequest);
		if (restResponse.Data.Errors != null && restResponse.Data.Errors.Count > 0)
		{
			Console.WriteLine("[ERROR] [ValidateLicense] Status={0} Errors={1}", restResponse.StatusCode, restResponse.Data.Errors);
			Environment.Exit(1);
		}
		return restResponse.Data;
	}

	public Class1<Class6> method_1(string string_0, string string_1, string string_2)
	{
		RestRequest restRequest = new RestRequest("machines", Method.POST);
		restRequest.AddHeader("Authorization", "Bearer " + string_2);
		restRequest.AddHeader("Content-Type", "application/vnd.api+json");
		restRequest.AddHeader("Accept", "application/vnd.api+json");
		restRequest.AddJsonBody(new
		{
			data = new
			{
				type = "machine",
				attributes = new
				{
					fingerprint = string_1,
					name = Environment.MachineName,
					hostname = Environment.GetEnvironmentVariable("COMPUTERNAME"),
					platform = (string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion").GetValue("ProductName"),
					cores = Environment.ProcessorCount
				},
				relationships = new
				{
					license = new
					{
						data = new
						{
							type = "license",
							id = string_0
						}
					}
				}
			}
		});
		IRestResponse<Class1<Class6>> restResponse = restClient_0.Execute<Class1<Class6>>(restRequest);
		if (restResponse.Data.Errors != null && restResponse.Data.Errors.Count > 0)
		{
			Console.WriteLine("[ERROR] [ActivateDevice] Status={0} Errors={1}", restResponse.StatusCode, restResponse.Data.Errors);
			Environment.Exit(1);
		}
		return restResponse.Data;
	}
}
