using System.Collections.Generic;
using System.Linq;
using Domain.Models;
using Desktop.ViewModels.Base;

namespace Desktop.ViewModels
{
    public class CompanyViewModel : ViewModelBase
    {

        public Company Company { get; set; }
        public List<CompanyRepresentativeViewModel> CompanyRepresentativeViewModels { get; set; }

        public CompanyViewModel()
        {
            Company = new Company();
            //{
            //    Name = @"ООО ""Олег строй""",
            //    Description = "Строим бани и машины",
            //    INN = "1234556712",
            //    Comment = "Оценка 4 за ТА",
            //    CompanyRepresentatives = new List<CompanyRepresentative>()
            //    {
            //        new CompanyRepresentative()
            //        {
            //            FirstName = "Vladimir",
            //            LastName = "Korneplod",
            //            MiddleName = "Vladimirovich",
            //        }
            //    }
            //};
            CompanyRepresentativeViewModels = new List<CompanyRepresentativeViewModel>();
        }

        public CompanyViewModel(Company company)
        {
            Company = company;
            CompanyRepresentativeViewModels = company.CompanyRepresentatives.Select(c => new CompanyRepresentativeViewModel(c)).ToList();
        }
        public string Name { 
            get
            {
                return Company.Name;
            }
            set
            {
                Company.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string INN
        {
            get
            {
                return Company.INN;
            }
            set
            {
                Company.INN = value;
                OnPropertyChanged("INN");
            }
        }
        
        public string Description
        {
            get
            {
                return Company.Description;
            }
            set
            {
                Company.Description = value;
                OnPropertyChanged("Descrition");
            }
        }

        public string Comment
        {
            get
            {
                return Company.Comment;
            }
            set
            {
                Company.Comment = value;
                OnPropertyChanged("Comment");
            }
        }
        public List<CompanyRepresentative> CompanyRepresentatives 
        { 
            get
            {
                return Company.CompanyRepresentatives;
            }
            set
            {
                Company.CompanyRepresentatives = value;
                OnPropertyChanged("CompanyRepresentatives");
            }
        }
    }
}
