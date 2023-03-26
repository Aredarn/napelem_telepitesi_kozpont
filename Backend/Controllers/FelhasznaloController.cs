using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using napelem_telepito_kozpont.Backend.DatabaseConnection;
using napelem_telepito_kozpont.Backend.Modells_Tables;
using System.Security.Cryptography;
using System.Security.Policy;

namespace napelem_telepito_kozpont.Backend.Controllers
{
    public class FelhasznaloController
    {
        /* Enkripteli a paraméterben megadott string-et, majd visszatér
           az enkriptelt változattal. */
        private string Hash(string value)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(value);

            byte[] hashBytes;

            using (SHA256 sha256 = SHA256.Create())
            {
                hashBytes = sha256.ComputeHash(passwordBytes);
            }

            return Convert.ToBase64String(hashBytes);
        }

        /* A `Login` metódus azt a célt szolgálja, hogy meg lehessen vizsgálni
           a megadott két paraméter (`felhasználónév`, `jelszó`) alapján
           létezik-e felhasználó az adatbázisban, mely a két paraméter Hash-elt
           értékeivel rendelkezik. Ha létezik, akkor visszatér egy `Felhasznalo`
           objektummal, mely tartalmazza az értékeket, különben csak egy dummy
           `Felhasznalo` objektumot ad vissza. */
        public Felhasznalo Login(string username, string password)
        {
            try
            {
                /* Adatbázis kapcsolat. */
                NapelemDbContext context = new();

                /* A paraméterben megadott változók értékeinek Hash-elése. */
                string usernameHash = Hash(username);
                string passwordHash = Hash(password);

                /* Megvizsgálni, hogy az előbb Hash-elt felhasználó és jelszó
                   létezik-e az adatbázisban. Ha igen, akkor tárolja egy
                   `Felhasznalo` objektumban, majd térjen is vissza vele. */
                Felhasznalo felhasznalo = context.Felhasznalo
                    .Single(row => row.Name == usernameHash
                                && row.Password == passwordHash);

                /* Térjen vissza az előbb létrehozott `Felhasznalo` objektummal. */
                return felhasznalo;
            }
            catch (Exception)
            {
                /* Bármilyen hiba, illetve kivétel esetén a program térjen
                   vissza egy olyan `Felhasznalo` objektummal, melyben a
                   tulajdonságok üres string-ek, illetve 0-ák, annak érdekében,
                   hogy fel lehessen ismerni, hogy nem egy valós felhasználó
                   lett megtalálva. */
                return new Felhasznalo {
                    Name = "",
                    Password = "",
                    Role = 0
                };
            }
        }
    }
}
