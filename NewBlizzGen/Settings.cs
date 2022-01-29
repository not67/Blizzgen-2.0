using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using NewBlizzGen.Properties;

namespace NewBlizzGen
{
	public class Settings : UserControl
	{
		private IContainer icontainer_0;

		private Guna2GroupBox guna2GroupBox1;

		private Guna2TextBox licenceTxt;

		private Guna2GroupBox guna2GroupBox2;

		private Guna2RadioButton OaAsFpqLvT;

		private Guna2RadioButton radioModeAuto;

		private Guna2GroupBox guna2GroupBox3;

		private Guna2RadioButton radioInvisibleOff;

		private Guna2RadioButton radioInvisibleOn;

		private Guna2GroupBox guna2GroupBox4;

		private Guna2RadioButton radioProxiesOff;

		private Guna2RadioButton radioProxiesOn;

		private Guna2GroupBox guna2GroupBox5;

		private Guna2NumericUpDown threadsCounter;

		private Guna2GroupBox guna2GroupBox6;

		private Guna2ComboBox countriesCombo;

		private Guna2GroupBox guna2GroupBox7;

		private Guna2TextBox emailDomainTxt;

		private Guna2GroupBox guna2GroupBox8;

		private Guna2TextBox gmailAccountTxt;

		private Guna2GroupBox guna2GroupBox9;

		private Guna2TextBox passwordTxt;

		private Guna2GroupBox guna2GroupBox10;

		private Guna2TextBox gamerTagTxt;

		private Guna2GroupBox guna2GroupBox11;

		private Guna2TextBox secAnsTxt;

		private Guna2Separator guna2Separator1;

		private Guna2GroupBox guna2GroupBox12;

		private Guna2ComboBox captchaCombo;

		private Guna2GroupBox guna2GroupBox15;

		private Guna2TextBox anyCaptchaTxt;

		private Guna2GroupBox guna2GroupBox13;

		private Guna2TextBox antiCaptchaTxt;

		private Guna2GroupBox guna2GroupBox14;

		private Guna2TextBox XbOhpOiNrS;

		private Guna2Separator vVahmlPppb;

		private Guna2GroupBox guna2GroupBox16;

		private Guna2ComboBox smsCombo;

		private Guna2GroupBox guna2GroupBox17;

		private Guna2TextBox smsOperatorTxt;

		private Guna2GroupBox guna2GroupBox18;

		private Guna2TextBox smsActivateTxt;

		private Guna2GroupBox guna2GroupBox19;

		private Guna2TextBox fiveSimTxt;

		private Guna2Button settingSaveBtn;

		private Guna2GroupBox guna2GroupBox20;

		private Guna2TextBox discordWebhookTxt;

		private Guna2GroupBox guna2GroupBox21;

		private Guna2HtmlLabel guna2HtmlLabel2;

		private Guna2ToggleSwitch saveFileSwitch;

		private Guna2HtmlLabel guna2HtmlLabel1;

		private Guna2ToggleSwitch saveDiscordSwitch;

		private Guna2Separator guna2Separator3;

		private Guna2MessageDialog guna2MessageDialog_0;

		public Settings()
		{
			InitializeComponent();
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			licenceTxt.Text = NewBlizzGen.Properties.Settings.Default.license;
			XbOhpOiNrS.Text = NewBlizzGen.Properties.Settings.Default.twocaptcha;
			antiCaptchaTxt.Text = NewBlizzGen.Properties.Settings.Default.anticaptcha;
			anyCaptchaTxt.Text = NewBlizzGen.Properties.Settings.Default.anycaptcha;
			fiveSimTxt.Text = NewBlizzGen.Properties.Settings.Default.fivesim;
			smsActivateTxt.Text = NewBlizzGen.Properties.Settings.Default.smsactivate;
			discordWebhookTxt.Text = NewBlizzGen.Properties.Settings.Default.webhook;
			passwordTxt.Text = NewBlizzGen.Properties.Settings.Default.password;
			gamerTagTxt.Text = NewBlizzGen.Properties.Settings.Default.gamertag;
			secAnsTxt.Text = NewBlizzGen.Properties.Settings.Default.secretans;
			saveDiscordSwitch.Checked = NewBlizzGen.Properties.Settings.Default.senddiscord;
			saveFileSwitch.Checked = NewBlizzGen.Properties.Settings.Default.savefile;
			smsOperatorTxt.Text = NewBlizzGen.Properties.Settings.Default.smsoperator;
			countriesCombo.Text = NewBlizzGen.Properties.Settings.Default.country;
			threadsCounter.Value = NewBlizzGen.Properties.Settings.Default.threads;
			if (NewBlizzGen.Properties.Settings.Default.mode == 0)
			{
				OaAsFpqLvT.Checked = true;
			}
			else
			{
				radioModeAuto.Checked = true;
			}
			if (NewBlizzGen.Properties.Settings.Default.invisible != 0)
			{
				radioInvisibleOn.Checked = true;
			}
			else
			{
				radioInvisibleOff.Checked = true;
			}
			if (NewBlizzGen.Properties.Settings.Default.proxies != 0)
			{
				radioProxiesOn.Checked = true;
			}
			else
			{
				radioProxiesOff.Checked = true;
			}
		}

		private void settingSaveBtn_Click(object sender, EventArgs e)
		{
			if (licenceTxt.Text == "")
			{
				ShowErrorMessage("You need to enter your license key!");
				return;
			}
			if (radioModeAuto.Checked && XbOhpOiNrS.Text == "" && antiCaptchaTxt.Text == "" && anyCaptchaTxt.Text == "")
			{
				ShowErrorMessage("You need to enter atleast one captcha Api key!");
				return;
			}
			if (fiveSimTxt.Text == "" && smsActivateTxt.Text == "")
			{
				ShowErrorMessage("You need enter atleast one SMS service API key!");
				return;
			}
			if (saveDiscordSwitch.Checked && discordWebhookTxt.Text == "")
			{
				ShowErrorMessage("You need to enter discord webhook or turn off send to discord!");
				return;
			}
			if (radioModeAuto.Checked)
			{
				NewBlizzGen.Properties.Settings.Default.mode = 1;
			}
			else
			{
				NewBlizzGen.Properties.Settings.Default.mode = 0;
			}
			if (!radioInvisibleOn.Checked)
			{
				NewBlizzGen.Properties.Settings.Default.invisible = 0;
			}
			else
			{
				NewBlizzGen.Properties.Settings.Default.invisible = 1;
			}
			if (radioProxiesOn.Checked)
			{
				NewBlizzGen.Properties.Settings.Default.proxies = 1;
			}
			else
			{
				NewBlizzGen.Properties.Settings.Default.proxies = 0;
			}
			NewBlizzGen.Properties.Settings.Default.twocaptcha = XbOhpOiNrS.Text;
			NewBlizzGen.Properties.Settings.Default.anticaptcha = antiCaptchaTxt.Text;
			NewBlizzGen.Properties.Settings.Default.anycaptcha = anyCaptchaTxt.Text;
			NewBlizzGen.Properties.Settings.Default.fivesim = fiveSimTxt.Text;
			NewBlizzGen.Properties.Settings.Default.smsactivate = smsActivateTxt.Text;
			NewBlizzGen.Properties.Settings.Default.webhook = discordWebhookTxt.Text;
			NewBlizzGen.Properties.Settings.Default.password = passwordTxt.Text;
			NewBlizzGen.Properties.Settings.Default.gamertag = gamerTagTxt.Text;
			NewBlizzGen.Properties.Settings.Default.secretans = secAnsTxt.Text;
			if (!saveDiscordSwitch.Checked)
			{
				NewBlizzGen.Properties.Settings.Default.senddiscord = false;
			}
			else
			{
				NewBlizzGen.Properties.Settings.Default.senddiscord = true;
			}
			if (!saveFileSwitch.Checked)
			{
				NewBlizzGen.Properties.Settings.Default.savefile = false;
			}
			else
			{
				NewBlizzGen.Properties.Settings.Default.savefile = true;
			}
			NewBlizzGen.Properties.Settings.Default.smsoperator = smsOperatorTxt.Text;
			NewBlizzGen.Properties.Settings.Default.country = countriesCombo.Text;
			NewBlizzGen.Properties.Settings.Default.threads = (int)threadsCounter.Value;
			try
			{
				NewBlizzGen.Properties.Settings.Default.Save();
				guna2MessageDialog_0.Caption = "Success";
				guna2MessageDialog_0.Icon = MessageDialogIcon.Information;
				guna2MessageDialog_0.Text = "Settings Saved!";
				guna2MessageDialog_0.Show();
			}
			catch (Exception ex)
			{
				ShowErrorMessage("Unable to save setting error: " + ex.Message);
			}
		}

