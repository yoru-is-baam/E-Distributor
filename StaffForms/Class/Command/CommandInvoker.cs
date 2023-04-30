namespace StaffForms.Class.Command
{
	public class CommandInvoker
	{
		private ICommand _command;

		public ICommand Command
		{
			set => _command = value;
		}

		public void Execute()
		{
			_command.Execute();
		}
	}
}
