using NaaAdjekai1HRM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaaAdjekaiHRM.Client.Pages
{
	public partial class EmployeeOverview
	{

		public IEnumerable<Employee> Employees { get; set; }

		public List<Country> Countries { get; set; }

		public List<JobCategory> JobCategories { get; set; }

        protected override Task OnInitializedAsync()
        {
			InitializeCountries();
			InitializeJobCategories();
			InitializeEmployees();

            return base.OnInitializedAsync();
        }

        private void InitializeJobCategories()
		{
			JobCategories = new List<JobCategory>()
			{
				new JobCategory{JobCategoryId = 1, JobCategoryName = "Web research"},
				new JobCategory{JobCategoryId = 2, JobCategoryName = "Sales"},
				new JobCategory{JobCategoryId = 3, JobCategoryName = "Management"},
				new JobCategory{JobCategoryId = 4, JobCategoryName = "Grapics Designer"},
				new JobCategory{JobCategoryId = 5, JobCategoryName = "Finance"},
				new JobCategory{JobCategoryId = 6, JobCategoryName = "QA"},
				new JobCategory{JobCategoryId = 7, JobCategoryName = "IT"},
				new JobCategory{JobCategoryId = 8, JobCategoryName = "Cleaning"},
				new JobCategory{JobCategoryId = 9, JobCategoryName = "Software Dev"},
				new JobCategory{JobCategoryId = 9, JobCategoryName = "System Admin"}
			};
		}

		private void InitializeCountries()
		{
			Countries = new List<Country>
			{
				new Country {CountryId = 1, Name = "Ghana"},
				new Country {CountryId = 2, Name = "Nigeria"},
				new Country {CountryId = 3, Name = "Germeny"},
				new Country {CountryId = 4, Name = "Canada"},
				new Country {CountryId = 5, Name = "China"},
				new Country {CountryId = 6, Name = "UK"},
				new Country {CountryId = 7, Name = "France"},
				new Country {CountryId = 8, Name = "Brazil"}
			};
		}

		private void InitializeEmployees()
		{
			var e1 = new Employee
			{
				CountryId = 1,
				MaritalStatus = MaritalStatus.Single,
				BirthDate = new DateTime(1989, 3, 11),
				City = "Koforidua",
				Email = "chris@scynett.com",
				EmployeeId = 1,
				FirstName = "Chris",
				LastName = "A",
				Gender = Gender.Male,
				PhoneNumber = "324777888773",
				Smoker = false,
				Street = "Lindador",
				Zip = "1000",
				JobCategoryId = 1,
				Comment = "Operations Manager",
				ExitDate = null,
				JoinedDate = new DateTime(2015, 3, 1)
			};

			var e2 = new Employee
			{
				CountryId = 2,
				MaritalStatus = MaritalStatus.Married,
				BirthDate = new DateTime(1979, 1, 16),
				City = "Antwerp",
				Email = "sam@scynett.com",
				EmployeeId = 2,
				FirstName = "Sam",
				LastName = "Nartey",
				Gender = Gender.Male,
				PhoneNumber = "33999909923",
				Smoker = false,
				Street = "New Street",
				Zip = "2000",
				JobCategoryId = 1,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2017, 12, 24)
			};
			Employees = new List<Employee> { e1, e2 };
		}
	}
}
