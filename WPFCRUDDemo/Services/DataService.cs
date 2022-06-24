using System;
using System.Collections.Generic;
using WPFCRUDDemo.Model;

namespace WPFCRUDDemo.Services
{
    public class DataService : IDataService
    {
        public List<Employee> GetEmployee()
        {
            var employees = new List<Employee>();
            employees.Add(new Employee()
            {
                Id = 1,
                Name = "André",
                LastName = "Lima",
                BirthDate = new DateTime(1984, 12, 31),
                Gender = Enums.Gender.Male,
                MaritalState = Enums.MaritalState.Married,
                AdmissionDate = new DateTime(2010, 1, 1)
            });
            employees.Add(new Employee()
            {
                Id = 2,
                Name = "Zé",
                LastName = "Lima",
                BirthDate = new DateTime(1988, 12, 31),
                Gender = Enums.Gender.Male,
                MaritalState = Enums.MaritalState.Married,
                AdmissionDate = new DateTime(2010, 1, 1)
            });
            return employees;
        }
    }
}
