using DAL;
using System.Linq;

namespace StaffForms.Class.ValidationStrategy
{
	public class PasswordValidationStrategy : IValidationStrategy
	{
		private readonly E_DistributorEntities _dbContext;
		private readonly Account _account;

		public PasswordValidationStrategy(E_DistributorEntities dbContext, Account account)
		{
			_dbContext = dbContext;
			_account = account;
		}

		public bool Validate(string password)
		{
			var account = _dbContext.Accounts.FirstOrDefault((a) => a.Username == _account.Username);

			if (account == null) return false;
			if (account.Password != password) return false;
			
			_account.Role = account.Role;
			_account.AccountId = account.AccountId;
			return true;
		}
	}
}
