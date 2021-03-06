using Luca_Finoia_MVC.Core.Entities;
using Luca_Finoia_MVC.RepositoryEF.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luca_Finoia_MVC.RepositoryEF
{
    public class MasterContext : DbContext
    {
        public DbSet<Piatto> Piatti { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Utente> Utenti { get; set; }

        public MasterContext()
        {

        }

        public MasterContext(DbContextOptions<MasterContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Ristorante;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Piatto>(new PiattoConfiguration());
            modelBuilder.ApplyConfiguration<Menu>(new MenuConfiguration());
            modelBuilder.ApplyConfiguration<Utente>(new UtenteConfiguration());

        }
    }
}
