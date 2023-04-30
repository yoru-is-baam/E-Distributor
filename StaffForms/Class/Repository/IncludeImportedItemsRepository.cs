using System.Collections.Generic;
using DAL;

namespace StaffForms.Class.Repository
{
	public class IncludeImportedItemsRepository : IIncludeImportedItemsRepository
	{
		private readonly E_DistributorEntities _dbContext;

		public IncludeImportedItemsRepository(E_DistributorEntities dbContext)
		{
			_dbContext = dbContext;
		}

		public void AddIncludeImportedItem(IncludeImportedItem includeImportedItem)
		{
			_dbContext.IncludeImportedItems.Add(includeImportedItem);
			_dbContext.SaveChanges();
		}

		public void AddIncludeImportedItems(List<int> itemIds, int warehouseReceiptId, List<Item> items)
		{
			for (var i = 0; i < items.Count; i++)
			{
				var includeImportedItem = new IncludeImportedItem()
				{
					ItemId = itemIds[i],
					WarehouseReceiptId = warehouseReceiptId,
					Quantity = items[i].Quantity,
					TotalPrice = items[i].Quantity * items[i].Price
				};

				AddIncludeImportedItem(includeImportedItem);
			}
		}
	}
}
