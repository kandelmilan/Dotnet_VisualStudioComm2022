using Microsoft.EntityFrameworkCore;
using DataBase.Models; // adjust namespace to your project
using System.Collections.Generic;

namespace DataBase.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // Example DbSet
        public DbSet<Student> Students { get; set; }
    }
}
