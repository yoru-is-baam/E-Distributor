using System.Linq;
using DAL;

namespace StaffForms.Class.ValidationStrategy
{
	public class UsernameValidationStrategy : IValidationStrategy
	{
		private readonly E_DistributorEntities _dbContext;

		public UsernameValidationStrategy(E_DistributorEntities dbContext)
		{
			_dbContext = dbContext;
		}

		public bool Validate(string data)
		{
			var account = _dbContext.Accounts.FirstOrDefault((a) => a.Username == data);

			return account != null;
		}
	}
}
