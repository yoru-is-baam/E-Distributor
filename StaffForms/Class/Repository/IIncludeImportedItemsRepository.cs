using System.Collections.Generic;
using DAL;

namespace StaffForms.Class.Repository
{
	public interface IIncludeImportedItemsRepository
	{
		void AddIncludeImportedItem(IncludeImportedItem includeImportedItem);
		void AddIncludeImportedItems(List<int> itemIds, int warehouseReceiptId, List<Item> items);
	}
}
