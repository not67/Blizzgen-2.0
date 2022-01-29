using System;
using System.ComponentModel;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using Guna.UI2.WinForms;
using NewBlizzGen.Properties;

namespace NewBlizzGen
{
	public class Form1 : Form
	{
		private static System.Timers.Timer timer_0;

		private IContainer icontainer_0;

		private Guna2Panel guna2Panel_0;

		private Guna2Panel guna2Panel_1;

		private Guna2ControlBox guna2ControlBox1;

		private Guna2DragControl guna2DragControl_0;

		private Guna2DragControl guna2DragControl_1;

		private Guna2Button guna2Button_0;

		private Guna2Button guna2Button_1;

		private Guna2HtmlLabel guna2HtmlLabel1;

		private Guna2PictureBox guna2PictureBox1;

		private Guna2Elipse guna2Elipse_0;

		private Guna2CustomGradientPanel mainPanel;

		private Guna2GroupBox guna2GroupBox1;

		private Guna2GroupBox guna2GroupBox19;

		private Guna2HtmlLabel ydsduQiHB;

		public Guna2HtmlLabel FailedRecord;
        private IContainer components;
        public Guna2HtmlLabel SuccessRecord;

		public Form1()
		{
			InitializeComponent();
			mainPanel.Controls.Clear();
			Generate value = new Generate();
			mainPanel.Controls.Add(value);
			guna2Button_0.Checked = true;
			SuccessRecord.Text = NewBlizzGen.Properties.Settings.Default.success.ToString();
			FailedRecord.Text = NewBlizzGen.Properties.Settings.Default.failed.ToString();
			AutoUpdater.Start("https://help.ricochetcheats.com/BlizzGen.xml");
			new System.Timers.Timer(10000.0).Elapsed += method_0;
		}

		private void method_0(object sender, ElapsedEventArgs e)
		{
			SuccessRecord.Text = NewBlizzGen.Properties.Settings.Default.success.ToString();
			FailedRecord.Text = NewBlizzGen.Properties.Settings.Default.failed.ToString();
		}

		private void guna2Button_1_Click(object sender, EventArgs e)
		{
			guna2Button_0.Checked = false;
			Settings value = new Settings();
			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(value);
			guna2Button_1.Checked = true;
		}

