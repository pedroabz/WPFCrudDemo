using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCRUDDemo.ViewModel;

namespace WPFCRUDDemo
{
    public class NewCommand : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            return parameter is EmployeeViewModel;
        }

        public override void Execute(object parameter)
        {
            var viewModel = (EmployeeViewModel)parameter;
            var employee = new Model.Employee();
            var maxId = 0;
            if (viewModel.Employee.Any())
            {
                maxId = viewModel.Employee.Max(f => f.Id);
            }
            employee.Id = maxId + 1;
            employee.BirthDate = new DateTime(1990, 1, 1);
            employee.AdmissionDate = DateTime.Today;


            var fw = new EditEmployee();
            fw.DataContext = employee;
            fw.ShowDialog();

            if (fw.DialogResult.HasValue && fw.DialogResult.Value)
            {
                viewModel.Employee.Add(employee);
                viewModel.SelectedEmployee = employee;
            }
        }
    }
}
