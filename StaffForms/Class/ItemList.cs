using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StaffForms.Class
{
	public class ItemList
	{
		private readonly DataGridView _dataGridView;

		public ItemList(DataGridView dataGridView)
		{
			_dataGridView = dataGridView;
		}

		public void AddItem(Item item)
		{
			// Check if an item with the same name already exists in the DataGridView
			int rowIndex = FindItemRowIndex(item.Name);

			if (rowIndex >= 0)
			{
				// Update the data of the existing item
				_dataGridView.Rows[rowIndex].Cells[1].Value = item.Price;
				_dataGridView.Rows[rowIndex].Cells[2].Value = item.Quantity;
			}
			else
			{
				// Add a new row for the item
				_dataGridView.Rows.Add(item.Name, item.Price, item.Quantity);
			}
		}

		private int FindItemRowIndex(string itemName)
		{
			foreach (DataGridViewRow row in _dataGridView.Rows)
			{
				// Case insensitive
				// data grid view has one null row
				if (row.Cells[0].Value != null && string.Equals(row.Cells[0].Value.ToString(), itemName,
					    StringComparison.OrdinalIgnoreCase))
				{
					return row.Index;
				}
			}

			return -1;
		}

		public void ClearItemList()
		{
			_dataGridView.Rows.Clear();
			_dataGridView.Refresh();
		}

		public Item GetItem(DataGridViewCellEventArgs eventArgs)
		{
			if (eventArgs.RowIndex < 0)
			{
				throw new IndexOutOfRangeException("Can't get item from this cell");
			}

			var row = _dataGridView.Rows[eventArgs.RowIndex];

			if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null)
			{
				throw new NullReferenceException("Can't get item from an empty cell.");
			}

			var name = row.Cells[0].Value.ToString();
			var price = int.Parse(row.Cells[1].Value.ToString());
			var quantity = int.Parse(row.Cells[2].Value.ToString());

			return new Item() { Name = name, Price = price, Quantity = quantity };
		}

		public List<Item> GetItemsAsList()
		{
			var items = new List<Item>();

			foreach (DataGridViewRow row in _dataGridView.Rows)
			{
				if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null) continue;

				var item = new Item
				{
					Name = row.Cells[0].Value.ToString(),
					Price = int.Parse(row.Cells[1].Value.ToString()),
					Quantity = int.Parse(row.Cells[2].Value.ToString())
				};

				items.Add(item);
			}

			return items;
		}

		public void ShowItemsInDataGridView(List<Item> items)
		{
			// Clear any existing data from the DataGridView
			_dataGridView.Rows.Clear();

			// Add each item to the DataGridView
			foreach (var item in items)
			{
				_dataGridView.Rows.Add(item.Name, item.Price, item.Quantity);
			}
		}

		public int GetTotalPrice()
		{
			var totalPrice = 0;

			foreach (DataGridViewRow row in _dataGridView.Rows)
			{
				if (row.Cells[1].Value == null || row.Cells[2].Value == null) continue;

				var price = int.Parse(row.Cells[1].Value.ToString());
				var quantity = int.Parse(row.Cells[2].Value.ToString());

				totalPrice += price * quantity;
			}

			return totalPrice;
		}

		public int GetTotalQuantity()
		{
			var totalQuantity = 0;

			foreach (DataGridViewRow row in _dataGridView.Rows)
			{
				if (row.Cells[2].Value == null) continue;

				var quantity = Convert.ToInt32(row.Cells[2].Value);
				totalQuantity += quantity;
			}

			return totalQuantity;
		}
	}
}