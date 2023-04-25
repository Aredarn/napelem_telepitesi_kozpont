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
    public class ProjektController
    {
        public bool ProjektLetrehozasa(Projektek projekt)
        {
            try
            {
                NapelemDbContext context = new();

                context.Projekt.Add(projekt);
                context.SaveChanges();

                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

                return false;
            }

        }
    }
}
