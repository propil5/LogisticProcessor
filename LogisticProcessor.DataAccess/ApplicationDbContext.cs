using LogisticProcessor.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace LogisticProcessor.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public virtual DbSet<ProductDto> Products { get; set; }
        public virtual DbSet<CompanyDto> Companies { get; set; }
        public virtual DbSet<PalletDto> Pallets { get; set; }

        internal ApplicationDbContext CreateDbContext(object p)
        {
            throw new System.NotImplementedException();
        }

        public virtual DbSet<AddressDto> AddressDto { get; set; }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration =  new ConfigurationBuilder() 
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/../../LogisticProcessor/src/Web/Server/appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("DatabaseConnection");
            builder.UseSqlServer(connectionString);
            return new ApplicationDbContext(builder.Options);
        }
    }
}
