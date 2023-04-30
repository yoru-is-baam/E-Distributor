using System;
using System.Windows;

namespace StaffForms.Class.Command
{
	public class SelectQRCommand : ICommand
	{
		private readonly ItemList _itemList;
		private readonly QRCoderManager _manager;
		private readonly Action<string> _callback;

		public SelectQRCommand(QRCoderManager manager, ItemList itemList, Action<string> callback)
		{
			_manager = manager;
			_itemList = itemList;
			_callback = callback;
		}

		public void Execute()
		{
			try
			{
				QRData qrData = _manager.GetQRData();
			
				if (qrData == null) return;

				_callback(qrData.AccountantId);
				_itemList.ShowItemsInDataGridView(qrData.Items);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
