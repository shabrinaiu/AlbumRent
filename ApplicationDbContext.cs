using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DatabaseConnection_EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        private static string ConnectionURL = @"Data Source=SHABRINA\MSSQLSERVER01;Initial Catalog = Albums; Integrated Security = True";

        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionURL);
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<RentTransaction> Transactions { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
