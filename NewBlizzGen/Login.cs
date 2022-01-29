using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using NewBlizzGen.Properties;

namespace NewBlizzGen
{
	public class Login : Form
	{
		private IContainer icontainer_0;

		private Guna2BorderlessForm guna2BorderlessForm_0;

		private Guna2GroupBox guna2GroupBox1;

		private Guna2TextBox licenceTxt;

		private Guna2ControlBox guna2ControlBox1;

		private Guna2Button LoginBTN;

		private Guna2DragControl guna2DragControl_0;

		private Guna2AnimateWindow guna2AnimateWindow_0;

		public Guna2MessageDialog LoginMessageBox;


		public Login()
		{
			InitializeComponent();
			licenceTxt.Text = NewBlizzGen.Properties.Settings.Default.license;
		}

		private void LoginBTN_Click(object sender, EventArgs e)
		{
			if (!(licenceTxt.Text == ""))
			{
				if (Verify(licenceTxt.Text))
				{
					NewBlizzGen.Properties.Settings.Default.license = licenceTxt.Text;
					NewBlizzGen.Properties.Settings.Default.Save();
					base.DialogResult = DialogResult.OK;
				}
			}
			else
			{
				LoginMessageBox.Caption = "License Error";
				LoginMessageBox.Text = "Enter your license key first!";
				LoginMessageBox.Show();
			}
		}

		public bool Verify(string key)
		{
			Class0 @class = new Class0(key);
			Class0.Class5 class2 = null;
			Class0.Class6 class3 = null;
			Class0.Class2<Class0.Class5, Class0.Class4> class4 = @class.method_0(key, GetHwid());
			if (!class4.Meta.Valid)
			{
				class2 = class4.Data;
				switch (class4.Meta.Constant)
				{
				case "NO_MACHINE":
					class3 = @class.method_1(class2.ID, GetHwid(), "prod-913ec97188b17dcc144a2197f1c2013f2bce33859761613e56278822c0b0f5f3v3").Data;
					Console.WriteLine("[INFO] [ActivateDevice] DeviceId={0} LicenseId={1}", class3.ID, class2.ID);
					class4 = @class.method_0(key, GetHwid());
					if (class4.Meta.Valid)
					{
						return true;
					}
					goto default;
				default:
					return false;
				case "NOT_FOUND":
					LoginMessageBox.Caption = "License Error";
					LoginMessageBox.Text = key + " " + class4.Meta.Detail;
					LoginMessageBox.Show();
					return false;
				case "EXPIRED":
					LoginMessageBox.Caption = "License Error";
					LoginMessageBox.Text = key + " " + class4.Meta.Detail;
					LoginMessageBox.Show();
					return false;
				case "FINGERPRINT_SCOPE_MISMATCH":
					LoginMessageBox.Caption = "HWID Error";
					LoginMessageBox.Text = "HWID does not match! Needs reset!";
					LoginMessageBox.Show();
					return false;
				}
			}
			return true;
		}

		public static string GetHwid()
		{
			string text = "";
			ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher("Select ProcessorId From Win32_processor").Get();
			string text2 = "";
			foreach (ManagementObject item in managementObjectCollection)
			{
				text2 = item["ProcessorId"].ToString();
			}
			using SHA256 sHA = SHA256.Create();
			string s = text2;
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			text = ToHexStr(sHA.ComputeHash(bytes));
			Console.WriteLine(text);
			return text;
		}

		public static string ToHexStr(byte[] hash)
		{
			StringBuilder stringBuilder = new StringBuilder(hash.Length * 2);
			foreach (byte b in hash)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBlizzGen.Login));
			guna2BorderlessForm_0 = new Guna.UI2.WinForms.Guna2BorderlessForm(icontainer_0);
			guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			licenceTxt = new Guna.UI2.WinForms.Guna2TextBox();
			LoginBTN = new Guna.UI2.WinForms.Guna2Button();
			guna2DragControl_0 = new Guna.UI2.WinForms.Guna2DragControl(icontainer_0);
			guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			guna2AnimateWindow_0 = new Guna.UI2.WinForms.Guna2AnimateWindow(icontainer_0);
			LoginMessageBox = new Guna.UI2.WinForms.Guna2MessageDialog();
			guna2GroupBox1.SuspendLayout();
			SuspendLayout();
			guna2BorderlessForm_0.ContainerControl = this;
			guna2BorderlessForm_0.DockIndicatorTransparencyValue = 0.6;
			guna2BorderlessForm_0.TransparentWhileDrag = true;
			guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
			guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox1.BorderThickness = 3;
			guna2GroupBox1.Controls.Add(licenceTxt);
			guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2GroupBox1.FillColor = System.Drawing.Color.Black;
			guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
			guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
			guna2GroupBox1.Location = new System.Drawing.Point(113, 43);
			guna2GroupBox1.Name = "guna2GroupBox1";
			guna2GroupBox1.ShadowDecoration.Parent = guna2GroupBox1;
			guna2GroupBox1.Size = new System.Drawing.Size(304, 87);
			guna2GroupBox1.TabIndex = 1;
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
			LoginBTN.CheckedState.Parent = LoginBTN;
			LoginBTN.CustomImages.Parent = LoginBTN;
			LoginBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			LoginBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			LoginBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			LoginBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			LoginBTN.DisabledState.Parent = LoginBTN;
			LoginBTN.FillColor = System.Drawing.Color.FromArgb(22, 33, 62);
			LoginBTN.Font = new System.Drawing.Font("Segoe UI", 9f);
			LoginBTN.ForeColor = System.Drawing.Color.White;
			LoginBTN.HoverState.Parent = LoginBTN;
			LoginBTN.Location = new System.Drawing.Point(175, 149);
			LoginBTN.Name = "LoginBTN";
			LoginBTN.ShadowDecoration.Parent = LoginBTN;
			LoginBTN.Size = new System.Drawing.Size(180, 42);
			LoginBTN.TabIndex = 13;
			LoginBTN.Text = "Login";
			LoginBTN.Click += new System.EventHandler(LoginBTN_Click);
			guna2DragControl_0.DockIndicatorTransparencyValue = 0.6;
			guna2DragControl_0.TargetControl = this;
			guna2DragControl_0.UseTransparentDrag = true;
			guna2ControlBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(22, 33, 62);
			guna2ControlBox1.HoverState.Parent = guna2ControlBox1;
			guna2ControlBox1.IconColor = System.Drawing.Color.White;
			guna2ControlBox1.Location = new System.Drawing.Point(482, 3);
			guna2ControlBox1.Name = "guna2ControlBox1";
			guna2ControlBox1.ShadowDecoration.Parent = guna2ControlBox1;
			guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
			guna2ControlBox1.TabIndex = 14;
			guna2AnimateWindow_0.TargetForm = this;
			LoginMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
			LoginMessageBox.Caption = null;
			LoginMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
			LoginMessageBox.Parent = this;
			LoginMessageBox.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
			LoginMessageBox.Text = null;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(15, 52, 96);
			base.ClientSize = new System.Drawing.Size(530, 229);
			base.Controls.Add(guna2ControlBox1);
			base.Controls.Add(LoginBTN);
			base.Controls.Add(guna2GroupBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Login";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Form2";
			guna2GroupBox1.ResumeLayout(false);
			ResumeLayout(false);
		}
	}
}
