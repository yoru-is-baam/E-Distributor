using System;
using System.Windows.Forms;
using StaffForms.Class;

namespace StaffForms
{
	public partial class MainForm : Form
	{
		private GoodsReceivingForm _goodsReceivingForm;
		private readonly Account _account;

		public MainForm(Account account)
		{
			InitializeComponent();

			_account = account;
		}

		private void GoodsReceivingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_goodsReceivingForm == null)
			{
				_goodsReceivingForm = new GoodsReceivingForm(_account);
				_goodsReceivingForm.FormClosed += (s, args) => _goodsReceivingForm = null;
				_goodsReceivingForm.Show();
			}
			else
			{
				_goodsReceivingForm.BringToFront();
			}
		}

		private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Program.LoginForm.Show();

			_goodsReceivingForm?.Close();
		}
	}
}
