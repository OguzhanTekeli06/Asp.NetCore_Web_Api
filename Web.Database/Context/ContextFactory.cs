using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace Web.Database;

public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
{
    public Context CreateDbContext(string[] args)
    {
        DotNetEnv.Env.Load();
        string connectionString = "Server=DESKTOP-0QE53DC;Database=ExampleDb;Integrated Security=True;TrustServerCertificate=True;";
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException("Connection string not found. Check your .env file.");
        }
        return new Context(new DbContextOptionsBuilder<Context>().UseSqlServer(connectionString).Options);
    }
}
