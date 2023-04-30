namespace StaffForms.Class
{
	public class Account
	{
		public string AccountId { get; set; }
		public string Username { get; set; }
		public string Role { get; set; }
		public string EmployeeId { get; set; }

		private Account(string accountId, string username, string role, string employeeId)
		{
			AccountId = accountId;
			Username = username;
			Role = role;
			EmployeeId = employeeId;
		}

		public class AccountBuilder
		{
			private string _accountId;
			private readonly string _username;
			private string _role;
			private string _employeeId;

			public AccountBuilder(string username)
			{
				_username = username;
			}

			public AccountBuilder WithAccountId(string accountId)
			{
				_accountId = accountId;
				return this;
			}

			public AccountBuilder WithRole(string role)
			{
				_role = role;
				return this;
			}

			public AccountBuilder WithEmployeeId(string employeeId)
			{
				_employeeId = employeeId;
				return this;
			}

			public Account Build()
			{
				return new Account(_accountId, _username, _role, _employeeId);
			}
		}
	}
}
