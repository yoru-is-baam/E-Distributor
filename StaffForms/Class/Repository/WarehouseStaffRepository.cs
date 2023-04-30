using DAL;
using System.Linq;

namespace StaffForms.Class.Repository
{
	public class WarehouseStaffRepository : IWarehouseStaffRepository
	{
		private readonly E_DistributorEntities _dbContext;

		public WarehouseStaffRepository(E_DistributorEntities dbContext)
		{
			_dbContext = dbContext;
		}

		public string GetWarehouseStaffId(string accountId)
		{
			var staff = _dbContext.WarehouseStaffs.FirstOrDefault((a) => a.AccountId == accountId);

			return staff?.WarehouseStaffId;
		}
	}
}
