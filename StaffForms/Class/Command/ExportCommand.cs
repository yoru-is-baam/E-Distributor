namespace StaffForms.Class.Command
{
	public class ExportCommand : ICommand
	{
		private readonly ItemList _itemList;
		private readonly Account _account;
		private readonly QRCoderManager _manager;

		public ExportCommand(ItemList itemList, Account account, QRCoderManager manager)
		{
			_itemList = itemList;
			_account = account;
			_manager = manager;
		}

		public void Execute()
		{
			var items = _itemList.GetItemsAsList();
			_manager.ExportQRCode(items, _account);
		}
	}
}
