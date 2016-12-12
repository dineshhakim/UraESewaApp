using UraEsewaApp.Models;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using UraEsewaApp.Models.Entities;

namespace UraEsewaApp.Repository.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }

        public IConfigurationRoot Configuration { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json");
            Configuration = configuration.Build();
            options.UseSqlServer(Configuration["Data:DefaultConnection:ConnectionString"]);
          
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<User> Users { get; set; }        
        public DbSet<RoleType> RoleTypes { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestStatus> RequestStatuses { get; set; }
        public DbSet<GLTranMast> GLTranMasts { get; set; }
        public DbSet<GLTranDetail> GLTranDetails { get; set; }
        public DbSet<GeneralLedger> GeneralLedgers { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }

}
