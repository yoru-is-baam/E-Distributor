using System;
using System.Windows.Forms;

namespace StaffForms
{
	internal static class Program
	{
		public static LoginForm LoginForm;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			LoginForm = new LoginForm();
			Application.Run(LoginForm);
		}
	}
}
