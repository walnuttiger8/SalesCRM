﻿using Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
    /// Логика взаимодействия для CompanyView.xaml
    /// </summary>
    public partial class CompanyView : Window
    {
        private CompanyViewModel _model;
        public CompanyView(CompanyViewModel model)
        {
            InitializeComponent();
            _model = model;

            DataContext = _model;
        }
    }
}
