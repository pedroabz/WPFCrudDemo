using System;
using WPFCRUDDemo.Services;
using WPFCRUDDemo.ViewModel;

namespace WPFCRUDDemo
{
    public class EditCommand : BaseCommand
    {
        private IDataService _dataService;
        public EditCommand(IDataService dataService)
        {
            _dataService = dataService;
        }
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as EmployeeViewModel;
            return viewModel != null && viewModel.SelectedEmployee != null;
        }

        public override void Execute(object parameter)
        {
            var viewModel = (EmployeeViewModel)parameter;
            var employeeClone = (Model.Employee)viewModel.SelectedEmployee.Clone();
            var fw = new EditEmployee();
            fw.DataContext = employeeClone;
            fw.ShowDialog();

            if (fw.DialogResult.HasValue && fw.DialogResult.Value)
            {                
                viewModel.SelectedEmployee.Name = employeeClone.Name;
                viewModel.SelectedEmployee.LastName = employeeClone.LastName;
                viewModel.SelectedEmployee.BirthDate = employeeClone.BirthDate;
                viewModel.SelectedEmployee.Gender = employeeClone.Gender;
                viewModel.SelectedEmployee.MaritalState = employeeClone.MaritalState;
                viewModel.SelectedEmployee.AdmissionDate = employeeClone.AdmissionDate;
                _dataService.EditEmployee(viewModel.SelectedEmployee);
            }
        }
    }
}
