using System;
using System.Windows.Forms;

namespace StaffForms.Class.Command
{
	public class CellClickCommand : ICommand
	{
		private readonly ItemList _itemList;
		private readonly ItemInformationControl _itemInformationControl;
		private readonly DataGridViewCellEventArgs _cellEventArgs;

		public CellClickCommand(ItemList itemList, ItemInformationControl itemInformationControl, DataGridViewCellEventArgs eventArgs)
		{
			_itemList = itemList;
			_cellEventArgs = eventArgs;
			_itemInformationControl = itemInformationControl;
		}

		public void Execute()
		{
			try
			{
				var item = _itemList.GetItem(_cellEventArgs);

				_itemInformationControl.ShowInformation(item);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
