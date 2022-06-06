using Application.Repository.Base;
using Application.UseCases.Base;
using Application.UseCases.CompanyUseCases;
using Desktop.ViewModels;
using Domain.Models;
using System.Windows;

namespace Desktop.Views
{
    /// <summary>
    /// Логика взаимодействия для CreateCompanyView.xaml
    /// </summary>
    public partial class CreateCompanyView : Window
    {
        private readonly CreateCompany _useCase;

        public CreateCompanyView(CreateCompany useCase)
        {
            InitializeComponent();

            _useCase = useCase;
        }
        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            ExecuteUseCase();
            RefreshDataContext();
            Close();
        }
        private void ExecuteUseCase()
        {
            var model = (CompanyViewModel) DataContext;
            var request = new CreateModelRequest<Company>(model.Company);
            _useCase.Execute(request);
        }
        private void RefreshDataContext()
        {
            DataContext = new CompanyViewModel();
        }
    }
}
