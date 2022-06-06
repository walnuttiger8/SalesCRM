using Application.UseCases.User;
using Desktop.ViewModels;
using System.Windows;

namespace Desktop.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationView.xaml
    /// </summary>
    public partial class AuthorizationView : Window
    {
        private AuthorizationViewModel _model;
        private readonly Authorization _useCase;
        public AuthorizationView(AuthorizationViewModel model, Authorization useCase)
        {
            InitializeComponent();

            _model = model;
            _useCase = useCase;
        }

        private void signupButton_Click(object sender, RoutedEventArgs e)
        {
            var request = new AuthorizationRequest(_model.Login, passwordBox.Password);
            var response = _useCase.Execute(request);

            var user = response.User;

            if (user == null)
            {
                MessageBox.Show("User not found!");
            } else
            {
                MessageBox.Show("User not found!");
            }
        }
    }
}
