namespace StaffForms.Class.ValidationStrategy
{
	public class ValidationContext
	{
		private IValidationStrategy _strategy;

		public ValidationContext()
		{

		}

		public ValidationContext(IValidationStrategy strategy)
		{
			_strategy = strategy;
		}

		public void SetStrategy(IValidationStrategy strategy)
		{
			_strategy = strategy;
		}

		public bool Validate(string input)
		{
			return _strategy.Validate(input);
		}
	}
}
