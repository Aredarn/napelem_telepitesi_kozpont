using Microsoft.EntityFrameworkCore;
using napelem_telepito_kozpont.Backend.Modells_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelem_telepito_kozpont.Backend.DatabaseConnection
{
    public class NapelemDbContext : DbContext
    {
        //EZ MINDENKINEK A SAJÁTJÁRA KELL ÁTÍRNIA.
        private readonly string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true";
        //egyszer elég

        //Creates the 'tables' to use in the program
        public DbSet<Felhasznalo> Felhasznalo { get; set; }
        public DbSet<Arucikk> Arucikk { get; set; }
        public DbSet<Polc> Polc { get; set; }
        public DbSet<Projektek> Projekt { get; set; }
        public DbSet<Status> Statusz { get; set; }
        public DbSet<ProjektArucikkhez> ProjektekArucikkhez { get; set; }
        public DbSet<UjArucikkIgeny> ujArucikkIgeny { get; set; }
        public DbSet<ProjectStatuszok> projectStatuszok { get; set; }
        public DbSet<Megrendelo> Megrendelok { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
