using System.Windows.Forms;

namespace StaffForms.Class
{
	public class ItemInformationControl
	{
		private readonly TextBox _nameBox;
		private readonly TextBox _priceBox;
		private readonly TextBox _quantityBox;

		public ItemInformationControl(TextBox nameBox, TextBox priceBox, TextBox quantityBox)
		{
			_nameBox = nameBox;
			_priceBox = priceBox;
			_quantityBox = quantityBox;
		}

		public void ResetInformation()
		{
			_nameBox.Text = "";
			_priceBox.Text = "";
			_quantityBox.Text = "";
			_nameBox.Focus();
		}

		public void ShowInformation(Item item)
		{
			_nameBox.Text = item.Name;
			_priceBox.Text = item.Price.ToString();
			_quantityBox.Text = item.Quantity.ToString();
		}
	}
}
