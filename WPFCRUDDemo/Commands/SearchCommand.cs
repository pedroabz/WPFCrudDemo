using System;
using WPFCRUDDemo.Services;
using WPFCRUDDemo.ViewModel;


namespace WPFCRUDDemo.Commands
{
    public class SearchCommand : BaseCommand
    {
        public override void Execute(object parameter)
        {
            var viewModel = (EmployeeViewModel)parameter;
            viewModel.Filter();
        }
    }
}
