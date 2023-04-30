namespace StaffForms.Class.ValidationStrategy
{
	public class IntegerValidationStrategy : IValidationStrategy
	{
		public bool Validate(string data)
		{
			bool isValid = int.TryParse(data, out int result);

			return isValid && result >= 0;
		}
	}
}
