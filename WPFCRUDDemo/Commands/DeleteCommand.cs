using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCRUDDemo.ViewModel;

namespace WPFCRUDDemo
{
    public class DeleteCommand : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as EmployeeViewModel;
            return viewModel != null && viewModel.SelectedEmployee != null;
        }

        public override void Execute(object parameter)
        {
            var viewModel = (EmployeeViewModel)parameter;
            viewModel.Employee.Remove(viewModel.SelectedEmployee);
            viewModel.SelectedEmployee = viewModel.Employee.FirstOrDefault();
        }
    }
}
