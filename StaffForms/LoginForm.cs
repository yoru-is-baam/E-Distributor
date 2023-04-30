using DAL;
using StaffForms.Class.Facade;
using StaffForms.Class.Factory;
using StaffForms.Class.ValidationStrategy;
using System;
using System.Windows.Forms;
using Account = StaffForms.Class.Account;

namespace StaffForms
{
	public partial class LoginForm : Form
	{
		private Account _account;
		private readonly E_DistributorEntities _dbContext;
		private readonly RepositoryFacade _repositoryFacade;
		private readonly ValidationContext _validationContext;

		public LoginForm()
		{
			InitializeComponent();

			_dbContext = EDistributorDbContext.Instance;
			_validationContext = new ValidationContext();
			_repositoryFacade = RepositoryFacade.Instance;
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			_account = new Account.AccountBuilder(UsernameBox.Text).Build();

			if (!IsAccountValid()) return;

			_account.EmployeeId = _repositoryFacade.GetEmployeeIdByRole(_account);

			var form = FormFactory.GetForm(_account);
			
			form.Show();
			this.Hide();
		}

		private bool IsAccountValid()
		{
			_validationContext.SetStrategy(new EmptyValidationStrategy());

			if (!_validationContext.Validate(UsernameBox.Text) || !_validationContext.Validate(PasswordBox.Text))
			{
				MessageBox.Show("Do not leave empty field");
				return false;
			}

			_validationContext.SetStrategy(new UsernameValidationStrategy(_dbContext));

			if (!_validationContext.Validate(UsernameBox.Text))
			{
				MessageBox.Show("Do not have this username");
				return false;
			}

			_validationContext.SetStrategy(new PasswordValidationStrategy(_dbContext, _account));

			if (!_validationContext.Validate(PasswordBox.Text))
			{
				MessageBox.Show("Wrong password");
				return false;
			}

			return true;
		}
	}
}
