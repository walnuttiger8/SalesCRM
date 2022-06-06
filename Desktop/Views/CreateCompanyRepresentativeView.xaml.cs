using Desktop.ViewModels;
using System.Windows;
using Application.UseCases.CompanyRepresentativeUseCases;
using Application.UseCases.Base;
using Domain.Models;

namespace Desktop.Views
{
    /// <summary>
    /// Логика взаимодействия для CreateCompanyRepresentativeView.xaml
    /// </summary>
    public partial class CreateCompanyRepresentativeView : Window
    {
        private readonly CreateCompanyRepresentative _useCase;
        private CreateCompanyRepresentativeViewModel _model;
        public CreateCompanyRepresentativeView(CreateCompanyRepresentativeViewModel model, CreateCompanyRepresentative useCase)
        {
            InitializeComponent();
            _useCase = useCase;
            _model = model;

            RefreshContext();
        }

        private void Execute()
        {
            var request = new CreateModelRequest<CompanyRepresentative>(_model.CompanyRepresentative);
            _useCase.Execute(request);
        }

        private void RefreshContext()
        {
            DataContext = _model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Execute();
            RefreshContext();
            Close();
        }
    }
}
