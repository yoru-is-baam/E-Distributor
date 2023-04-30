namespace StaffForms.Class.Command
{
	public class ResetCommand : ICommand
	{
		private readonly ItemInformationControl _itemInformationControl;

		public ResetCommand(ItemInformationControl itemInformationControl)
		{
			_itemInformationControl = itemInformationControl;
		}

		public void Execute()
		{
			_itemInformationControl.ResetInformation();
		}
	}
}
