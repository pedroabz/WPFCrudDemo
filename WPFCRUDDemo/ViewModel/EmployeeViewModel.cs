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
        public DeleteCommand Delete { get; private set; } = new DeleteCommand();
        public NewCommand New { get; private set; } = new NewCommand();
        public EditCommand Edit { get; private set; } = new EditCommand();

        private IDataService _dataService;

        public EmployeeViewModel(IDataService dataService)
        {               
            _dataService = dataService;
            Employee = new System.Collections.ObjectModel.ObservableCollection<Model.Employee>(_dataService.GetEmployee()); // já implementa as interfaces de notificação de alteração de coleções
            SelectedEmployee = Employee.FirstOrDefault();
        }
    }
}
