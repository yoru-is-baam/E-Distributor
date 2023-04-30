using System;
using System.Windows.Forms;

namespace StaffForms.Class.Factory
{
	public class FormFactory
	{
		private FormFactory()
		{

		}

		public static Form GetForm(Account account)
		{
			switch (account.Role)
			{
				case "Accountant":
					return new MainForm(account);
				case "WarehouseStaff":
					return new QRCodeScannerForm(account);
				default:
					throw new Exception("Invalid role");
			}
		}
	}
}