		public void ShowErrorMessage(string Message)
		{
			guna2MessageDialog_0.Caption = "Settings Error";
			guna2MessageDialog_0.Icon = MessageDialogIcon.Error;
			guna2MessageDialog_0.Text = Message;
			guna2MessageDialog_0.Show();
		}

		private void OaAsFpqLvT_CheckedChanged(object sender, EventArgs e)
		{
			radioInvisibleOff.Checked = true;
		}

		private void EkTsesRmcr(object sender, EventArgs e)
		{
			radioModeAuto.Checked = true;
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
			guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			licenceTxt = new Guna.UI2.WinForms.Guna2TextBox();
			guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
			OaAsFpqLvT = new Guna.UI2.WinForms.Guna2RadioButton();
			radioModeAuto = new Guna.UI2.WinForms.Guna2RadioButton();
			guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
			radioInvisibleOff = new Guna.UI2.WinForms.Guna2RadioButton();
			radioInvisibleOn = new Guna.UI2.WinForms.Guna2RadioButton();
			guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
			radioProxiesOff = new Guna.UI2.WinForms.Guna2RadioButton();
			radioProxiesOn = new Guna.UI2.WinForms.Guna2RadioButton();
			guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
			threadsCounter = new Guna.UI2.WinForms.Guna2NumericUpDown();
			guna2GroupBox6 = new Guna.UI2.WinForms.Guna2GroupBox();
			countriesCombo = new Guna.UI2.WinForms.Guna2ComboBox();
			guna2GroupBox7 = new Guna.UI2.WinForms.Guna2GroupBox();
			emailDomainTxt = new Guna.UI2.WinForms.Guna2TextBox();
			guna2GroupBox8 = new Guna.UI2.WinForms.Guna2GroupBox();
			gmailAccountTxt = new Guna.UI2.WinForms.Guna2TextBox();
			guna2GroupBox9 = new Guna.UI2.WinForms.Guna2GroupBox();
			passwordTxt = new Guna.UI2.WinForms.Guna2TextBox();
			guna2GroupBox10 = new Guna.UI2.WinForms.Guna2GroupBox();
			gamerTagTxt = new Guna.UI2.WinForms.Guna2TextBox();
			guna2GroupBox11 = new Guna.UI2.WinForms.Guna2GroupBox();
			secAnsTxt = new Guna.UI2.WinForms.Guna2TextBox();
			guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
			guna2GroupBox12 = new Guna.UI2.WinForms.Guna2GroupBox();
			captchaCombo = new Guna.UI2.WinForms.Guna2ComboBox();
			guna2GroupBox15 = new Guna.UI2.WinForms.Guna2GroupBox();
			anyCaptchaTxt = new Guna.UI2.WinForms.Guna2TextBox();
			guna2GroupBox13 = new Guna.UI2.WinForms.Guna2GroupBox();
			antiCaptchaTxt = new Guna.UI2.WinForms.Guna2TextBox();
			guna2GroupBox14 = new Guna.UI2.WinForms.Guna2GroupBox();
			XbOhpOiNrS = new Guna.UI2.WinForms.Guna2TextBox();
			vVahmlPppb = new Guna.UI2.WinForms.Guna2Separator();
			guna2GroupBox16 = new Guna.UI2.WinForms.Guna2GroupBox();
			smsCombo = new Guna.UI2.WinForms.Guna2ComboBox();
			guna2GroupBox17 = new Guna.UI2.WinForms.Guna2GroupBox();
			smsOperatorTxt = new Guna.UI2.WinForms.Guna2TextBox();
			guna2GroupBox18 = new Guna.UI2.WinForms.Guna2GroupBox();
			smsActivateTxt = new Guna.UI2.WinForms.Guna2TextBox();
			guna2GroupBox19 = new Guna.UI2.WinForms.Guna2GroupBox();
			fiveSimTxt = new Guna.UI2.WinForms.Guna2TextBox();
			settingSaveBtn = new Guna.UI2.WinForms.Guna2Button();
			guna2GroupBox20 = new Guna.UI2.WinForms.Guna2GroupBox();
			discordWebhookTxt = new Guna.UI2.WinForms.Guna2TextBox();
			guna2GroupBox21 = new Guna.UI2.WinForms.Guna2GroupBox();
			guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			saveFileSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
			guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			saveDiscordSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
			guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
			guna2MessageDialog_0 = new Guna.UI2.WinForms.Guna2MessageDialog();
			guna2GroupBox1.SuspendLayout();
			guna2GroupBox2.SuspendLayout();
			guna2GroupBox3.SuspendLayout();
			guna2GroupBox4.SuspendLayout();
			guna2GroupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)threadsCounter).BeginInit();
			guna2GroupBox6.SuspendLayout();
			guna2GroupBox7.SuspendLayout();
			guna2GroupBox8.SuspendLayout();
			guna2GroupBox9.SuspendLayout();
			guna2GroupBox10.SuspendLayout();
			guna2GroupBox11.SuspendLayout();
			guna2GroupBox12.SuspendLayout();
			guna2GroupBox15.SuspendLayout();
			guna2GroupBox13.SuspendLayout();
			guna2GroupBox14.SuspendLayout();
			guna2GroupBox16.SuspendLayout();
			guna2GroupBox17.SuspendLayout();
			guna2GroupBox18.SuspendLayout();
			guna2GroupBox19.SuspendLayout();
			guna2GroupBox20.SuspendLayout();
			guna2GroupBox21.SuspendLayout();
			SuspendLayout();
			guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox1.BorderThickness = 3;
			guna2GroupBox1.Controls.Add(licenceTxt);
			guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox1.FillColor = System.Drawing.Color.Black;
			guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox1.Location = new System.Drawing.Point(5, 5);
			guna2GroupBox1.Name = "guna2GroupBox1";
			guna2GroupBox1.ShadowDecoration.Parent = guna2GroupBox1;
			guna2GroupBox1.Size = new System.Drawing.Size(304, 87);
			guna2GroupBox1.TabIndex = 0;
			guna2GroupBox1.Text = "License Key:";
			licenceTxt.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			licenceTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			licenceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			licenceTxt.DefaultText = "";
			licenceTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			licenceTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			licenceTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			licenceTxt.DisabledState.Parent = licenceTxt;
			licenceTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			licenceTxt.Enabled = false;
			licenceTxt.FillColor = System.Drawing.Color.Black;
			licenceTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			licenceTxt.FocusedState.Parent = licenceTxt;
			licenceTxt.Font = new System.Drawing.Font("Segoe UI", 9f);
			licenceTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			licenceTxt.HoverState.Parent = licenceTxt;
			licenceTxt.Location = new System.Drawing.Point(6, 44);
			licenceTxt.Name = "licenceTxt";
			licenceTxt.PasswordChar = '\0';
			licenceTxt.PlaceholderText = "";
			licenceTxt.SelectedText = "";
			licenceTxt.ShadowDecoration.Parent = licenceTxt;
			licenceTxt.Size = new System.Drawing.Size(292, 36);
			licenceTxt.TabIndex = 0;
			guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox2.BorderThickness = 3;
			guna2GroupBox2.Controls.Add(OaAsFpqLvT);
			guna2GroupBox2.Controls.Add(radioModeAuto);
			guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox2.FillColor = System.Drawing.Color.Black;
			guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox2.Location = new System.Drawing.Point(314, 5);
			guna2GroupBox2.Name = "guna2GroupBox2";
			guna2GroupBox2.ShadowDecoration.Parent = guna2GroupBox2;
			guna2GroupBox2.Size = new System.Drawing.Size(131, 87);
			guna2GroupBox2.TabIndex = 1;
			guna2GroupBox2.Text = "Mode:";
			OaAsFpqLvT.AutoSize = true;
			OaAsFpqLvT.CheckedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			OaAsFpqLvT.CheckedState.BorderThickness = 0;
			OaAsFpqLvT.CheckedState.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
			OaAsFpqLvT.CheckedState.InnerColor = System.Drawing.Color.White;
			OaAsFpqLvT.CheckedState.InnerOffset = -4;
			OaAsFpqLvT.Location = new System.Drawing.Point(66, 52);
			OaAsFpqLvT.Name = "radioModeManual";
			OaAsFpqLvT.Size = new System.Drawing.Size(65, 19);
			OaAsFpqLvT.TabIndex = 1;
			OaAsFpqLvT.Text = "Manual";
			OaAsFpqLvT.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(125, 137, 149);
			OaAsFpqLvT.UncheckedState.BorderThickness = 2;
			OaAsFpqLvT.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			OaAsFpqLvT.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			OaAsFpqLvT.CheckedChanged += new System.EventHandler(OaAsFpqLvT_CheckedChanged);
			radioModeAuto.AutoSize = true;
			radioModeAuto.Checked = true;
			radioModeAuto.CheckedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			radioModeAuto.CheckedState.BorderThickness = 0;
			radioModeAuto.CheckedState.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
			radioModeAuto.CheckedState.InnerColor = System.Drawing.Color.White;
			radioModeAuto.CheckedState.InnerOffset = -4;
			radioModeAuto.Location = new System.Drawing.Point(9, 52);
			radioModeAuto.Name = "radioModeAuto";
			radioModeAuto.Size = new System.Drawing.Size(51, 19);
			radioModeAuto.TabIndex = 0;
			radioModeAuto.TabStop = true;
			radioModeAuto.Text = "Auto";
			radioModeAuto.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(125, 137, 149);
			radioModeAuto.UncheckedState.BorderThickness = 2;
			radioModeAuto.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			radioModeAuto.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			guna2GroupBox3.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox3.BorderThickness = 3;
			guna2GroupBox3.Controls.Add(radioInvisibleOff);
			guna2GroupBox3.Controls.Add(radioInvisibleOn);
			guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox3.FillColor = System.Drawing.Color.Black;
			guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox3.Location = new System.Drawing.Point(451, 5);
			guna2GroupBox3.Name = "guna2GroupBox3";
			guna2GroupBox3.ShadowDecoration.Parent = guna2GroupBox3;
			guna2GroupBox3.Size = new System.Drawing.Size(102, 87);
			guna2GroupBox3.TabIndex = 2;
			guna2GroupBox3.Text = "Invisible:";
			radioInvisibleOff.AutoSize = true;
			radioInvisibleOff.CheckedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			radioInvisibleOff.CheckedState.BorderThickness = 0;
			radioInvisibleOff.CheckedState.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
			radioInvisibleOff.CheckedState.InnerColor = System.Drawing.Color.White;
			radioInvisibleOff.CheckedState.InnerOffset = -4;
			radioInvisibleOff.Location = new System.Drawing.Point(56, 52);
			radioInvisibleOff.Name = "radioInvisibleOff";
			radioInvisibleOff.Size = new System.Drawing.Size(42, 19);
			radioInvisibleOff.TabIndex = 1;
			radioInvisibleOff.Text = "Off";
			radioInvisibleOff.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(125, 137, 149);
			radioInvisibleOff.UncheckedState.BorderThickness = 2;
			radioInvisibleOff.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			radioInvisibleOff.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			radioInvisibleOn.AutoSize = true;
			radioInvisibleOn.Checked = true;
			radioInvisibleOn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			radioInvisibleOn.CheckedState.BorderThickness = 0;
			radioInvisibleOn.CheckedState.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
			radioInvisibleOn.CheckedState.InnerColor = System.Drawing.Color.White;
			radioInvisibleOn.CheckedState.InnerOffset = -4;
			radioInvisibleOn.Location = new System.Drawing.Point(9, 52);
			radioInvisibleOn.Name = "radioInvisibleOn";
			radioInvisibleOn.Size = new System.Drawing.Size(41, 19);
			radioInvisibleOn.TabIndex = 0;
			radioInvisibleOn.TabStop = true;
			radioInvisibleOn.Text = "On";
			radioInvisibleOn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(125, 137, 149);
			radioInvisibleOn.UncheckedState.BorderThickness = 2;
			radioInvisibleOn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			radioInvisibleOn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			radioInvisibleOn.CheckedChanged += new System.EventHandler(EkTsesRmcr);
			guna2GroupBox4.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox4.BorderThickness = 3;
			guna2GroupBox4.Controls.Add(radioProxiesOff);
			guna2GroupBox4.Controls.Add(radioProxiesOn);
			guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox4.FillColor = System.Drawing.Color.Black;
			guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox4.Location = new System.Drawing.Point(559, 5);
			guna2GroupBox4.Name = "guna2GroupBox4";
			guna2GroupBox4.ShadowDecoration.Parent = guna2GroupBox4;
			guna2GroupBox4.Size = new System.Drawing.Size(102, 87);
			guna2GroupBox4.TabIndex = 3;
			guna2GroupBox4.Text = "Proxies:";
			radioProxiesOff.AutoSize = true;
			radioProxiesOff.CheckedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			radioProxiesOff.CheckedState.BorderThickness = 0;
			radioProxiesOff.CheckedState.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
			radioProxiesOff.CheckedState.InnerColor = System.Drawing.Color.White;
			radioProxiesOff.CheckedState.InnerOffset = -4;
			radioProxiesOff.Location = new System.Drawing.Point(56, 52);
			radioProxiesOff.Name = "radioProxiesOff";
			radioProxiesOff.Size = new System.Drawing.Size(42, 19);
			radioProxiesOff.TabIndex = 1;
			radioProxiesOff.Text = "Off";
			radioProxiesOff.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(125, 137, 149);
			radioProxiesOff.UncheckedState.BorderThickness = 2;
			radioProxiesOff.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			radioProxiesOff.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			radioProxiesOn.AutoSize = true;
			radioProxiesOn.Checked = true;
			radioProxiesOn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			radioProxiesOn.CheckedState.BorderThickness = 0;
			radioProxiesOn.CheckedState.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
			radioProxiesOn.CheckedState.InnerColor = System.Drawing.Color.White;
			radioProxiesOn.CheckedState.InnerOffset = -4;
			radioProxiesOn.Location = new System.Drawing.Point(9, 52);
			radioProxiesOn.Name = "radioProxiesOn";
			radioProxiesOn.Size = new System.Drawing.Size(41, 19);
			radioProxiesOn.TabIndex = 0;
			radioProxiesOn.TabStop = true;
			radioProxiesOn.Text = "On";
			radioProxiesOn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(125, 137, 149);
			radioProxiesOn.UncheckedState.BorderThickness = 2;
			radioProxiesOn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			radioProxiesOn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			guna2GroupBox5.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox5.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox5.BorderThickness = 3;
			guna2GroupBox5.Controls.Add(threadsCounter);
			guna2GroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox5.FillColor = System.Drawing.Color.Black;
			guna2GroupBox5.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox5.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox5.Location = new System.Drawing.Point(667, 5);
			guna2GroupBox5.Name = "guna2GroupBox5";
			guna2GroupBox5.ShadowDecoration.Parent = guna2GroupBox5;
			guna2GroupBox5.Size = new System.Drawing.Size(114, 87);
			guna2GroupBox5.TabIndex = 4;
			guna2GroupBox5.Text = "Threads:";
			threadsCounter.BackColor = System.Drawing.Color.Transparent;
			threadsCounter.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			threadsCounter.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			threadsCounter.Cursor = System.Windows.Forms.Cursors.IBeam;
			threadsCounter.DisabledState.Parent = threadsCounter;
			threadsCounter.FillColor = System.Drawing.Color.Black;
			threadsCounter.FocusedState.Parent = threadsCounter;
			threadsCounter.Font = new System.Drawing.Font("Segoe UI", 9f);
			threadsCounter.ForeColor = System.Drawing.Color.WhiteSmoke;
			threadsCounter.Location = new System.Drawing.Point(8, 46);
			threadsCounter.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			threadsCounter.Name = "threadsCounter";
			threadsCounter.ShadowDecoration.Parent = threadsCounter;
			threadsCounter.Size = new System.Drawing.Size(99, 33);
			threadsCounter.TabIndex = 0;
			threadsCounter.UpDownButtonFillColor = System.Drawing.Color.FromArgb(22, 33, 62);
			threadsCounter.UseTransparentBackground = true;
			threadsCounter.Value = new decimal(new int[4] { 10, 0, 0, 0 });
			guna2GroupBox6.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox6.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox6.BorderThickness = 3;
			guna2GroupBox6.Controls.Add(countriesCombo);
			guna2GroupBox6.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox6.FillColor = System.Drawing.Color.Black;
			guna2GroupBox6.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox6.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox6.Location = new System.Drawing.Point(787, 5);
			guna2GroupBox6.Name = "guna2GroupBox6";
			guna2GroupBox6.ShadowDecoration.Parent = guna2GroupBox6;
			guna2GroupBox6.Size = new System.Drawing.Size(163, 87);
			guna2GroupBox6.TabIndex = 5;
			guna2GroupBox6.Text = "Country:";
			countriesCombo.BackColor = System.Drawing.Color.Transparent;
			countriesCombo.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			countriesCombo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			countriesCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			countriesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			countriesCombo.Enabled = false;
			countriesCombo.FillColor = System.Drawing.Color.Black;
			countriesCombo.FocusedColor = System.Drawing.Color.FromArgb(94, 148, 255);
			countriesCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			countriesCombo.FocusedState.Parent = countriesCombo;
			countriesCombo.Font = new System.Drawing.Font("Segoe UI", 10f);
			countriesCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
			countriesCombo.HoverState.Parent = countriesCombo;
			countriesCombo.ItemHeight = 30;
			countriesCombo.Items.AddRange(new object[2] { "India", "England" });
			countriesCombo.ItemsAppearance.Parent = countriesCombo;
			countriesCombo.Location = new System.Drawing.Point(7, 45);
			countriesCombo.Name = "countriesCombo";
			countriesCombo.ShadowDecoration.Parent = countriesCombo;
			countriesCombo.Size = new System.Drawing.Size(149, 36);
			countriesCombo.StartIndex = 0;
			countriesCombo.TabIndex = 6;
			guna2GroupBox7.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox7.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox7.BorderThickness = 3;
			guna2GroupBox7.Controls.Add(emailDomainTxt);
			guna2GroupBox7.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox7.FillColor = System.Drawing.Color.Black;
			guna2GroupBox7.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox7.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox7.Location = new System.Drawing.Point(5, 97);
			guna2GroupBox7.Name = "guna2GroupBox7";
			guna2GroupBox7.ShadowDecoration.Parent = guna2GroupBox7;
			guna2GroupBox7.Size = new System.Drawing.Size(133, 87);
			guna2GroupBox7.TabIndex = 1;
			guna2GroupBox7.Text = "Email Domain:";
			emailDomainTxt.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			emailDomainTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			emailDomainTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			emailDomainTxt.DefaultText = "gmail.com";
			emailDomainTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			emailDomainTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			emailDomainTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			emailDomainTxt.DisabledState.Parent = emailDomainTxt;
			emailDomainTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			emailDomainTxt.FillColor = System.Drawing.Color.Black;
			emailDomainTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			emailDomainTxt.FocusedState.Parent = emailDomainTxt;
			emailDomainTxt.Font = new System.Drawing.Font("Segoe UI", 9f);
			emailDomainTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			emailDomainTxt.HoverState.Parent = emailDomainTxt;
			emailDomainTxt.Location = new System.Drawing.Point(6, 44);
			emailDomainTxt.Name = "emailDomainTxt";
			emailDomainTxt.PasswordChar = '\0';
			emailDomainTxt.PlaceholderText = "";
			emailDomainTxt.SelectedText = "";
			emailDomainTxt.ShadowDecoration.Parent = emailDomainTxt;
			emailDomainTxt.Size = new System.Drawing.Size(120, 36);
			emailDomainTxt.TabIndex = 0;
			guna2GroupBox8.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox8.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox8.BorderThickness = 3;
			guna2GroupBox8.Controls.Add(gmailAccountTxt);
			guna2GroupBox8.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox8.FillColor = System.Drawing.Color.Black;
			guna2GroupBox8.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox8.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox8.Location = new System.Drawing.Point(144, 97);
			guna2GroupBox8.Name = "guna2GroupBox8";
			guna2GroupBox8.ShadowDecoration.Parent = guna2GroupBox8;
			guna2GroupBox8.Size = new System.Drawing.Size(198, 87);
			guna2GroupBox8.TabIndex = 2;
			guna2GroupBox8.Text = "Gmail Email Address:";
			gmailAccountTxt.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			gmailAccountTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			gmailAccountTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			gmailAccountTxt.DefaultText = "";
			gmailAccountTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			gmailAccountTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			gmailAccountTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			gmailAccountTxt.DisabledState.Parent = gmailAccountTxt;
			gmailAccountTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			gmailAccountTxt.Enabled = false;
			gmailAccountTxt.FillColor = System.Drawing.Color.Black;
			gmailAccountTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			gmailAccountTxt.FocusedState.Parent = gmailAccountTxt;
			gmailAccountTxt.Font = new System.Drawing.Font("Segoe UI", 9f);
			gmailAccountTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			gmailAccountTxt.HoverState.Parent = gmailAccountTxt;
			gmailAccountTxt.Location = new System.Drawing.Point(6, 44);
			gmailAccountTxt.Name = "gmailAccountTxt";
			gmailAccountTxt.PasswordChar = '\0';
			gmailAccountTxt.PlaceholderText = "";
			gmailAccountTxt.SelectedText = "";
			gmailAccountTxt.ShadowDecoration.Parent = gmailAccountTxt;
			gmailAccountTxt.Size = new System.Drawing.Size(186, 36);
			gmailAccountTxt.TabIndex = 0;
			guna2GroupBox9.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox9.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox9.BorderThickness = 3;
			guna2GroupBox9.Controls.Add(passwordTxt);
			guna2GroupBox9.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox9.FillColor = System.Drawing.Color.Black;
			guna2GroupBox9.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox9.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox9.Location = new System.Drawing.Point(348, 97);
			guna2GroupBox9.Name = "guna2GroupBox9";
			guna2GroupBox9.ShadowDecoration.Parent = guna2GroupBox9;
			guna2GroupBox9.Size = new System.Drawing.Size(163, 87);
			guna2GroupBox9.TabIndex = 3;
			guna2GroupBox9.Text = "Password:";
			passwordTxt.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			passwordTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			passwordTxt.DefaultText = "";
			passwordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			passwordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			passwordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			passwordTxt.DisabledState.Parent = passwordTxt;
			passwordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			passwordTxt.FillColor = System.Drawing.Color.Black;
			passwordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			passwordTxt.FocusedState.Parent = passwordTxt;
			passwordTxt.Font = new System.Drawing.Font("Segoe UI", 9f);
			passwordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			passwordTxt.HoverState.Parent = passwordTxt;
			passwordTxt.Location = new System.Drawing.Point(6, 44);
			passwordTxt.Name = "passwordTxt";
			passwordTxt.PasswordChar = '\0';
			passwordTxt.PlaceholderText = "";
			passwordTxt.SelectedText = "";
			passwordTxt.ShadowDecoration.Parent = passwordTxt;
			passwordTxt.Size = new System.Drawing.Size(150, 36);
			passwordTxt.TabIndex = 0;
			guna2GroupBox10.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox10.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox10.BorderThickness = 3;
			guna2GroupBox10.Controls.Add(gamerTagTxt);
			guna2GroupBox10.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox10.FillColor = System.Drawing.Color.Black;
			guna2GroupBox10.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox10.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox10.Location = new System.Drawing.Point(517, 97);
			guna2GroupBox10.Name = "guna2GroupBox10";
			guna2GroupBox10.ShadowDecoration.Parent = guna2GroupBox10;
			guna2GroupBox10.Size = new System.Drawing.Size(118, 87);
			guna2GroupBox10.TabIndex = 4;
			guna2GroupBox10.Text = "Gamer Tag:";
			gamerTagTxt.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			gamerTagTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			gamerTagTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			gamerTagTxt.DefaultText = "";
			gamerTagTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			gamerTagTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			gamerTagTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			gamerTagTxt.DisabledState.Parent = gamerTagTxt;
			gamerTagTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			gamerTagTxt.FillColor = System.Drawing.Color.Black;
			gamerTagTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			gamerTagTxt.FocusedState.Parent = gamerTagTxt;
			gamerTagTxt.Font = new System.Drawing.Font("Segoe UI", 9f);
			gamerTagTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			gamerTagTxt.HoverState.Parent = gamerTagTxt;
			gamerTagTxt.Location = new System.Drawing.Point(6, 44);
			gamerTagTxt.Name = "gamerTagTxt";
			gamerTagTxt.PasswordChar = '\0';
			gamerTagTxt.PlaceholderText = "";
			gamerTagTxt.SelectedText = "";
			gamerTagTxt.ShadowDecoration.Parent = gamerTagTxt;
			gamerTagTxt.Size = new System.Drawing.Size(106, 36);
			gamerTagTxt.TabIndex = 0;
			guna2GroupBox11.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox11.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox11.BorderThickness = 3;
			guna2GroupBox11.Controls.Add(secAnsTxt);
			guna2GroupBox11.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox11.FillColor = System.Drawing.Color.Black;
			guna2GroupBox11.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox11.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox11.Location = new System.Drawing.Point(641, 97);
			guna2GroupBox11.Name = "guna2GroupBox11";
			guna2GroupBox11.ShadowDecoration.Parent = guna2GroupBox11;
			guna2GroupBox11.Size = new System.Drawing.Size(118, 87);
			guna2GroupBox11.TabIndex = 5;
			guna2GroupBox11.Text = "Secret Ans:";
			secAnsTxt.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			secAnsTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			secAnsTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			secAnsTxt.DefaultText = "";
			secAnsTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			secAnsTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			secAnsTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			secAnsTxt.DisabledState.Parent = secAnsTxt;
			secAnsTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			secAnsTxt.FillColor = System.Drawing.Color.Black;
			secAnsTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			secAnsTxt.FocusedState.Parent = secAnsTxt;
			secAnsTxt.Font = new System.Drawing.Font("Segoe UI", 9f);
			secAnsTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			secAnsTxt.HoverState.Parent = secAnsTxt;
			secAnsTxt.Location = new System.Drawing.Point(6, 44);
			secAnsTxt.Name = "secAnsTxt";
			secAnsTxt.PasswordChar = '\0';
			secAnsTxt.PlaceholderText = "";
			secAnsTxt.SelectedText = "";
			secAnsTxt.ShadowDecoration.Parent = secAnsTxt;
			secAnsTxt.Size = new System.Drawing.Size(106, 36);
			secAnsTxt.TabIndex = 0;
			guna2Separator1.FillColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			guna2Separator1.Location = new System.Drawing.Point(11, 184);
			guna2Separator1.Name = "guna2Separator1";
			guna2Separator1.Size = new System.Drawing.Size(939, 10);
			guna2Separator1.TabIndex = 6;
			guna2GroupBox12.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox12.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox12.BorderThickness = 3;
			guna2GroupBox12.Controls.Add(captchaCombo);
			guna2GroupBox12.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox12.FillColor = System.Drawing.Color.Black;
			guna2GroupBox12.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox12.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox12.Location = new System.Drawing.Point(5, 195);
			guna2GroupBox12.Name = "guna2GroupBox12";
			guna2GroupBox12.ShadowDecoration.Parent = guna2GroupBox12;
			guna2GroupBox12.Size = new System.Drawing.Size(143, 87);
			guna2GroupBox12.TabIndex = 7;
			guna2GroupBox12.Text = "Captcha:";
			captchaCombo.BackColor = System.Drawing.Color.Transparent;
			captchaCombo.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			captchaCombo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			captchaCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			captchaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			captchaCombo.Enabled = false;
			captchaCombo.FillColor = System.Drawing.Color.Black;
			captchaCombo.FocusedColor = System.Drawing.Color.FromArgb(94, 148, 255);
			captchaCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			captchaCombo.FocusedState.Parent = captchaCombo;
			captchaCombo.Font = new System.Drawing.Font("Segoe UI", 10f);
			captchaCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
			captchaCombo.HoverState.Parent = captchaCombo;
			captchaCombo.ItemHeight = 30;
			captchaCombo.Items.AddRange(new object[3] { "2Captcha", "AnyCaptcha", "Anti-Captcha" });
			captchaCombo.ItemsAppearance.Parent = captchaCombo;
			captchaCombo.Location = new System.Drawing.Point(7, 45);
			captchaCombo.Name = "captchaCombo";
			captchaCombo.ShadowDecoration.Parent = captchaCombo;
			captchaCombo.Size = new System.Drawing.Size(129, 36);
			captchaCombo.StartIndex = 1;
			captchaCombo.TabIndex = 6;
			guna2GroupBox15.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox15.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox15.BorderThickness = 3;
			guna2GroupBox15.Controls.Add(anyCaptchaTxt);
			guna2GroupBox15.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox15.FillColor = System.Drawing.Color.Black;
			guna2GroupBox15.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox15.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox15.Location = new System.Drawing.Point(689, 195);
			guna2GroupBox15.Name = "guna2GroupBox15";
			guna2GroupBox15.ShadowDecoration.Parent = guna2GroupBox15;
			guna2GroupBox15.Size = new System.Drawing.Size(261, 87);
			guna2GroupBox15.TabIndex = 8;
			guna2GroupBox15.Text = "AnyCaptcha Api:";
			anyCaptchaTxt.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			anyCaptchaTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			anyCaptchaTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			anyCaptchaTxt.DefaultText = "";
			anyCaptchaTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			anyCaptchaTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			anyCaptchaTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			anyCaptchaTxt.DisabledState.Parent = anyCaptchaTxt;
			anyCaptchaTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			anyCaptchaTxt.FillColor = System.Drawing.Color.Black;
			anyCaptchaTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			anyCaptchaTxt.FocusedState.Parent = anyCaptchaTxt;
			anyCaptchaTxt.Font = new System.Drawing.Font("Segoe UI", 9f);
			anyCaptchaTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			anyCaptchaTxt.HoverState.Parent = anyCaptchaTxt;
			anyCaptchaTxt.Location = new System.Drawing.Point(6, 44);
			anyCaptchaTxt.Name = "anyCaptchaTxt";
			anyCaptchaTxt.PasswordChar = '\0';
			anyCaptchaTxt.PlaceholderText = "";
			anyCaptchaTxt.SelectedText = "";
			anyCaptchaTxt.ShadowDecoration.Parent = anyCaptchaTxt;
			anyCaptchaTxt.Size = new System.Drawing.Size(248, 36);
			anyCaptchaTxt.TabIndex = 0;
			guna2GroupBox13.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox13.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox13.BorderThickness = 3;
			guna2GroupBox13.Controls.Add(antiCaptchaTxt);
			guna2GroupBox13.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox13.FillColor = System.Drawing.Color.Black;
			guna2GroupBox13.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox13.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox13.Location = new System.Drawing.Point(422, 195);
			guna2GroupBox13.Name = "guna2GroupBox13";
			guna2GroupBox13.ShadowDecoration.Parent = guna2GroupBox13;
			guna2GroupBox13.Size = new System.Drawing.Size(261, 87);
			guna2GroupBox13.TabIndex = 9;
			guna2GroupBox13.Text = "Anti-Captch Api:";
			antiCaptchaTxt.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			antiCaptchaTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			antiCaptchaTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			antiCaptchaTxt.DefaultText = "";
			antiCaptchaTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			antiCaptchaTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			antiCaptchaTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			antiCaptchaTxt.DisabledState.Parent = antiCaptchaTxt;
			antiCaptchaTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			antiCaptchaTxt.Enabled = false;
			antiCaptchaTxt.FillColor = System.Drawing.Color.Black;
			antiCaptchaTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			antiCaptchaTxt.FocusedState.Parent = antiCaptchaTxt;
			antiCaptchaTxt.Font = new System.Drawing.Font("Segoe UI", 9f);
			antiCaptchaTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			antiCaptchaTxt.HoverState.Parent = antiCaptchaTxt;
			antiCaptchaTxt.Location = new System.Drawing.Point(6, 44);
			antiCaptchaTxt.Name = "antiCaptchaTxt";
			antiCaptchaTxt.PasswordChar = '\0';
			antiCaptchaTxt.PlaceholderText = "";
			antiCaptchaTxt.SelectedText = "";
			antiCaptchaTxt.ShadowDecoration.Parent = antiCaptchaTxt;
			antiCaptchaTxt.Size = new System.Drawing.Size(248, 36);
			antiCaptchaTxt.TabIndex = 0;
			guna2GroupBox14.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox14.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox14.BorderThickness = 3;
			guna2GroupBox14.Controls.Add(XbOhpOiNrS);
			guna2GroupBox14.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox14.FillColor = System.Drawing.Color.Black;
			guna2GroupBox14.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox14.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox14.Location = new System.Drawing.Point(154, 195);
			guna2GroupBox14.Name = "guna2GroupBox14";
			guna2GroupBox14.ShadowDecoration.Parent = guna2GroupBox14;
			guna2GroupBox14.Size = new System.Drawing.Size(261, 87);
			guna2GroupBox14.TabIndex = 9;
			guna2GroupBox14.Text = "2Captcha Api:";
			XbOhpOiNrS.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			XbOhpOiNrS.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			XbOhpOiNrS.Cursor = System.Windows.Forms.Cursors.IBeam;
			XbOhpOiNrS.DefaultText = "";
			XbOhpOiNrS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			XbOhpOiNrS.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			XbOhpOiNrS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			XbOhpOiNrS.DisabledState.Parent = XbOhpOiNrS;
			XbOhpOiNrS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			XbOhpOiNrS.Enabled = false;
			XbOhpOiNrS.FillColor = System.Drawing.Color.Black;
			XbOhpOiNrS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			XbOhpOiNrS.FocusedState.Parent = XbOhpOiNrS;
			XbOhpOiNrS.Font = new System.Drawing.Font("Segoe UI", 9f);
			XbOhpOiNrS.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			XbOhpOiNrS.HoverState.Parent = XbOhpOiNrS;
			XbOhpOiNrS.Location = new System.Drawing.Point(6, 44);
			XbOhpOiNrS.Name = "twoCaptchaTxt";
			XbOhpOiNrS.PasswordChar = '\0';
			XbOhpOiNrS.PlaceholderText = "";
			XbOhpOiNrS.SelectedText = "";
			XbOhpOiNrS.ShadowDecoration.Parent = XbOhpOiNrS;
			XbOhpOiNrS.Size = new System.Drawing.Size(248, 36);
			XbOhpOiNrS.TabIndex = 0;
			vVahmlPppb.FillColor = System.Drawing.Color.FromArgb(22, 33, 62);
			vVahmlPppb.FillStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			vVahmlPppb.Location = new System.Drawing.Point(10, 282);
			vVahmlPppb.Name = "guna2Separator2";
			vVahmlPppb.Size = new System.Drawing.Size(939, 10);
			vVahmlPppb.TabIndex = 10;
			guna2GroupBox16.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox16.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox16.BorderThickness = 3;
			guna2GroupBox16.Controls.Add(smsCombo);
			guna2GroupBox16.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox16.FillColor = System.Drawing.Color.Black;
			guna2GroupBox16.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox16.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox16.Location = new System.Drawing.Point(6, 293);
			guna2GroupBox16.Name = "guna2GroupBox16";
			guna2GroupBox16.ShadowDecoration.Parent = guna2GroupBox16;
			guna2GroupBox16.Size = new System.Drawing.Size(143, 87);
			guna2GroupBox16.TabIndex = 8;
			guna2GroupBox16.Text = "SMS:";
			smsCombo.BackColor = System.Drawing.Color.Transparent;
			smsCombo.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			smsCombo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			smsCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			smsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			smsCombo.Enabled = false;
			smsCombo.FillColor = System.Drawing.Color.Black;
			smsCombo.FocusedColor = System.Drawing.Color.FromArgb(94, 148, 255);
			smsCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			smsCombo.FocusedState.Parent = smsCombo;
			smsCombo.Font = new System.Drawing.Font("Segoe UI", 10f);
			smsCombo.ForeColor = System.Drawing.Color.WhiteSmoke;
			smsCombo.HoverState.Parent = smsCombo;
			smsCombo.ItemHeight = 30;
			smsCombo.Items.AddRange(new object[2] { "5sim", "Sms-Activate" });
			smsCombo.ItemsAppearance.Parent = smsCombo;
			smsCombo.Location = new System.Drawing.Point(7, 44);
			smsCombo.Name = "smsCombo";
			smsCombo.ShadowDecoration.Parent = smsCombo;
			smsCombo.Size = new System.Drawing.Size(129, 36);
			smsCombo.StartIndex = 0;
			smsCombo.TabIndex = 6;
			guna2GroupBox17.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox17.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox17.BorderThickness = 3;
			guna2GroupBox17.Controls.Add(smsOperatorTxt);
			guna2GroupBox17.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox17.FillColor = System.Drawing.Color.Black;
			guna2GroupBox17.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox17.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox17.Location = new System.Drawing.Point(155, 293);
			guna2GroupBox17.Name = "guna2GroupBox17";
			guna2GroupBox17.ShadowDecoration.Parent = guna2GroupBox17;
			guna2GroupBox17.Size = new System.Drawing.Size(143, 87);
			guna2GroupBox17.TabIndex = 9;
			guna2GroupBox17.Text = "Operator:";
			smsOperatorTxt.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			smsOperatorTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			smsOperatorTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			smsOperatorTxt.DefaultText = "";
			smsOperatorTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			smsOperatorTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			smsOperatorTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			smsOperatorTxt.DisabledState.Parent = smsOperatorTxt;
			smsOperatorTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			smsOperatorTxt.FillColor = System.Drawing.Color.Black;
			smsOperatorTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			smsOperatorTxt.FocusedState.Parent = smsOperatorTxt;
			smsOperatorTxt.Font = new System.Drawing.Font("Segoe UI", 9f);
			smsOperatorTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			smsOperatorTxt.HoverState.Parent = smsOperatorTxt;
			smsOperatorTxt.Location = new System.Drawing.Point(7, 44);
			smsOperatorTxt.Name = "smsOperatorTxt";
			smsOperatorTxt.PasswordChar = '\0';
			smsOperatorTxt.PlaceholderText = "";
			smsOperatorTxt.SelectedText = "";
			smsOperatorTxt.ShadowDecoration.Parent = smsOperatorTxt;
			smsOperatorTxt.Size = new System.Drawing.Size(130, 36);
			smsOperatorTxt.TabIndex = 1;
			guna2GroupBox18.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox18.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox18.BorderThickness = 3;
			guna2GroupBox18.Controls.Add(smsActivateTxt);
			guna2GroupBox18.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox18.FillColor = System.Drawing.Color.Black;
			guna2GroupBox18.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox18.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox18.Location = new System.Drawing.Point(5, 386);
			guna2GroupBox18.Name = "guna2GroupBox18";
			guna2GroupBox18.ShadowDecoration.Parent = guna2GroupBox18;
			guna2GroupBox18.Size = new System.Drawing.Size(293, 87);
			guna2GroupBox18.TabIndex = 10;
			guna2GroupBox18.Text = "SMS Activate API:";
			smsActivateTxt.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			smsActivateTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			smsActivateTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			smsActivateTxt.DefaultText = "";
			smsActivateTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			smsActivateTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			smsActivateTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			smsActivateTxt.DisabledState.Parent = smsActivateTxt;
			smsActivateTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			smsActivateTxt.Enabled = false;
			smsActivateTxt.FillColor = System.Drawing.Color.Black;
			smsActivateTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			smsActivateTxt.FocusedState.Parent = smsActivateTxt;
			smsActivateTxt.Font = new System.Drawing.Font("Segoe UI", 9f);
			smsActivateTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			smsActivateTxt.HoverState.Parent = smsActivateTxt;
			smsActivateTxt.Location = new System.Drawing.Point(7, 44);
			smsActivateTxt.Name = "smsActivateTxt";
			smsActivateTxt.PasswordChar = '\0';
			smsActivateTxt.PlaceholderText = "";
			smsActivateTxt.SelectedText = "";
			smsActivateTxt.ShadowDecoration.Parent = smsActivateTxt;
			smsActivateTxt.Size = new System.Drawing.Size(280, 36);
			smsActivateTxt.TabIndex = 1;
			guna2GroupBox19.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox19.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox19.BorderThickness = 3;
			guna2GroupBox19.Controls.Add(fiveSimTxt);
			guna2GroupBox19.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox19.FillColor = System.Drawing.Color.Black;
			guna2GroupBox19.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox19.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox19.Location = new System.Drawing.Point(304, 293);
			guna2GroupBox19.Name = "guna2GroupBox19";
			guna2GroupBox19.ShadowDecoration.Parent = guna2GroupBox19;
			guna2GroupBox19.Size = new System.Drawing.Size(646, 180);
			guna2GroupBox19.TabIndex = 11;
			guna2GroupBox19.Text = "5Sim API:";
			fiveSimTxt.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			fiveSimTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			fiveSimTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			fiveSimTxt.DefaultText = "";
			fiveSimTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			fiveSimTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			fiveSimTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			fiveSimTxt.DisabledState.Parent = fiveSimTxt;
			fiveSimTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			fiveSimTxt.FillColor = System.Drawing.Color.Black;
			fiveSimTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			fiveSimTxt.FocusedState.Parent = fiveSimTxt;
			fiveSimTxt.Font = new System.Drawing.Font("Segoe UI", 9f);
			fiveSimTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			fiveSimTxt.HoverState.Parent = fiveSimTxt;
			fiveSimTxt.Location = new System.Drawing.Point(7, 44);
			fiveSimTxt.Multiline = true;
			fiveSimTxt.Name = "fiveSimTxt";
			fiveSimTxt.PasswordChar = '\0';
			fiveSimTxt.PlaceholderText = "";
			fiveSimTxt.SelectedText = "";
			fiveSimTxt.ShadowDecoration.Parent = fiveSimTxt;
			fiveSimTxt.Size = new System.Drawing.Size(632, 129);
			fiveSimTxt.TabIndex = 1;
			settingSaveBtn.CheckedState.Parent = settingSaveBtn;
			settingSaveBtn.CustomImages.Parent = settingSaveBtn;
			settingSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			settingSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			settingSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			settingSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			settingSaveBtn.DisabledState.Parent = settingSaveBtn;
			settingSaveBtn.FillColor = System.Drawing.Color.FromArgb(22, 33, 62);
			settingSaveBtn.Font = new System.Drawing.Font("Segoe UI", 9f);
			settingSaveBtn.ForeColor = System.Drawing.Color.White;
			settingSaveBtn.HoverState.Parent = settingSaveBtn;
			settingSaveBtn.Location = new System.Drawing.Point(770, 486);
			settingSaveBtn.Name = "settingSaveBtn";
			settingSaveBtn.ShadowDecoration.Parent = settingSaveBtn;
			settingSaveBtn.Size = new System.Drawing.Size(180, 87);
			settingSaveBtn.TabIndex = 12;
			settingSaveBtn.Text = "Save";
			settingSaveBtn.Click += new System.EventHandler(settingSaveBtn_Click);
			guna2GroupBox20.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox20.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox20.BorderThickness = 3;
			guna2GroupBox20.Controls.Add(discordWebhookTxt);
			guna2GroupBox20.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox20.FillColor = System.Drawing.Color.Black;
			guna2GroupBox20.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox20.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox20.Location = new System.Drawing.Point(6, 486);
			guna2GroupBox20.Name = "guna2GroupBox20";
			guna2GroupBox20.ShadowDecoration.Parent = guna2GroupBox20;
			guna2GroupBox20.Size = new System.Drawing.Size(758, 87);
			guna2GroupBox20.TabIndex = 11;
			guna2GroupBox20.Text = "Discord Webhook:";
			discordWebhookTxt.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
			discordWebhookTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			discordWebhookTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			discordWebhookTxt.DefaultText = "";
			discordWebhookTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			discordWebhookTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			discordWebhookTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			discordWebhookTxt.DisabledState.Parent = discordWebhookTxt;
			discordWebhookTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			discordWebhookTxt.Enabled = false;
			discordWebhookTxt.FillColor = System.Drawing.Color.Black;
			discordWebhookTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			discordWebhookTxt.FocusedState.Parent = discordWebhookTxt;
			discordWebhookTxt.Font = new System.Drawing.Font("Segoe UI", 9f);
			discordWebhookTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			discordWebhookTxt.HoverState.Parent = discordWebhookTxt;
			discordWebhookTxt.Location = new System.Drawing.Point(7, 44);
			discordWebhookTxt.Name = "discordWebhookTxt";
			discordWebhookTxt.PasswordChar = '\0';
			discordWebhookTxt.PlaceholderText = "";
			discordWebhookTxt.SelectedText = "";
			discordWebhookTxt.ShadowDecoration.Parent = discordWebhookTxt;
			discordWebhookTxt.Size = new System.Drawing.Size(745, 36);
			discordWebhookTxt.TabIndex = 1;
			guna2GroupBox21.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox21.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox21.BorderThickness = 3;
			guna2GroupBox21.Controls.Add(guna2HtmlLabel2);
			guna2GroupBox21.Controls.Add(saveFileSwitch);
			guna2GroupBox21.Controls.Add(guna2HtmlLabel1);
			guna2GroupBox21.Controls.Add(saveDiscordSwitch);
			guna2GroupBox21.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox21.CustomBorderThickness = new System.Windows.Forms.Padding(0);
			guna2GroupBox21.FillColor = System.Drawing.Color.Black;
			guna2GroupBox21.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox21.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox21.Location = new System.Drawing.Point(765, 97);
			guna2GroupBox21.Name = "guna2GroupBox21";
			guna2GroupBox21.ShadowDecoration.Parent = guna2GroupBox21;
			guna2GroupBox21.Size = new System.Drawing.Size(185, 87);
			guna2GroupBox21.TabIndex = 6;
			guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
			guna2HtmlLabel2.Location = new System.Drawing.Point(53, 47);
			guna2HtmlLabel2.Name = "guna2HtmlLabel2";
			guna2HtmlLabel2.Size = new System.Drawing.Size(63, 15);
			guna2HtmlLabel2.TabIndex = 3;
			guna2HtmlLabel2.Text = "Save To File";
			saveFileSwitch.Checked = true;
			saveFileSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			saveFileSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
			saveFileSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
			saveFileSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
			saveFileSwitch.CheckedState.Parent = saveFileSwitch;
			saveFileSwitch.Enabled = false;
			saveFileSwitch.Location = new System.Drawing.Point(129, 44);
			saveFileSwitch.Name = "saveFileSwitch";
			saveFileSwitch.ShadowDecoration.Parent = saveFileSwitch;
			saveFileSwitch.Size = new System.Drawing.Size(40, 25);
			saveFileSwitch.TabIndex = 2;
			saveFileSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(125, 137, 149);
			saveFileSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(125, 137, 149);
			saveFileSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
			saveFileSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
			saveFileSwitch.UncheckedState.Parent = saveFileSwitch;
			guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			guna2HtmlLabel1.Location = new System.Drawing.Point(29, 17);
			guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			guna2HtmlLabel1.Size = new System.Drawing.Size(83, 15);
			guna2HtmlLabel1.TabIndex = 1;
			guna2HtmlLabel1.Text = "Send To Discord";
			saveDiscordSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			saveDiscordSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
			saveDiscordSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
			saveDiscordSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
			saveDiscordSwitch.CheckedState.Parent = saveDiscordSwitch;
			saveDiscordSwitch.Enabled = false;
			saveDiscordSwitch.Location = new System.Drawing.Point(129, 13);
			saveDiscordSwitch.Name = "saveDiscordSwitch";
			saveDiscordSwitch.ShadowDecoration.Parent = saveDiscordSwitch;
			saveDiscordSwitch.Size = new System.Drawing.Size(40, 25);
			saveDiscordSwitch.TabIndex = 0;
			saveDiscordSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(125, 137, 149);
			saveDiscordSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(125, 137, 149);
			saveDiscordSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
			saveDiscordSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
			saveDiscordSwitch.UncheckedState.Parent = saveDiscordSwitch;
			guna2Separator3.FillColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2Separator3.FillStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			guna2Separator3.Location = new System.Drawing.Point(6, 474);
			guna2Separator3.Name = "guna2Separator3";
			guna2Separator3.Size = new System.Drawing.Size(939, 10);
			guna2Separator3.TabIndex = 13;
			guna2MessageDialog_0.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
			guna2MessageDialog_0.Caption = null;
			guna2MessageDialog_0.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
			guna2MessageDialog_0.Parent = null;
			guna2MessageDialog_0.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
			guna2MessageDialog_0.Text = null;
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			BackColor = System.Drawing.Color.FromArgb(15, 52, 96);
			base.Controls.Add(guna2Separator3);
			base.Controls.Add(guna2GroupBox21);
			base.Controls.Add(guna2GroupBox20);
			base.Controls.Add(settingSaveBtn);
			base.Controls.Add(guna2GroupBox19);
			base.Controls.Add(guna2GroupBox18);
			base.Controls.Add(guna2GroupBox17);
			base.Controls.Add(guna2GroupBox16);
			base.Controls.Add(vVahmlPppb);
			base.Controls.Add(guna2GroupBox14);
			base.Controls.Add(guna2GroupBox13);
			base.Controls.Add(guna2GroupBox15);
			base.Controls.Add(guna2GroupBox12);
			base.Controls.Add(guna2Separator1);
			base.Controls.Add(guna2GroupBox11);
			base.Controls.Add(guna2GroupBox10);
			base.Controls.Add(guna2GroupBox9);
			base.Controls.Add(guna2GroupBox8);
			base.Controls.Add(guna2GroupBox7);
			base.Controls.Add(guna2GroupBox6);
			base.Controls.Add(guna2GroupBox5);
			base.Controls.Add(guna2GroupBox4);
			base.Controls.Add(guna2GroupBox3);
			base.Controls.Add(guna2GroupBox2);
			base.Controls.Add(guna2GroupBox1);
			base.Name = "Settings";
			base.Size = new System.Drawing.Size(958, 592);
			base.Load += new System.EventHandler(Settings_Load);
			guna2GroupBox1.ResumeLayout(false);
			guna2GroupBox2.ResumeLayout(false);
			guna2GroupBox2.PerformLayout();
			guna2GroupBox3.ResumeLayout(false);
			guna2GroupBox3.PerformLayout();
			guna2GroupBox4.ResumeLayout(false);
			guna2GroupBox4.PerformLayout();
			guna2GroupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)threadsCounter).EndInit();
			guna2GroupBox6.ResumeLayout(false);
			guna2GroupBox7.ResumeLayout(false);
			guna2GroupBox8.ResumeLayout(false);
			guna2GroupBox9.ResumeLayout(false);
			guna2GroupBox10.ResumeLayout(false);
			guna2GroupBox11.ResumeLayout(false);
			guna2GroupBox12.ResumeLayout(false);
			guna2GroupBox15.ResumeLayout(false);
			guna2GroupBox13.ResumeLayout(false);
			guna2GroupBox14.ResumeLayout(false);
			guna2GroupBox16.ResumeLayout(false);
			guna2GroupBox17.ResumeLayout(false);
			guna2GroupBox18.ResumeLayout(false);
			guna2GroupBox19.ResumeLayout(false);
			guna2GroupBox20.ResumeLayout(false);
			guna2GroupBox21.ResumeLayout(false);
			guna2GroupBox21.PerformLayout();
			ResumeLayout(false);
		}
	}
}
