using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NewBlizzGen.Properties
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	[CompilerGenerated]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance;

		public static Settings Default => defaultInstance;

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("gmail.com")]
		public string emaildomain
		{
			get
			{
				return (string)this["emaildomain"];
			}
			set
			{
				this["emaildomain"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string fivesim
		{
			get
			{
				return (string)this["fivesim"];
			}
			set
			{
				this["fivesim"] = value;
			}
		}

		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string license
		{
			get
			{
				return (string)this["license"];
			}
			set
			{
				this["license"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string gamertag
		{
			get
			{
				return (string)this["gamertag"];
			}
			set
			{
				this["gamertag"] = value;
			}
		}

		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string password
		{
			get
			{
				return (string)this["password"];
			}
			set
			{
				this["password"] = value;
			}
		}

		[DefaultSettingValue("tesla")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string secretans
		{
			get
			{
				return (string)this["secretans"];
			}
			set
			{
				this["secretans"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string webhook
		{
			get
			{
				return (string)this["webhook"];
			}
			set
			{
				this["webhook"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool senddiscord
		{
			get
			{
				return (bool)this["senddiscord"];
			}
			set
			{
				this["senddiscord"] = value;
			}
		}

		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool savefile
		{
			get
			{
				return (bool)this["savefile"];
			}
			set
			{
				this["savefile"] = value;
			}
		}

		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		public int success
		{
			get
			{
				return (int)this["success"];
			}
			set
			{
				this["success"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int failed
		{
			get
			{
				return (int)this["failed"];
			}
			set
			{
				this["failed"] = value;
			}
		}

		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string smsactivate
		{
			get
			{
				return (string)this["smsactivate"];
			}
			set
			{
				this["smsactivate"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string anycaptcha
		{
			get
			{
				return (string)this["anycaptcha"];
			}
			set
			{
				this["anycaptcha"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string anticaptcha
		{
			get
			{
				return (string)this["anticaptcha"];
			}
			set
			{
				this["anticaptcha"] = value;
			}
		}

		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string twocaptcha
		{
			get
			{
				return (string)this["twocaptcha"];
			}
			set
			{
				this["twocaptcha"] = value;
			}
		}

		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string smsoperator
		{
			get
			{
				return (string)this["smsoperator"];
			}
			set
			{
				this["smsoperator"] = value;
			}
		}

		[DefaultSettingValue("India")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string country
		{
			get
			{
				return (string)this["country"];
			}
			set
			{
				this["country"] = value;
			}
		}

		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("1")]
		public int mode
		{
			get
			{
				return (int)this["mode"];
			}
			set
			{
				this["mode"] = value;
			}
		}

		[DefaultSettingValue("1")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int invisible
		{
			get
			{
				return (int)this["invisible"];
			}
			set
			{
				this["invisible"] = value;
			}
		}

		[DefaultSettingValue("1")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public int proxies
		{
			get
			{
				return (int)this["proxies"];
			}
			set
			{
				this["proxies"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("10")]
		public int threads
		{
			get
			{
				return (int)this["threads"];
			}
			set
			{
				this["threads"] = value;
			}
		}

		static Settings()
		{
			defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
		}
	}
}
