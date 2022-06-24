using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WPFCRUDDemo.Model;

namespace WPFCRUDDemo
{
    public class EmployeeDbContextFactory : IDesignTimeDbContextFactory<EmployeeDbContext>
    {
        public EmployeeDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EmployeeDbContext>();
            optionsBuilder.UseSqlite("Data Source=Employee.db");

            return new EmployeeDbContext(optionsBuilder.Options);
        }
    }
}