		private void guna2Button_0_Click(object sender, EventArgs e)
		{
			guna2Button_1.Checked = false;
			Generate value = new Generate();
			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(value);
			guna2Button_0.Checked = true;
		}

		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(Environment.ExitCode);
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Panel_0 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button_1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_0 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel_1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.FailedRecord = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox19 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.SuccessRecord = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ydsduQiHB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl_0 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl_1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse_0 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.mainPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Panel_0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel_1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox19.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel_0
            // 
            this.guna2Panel_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.guna2Panel_0.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel_0.Controls.Add(this.guna2Button_1);
            this.guna2Panel_0.Controls.Add(this.guna2Button_0);
            this.guna2Panel_0.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel_0.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel_0.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel_0.Name = "guna2Panel_0";
            this.guna2Panel_0.ShadowDecoration.Parent = this.guna2Panel_0;
            this.guna2Panel_0.Size = new System.Drawing.Size(124, 638);
            this.guna2Panel_0.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Properties.Resources.Bnet_logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(8, 19);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(100, 79);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Button_1
            // 
            this.guna2Button_1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.guna2Button_1.CheckedState.Parent = this.guna2Button_1;
            this.guna2Button_1.CustomImages.Parent = this.guna2Button_1;
            this.guna2Button_1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_1.DisabledState.Parent = this.guna2Button_1;
            this.guna2Button_1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.guna2Button_1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_1.ForeColor = System.Drawing.Color.White;
            this.guna2Button_1.HoverState.Parent = this.guna2Button_1;
            this.guna2Button_1.Location = new System.Drawing.Point(0, 171);
            this.guna2Button_1.Name = "guna2Button_1";
            this.guna2Button_1.ShadowDecoration.Parent = this.guna2Button_1;
            this.guna2Button_1.Size = new System.Drawing.Size(124, 42);
            this.guna2Button_1.TabIndex = 1;
            this.guna2Button_1.Text = "Settings";
            this.guna2Button_1.Click += new System.EventHandler(this.guna2Button_1_Click);
            // 
            // guna2Button_0
            // 
            this.guna2Button_0.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_0.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.guna2Button_0.CheckedState.Parent = this.guna2Button_0;
            this.guna2Button_0.CustomImages.Parent = this.guna2Button_0;
            this.guna2Button_0.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_0.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_0.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_0.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_0.DisabledState.Parent = this.guna2Button_0;
            this.guna2Button_0.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.guna2Button_0.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_0.ForeColor = System.Drawing.Color.White;
            this.guna2Button_0.HoverState.Parent = this.guna2Button_0;
            this.guna2Button_0.Location = new System.Drawing.Point(0, 123);
            this.guna2Button_0.Name = "guna2Button_0";
            this.guna2Button_0.ShadowDecoration.Parent = this.guna2Button_0;
            this.guna2Button_0.Size = new System.Drawing.Size(124, 42);
            this.guna2Button_0.TabIndex = 0;
            this.guna2Button_0.Text = "Generate";
            this.guna2Button_0.Click += new System.EventHandler(this.guna2Button_0_Click);
            // 
            // guna2Panel_1
            // 
            this.guna2Panel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.guna2Panel_1.Controls.Add(this.guna2GroupBox1);
            this.guna2Panel_1.Controls.Add(this.guna2GroupBox19);
            this.guna2Panel_1.Controls.Add(this.ydsduQiHB);
            this.guna2Panel_1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel_1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel_1.Location = new System.Drawing.Point(124, 0);
            this.guna2Panel_1.Name = "guna2Panel_1";
            this.guna2Panel_1.ShadowDecoration.Parent = this.guna2Panel_1;
            this.guna2Panel_1.Size = new System.Drawing.Size(958, 46);
            this.guna2Panel_1.TabIndex = 1;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.FailedRecord);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Maroon;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(797, 5);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(58, 35);
            this.guna2GroupBox1.TabIndex = 17;
            // 
            // FailedRecord
            // 
            this.FailedRecord.BackColor = System.Drawing.Color.Transparent;
            this.FailedRecord.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FailedRecord.ForeColor = System.Drawing.Color.Maroon;
            this.FailedRecord.Location = new System.Drawing.Point(6, 6);
            this.FailedRecord.Name = "FailedRecord";
            this.FailedRecord.Size = new System.Drawing.Size(12, 22);
            this.FailedRecord.TabIndex = 1;
            this.FailedRecord.Text = "0";
            // 
            // guna2GroupBox19
            // 
            this.guna2GroupBox19.BorderThickness = 2;
            this.guna2GroupBox19.Controls.Add(this.SuccessRecord);
            this.guna2GroupBox19.CustomBorderColor = System.Drawing.Color.Green;
            this.guna2GroupBox19.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox19.FillColor = System.Drawing.Color.Black;
            this.guna2GroupBox19.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox19.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox19.Location = new System.Drawing.Point(733, 5);
            this.guna2GroupBox19.Name = "guna2GroupBox19";
            this.guna2GroupBox19.ShadowDecoration.Parent = this.guna2GroupBox19;
            this.guna2GroupBox19.Size = new System.Drawing.Size(58, 35);
            this.guna2GroupBox19.TabIndex = 16;
            // 
            // SuccessRecord
            // 
            this.SuccessRecord.BackColor = System.Drawing.Color.Transparent;
            this.SuccessRecord.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessRecord.ForeColor = System.Drawing.Color.Green;
            this.SuccessRecord.Location = new System.Drawing.Point(6, 6);
            this.SuccessRecord.Name = "SuccessRecord";
            this.SuccessRecord.Size = new System.Drawing.Size(12, 22);
            this.SuccessRecord.TabIndex = 0;
            this.SuccessRecord.Text = "0";
            // 
            // ydsduQiHB
            // 
            this.ydsduQiHB.BackColor = System.Drawing.Color.Transparent;
            this.ydsduQiHB.Location = new System.Drawing.Point(148, 16);
            this.ydsduQiHB.Name = "ydsduQiHB";
            this.ydsduQiHB.Size = new System.Drawing.Size(42, 15);
            this.ydsduQiHB.TabIndex = 2;
            this.ydsduQiHB.Text = " <div style=\"color:red\">beta 0.1</div>";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(13, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(149, 27);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "BlizzGen v2.0";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(901, 8);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2DragControl_0
            // 
            this.guna2DragControl_0.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl_0.TargetControl = this.guna2Panel_0;
            this.guna2DragControl_0.UseTransparentDrag = true;
            // 
            // guna2DragControl_1
            // 
            this.guna2DragControl_1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl_1.TargetControl = this.guna2Panel_1;
            this.guna2DragControl_1.UseTransparentDrag = true;
            // 
            // guna2Elipse_0
            // 
            this.guna2Elipse_0.BorderRadius = 2;
            this.guna2Elipse_0.TargetControl = this;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.mainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.mainPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.mainPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.mainPanel.Location = new System.Drawing.Point(124, 46);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(958, 592);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 638);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.guna2Panel_1);
            this.Controls.Add(this.guna2Panel_0);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlizzGen 2.0";
            this.guna2Panel_0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel_1.ResumeLayout(false);
            this.guna2Panel_1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox19.ResumeLayout(false);
            this.guna2GroupBox19.PerformLayout();
            this.ResumeLayout(false);

		}

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
