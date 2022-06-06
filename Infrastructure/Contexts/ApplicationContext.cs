using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace Infrastructure.Contexts
{
    public class ApplicationContext : DbContext
    {
        private static DbContextOptionsBuilder<ApplicationContext> db = new DbContextOptionsBuilder<ApplicationContext>();
        private static SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
        {
            DataSource = @"(localdb)\MSSQLLocalDB",
            InitialCatalog = "SalesCRM"
        };

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public ApplicationContext() : base(db.UseSqlServer(sb.ConnectionString).Options) 
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<CompanyRepresentative> CompanyRepresentatives { get; set; }
    }
}
