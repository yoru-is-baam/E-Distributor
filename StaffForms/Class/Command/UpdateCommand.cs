using DAL;
using StaffForms.Class.Facade;

namespace StaffForms.Class.Command
{
	public class UpdateCommand : ICommand
	{
		private readonly ItemList _itemList;
		private readonly WarehouseReceipt _warehouseReceipt;
		private readonly RepositoryFacade _repositoryFacade;

		public UpdateCommand(ItemList itemList, WarehouseReceipt warehouseReceipt)
		{
			_itemList = itemList;
			_warehouseReceipt = warehouseReceipt;
			_repositoryFacade = RepositoryFacade.Instance;
		}

		public void Execute()
		{
			var items = _itemList.GetItemsAsList();

			_repositoryFacade.AddFullyWarehouseReceipt(_warehouseReceipt, items);
			
			_itemList.ClearItemList();
		}
	}
}
