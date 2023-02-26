using Microsoft.EntityFrameworkCore;
using napelem_telepito_kozpont.DataLayer.Database;
using napelem_telepito_kozpont.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelem_telepito_kozpont.DataLayer.Repositories
{
    public class CatParadiseRepository
    {

        public void CreateCat()
        {
            using (var context = new CatParadiseDbContext())
            {
                context.Cats.Add(new Cat() { Name = "Jack", Bio = "A few things about me. My most distinguished trait is my unmatched modesty. I strive to be the humble-est mother fucker out there. Consequently, I am also like, the best cat to ever grace this planet. Did I also tell you that I posess the most advanced neuron pathways ever conceivable? Sí, eso es la verdad."});
                context.SaveChanges();
            }
            
        }

        public void CreateCatHotel()
        {
            using (var context = new CatParadiseDbContext())
            {
                context.Hotels.Add(new CatHotel() { HotelName = "El Hotel Gato", Location = "Something street Any Number" });
                context.SaveChanges();
            }

        }

        public List<Cat> GetCats()
        {
            using (var context = new CatParadiseDbContext())
            {
                return context.Cats.ToList();
            }
        }

    }
}
