using Microsoft.VisualBasic.ApplicationServices;
using napelem_telepito_kozpont.Backend.DatabaseConnection;
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



    }
}
