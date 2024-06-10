using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Persistence.Contexts.EntityFramework
{
    public class PMISiteContextFactory : IDesignTimeDbContextFactory<PMISiteContext>
    {
        public PMISiteContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<PMISiteContext>()
                .UseSqlServer(connectionString);

            return new PMISiteContext(optionsBuilder.Options);
        }
    }
}
