using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SiteDiscover.Persistence.Contexts.EntityFramework
{
    public class PMISiteContextFactory : IDesignTimeDbContextFactory<PMISiteContext>
    {
        public PMISiteContext CreateDbContext(string[] args)
        {
            string hostEnvironmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings{hostEnvironmentName}.json",optional:true)
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<PMISiteContext>()
                .UseSqlServer(connectionString);

            return new PMISiteContext(optionsBuilder.Options);
        }
    }
}
