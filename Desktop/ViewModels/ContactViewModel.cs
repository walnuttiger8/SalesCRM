using System;
using Desktop.ViewModels.Base;
using Domain.Models;

namespace Desktop.ViewModels
{
    public class ContactViewModel : ViewModelBase
    {
        public Contact Contact { get; set; }

        public ContactViewModel()
        {
            Contact = new Contact();
        }

        public DateTime ContactDate
        {
            get
            {
                return Contact.ContactDate;
            }
            set
            {
                Contact.ContactDate = value;
                OnPropertyChanged("ContactDate");
            }
        }

        public string Comment
        {
            get
            {
                return Contact.Comment;
            }
            set
            {
                Contact.Comment = value;
                OnPropertyChanged("Comment");
            }
        }

        public ContactType ContactType
        {
            get
            {
                return Contact.ContactType;
            }
            set
            {
                Contact.ContactType = value;
                OnPropertyChanged("ContactType");
            }
        }

        public CompanyRepresentative CompanyRepresentative
        {
            get
            {
                return Contact.CompanyRepresentative;
            }
            set
            {
                Contact.CompanyRepresentative = value;
                OnPropertyChanged("CompanyRepresentative");
            }
        }
    }
}
