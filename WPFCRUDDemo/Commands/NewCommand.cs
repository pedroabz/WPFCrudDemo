using System;
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
            var employee = new Model.Employee
            {
                BirthDate = new DateTime(1990, 1, 1),
                AdmissionDate = DateTime.Today
            };

            var fw = new EditEmployee
            {
                DataContext = employee
            };
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
