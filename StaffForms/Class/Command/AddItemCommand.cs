namespace StaffForms.Class.Command
{
	public class AddItemCommand : ICommand
	{
		private readonly ItemList _itemList;
		private readonly Item _item;

		public AddItemCommand(ItemList itemList, Item item)
		{
			_itemList = itemList;
			_item = item;
		}

		public void Execute()
		{
			_itemList.AddItem(_item);
		}
	}
}
