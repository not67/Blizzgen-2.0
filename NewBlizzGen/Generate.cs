using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AnyCaptchaHelper;
using Faker;
using Guna.UI2.WinForms;
using NewBlizzGen.Properties;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using YoutubeBot._5sim;
using YoutubeBot._5sim.Objects;

namespace NewBlizzGen
{
	public class Generate : UserControl
	{
		private static SemaphoreSlim semaphoreSlim_0;

		private List<Thread> list_0 = new List<Thread>();

		public string country = "";

		public string smsoperator = "any";

		public List<string> proxies = new List<string>();

		private Class7 class7_0 = new Class7();

		public int _success;

		public int _failed;

		private IContainer icontainer_0;

		private Guna2Button startBTN;

		private Guna2TextBox guna2TextBox_0;

		private Guna2GroupBox guna2GroupBox1;

		private Guna2GroupBox zHcsrajlRn;

		private Guna2TextBox guna2TextBox_1;

		private Guna2MessageDialog guna2MessageDialog_0;

		private Guna2Button resetBTN;

		private Guna2TrackBar guna2TrackBar1;

		private Guna2NotificationPaint guna2NotificationPaint_0;

		private Guna2GroupBox guna2GroupBox3;

		private Guna2HtmlLabel AnyCaptchaBalance;

		private Guna2HtmlLabel guna2HtmlLabel10;

		private Guna2HtmlLabel AntiCaptchaBalance;

		private Guna2HtmlLabel guna2HtmlLabel6;

		private Guna2HtmlLabel TwoCaptchaBalance;

		private Guna2HtmlLabel guna2HtmlLabel8;

		private Guna2HtmlLabel SmsActivateBalance;

		private Guna2HtmlLabel guna2HtmlLabel4;

		private Guna2HtmlLabel FiveSimBalanceDisplay;

		private Guna2HtmlLabel guna2HtmlLabel1;

		private Guna2GroupBox guna2GroupBox4;

		private Guna2HtmlLabel LastAccount;

		private Guna2HtmlLabel guna2HtmlLabel3;

		private Guna2HtmlLabel FailedCount;

		private Guna2HtmlLabel guna2HtmlLabel7;

		private Guna2HtmlLabel SuccessCount;

		private Guna2HtmlLabel guna2HtmlLabel11;

		private Guna2HtmlLabel CountryName;

		private Guna2HtmlLabel guna2HtmlLabel13;

		private Guna2HtmlLabel ThreadsNumber;

		private Guna2HtmlLabel guna2HtmlLabel15;

		public Generate()
		{
			InitializeComponent();
		}

		private void Generate_Load(object sender, EventArgs e)
		{
			if (NewBlizzGen.Properties.Settings.Default.fivesim != "")
			{
				try
				{
					FiveSimBalanceDisplay.Text = class7_0.method_0();
				}
				catch (Exception ex)
				{
					guna2MessageDialog_0.Text = ex.Message;
					guna2MessageDialog_0.Show();
				}
			}
			if (NewBlizzGen.Properties.Settings.Default.smsactivate != "")
			{
				try
				{
					SmsActivateBalance.Text = class7_0.SmsActivateBalance();
				}
				catch (Exception ex2)
				{
					guna2MessageDialog_0.Text = ex2.Message + "This erro";
					guna2MessageDialog_0.Show();
				}
			}
			if (NewBlizzGen.Properties.Settings.Default.anycaptcha != "")
			{
				try
				{
					AnyCaptchaBalance.Text = class7_0.AnyCaptchaBalance();
				}
				catch (Exception ex3)
				{
					guna2MessageDialog_0.Text = ex3.Message;
					guna2MessageDialog_0.Show();
				}
			}
			if (NewBlizzGen.Properties.Settings.Default.twocaptcha != "")
			{
				try
				{
					TwoCaptchaBalance.Text = class7_0.TwoCaptchaBalance().ToString();
				}
				catch (Exception ex4)
				{
					guna2MessageDialog_0.Text = ex4.Message;
					guna2MessageDialog_0.Show();
				}
			}
			if (NewBlizzGen.Properties.Settings.Default.anticaptcha != "")
			{
				try
				{
					AntiCaptchaBalance.Text = class7_0.AntiCaptchaBalance().ToString();
				}
				catch (Exception ex5)
				{
					guna2MessageDialog_0.Text = ex5.Message;
					guna2MessageDialog_0.Show();
				}
			}
			try
			{
				ThreadsNumber.Text = NewBlizzGen.Properties.Settings.Default.threads.ToString();
			}
			catch (Exception ex6)
			{
				guna2MessageDialog_0.Text = ex6.Message;
				guna2MessageDialog_0.Show();
			}
			try
			{
				CountryName.Text = NewBlizzGen.Properties.Settings.Default.country;
			}
			catch (Exception ex7)
			{
				guna2MessageDialog_0.Text = ex7.Message;
				guna2MessageDialog_0.Show();
			}
		}

		private void startBTN_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(method_0);
			list_0.Clear();
			thread.Start();
		}

		private void method_0()
		{
			Invoke((MethodInvoker)delegate
			{
				startBTN.Enabled = false;
			});
			if (NewBlizzGen.Properties.Settings.Default.country == "India")
			{
				country = "india";
				if (NewBlizzGen.Properties.Settings.Default.smsoperator != "")
				{
					smsoperator = NewBlizzGen.Properties.Settings.Default.smsoperator;
				}
			}
			if (NewBlizzGen.Properties.Settings.Default.proxies == 1)
			{
				string path = "proxies.txt";
				proxies = File.ReadLines(path).ToList();
				if (proxies.Count <= 0)
				{
					guna2MessageDialog_0.Text = "There are no proxies in your proxies file";
					guna2MessageDialog_0.Show();
					return;
				}
			}
			for (int i = 0; i < guna2TrackBar1.Value; i++)
			{
				int int_0 = i + 1;
				semaphoreSlim_0.Wait();
				list_0.Add(new Thread((ThreadStart)delegate
				{
					method_1(int_0);
				}));
				list_0[i].Start();
				Thread.Sleep(500);
			}
			while (semaphoreSlim_0.CurrentCount < NewBlizzGen.Properties.Settings.Default.threads)
			{
				Thread.Sleep(5000);
				Console.WriteLine(semaphoreSlim_0.CurrentCount);
				if (semaphoreSlim_0.CurrentCount == NewBlizzGen.Properties.Settings.Default.threads)
				{
					break;
				}
			}
			Invoke((MethodInvoker)delegate
			{
				startBTN.Enabled = true;
			});
		}

