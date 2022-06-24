using System.Collections.Generic;
using WPFCRUDDemo.Model;

namespace WPFCRUDDemo.Services
{
    public interface IDataService
    {
        List<Employee> GetEmployee();
        void AddEmployee(Employee employee);
        void RemoveEmployee(Employee employee);        
        void EditEmployee(Employee employee);        
    }
}