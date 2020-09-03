using System;
using Microsoft.EntityFrameworkCore;
using MVCMigration.Infrastructure.Models;

namespace MVCMigration.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
