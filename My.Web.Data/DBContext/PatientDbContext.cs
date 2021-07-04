using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using My.Web.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace My.Web.Data
{
    public class PatientDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public PatientDbContext(DbContextOptions<PatientDbContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            //var connecttionString = configuration.GetSection("ConnectionStrings").GetSection("DefaultConnectionString").Value;

            //optionsBuilder.UseSqlServer(connecttionString);
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PatientDbContext>
    {
        public PatientDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "../../My.Web.API/appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<PatientDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnectionString");
            builder.UseSqlServer(connectionString);
            return new PatientDbContext(builder.Options);
        }
    }
}
