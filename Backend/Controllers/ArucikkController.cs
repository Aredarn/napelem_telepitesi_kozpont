using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using napelem_telepito_kozpont.Backend.DatabaseConnection;
using napelem_telepito_kozpont.Backend.Modells_Tables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public List<Arucikk> GetItems()
        {
            NapelemDbContext context = new();

            return context.Arucikk.ToList();
        }

        public int GetPrizeFromName(string name)
        {
            try
            {
                NapelemDbContext context = new();

                var data = context.Arucikk
                    .Single(row => row.Arucikknev == name);

                return data.Price;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool Add(Polc polc)
        {
            try
            {
                /* Adatbázis kapcsolat, hogy hozzá lehessen adni az
                   `Polc` nevű táblához egy új rekordot. */
                NapelemDbContext context = new();


                /* utolso sor utolso oszlop utolso rekeszet megkeresem 
                    ami eddig a raktarban mar foglalt */

                

                if (context.Polc.ToList().Count < 0)
                {
                    polc.Column = 1;
                    polc.Row = 1;
                    polc.Level = 1;
                }
                else
                {
                    int maxColumn = context.Polc.Max(p => p.Column);
                    
                    int maxRow = context.Polc.Max(p => p.Row);
                    int maxLevel = context.Polc.Max(p => p.Level);
                    
                    /* a polc amit kapunk parameterben csak az ItemNamet es a mennyiseget tartalmazza
                         azt hogy hol szeretnenk eltarolni az alkatreszt meg itt kell kiszamolni es hozzaadni
                        az objektumhoz */

                    /* ezt a reszet meg at kell irni --> normalisan kene megkeresni a kovi 
                        szabad rekeszt !!!!!!!! */

                    polc.Column = maxColumn + 1;
                    polc.Row = maxRow + 1;
                    
                    polc.Level = maxLevel + 1;

                }
                /* Az `Add()` metódust alkalmazva a paraméterben megadott
                   `Polc` objektummal a hozzáadás egyszerűen
                   megtörténik. A `SaveChanges` után hajtódik végre. */

                //List<Polc> raktar = context.Polc.ToList();

                //context.Polc.Add(new PolcViewModel { Row = polc.Row, Column = polc.Column, Level = polc.Level, ItemsInShelf = polc.ItemsInShelf, ItemName = polc.Arucikk.Arucikknev });
                context.Polc.Add(polc);
                context.SaveChanges();

                /* Sikeresen lefutott a metódus, adjon vissza igaz értéket. */
                return true;
            }
            catch (Exception ex)
            {
                /* Hiba, vagy kivétel esetén adjon vissza hamis értéket. */
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
