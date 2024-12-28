using Microsoft.EntityFrameworkCore;
using MyFirstWeb.Models;

namespace YourProjectNamespace.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

