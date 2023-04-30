using System;
using System.Windows.Forms;
using DAL;
using StaffForms.Class.Command;
using StaffForms.Class;
using Account = StaffForms.Class.Account;

namespace StaffForms
{
	public partial class QRCodeScannerForm : Form
	{
		private ICommand _command;
		private string _accountantId;
		private readonly Account _account;
		private readonly ItemList _itemList;
		private readonly CommandInvoker _invoker;

		public QRCodeScannerForm(Account account)
		{
			InitializeComponent();

			_account = account;
			_invoker = new CommandInvoker();
			_itemList = new ItemList(DataGridView);
		}

		private void QRCodeScannerForm_Load(object sender, EventArgs e)
		{
			BtnUpdate.Enabled = false;
		}

		private void BtnSelectQR_Click(object sender, EventArgs e)
		{
			_command = new SelectQRCommand(QRCoderManager.Instance, _itemList, SetAccountantId);
			_invoker.Command = _command;
			_invoker.Execute();
		}

		private void SetAccountantId(string accountantId)
		{
			_accountantId = accountantId;
		}

		private void BtnLogout_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void QRCodeScannerForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Program.LoginForm.Show();
		}

		private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			BtnUpdate.Enabled = true;
		}

		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			var warehouseReceipt = new WarehouseReceipt()
			{
				TotalQuantity = _itemList.GetTotalQuantity(),
				TotalPrice = _itemList.GetTotalPrice(),
				CreatedAt = DateTime.Today,
				WarehouseStaffId = _account.EmployeeId,
				AccountantId = _accountantId
			};

			_command = new UpdateCommand(_itemList, warehouseReceipt);
			_invoker.Command = _command;
			_invoker.Execute();

			BtnUpdate.Enabled = false;
			MessageBox.Show("Update successfully!");
		}
	}
}
