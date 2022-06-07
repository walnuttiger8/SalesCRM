using Desktop.ViewModels;
using System.Windows;
using Domain.Models;
using Infrastructure.Repository.Base;
using Infrastructure.Contexts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Desktop.Views;
using Application.Repository.Base;
using Application.UseCases.CompanyUseCases;
using Application.UseCases.CompanyRepresentativeUseCases;
using Application.UseCases.ContactUseCases;
using Application.UseCases.Company;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ApplicationContext _applicationContext;
        private IRepository<Company> _companyRepository;
        private IRepository<CompanyRepresentative> _companyRepresentativeRepository;
        private IRepository<Contact> _contactRepository;

        public MainWindow()
        {
            var sb = new SqlConnectionStringBuilder()
            {
                DataSource = @"(localdb)\MSSQLLocalDB",
                InitialCatalog = "SalesCRM"
            };


            InitializeComponent();
            var db = new DbContextOptionsBuilder<ApplicationContext>();
            _applicationContext = new ApplicationContext(db.UseSqlServer(sb.ConnectionString).Options);

            _companyRepository = new Repository<Company>(_applicationContext);
            _companyRepresentativeRepository = new Repository<CompanyRepresentative>(_applicationContext);
            _contactRepository = new Repository<Contact>(_applicationContext);
        }

        private void addCompanyButton_Click(object sender, RoutedEventArgs e)
        {
            var useCase = new CreateCompany(_companyRepository);
            var view = new CreateCompanyView(useCase);

            view.Show();
        }

        private void addCompanyRepresentativeButton_Click(object sender, RoutedEventArgs e)
        {
            var useCase = new CreateCompanyRepresentative(_companyRepresentativeRepository);
            var companies = _companyRepository.GetAll();
            var model = new CreateCompanyRepresentativeViewModel(companies.ToList());
            var view = new CreateCompanyRepresentativeView(model, useCase);

            view.Show();
        }

        private void addContactButton_Click(object sender, RoutedEventArgs e)
        {
            var useCase = new CreateContact(_contactRepository);
            var companyRepresentatives = _companyRepresentativeRepository.GetAll();
            var model = new CreateContactViewModel(companyRepresentatives.ToList());
            var view = new CreateContactView(model, useCase);

            view.Show();
        }

        private void showCompaniesButton_Click(object sender, RoutedEventArgs e)
        {
            var useCase = new GetCompany(_companyRepository);
            var model = new CompaniesViewModel(_companyRepository.GetAll().ToList());
            var view = new CompaniesView(model, _companyRepository);

            view.Show();
        }
    }
}
