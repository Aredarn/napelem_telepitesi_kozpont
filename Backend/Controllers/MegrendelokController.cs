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
    public class MegrendelokController
    {
        public int MegrendeloHozzaadasa(Megrendelo megrendelo)
        {
            try
            {
                NapelemDbContext context = new();

                context.Megrendelok.Add(megrendelo);
                context.SaveChanges();

                return megrendelo.ClientID;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

                return 0;
            }

        }
    }
}
