using StaffForms.Class;
using StaffForms.Class.Command;
using StaffForms.Class.ValidationStrategy;
using System;
using System.Windows.Forms;
using Account = StaffForms.Class.Account;
using Item = StaffForms.Class.Item;

namespace StaffForms
{
	public partial class GoodsReceivingForm : Form
	{
		private ICommand _command;
		private readonly Account _account;
		private readonly ItemList _itemList;
		private readonly CommandInvoker _invoker;
		private readonly ValidationContext _validationContext;
		private readonly ItemInformationControl _itemInformationControl;

		public GoodsReceivingForm(Account account)
		{
			InitializeComponent();

			_account = account;
			_invoker = new CommandInvoker();
			_itemList = new ItemList(DataGridView);
			_validationContext = new ValidationContext();
			_itemInformationControl = new ItemInformationControl(NameBox, PriceBox, QuantityBox);
		}

		private void GoodsReceivingForm_Load(object sender, EventArgs e)
		{
			BtnExport.Enabled = false;
			BtnResetAll.Enabled = false;
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			if (!IsItemValid()) return;

			var item = new Item()
				{ Name = NameBox.Text, Price = int.Parse(PriceBox.Text), Quantity = int.Parse(QuantityBox.Text) };

			_command = new AddItemCommand(_itemList, item);
			_invoker.Command = _command;
			_invoker.Execute();

			BtnReset_Click(null, null);

			BtnExport.Enabled = true;
			BtnResetAll.Enabled = true;
		}

		
		private void BtnReset_Click(object sender, EventArgs e)
		{
			_command = new ResetCommand(_itemInformationControl);
			_invoker.Command = _command;
			_invoker.Execute();
		}

		private void BtnResetAll_Click(object sender, EventArgs e)
		{
			_command = new ResetAllCommand(_itemList, _itemInformationControl);
			_invoker.Command = _command;
			_invoker.Execute();

			GoodsReceivingForm_Load(null, null);
		}

		private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			_command = new CellClickCommand(_itemList, _itemInformationControl, e);
			_invoker.Command = _command;
			_invoker.Execute();
		}

		private void BtnExport_Click(object sender, EventArgs e)
		{
			_command = new ExportCommand(_itemList, _account, QRCoderManager.Instance);
			_invoker.Command = _command;
			_invoker.Execute();
		}

		// function
		private bool IsItemValid()
		{
			// Set another strategy
			_validationContext.SetStrategy(new EmptyValidationStrategy());

			if (!_validationContext.Validate(NameBox.Text) || !_validationContext.Validate(PriceBox.Text) || !_validationContext.Validate(QuantityBox.Text))
			{
				MessageBox.Show("Do not leave empty field");
				return false;
			}

			// Set another strategy
			_validationContext.SetStrategy(new IntegerValidationStrategy());

			if (!_validationContext.Validate(PriceBox.Text) || !_validationContext.Validate(QuantityBox.Text))
			{
				MessageBox.Show("Price/Quantity must be number");
				return false;
			}

			// Set another strategy
			_validationContext.SetStrategy(new NameValidationStrategy());

			if (!_validationContext.Validate(NameBox.Text))
			{
				MessageBox.Show("Name must be text or number");
				return false;
			}

			return true;
		}
	}
}
