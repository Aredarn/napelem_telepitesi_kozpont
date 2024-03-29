﻿using System;
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

        public List<UjArucikkIgeny> GetMissingItems()
        {
            NapelemDbContext context = new();

            return context.ujArucikkIgeny.ToList();
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

                bool foglalt = true;

                //var customers = context.Customers.Where(x => customerIds.Contains(x.CustomerID)).ToList();
                var keresett = context.Polc.Where(x => x.Row == polc.Row && x.Column == polc.Column && x.Level == polc.Level).ToList();
                if (keresett.Count == 0)
                {
                    // üres a polc
                    foglalt = false;
                    
                }

                if (foglalt)
                {
                    MessageBox.Show("Ez a polc már foglalt.\n Válassz másikat!");
                }
                else
                {
                    context.Polc.Add(polc);
                    context.SaveChanges();
                    MessageBox.Show("Az alkatrész felvétele a raktárba sikeresen megtörtént!");
                }
                /* Az `Add()` metódust alkalmazva a paraméterben megadott
                   `Polc` objektummal a hozzáadás egyszerűen
                   megtörténik. A `SaveChanges` után hajtódik végre. */

                //List<Polc> raktar = context.Polc.ToList();

                //context.Polc.Add(new PolcViewModel { Row = polc.Row, Column = polc.Column, Level = polc.Level, ItemsInShelf = polc.ItemsInShelf, ItemName = polc.Arucikk.Arucikknev });

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

        public List<AlkatreszViewModel> AlkatreszListaLekerese()
        {
            try
            {
                NapelemDbContext context = new();

                /* Arucikk es Polc tabla joinolasa -- kiiratashoz ViewModel hasznalata */

                List<AlkatreszViewModel> alkatreszek = context.Arucikk
                    .Join(context.Polc,
                          polc => polc.ArucikkID,
                          arucikk => arucikk.ArucikkID,
                          (arucikk, polc) => new {
                              arucikk.ArucikkID,
                              arucikk.Arucikknev,
                              arucikk.Price,
                              polc.ItemsInShelf
                          })
                        .Select(result => new AlkatreszViewModel
                        {
                            AlkatreszID = result.ArucikkID,
                            AlkatreszNev = result.Arucikknev,
                            Ar = result.Price,
                            Raktaron = result.ItemsInShelf
                        }).ToList();

                return alkatreszek;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

                return new List<AlkatreszViewModel>();
            }
        }

        public Dictionary<string, int> GetMissingReservedItems()
        {
            try
            {
                NapelemDbContext context = new();

                // meg kell nezni hogy a projektek arucikkekhez tabla 
                // IsReserved == true elemei teljesithetoek-e a raktarbol
                // ha nem akkor kell oket kilistazni

                List<ProjektArucikkhez> igenyek = context.ProjektekArucikkhez.ToList();
                List<Polc> raktaron = context.Polc.ToList();

                // alkatreszviewmodel "raktaron" reszebe fogom rakni amennyi meg kell belole
                Dictionary<string, int> hianyoznak = new Dictionary<string, int>();
                //MessageBox.Show("pls");

                // vegigmegyek az igenyeken
                foreach (var igeny in igenyek)
                {
                    // ha le van foglalva akkor megnezem hogy van-e a raktarban annyi kapacitas
                    if (igeny.IsReserved)
                    {
                        int db = 0; //osszesen mennyi ilyen termek van a raktarban
                        var keresettAru = context.Arucikk.Find(igeny.ArucikkID);
                        string arunev = ""; 
                        if (keresettAru != null)
                        {
                            arunev = keresettAru.Arucikknev;
                            // alapjaraton 0-val adom hozza a hianyzast
                            // hianyoznak.Add(keresettAru, 0);
                            //MessageBox.Show("megtalalta az arucikket");
                            foreach (var raktar in raktaron)
                            {
                                // ha a raktarban van ugyanolyan id-val arucikk, akkor 
                                // a hozza tartozo itemsinshelf adattagot hozzaadjuk a db-hoz
                                if (raktar.ArucikkID == igeny.ArucikkID)
                                {
                                    db += raktar.ItemsInShelf;
                                }
                            }
                            //MessageBox.Show(db.ToString());
                            // megnezem hogy az igenyelt mennyiseg kevesebb-e mint amennyi van a raktarban
                            if (igeny.Quantity > db)
                            {
                                if (!hianyoznak.ContainsKey(arunev)) // ha nincs meg benne hozzaadjuk
                                {
                                    hianyoznak.Add(keresettAru.Arucikknev, igeny.Quantity);
                                }
                                //MessageBox.Show(hianyoznak.Keys.First());
                            }
                        }
                    }
                }
                return hianyoznak;
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return new Dictionary<string, int>();
            }
        }
    }
    public class AlkatreszViewModel
    {
        public int AlkatreszID { get; set; }
        public string AlkatreszNev { get; set; }
        public int Ar { get; set; }
        public int Raktaron { get; set; }
        
    }
}
