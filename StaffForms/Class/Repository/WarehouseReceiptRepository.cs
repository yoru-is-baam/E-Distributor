using DAL;

namespace StaffForms.Class.Repository
{
	public class WarehouseReceiptRepository : IWarehouseReceiptRepository
	{
		private readonly E_DistributorEntities _dbContext;

		public WarehouseReceiptRepository(E_DistributorEntities dbContext)
		{
			_dbContext = dbContext;
		}

		public void AddWarehouseReceipt(WarehouseReceipt warehouseReceipt)
		{
			_dbContext.WarehouseReceipts.Add(warehouseReceipt);
			_dbContext.SaveChanges();
		}
	}
}
