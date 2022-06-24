using Microsoft.EntityFrameworkCore;

namespace WPFCRUDDemo.Model
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base (options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
