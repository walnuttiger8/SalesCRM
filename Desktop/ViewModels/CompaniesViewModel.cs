using Desktop.ViewModels.Base;
using Domain.Models;
using System.Collections.Generic;

namespace Desktop.ViewModels
{
    public class CompaniesViewModel : ViewModelBase
    {
        public List<Company> Companies { get; set; }

        public CompaniesViewModel()
        {
            Companies = new List<Company>()
            {
                new Company()
                {
                    Name = "Test",
                    Comment = "test",
                    Description = "test",
                    INN = "123124315"
                }
            };
        }

        public CompaniesViewModel(List<Company> companies)
        {
            Companies = companies;
        }
    }
}
