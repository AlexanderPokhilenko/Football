using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL.Implementation
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<StageType> StageTypes { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Team> Teams { get; set; }

        public ApplicationContext() : base(GetContextOptions())
        {
            Database.EnsureCreated();
        }

        private static DbContextOptions<ApplicationContext> GetContextOptions()
        {
            throw new NotImplementedException();
            //var connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            //var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>().UseSqlServer(connectionString);
            //return optionsBuilder.Options;
        }
    }
}
