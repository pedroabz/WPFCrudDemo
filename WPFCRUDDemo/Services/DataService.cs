using System;
using System.Collections.Generic;
using System.Linq;
using WPFCRUDDemo.Model;

namespace WPFCRUDDemo.Services
{
    public class DataService : IDataService
    {
        private readonly EmployeeDbContext _employeeDbContext;
        public DataService(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public List<Employee> GetEmployee()
        {
            return _employeeDbContext.Employees.ToList();
        }
        public void AddEmployee(Employee employee)
        {
            _employeeDbContext.Employees.Add(employee);
            _employeeDbContext.SaveChanges();
        }
        public void RemoveEmployee(Employee employee)
        {
            _employeeDbContext.Employees.Remove(employee);
            _employeeDbContext.SaveChanges();
        }
        public void EditEmployee(Employee employee)
        {
            _employeeDbContext.Employees.Update(employee);
            _employeeDbContext.SaveChanges();
        }
    }
}
