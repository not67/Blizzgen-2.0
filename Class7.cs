using System;
using System.Net.Http;
using AnticaptchaNet;
using AnyCaptchaHelper;
using NewBlizzGen.Properties;
using YoutubeBot._5sim;

internal class Class7
{
	public string method_0()
	{
		float balance = new Api(Settings.Default.fivesim).getAccount().balance;
		return balance.ToString();
	}

	public string SmsActivateBalance()
	{
		string[] array = smethod_0("https://sms-activate.ru/stubs/handler_api.php?api_key=" + Settings.Default.smsactivate + "&action=getBalanceAndCashBack").Split(':');
		Console.WriteLine(array);
		return array[1];
	}

	public string AnyCaptchaBalance()
	{
		return new AnyCaptcha().GetBalance(Settings.Default.anycaptcha).Balance.ToString();
	}

	public string TwoCaptchaBalance()
	{
		return smethod_0("https://2captcha.com/res.php?action=getbalance&key=" + Settings.Default.twocaptcha);
	}

	public float AntiCaptchaBalance()
	{
		return new Anticaptcha(Settings.Default.anticaptcha).GetBalance();
	}

	public static string smethod_0(string string_0)
	{
		HttpClient val = new HttpClient();
		try
		{
			HttpResponseMessage result = val.GetAsync(string_0).GetAwaiter().GetResult();
			if (!result.IsSuccessStatusCode)
			{
				return "0";
			}
			return result.Content.ReadAsStringAsync().GetAwaiter()
				.GetResult();
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
