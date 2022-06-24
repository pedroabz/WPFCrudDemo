using System.Collections.Generic;
using WPFCRUDDemo.Model;

namespace WPFCRUDDemo.Services
{
    public interface IDataService
    {
        List<Employee> GetEmployee();
    }
}