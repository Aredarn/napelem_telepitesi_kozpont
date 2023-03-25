using Microsoft.VisualBasic.ApplicationServices;
using napelem_telepito_kozpont.Backend.DatabaseConnection;
using napelem_telepito_kozpont.Backend.Modells_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace napelem_telepito_kozpont.Backend.Controllers
{
    public class SingelTableQueries
    {

        //Összes USER-t visszaadja egy listában.
        public void GetUsers()
        {
            using (var context = new NapelemDbContext())
            {
                //return context.Users.ToList();
            }
        }


        //Az 'AddNewItem' függvény 3 paramétert vár feltehetőleg textboxokból,
        //visszatérési értéke string, hogy a képernyőre kiírja a funkció sikerességét, sikertelenségét
        //Megnézi hogy a beírt Árucikknév létezik-e az adatbázisban és ha nem hozzáadja
        public string AddNewItem(string name, int price, int maxonshelf)
        {
            try
            {
                using (var context = new NapelemDbContext()) {
                
                    if (!context.Arucikk.Any(i=>i.Arucikknev == name))
                    {
                        var ItemToSave = new Arucikk { Arucikknev= name, Price = price,MaxOnShelf = maxonshelf };
                        context.Arucikk.Add(ItemToSave);
                        context.SaveChanges();
                        return ("Sikeres árucikk felvétel");
                    }              
                    else
                    {
                        return ($"A(z) {name} nevű árucikk már létezik");
                    }
            }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }


        // A függvény megváltoztatja egy létező termék árát. Két paramétert vár, az árucikk nevét és új árát
        
        public string ModifyItemPrice(string name, int newprice)
        {
            try
            {
                using (var context = new NapelemDbContext())
                {
                    var item = context.Arucikk.FirstOrDefault(i => i.Arucikknev == name);
                    if (item != null)
                    {
                        item.Price = newprice;
                        context.SaveChanges();
                        return $"A(z) '{name}' nevű árucikk ára: {newprice}. módosítva";
                    }
                    else
                    {
                        return $"{name} nevű árucikk nem található.";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }



    }
}
