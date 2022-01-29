using System;
using System.Windows.Forms;
using NewBlizzGen;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		if (new Login().ShowDialog() == DialogResult.OK)
		{
			Application.Run(new Form1());
		}
		else
		{
			Application.Exit();
		}
	}
}
