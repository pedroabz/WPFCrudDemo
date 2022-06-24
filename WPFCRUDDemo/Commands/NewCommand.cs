using System;
using System.Linq;
using WPFCRUDDemo.Services;
using WPFCRUDDemo.ViewModel;

namespace WPFCRUDDemo
{
    public class NewCommand : BaseCommand
    {
        private IDataService _dataService;
        public NewCommand(IDataService dataService)
        {
            _dataService = dataService;
        }

        public override bool CanExecute(object parameter)
        {
            return parameter is EmployeeViewModel;
        }

        public override void Execute(object parameter)
        {
            var viewModel = (EmployeeViewModel)parameter;
            var employee = new Model.Employee();
            employee.BirthDate = new DateTime(1990, 1, 1);
            employee.AdmissionDate = DateTime.Today;           

            var fw = new EditEmployee();
            fw.DataContext = employee;
            fw.ShowDialog();

            if (fw.DialogResult.HasValue && fw.DialogResult.Value)
            {
                _dataService.AddEmployee(employee);
                viewModel.Employee.Add(employee);
                viewModel.SelectedEmployee = employee;
            }
        }
    }
}
