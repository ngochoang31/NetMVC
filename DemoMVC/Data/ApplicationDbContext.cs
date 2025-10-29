using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set; }
        
        public DbSet<Employee> Employee { get; set; }
        public DbSet<DemoMVC.Models.Demo> Demo { get; set; } = default!;
    }
}