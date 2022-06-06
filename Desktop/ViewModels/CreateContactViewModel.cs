using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ViewModels
{
    public class CreateContactViewModel : ContactViewModel
    {
        public List<CompanyRepresentative> CompanyRepresentatives { get; set; }

        public CreateContactViewModel(List<CompanyRepresentative> companyRepresentatives)
        {
            CompanyRepresentatives = companyRepresentatives;
        }

        public CreateContactViewModel()
        {
            CompanyRepresentatives = new List<CompanyRepresentative>();
        }
    }
}
