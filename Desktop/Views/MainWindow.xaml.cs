using Desktop.ViewModels;
using System.Windows;
using Domain.Models;
using Application.UseCases.Base;
using Infrastructure.Repository.Base;
using Infrastructure.Contexts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var sb = new SqlConnectionStringBuilder()
            {
                DataSource = @"(localdb)\MSSQLLocalDB",
                InitialCatalog = "SalesCRM"
            };


            InitializeComponent();
            var db = new DbContextOptionsBuilder<ApplicationContext>();
            var applicationContext = new ApplicationContext(db.UseSqlServer(sb.ConnectionString).Options);
            var repository = new Repository<Company>(applicationContext);
            var useCase = new GetAllModelsUseCase<Company>(repository);
            var response = useCase.Execute(new GetAllModelsRequest<Company>());
            DataContext = new CompanyViewModel();
        }
    }
}
