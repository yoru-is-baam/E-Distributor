using System.Windows.Forms;

namespace StaffForms.Class.Command
{
	public class ResetAllCommand : ICommand
	{
		private readonly ItemList _itemList;
		private readonly ItemInformationControl _itemInformationControl;

		public ResetAllCommand(ItemList itemList, ItemInformationControl itemInformationControl)
		{
			_itemList = itemList;
			_itemInformationControl = itemInformationControl;
		}

		public void Execute()
		{
			var result = MessageBox.Show("Are you sure you want to reset all items?", "Confirm reset", MessageBoxButtons.YesNo);

			if (result != DialogResult.Yes) return;

			_itemList.ClearItemList();
			_itemInformationControl.ResetInformation();
		}
	}
}
