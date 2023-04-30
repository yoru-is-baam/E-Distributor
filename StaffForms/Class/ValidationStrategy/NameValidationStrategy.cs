using System.Linq;

namespace StaffForms.Class.ValidationStrategy
{
	public class NameValidationStrategy : IValidationStrategy
	{
		public bool Validate(string data)
		{
			return !string.IsNullOrWhiteSpace(data) && data.All(c => char.IsLetterOrDigit(c) || c == ' ');
		}
	}
}
