using Microsoft.EntityFrameworkCore;
using napelem_telepito_kozpont.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelem_telepito_kozpont.DataLayer.Database
{
    /// <summary>
    /// Todo, ilyen db contextet kell majd csinálni a napelem táblának
    /// Meg persze meg kell csinálni a napelem modelleket (ezek fogják reprezentálni a táblákat) a cica meg a cica hotel alapján
    /// A connection string mindig a connected service-ből jön, az Express local db.
    /// Ha ez neked más nyilván itt át kell írni. Egyébként a secrets.json-ba tárolódik ez a connection string
    /// Projekt, jobb klikk, manage secrets, és ott lesz
    /// Van rá lehetőség, hogy a program kiolvassa onnan, de az majd máskor
    /// Két parancsot kell kiadni
    /// dotnet ef migrations add ValamiNév - ez csak egy c# file-t generál
    /// Ezt mindig ki kell adni ha változnak a modelljeid felépítése AKA az adatbázis séma
    /// Egyébként meg elég csak egyszer valakinek ezt kiadnia, és legenerálódik egy C# fájl
    /// Ha ez megvan akkor már nem kell többet kiadni ezt a parancsot
    /// Utána már csak egy dotnet ef database update-et kell kiadni, ami felkúrja a táblákat az adatábzisba (connection string helyén lévő db-be)
    /// Adat lekérdezés meg ilyenek meg másik classba van, CatParadiseRepositoryba
    /// 
    /// </summary>
    public class CatParadiseDbContext : DbContext
    {
        private readonly string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true";

        public DbSet<Cat> Cats { get; set; }
        public DbSet<CatHotel> Hotels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
