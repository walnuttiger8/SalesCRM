using Domain.Models;
using System.Collections.Generic;

namespace Desktop.ViewModels
{
    public class CreateCompanyRepresentativeViewModel : CompanyRepresentativeViewModel
    {
        public List<Company> Companies { get; set; }
        public CreateCompanyRepresentativeViewModel(List<Company> companies)
        {
            Companies = companies;
        }

        public CreateCompanyRepresentativeViewModel()
        {
            Companies = new List<Company>();
        }
    }
}
