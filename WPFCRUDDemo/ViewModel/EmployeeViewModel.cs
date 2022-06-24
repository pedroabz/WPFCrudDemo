using System.Linq;
using WPFCRUDDemo.Services;

namespace WPFCRUDDemo.ViewModel
{
    public class EmployeeViewModel : BaseNotifyPropertyChanged
    {
        public System.Collections.ObjectModel.ObservableCollection<Model.Employee> Employee { get; private set; }

        private Model.Employee _selectedEmployee;
        public Model.Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set { 
                SetField(ref _selectedEmployee, value);
                Delete.RaiseCanExecuteChanged();
                Edit.RaiseCanExecuteChanged();
            }
        }
        public DeleteCommand Delete { get; private set; }
        public NewCommand New { get; private set; }
        public EditCommand Edit { get; private set; }

        private IDataService _dataService;

        public EmployeeViewModel(IDataService dataService, NewCommand newCommand, EditCommand editCommand, DeleteCommand deleteCommand)
        {               
            _dataService = dataService;
            Employee = new System.Collections.ObjectModel.ObservableCollection<Model.Employee>(_dataService.GetEmployee());
            New = newCommand;
            Delete = deleteCommand;
            Edit = editCommand;
            SelectedEmployee = Employee.FirstOrDefault();
        }
    }
}
