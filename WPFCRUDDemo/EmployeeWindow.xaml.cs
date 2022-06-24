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
        public EmployeeWindow(IDataService dataService, EmployeeViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();            
        }
    }
}
