using Desktop.ViewModels.Base;

namespace Desktop.ViewModels
{
    public class AuthorizationViewModel : ViewModelBase
    {
        public AuthorizationViewModel()
        {
            login = "";
            password = "";
        }

        private string login;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }
    }
}
