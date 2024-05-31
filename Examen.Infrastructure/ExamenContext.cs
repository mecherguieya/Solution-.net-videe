
using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Examen.Infrastructure
{
    public class ExamenContext : DbContext
    {
        public DbSet<Laboratoire> Laboratoires { get; set; }
        public DbSet<Analyse> Analyses { get; set; }
        public DbSet<Infirmier> Infirmiers { get; set; }
        public DbSet<Bilan> Bilans { get; set; }
        public DbSet<Patient> Patients { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(); 

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                       Initial Catalog= LaboMecherguiEya;
                       Integrated Security=true;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


          
 

        }
        //protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        //{
            
        //}
    }
}
