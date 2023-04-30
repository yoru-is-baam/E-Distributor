using DAL;
using System.Linq;

namespace StaffForms.Class.Repository
{
	public class AccountantRepository : IAccountantRepository
	{
		private readonly E_DistributorEntities _dbContext;

		public AccountantRepository(E_DistributorEntities dbContext)
		{
			_dbContext = dbContext;
		}

		public string GetAccountantId(string accountId)
		{
			var accountant = _dbContext.Accountants.FirstOrDefault((a) => a.AccountId == accountId);

			return accountant?.AccountantId;
		}
	}
}
