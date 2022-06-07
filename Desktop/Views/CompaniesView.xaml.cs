using Application.Repository.Base;
using Application.UseCases.Company;
using Desktop.ViewModels;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Desktop.Views
{
    /// <summary>
    /// Логика взаимодействия для CompaniesView.xaml
    /// </summary>
    public partial class CompaniesView : Window
    {
        private CompaniesViewModel _model;
        private IRepository<Company> _repository;
        public CompaniesView(CompaniesViewModel model, IRepository<Company> repository)
        {
            InitializeComponent();
            _model = model;
            _repository = repository;

            DataContext = _model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            var guid = Guid.Parse(btn.Tag.ToString());

            var company = _repository.GetAll().Include(x=>x.CompanyRepresentatives).Where(x=>x.Id==guid).FirstOrDefault();
            if (company == null)
            {
                MessageBox.Show("Something wrong!");
            } else
            {
                var model = new CompanyViewModel(company);
                var view = new CompanyView(model);
                view.Show();
            }
        }
    }
}
