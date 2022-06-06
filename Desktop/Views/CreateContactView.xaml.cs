using Application.UseCases.Base;
using Application.UseCases.ContactUseCases;
using Desktop.ViewModels;
using Domain.Models;
using System.Windows;

namespace Desktop.Views
{
    /// <summary>
    /// Логика взаимодействия для CreateContactView.xaml
    /// </summary>
    public partial class CreateContactView : Window
    {
        private readonly CreateContact _useCase;
        private readonly CreateContactViewModel _model;
        public CreateContactView(CreateContactViewModel model, CreateContact useCase)
        {
            InitializeComponent();
            _useCase = useCase;

            _model = model;
            RefreshContext();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Execute();
            RefreshContext();
            Close();
        }

        private void Execute()
        {
            var request = new CreateModelRequest<Contact>(_model.Contact);
            _useCase.Execute(request);
        }

        private void RefreshContext()
        {
            DataContext = _model;
        }
    }
}
