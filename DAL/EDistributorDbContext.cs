namespace DAL
{
	public class EDistributorDbContext
	{
		private static E_DistributorEntities _instance;

		private EDistributorDbContext()
		{

		}

		public static E_DistributorEntities Instance => _instance ?? (_instance = new E_DistributorEntities());
	}
}
