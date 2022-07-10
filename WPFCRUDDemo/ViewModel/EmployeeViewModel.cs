using System.Linq;
using WPFCRUDDemo.Services;
using System.Collections.ObjectModel;
using WPFCRUDDemo.Model;
using WPFCRUDDemo.Commands;

namespace WPFCRUDDemo.ViewModel
{
    public class EmployeeViewModel : BaseNotifyPropertyChanged
    {
        private ObservableCollection<Employee> _employee;
        public ObservableCollection<Employee> Employee {

            get {
                return _employee;
            }             
            set {
                _employee = value;
                OnPropertyChanged(typeof(Employee).ToString());
            } 
        }

        private string _query;

        public string Query
        {
            get { return _query; }
            set { 
                _query = value;
                OnPropertyChanged(typeof(Employee).ToString());
            }
        }


        private Employee _selectedEmployee;
        public Employee SelectedEmployee
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
        public SearchCommand Search { get; set; }


        private IDataService _dataService;

        public EmployeeViewModel(IDataService dataService, NewCommand newCommand, EditCommand editCommand, DeleteCommand deleteCommand, SearchCommand searchCommand)
        {               
            _dataService = dataService;
            Employee = new ObservableCollection<Employee>(_dataService.GetEmployee());
            New = newCommand;
            Delete = deleteCommand;
            Edit = editCommand;
            Search = searchCommand;
            SelectedEmployee = Employee.FirstOrDefault();
        }

        public void Filter()
        {
            // Need to clear list and then add each one because Binding won't work again if I instantiate a new object to Employee
            Employee.Clear();
            var filteredEmployees = _dataService.GetEmployee().Where(x => x.Name.ToUpper().Contains(Query.ToUpper()));
            foreach (var employee in filteredEmployees)
            { 
                Employee.Add(employee);
            }            
        }
    }
}
