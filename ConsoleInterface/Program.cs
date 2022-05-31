using Infrastructure.Contexts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var sb = new SqlConnectionStringBuilder()
{
    DataSource = @"(localdb)\MSSQLLocalDB",
    InitialCatalog = "SalesCRM"
};

var b = new DbContextOptionsBuilder<ApplicationContext>();
var context = new ApplicationContext(b.UseSqlServer(sb.ConnectionString).Options);
Console.WriteLine("success!");