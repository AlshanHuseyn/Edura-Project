using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class DesignTimeDbContext : IDesignTimeDbContextFactory<EduraContext>
    {
        public EduraContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<EduraContext>();
            var connectionstring = configuration.GetConnectionString("Constring");
            builder.UseSqlServer(connectionstring);
            return new EduraContext(builder.Options);
        }
    }
}
