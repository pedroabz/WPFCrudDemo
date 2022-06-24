using System;
using System.Windows;
using WPFCRUDDemo.Services;
using WPFCRUDDemo.ViewModel;

namespace WPFCRUDDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        IDataService _dataService;
        public EmployeeWindow(IDataService dataService, EmployeeViewModel viewModel)
        {
            _dataService = dataService;
            DataContext = viewModel;
            InitializeComponent();            
        }
    }
}
