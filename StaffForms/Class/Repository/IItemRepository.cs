using System.Collections.Generic;

namespace StaffForms.Class.Repository
{
	public interface IItemRepository
	{
		void AddItem(DAL.Item item);
		List<int> AddItems(List<Item> items);
		void UpdateItem(DAL.Item item);
		DAL.Item GetItemByName(string name);
	}
}
