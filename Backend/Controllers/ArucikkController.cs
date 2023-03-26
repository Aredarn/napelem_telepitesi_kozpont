using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using napelem_telepito_kozpont.Backend.DatabaseConnection;
using napelem_telepito_kozpont.Backend.Modells_Tables;

namespace napelem_telepito_kozpont.Backend.Controllers
{
    public class ArucikkController
    {
        /* Az `Add` metódus segítségével új árucikk adható hozzá az
           adatbázishoz, illetve az `Arucikk` nevű táblába új
           rekordként.
           Annak érdekében, hogy a metódus működjön paraméterben
           meg kell adni egy `Arucikk` objektumot, majd az alapján
           fog lefutni a metódus. */
        public bool Add(Arucikk arucikk)
        {
            try
            {
                /* Adatbázis kapcsolat, hogy hozzá lehessen adni az
                   `Arucikk` nevű táblához egy új rekordot. */
                NapelemDbContext context = new();

                /* Az `Add()` metódust alkalmazva a paraméterben megadott
                   `Arucikk` objektummal a hozzáadás egyszerűen
                   megtörténik. A `SaveChanges` után hajtódik végre. */
                context.Arucikk.Add(arucikk);
                context.SaveChanges();

                /* Sikeresen lefutott a metódus, adjon vissza igaz értéket. */
                return true;
            }
            catch (Exception)
            {
                /* Hiba, vagy kivétel esetén adjon vissza hamis értéket. */
                return false;
            }
        }
    }
}
