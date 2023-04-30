using System.Collections.Generic;
using DAL;
using System.Data.Entity;
using System.Linq;

namespace StaffForms.Class.Repository
{
	public class ItemRepository : IItemRepository
	{
		private readonly E_DistributorEntities _dbContext;

		public ItemRepository(E_DistributorEntities dbContext)
		{
			_dbContext = dbContext;
		}

		public void AddItem(DAL.Item item)
		{
			_dbContext.Items.Add(item);
			_dbContext.SaveChanges();
		}

		public List<int> AddItems(List<Item> items)
		{
			var itemIds = new List<int>();

			foreach (var item in items)
			{
				var existingItem = GetItemByName(item.Name);

				if (existingItem != null)
				{
					// Update existing item with new quantity and price
					existingItem.Quantity += item.Quantity;
					existingItem.Price = item.Price;

					UpdateItem(existingItem);
					itemIds.Add(existingItem.ItemId);
				}
				else
				{
					var dalItem = new DAL.Item()
					{
						Name = item.Name,
						Price = item.Price,
						Quantity = item.Quantity
					};

					AddItem(dalItem);
					itemIds.Add(dalItem.ItemId);
				}
			}

			return itemIds;
		}

		public void UpdateItem(DAL.Item item)
		{
			_dbContext.Entry(item).State = EntityState.Modified;
			_dbContext.SaveChanges();
		}

		public DAL.Item GetItemByName(string name)
		{
			return _dbContext.Items.SingleOrDefault(i => i.Name == name);
		}
	}
}
