using ASPNET_MVC_CRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNET_MVC_CRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
