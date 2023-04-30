using DAL;
using StaffForms.Class.Repository;
using System.Collections.Generic;

namespace StaffForms.Class.Facade
{
	public class RepositoryFacade
	{
		private static RepositoryFacade _instance;

		private readonly IItemRepository _itemRepository;
		private readonly IAccountantRepository _accountantRepository;
		private readonly IWarehouseStaffRepository _warehouseStaffRepository;
		private readonly IWarehouseReceiptRepository _warehouseReceiptRepository;
		private readonly IIncludeImportedItemsRepository _includeImportedItemsRepository;

		private RepositoryFacade()
		{
			_itemRepository = new ItemRepository(EDistributorDbContext.Instance);
			_accountantRepository = new AccountantRepository(EDistributorDbContext.Instance);
			_warehouseStaffRepository = new WarehouseStaffRepository(EDistributorDbContext.Instance);
			_warehouseReceiptRepository = new WarehouseReceiptRepository(EDistributorDbContext.Instance);
			_includeImportedItemsRepository = new IncludeImportedItemsRepository(EDistributorDbContext.Instance);
		}

		public static RepositoryFacade Instance => _instance ?? (_instance = new RepositoryFacade());

		public void AddFullyWarehouseReceipt(WarehouseReceipt warehouseReceipt, List<Item> items)
		{
			var itemIds = _itemRepository.AddItems(items);
			
			_warehouseReceiptRepository.AddWarehouseReceipt(warehouseReceipt);
			_includeImportedItemsRepository.AddIncludeImportedItems(itemIds, warehouseReceipt.WarehouseReceiptId, items);
		}

		public string GetEmployeeIdByRole(Account account)
		{
			if (account.Role == "Accountant")
			{
				return _accountantRepository.GetAccountantId(account.AccountId);
			}
			else if (account.Role == "WarehouseStaff")
			{
				return _warehouseStaffRepository.GetWarehouseStaffId(account.AccountId);
			}

			return null;
		}
	}
}
