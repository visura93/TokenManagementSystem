using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Entity;
using TokenManagement.Models.DomainObjects;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace TokenManagement.Models
{
        public class ApplicationDbContext : DbContext
        {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YourDatabaseName;User ID=YourUsername;Password=YourPassword;";

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) // Replace with your connection string name
            {
            }

            public Microsoft.EntityFrameworkCore.DbSet<Token> Tokens { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Locations> Locations { get; set; }
        // Add other DbSets for other entities you have (ServiceCategory, ServiceProvider, etc.)
    }
    
}
