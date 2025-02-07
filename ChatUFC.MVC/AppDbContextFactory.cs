using ChatUFC.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ChatUFC.MVC;

public class AppDbContextFactory : IDesignTimeDbContextFactory<DbChat>
{
    public DbChat CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

        var build = new DbContextOptionsBuilder<DbChat>().UseSqlServer(config.GetConnectionString("AzureSQL1"), b => b.MigrationsAssembly("ChatUFC.Persistence"));

        return new DbChat(build.Options);
    }
}
