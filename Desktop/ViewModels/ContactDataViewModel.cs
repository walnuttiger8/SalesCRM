using Desktop.ViewModels.Base;
using Domain.Models;

namespace Desktop.ViewModels
{
    public class ContactDataViewModel : ViewModelBase
    {
        public ContactData ContactData { get; set; }

        public ContactDataViewModel(ContactData contactData)
        {
            ContactData = contactData;
        }

        public string Data
        {
            get
            {
                return ContactData.Data;
            }
            set
            {
                ContactData.Data = value;
                OnPropertyChanged("Data");
            }
        }
    }
}
