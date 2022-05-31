using Desktop.ViewModels.Base;
using Domain.Models;

namespace Desktop.ViewModels
{
    public class CompanyRepresentativeViewModel : ViewModelBase
    {
        public CompanyRepresentative CompanyRepresentative { get; set; }
        public ContactDataViewModel ContactDataViewModel { get; set; }

        public CompanyRepresentativeViewModel(CompanyRepresentative companyRepresentative)
        {
            CompanyRepresentative = companyRepresentative;
            ContactDataViewModel = new ContactDataViewModel(companyRepresentative.ContactData);
        }


        public string LastName { 
            get 
            {
                return CompanyRepresentative.LastName;
            }
            set 
            { 
                CompanyRepresentative.LastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string FirstName
        {
            get
            {
                return CompanyRepresentative.FirstName;
            }
            set
            {
                CompanyRepresentative.FirstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string MiddleName
        {
            get
            {
                return CompanyRepresentative.MiddleName;
            }
            set
            {
                CompanyRepresentative.MiddleName = value;
                OnPropertyChanged("MiddleName");
            }
        }
        public string Comment
        {
            get
            {
                return CompanyRepresentative.Comment;
            }
            set
            {
                CompanyRepresentative.Comment = value;
                OnPropertyChanged("MiddleName");
            }
        }
    }
}