		public void KillOpenChromeDrivers()
		{
			Process[] processesByName = Process.GetProcessesByName("chromedriver.exe");
			foreach (Process obj in processesByName)
			{
				obj.Kill();
				obj.WaitForExit();
			}
		}

		private void method_1(int int_0)
		{
			_ = NewBlizzGen.Properties.Settings.Default.anticaptcha;
			ChromeOptions chromeOptions = new ChromeOptions();
			chromeOptions.AddArgument("--no-sandbox");
			chromeOptions.AddArgument("--window-size=400,600");
			chromeOptions.AddExcludedArguments(new List<string> { "enable-automation" });
			ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
			chromeDriverService.HideCommandPromptWindow = true;
			if (NewBlizzGen.Properties.Settings.Default.proxies == 1)
			{
				string text = proxies[int_0].Replace("/n", "");
				chromeOptions.AddArgument("--proxy-server=" + text);
				setStatus(int_0, "Proxy Set... " + text);
			}
			if (NewBlizzGen.Properties.Settings.Default.invisible == 1)
			{
				chromeOptions.AddArgument("--headless");
			}
			IWebDriver webDriver = new ChromeDriver(chromeDriverService, chromeOptions, TimeSpan.FromMinutes(3.0));
			IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)webDriver;
			webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30.0);
			Stopwatch stopwatch = Stopwatch.StartNew();
			stopwatch.Start();
			try
			{
				webDriver.Url = "https://account.battle.net/creation/flow/creation-full";
				setStatus(int_0, "Starting Task...");
			}
			catch (Exception ex)
			{
				setStatus(int_0, ex.Message);
				webDriver.Quit();
				UpdateFailed();
				semaphoreSlim_0.Release();
				return;
			}
			try
			{
				SelectElement selectElement = new SelectElement(webDriver.FindElement(By.Id("capture-country")));
				if (country == "india")
				{
					selectElement.SelectByText("India");
					setStatus(int_0, "Country Selected as India...");
				}
			}
			catch (Exception ex2)
			{
				setStatus(int_0, ex2.Message);
				webDriver.Quit();
				UpdateFailed();
				semaphoreSlim_0.Release();
				return;
			}
			Random random = new Random();
			try
			{
				Thread.Sleep(1500);
				IWebElement webElement = webDriver.FindElement(By.Id("dob-field-inactive"));
				javaScriptExecutor.ExecuteScript("arguments[0].setAttribute('class','step__field--date step__form__block phantom')", webElement);
				IWebElement webElement2 = webDriver.FindElement(By.Id("dob-field-active"));
				javaScriptExecutor.ExecuteScript("arguments[0].setAttribute('class','step__field step__form__block')", webElement2);
				Thread.Sleep(500);
				webDriver.FindElement(By.XPath("//*[@class='step__input--date--mm']")).SendKeys(random.Next(1, 12).ToString());
				Thread.Sleep(500);
				webDriver.FindElement(By.XPath("//*[@class='step__input--date--dd']")).SendKeys(random.Next(1, 28).ToString());
				Thread.Sleep(500);
				webDriver.FindElement(By.XPath("//*[@class='step__input--date--yyyy']")).SendKeys(random.Next(1972, 2001).ToString());
				Thread.Sleep(500);
				webDriver.FindElement(By.XPath("//*[@id='flow-form-submit-btn']")).Click();
				setStatus(int_0, "Entered Random DOB...");
			}
			catch (Exception ex3)
			{
				setStatus(int_0, ex3.Message);
				webDriver.Quit();
				UpdateFailed();
				semaphoreSlim_0.Release();
				return;
			}
			try
			{
				setStatus(int_0, "Sending to AnyCaptcha to Solve Captcha...");
				AnyCaptchaResult anyCaptchaResult = new AnyCaptcha().FunCaptchaProxyless(NewBlizzGen.Properties.Settings.Default.anycaptcha, "E8A75615-1CBA-5DFF-8032-D16BCF234E10", "https://blizzard-api.arkoselabs.com/v2/E8A75615-1CBA-5DFF-8032-D16BCF234E10/enforcement.8b144c4f9762e265309b45a275be4e56.html");
				UpdateAnyCaptchaBalance();
				if (!anyCaptchaResult.IsSuccess)
				{
					setStatus(int_0, anyCaptchaResult.Message);
					webDriver.Quit();
					UpdateFailed();
					semaphoreSlim_0.Release();
					return;
				}
				setStatus(int_0, "Got a Response...");
				try
				{
					IWebElement webElement3 = webDriver.FindElement(By.XPath("//*[@id='capture-arkose']"));
					javaScriptExecutor.ExecuteScript("var elem = arguments[0]; var value = arguments[1]; elem.value = value;", webElement3, anyCaptchaResult.Result);
					javaScriptExecutor.ExecuteScript("document.querySelector('#flow-form-submit-btn').disabled=false");
					javaScriptExecutor.ExecuteScript("document.querySelector('form').submit()");
				}
				catch
				{
					Console.WriteLine("Error solving captcha");
					webDriver.Quit();
					semaphoreSlim_0.Release();
				}
			}
			catch
			{
				UpdateFailed();
				webDriver.Quit();
				semaphoreSlim_0.Release();
			}
			string text2 = Faker.Name.First();
			string text3 = Faker.Name.Last();
			try
			{
				webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100000.0);
				webDriver.FindElement(By.Id("capture-first-name")).SendKeys(text2);
				Thread.Sleep(300);
				webDriver.FindElement(By.Id("capture-last-name")).SendKeys(text3);
				javaScriptExecutor.ExecuteScript("document.querySelector('form').submit()");
				setStatus(int_0, "Entered Random Name... " + text2 + " " + text3);
			}
			catch (Exception ex4)
			{
				setStatus(int_0, ex4.Message);
				webDriver.Quit();
				UpdateFailed();
				semaphoreSlim_0.Release();
				return;
			}
			string text4 = "";
			try
			{
				webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30000.0);
				string emaildomain = NewBlizzGen.Properties.Settings.Default.emaildomain;
				text4 = text2 + text3 + random.Next(12134, 993242) + "@" + emaildomain;
				webDriver.FindElement(By.Id("capture-email")).SendKeys(text4.ToLower());
				setStatus(int_0, "Entered Random Email... " + text4.ToLower());
			}
			catch (Exception ex5)
			{
				setStatus(int_0, ex5.Message);
				webDriver.Quit();
				UpdateFailed();
				semaphoreSlim_0.Release();
				return;
			}
			string text5 = string.Empty;
			try
			{
				Api api = new Api(NewBlizzGen.Properties.Settings.Default.fivesim);
				Number number = api.buyActivationNumber("blizzard", country, smsoperator);
				UpdateFiveSimBalance();
				webDriver.FindElement(By.Id("capture-phone-number")).SendKeys(number.phone.ToString());
				javaScriptExecutor.ExecuteScript("document.querySelector('form').submit()");
				Thread.Sleep(3000);
				setStatus(int_0, "Got An Indian Phone Number...");
				if (webDriver.PageSource.Contains("Something went wrong"))
				{
					setStatus(int_0, "IP is temporarily banned. Use a VPN");
					webDriver.Quit();
					UpdateFailed();
					semaphoreSlim_0.Release();
					return;
				}
				if (webDriver.PageSource.Contains("Phone number is already in use"))
				{
					webDriver.FindElement(By.Id("capture-phone-number")).Clear();
					number = api.buyActivationNumber("blizzard", country, smsoperator);
					UpdateFiveSimBalance();
					webDriver.FindElement(By.Id("capture-phone-number")).SendKeys(number.phone.ToString());
					javaScriptExecutor.ExecuteScript("document.querySelector('form').submit()");
				}
				Number number2 = api.checkNumber(number.id);
				int num = 1;
				while (number2.status != "FINISHED")
				{
					Thread.Sleep(2000);
					num++;
					number2 = api.checkNumber(number.id);
					foreach (Sms sm in number2.sms)
					{
						text5 = sm.code;
					}
					if (text5 != "")
					{
						break;
					}
					if (num == 30)
					{
						webDriver.FindElement(By.Id("resend-sms-verification")).Click();
					}
					if (num == 60)
					{
						setStatus(int_0, "Waited A Few Minutes - No SMS Code...");
						webDriver.Quit();
						semaphoreSlim_0.Release();
						return;
					}
				}
				if (text5 == "")
				{
					UpdateFailed();
					webDriver.Quit();
					semaphoreSlim_0.Release();
					return;
				}
				setStatus(int_0, "Got SMS Code... " + text5.ToString());
			}
			catch (Exception ex6)
			{
				setStatus(int_0, ex6.Message);
				UpdateFailed();
				webDriver.Quit();
				semaphoreSlim_0.Release();
				return;
			}
			try
			{
				text5.ToList();
				Console.WriteLine(text5[0].ToString());
				webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60000.0);
				webDriver.FindElement(By.Id("field-0")).SendKeys(text5[0].ToString());
				webDriver.FindElement(By.Id("field-1")).SendKeys(text5[1].ToString());
				webDriver.FindElement(By.Id("field-2")).SendKeys(text5[2].ToString());
				webDriver.FindElement(By.Id("field-3")).SendKeys(text5[3].ToString());
				webDriver.FindElement(By.Id("field-4")).SendKeys(text5[4].ToString());
				webDriver.FindElement(By.Id("field-5")).SendKeys(text5[5].ToString());
				Thread.Sleep(2000);
				javaScriptExecutor.ExecuteScript("document.querySelector('form').submit()");
			}
			catch (Exception ex7)
			{
				setStatus(int_0, ex7.Message);
				webDriver.Quit();
				UpdateFailed();
				semaphoreSlim_0.Release();
				return;
			}
			try
			{
				IWebElement webElement4 = webDriver.FindElement(By.CssSelector("#legal-checkboxes label input"));
				javaScriptExecutor.ExecuteScript("arguments[0].click();", webElement4);
				Thread.Sleep(1000);
				javaScriptExecutor.ExecuteScript("document.querySelector('form').submit()");
				setStatus(int_0, "Checked Terms & Condition Box...");
			}
			catch (Exception ex8)
			{
				setStatus(int_0, ex8.Message);
				webDriver.Quit();
				UpdateFailed();
				semaphoreSlim_0.Release();
				return;
			}
			string text6 = NewBlizzGen.Properties.Settings.Default.password;
			try
			{
				if (text6 == "")
				{
					text6 = CreatePassword(12);
				}
				webDriver.FindElement(By.Id("capture-password")).SendKeys(text6);
				Thread.Sleep(1000);
				javaScriptExecutor.ExecuteScript("document.querySelector('form').submit()");
				setStatus(int_0, "Entered Password... " + text6);
			}
			catch (Exception ex9)
			{
				setStatus(int_0, ex9.Message);
				webDriver.Quit();
				UpdateFailed();
				semaphoreSlim_0.Release();
				return;
			}
			string text7 = NewBlizzGen.Properties.Settings.Default.gamertag;
			try
			{
				if (!(text7 == ""))
				{
					webDriver.FindElement(By.Id("capture-battletag")).Clear();
					Thread.Sleep(1000);
					webDriver.FindElement(By.Id("capture-battletag")).SendKeys(NewBlizzGen.Properties.Settings.Default.gamertag);
				}
				else
				{
					webDriver.FindElement(By.Id("capture-battletag")).Click();
					Thread.Sleep(700);
					webDriver.FindElement(By.Id("capture-battletag")).Click();
					Thread.Sleep(700);
					text7 = webDriver.FindElement(By.Id("capture-battletag")).GetAttribute("value");
				}
				Thread.Sleep(800);
				javaScriptExecutor.ExecuteScript("document.querySelector('form').submit()");
				setStatus(int_0, "Gamer Tag Set... " + text7);
			}
			catch (Exception ex10)
			{
				setStatus(int_0, ex10.Message);
				webDriver.Quit();
				UpdateFailed();
				semaphoreSlim_0.Release();
				return;
			}
			try
			{
				webDriver.FindElement(By.PartialLinkText("Account")).Click();
			}
			catch (Exception ex11)
			{
				setStatus(int_0, ex11.Message);
				webDriver.Quit();
				UpdateFailed();
				semaphoreSlim_0.Release();
				return;
			}
			try
			{
				Thread.Sleep(5000);
				webDriver.SwitchTo().Window(webDriver.WindowHandles[1]);
			}
			catch (Exception ex12)
			{
				setStatus(int_0, ex12.Message);
				webDriver.Quit();
				UpdateFailed();
				semaphoreSlim_0.Release();
				return;
			}
			try
			{
				Thread.Sleep(2000);
				webDriver.Navigate().GoToUrl("https://account.battle.net/security");
			}
			catch (Exception ex13)
			{
				setStatus(int_0, ex13.Message);
				webDriver.Quit();
				UpdateFailed();
				semaphoreSlim_0.Release();
				return;
			}
			string text8 = NewBlizzGen.Properties.Settings.Default.secretans;
			try
			{
				Thread.Sleep(1000);
				webDriver.FindElement(By.PartialLinkText("Select a Secret Question")).Click();
				Thread.Sleep(1000);
				new SelectElement(webDriver.FindElement(By.XPath("//*[@id='question-select']"))).SelectByText("What was the first car you owned?");
				Thread.Sleep(1000);
				if (text8 == "")
				{
					text8 = "Tesla";
				}
				webDriver.FindElement(By.Id("answer")).SendKeys(text8);
				Thread.Sleep(1000);
				webDriver.FindElement(By.Id("sqa-submit")).Click();
				Thread.Sleep(1000);
				setStatus(int_0, "Setting Answer to Security Question... " + text8);
			}
			catch (Exception ex14)
			{
				setStatus(int_0, ex14.Message);
				webDriver.Quit();
				UpdateFailed();
				semaphoreSlim_0.Release();
				return;
			}
			string text9 = "";
			if (NewBlizzGen.Properties.Settings.Default.savefile)
			{
				text9 = "Created with BlizzGen 2.0 - " + text4 + ":" + text6 + "  [Secret Ans: " + text8 + "] [Gamer Tag: " + text7 + "]";
				File.AppendAllText("Accounts.txt", text9 + Environment.NewLine);
				setStatus(int_0, "Account Saved To File...");
				stopwatch.Stop();
				UpdateSucess(stopwatch.Elapsed.ToString("m\\:ss"));
			}
			string string_0 = text4 + ":" + text6 + "  [Secret Ans: " + text8 + "] [Gamer Tag: " + text7 + "]";
			Invoke((MethodInvoker)delegate
			{
				guna2TextBox_1.AppendText(string_0 + Environment.NewLine);
			});
			setStatus(int_0, "Account Created Successfully!");
			webDriver.Quit();
			semaphoreSlim_0.Release();
		}

		public void UpdateSucess(string time)
		{
			_success++;
			NewBlizzGen.Properties.Settings.Default.success = NewBlizzGen.Properties.Settings.Default.success + 1;
			NewBlizzGen.Properties.Settings.Default.Save();
			Invoke((MethodInvoker)delegate
			{
				SuccessCount.Text = _success.ToString();
				LastAccount.Text = time;
				new Form1().SuccessRecord.Text = NewBlizzGen.Properties.Settings.Default.success.ToString();
			});
		}

		public void UpdateFailed()
		{
			_failed++;
			NewBlizzGen.Properties.Settings.Default.failed = NewBlizzGen.Properties.Settings.Default.failed + 1;
			NewBlizzGen.Properties.Settings.Default.Save();
			Invoke((MethodInvoker)delegate
			{
				FailedCount.Text = _failed.ToString();
				new Form1().FailedRecord.Text = NewBlizzGen.Properties.Settings.Default.failed.ToString();
			});
		}

		public void UpdateAnyCaptchaBalance()
		{
			Invoke((MethodInvoker)delegate
			{
				AnyCaptchaBalance.Text = class7_0.AnyCaptchaBalance();
			});
		}

		public void UpdateFiveSimBalance()
		{
			Invoke((MethodInvoker)delegate
			{
				FiveSimBalanceDisplay.Text = class7_0.method_0();
			});
		}

		public string CreatePassword(int length)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			while (0 < length--)
			{
				stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*$@!"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*$@!".Length)]);
			}
			return stringBuilder.ToString();
		}

		public void setStatus(int int_0, string value)
		{
			Invoke((MethodInvoker)delegate
			{
				guna2TextBox_0.AppendText(DateTime.Now.ToString("[MM-dd-yyyy HH:mm:ss]") + " Account " + int_0 + " - " + value + Environment.NewLine);
			});
		}

		private void resetBTN_Click(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("chromedriver.exe");
			foreach (Process obj in processesByName)
			{
				obj.Kill();
				obj.WaitForExit();
				obj.Dispose();
			}
		}

		private void fkcoandfg(object sender, ScrollEventArgs e)
		{
			guna2NotificationPaint_0.Text = guna2TrackBar1.Value.ToString();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			icontainer_0 = new System.ComponentModel.Container();
			startBTN = new Guna.UI2.WinForms.Guna2Button();
			guna2TextBox_0 = new Guna.UI2.WinForms.Guna2TextBox();
			guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			zHcsrajlRn = new Guna.UI2.WinForms.Guna2GroupBox();
			guna2TextBox_1 = new Guna.UI2.WinForms.Guna2TextBox();
			guna2MessageDialog_0 = new Guna.UI2.WinForms.Guna2MessageDialog();
			resetBTN = new Guna.UI2.WinForms.Guna2Button();
			guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
			guna2NotificationPaint_0 = new Guna.UI2.WinForms.Guna2NotificationPaint(icontainer_0);
			guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
			AnyCaptchaBalance = new Guna.UI2.WinForms.Guna2HtmlLabel();
			guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			AntiCaptchaBalance = new Guna.UI2.WinForms.Guna2HtmlLabel();
			guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			TwoCaptchaBalance = new Guna.UI2.WinForms.Guna2HtmlLabel();
			guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			SmsActivateBalance = new Guna.UI2.WinForms.Guna2HtmlLabel();
			guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			FiveSimBalanceDisplay = new Guna.UI2.WinForms.Guna2HtmlLabel();
			guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
			LastAccount = new Guna.UI2.WinForms.Guna2HtmlLabel();
			guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			FailedCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
			guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			SuccessCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
			guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			CountryName = new Guna.UI2.WinForms.Guna2HtmlLabel();
			guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			ThreadsNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
			guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			guna2GroupBox1.SuspendLayout();
			zHcsrajlRn.SuspendLayout();
			guna2GroupBox3.SuspendLayout();
			guna2GroupBox4.SuspendLayout();
			SuspendLayout();
			startBTN.CheckedState.Parent = startBTN;
			startBTN.CustomImages.Parent = startBTN;
			startBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			startBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			startBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			startBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			startBTN.DisabledState.Parent = startBTN;
			startBTN.FillColor = System.Drawing.Color.FromArgb(22, 33, 62);
			startBTN.Font = new System.Drawing.Font("Segoe UI", 9f);
			startBTN.ForeColor = System.Drawing.Color.White;
			startBTN.HoverState.Parent = startBTN;
			startBTN.Location = new System.Drawing.Point(298, 513);
			startBTN.Name = "startBTN";
			startBTN.ShadowDecoration.Parent = startBTN;
			startBTN.Size = new System.Drawing.Size(180, 45);
			startBTN.TabIndex = 0;
			startBTN.Text = "Start";
			startBTN.Click += new System.EventHandler(startBTN_Click);
			guna2TextBox_0.BackColor = System.Drawing.Color.FromArgb(15, 52, 96);
			guna2TextBox_0.BorderColor = System.Drawing.Color.FromArgb(15, 52, 96);
			guna2TextBox_0.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			guna2TextBox_0.BorderThickness = 2;
			guna2TextBox_0.Cursor = System.Windows.Forms.Cursors.IBeam;
			guna2TextBox_0.DefaultText = "";
			guna2TextBox_0.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			guna2TextBox_0.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			guna2TextBox_0.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			guna2TextBox_0.DisabledState.Parent = guna2TextBox_0;
			guna2TextBox_0.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			guna2TextBox_0.FillColor = System.Drawing.Color.FromArgb(15, 52, 96);
			guna2TextBox_0.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			guna2TextBox_0.FocusedState.Parent = guna2TextBox_0;
			guna2TextBox_0.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			guna2TextBox_0.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
			guna2TextBox_0.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			guna2TextBox_0.HoverState.Parent = guna2TextBox_0;
			guna2TextBox_0.Location = new System.Drawing.Point(6, 45);
			guna2TextBox_0.Multiline = true;
			guna2TextBox_0.Name = "messageTXT";
			guna2TextBox_0.PasswordChar = '\0';
			guna2TextBox_0.PlaceholderText = "";
			guna2TextBox_0.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			guna2TextBox_0.SelectedText = "";
			guna2TextBox_0.ShadowDecoration.Parent = guna2TextBox_0;
			guna2TextBox_0.Size = new System.Drawing.Size(940, 148);
			guna2TextBox_0.TabIndex = 0;
			guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox1.BorderRadius = 2;
			guna2GroupBox1.BorderThickness = 2;
			guna2GroupBox1.Controls.Add(guna2TextBox_0);
			guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox1.FillColor = System.Drawing.Color.Black;
			guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox1.Location = new System.Drawing.Point(3, 308);
			guna2GroupBox1.Name = "guna2GroupBox1";
			guna2GroupBox1.ShadowDecoration.Parent = guna2GroupBox1;
			guna2GroupBox1.Size = new System.Drawing.Size(952, 200);
			guna2GroupBox1.TabIndex = 1;
			guna2GroupBox1.Text = "Logs:";
			zHcsrajlRn.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			zHcsrajlRn.BorderRadius = 2;
			zHcsrajlRn.BorderThickness = 2;
			zHcsrajlRn.Controls.Add(guna2TextBox_1);
			zHcsrajlRn.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			zHcsrajlRn.FillColor = System.Drawing.Color.Black;
			zHcsrajlRn.Font = new System.Drawing.Font("Segoe UI", 9f);
			zHcsrajlRn.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			zHcsrajlRn.Location = new System.Drawing.Point(3, 154);
			zHcsrajlRn.Name = "guna2GroupBox2";
			zHcsrajlRn.ShadowDecoration.Parent = zHcsrajlRn;
			zHcsrajlRn.Size = new System.Drawing.Size(952, 152);
			zHcsrajlRn.TabIndex = 2;
			zHcsrajlRn.Text = "Accounts:";
			guna2TextBox_1.BackColor = System.Drawing.Color.FromArgb(15, 52, 96);
			guna2TextBox_1.BorderColor = System.Drawing.Color.FromArgb(15, 52, 96);
			guna2TextBox_1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			guna2TextBox_1.BorderThickness = 2;
			guna2TextBox_1.Cursor = System.Windows.Forms.Cursors.IBeam;
			guna2TextBox_1.DefaultText = "";
			guna2TextBox_1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			guna2TextBox_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			guna2TextBox_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			guna2TextBox_1.DisabledState.Parent = guna2TextBox_1;
			guna2TextBox_1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			guna2TextBox_1.FillColor = System.Drawing.Color.FromArgb(15, 52, 96);
			guna2TextBox_1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			guna2TextBox_1.FocusedState.Parent = guna2TextBox_1;
			guna2TextBox_1.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			guna2TextBox_1.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
			guna2TextBox_1.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			guna2TextBox_1.HoverState.Parent = guna2TextBox_1;
			guna2TextBox_1.Location = new System.Drawing.Point(6, 45);
			guna2TextBox_1.Multiline = true;
			guna2TextBox_1.Name = "accountsTXT";
			guna2TextBox_1.PasswordChar = '\0';
			guna2TextBox_1.PlaceholderText = "";
			guna2TextBox_1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			guna2TextBox_1.SelectedText = "";
			guna2TextBox_1.ShadowDecoration.Parent = guna2TextBox_1;
			guna2TextBox_1.Size = new System.Drawing.Size(940, 100);
			guna2TextBox_1.TabIndex = 0;
			guna2MessageDialog_0.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
			guna2MessageDialog_0.Caption = null;
			guna2MessageDialog_0.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
			guna2MessageDialog_0.Parent = null;
			guna2MessageDialog_0.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
			guna2MessageDialog_0.Text = null;
			resetBTN.CheckedState.Parent = resetBTN;
			resetBTN.CustomImages.Parent = resetBTN;
			resetBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			resetBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			resetBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			resetBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			resetBTN.DisabledState.Parent = resetBTN;
			resetBTN.FillColor = System.Drawing.Color.FromArgb(22, 33, 62);
			resetBTN.Font = new System.Drawing.Font("Segoe UI", 9f);
			resetBTN.ForeColor = System.Drawing.Color.White;
			resetBTN.HoverState.Parent = resetBTN;
			resetBTN.Location = new System.Drawing.Point(484, 513);
			resetBTN.Name = "resetBTN";
			resetBTN.ShadowDecoration.Parent = resetBTN;
			resetBTN.Size = new System.Drawing.Size(180, 45);
			resetBTN.TabIndex = 3;
			resetBTN.Text = "Reset";
			resetBTN.Click += new System.EventHandler(resetBTN_Click);
			guna2TrackBar1.HoverState.Parent = guna2TrackBar1;
			guna2TrackBar1.Location = new System.Drawing.Point(9, 126);
			guna2TrackBar1.Maximum = 250;
			guna2TrackBar1.Minimum = 1;
			guna2TrackBar1.Name = "guna2TrackBar1";
			guna2TrackBar1.Size = new System.Drawing.Size(908, 23);
			guna2TrackBar1.TabIndex = 4;
			guna2TrackBar1.ThumbColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2TrackBar1.Value = 20;
			guna2TrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(fkcoandfg);
			guna2NotificationPaint_0.FillColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2NotificationPaint_0.Location = new System.Drawing.Point(922, 127);
			guna2NotificationPaint_0.Size = new System.Drawing.Size(30, 20);
			guna2NotificationPaint_0.TargetControl = this;
			guna2NotificationPaint_0.Text = "20";
			guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox3.BorderRadius = 2;
			guna2GroupBox3.BorderThickness = 2;
			guna2GroupBox3.Controls.Add(AnyCaptchaBalance);
			guna2GroupBox3.Controls.Add(guna2HtmlLabel10);
			guna2GroupBox3.Controls.Add(AntiCaptchaBalance);
			guna2GroupBox3.Controls.Add(guna2HtmlLabel6);
			guna2GroupBox3.Controls.Add(TwoCaptchaBalance);
			guna2GroupBox3.Controls.Add(guna2HtmlLabel8);
			guna2GroupBox3.Controls.Add(SmsActivateBalance);
			guna2GroupBox3.Controls.Add(guna2HtmlLabel4);
			guna2GroupBox3.Controls.Add(FiveSimBalanceDisplay);
			guna2GroupBox3.Controls.Add(guna2HtmlLabel1);
			guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox3.FillColor = System.Drawing.Color.Black;
			guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox3.Location = new System.Drawing.Point(3, 6);
			guna2GroupBox3.Name = "guna2GroupBox3";
			guna2GroupBox3.ShadowDecoration.Parent = guna2GroupBox3;
			guna2GroupBox3.Size = new System.Drawing.Size(475, 117);
			guna2GroupBox3.TabIndex = 3;
			guna2GroupBox3.Text = "Balances:";
			AnyCaptchaBalance.BackColor = System.Drawing.Color.Transparent;
			AnyCaptchaBalance.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			AnyCaptchaBalance.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
			AnyCaptchaBalance.Location = new System.Drawing.Point(323, 91);
			AnyCaptchaBalance.Name = "AnyCaptchaBalance";
			AnyCaptchaBalance.Size = new System.Drawing.Size(25, 17);
			AnyCaptchaBalance.TabIndex = 9;
			AnyCaptchaBalance.Text = "N/A";
			AnyCaptchaBalance.TextAlignment = System.Drawing.ContentAlignment.TopRight;
			guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
			guna2HtmlLabel10.Location = new System.Drawing.Point(201, 91);
			guna2HtmlLabel10.Name = "guna2HtmlLabel10";
			guna2HtmlLabel10.Size = new System.Drawing.Size(84, 15);
			guna2HtmlLabel10.TabIndex = 8;
			guna2HtmlLabel10.Text = "AnyCaptcha.com";
			AntiCaptchaBalance.BackColor = System.Drawing.Color.Transparent;
			AntiCaptchaBalance.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			AntiCaptchaBalance.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
			AntiCaptchaBalance.Location = new System.Drawing.Point(323, 68);
			AntiCaptchaBalance.Name = "AntiCaptchaBalance";
			AntiCaptchaBalance.Size = new System.Drawing.Size(25, 17);
			AntiCaptchaBalance.TabIndex = 7;
			AntiCaptchaBalance.Text = "N/A";
			AntiCaptchaBalance.TextAlignment = System.Drawing.ContentAlignment.TopRight;
			guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
			guna2HtmlLabel6.Location = new System.Drawing.Point(201, 68);
			guna2HtmlLabel6.Name = "guna2HtmlLabel6";
			guna2HtmlLabel6.Size = new System.Drawing.Size(87, 15);
			guna2HtmlLabel6.TabIndex = 6;
			guna2HtmlLabel6.Text = "Anti-Captcha.com";
			TwoCaptchaBalance.BackColor = System.Drawing.Color.Transparent;
			TwoCaptchaBalance.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			TwoCaptchaBalance.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
			TwoCaptchaBalance.Location = new System.Drawing.Point(323, 45);
			TwoCaptchaBalance.Name = "TwoCaptchaBalance";
			TwoCaptchaBalance.Size = new System.Drawing.Size(25, 17);
			TwoCaptchaBalance.TabIndex = 5;
			TwoCaptchaBalance.Text = "N/A";
			TwoCaptchaBalance.TextAlignment = System.Drawing.ContentAlignment.TopRight;
			guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
			guna2HtmlLabel8.Location = new System.Drawing.Point(201, 45);
			guna2HtmlLabel8.Name = "guna2HtmlLabel8";
			guna2HtmlLabel8.Size = new System.Drawing.Size(72, 15);
			guna2HtmlLabel8.TabIndex = 4;
			guna2HtmlLabel8.Text = "2Captcha.com";
			SmsActivateBalance.BackColor = System.Drawing.Color.Transparent;
			SmsActivateBalance.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			SmsActivateBalance.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
			SmsActivateBalance.Location = new System.Drawing.Point(109, 68);
			SmsActivateBalance.Name = "SmsActivateBalance";
			SmsActivateBalance.Size = new System.Drawing.Size(25, 17);
			SmsActivateBalance.TabIndex = 3;
			SmsActivateBalance.Text = "N/A";
			SmsActivateBalance.TextAlignment = System.Drawing.ContentAlignment.TopRight;
			guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
			guna2HtmlLabel4.Location = new System.Drawing.Point(6, 68);
			guna2HtmlLabel4.Name = "guna2HtmlLabel4";
			guna2HtmlLabel4.Size = new System.Drawing.Size(80, 15);
			guna2HtmlLabel4.TabIndex = 2;
			guna2HtmlLabel4.Text = "SMS-Activate.ru";
			FiveSimBalanceDisplay.BackColor = System.Drawing.Color.Transparent;
			FiveSimBalanceDisplay.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			FiveSimBalanceDisplay.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
			FiveSimBalanceDisplay.Location = new System.Drawing.Point(109, 45);
			FiveSimBalanceDisplay.Name = "FiveSimBalanceDisplay";
			FiveSimBalanceDisplay.Size = new System.Drawing.Size(25, 17);
			FiveSimBalanceDisplay.TabIndex = 1;
			FiveSimBalanceDisplay.Text = "N/A";
			FiveSimBalanceDisplay.TextAlignment = System.Drawing.ContentAlignment.TopRight;
			guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			guna2HtmlLabel1.Location = new System.Drawing.Point(6, 45);
			guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			guna2HtmlLabel1.Size = new System.Drawing.Size(49, 17);
			guna2HtmlLabel1.TabIndex = 0;
			guna2HtmlLabel1.Text = "5Sim.net";
			guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox4.BorderRadius = 2;
			guna2GroupBox4.BorderThickness = 2;
			guna2GroupBox4.Controls.Add(LastAccount);
			guna2GroupBox4.Controls.Add(guna2HtmlLabel3);
			guna2GroupBox4.Controls.Add(FailedCount);
			guna2GroupBox4.Controls.Add(guna2HtmlLabel7);
			guna2GroupBox4.Controls.Add(SuccessCount);
			guna2GroupBox4.Controls.Add(guna2HtmlLabel11);
			guna2GroupBox4.Controls.Add(CountryName);
			guna2GroupBox4.Controls.Add(guna2HtmlLabel13);
			guna2GroupBox4.Controls.Add(ThreadsNumber);
			guna2GroupBox4.Controls.Add(guna2HtmlLabel15);
			guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox4.FillColor = System.Drawing.Color.Black;
			guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox4.Location = new System.Drawing.Point(480, 6);
			guna2GroupBox4.Name = "guna2GroupBox4";
			guna2GroupBox4.ShadowDecoration.Parent = guna2GroupBox4;
			guna2GroupBox4.Size = new System.Drawing.Size(475, 117);
			guna2GroupBox4.TabIndex = 10;
			guna2GroupBox4.Text = "Stats:";
			LastAccount.BackColor = System.Drawing.Color.Transparent;
			LastAccount.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			LastAccount.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
			LastAccount.Location = new System.Drawing.Point(252, 91);
			LastAccount.Name = "LastAccount";
			LastAccount.Size = new System.Drawing.Size(25, 17);
			LastAccount.TabIndex = 9;
			LastAccount.Text = "N/A";
			LastAccount.TextAlignment = System.Drawing.ContentAlignment.TopRight;
			guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
			guna2HtmlLabel3.Location = new System.Drawing.Point(164, 91);
			guna2HtmlLabel3.Name = "guna2HtmlLabel3";
			guna2HtmlLabel3.Size = new System.Drawing.Size(72, 17);
			guna2HtmlLabel3.TabIndex = 8;
			guna2HtmlLabel3.Text = "Last Account";
			FailedCount.BackColor = System.Drawing.Color.Transparent;
			FailedCount.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			FailedCount.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
			FailedCount.Location = new System.Drawing.Point(252, 68);
			FailedCount.Name = "FailedCount";
			FailedCount.Size = new System.Drawing.Size(10, 17);
			FailedCount.TabIndex = 7;
			FailedCount.Text = "0";
			FailedCount.TextAlignment = System.Drawing.ContentAlignment.TopRight;
			guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
			guna2HtmlLabel7.Location = new System.Drawing.Point(164, 68);
			guna2HtmlLabel7.Name = "guna2HtmlLabel7";
			guna2HtmlLabel7.Size = new System.Drawing.Size(34, 17);
			guna2HtmlLabel7.TabIndex = 6;
			guna2HtmlLabel7.Text = "Failed";
			SuccessCount.BackColor = System.Drawing.Color.Transparent;
			SuccessCount.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			SuccessCount.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
			SuccessCount.Location = new System.Drawing.Point(252, 45);
			SuccessCount.Name = "SuccessCount";
			SuccessCount.Size = new System.Drawing.Size(10, 17);
			SuccessCount.TabIndex = 5;
			SuccessCount.Text = "0";
			SuccessCount.TextAlignment = System.Drawing.ContentAlignment.TopRight;
			guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
			guna2HtmlLabel11.Location = new System.Drawing.Point(164, 45);
			guna2HtmlLabel11.Name = "guna2HtmlLabel11";
			guna2HtmlLabel11.Size = new System.Drawing.Size(44, 17);
			guna2HtmlLabel11.TabIndex = 4;
			guna2HtmlLabel11.Text = "Success";
			CountryName.BackColor = System.Drawing.Color.Transparent;
			CountryName.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			CountryName.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
			CountryName.Location = new System.Drawing.Point(75, 68);
			CountryName.Name = "CountryName";
			CountryName.Size = new System.Drawing.Size(25, 17);
			CountryName.TabIndex = 3;
			CountryName.Text = "N/A";
			CountryName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
			guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
			guna2HtmlLabel13.Location = new System.Drawing.Point(6, 68);
			guna2HtmlLabel13.Name = "guna2HtmlLabel13";
			guna2HtmlLabel13.Size = new System.Drawing.Size(46, 17);
			guna2HtmlLabel13.TabIndex = 2;
			guna2HtmlLabel13.Text = "Country";
			ThreadsNumber.BackColor = System.Drawing.Color.Transparent;
			ThreadsNumber.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			ThreadsNumber.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
			ThreadsNumber.Location = new System.Drawing.Point(75, 45);
			ThreadsNumber.Name = "ThreadsNumber";
			ThreadsNumber.Size = new System.Drawing.Size(25, 17);
			ThreadsNumber.TabIndex = 1;
			ThreadsNumber.Text = "N/A";
			ThreadsNumber.TextAlignment = System.Drawing.ContentAlignment.TopRight;
			guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
			guna2HtmlLabel15.Location = new System.Drawing.Point(6, 45);
			guna2HtmlLabel15.Name = "guna2HtmlLabel15";
			guna2HtmlLabel15.Size = new System.Drawing.Size(44, 17);
			guna2HtmlLabel15.TabIndex = 0;
			guna2HtmlLabel15.Text = "Threads";
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			BackColor = System.Drawing.Color.FromArgb(15, 52, 96);
			base.Controls.Add(guna2GroupBox4);
			base.Controls.Add(guna2GroupBox3);
			base.Controls.Add(guna2TrackBar1);
			base.Controls.Add(resetBTN);
			base.Controls.Add(zHcsrajlRn);
			base.Controls.Add(guna2GroupBox1);
			base.Controls.Add(startBTN);
			base.Name = "Generate";
			base.Size = new System.Drawing.Size(958, 592);
			base.Load += new System.EventHandler(Generate_Load);
			guna2GroupBox1.ResumeLayout(false);
			zHcsrajlRn.ResumeLayout(false);
			guna2GroupBox3.ResumeLayout(false);
			guna2GroupBox3.PerformLayout();
			guna2GroupBox4.ResumeLayout(false);
			guna2GroupBox4.PerformLayout();
			ResumeLayout(false);
		}

		static Generate()
		{
			semaphoreSlim_0 = new SemaphoreSlim(NewBlizzGen.Properties.Settings.Default.threads);
		}

		[CompilerGenerated]
		private void method_2()
		{
			startBTN.Enabled = false;
		}

		[CompilerGenerated]
		private void method_3()
		{
			startBTN.Enabled = true;
		}

		[CompilerGenerated]
		private void jVkswCpci7()
		{
			FailedCount.Text = _failed.ToString();
			new Form1().FailedRecord.Text = NewBlizzGen.Properties.Settings.Default.failed.ToString();
		}

		[CompilerGenerated]
		private void method_4()
		{
			AnyCaptchaBalance.Text = class7_0.AnyCaptchaBalance();
		}

		[CompilerGenerated]
		private void method_5()
		{
			FiveSimBalanceDisplay.Text = class7_0.method_0();
		}
	}
}
